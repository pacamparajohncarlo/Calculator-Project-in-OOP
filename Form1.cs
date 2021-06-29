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
            if ((textnumdisplay.Text == "0");
            {
                textnumdisplay.Clear();
            }
            Button button = (Button)sender;
            textnumdisplay.Text = textnumdisplay.Text + button.Text;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            textnumdisplay.Clear();
            calcInput = "0";
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
        }

        private void Buttonsubtract_Click(object sender, EventArgs e)
        {
            function = "-";
        }

        private void Buttonadd_Click(object sender, EventArgs e)
        {
            function = "+";
        }

        private void Buttondivide_Click(object sender, EventArgs e)
        {
            function = "/";
        }
    }
}
