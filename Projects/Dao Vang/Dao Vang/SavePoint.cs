using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dao_Vang
{
    public partial class SavePoint : Form
    {
        public SavePoint()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GoldMiner gm = new GoldMiner();
            gm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e) //Lưu điểm thành tích vào file dsdiem.txt
        {
            StreamWriter writer = new StreamWriter("dsdiem.txt");  
            if (writer == null) return;
            foreach (var item in lstSavePoint.Items)
                writer.WriteLine(item.ToString());
            foreach (var items in lstName.Items)
                writer.WriteLine(items.ToString());
            writer.Close();
        }

        private void SavePoint_Load(object sender, EventArgs e) 
        {
            StreamReader reader = new StreamReader("dsdiem.txt"); //Hiển thị danh sách điểm thành tích
            if (reader == null) return;
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                lstName.Items.Add(input.Substring(0, 7));
                lstSavePoint.Items.Add(input.ToString().Substring(9));
                SapXep();
            }
            reader.Close();
        }
        public void SapXep() //Sắp xếp điểm thách tích từ lớn đến bé
        {
            if (lstSavePoint.Items.Count <= 1)
                return;
            for (int j = 0; j < lstSavePoint.Items.Count - 1; j++)
            {
                for (int i = 0; i < lstSavePoint.Items.Count - 1; i++)
                {
                    lstSavePoint.SetSelected(i, true);
                    string a = lstSavePoint.SelectedItem.ToString();
                    lstSavePoint.SetSelected(++i, true);
                    i--;
                    string b = lstSavePoint.SelectedItem.ToString();
                    if (b.CompareTo(a) == 1)
                    {
                        lstSavePoint.Items.RemoveAt(i);
                        lstSavePoint.Items.Insert(i, b);
                        i++;
                        lstSavePoint.Items.RemoveAt(i);
                        lstSavePoint.Items.Insert(i, a);
                        i--;
                    }
                }
            }
        }
    }
 }
