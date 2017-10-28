namespace Gold_Miner
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.timerDem = new System.Windows.Forms.Timer(this.components);
            this.pbxPlay = new System.Windows.Forms.PictureBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMucTieu = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx15 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pbx10 = new System.Windows.Forms.PictureBox();
            this.pbx11 = new System.Windows.Forms.PictureBox();
            this.pbx12 = new System.Windows.Forms.PictureBox();
            this.pbx13 = new System.Windows.Forms.PictureBox();
            this.pbx14 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx14)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDem
            // 
            this.timerDem.Tick += new System.EventHandler(this.timerDem_Tick);
            // 
            // pbxPlay
            // 
            this.pbxPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlay.Image")));
            this.pbxPlay.Location = new System.Drawing.Point(0, 0);
            this.pbxPlay.Name = "pbxPlay";
            this.pbxPlay.Size = new System.Drawing.Size(687, 511);
            this.pbxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlay.TabIndex = 0;
            this.pbxPlay.TabStop = false;
            this.pbxPlay.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTien
            // 
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTien.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTien.Image = ((System.Drawing.Image)(resources.GetObject("lblTien.Image")));
            this.lblTien.Location = new System.Drawing.Point(13, 20);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(140, 26);
            this.lblTien.TabIndex = 5;
            this.lblTien.Text = "Tiền: $";
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLevel.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLevel.Image = ((System.Drawing.Image)(resources.GetObject("lblLevel.Image")));
            this.lblLevel.Location = new System.Drawing.Point(573, 61);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 26);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Cửa:";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTime.Image = ((System.Drawing.Image)(resources.GetObject("lblTime.Image")));
            this.lblTime.Location = new System.Drawing.Point(573, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 26);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "T/G:";
            // 
            // lblMucTieu
            // 
            this.lblMucTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMucTieu.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblMucTieu.Image = ((System.Drawing.Image)(resources.GetObject("lblMucTieu.Image")));
            this.lblMucTieu.Location = new System.Drawing.Point(13, 61);
            this.lblMucTieu.Name = "lblMucTieu";
            this.lblMucTieu.Size = new System.Drawing.Size(171, 26);
            this.lblMucTieu.TabIndex = 8;
            this.lblMucTieu.Text = "Mục tiêu: $";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gold;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuit.Location = new System.Drawing.Point(462, 30);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 46);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(65, 161);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(58, 41);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 10;
            this.pbx1.TabStop = false;
            // 
            // pbx15
            // 
            this.pbx15.Location = new System.Drawing.Point(397, 248);
            this.pbx15.Name = "pbx15";
            this.pbx15.Size = new System.Drawing.Size(58, 41);
            this.pbx15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx15.TabIndex = 11;
            this.pbx15.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(188, 259);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(58, 41);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 12;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(333, 314);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(58, 41);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 13;
            this.pbx3.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(253, 337);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(58, 41);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 14;
            this.pbx4.TabStop = false;
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(415, 337);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(58, 41);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 15;
            this.pbx5.TabStop = false;
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(108, 259);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(58, 41);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 16;
            this.pbx6.TabStop = false;
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(384, 161);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(58, 41);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 17;
            this.pbx7.TabStop = false;
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(203, 172);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(58, 41);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 18;
            this.pbx8.TabStop = false;
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(126, 410);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(58, 41);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 19;
            this.pbx9.TabStop = false;
            // 
            // pbx10
            // 
            this.pbx10.Location = new System.Drawing.Point(108, 337);
            this.pbx10.Name = "pbx10";
            this.pbx10.Size = new System.Drawing.Size(58, 41);
            this.pbx10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx10.TabIndex = 20;
            this.pbx10.TabStop = false;
            // 
            // pbx11
            // 
            this.pbx11.Location = new System.Drawing.Point(354, 396);
            this.pbx11.Name = "pbx11";
            this.pbx11.Size = new System.Drawing.Size(58, 41);
            this.pbx11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx11.TabIndex = 21;
            this.pbx11.TabStop = false;
            // 
            // pbx12
            // 
            this.pbx12.Location = new System.Drawing.Point(540, 355);
            this.pbx12.Name = "pbx12";
            this.pbx12.Size = new System.Drawing.Size(58, 41);
            this.pbx12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx12.TabIndex = 22;
            this.pbx12.TabStop = false;
            // 
            // pbx13
            // 
            this.pbx13.Location = new System.Drawing.Point(507, 283);
            this.pbx13.Name = "pbx13";
            this.pbx13.Size = new System.Drawing.Size(58, 41);
            this.pbx13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx13.TabIndex = 23;
            this.pbx13.TabStop = false;
            // 
            // pbx14
            // 
            this.pbx14.Location = new System.Drawing.Point(477, 199);
            this.pbx14.Name = "pbx14";
            this.pbx14.Size = new System.Drawing.Size(58, 41);
            this.pbx14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx14.TabIndex = 24;
            this.pbx14.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 511);
            this.Controls.Add(this.pbx14);
            this.Controls.Add(this.pbx13);
            this.Controls.Add(this.pbx12);
            this.Controls.Add(this.pbx11);
            this.Controls.Add(this.pbx10);
            this.Controls.Add(this.pbx9);
            this.Controls.Add(this.pbx8);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx15);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblMucTieu);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.pbxPlay);
            this.DoubleBuffered = true;
            this.Name = "Play";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerDem;
        private System.Windows.Forms.PictureBox pbxPlay;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMucTieu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx15;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx10;
        private System.Windows.Forms.PictureBox pbx11;
        private System.Windows.Forms.PictureBox pbx12;
        private System.Windows.Forms.PictureBox pbx13;
        private System.Windows.Forms.PictureBox pbx14;
    }
}