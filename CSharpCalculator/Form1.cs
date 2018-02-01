using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculator
{
    public partial class Form1 : Form
    {
        // last opelator
        string lastOpe;
        // to keep the num 
        double memToKeep;
        // how many times user used opelator
        int counter = 0;
        // how many times user used point in a equation
        int pointCount = 0;


        //  i got error if i click every opelator 2times in a row
        // so if user click the opelator, this counter would be increased
        int ucantClickTwiceInARow = 0;

        public Form1()
        {
            InitializeComponent();
        }

        

        // clear button
        private void button19_Click(object sender, EventArgs e)
        {
            clearText();
        }

        // function ClearTextBox(initialization)
        public void clearText()
        {
            textBox1.Clear();
            memToKeep = 0;
            lastOpe = "";
            textBox1.Text = "0";
            counter = 0;
            ucantClickTwiceInARow = 0;
        }

        // button 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "1";
            ucantClickTwiceInARow = 0;

        }

        // button 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "2";
            ucantClickTwiceInARow = 0;
        }

        // button 3
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "3";
            ucantClickTwiceInARow = 0;
        }

        // button 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "4";
            ucantClickTwiceInARow = 0;
        }

        // button 5
        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "5";
            ucantClickTwiceInARow = 0;
        }

        // button 6
        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "6";
            ucantClickTwiceInARow = 0;
        }

        // button 7
        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "7";
            ucantClickTwiceInARow = 0;
        }

        // button 8
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "8";
            ucantClickTwiceInARow = 0;
        }

        // button 9
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }

            textBox1.Text += "9";
            ucantClickTwiceInARow = 0;
        }

        // button 0
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                textBox1.Clear();
            }
            textBox1.Text += "0";
            ucantClickTwiceInARow = 0;

        }

        // plus button
        private void button13_Click(object sender, EventArgs e)
        {
            counter++;
            ucantClickTwiceInARow++;

            if(ucantClickTwiceInARow >= 2)
            {
                return;
            }

            if (counter >= 2)
            {
                if(lastOpe == "+")
                {
                    memToKeep += Convert.ToDouble(textBox1.Text);
                }
                else if(lastOpe == "-")
                {
                    memToKeep -= Convert.ToDouble(textBox1.Text);
                }
                else if(lastOpe == "*")
                {
                    memToKeep = memToKeep * Convert.ToDouble(textBox1.Text);
                }
                else if(lastOpe == "/")
                {
                    memToKeep = memToKeep / Convert.ToDouble(textBox1.Text);
                }
            }
            else
            {
                // If user uses OPE first time
                memToKeep = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Clear();
            lastOpe = "+";
            pointCount = 0;

        }

        // equal button
        private void button12_Click(object sender, EventArgs e)
        {

            //  check
            if (counter == 0)
            {
                return;
            }

            if (lastOpe == "+")
            {
                memToKeep += Convert.ToDouble(textBox1.Text);
                textBox1.Text = memToKeep.ToString(); 
            }
            else if (lastOpe == "-")
            {
                memToKeep -= Convert.ToDouble(textBox1.Text);
                textBox1.Text = memToKeep.ToString();
            }
            else if(lastOpe == "*")
            {
                memToKeep = memToKeep * Convert.ToDouble(textBox1.Text);
                textBox1.Text = memToKeep.ToString();
            }
            else if(lastOpe == "/")
            {
                memToKeep = memToKeep / Convert.ToDouble(textBox1.Text);
                textBox1.Text = memToKeep.ToString();
            }

            lastOpe = "";
            pointCount = 0;

        }

        // minus button
        private void button14_Click(object sender, EventArgs e)
        {
            counter++;
            ucantClickTwiceInARow++;

            if (ucantClickTwiceInARow >= 2)
            {
                return;
            }

            if (counter >= 2)
            {
                if (lastOpe == "+")
                {
                    memToKeep += Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "-")
                {
                    memToKeep -= Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "*")
                {
                    memToKeep = memToKeep * Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "/")
                {
                    memToKeep = memToKeep / Convert.ToDouble(textBox1.Text);
                }
            }
            else
            {
                // If user uses OPE first time
                memToKeep = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Clear();
            lastOpe = "-";
            pointCount = 0;

        }

        // maltiple
        private void button15_Click(object sender, EventArgs e)
        {
            counter++;
            ucantClickTwiceInARow++;

            if (ucantClickTwiceInARow >= 2)
            {
                return;
            }

            if (counter >= 2)
            {
                if (lastOpe == "+")
                {
                    memToKeep += Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "-")
                {
                    memToKeep -= Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "*")
                {
                    memToKeep = memToKeep * Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "/")
                {
                    memToKeep = memToKeep / Convert.ToDouble(textBox1.Text);
                }
            }
            else
            {
                // If user uses OPE first time
                memToKeep = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Clear();
            lastOpe = "*"; counter++;
            pointCount = 0;
        }

        // devide
        private void button16_Click(object sender, EventArgs e)
        {
            counter++;
            ucantClickTwiceInARow++;

            if (ucantClickTwiceInARow >= 2)
            {
                return;
            }

            if (counter >= 2)
            {
                if (lastOpe == "+")
                {
                    memToKeep += Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "-")
                {
                    memToKeep -= Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "*")
                {
                    memToKeep = memToKeep * Convert.ToDouble(textBox1.Text);
                }
                else if (lastOpe == "/")
                {
                    memToKeep = memToKeep / Convert.ToDouble(textBox1.Text);
                }
            }
            else
            {
                // If user uses OPE first time
                memToKeep = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Clear();
            lastOpe = "/";
            pointCount = 0;
        }

        // point 
        private void button11_Click(object sender, EventArgs e)
        {
            //  already used it
            if (pointCount == 1)
            {
                return;
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text += ".";
            }

            pointCount++;


        }

        // % button
        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                return;
            }

            double p;
            p = Convert.ToDouble(textBox1.Text) / 100;
            textBox1.Text = p.ToString();

            
        }

        // plus to minus(minus to plus) button
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }

            // plus
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                double a;
                a = Convert.ToDouble(textBox1.Text) * (-1);
                textBox1.Text = a.ToString();

            }

        }
    }
}
