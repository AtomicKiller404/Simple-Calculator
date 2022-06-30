using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            button1.Text = "7";
            button2.Text = "8";
            button3.Text = "9";
            button4.Text = "/";
            button5.Text = "CE";
            button6.Text = "4";
            button7.Text = "5";
            button8.Text = "6";
            button9.Text = "*";
            button10.Text = "C";
            button11.Text = "1";
            button12.Text = "2";
            button13.Text = "3";
            button14.Text = "-";
            button15.Text = "=";
            button16.Text = "0";
            button17.Text = ".";
            button18.Text = "+";

            label1.Text = null;
            label2.Text = "0";
        }

        bool first = true;
        char[] chSimbol = new char[2];
        private void calculate()
        {
            
            if (first)
            {
                chSimbol[0] = '+';
                first = false;
            }

            try
            {
                float fNumbOne = float.Parse(label1.Text.Remove(label1.Text.Length - 1));
                chSimbol[1] = label1.Text[label1.Text.Length - 1];
                float fResult = 0.0f;
                float fNumTwo = 0.0f;
                if (label2.Text != "0")
                {
                    fNumTwo = float.Parse(label2.Text.Remove(label2.Text.Length - 1));
                }
                else
                {
                    fNumTwo = float.Parse(label2.Text);
                }


                if (chSimbol[0] == '/')
                {
                    fResult = fNumTwo / fNumbOne;
                }
                else if (chSimbol[0] == '*')
                {
                    fResult = fNumTwo * fNumbOne;

                }
                else if (chSimbol[0] == '-')
                {
                    fResult = fNumTwo - fNumbOne;

                }
                else if (chSimbol[0] == '+')
                {
                    fResult = fNumTwo + fNumbOne;

                }
                else if(chSimbol[0] == '=')
                {
                    fResult = fNumbOne;
                }

                if (chSimbol[1] != '=')
                {
                    chSimbol[0] = chSimbol[1];
                    label2.Text = fResult.ToString() + chSimbol[1];
                    label1.Text = "";
                }
                else
                {
                    label1.Text = fResult.ToString();
                    label2.Text = "";
                }
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text += button18.Text;
            calculate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += ',';

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += button16.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += button15.Text;

            calculate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += button14.Text;
            calculate();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            label1.Text += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += button12.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += button11.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = null;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;

            calculate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = "0";
            first = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;

            calculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += button2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }
    }
}
