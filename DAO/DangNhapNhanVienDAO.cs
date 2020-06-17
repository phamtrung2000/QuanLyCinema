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
    public class DangNhapNhanVienDAO
    {
        public static bool Login(string user, string pass)
        {
            var result = false;
            using (var connection = SqlServerConnection.KetNoiToiCSDL())
            {
                connection.Open();

                using (var command = new SqlCommand("DangNhapNhanVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        public static int PhanQuyenTheoChucVu(string user, string pass)
        {
            int result = 0;
            using (var connection = SqlServerConnection.KetNoiToiCSDL())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("PhanQuyenNhanVien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);

                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        string a = "";

                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            a = row["CHUCVU"].ToString();

                        }
                        /// quanly :1   nhanvien ban hang :2
                        if (a == "Quản trị") result = 1;
                        else if (a == "Nhân viên quản lý phim") result = 2;
                        else if (a == "Nhân viên quản lý phòng chiếu") result = 3;
                        else if (a == "Nhân viên quản lý lịch chiếu") result = 4;
                        else if (a == "Nhân viên bán vé") result = 5;
                    }
                }
            }
            return result;
        }
    }
}
