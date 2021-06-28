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
        Double val = 0;
        String text = "";
        bool operation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textnumdisplay.Text == "0")||(operation))
            {
                textnumdisplay.Clear();
            }
            Button button = (Button)sender;
            textnumdisplay.Text = textnumdisplay.Text + button.Text;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            textnumdisplay.Clear();
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
        }
    }
}
