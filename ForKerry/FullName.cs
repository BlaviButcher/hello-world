using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This ones pretty basic. I think it was my first program lol
namespace Full_Name_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            string First;
            string Middle;
            string Last;
            string Full;

            First = textFirst.Text;
            Middle = textMiddle.Text;
            Last = textLast.Text;
            Full = First + " " + Middle + " " + Last;
            textFull.Text = Full;



        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textFirst.Text = "";
            textMiddle.Text = "";
            textLast.Text = "";
            textFull.Text = "";
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
