using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapKhachHangDAO
    {
        public static bool Login(string user, string pass)
        {
            var result = false;

            using (var connection = SqlServerConnection.KetNoiToiCSDL())
            {
                connection.Open();

                using (var command = new SqlCommand("DangNhapKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows == true)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        public static int PhanQuyen(string user, string pass)
        {
            var result = 0;
            using (var connection = SqlServerConnection.KetNoiToiCSDL())
            {
                connection.Open();

                using (var command = new SqlCommand("DangNhapKhachHang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        string LoaiKH = "";

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            LoaiKH = row["LOAIKH"].ToString();
                        }

                        if (LoaiKH == "Đồng") result = 1;
                        else if (LoaiKH == "Bạc") result = 2;
                        else if (LoaiKH == "Vàng") result = 3;
                        else if (LoaiKH == "Bạch kim") result = 4;
                        else if (LoaiKH == "Kim cương") result = 5;
                    }
                }
            }
            return result;
        }
    }
}

