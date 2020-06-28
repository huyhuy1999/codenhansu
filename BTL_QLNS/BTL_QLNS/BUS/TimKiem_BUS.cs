using BTL_QLNS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BTL_QLNS.BUS
{
    class TimKiem_BUS
    {

        /// <param name="type"></param>
        /// <param name="keyword"></param>
        DataExec da = new DataExec();
        public DataTable TimKiem(bool type, string keyword)//tạo hàm tìm kiếm
        {

            string sql;
            try
            {
                if (type == true)
                {
                    sql = "select nv.id_Nv,nv.name_Nv,FORMAT(nv.ngaysinh_Nv, 'dd/MM/yyyy ') ngay_sinh,nv.diachi_Nv,pb.name_Pb from NHANVIEN nv inner join PHONGBAN pb on nv.id_Pb = pb.id_Pb where nv.id_Nv = '" + keyword + "'order by pb.name_Pb";
                }
                else
                {
                    //Column = "id_Nv AS 'mã nhân viên',name_NV AS'tên nhân viên',ngaysinh_Nv AS 'ngày sinh',name_Pb AS 'Tên phòng ban',luong_NV AS'lương',";
                    sql = "select nv.id_Nv , nv.name_Nv,FORMAT(nv.ngaysinh_Nv, 'dd/MM/yyyy') ngay_sinh,pb.name_pb,nv.luong_Nv from NHANVIEN nv inner join PHONGBAN pb on nv.id_Pb = pb.id_Pb where nv.id_Pb = '" + keyword + "'";
                }
                return da.getTable(sql);
            }
            catch (Exception )
            {

                return null;
            }
               
        }
            
    }
}
