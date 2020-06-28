using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL_QLNS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            //cho form nam duoi taskbar
            Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
            rect.Location = new Point(0, 0);
            this.MaximizedBounds = rect;
            this.WindowState = FormWindowState.Maximized;

            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlyphongban frmpb = new Quanlyphongban();
            frmpb.TopLevel = false;
            pnlMain.Controls.Add(frmpb);
            frmpb.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmpb.Dock = DockStyle.Fill;
            frmpb.Show();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien frmNV = new Quanlynhanvien();
            frmNV.TopLevel = false;//cho hien uu tien
            pnlMain.Controls.Add(frmNV);//add form len panelMain
            frmNV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//bo vien cua form
            frmNV.Dock = DockStyle.Fill;//fill tu dong co gian theo size form chinh
            frmNV.Show();//hhien thi
        }

        private void hopdongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlyduan frmda = new Quanlyduan();
            frmda.TopLevel = false;
            pnlMain.Controls.Add(frmda);
            frmda.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmda.Dock = DockStyle.Fill;
            frmda.Show();
        }

        private void tuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiem frmtk = new TimKiem();
            frmtk.TopLevel = false;
            pnlMain.Controls.Add(frmtk);
            frmtk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmtk.Dock = DockStyle.Fill;
            frmtk.Show();
        }
    }
}
