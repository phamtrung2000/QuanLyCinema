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
    public class CaChieuDAO
    {
        public static DataTable LoadDSCC()
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * " +
                                  "FROM CACHIEU ORDER BY STT ASC";

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static void Them(CaChieuDTO cachieu)
        {
            // mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO CACHIEU VALUES(@MACC,@TENCC,@BATDAU,@KETTHUC)";
            command.CommandText = "EXEC Themcachieu @MACC,@TENCC,@BATDAU,@KETTHUC";
            command.Parameters.Add("@MACC", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TENCC", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@BATDAU", SqlDbType.DateTime);
            command.Parameters.Add("@KETTHUC", SqlDbType.DateTime);


            // gán giá trị
            command.Parameters["@MACC"].Value = cachieu.Macc;
            command.Parameters["@TENCC"].Value = cachieu.Tencc;
            command.Parameters["@BATDAU"].Value = cachieu.Batdau.ToLongTimeString();
            command.Parameters["@KETTHUC"].Value = cachieu.Ketthuc.ToLongTimeString();

            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }
        public static void Sua(CaChieuDTO cachieu)
        {
            // mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO NHANVIEN VALUES(@MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL)";
            command.CommandText = "EXEC Suacachieu @MACC,@TENCC,@BATDAU,@KETTHUC";
            command.Parameters.Add("@MACC", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TENCC", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@BATDAU", SqlDbType.DateTime);
            command.Parameters.Add("@KETTHUC", SqlDbType.DateTime);


            // gán giá trị
            command.Parameters["@MACC"].Value = cachieu.Macc;
            command.Parameters["@TENCC"].Value = cachieu.Tencc;
            command.Parameters["@BATDAU"].Value = cachieu.Batdau.ToLongTimeString();
            command.Parameters["@KETTHUC"].Value = cachieu.Ketthuc.ToLongTimeString();

            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }
        public static void Xoa(string macc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Xoacachieu '" + macc + "'";
            //command.CommandText = "DELETE NV FROM NHANVIEN NV " +
            //                      "WHERE NV.MANV='" + manv + "'";
            //command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            // gán giá trị
            //command.Parameters["@MANV"].Value = manv;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable TimtheoMacc(string macc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheoMacc '" + macc + "'";
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
        public static DataTable TimtheoTencc(string tencc)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheoTencc '" + tencc + "'";
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
