using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dao_Vang
{
    public partial class GoldMiner : Form
    {
        public GoldMiner()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 play = new Form1();
            play.Show();
            this.Hide();
        }
    }
}
