﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_QLNS.DAL;
namespace BTL_QLNS.BUS
{
    class NhanVien_BUS
    {
        DataExec dt = new DataExec();
        public DataTable getNhanvien()
        {
            DataTable da = null;
            String sql = "Select * from NhanVien ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)// khởi tạo hàm thêm
        {
            String sql = " insert into NHANVIEN values('" + manv + "',N'" + tennv + "','" + ngaysinh + "',N'" + diachi + "','" + luong + "',N'" + mapb + "',N'" + mada + "')";
            try
            {
                dt.ExcuteNonQuery(sql);// gọi hàm thực thi query
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updateNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        {
            String sql = "UPDATE NHANVIEN set name_Nv=N'" + tennv + "',ngaysinh_Nv='" + ngaysinh + "',diachi_Nv=N'" + diachi + "',luong_Nv='" + luong + "',id_Pb='" + mapb + "',id_Da='" + mada + "' where id_Nv='" + manv + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteNV(String manv)//tạo hàm xóa 
        {
            String sql = "delete Nhanvien where id_Nv='" + manv + "'"; // câu truy vấn
            try//đưa vào xử lý ngoại lệ
            {
                dt.ExcuteNonQuery(sql);//gọi hàm thực thi câu lệnh query
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)// nếu try lỗi đẩy xg catch bắt lỗi
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from NhanVien where id_Nv like N'%" + condi + "%' OR name_Nv like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
        public String selectPB(String mapb)
        {
            String tenpb;
            String sql = "select name_Pb from PHONGBAN where id_Pb='" + mapb + "'";
            tenpb = dt.ExcuteScalar(sql);
            return tenpb;
        }
        public String selectDA(String mada)
        {
            String tenda;
            String sql = "select name_Da from DUAN where id_Da='" + mada + "'";
            tenda = dt.ExcuteScalar(sql);
            return tenda;
        }
    }
}
