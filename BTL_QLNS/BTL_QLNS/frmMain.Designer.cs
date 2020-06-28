namespace BTL_QLNS
{
    partial class frmMain
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.danhMucjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopdongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuyểnDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 53);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 367);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 30);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(790, 53);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 367);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlTop.Controls.Add(this.ptbMinimize);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 53);
            this.pnlTop.TabIndex = 1;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = global::BTL_QLNS.Properties.Resources.minimazar;
            this.ptbMinimize.Location = new System.Drawing.Point(742, 12);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(20, 20);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 0;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = global::BTL_QLNS.Properties.Resources.close_button;
            this.ptbExit.Location = new System.Drawing.Point(768, 12);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(20, 20);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Teal;
            this.pnlMain.BackgroundImage = global::BTL_QLNS.Properties.Resources.unnamed;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.msMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(10, 53);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(780, 367);
            this.pnlMain.TabIndex = 2;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucjToolStripMenuItem,
            this.tácVụToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem1});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(780, 28);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // danhMucjToolStripMenuItem
            // 
            this.danhMucjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbToolStripMenuItem,
            this.nhanvienToolStripMenuItem,
            this.hopdongToolStripMenuItem});
            this.danhMucjToolStripMenuItem.Name = "danhMucjToolStripMenuItem";
            this.danhMucjToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMucjToolStripMenuItem.Text = "Danh mục";
            // 
            // pbToolStripMenuItem
            // 
            this.pbToolStripMenuItem.Name = "pbToolStripMenuItem";
            this.pbToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pbToolStripMenuItem.Text = "Phòng ban";
            this.pbToolStripMenuItem.Click += new System.EventHandler(this.pbToolStripMenuItem_Click);
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nhanvienToolStripMenuItem.Text = "Nhân viên";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // hopdongToolStripMenuItem
            // 
            this.hopdongToolStripMenuItem.Name = "hopdongToolStripMenuItem";
            this.hopdongToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hopdongToolStripMenuItem.Text = "dự án";
            this.hopdongToolStripMenuItem.Click += new System.EventHandler(this.hopdongToolStripMenuItem_Click);
            // 
            // tácVụToolStripMenuItem
            // 
            this.tácVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuyểnDụngToolStripMenuItem});
            this.tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            this.tácVụToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.tácVụToolStripMenuItem.Text = "Tác vụ";
            // 
            // tuyểnDụngToolStripMenuItem
            // 
            this.tuyểnDụngToolStripMenuItem.Name = "tuyểnDụngToolStripMenuItem";
            this.tuyểnDụngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tuyểnDụngToolStripMenuItem.Text = "Tìm Kiếm";
            this.tuyểnDụngToolStripMenuItem.Click += new System.EventHandler(this.tuyểnDụngToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem1
            // 
            this.giớiThiệuToolStripMenuItem1.Name = "giớiThiệuToolStripMenuItem1";
            this.giớiThiệuToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.giớiThiệuToolStripMenuItem1.Text = "Giới thiệu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRM Pro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem danhMucjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hopdongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuyểnDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem1;
    }
}