using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smokies
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            decimal smoke;
            decimal day;
            decimal week;
            decimal month;
            decimal year;
            decimal smokes;
            decimal ten;
            double life, lifeDay, lifeWeek, lifeMonth, lifeYear;

            try
            {
                smoke = decimal.Parse(textSmoke.Text);
                smokes = (decimal)smoke;
                const decimal COST = 26.90m / 20.00m;
                const double LIFE = 11;
                life = (double)smoke;
                

                day = smoke * COST;
                week = day * 7m;
                month = day * 30.5m;
                year = day * 364.25m;
                ten = year * 10m;

                lifeDay = life * LIFE;
                lifeWeek = lifeDay * 7;
                lifeMonth = lifeDay * 30.5;
                lifeYear = lifeDay * 364.25;


                textLifeDay.Text = lifeDay.ToString();
                textLifeWeek.Text = lifeWeek.ToString();
                textLifeMonth.Text = lifeMonth.ToString();
                textLifeYear.Text = lifeYear.ToString();

                textToday.Text = day.ToString("C");
                textWeek.Text = week.ToString("C");
                textMonth.Text = month.ToString("C");
                textYear.Text = year.ToString("C");





                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
