using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BTL_QLNS.DAL
{
    public class DataExec
    {
        public SqlConnection getConnect()// khởi tạo hàm kết nối
        {
            String strConn = @"Data Source=LAPTOP-B9HCOLT4\SQLEXPRESS;Initial Catalog=Quanlynhasu_3F;Integrated Security=True";
            return new SqlConnection(strConn);
        }
        public DataTable getTable(String sql)// tạo dataset
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect(); //gọi hàm kết nối
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//thiết lập query và thực thi
            da.Fill(dt);//lấp đầy kết quả 
            conn.Close();
            return dt;
        }
        public void ExcuteNonQuery(String sql)//hàm thực thi câu lênh query
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
             conn.Close();
        }
        public String ExcuteScalar(String sql)//lấy một giá trị từ CSDL sau khi thực thi query
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            String kq=cmd.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }
    }
}
     