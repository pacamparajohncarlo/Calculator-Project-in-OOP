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
        string firstvar = "";
        string secondvar = "";
        char function;
        double result = 0.0;
        string calcInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "1";
            textnumdisplay.Text = calcInput;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            textnumdisplay.Text.Remove();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttondcml_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(textnumdisplay.Text);
            operation = true;
        }

        private void Cancel_onesymbol_Click(object sender, EventArgs e)
        {
            if (textnumdisplay.Text.Length > 0) ;
            {
                textnumdisplay.Text = textnumdisplay.Text.Remove(textnumdisplay.Text.Length - 1, 1);
            }
        }

        private void Buttondcml_Click_1(object sender, EventArgs e)
        {
            Buttoncml_Click.text = Buttoncml_Click.text + ".";
        }

        private void Buttondcml_Click_2(object sender, EventArgs e)
        {
   
        }

        private void Buttonmultiply_Click(object sender, EventArgs e)
        {
            function = "x";
            firstvar = calcInput;
            calcInput = "";
        }

        private void Buttonsubtract_Click(object sender, EventArgs e)
        {
            function = "-";
            firstvar = calcInput;
            calcInput = "";
        }

        private void Buttonadd_Click(object sender, EventArgs e)
        {
            function = "+";
            firstvar = calcInput;
            calcInput = "";
        }

        private void Buttondivide_Click(object sender, EventArgs e)
        {
            function = "/";
            firstvar = calcInput;
            calcInput = "";
        }

        private void Buttonequal_Click(object sender, EventArgs e)
        {
            secondvar = calcInput;
            double firstvar, secondvar;
            firstvar = Convert.ToDouble(first);
            secondvar = Convert.ToDouble(second);
            //Operation
            //Addition
            if function == "+";
        }

        private void Buttonzero_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "0";
            textnumdisplay.Text = calcInput;
        }

        private void Buttontwo_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "2";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonthree_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "3";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonfour_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "4";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonfive_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "5";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonsix_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "6";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonseven_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "7";
            textnumdisplay.Text = calcInput;
        }

        private void Buttoneight_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "8";
            textnumdisplay.Text = calcInput;
        }

        private void Buttonnine_Click(object sender, EventArgs e)
        {
            textnumdisplay.Tex = "";
            calcInput = "9";
            textnumdisplay.Text = calcInput;
        }
    }
}
