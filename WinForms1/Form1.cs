using System;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Наземный");
            comboBox1.Items.Add("Водный");
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                textBox1.Visible = true;
            }
        }
    }
}
