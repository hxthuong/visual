using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Items;
using System.Drawing;

namespace Gold_Miner
{
    public partial class Play : Form
    {
        int second = 59;
        int point = 0;
        int mt = 0;
        public Play()
        {
            InitializeComponent();
        }
        
        private void Play_Load(object sender, EventArgs e)
        {
            timerDem.Enabled = true;
            Level1();

        }
       
        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn lưu điểm không?", "Thông báo", MessageBoxButtons.YesNo);
            if (this.DialogResult == DialogResult.Yes)
                SavePoint();
            Close();
        }
        private void timerDem_Tick(object sender, EventArgs e)
        {
            timerDem.Interval = 1000;
            second--;
            lblTime.Text = "T/G:"+" "+second.ToString();
            if (second < 0)
            {
                lblTime.Text = "Hết giờ";
                timerDem.Enabled = false;
                if (lblTime.Text == "Hết giờ" && point < mt)
                {
                    MessageBox.Show("Bạn không đạt được mục tiêu!");
                    if (MessageBox.Show("Bạn có muốn lưu điểm không?", "Có", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        SavePoint();
                    NewGame();
                }
                else Level2();
            }
        }
        public void MucTieu()
        {
            mt = mt + 500 + (int)Math.Pow(5, 3);
            MessageBox.Show("Mục tiêu là:" + mt.ToString());
        }
        public void TPoint()
        {
            mt = mt + point;
            lblTien.Text = "Tiền:" + " " + "$" + point.ToString();
        }
        public void SavePoint()
        {

        }
        public void NewGame()
        {

        }
        private void Level1()
        {
            MucTieu();
            lblMucTieu.Text = "Mục tiêu:" + " " + mt.ToString();
            lblLevel.Text = "Cửa:" + " " + "1";
            Random ran = new Random();
            #region picture 1
            pbx1.Location = new System.Drawing.Point(43, 241);
            string[] file1 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx1.Image = Image.FromFile(file1[ran.Next(file1.Length)]);
            if (file1.Length == 1) // Gold 1
            {
                pbx1.Size = new Size(87, 75);
                point += 500;
            }
            else if (file1.Length == 2) // Gold 2
            {
                pbx1.Size = new Size(45, 41);
                point += 200;
            }
            else if (file1.Length == 3) //Gold 3
            {
                pbx1.Size = new Size(29, 28);
                point += 50;
            }
            else if (file1.Length == 4) //Bag
            {
                pbx1.Size = new Size(50, 49);
            }
            else if (file1.Length == 5) //Diamond
            {
                pbx1.Size = new Size(21, 26);
                point += 600;
            }
            else if (file1.Length == 6) //Stone 1
            {
                pbx1.Size = new Size(51, 42);
                point += 11;
            }
            else if (file1.Length == 7) //Stone 2
            {
                pbx1.Size = new Size(57, 49);
                point += 20;
            }
            else if (file1.Length == 8) //Bone 1
            {
                pbx1.Size = new Size(40, 34);
                point += 7;
            }
            else //Bone 2
            {
                pbx1.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 2
            pbx2.Location = new System.Drawing.Point(27, 301);
            string[] file2 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx2.Image = Image.FromFile(file2[ran.Next(file2.Length)]);
            if (file2.Length == 1)
            {
                pbx2.Size = new Size(87, 75);
                point += 500;
            }
            else if (file2.Length == 2)
            {
                pbx2.Size = new Size(45, 41);
                point += 200;
            }
            else if (file2.Length == 3)
            {
                pbx2.Size = new Size(29, 28);
                point += 50;
            }
            else if (file2.Length == 4)
            {
                pbx2.Size = new Size(50, 49);
            }
            else if (file2.Length == 5)
            {
                pbx2.Size = new Size(21, 26);
                point += 600;
            }
            else if (file2.Length == 6)
            {
                pbx2.Size = new Size(51, 42);
                point += 11;
            }
            else if (file2.Length == 7)
            {
                pbx2.Size = new Size(57, 49);
                point += 20;
            }
            else if (file2.Length == 8)
            {
                pbx2.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx2.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 3
            pbx3.Location = new System.Drawing.Point(99, 169);
            string[] file3 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx3.Image = Image.FromFile(file3[ran.Next(file3.Length)]);
            if (file3.Length == 1)
            {
                pbx3.Size = new Size(87, 75);
                point += 500;
            }
            else if (file3.Length == 2)
            {
                pbx3.Size = new Size(45, 41);
                point += 200;
            }
            else if (file3.Length == 3)
            {
                pbx3.Size = new Size(29, 28);
                point += 50;
            }
            else if (file3.Length == 4)
            {
                pbx3.Size = new Size(50, 49);
            }
            else if (file3.Length == 5)
            {
                pbx3.Size = new Size(21, 26);
                point += 600;
            }
            else if (file3.Length == 6)
            {
                pbx3.Size = new Size(51, 42);
                point += 11;
            }
            else if (file3.Length == 7)
            {
                pbx3.Size = new Size(57, 49);
                point += 20;
            }
            else if (file3.Length == 8)
            {
                pbx3.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx3.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 4
            pbx4.Location = new System.Drawing.Point(181, 241);
            string[] file4 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx4.Image = Image.FromFile(file4[ran.Next(file4.Length)]);
            if (file4.Length == 1)
            {
                pbx4.Size = new Size(87, 75);
                point += 500;
            }
            else if (file4.Length == 2)
            {
                pbx4.Size = new Size(45, 41);
                point += 200;
            }
            else if (file4.Length == 3)
            {
                pbx4.Size = new Size(29, 28);
                point += 50;
            }
            else if (file4.Length == 4)
            {
                pbx4.Size = new Size(50, 49);
            }
            else if (file4.Length == 5)
            {
                pbx4.Size = new Size(21, 26);
                point += 600;
            }
            else if (file4.Length == 6)
            {
                pbx4.Size = new Size(51, 42);
                point += 11;
            }
            else if (file4.Length == 7)
            {
                pbx4.Size = new Size(57, 49);
                point += 20;
            }
            else if (file4.Length == 8)
            {
                pbx4.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx4.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 5
            pbx5.Location = new System.Drawing.Point(181, 398);
            string[] file5 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx5.Image = Image.FromFile(file5[ran.Next(file5.Length)]);
            if (file5.Length == 1)
            {
                pbx5.Size = new Size(87, 75);
                point += 500;
            }
            else if (file5.Length == 2)
            {
                pbx5.Size = new Size(45, 41);
                point += 200;
            }
            else if (file5.Length == 3)
            {
                pbx5.Size = new Size(29, 28);
                point += 50;
            }
            else if (file5.Length == 4)
            {
                pbx5.Size = new Size(50, 49);
            }
            else if (file5.Length == 5)
            {
                pbx5.Size = new Size(21, 26);
                point += 600;
            }
            else if (file5.Length == 6)
            {
                pbx5.Size = new Size(51, 42);
                point += 11;
            }
            else if (file5.Length == 7)
            {
                pbx5.Size = new Size(57, 49);
                point += 20;
            }
            else if (file5.Length == 8)
            {
                pbx5.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx5.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 6
            pbx6.Location = new System.Drawing.Point(251, 422);
            string[] file6 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx6.Image = Image.FromFile(file6[ran.Next(file6.Length)]);
            if (file6.Length == 1)
            {
                pbx6.Size = new Size(87, 75);
                point += 500;
            }
            else if (file6.Length == 2)
            {
                pbx6.Size = new Size(45, 41);
                point += 200;
            }
            else if (file6.Length == 3)
            {
                pbx6.Size = new Size(29, 28);
                point += 50;
            }
            else if (file6.Length == 4)
            {
                pbx6.Size = new Size(50, 49);
            }
            else if (file6.Length == 5)
            {
                pbx6.Size = new Size(21, 26);
                point += 600;
            }
            else if (file6.Length == 6)
            {
                pbx6.Size = new Size(51, 42);
                point += 11;
            }
            else if (file6.Length == 7)
            {
                pbx6.Size = new Size(57, 49);
                point += 20;
            }
            else if (file6.Length == 8)
            {
                pbx6.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx6.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 7
            pbx7.Location = new System.Drawing.Point(308, 344);
            string[] file7 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx7.Image = Image.FromFile(file7[ran.Next(file7.Length)]);
            if (file7.Length == 1)
            {
                pbx7.Size = new Size(87, 75);
                point += 500;
            }
            else if (file7.Length == 2)
            {
                pbx7.Size = new Size(45, 41);
                point += 200;
            }
            else if (file7.Length == 3)
            {
                pbx7.Size = new Size(29, 28);
                point += 50;
            }
            else if (file7.Length == 4)
            {
                pbx7.Size = new Size(50, 49);
            }
            else if (file7.Length == 5)
            {
                pbx7.Size = new Size(21, 26);
                point += 600;
            }
            else if (file7.Length == 6)
            {
                pbx7.Size = new Size(51, 42);
                point += 11;
            }
            else if (file7.Length == 7)
            {
                pbx7.Size = new Size(57, 49);
                point += 20;
            }
            else if (file7.Length == 8)
            {
                pbx7.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx7.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 8
            pbx8.Location = new System.Drawing.Point(381, 221);
            string[] file8 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx8.Image = Image.FromFile(file8[ran.Next(file8.Length)]);
            if (file8.Length == 1)
            {
                pbx8.Size = new Size(87, 75);
                point += 500;
            }
            else if (file8.Length == 2)
            {
                pbx8.Size = new Size(45, 41);
                point += 200;
            }
            else if (file8.Length == 3)
            {
                pbx8.Size = new Size(29, 28);
                point += 50;
            }
            else if (file8.Length == 4)
            {
                pbx8.Size = new Size(50, 49);
            }
            else if (file8.Length == 5)
            {
                pbx8.Size = new Size(21, 26);
                point += 600;
            }
            else if (file8.Length == 6)
            {
                pbx8.Size = new Size(51, 42);
                point += 11;
            }
            else if (file8.Length == 7)
            {
                pbx8.Size = new Size(57, 49);
                point += 20;
            }
            else if (file8.Length == 8)
            {
                pbx8.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx8.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 9
            pbx9.Location = new System.Drawing.Point(425, 422);
            string[] file9 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx9.Image = Image.FromFile(file9[ran.Next(file9.Length)]);
            if (file9.Length == 1)
            {
                pbx9.Size = new Size(87, 75);
                point += 500;
            }
            else if (file9.Length == 2)
            {
                pbx9.Size = new Size(45, 41);
                point += 200;
            }
            else if (file9.Length == 3)
            {
                pbx9.Size = new Size(29, 28);
                point += 50;
            }
            else if (file9.Length == 4)
            {
                pbx9.Size = new Size(50, 49);
            }
            else if (file9.Length == 5)
            {
                pbx9.Size = new Size(21, 26);
                point += 600;
            }
            else if (file9.Length == 6)
            {
                pbx9.Size = new Size(51, 42);
                point += 11;
            }
            else if (file9.Length == 7)
            {
                pbx9.Size = new Size(57, 49);
                point += 20;
            }
            else if (file9.Length == 8)
            {
                pbx9.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx9.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 10
            pbx10.Location = new System.Drawing.Point(493, 358);
            string[] file10 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx10.Image = Image.FromFile(file10[ran.Next(file2.Length)]);
            if (file2.Length == 1)
            {
                pbx2.Size = new Size(87, 75);
                point += 500;
            }
            else if (file2.Length == 2)
            {
                pbx2.Size = new Size(45, 41);
                point += 200;
            }
            else if (file2.Length == 3)
            {
                pbx2.Size = new Size(29, 28);
                point += 50;
            }
            else if (file2.Length == 4)
            {
                pbx2.Size = new Size(50, 49);
            }
            else if (file2.Length == 5)
            {
                pbx2.Size = new Size(21, 26);
                point += 600;
            }
            else if (file2.Length == 6)
            {
                pbx2.Size = new Size(51, 42);
                point += 11;
            }
            else if (file2.Length == 7)
            {
                pbx2.Size = new Size(57, 49);
                point += 20;
            }
            else if (file2.Length == 8)
            {
                pbx2.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx2.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 11
            pbx11.Location = new System.Drawing.Point(521, 310);
            string[] file11 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx11.Image = Image.FromFile(file11[ran.Next(file11.Length)]);
            if (file11.Length == 1)
            {
                pbx11.Size = new Size(87, 75);
                point += 500;
            }
            else if (file11.Length == 2)
            {
                pbx11.Size = new Size(45, 41);
                point += 200;
            }
            else if (file11.Length == 3)
            {
                pbx11.Size = new Size(29, 28);
                point += 50;
            }
            else if (file11.Length == 4)
            {
                pbx11.Size = new Size(50, 49);
            }
            else if (file11.Length == 5)
            {
                pbx11.Size = new Size(21, 26);
                point += 600;
            }
            else if (file11.Length == 6)
            {
                pbx11.Size = new Size(51, 42);
                point += 11;
            }
            else if (file11.Length == 7)
            {
                pbx11.Size = new Size(57, 49);
                point += 20;
            }
            else if (file11.Length == 8)
            {
                pbx11.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx11.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 12
            pbx12.Location = new System.Drawing.Point(521, 267);
            string[] file12 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx12.Image = Image.FromFile(file12[ran.Next(file12.Length)]);
            if (file12.Length == 1)
            {
                pbx12.Size = new Size(87, 75);
                point += 500;
            }
            else if (file12.Length == 2)
            {
                pbx12.Size = new Size(45, 41);
                point += 200;
            }
            else if (file12.Length == 3)
            {
                pbx12.Size = new Size(29, 28);
                point += 50;
            }
            else if (file12.Length == 4)
            {
                pbx12.Size = new Size(50, 49);
            }
            else if (file12.Length == 5)
            {
                pbx12.Size = new Size(21, 26);
                point += 600;
            }
            else if (file12.Length == 6)
            {
                pbx12.Size = new Size(51, 42);
                point += 11;
            }
            else if (file12.Length == 7)
            {
                pbx12.Size = new Size(57, 49);
                point += 20;
            }
            else if (file12.Length == 8)
            {
                pbx12.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx12.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 13
            pbx13.Location = new System.Drawing.Point(558, 221);
            string[] file13 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx13.Image = Image.FromFile(file13[ran.Next(file13.Length)]);
            if (file13.Length == 1)
            {
                pbx13.Size = new Size(87, 75);
                point += 500;
            }
            else if (file13.Length == 2)
            {
                pbx13.Size = new Size(45, 41);
                point += 200;
            }
            else if (file13.Length == 3)
            {
                pbx13.Size = new Size(29, 28);
                point += 50;
            }
            else if (file13.Length == 4)
            {
                pbx13.Size = new Size(50, 49);
            }
            else if (file13.Length == 5)
            {
                pbx13.Size = new Size(21, 26);
                point += 600;
            }
            else if (file13.Length == 6)
            {
                pbx13.Size = new Size(51, 42);
                point += 11;
            }
            else if (file13.Length == 7)
            {
                pbx13.Size = new Size(57, 49);
                point += 20;
            }
            else if (file13.Length == 8)
            {
                pbx13.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx13.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 14
            pbx14.Location = new System.Drawing.Point(558, 173);
            string[] file14 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx2.Image = Image.FromFile(file14[ran.Next(file14.Length)]);
            if (file14.Length == 1)
            {
                pbx14.Size = new Size(87, 75);
                point += 500;
            }
            else if (file14.Length == 2)
            {
                pbx14.Size = new Size(45, 41);
                point += 200;
            }
            else if (file14.Length == 3)
            {
                pbx14.Size = new Size(29, 28);
                point += 50;
            }
            else if (file14.Length == 4)
            {
                pbx14.Size = new Size(50, 49);
            }
            else if (file14.Length == 5)
            {
                pbx14.Size = new Size(21, 26);
                point += 600;
            }
            else if (file14.Length == 6)
            {
                pbx14.Size = new Size(51, 42);
                point += 11;
            }
            else if (file14.Length == 7)
            {
                pbx14.Size = new Size(57, 49);
                point += 20;
            }
            else if (file14.Length == 8)
            {
                pbx14.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx14.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
            #region picture 15
            pbx15.Location = new System.Drawing.Point(599, 332);
            string[] file15 = Directory.GetFiles(@"D:\GitHub\de-tai-ket-thuc-hoc-phan-htxthuong_hathihonghanh\Gold Miner\Gold Miner\bin\Debug", "*.png",
                                              SearchOption.AllDirectories);
            pbx15.Image = Image.FromFile(file15[ran.Next(file15.Length)]);
            if (file15.Length == 1)
            {
                pbx15.Size = new Size(87, 75);
                point += 500;
            }
            else if (file15.Length == 2)
            {
                pbx15.Size = new Size(45, 41);
                point += 200;
            }
            else if (file15.Length == 3)
            {
                pbx15.Size = new Size(29, 28);
                point += 50;
            }
            else if (file15.Length == 4)
            {
                pbx15.Size = new Size(50, 49);
            }
            else if (file15.Length == 5)
            {
                pbx15.Size = new Size(21, 26);
                point += 600;
            }
            else if (file15.Length == 6)
            {
                pbx15.Size = new Size(51, 42);
                point += 11;
            }
            else if (file15.Length == 7)
            {
                pbx15.Size = new Size(57, 49);
                point += 20;
            }
            else if (file15.Length == 8)
            {
                pbx15.Size = new Size(40, 34);
                point += 7;
            }
            else
            {
                pbx15.Size = new Size(40, 34);
                point += 20;
            }
            #endregion
        }
        private void Level2()
        {

        }

    }
}
