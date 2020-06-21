using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class LichChieuDAO
    {
        public static DataTable LoadDSLC()
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * " +
                                  "FROM LICHCHIEU ORDER BY STT ASC";

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static void Them(LichChieuDTO lichchieu)
        {
            // mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO LICHCHIEU VALUES(@NGAYCHIEU,@MAPHIM,@MACC,@MAPC)";
            //command.CommandText = "EXEC Themlichchieu @NGAYCHIEU,@MAPHIM,@MACC,@MAPC";
            command.Parameters.Add("@NGAYCHIEU", SqlDbType.Date);
            command.Parameters.Add("@MAPHIM", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MACC", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MAPC", SqlDbType.VarChar, 10);


            // gán giá trị
            command.Parameters["@NGAYCHIEU"].Value = lichchieu.Ngaychieu;
            command.Parameters["@MAPHIM"].Value = lichchieu.Maphim;
            command.Parameters["@MACC"].Value = lichchieu.Macc;
            command.Parameters["@MAPC"].Value = lichchieu.Mapc;

            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }
        public static void Sua(LichChieuDTO lichchieu)
        {
            /// mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO CACHIEU VALUES(@MACC,@TENCC,@BATDAU,@KETTHUC)";
            command.CommandText = "EXEC Sualichchieu @NGAYCHIEU,@MAPHIM,@MACC,@MAPC";
            command.Parameters.Add("@NGAYCHIEU", SqlDbType.Date);
            command.Parameters.Add("@MAPHIM", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MACC", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MAPC", SqlDbType.VarChar, 10);


            // gán giá trị
            command.Parameters["@NGAYCHIEU"].Value = lichchieu.Ngaychieu;
            command.Parameters["@MAPHIM"].Value = lichchieu.Maphim;
            command.Parameters["@MACC"].Value = lichchieu.Macc;
            command.Parameters["@MAPC"].Value = lichchieu.Mapc;

            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }

        public static void Xoa(DateTime ngaychieu, string maphim)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Xoalichchieu '" + ngaychieu + "','" + maphim + "'";
            //command.CommandText = "DELETE NV FROM NHANVIEN NV " +
            //                      "WHERE NV.MANV='" + manv + "'";
            //command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            // gán giá trị
            //command.Parameters["@MANV"].Value = manv;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Timtheongaychieu(DateTime nc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheongaychieu '" + nc + "'";
            //command.CommandText = "SELECT * FROM NHANVIEN " +
            //                      "WHERE MANV LIKE'" + manv + "%'";

            // gán giá trị

            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static DataTable Timtheomacc(string macc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheomacclc '" + macc + "'";
            //command.CommandText = "SELECT * FROM NHANVIEN " +
            //                      "WHERE MANV LIKE'" + manv + "%'";

            // gán giá trị

            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static DataTable Timtheomapc(string mapc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Timtheomapc '" + mapc + "'";
            //command.CommandText = "SELECT * FROM NHANVIEN " +
            //                      "WHERE MANV LIKE'" + manv + "%'";

            // gán giá trị

            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}

