using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void msgLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {                      
            try
            {
                double input = double.Parse(txtBoxInput.Text);
                msgLabel.Text = $"10% of {input} is {0.1 * input}";
            }
            catch
            {
                //Regex r = new Regex("^[a-zA-Z]*$");
                Match match = Regex.Match(txtBoxInput.Text, "^[a-zA-Z]*$");


                if (txtBoxInput.Text == "" || match.Success == true )
                {                   
                    msgLabel.BackColor = Color.Azure;
                    msgLabel.Text = "Please Enter a valid integer";
                }
            }            
        }

        private void msgLabel_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
