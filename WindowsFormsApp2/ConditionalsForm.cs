using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ConditionalsForm : Form
    {
        public ConditionalsForm()
        {
            InitializeComponent();
        }


        private float determineEquivalentGrade(int num)
        {
            if (num >= 0 || num <= 100)
            {
                if (num < 50)
                {
                    return 5.00f;
                }
                else if (num < 55.49)
                {
                    return 3.00f;
                }
                else if (num < 60.99)
                {
                    return 2.75f;
                }
                else if (num < 65.49)
                {
                    return 2.50f;
                }
                else if (num < 71.99)
                {
                    return 2.25f;
                }
                else if (num < 77.49)
                {
                    return 2.00f;
                }
                else if (num < 82.99)
                {
                    return 1.75f;
                }
                else if (num < 88.49)
                {
                    return 1.50f;
                }
                else if (num < 93.99)
                {
                    return 1.25f;
                }
                else {
                    return 1.00f;
                }
            }
            else
            {
                return 0.0f;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grade = textBox1.Text;
            float res = determineEquivalentGrade(int.Parse(textBox1.Text));
            result.Text = grade + " is equivalent to " + res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MenuPage().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int day;

            if (int.TryParse(textBox2.Text, out day))
            {
                if (day >= 1 && day <= 7)
                {
                    string res = DetermineWeekName(day);
                    weekResult.Text = res;
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 7.", "Invalid Day", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string DetermineWeekName(int day)
        {
            switch (day)
            {
                case 1: return "Sunday";
                case 2: return "Monday";
                case 3: return "Tuesday";
                case 4: return "Wednesday";
                case 5: return "Thursday";
                case 6: return "Friday";
                case 7: return "Saturday";
                default: return "Invalid day";
            }
        }

    }
}
