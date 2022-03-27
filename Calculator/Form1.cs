using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double opr1 = 0;
        private double opr2 = 0;
        private bool plus = false;
        private bool minus = false;
        private bool mul = false;
        private bool div = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="0")
            {
                textBox2.Text = "0";
                textBox1.Text = "0";
            }
            else
            {
                textBox2.Text = textBox2.Text+"0";
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "1";
                textBox1.Text = "1";
            }
            else
            {
                textBox2.Text = textBox2.Text + "1";
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "2";
                textBox1.Text = "2";
            }
            else
            {
                textBox2.Text = textBox1.Text + "2";
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "3";
                textBox1.Text = "3";
            }
            else
            {
                textBox2.Text = textBox1.Text + "3";
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "4";
                textBox1.Text = "4";
            }
            else
            {
                textBox2.Text = textBox2.Text + "4";
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "5";
                textBox1.Text = "5";
            }
            else
            {
                textBox2.Text = textBox2.Text + "5";
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "6";
                textBox1.Text = "6";
            }
            else
            {
                textBox2.Text = textBox2.Text + "6";
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "7";
                textBox1.Text = "7";
            }
            else
            {
                textBox2.Text = textBox2.Text + "7";
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "8";
                textBox1.Text = "8";
            }
            else
            {
                textBox2.Text = textBox2.Text + "8";
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "9";
                textBox1.Text = "9";
            }
            else
            {
                textBox2.Text = textBox1.Text + "9";
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void bd2_Click(object sender, EventArgs e)
        {
            int len = textBox2.Text.Length;
            string txt = textBox2.Text;
            bool chk = false;
            for(int i = 0; i < len; i++)
            {
                if (txt[i] == '.')
                    chk = true;
            }
            if (textBox2.Text == "0")
                textBox2.Text = "0.";
            else if(chk == true)
                textBox2.Text = textBox2.Text;
            else
                textBox2.Text = textBox2.Text + ".";
        }

        private void bd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text ="";
            textBox2.Text = "0";
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            string txt = textBox2.Text;
            string txt1 = string.Empty;
            int len = txt.Length;
            for (int i = 0; i < len - 1; i++)
            {
                txt1 = txt1 + txt[i];
            }
            textBox2.Text = txt1;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text == "0")
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text+"+";
                textBox2.Text = "";
            }
            plus = true;
            minus = false;
            mul = false;
            div = false;
    }

        private void beq_Click(object sender, EventArgs e)
        {
            opr2 = Convert.ToDouble(textBox2.Text);
            if (plus == true)
                textBox2.Text = Convert.ToString(opr1 + opr2);
            else if(minus == true)
                textBox2.Text = Convert.ToString(opr1 - opr2);
            else if (mul == true)
                textBox2.Text = Convert.ToString(opr1 * opr2);
            else if (div == true && opr2 != 0)
                textBox2.Text = Convert.ToString(opr1 / opr2);
            else if (div == true && opr2==0)
                textBox2.Text = "Undefined";
        }
        private void bmin_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text == "0")
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text + "-";
                textBox2.Text = "";
            }
            plus = false;
            minus = true;
            mul = false;
            div = false;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text == "0")
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text + "x";
                textBox2.Text = "";
            }
            plus=false;
            minus = false;
            mul = true;
            div = false;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(textBox2.Text);
            if (textBox2.Text == "0")
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            else
            {
                textBox1.Text = textBox1.Text + "/";
                textBox2.Text = "";
            }
            plus = false;
            minus = false;
            mul = false;
            div = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
