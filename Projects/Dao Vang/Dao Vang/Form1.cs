using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace Dao_Vang
{
    public partial class Form1 : Form
    {
     //   int speedLeft = 10;
        int speedTop = 10;
        bool down = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDem.Enabled = true;
        }

        private void tmrDem_Tick(object sender, EventArgs e)
        {
            pbxClaw.Location = new Point(pbxClaw.Location.X + 10, pbxClaw.Location.Y);
            if (pbxClaw.Location.X >= 600)
                pbxClaw.Location = new Point(pbxClaw.Location.X - 600, pbxClaw.Location.Y);
            Tha();

        }
        public void Tha() // thả ngoàm xuống
        {
            if (down == true)
            {
                pbxClaw.Top += speedTop;
                pbxClaw.Left -= 10;
                if (pbxClaw.Bottom >= this.Bottom)
                {
                  speedTop = -speedTop;
                }
                else
                    speedTop += 3;
            }

        }   
        private void btnQuit_Click(object sender, EventArgs e) //Thoát game
        {
            if (MessageBox.Show("Bạn có muốn lưu điểm không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Save();
        }
        public void Save() //Lưu điểm
        {
            SavePoint sp = new SavePoint();
            sp.Show();
            this.Hide();
            tmrDem.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                down = true;
        }
    }
}
