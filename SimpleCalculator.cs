using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class SimpleCalculator : Form
    {
        private string operation = "";
        private double result = 0;
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(result != 0 && operation != "")
            {
                txtDisplay.Text = (result * double.Parse(txtDisplay.Text) / 100).ToString();
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e) // Clear Entry Button
        {
            txtDisplay.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // Clear All Button
        {
            result = 0;
            txtDisplay.Clear();
            inputBox.Clear();
            operation = "";
        }

        private void button4_Click(object sender, EventArgs e) // Remove Button
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void resultReverseBtn_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtDisplay.Text) < 0)
            {
                txtDisplay.Text = Math.Abs(double.Parse(txtDisplay.Text)).ToString();
            }
            else if(double.Parse(txtDisplay.Text) > 0)
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void numberBtn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void numberBtn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void numberBtn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void numberBtn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void numberBtn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void numberBtn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void numberBtn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void numberBtn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void numberBtn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void periodBtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }

        private void summationBtn_Click(object sender, EventArgs e)
        {
            operation = "+";
            result = double.Parse(txtDisplay.Text);
            inputBox.Text = result + operation;
            txtDisplay.Clear();
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            operation = "-";
            result = double.Parse(txtDisplay.Text);
            inputBox.Text = result + operation;
            txtDisplay.Clear();
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            operation = "*";
            result = double.Parse(txtDisplay.Text);
            inputBox.Text = result + operation;
            txtDisplay.Clear();
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            operation = "/";
            result = double.Parse(txtDisplay.Text);
            inputBox.Text = result + operation;
            txtDisplay.Clear();
        }

        private void rootBtn_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtDisplay.Text) > 0)
            {
                txtDisplay.Text = Math.Sqrt(double.Parse(txtDisplay.Text)).ToString();
            }
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0) 
            {
                txtDisplay.Text = (double.Parse(txtDisplay.Text)* double.Parse(txtDisplay.Text)).ToString();
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void resultBtn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    inputBox.Text += txtDisplay.Text;
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text += txtDisplay.Text;
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    inputBox.Text += txtDisplay.Text;
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    inputBox.Text += txtDisplay.Text;
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void reciprocalBtn_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = (1/(double.Parse(txtDisplay.Text))).ToString();
            }
        }
    }
}
