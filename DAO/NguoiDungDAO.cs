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
   
    //public class NguoiDungDAO
    //{
    //    //Load danh sách sv từ database
    //    public static DataTable LoadDSND()
    //    {
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();
    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "SELECT * " +
    //                              "FROM NGUOIDUNG ORDER BY STT ASC";

    //        DataTable dataTable = new DataTable();
    //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    //        dataAdapter.Fill(dataTable);
    //        connection.Close();
    //        return dataTable;
    //    }

    //    public static void Them(NguoiDungDTO nguoidung)
    //    {
    //        // mở kết nối
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();

    //        // tạo câu lệnh Thêm
    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        //command.CommandText = "INSERT INTO NHANVIEN VALUES(@MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL)";
    //        command.CommandText = "EXEC Themnhanvien @MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL";
    //        command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
    //        command.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 40);
    //        command.Parameters.Add("@CHUCVU", SqlDbType.VarChar, 100);
    //        command.Parameters.Add("@SDT", SqlDbType.VarChar, 20);
    //        command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 4);
    //        command.Parameters.Add("@NGAYSINH", SqlDbType.Date);
    //        command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);
    //        command.Parameters.Add("@LUONG", SqlDbType.Money);
    //        command.Parameters.Add("@NGAYVL", SqlDbType.Date);

    //        // gán giá trị
    //        command.Parameters["@MANV"].Value = nguoidung.MaNV;
    //        command.Parameters["@HOTEN"].Value = nguoidung.HoTen;
    //        command.Parameters["@CHUCVU"].Value = nguoidung.ChucVu;
    //        command.Parameters["@SDT"].Value = nguoidung.SDT;
    //        command.Parameters["@GIOITINH"].Value = nguoidung.GioiTinh;
    //        command.Parameters["@NGAYSINH"].Value = nguoidung.NgaySinh;
    //        command.Parameters["@DIACHI"].Value = nguoidung.DiaChi;
    //        command.Parameters["@LUONG"].Value = nguoidung.Luong;
    //        command.Parameters["@NGAYVL"].Value = nguoidung.NgayVL;

    //        command.ExecuteNonQuery();

    //        // đóng kết nối
    //        connection.Close();
    //    }

    //    public static void Sua(NguoiDungDTO nguoidung)
    //    {
    //        // mở kết nối
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();

    //        // tạo câu lệnh Sửa
    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "EXEC Suanhanvien @MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL";
    //        //command.CommandText = "UPDATE NHANVIEN " +
    //        //    "SET MANV=@MANV ," +
    //        //    "HOTEN=@HOTEN," +
    //        //    "CHUCVU=@CHUCVU," +
    //        //    "SDT=@SDT," +
    //        //    "GIOITINH=@GIOITINH," +
    //        //    "NGAYSINH=@NGAYSINH," +
    //        //    "DIACHI=@DIACHI," +
    //        //    "LUONG=@LUONG," +
    //        //    "NGAYVL=@NGAYVL " +
    //        //    "WHERE MANV=@MANV";
    //        command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
    //        command.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 40);
    //        command.Parameters.Add("@CHUCVU", SqlDbType.VarChar, 20);
    //        command.Parameters.Add("@SDT", SqlDbType.VarChar, 20);
    //        command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 4);
    //        command.Parameters.Add("@NGAYSINH", SqlDbType.Date);
    //        command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100);
    //        command.Parameters.Add("@LUONG", SqlDbType.Money);
    //        command.Parameters.Add("@NGAYVL", SqlDbType.Date);

    //        // gán giá trị
    //        command.Parameters["@MANV"].Value = nguoidung.MaNV;
    //        command.Parameters["@HOTEN"].Value = nguoidung.HoTen;
    //        command.Parameters["@CHUCVU"].Value = nguoidung.ChucVu;
    //        command.Parameters["@SDT"].Value = nguoidung.SDT;
    //        command.Parameters["@GIOITINH"].Value = nguoidung.GioiTinh;
    //        command.Parameters["@NGAYSINH"].Value = nguoidung.NgaySinh;
    //        command.Parameters["@DIACHI"].Value = nguoidung.DiaChi;
    //        command.Parameters["@LUONG"].Value = nguoidung.Luong;
    //        command.Parameters["@NGAYVL"].Value = nguoidung.NgayVL;

    //        // thực hiện câu lệnh
    //        command.ExecuteNonQuery();

    //        // đóng kết nối
    //        connection.Close();
    //    }

    //    public static void Xoa(string manv)
    //    {
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();
    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "EXEC Xoanhanvien'" + manv + "'";
    //        //command.CommandText = "DELETE NV FROM NHANVIEN NV " +
    //        //                      "WHERE NV.MANV='" + manv + "'";
    //        //command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
    //        // gán giá trị
    //        //command.Parameters["@MANV"].Value = manv;
    //        command.ExecuteNonQuery();
    //        connection.Close();
    //    }

    //    public static DataTable TimTheoMaNV(string manv)
    //    {
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();

    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "EXEC Timtheo_manv '" + manv + "'";
    //        //command.CommandText = "SELECT * FROM NHANVIEN " +
    //        //                      "WHERE MANV LIKE'" + manv + "%'";

    //        // gán giá trị

    //        command.ExecuteNonQuery();
    //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    //        DataTable dataTable = new DataTable();
    //        dataAdapter.Fill(dataTable);
    //        connection.Close();
    //        return dataTable;
    //    }

    //    public static DataTable TimTheoHoTen(string hoten)
    //    {
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();

    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "EXEC Timtheo_hoten N'" + hoten + "'";
    //        //command.CommandText = "SELECT * FROM NHANVIEN " +
    //        //                      "WHERE HOTEN LIKE N'" + hoten + "%'";

    //        // gán giá trị

    //        command.ExecuteNonQuery();
    //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    //        DataTable dataTable = new DataTable();
    //        dataAdapter.Fill(dataTable);
    //        connection.Close();
    //        return dataTable;
    //    }

    //    public static DataTable TimTheoSDT(string sdt)
    //    {
    //        SqlConnection connection = SQLConnectionData.HamKetNoi();
    //        connection.Open();

    //        SqlCommand command = connection.CreateCommand();
    //        command.CommandType = CommandType.Text;
    //        command.CommandText = "EXEC Timtheo_sdt '" + sdt + "'";
    //        //command.CommandText = "SELECT * FROM NHANVIEN " +
    //        //                     "WHERE SDT LIKE'" + sdt + "%'";

    //        // gán giá trị

    //        command.ExecuteNonQuery();
    //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    //        DataTable dataTable = new DataTable();
    //        dataAdapter.Fill(dataTable);
    //        connection.Close();
    //        return dataTable;
    //    }

    //}
}
