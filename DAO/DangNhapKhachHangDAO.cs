using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapKhachHangDAO
    {
        public static bool Login(string user, string pass)
        {
            using (var connection = SQLConnectionData.HamKetNoi())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EXEC Dangnhapkhachhang '"+user+"','"+pass+"'";

                    //command.CommandText = "SELECT KHTT.LOAIKH,DNKH.TAIKHOAN,DNKH.MATKHAU FROM KHACHHANGTHANTHIET KHTT INNER JOIN DANGNHAP_KHACHHANG DNKH ON DNKH.MAKH = KHTT.MAKH" +
                    //    " WHERE DNKH.TAIKHOAN=@user AND DNKH.MATKHAU=@pass";

                    // command.CommandText = "SELECT * FROM NGUOIDUNG WHERE TAIKHOAN=@user AND MATKHAU=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows == true)
                    {

                        while (reader.Read())

                        {

                            //// UserLoginCache.MaNV = reader.GetString(0);
                            //DangNhapNhanVienDTO = reader.GetString(0);
                            //UserLoginCache.ChucVu = reader.GetString(1);
                            //UserLoginCache.SDT = reader.GetString(2);
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public static int Phanquyen(string user, string pass)
        {
            using (var connection = SQLConnectionData.HamKetNoi())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("EXEC Phanquyenkhachhang '"+user+"', '"+pass+"'", connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        string a = "";

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            a = row["LOAIKH"].ToString();
                        }
                        /// quanly :1   nhanvien ban hang :2 
                        if (a == "Đồng")
                        {
                            return 1;
                        }
                        else if (a == "Bạc")
                        {
                            return 2;
                        }
                        else if (a == "Vàng")
                        {
                            return 3;
                        }
                        else if (a == "Bạch kim")
                        {
                            return 4;
                        }
                        else if (a == "Kim cương")
                        {
                            return 5;
                        }
                        return 0;
                    }
                }
            }
        }
    }
}

