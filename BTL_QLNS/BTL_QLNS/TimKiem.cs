using BTL_QLNS.BUS;
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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        TimKiem_BUS tkb = new TimKiem_BUS();

        private void TimKiem_load(object sender, EventArgs e)
        {
            var rs = new TimKiem_BUS();
        }
        private void btntrolai_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (rdbphongban.Checked == true)
            {
                // Tìm theo pb
                dgvtimkiem.DataSource = tkb.TimKiem(false, txtmacantim.Text);
            }
            else 
            {
                // Tìm theo manv
                dgvtimkiem.DataSource = tkb.TimKiem(true, txtmacantim.Text);
                dgvtimkiem.Columns["id_Nv"].HeaderText = "Mã nhân viên";
                dgvtimkiem.Columns["name_Nv"].HeaderText = "Họ tên";
                dgvtimkiem.Columns["name_pb"].HeaderText = "phòng ban ";
                dgvtimkiem.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
              
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            txtmacantim.Text = "";
            txtmacantim.Focus();
        }

        private void dgvtimkiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    };

