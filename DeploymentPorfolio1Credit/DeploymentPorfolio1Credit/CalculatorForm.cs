using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeploymentPorfolio1Credit
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }



        private void plusButton_Click(object sender, EventArgs e)
        {
            if ((num1.Text == "") || (num2.Text == ""))
            {
                MessageBox.Show("Please enter numbers.");
            }
            else
            {
                float number1 = float.Parse(num1.Text);
                float number2 = float.Parse(num2.Text);
                string result = (number1 + number2).ToString();

                MessageBox.Show("Result = " + result);
            }

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if ((num1.Text == "") || (num2.Text == ""))
            {
                MessageBox.Show("Please enter numbers.");
            }
            else
            {
                float number1 = float.Parse(num1.Text);
                float number2 = float.Parse(num2.Text);
                string result = (number1 - number2).ToString();

                MessageBox.Show("Result = " + result);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if ((num1.Text == "") || (num2.Text == ""))
            {
                MessageBox.Show("Please enter numbers.");
            }
            else
            {
                float number1 = float.Parse(num1.Text);
                float number2 = float.Parse(num2.Text);
                string result = (number1 * number2).ToString();

                MessageBox.Show("Result = " + result);
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if ((num1.Text == "") || (num2.Text == ""))
            {
                MessageBox.Show("Please enter numbers.");
            }
            else
            {
                float number1 = float.Parse(num1.Text);
                float number2 = float.Parse(num2.Text);
                string result = (Math.Round((number1 / number2), 2)).ToString();

                MessageBox.Show("Result = " + result);
            }
        }

        private void num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void calcButton_Click(object sender, EventArgs e)
        {

        }
    }
}
