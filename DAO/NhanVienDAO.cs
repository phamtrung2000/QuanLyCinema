using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DAO
{
    public class NhanVienDAO
    {
        //--------------------------------------------------------------------------------------------//
        private SqlServerConnection sqlServerConnection;
        public NhanVienDAO()
        {
            sqlServerConnection = new SqlServerConnection();
        }
        public DataTable TimTheoMaNhanVien(string manv)
        {
            string query = "Timtheo_MaNV";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@MaNV", manv);
            return sqlServerConnection.executeSelectQuery(query, sqlParameter);
        }
        public DataTable getAll()
        {
            string query = "SelectAllNhanVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return sqlServerConnection.executeSelectQuery(query, sqlParameters);   
        }


        //--------------------------------------------------------------------------------------------//


        //Load danh sách sv từ database
        public static DataTable LoadDSNV()
        {
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * " +
                                  "FROM NHANVIEN ORDER BY STT ASC";

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public static void Them(NhanVienDTO nhanvien)
        {
            // mở kết nối
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO NHANVIEN VALUES(@MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL)";
            command.CommandText = "EXEC Themnhanvien @MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL";
            command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@CHUCVU", SqlDbType.VarChar, 100);
            command.Parameters.Add("@SDT", SqlDbType.VarChar, 20);
            command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 4);
            command.Parameters.Add("@NGAYSINH", SqlDbType.Date);
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@LUONG", SqlDbType.Money);
            command.Parameters.Add("@NGAYVL", SqlDbType.Date);

            // gán giá trị
            command.Parameters["@MANV"].Value = nhanvien.MaNV;
            command.Parameters["@HOTEN"].Value = nhanvien.HoTen;
            command.Parameters["@CHUCVU"].Value = nhanvien.ChucVu;
            command.Parameters["@SDT"].Value = nhanvien.SDT;
            command.Parameters["@GIOITINH"].Value = nhanvien.GioiTinh;
            command.Parameters["@NGAYSINH"].Value = nhanvien.NgaySinh;
            command.Parameters["@DIACHI"].Value = nhanvien.DiaChi;
            command.Parameters["@LUONG"].Value = nhanvien.Luong;
            command.Parameters["@NGAYVL"].Value = nhanvien.NgayBatDauLamViec;

            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }


        public static void Sua(NhanVienDTO nhanvien)
        {
            // mở kết nối
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();

            // tạo câu lệnh Sửa
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Suanhanvien @MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL";
            //command.CommandText = "UPDATE NHANVIEN " +
            //    "SET MANV=@MANV ," +
            //    "HOTEN=@HOTEN," +
            //    "CHUCVU=@CHUCVU," +
            //    "SDT=@SDT," +
            //    "GIOITINH=@GIOITINH," +
            //    "NGAYSINH=@NGAYSINH," +
            //    "DIACHI=@DIACHI," +
            //    "LUONG=@LUONG," +
            //    "NGAYVL=@NGAYVL " +
            //    "WHERE MANV=@MANV";
            command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@CHUCVU", SqlDbType.VarChar, 20);
            command.Parameters.Add("@SDT", SqlDbType.VarChar, 20);
            command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 4);
            command.Parameters.Add("@NGAYSINH", SqlDbType.Date);
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@LUONG", SqlDbType.Money);
            command.Parameters.Add("@NGAYVL", SqlDbType.Date);

            // gán giá trị
            command.Parameters["@MANV"].Value = nhanvien.MaNV;
            command.Parameters["@HOTEN"].Value = nhanvien.HoTen;
            command.Parameters["@CHUCVU"].Value = nhanvien.ChucVu;
            command.Parameters["@SDT"].Value = nhanvien.SDT;
            command.Parameters["@GIOITINH"].Value = nhanvien.GioiTinh;
            command.Parameters["@NGAYSINH"].Value = nhanvien.NgaySinh;
            command.Parameters["@DIACHI"].Value = nhanvien.DiaChi;
            command.Parameters["@LUONG"].Value = nhanvien.Luong;
            command.Parameters["@NGAYVL"].Value = nhanvien.NgayBatDauLamViec;

            // thực hiện câu lệnh
            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }

        public static void Xoa(string manv)
        {
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Xoanhanvien'" + manv + "'";
            //command.CommandText = "DELETE NV FROM NHANVIEN NV " +
            //                      "WHERE NV.MANV='" + manv + "'";
            //command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            // gán giá trị
            //command.Parameters["@MANV"].Value = manv;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable TimTheoMaNV(string manv)
        {
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Timtheo_manv '" + manv + "'";
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

        public static DataTable TimTheoHoTen(string hoten)
        {
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Timtheo_hoten N'" + hoten + "'";
            //command.CommandText = "SELECT * FROM NHANVIEN " +
            //                      "WHERE HOTEN LIKE N'" + hoten + "%'";

            // gán giá trị

            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public static DataTable TimTheoSDT(string sdt)
        {
            SqlConnection connection = SqlServerConnection.KetNoiToiCSDL();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Timtheo_sdt '" + sdt + "'";
            //command.CommandText = "SELECT * FROM NHANVIEN " +
            //                     "WHERE SDT LIKE'" + sdt + "%'";

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
