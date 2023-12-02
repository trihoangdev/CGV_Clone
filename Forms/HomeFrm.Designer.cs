namespace CGV_Clone.Forms
{
    partial class HomeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pHIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moiveShowingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.movieUpcomingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rẠPCGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.specialCinemaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cinema3DMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÀNHVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÀIKHOẢNCGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUYỀNLỢIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTUREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẦYONLINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHUÊRẠPVÉNHÓMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginlb = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHIMToolStripMenuItem,
            this.rẠPCGVToolStripMenuItem,
            this.tHÀNHVIÊNToolStripMenuItem,
            this.cUTUREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pHIMToolStripMenuItem
            // 
            this.pHIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moiveShowingMenu,
            this.movieUpcomingMenu});
            this.pHIMToolStripMenuItem.Name = "pHIMToolStripMenuItem";
            this.pHIMToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.pHIMToolStripMenuItem.Text = "PHIM";
            // 
            // moiveShowingMenu
            // 
            this.moiveShowingMenu.Name = "moiveShowingMenu";
            this.moiveShowingMenu.Size = new System.Drawing.Size(220, 24);
            this.moiveShowingMenu.Text = "PHIM ĐANG CHIẾU";
            this.moiveShowingMenu.Click += new System.EventHandler(this.MovieShowingMenu_Click);
            // 
            // movieUpcomingMenu
            // 
            this.movieUpcomingMenu.Name = "movieUpcomingMenu";
            this.movieUpcomingMenu.Size = new System.Drawing.Size(220, 24);
            this.movieUpcomingMenu.Text = "PHIM SẮP CHIẾU";
            this.movieUpcomingMenu.Click += new System.EventHandler(this.MovieUpcomingMenu_Click);
            // 
            // rẠPCGVToolStripMenuItem
            // 
            this.rẠPCGVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemasMenu,
            this.specialCinemaMenu,
            this.cinema3DMenu});
            this.rẠPCGVToolStripMenuItem.Name = "rẠPCGVToolStripMenuItem";
            this.rẠPCGVToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.rẠPCGVToolStripMenuItem.Text = "RẠP CGV";
            // 
            // cinemasMenu
            // 
            this.cinemasMenu.Name = "cinemasMenu";
            this.cinemasMenu.Size = new System.Drawing.Size(199, 24);
            this.cinemasMenu.Text = "TẤT CẢ CÁC RẠP";
            this.cinemasMenu.Click += new System.EventHandler(this.CinemaMenu_Click);
            // 
            // specialCinemaMenu
            // 
            this.specialCinemaMenu.Name = "specialCinemaMenu";
            this.specialCinemaMenu.Size = new System.Drawing.Size(199, 24);
            this.specialCinemaMenu.Text = "RẠP ĐẶC BIỆT";
            this.specialCinemaMenu.Click += new System.EventHandler(this.SpecialCinemaMenu_Click);
            // 
            // cinema3DMenu
            // 
            this.cinema3DMenu.Name = "cinema3DMenu";
            this.cinema3DMenu.Size = new System.Drawing.Size(199, 24);
            this.cinema3DMenu.Text = "RẠP 3D";
            this.cinema3DMenu.Click += new System.EventHandler(this.Cinema3DMenu_Click);
            // 
            // tHÀNHVIÊNToolStripMenuItem
            // 
            this.tHÀNHVIÊNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tÀIKHOẢNCGVToolStripMenuItem,
            this.qUYỀNLỢIToolStripMenuItem});
            this.tHÀNHVIÊNToolStripMenuItem.Name = "tHÀNHVIÊNToolStripMenuItem";
            this.tHÀNHVIÊNToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.tHÀNHVIÊNToolStripMenuItem.Text = "THÀNH VIÊN";
            // 
            // tÀIKHOẢNCGVToolStripMenuItem
            // 
            this.tÀIKHOẢNCGVToolStripMenuItem.Name = "tÀIKHOẢNCGVToolStripMenuItem";
            this.tÀIKHOẢNCGVToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.tÀIKHOẢNCGVToolStripMenuItem.Text = "TÀI KHOẢN CGV";
            // 
            // qUYỀNLỢIToolStripMenuItem
            // 
            this.qUYỀNLỢIToolStripMenuItem.Name = "qUYỀNLỢIToolStripMenuItem";
            this.qUYỀNLỢIToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.qUYỀNLỢIToolStripMenuItem.Text = "QUYỀN LỢI";
            // 
            // cUTUREToolStripMenuItem
            // 
            this.cUTUREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẦYONLINEToolStripMenuItem,
            this.tHUÊRẠPVÉNHÓMToolStripMenuItem,
            this.eCGVToolStripMenuItem});
            this.cUTUREToolStripMenuItem.Name = "cUTUREToolStripMenuItem";
            this.cUTUREToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.cUTUREToolStripMenuItem.Text = "THÀNH VIÊN";
            // 
            // qUẦYONLINEToolStripMenuItem
            // 
            this.qUẦYONLINEToolStripMenuItem.Name = "qUẦYONLINEToolStripMenuItem";
            this.qUẦYONLINEToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.qUẦYONLINEToolStripMenuItem.Text = "QUẦY ONLINE";
            // 
            // tHUÊRẠPVÉNHÓMToolStripMenuItem
            // 
            this.tHUÊRẠPVÉNHÓMToolStripMenuItem.Name = "tHUÊRẠPVÉNHÓMToolStripMenuItem";
            this.tHUÊRẠPVÉNHÓMToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.tHUÊRẠPVÉNHÓMToolStripMenuItem.Text = "THUÊ RẠP & VÉ NHÓM";
            // 
            // eCGVToolStripMenuItem
            // 
            this.eCGVToolStripMenuItem.Name = "eCGVToolStripMenuItem";
            this.eCGVToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.eCGVToolStripMenuItem.Text = "E-CGV";
            // 
            // loginlb
            // 
            this.loginlb.AutoSize = true;
            this.loginlb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlb.Image = ((System.Drawing.Image)(resources.GetObject("loginlb.Image")));
            this.loginlb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginlb.Location = new System.Drawing.Point(1225, 4);
            this.loginlb.Name = "loginlb";
            this.loginlb.Size = new System.Drawing.Size(197, 19);
            this.loginlb.TabIndex = 2;
            this.loginlb.Text = "       ĐĂNG NHẬP/ĐĂNG KÝ";
            this.loginlb.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(176, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1095, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(274, 114);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(930, 280);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 277);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(235, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 277);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(467, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 277);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(699, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(226, 277);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGV_Clone.Properties.Resources._event;
            this.pictureBox1.Location = new System.Drawing.Point(169, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox9);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox10);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(277, 474);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(930, 280);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(226, 277);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(235, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(226, 277);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(467, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(226, 277);
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(699, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(226, 277);
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1424, 771);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.loginlb);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeFrm";
            this.Text = "TRANG CHỦ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pHIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rẠPCGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÀNHVIÊNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTUREToolStripMenuItem;
        private System.Windows.Forms.Label loginlb;
        private System.Windows.Forms.ToolStripMenuItem moiveShowingMenu;
        private System.Windows.Forms.ToolStripMenuItem movieUpcomingMenu;
        private System.Windows.Forms.ToolStripMenuItem cinemasMenu;
        private System.Windows.Forms.ToolStripMenuItem specialCinemaMenu;
        private System.Windows.Forms.ToolStripMenuItem cinema3DMenu;
        private System.Windows.Forms.ToolStripMenuItem tÀIKHOẢNCGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUYỀNLỢIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẦYONLINEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHUÊRẠPVÉNHÓMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCGVToolStripMenuItem;
        private System.Windows.Forms.Button btnFilmHeaderNext;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}