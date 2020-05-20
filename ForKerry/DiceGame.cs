using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    
    public partial class Form1 : Form
    {
        decimal money = 20m;
        
        public Form1()
        {
            InitializeComponent();
            textBoxMoney.Text = money.ToString("C");
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            decimal bet;
            int PD1, PD2, PD3, CD1, CD2, CD3;
            textBoxPD1.Text = "";
            textBoxPD2.Text = "";
            textBoxPD3.Text = "";
            textBoxCD1.Text = "";
            textBoxCD2.Text = "";
            textBoxCD3.Text = "";

            

            if (decimal.TryParse(textBoxBet.Text, out bet))
            {
                if (bet > money)
                {
                    MessageBox.Show("You do not have enough money to place this bet!");

                }
                if (bet <= 0)
                    MessageBox.Show("You can't bet that amount!");
                else
                {
                    Random rand = new Random();
                    PD1 = rand.Next(7) + 1;
                    PD2 = rand.Next(7) + 1;
                    PD3 = rand.Next(7) + 1;
                    CD1 = rand.Next(7) + 1;
                    CD2 = rand.Next(7) + 1;
                    CD3 = rand.Next(7) + 1;

                    textBoxPD1.Text = PD1.ToString();
                    textBoxPD2.Text = PD2.ToString();
                    textBoxPD3.Text = PD3.ToString();
                    textBoxCD1.Text = CD1.ToString();
                    textBoxCD2.Text = CD2.ToString();
                    textBoxCD3.Text = CD3.ToString();

                    if (PD1 + PD2 + PD3 > CD1 + CD2 + CD3)
                    {
                        MessageBox.Show("You win this round!");
                        money += bet;
                        textBoxMoney.Text = money.ToString("C");
                    }
                    else if (PD1 + PD2 + PD3 == CD1 + CD2 + CD3)
                    {
                        MessageBox.Show("It's a draw this round!");
                        textBoxMoney.Text = money.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("You lose this round!");
                        money -= bet;
                        textBoxMoney.Text = money.ToString("C");
                    }

                    if (money <= 0)
                    {
                        MessageBox.Show("You have lost the game!");
                        Application.Restart();
                    }
                    if (money >= 50)
                    {
                        MessageBox.Show("You win the game!");
                        Application.Restart();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
    }
}
