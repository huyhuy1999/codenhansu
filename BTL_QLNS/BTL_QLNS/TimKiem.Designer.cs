using System;

namespace BTL_QLNS
{
    partial class TimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbmanhanvien = new System.Windows.Forms.RadioButton();
            this.rdbphongban = new System.Windows.Forms.RadioButton();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.lbthongtin = new System.Windows.Forms.Label();
            this.txtmacantim = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbmanhanvien);
            this.groupBox1.Controls.Add(this.rdbphongban);
            this.groupBox1.Location = new System.Drawing.Point(50, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM THEO";
            // 
            // rdbmanhanvien
            // 
            this.rdbmanhanvien.AutoSize = true;
            this.rdbmanhanvien.Location = new System.Drawing.Point(307, 54);
            this.rdbmanhanvien.Name = "rdbmanhanvien";
            this.rdbmanhanvien.Size = new System.Drawing.Size(72, 21);
            this.rdbmanhanvien.TabIndex = 1;
            this.rdbmanhanvien.Text = "MÃ NV";
            this.rdbmanhanvien.UseVisualStyleBackColor = true;
            this.rdbmanhanvien.CheckedChanged += new System.EventHandler(this.rdbnhanvien_CheckedChanged);
            // 
            // rdbphongban
            // 
            this.rdbphongban.AutoSize = true;
            this.rdbphongban.Checked = true;
            this.rdbphongban.Location = new System.Drawing.Point(52, 54);
            this.rdbphongban.Name = "rdbphongban";
            this.rdbphongban.Size = new System.Drawing.Size(112, 21);
            this.rdbphongban.TabIndex = 0;
            this.rdbphongban.TabStop = true;
            this.rdbphongban.Text = "PHÒNG BAN";
            this.rdbphongban.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(622, 128);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(137, 43);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "TÌM";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.Location = new System.Drawing.Point(946, 128);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(132, 43);
            this.btntrolai.TabIndex = 2;
            this.btntrolai.Text = "TRỞ LẠI";
            this.btntrolai.UseVisualStyleBackColor = true;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Location = new System.Drawing.Point(50, 242);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.RowTemplate.Height = 24;
            this.dgvtimkiem.Size = new System.Drawing.Size(1086, 212);
            this.dgvtimkiem.TabIndex = 3;
            this.dgvtimkiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtimkiem_CellContentClick);
            // 
            // lbthongtin
            // 
            this.lbthongtin.AutoSize = true;
            this.lbthongtin.Location = new System.Drawing.Point(619, 68);
            this.lbthongtin.Name = "lbthongtin";
            this.lbthongtin.Size = new System.Drawing.Size(127, 17);
            this.lbthongtin.TabIndex = 4;
            this.lbthongtin.Text = "NHẬP THÔNG TIN";
            this.lbthongtin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmacantim
            // 
            this.txtmacantim.Location = new System.Drawing.Point(752, 65);
            this.txtmacantim.Name = "txtmacantim";
            this.txtmacantim.Size = new System.Drawing.Size(200, 22);
            this.txtmacantim.TabIndex = 5;
            this.txtmacantim.TextChanged += new System.EventHandler(this.txtmacantim_TextChanged);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(791, 128);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(133, 42);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = "TIẾP TỤC";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 479);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtmacantim);
            this.Controls.Add(this.lbthongtin);
            this.Controls.Add(this.dgvtimkiem);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void txtmacantim_TextChanged(object sender ,EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rdbnhanvien_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmanhanvien;
        private System.Windows.Forms.RadioButton rdbphongban;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btntrolai;
        private System.Windows.Forms.DataGridView dgvtimkiem;
        private System.Windows.Forms.Label lbthongtin;
        private System.Windows.Forms.TextBox txtmacantim;
        private System.Windows.Forms.Button btnnext;
    }
}