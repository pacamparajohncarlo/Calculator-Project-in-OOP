using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        calcclass calc = new calcclass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "1";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttondcml_Click(object sender, EventArgs e)
        {

        }

        private void Buttondcml_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Buttondcml_Click_2(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += ".";
            textnumdisplay.Text += calc.calcInput;
        }
          
        private void Buttonmultiply_Click(object sender, EventArgs e)
        {
            calc.function = '*';
            calc.firstvar = calc.calcInput;
            calc.calcInput = "";
        }

        private void Buttonsubtract_Click(object sender, EventArgs e)
        {
            calc.function = '-';
            calc.firstvar = calc.calcInput;
            calc.calcInput = "";
        }

        private void Buttonadd_Click(object sender, EventArgs e)
        {
            calc.function = '+';
            calc.firstvar = calc.calcInput;
            calc.calcInput = "";
        }

        private void Buttondivide_Click(object sender, EventArgs e)
        {
            calc.function = '/';
            calc.firstvar = calc.calcInput;
            calc.calcInput = "";
        }

        private void Buttonequal_Click(object sender, EventArgs e)
        {
            calc.secondvar = calc.calcInput;
            double firstnumber, secondnumber;
            firstnumber = Convert.ToDouble(calc.firstvar);
            secondnumber = Convert.ToDouble(calc.secondvar);
            //Operation
            //Addition
            if (calc.function == '+')
            {
                calc.result = firstnumber + secondnumber;
                textnumdisplay.Text = calc.result.ToString();
            }
            //Subtraction
            else if (calc.function == '-')
            {
                calc.result = firstnumber - secondnumber;
                textnumdisplay.Text = calc.result.ToString();
            }
            //Multiplication
            else if (calc.function == '*')
            {
                calc.result = firstnumber * secondnumber;
                textnumdisplay.Text = calc.result.ToString();
            }
            //Division
            else if (calc.function == '/')
            {
                if (secondnumber == '0')
                {
                    textnumdisplay.Text = "Syntax Error";
                }
                else
                {
                    calc.result = firstnumber / secondnumber;
                    textnumdisplay.Text = calc.result.ToString();
                } 
            }
        }

        private void Buttonzero_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "0";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttontwo_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "2";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonthree_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "3";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonfour_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "4";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonfive_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "5";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonsix_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "6";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonseven_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "7";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttoneight_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "8";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonnine_Click(object sender, EventArgs e)
        {
            textnumdisplay.Text = "";
            calc.calcInput += "9";
            textnumdisplay.Text += calc.calcInput;
        }

        private void Buttonclear_Click(object sender, EventArgs e)
        {
            calc.firstvar = "";
            calc.secondvar = "";
            calc.calcInput = "";
            calc.result = 0.0;
            textnumdisplay.Text = "0";
        }
    }
}
