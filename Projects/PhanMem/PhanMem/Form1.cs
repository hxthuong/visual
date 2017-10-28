using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMem
{
    public partial class Form1 : Form
    {
        static String ConString = 
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxdbtc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxcqtc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection data = new SqlConnection(ConfigurationM)
        }
    }
}
