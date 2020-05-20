using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        int speed = 3;
        int ballx = 10;
        int bally = 5;
        int score = 0;
        int cpuPoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuLabel.Text = "" + cpuPoint;

            ball.Top -= bally;
            ball.Left -= ballx;

            cpu.Top += speed;

            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 360)
                {
                    //change direction
                    speed = -speed;
                }
            }
            else
            {
                //make game harder
                cpu.Top = ball.Top + 30;
            }

            //Scoring
            if (ball.Left < 0)
            {
                ball.Left = 434; //reset ball
                ballx = -ballx; //change dir
                cpuPoint++; 
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                score++;
            }
            //ball control
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }
            
            //if ball collides
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }

            //Player control
            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }

            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }

        }

    }
    
}
