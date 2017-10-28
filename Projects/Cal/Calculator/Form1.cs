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
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtDisplay.Text);
            double KQ;
            if(sign == "+") //Cong
            {
                KQ = val1 + val2;
                txtDisplay.Text = KQ.ToString();
            }
            else if (sign == "-") //Tru
            {
                KQ = val1 - val2;
                txtDisplay.Text = KQ.ToString();
            }
            else if (sign == "*")  //Nhan
            {
                KQ = val1 * val2;
                txtDisplay.Text = KQ.ToString();
            }
            else if (sign == "/") //Chia
            {
                KQ = val1 / val2;
                txtDisplay.Text = KQ.ToString();
            }
            else if (sign == "√") //Can
            {
                KQ = Math.Sqrt(val2);
                txtDisplay.Text = KQ.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            if (keycode >= 48 && keycode <= 57 || keycode == 0 || keycode == 32 || keycode == 46)
                {
                if (keycode == 46) ++trackkeypoint;
                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }
            }
            else e.Handled = true;
        }

        private void btnThapPhan_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Format("{0:0.0}", double.Parse(txtDisplay.Text));
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            sign = "√";
            val1 = double.Parse(txtDisplay.Text);
            txtDisplay.Text = ""; 
        }
    }
}
