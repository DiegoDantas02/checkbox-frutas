using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Escolher_Click(object sender, EventArgs e)
        {
            string txt = "";
            if(checkBox1.Checked)
            {
                txt += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                txt += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                txt += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                txt = checkBox4.Text + ", ";
            }
            if (checkBox5.Checked)
            {
                txt = checkBox5.Text + ", ";
            }
            if (checkBox6.Checked)
            {
                txt = checkBox6.Text + ", ";
            }

            MessageBox.Show("A Marca Escolhida foi: " + txt, "A Marca escolhida foi...");
        }
    }
}
