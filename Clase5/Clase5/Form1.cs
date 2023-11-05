using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valueWeek = Convert.ToInt32(textBox1.Text);
            label2.Text = label2.Text + " " + WeekDay(valueWeek);
           

        }

        public string WeekDay ( int valueWeek)
        {
            string Day = " ";

            switch ( valueWeek)
            {
                case 1:
                    Day = "Sunday";
                    break;
                case 2:
                    Day = "Monday";
                    break;
                case 3:
                    Day = "Tuesday";
                    break;
                case 4:
                    Day = "Wednesday";
                    break;
                case 5:
                    Day = "Thursday";
                    break;
                case 6:
                    Day = "Friday";
                    break;
                case 7:
                    Day = "Saturday";
                    break;
                default:
                    Day = "The number is not a day of the week.";
                    break;
            }

            return Day;
        }
    }
}
