﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PhimDAO
    {
        public static DataTable LoadDSPhim()
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = " EXEC LoadPhim ";

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static void Them(PhimDTO phim)
        {
            // mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO PHIM VALUES(@MAPHIM,@TENPHIM,@DAODIEN,@DIENVIEN,@MALP,@NOIDUNG,@NAMSX,@NUOCSX,@THOILUONG)";
            command.CommandText = "EXEC Themphim @MAPHIM,@TENPHIM,@DAODIEN,@DIENVIEN,@NOIDUNG,@NAMSX,@NUOCSX,@THOILUONG";
            command.Parameters.Add("@MAPHIM", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TENPHIM", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@DAODIEN", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DIENVIEN", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar, 1000);
            command.Parameters.Add("@NAMSX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NUOCSX", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@THOILUONG", SqlDbType.NVarChar, 100);


            // gán giá trị
            command.Parameters["@MAPHIM"].Value = phim.MaPhim;
            command.Parameters["@TENPHIM"].Value = phim.TenPhim;
            command.Parameters["@DAODIEN"].Value = phim.DaoDien;
            command.Parameters["@DIENVIEN"].Value = phim.DienVien;
            command.Parameters["@NOIDUNG"].Value = phim.NoiDung;
            command.Parameters["@NAMSX"].Value = phim.NamSX;
            command.Parameters["@NUOCSX"].Value = phim.NuocSX;
            command.Parameters["@THOILUONG"].Value = phim.ThoiLuong;
            command.Parameters["@DAODIEN"].Value = phim.DaoDien;


            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }
        public static void Sua(PhimDTO phim)
        {
            // mở kết nối
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            // tạo câu lệnh Thêm
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            //command.CommandText = "INSERT INTO NHANVIEN VALUES(@MANV,@HOTEN,@CHUCVU,@SDT,@GIOITINH,@NGAYSINH,@DIACHI,@LUONG,@NGAYVL)";
            command.CommandText = "EXEC Suaphim @MAPHIM,@TENPHIM,@DAODIEN,@DIENVIEN,@NOIDUNG,@NAMSX,@NUOCSX,@THOILUONG";
            command.Parameters.Add("@MAPHIM", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TENPHIM", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@DAODIEN", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@DIENVIEN", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar, 1000);
            command.Parameters.Add("@NAMSX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NUOCSX", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@THOILUONG", SqlDbType.NVarChar, 100);


            // gán giá trị
            command.Parameters["@MAPHIM"].Value = phim.MaPhim;
            command.Parameters["@TENPHIM"].Value = phim.TenPhim;
            command.Parameters["@DAODIEN"].Value = phim.DaoDien;
            command.Parameters["@DIENVIEN"].Value = phim.DienVien;
            command.Parameters["@NOIDUNG"].Value = phim.NoiDung;
            command.Parameters["@NAMSX"].Value = phim.NamSX;
            command.Parameters["@NUOCSX"].Value = phim.NuocSX;
            command.Parameters["@THOILUONG"].Value = phim.ThoiLuong;
            command.Parameters["@DAODIEN"].Value = phim.DaoDien;
            command.ExecuteNonQuery();

            // đóng kết nối
            connection.Close();
        }
        public static void Xoa(string map)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC Xoaphim '" + map + "'";
            //command.CommandText = "DELETE NV FROM NHANVIEN NV " +
            //                      "WHERE NV.MANV='" + manv + "'";
            //command.Parameters.Add("@MANV", SqlDbType.VarChar, 10);
            // gán giá trị
            //command.Parameters["@MANV"].Value = manv;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable TimtheoMaP(string map)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheoMaP '" + map + "'";
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
        public static DataTable TimTheoTenPhim(string tenp)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC TimTheoTenP '" + tenp + "'";
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

        public static DataTable LoadTheLoaiPhim(string maphim)
        {
            SqlConnection connection = SQLConnectionData.HamKetNoi();
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXEC LoadTheLoaiPhim '" + maphim + "'";
            command.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
    }
}
