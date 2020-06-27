create database DOAN
GO
use DOAN
GO
--DROP DATABASE DOAN
CREATE TABLE NHANVIEN 
(
    STT INT IDENTITY,
	MANV VARCHAR(10) PRIMARY KEY ,
	HOTEN NVARCHAR(40),
	CHUCVU NVARCHAR(100),
	SDT VARCHAR(20),
	GIOITINH NVARCHAR(4) CHECK (GIOITINH IN('Nam',N'NỮ')),
	NGAYSINH DATE,
	DIACHI NVARCHAR(100),
	LUONG MONEY ,
	NGAYVL DATE
)
--DROP TABLE NHANVIEN
GO
SET DATEFORMAT DMY 
INSERT INTO NHANVIEN VALUES ('NV1',N'Trần Nguyễn Thanh Phương',N'Quản trị','098269245',N'Nữ','22/10/1960',N'1/4 Linh Xuân , Thủ Đức, TPHCM',100000000,'10/10/2017')

INSERT INTO NHANVIEN VALUES ('NV2',N'Nguyễn Thiên Hương',N'Nhân viên quản lý phim','0982692456',N'Nữ','22/1/1980',N'12/4 Linh Xuân , Thủ Đức, TPHCM',100000000,'10/10/2017')
INSERT INTO NHANVIEN VALUES ('NV3',N'Trần Nguyễn Trung Quân',N'Nhân viên quản lý phòng chiếu','0982692457','Nam',N'15/10/1982',N'16/4 Linh Xuân , Thủ Đức, TPHCM',100000000,'10/10/2017')
INSERT INTO NHANVIEN VALUES ('NV4',N'Trần Thanh',N'Nhân viên quản lý lịch chiếu','0982692458',N'Nữ','19/11/1972',N'199/4 Linh Trung , Thủ Đức, TPHCM',100000000,'11/10/2017')
INSERT INTO NHANVIEN VALUES ('NV5',N'Nguyễn Thanh Phương',N'Nhân viên quản lý vé','0982692459',N'Nữ','23/11/1990',N'100/7 Linh Trung , Thủ Đức, TPHCM',100000000,'12/8/2017')
INSERT INTO NHANVIEN VALUES ('NV6',N'Trần Thanh Nhàn',N'Nhân viên bán vé','0982692451',N'Nữ','13/6/1978',N'1/4 Linh Tây , Thủ Đức, TPHCM',100000000,'11/2/2017')

--INSERT INTO NHANVIEN VALUES ('NV7',N'Trần Đức Minh',N'Quản Lý','0982692145','Nam','3/4/1974',N'12/5 Linh Tây, Thủ Đức, TPHCM',20000000,'10/11/2017')
--INSERT INTO NHANVIEN VALUES ('NV8',N'Nguyễn Trung Kiên',N'Nhân Viên Bán Hàng','0982692124','Nam','12/6/1980',N'123A Q9 , TPHCM',100000000,'15/2/2017')
--INSERT INTO NHANVIEN VALUES ('NV9',N'Nguyễn Đức Quốc',N'Nhân Viên Bán Hàng','0982692123','Nam','9/3/1970',N'123/45 Linh Trung, Thủ Đức, TPHCM',10000000,'10/11/2017')
--INSERT INTO NHANVIEN VALUES ('NV10',N'Trần Thị Mai Tính',N'Nhân Viên Bán Hàng','0962482746',N'Nữ','10/3/1980',N'12/5 Linh Xuân, Thủ Đức, TPHCM',10000000,'10/8/2017')
--INSERT INTO NHANVIEN VALUES ('NV11',N'Lương Công Hải',N'Nhân Viên Vệ Sinh','0927384721','Nam','10/1/1981',N'13/4 Linh Tây, Thủ Đức, TPHCM',5000000,'10/1/2017')
--INSERT INTO NHANVIEN VALUES ('NV12',N'Trần Viễn',N'Nhân Viên Bán Hàng','0948693723',N'Nữ','3/9/1979',N'12A/45 Trảng Bom, Đồng Nai',10000000,'8/2/2017')
--INSERT INTO NHANVIEN VALUES ('NV13',N'Trần Nguyễn Thanh Trúc',N'Quản Lý','0927384951',N'Nữ','2/5/1983',N'123/45 Quận 1, TPHCM',20000000,'20/1/2017')
--INSERT INTO NHANVIEN VALUES ('NV14',N'Phạm Ngọc Anh Tín',N'Giám Đốc','09463859371','Nam','15/10/1985',N' Quận 1, TPHCM',0,'10/12/2017')
--INSERT INTO NHANVIEN VALUES ('NV15',N'Nguyễn Hà ',N'Thủ Kho','0985472849',N'Nữ','31/12/1981',N'100/35 Linh Tây, Thủ Đức, TPHCM',15000000,'17/11/2017')
--INSERT INTO NHANVIEN VALUES ('NV16',N'Phạm Thanh Thiên Trúc',N'Thủ Kho','0982285392',N'Nữ','6/4/1971',N'121/5 Lê Đại Hành , Quận Bình Thạnh, TPHCM',15000000,'15/12/2017')
--INSERT INTO NHANVIEN VALUES ('NV17',N'Phạm Ngọc Anh',N'Thủ Kho','0903958271','Nam','25/10/1995',N'119 Tôn Thất Đạm, P. Bến Nghé, Quận 1, TP. HCM',150000000,'13/6/2017')
--INSERT INTO NHANVIEN VALUES ('NV18',N'Nguyễn Ngọc Quý',N'Thủ Kho','0957263689','Nam','15/10/1996',N'12 Tôn Thất Tùng, P. Bến Nghé, Quận 3, TP. HCM',150000000,'8/7/2017')
--INSERT INTO NHANVIEN VALUES ('NV19',N'Ngô Thanh Trọng',N'Thủ Kho','0957676689','Nam','28/3/1993',N'67/4/118 Vũ Huy Tấn, P. 3,  Quận Bình Thạnh, TP. HCM',150000000,'12/7/2017')
--INSERT INTO NHANVIEN VALUES ('NV20',N'Nguyễn Duy Thành',N'Thủ Kho','0953857361','Nam','21/5/1991',N'181/2 Đường 3 Tháng 2,  Quận 10, TP. HCM',150000000,'22/1/2017')

go
create PROC LoadNhanVien
as
begin
SELECT * FROM NHANVIEN ORDER BY STT ASC
end


go
----PROC THEMNHANVIEN
create PROC Themnhanvien(@manv varchar(10),@hoten NVARCHAR(40),@chucvu NVARCHAR(100),@sdt VARCHAR(20),@gioitinh NVARCHAR(4),
@ngaysinh DATE,@diachi NVARCHAR(100),@luong MONEY,@ngayvl DATE)
as
begin
 insert into NHANVIEN(MANV,HOTEN,CHUCVU,SDT,GIOITINH,NGAYSINH,DIACHI,LUONG,NGAYVL) VALUES (@manv,@hoten,@chucvu,@sdt,@gioitinh,@ngaysinh,@diachi,@luong,@ngayvl)
end

 go
 -----PROC XOANHANVIEN
 CREATE PROC Xoanhanvien(@manv varchar(10) )
 as
 DELETE FROM NHANVIEN 
  WHERE NHANVIEN.MANV=@manv

  go
  ---PROC SUANHANVIEN
  CREATE PROC Suanhanvien(@manv varchar(10),@hoten NVARCHAR(40),@chucvu NVARCHAR(100),@sdt VARCHAR(20),@gioitinh NVARCHAR(4),
  @ngaysinh DATE,@diachi NVARCHAR(100),@luong MONEY,@ngayvl DATE)
  as
  begin
  update NHANVIEN
  set MANV=@manv,
  HOTEN=@hoten,
  CHUCVU=@chucvu,
  SDT=@sdt,
  GIOITINH=@gioitinh,
  NGAYSINH=@ngaysinh, DIACHI=@diachi,LUONG=@luong,NGAYVL=@ngayvl
  WHERE MANV=@manv
  end

  go
   -----PROC TIMTHEOMANV
  CREATE PROC Timtheo_manv(@manv varchar(10))
  as
  begin
  select *from NHANVIEN where MANV like '%'+ @manv +'%'
  end
  -- drop PROC Timtheo_manv
  -- exec Timtheo_manv 'NV'

  go
  ---PROC TIMTHEOHOTEN
  CREATE PROC Timtheo_hoten(@hoten nvarchar(40))
  as
  begin
  select *from NHANVIEN where HOTEN like '%'+ @hoten +'%'
  --select * from NHANVIEN where lower(HOTEN) like '%' + lower(RTRIM(@hoten)) + '%'
  end

  -- drop proc Timtheo_hoten
  --select *from NHANVIEN where HOTEN like N''
 -- exec Timtheo_hoten N'Trần'
  go
  -------PROC TIMTHEOSDT
  CREATE PROC Timtheo_sdt(@sdt varchar(20))
  as
  select *from NHANVIEN where SDT like '%'+ @sdt +'%'

  go
CREATE TABLE DANGNHAP_NHANVIEN
(
MANV VARCHAR(10),
TAIKHOAN VARCHAR(50),
MATKHAU VARCHAR(50),
CONSTRAINT PK_DANGNHAP_NHANVIEN PRIMARY KEY(MANV,MATKHAU),
CONSTRAINT FK_DANGNHAP_NHANVIEN_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV) ON DELETE CASCADE
)

INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV1','thanhphuong','thanhphuong')
INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV2','thienhuong','thienhuong')
INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV3','trungquan','trungquan')
INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV4','tranthanh','tranthanh')
INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV5','nthanhphuong','nthanhphuong')
INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV6','thanhnhan','thanhnhan')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV7','ducminh','ducminh')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV8','trungkien','trungkien')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV9','ducquoc','ducquoc')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV10','maitinh','maitinh')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV15','nguyenha','nguyenha')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV16','thientruc','thientruc')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV11','conghai','conghai')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV12','tranvien','tranvien')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV13','thanhtruc','thanhtruc')
--INSERT INTO DANGNHAP_NHANVIEN VALUES ('NV14','anhtin','anhtin')
go
  CREATE PROC Dangnhapnhanvien(@user varchar(50),@pass varchar(50))
as SELECT NV.HOTEN,NV.CHUCVU,NV.SDT,DN.TAIKHOAN,DN.MATKHAU FROM DANGNHAP_NHANVIEN DN INNER JOIN NHANVIEN NV ON DN.MANV=NV.MANV
   WHERE DN.TAIKHOAN =@user and DN.MATKHAU=@pass
go
---PROC DANGNHAP
 CREATE PROC Phanquyennhanvien(@user varchar(50),@pass varchar(50))
 as 
 begin
 SELECT NV.CHUCVU,DN.TAIKHOAN,DN.MATKHAU FROM DANGNHAP_NHANVIEN DN INNER JOIN NHANVIEN NV ON DN.MANV=NV.MANV
  WHERE DN.TAIKHOAN =@user and DN.MATKHAU=@pass
end

go
CREATE PROC PhanQuyen(@user varchar(50),@pass varchar(50))
as 
begin
SELECT ND.PHANQUYEN FROM DANGNHAP_NHANVIEN DN INNER JOIN NHANVIEN NV ON DN.MANV=NV.MANV INNER JOIN NGUOIDUNG ND ON ND.MAND=NV.MANV WHERE DN.TAIKHOAN = 'thanhphuong' and DN.MATKHAU='thanhphuong'
end
-- exec PhanQuyen 'thanhphuong','thanhphuong'
GO
CREATE TABLE KHACHHANGTHANTHIET
(
    STT INT IDENTITY,
	MAKH VARCHAR(10) PRIMARY KEY ,
	HOTEN NVARCHAR(40) ,
	DIACHI NVARCHAR(100) ,
	NGAYSINH DATE,
	GIOITINH NVARCHAR(4) check (GIOITINH IN ('Nam',N'Nữ')),
	SDT VARCHAR(20),
	LOAIKH NVARCHAR(50), -- cái này sẽ cút MALOAIKH
	NGAYDK DATE
)

--CREATE TABLE LOAIKHACHHANG
--(
--    MALOAIKH NVARCHAR(50),
--	TENLOAIKH NVARCHAR(50),
--	MUCGIAMGIA INT -- PHAN TRAM
--)

INSERT INTO KHACHHANGTHANTHIET (MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES 
('KH1',N'Nguyễn Văn An',N'731 Trần Hưng Đạo, Q5, TpHCM','08823451','22/10/1960','Nam',N'Bạc','22/07/2018'),
('KH2',N'Trần Ngọc Hân',N'23/5 Nguyễn Trãi, Q5, TpHCM','0908256478','3/4/1974',N'Nữ',N'Vàng','30/07/2018'),
('KH3',N'Trần Ngọc Linh',N'45 Nguyen Tất Thành, Q1, TpHCM','0938776266','12/6/1980',N'Nữ',N'Đồng','05/08/2018'),
('KH4',N'Trần Minh Long',N'50/34 Lê Đại Hành, Q10, TpHCM','0917325476','9/3/1965','Nam',N'Đồng','02/10/2017'),
('KH5',N'Lê Nhật Minh',N'34 Trương Định, Q3, TpHCM','08246108','10/3/1950','Nam',N'Bạc','28/10/2018'),
('KH6',N'Lê Hoài Thương',N'227 Nguyễn Văn Cừ,Q5,TpHCM','08631738','31/12/1981',N'Nữ',N'Vàng','4/10/2018'),
('KH7',N'Nguyễn Văn Tám',N'32/3 Trần Bình Trọng, Q5, TpHCM','0916783565','6/4/1971','Nam',N'Đồng','3/4/2018'),
('KH8',N'Phan Thị Thanh',N'45/2 An Dương Vương, Q5, TpHCM','0938435756','10/1/1971',N'Nữ',N'Đồng','3/10/2017'),
('KH9',N'Lê Hà Vinh',N'873 Lê Hồng Phong, Q5, TpHCM','08654763','3/9/1979','Nam',N'Bạc','2/10/2018'),
('KH10',N'Hà Duy Lập',N'34/34B Nguyễn Trãi, Q1, TpHCM','08768904','2/5/1983','Nam',N'Đồng','28/1/2018'),
('KH11',N'Qua Văn Cầu',N'50/34 Nguyễn Thị Minh Khai, Q10, TpHCM','0917325472','9/5/1975','Nam',N'Bạc','15/12/2018'),
('KH12',N'Trương Minh Điền',N'36 Trương Định, Q5, TpHCM','082461089','10/3/1990','Nam',N'Bạch kim','5/9/2017'),
('KH13',N'Lê Hoài Nam',N'227/2 Nguyễn Văn Cừ,Q5,TpHCM','086317380','31/10/1981','Nam',N'Kim cương','21/4/2018'),
('KH14',N'Nguyễn Văn Long',N'32/3 Lương Định Của, Q5, TpHCM','0916735650','6/4/1980','Nam',N'Bạch kim','28/8/2018'),
('KH15',N'Phan Thị Thanh Nhàn',N'12/2 An Dương Vương, Q6, TpHCM','0948435756','10/12/1972',N'Nữ',N'Bạc','5/10/2018'),
('KH16',N'Trần Khôi Nguyên',N'873 Trần Đại Nghĩa, Q5, TpHCM','086547632','12/4/1997','Nam',N'Kim cương','15/4/2018')
INSERT INTO KHACHHANGTHANTHIET (MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES 
('KH17',N'Bùi Minh Hiếu',N'34 Phạm Ngũ Lão, Q10, TpHCM','087689304','24/9/1984','Nam',N'Bạch kim','11/12/2018'),
('KH18',N'Lê Đức Thắng',N'104 CMT8, Q11, TpHCM','08654763','20/10/2000','Nam',N'Đồng','13/2/2018'),
('KH19',N'Phạm Công Minh',N'1 Nguyễn Trãi, Q8, TpHCM','087689042','5/6/1977','Nam',N'Bạc','2/5/2018'),
('KH20',N'Trần Trung Nghĩa',N'50 Nguyễn Thị Minh Khai, Q10, TpHCM','0917325272','12/1/1975','Nam',N'Đồng','31/12/2018'), ('KH21',N'Lê Trọng Hiếu',N'32 Võ Thị Sáu, Bình Thạnh, TpHCM','082431089','10/4/1995','Nam',N'Bạc','12/11/2018'),
('KH22',N'Lê Hoài Nam',N'227/2 Nguyễn Thị Minh Khai,Q7,TpHCM','086323480','22/11/1982','Nam',N'Vàng','25/4/2018'),
('KH23',N'Nguyễn Hồng Phương Nhi',N'25 Tôn Đức Thắng, Gò Vấp, TpHCM','091621350','5/6/1995',N'Nữ',N'Bạch kim','10/5/2018'),
  ('KH24',N'Phan Thanh Nhàn',N'30/4 Bến Vân Đồn, Q6, TpHCM','0941233756','10/12/1982',N'Nữ',N'Đồng','22/7/2018'),
  ('KH25',N'Trần Nguyễn Hoàng Quý',N'123 Linh Trung , Thủ Đức','0236547632','12/4/1997','Nam',N'Đồng','30/5/2018'),
  ('KH26',N'Trần Long',N'12/4 Linh Tây, Thủ Đức, TpHCM','087689214','3/6/1978','Nam',N'Vàng','10/3/2018'),
  ('KH27',N'Nguyễn Tự Long',N'3 Trần Đại Nghĩa, Q7, TpHCM','09167231650','3/6/1997','Nam',N'Bạch kim','20/5/2018'),
  ('KH28',N'Đào Như ý',N'15/2 An Dương Vương, Q6, TpHCM','0943125756','12/10/1982',N'Nữ',N'Vàng','10/1/2018'),
  ('KH29',N'Trần Khôi Ngô Tuấn Tú',N'231 Trần Đại Nghĩa, Q5, TpHCM','086521332','14/4/1997','Nam',N'Bạc','28/5/2018'),
  ('KH30',N'Phan Hải Đăng',N'34/34 Lý Thái Tổ , Q10, TpHCM','097622104','20/5/1999','Nam',N'Đồng','29/4/2018'),
  ('KH31',N'Hà Đức Huy',N'61 Quang Trung, P. 10, Gò Vấp, TP. HCM','0983295462','16/5/1999','Nam',N'Vàng','23/11/2018'),
  ('KH32',N'Phạm Thị Quỳnh Mai',N'58 Hữu Nghị, P. Bình Thọ, Thủ Đức, TP. HCM','0916987276','20/2/1994',N'Nữ',N'Đồng','18/2/2018'),
  ('KH33',N'Lê Hoài Thu',N'39A Gò Dưa, P. Tam Bình, Thủ Đức, TP. HCM','0907149571','26/4/1982',N'Nữ',N'Bạc','3/7/2018'),
  ('KH34',N'Lê Bích Hường',N'5 Đường Số 5, Thủ Đức, TP. HCM','0963085555','13/7/1989',N'Nữ',N'Vàng','21/4/2018'),
  ('KH35',N'Trần Thị Lan Hương',N'778 Kha Vạn Cân, P. Linh Đông, Thủ Đức, TP. HCM','0948020886','2/6/1983',N'Nữ',N'Bạc','10/9/2018'),
  ('KH36',N'Nguyễn Thu Hương',N'6 Lưu Văn Lang, Quận 1, TP. HCM','0946126969','31/5/1995',N'Nữ',N'Bạch kim','13/4/2018'),
  ('KH37',N'Nguyễn Thị Thu Hà',N'34 Đường Số 11, P. 11, Gò Vấp, TP. HCM','0915161646','16/9/1999',N'Nữ',N'Đồng','4/3/2018'),
  ('KH38',N'Nguyễn Tiến Dũng',N'45 Hoàng Hoa Thám, P. 13, Tân Bình, TP. HCM','0973780808','7/10/1993','Nam',N'Bạc','15/4/2018'),
  ('KH39',N'Nguyễn Văn Trường',N'40/3 Phạm Viết Chánh, P. 19, Bình Thạnh, TP. HCM','0975136968','26/12/1990','Nam',N'Kim cương','25/12/2018'),
  ('KH40',N'Ngô Thị Quyết',N'63 Thống Nhất, P. Bình Thọ, Thủ Đức, TP. HCM','0912624767','8/11/1991','Nam',N'Đồng','18/2/2018'),
  ('KH41',N'Nguyễn Thu Huyền',N'124 Nguyễn Xí, P. 26, Bình Thạnh, TP. HCM','0913259118','1/5/1987',N'Nữ',N'Vàng','5/12/2018'),
  ('KH42',N'Nguyễn Anh Sơn',N'298 Nguyễn Văn Khối,(Cây Trâm) P. 8, Gò Vấp, TP. HCM','0988199968','10/3/1993','Nam',N'Bạc','13/7/2018')
INSERT INTO KHACHHANGTHANTHIET (MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES 
('KH43',N'Trần Thị Ngọc',N'115/20 Nguyễn Duy Cung, Gò Vấp, TP. HCM','0937560696','12/1/1987',N'Nữ',N'Đồng','24/2/2018'),
('KH44',N'Nguyễn Thị Ngọc Diệp',N'Chung Cư An Lộc, Nguyễn Oanh, P. 17, Gò Vấp, TP. HCM','0983448686','27/8/1995',N'Nữ',N'Kim cương','15/4/2018'),
('KH45',N'Triệu Thị Thức',N'36/2A Hoàng Xuân Nhị, P. Phú Trung, Tân Phú, TP. HCM','0988428080','26/7/1989',N'Nữ',N'Bạc','23/7/2018'),
('KH46',N'Cao Trọng Việt',N'401 Lê Văn Thọ, P. 9, Gò Vấp, TP. HCM','0989674906','29/6/1991','Nam',N'Đồng','15/8/2018'),
('KH47',N'Hoàng Đức Anh',N'236/19/13 Điện Biên Phủ, P. 17, Bình Thạnh, TP. HCM','0989455028','1/10/1997',N'Nữ',N'Bạch kim','20/1/2018'),
('KH48',N'Hoàng Đức Anh',N'22A Đường Số 19, P. Hiệp Bình Chánh, Thủ Đức, TP. HCM','0987932912','20/5/1993',N'Nữ',N'Bạc','19/4/2018'),
('KH49',N'Nguyễn Trung Hiếu',N'376 Lê Văn Thọ, P. 11, Gò Vấp, TP. HCM','0943548668','4/3/1994','Nam',N'Đồng','15/10/2018'),
('KH50',N'Phạm Thị Tuyết Mai',N'14 Đường Số 12, P. 11, Gò Vấp, TP. HCM','01687890731','6/7/1990',N'Nữ',N'Vàng','5/4/2018'),
('KH51',N'Bùi Huy Thiêm',N'2 Bùi Quang Là, P. 12, Gò Vấp, TP. HCM','0987064996','2/9/1985','Nam',N'Bạc','15/3/2018'),
('KH52',N'Ngô Thị Hạnh',N'78/31 Đường Số 11, Gò Vấp, TP. HCM','0912177899','13/5/1998',N'Nữ',N'Kim cương','4/4/2018'),
('KH53',N'Nguyễn Tiến Sơn',N'273/69/2/5 Nguyễn Văn Đậu, Bình Thạnh, TP. HCM','0906013344','24/6/1998','Nam',N'Đồng','15/9/2018'),
('KH54',N'Nguyễn Văn Sáng',N'202 Nguyễn Văn Khối, P. 9, Gò Vấp, TP. HCM','0975056855','8/8/1998','Nam',N'Đồng','26/4/2018'),
('KH55',N'Lương Quang Tuấn',N'50 Đường C18, P. 12, Tân Bình, TP. HCM','0976654109','29/5/1998','Nam',N'Bạc','11/2/2018'),
('KH56',N'Nguyễn Thị Thúy',N'8C Nguyễn Ngọc Phương, P. 19, Bình Thạnh, TP. HCM','0936407737','14/9/1998',N'Nữ',N'Kim cương','15/11/2018'),
('KH57',N'Nguyễn Thúy Ngân',N'Park 4, Vinhomes Central Park, 208 Nguyễn Hữu Cảnh, P. 22, Bình Thạnh, TP. HCM','0961109658','23/12/1998',N'Nữ',N'Đồng','3/4/2018'),
('KH58',N'Nguyễn Thị Phượng',N'31 Điện Biên Phủ, P. 15, Bình Thạnh, TP. HCM','0944130684','15/1/1998',N'Nữ',N'Vàng','23/12/2018'),
('KH59',N'Ngô Tùng Quân',N'350/1B Nguyễn Văn Khối, Gò Vấp, TP. HCM','0943805555','28/3/1998','Nam',N'Bạc','15/7/2018')
INSERT INTO KHACHHANGTHANTHIET (MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES 
('KH60',N'Nguyễn Trọng Tú',N'171 Calmette, Quận 1','0945290268','25/4/1998','Nam',N'Đồng','13/4/2018'),
('KH61',N'Trương Sơn',N'94 Xuân Thủy, P. Thảo Điền, Quận 2','0913067704','26/8/1993','Nam',N'Đồng','15/5/2018'),
('KH62',N'Nguyễn Thị Thanh Bình',N'306 Nguyễn Thượng Hiền, P. 5, Quận Phú Nhuận','0906200318','5/4/1995',N'Nữ',N'Đồng','18/4/2018'),
('KH63',N'Nguyễn Khắc Hiếu',N'131 Hoàng Hoa Thám, P. 13, Quận Tân Bình','0915868634','13/9/1989','Nam',N'Bạc','15/10/2018'),
('KH64',N'Nguyễn Thùy Dung',N'254 Điện Biên Phủ, P. 7, Quận 3','0972635295','10/10/1986',N'Nữ',N'Bạch kim','24/12/2018'),
('KH65',N'Bùi Tuấn Dương',N'436 Nguyễn Thị Thập, P. Tân Quy, Quận 7','0968083038','4/2/1996','Nam',N'Đồng','15/11/2018'),
('KH66',N'Trần Quốc Hưng',N' 20 Cộng Hòa, P. 12, Quận Tân Bình','0913280023','6/1/1998','Nam',N'Bạc','12/4/2018'),
('KH67',N'Nguyễn Thị Hoan',N'32 Hoa Mai, P. 2, Quận Phú Nhuận','01648805576','11/9/1991',N'Nữ',N'Kim cương','15/10/2018'),
('KH68',N'Võ Thị Phương Thảo',N'151E Hai Bà Trưng, P. 6, Quận 3','0932233220','23/3/1993',N'Nữ',N'Đồng','5/4/2018'),
('KH69',N'Đặng Đức Long',N'200A Lý Tự Trọng (Ngã 4 Trương Định), Quận 1','0914371146','12/7/1992','Nam',N'Vàng','15/12/2018'),
('KH70',N'Nguyễn Văn Lâm',N'52 Mạc Đĩnh Chi, P. Đakao, Quận 1','0945199968','15/5/1994','Nam',N'Bạc','29/4/2018'),
('KH71',N'Lê Thị Kim Chi',N'14 Lê Quý Đôn, P. 6, Quận 3','0983388625','23/2/2000',N'Nữ',N'Đồng','15/8/2018'),
('KH72',N'Huỳnh Thị Hải Vân',N'77 Cộng Hoà, P. 4, Quận Tân Bình','0989089606','9/3/1994',N'Nữ',N'Đồng','25/4/2018'),
('KH73',N'Lê Minh Đức',N'476 Nguyễn Chí Thanh, Quận 10','0912261227','18/8/1995','Nam',N'Bạc','15/1/2018'),
('KH74',N'Nguyễn Thị Thanh Hoa',N'15 Lê Quý Đôn, P. 6, Quận 3','0904595950','21/4/1997',N'Nữ',N'Đồng','17/4/2018'),
('KH75',N'Trịnh Tuấn Anh',N'230 Nguyễn Tri Phương, P. 4, Quận 10','0988356206','27/2/1994','Nam',N'Kim cương','15/10/2018'),
('KH76',N'Phùng Thị Hằng',N'19 Hồ Xuân Hương, P. 6, Quận 3','0944407968','25/5/1992',N'Nữ',N'Bạc','4/4/2018'),
('KH77',N'Ngô Xuân Thanh',N'109 Lý Tự Trọng, Quận 1','0913518780','23/4/1991','Nam',N'Đồng','15/12/2018'),
('KH78',N'Nguyễn Hải Yến',N'17/11 Lê Thánh Tôn (Mặt Tiền), Quận 1','01252791111','21/6/1989',N'Nữ',N'Đồng','29/5/2018'),
('KH79',N'Dương Bích Hiền',N'Tầng 2 Estella Place, 88 Song Hành, P. An Phú, Quận 2','0902198052','11/8/1984',N'Nữ',N'Đồng','15/2/2018')
INSERT INTO KHACHHANGTHANTHIET (MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES 
('KH80',N'Nguyễn Anh Việt',N'745/13 Lạc Long Quân, P.14, Tân Bình, TP.HCM','01234669955','9/7/1981','Nam',N'Bạc','17/5/2018'),
('KH81',N'Bùi Xuân Quang',N'52 Thạch Thị Thanh, P. Tân Định, Quận 1','0989992169','20/12/1989','Nam',N'Vàng','30/4/2018'),
('KH82',N'Nguyễn Hoàng Hiếu',N'285 Cách Mạng Tháng 8, P. 12, Quận 10','01213146688','16/10/1988','Nam',N'Đồng','1/2/2018'),
('KH83',N'Tạ Thị Thu Hương',N'92 Nam Kỳ Khởi Nghĩa, Quận 1','01693118338','11/8/1986',N'Nữ',N'Bạch kim','26/4/2018'),
('KH84',N'Nguyễn Thị Tú Ngọc',N'345 Bến Bình Đông, P. 13, Quận 8, TP. HCM','0915551975','12/1/1994',N'Nữ',N'Bạc','15/1/2018'),
('KH85',N'Nguyễn Mạnh Tùng',N'809/23G Trần Hưng Đạo, P. 1, Quận 5, TP. HCM','0969390899','26/2/1999','Nam',N'Đồng','16/3/2018'),
('KH86',N'Vũ Thị Tuyết',N'C3/21T Phạm Hùng, Xã Bình Hưng, Bình Chánh, TP. HCM','0977110966','18/3/1992',N'Nữ',N'Kim cương','3/8/2018'),
('KH87',N'Phạm Văn Sơn',N'219 Đề Thám, P. Phạm Ngũ Lão, Quận 1, TP. HCM','0912078292','10/2/1995','Nam',N'Bạc','6/4/2018'),
('KH88',N'Nguyễn Thị Thu Trang',N'309/1 Nguyễn Văn Trỗi, P. 1, Tân Bình, TP. HCM','0983588082','18/8/1997',N'Nữ',N'Đồng','28/1/2018'),
('KH89',N'Nguyễn Thu Phương',N'17A Nguyễn Thị Minh Khai, P. Bến Nghé, Quận 1, TP. HCM','0982903676','27/9/1998',N'Nữ',N'Kim cương','24/11/2018'),
('KH90',N'Trịnh Thu Hồng',N'229/24 Tân Kỳ Tân Quý, P. Tân Sơn Nhì, Tân Phú, TP. HCM','0913564202','1/7/1992',N'Nữ',N'Đồng','17/4/2018'),
('KH91',N'Bùi Thị Thu Thủy',N'449C Trần Hưng Đạo, P. Cầu Kho, Quận 1, TP. HCM','0914884257','26/2/1990',N'Nữ',N'Bạc','15/2/2018'),
('KH92',N'Trần Bích Trâm',N'239 Đường Số 8, P. 11, Gò Vấp, TP. HCM','0983633890','18/8/1985',N'Nữ',N'Vàng','14/7/2018'),
('KH93',N'Nguyễn Khánh Linh',N'836 Phạm Văn Đồng, P. Hiệp Bình Chánh, Thủ Đức, TP. HCM','0944476305','27/9/1994',N'Nữ',N'Đồng','9/12/2018'),
('KH94',N'Nguyễn Thị Thanh',N'220/68/5 Âu Cơ, P. 9, Tân Bình, TP. HCM','0981230678','13/6/1993',N'Nữ',N'Đồng','15/6/2018'),
('KH95',N'Trần Thế Anh',N'158/202 Phạm Văn Hai, P.3, Tân Bình , TP.HCM','0948200666','3/7/1996','Nam',N'Bạc','24/4/2018'),
('KH96',N'Bùi Đăng Thắng',N'140/2 Phạm Văn Chiêu, P.9, Gò Vấp, TP.HCM','0966277447','25/8/1998','Nam',N'Đồng','15/3/2018'),
('KH97',N'Nguyễn Đức Tá',N'229/25 Tuy Lý Vương, P.12, Quận 8, TP.HCM','0986456282','10/12/1999','Nam',N'Kim cương','20/6/2018'),
('KH98',N'Đỗ Thị Bích Vân',N'95/29 Đinh Tiên Hoàng, P.3, Bình Thạnh, TP.HCM','0912758399','29/6/1996',N'Nữ',N'Bạc','1/12/2018'),
('KH99',N'Hoàng Trọng Chính',N'320 Cộng Hòa, P.13, Tân Bình, TP.HCM','0986196068','12/4/1993','Nam',N'Đồng','21/4/2018'),
('KH100',N'Trần Anh Tuấn',N'142/8/3 Lê Lợi, P.4, Gò Vấp, TP.HCM','0987685085','5/1/1994','Nam',N'Bạch kim','15/5/2018')

go
create PROC LoadKhachHang
as
begin
SELECT * FROM KHACHHANGTHANTHIET ORDER BY STT ASC
end

go
---PROC THEMKHACHHANG
create PROC Them_khachhang( @makh varchar(10),@hoten NVARCHAR(40),@diachi NVARCHAR(100),@ngaysinh DATE,@gioitinh nvarchar(4), @sdt varchar(20) ,@loaikh NVARCHAR(50),@ngaydk date)
as
begin
 insert into KHACHHANGTHANTHIET(MAKH,HOTEN,DIACHI,SDT,NGAYSINH,GIOITINH,LOAIKH,NGAYDK) VALUES (@makh,@hoten,@diachi,@sdt,@ngaysinh,@gioitinh,@loaikh,@ngaydk)
end

 go
 ---EXEC Them_khachhang 'KH101',N'Trần Anh Tuấn',N'142/8/3 Lê Lợi, P.4, Gò Vấp, TP.HCM','0987685085','5/1/1994','Nữ',N'Bạch kim','15/5/2018'
----PROC XOAKHACHAHANG
 CREATE PROC Xoakhachhang(@makh varchar(10) )
 as
 DELETE FROM KHACHHANGTHANTHIET
  WHERE KHACHHANGTHANTHIET.MAKH=@makh

  go
  ---PROC SUANHANVIEN
  CREATE PROC Suakhachhang(@makh varchar(10),@hoten NVARCHAR(40),@diachi NVARCHAR(100),@ngaysinh DATE,@gioitinh nvarchar(4), @sdt varchar(20) ,@loaikh NVARCHAR(50),@ngaydk date)
as
begin
update KHACHHANGTHANTHIET
  set MAKH=@makh,
  HOTEN=@hoten,
  DIACHI=@diachi,
  NGAYSINH=@ngaysinh,
  NGAYDK=@ngaydk,
  GIOITINH=@gioitinh,
  SDT=@sdt,
  LOAIKH=@loaikh
  WHERE MAKH=@makh
end

 go
---PROC TIMTHEOHOTEN
  CREATE PROC Timkhachhang_hoten(@hoten nvarchar(40))
  as
  begin
 select * from KHACHHANGTHANTHIET where HOTEN like '%'+ @hoten +'%'
  end

-- drop proc Timkhachhang_hoten
-- exec Timkhachhang_hoten N'Nguyễn'
go
----PROC TIMTHEOsdt
CREATE PROC Timkhachhang_sdt(@sdt varchar(20))
as 
begin
 select *from KHACHHANGTHANTHIET where SDT like '%'+ @sdt +'%'
 end

go
----PROC TIMTHEOmakh
CREATE PROC Timkhachhang_makh(@makh varchar(10))
as begin
select *from KHACHHANGTHANTHIET where MAKH like '%'+ @makh +'%'
end

GO
CREATE TABLE DANGNHAP_KHACHHANG
(
MAKH VARCHAR(10),
TAIKHOAN VARCHAR(50),
MATKHAU VARCHAR(50),
CONSTRAINT PK_DANGNHAP_KHACHHANG PRIMARY KEY(MAKH,MATKHAU),
CONSTRAINT FK_DANGNHAP_KHACHHANG_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANGTHANTHIET(MAKH) ON DELETE CASCADE
)

INSERT INTO DANGNHAP_KHACHHANG VALUES ('KH1','thanhphuong','thanhphuong')
INSERT INTO DANGNHAP_KHACHHANG VALUES ('KH2','thienhuong','thienhuong')
INSERT INTO DANGNHAP_KHACHHANG VALUES ('KH3','trungquan','trungquan')
INSERT INTO DANGNHAP_KHACHHANG VALUES ('KH4','tranthanh','tranthanh')

go
CREATE PROC Phanquyenkhachhang(@user varchar(50),@pass varchar(50))
as 
begin
 SELECT KH.LOAIKH,DN.TAIKHOAN,DN.MATKHAU FROM DANGNHAP_KHACHHANG DN INNER JOIN KHACHHANGTHANTHIET KH ON DN.MAKH=KH.MAKH
   WHERE DN.TAIKHOAN =@user and DN.MATKHAU=@pass
end
 
  go
  CREATE PROC Dangnhapkhachhang(@user varchar(50),@pass varchar(50))
as
begin
 SELECT KH.HOTEN,KH.LOAIKH,KH.SDT,DN.TAIKHOAN,DN.MATKHAU FROM DANGNHAP_KHACHHANG DN INNER JOIN KHACHHANGTHANTHIET KH ON DN.MAKH=KH.MAKH
   WHERE DN.TAIKHOAN =@user and DN.MATKHAU=@pass
end

go
CREATE TABLE NGUOIDUNG
(
    STT INT IDENTITY,
	MAND VARCHAR(10) PRIMARY KEY ,
	HOTEN NVARCHAR(40),
	CHUCVU NVARCHAR(100),
	PHANQUYEN NVARCHAR(100),
	CONSTRAINT FK_NGUOIDUNG_MAND FOREIGN KEY(MAND) REFERENCES NHANVIEN(MANV) ON DELETE CASCADE
)

INSERT INTO NGUOIDUNG( MAND,HOTEN,CHUCVU,PHANQUYEN) VALUES 
('NV1',N'Trần Nguyễn Thanh Phương',N'Quản trị',N'Quản trị'),
('NV2',N'Nguyễn Thiên Hương ',N'Nhân viên quản lý phim',N'Quản lý phim, Quản lý loại phim'),
('NV3',N'Trần Nguyễn Trung Quân',N'Nhân viên quản lý phòng chiếu',N'Quản lý phòng chiếu'),
('NV4',N'Trần Thanh',N'Nhân viên quản lý lịch chiếu',N'Quản lý lịch chiếu'),
('NV5',N'Nguyễn Thanh Phương',N'Nhân viên quản lý vé',N'Quản lý loại vé, Quản lý vé')
--drop table NGUOIDUNG

go
----PROC THEMNGUOIDUNG
create PROC ThemNguoiDung(@mand varchar(10),@hoten NVARCHAR(40),@chucvu NVARCHAR(100),@phanquyen NVARCHAR(100))
as
begin
 insert into NGUOIDUNG(MAND,HOTEN,CHUCVU,PHANQUYEN) VALUES (@mand,@hoten,@chucvu,@phanquyen)
 end

 go
 -----PROC XOANGUOIDUNG
 CREATE PROC XoaNguoiDung(@mand varchar(10))
 as
 begin
 DELETE FROM NGUOIDUNG 
  WHERE NGUOIDUNG.MAND=@mand
end

-- exec XoaNguoiDung 'NV1'

  go
  ---PROC SUANGUOIDUNG
  CREATE PROC SuaNguoiDung(@mand varchar(10),@hoten NVARCHAR(40),@chucvu NVARCHAR(100),@phanquyen NVARCHAR(100))
  as
  begin
  update NGUOIDUNG
  set MAND=@mand,
  HOTEN=@hoten,
  CHUCVU=@chucvu,
  PHANQUYEN=@phanquyen
  WHERE MAND=@mand
  end

  go
   -----PROC TIMTHEOMAND
  CREATE PROC TimTheoMaND(@mand varchar(10))
  as
  begin
  select *from NGUOIDUNG where MAND like '%'+ @mand +'%'
  end
  -- drop PROC Timtheo_manv
  -- exec TimTheoMaND 'NV1'

  go
  ---PROC TIMTHEOHOTENNGUOIDUNG
  CREATE PROC TimTheoHoTenNguoiDung(@hoten nvarchar(40))
  as
  begin
  select *from NGUOIDUNG where HOTEN like '%'+ @hoten +'%'
  --select * from NHANVIEN where lower(HOTEN) like '%' + lower(RTRIM(@hoten)) + '%'
  end

  -- drop proc Timtheo_hoten
  --select *from NHANVIEN where HOTEN like N''
 -- exec Timtheo_hoten N'Trần'

 
GO
CREATE TABLE PHONGCHIEU
(
    STT INT IDENTITY,
	MAPC VARCHAR(10) PRIMARY KEY ,
	TENPC NVARCHAR(40),
	SOCHO INT, --số chỗ
	MAYCHIEU NVARCHAR(100),
	-- Viewsonic PX727 4K HDR (US)
	-- Viewsonic PX747 4K (US)
	-- Optoma HT27LV
	-- Optoma HT27LV-4K HDR
	-- Sony VZ1000ES
	-- Optoma HD29H 4K
	LOA NVARCHAR(100),
	-- Bộ dàn âm thanh xem phim 5.1 Yamaha YHT-299
	-- Bộ dàn âm thanh xem phim 5.1 Yamaha YHT-196
	DIENTICH INT,
	TINHTRANG NVARCHAR(20),
	-- Tốt / Khá / Trung Bình
	TRANGTHIETBIKHAC NVARCHAR(100)
)
-- drop table phongchieu
GO
INSERT INTO PHONGCHIEU(MAPC,TENPC,SOCHO,MAYCHIEU,LOA,DIENTICH,TINHTRANG,TRANGTHIETBIKHAC) VALUES 
('PC1',N'Phòng chiếu 1',100,N'Viewsonic PX727 4K HDR (US)',N'Bộ dàn âm thanh xem phim 5.1 Yamaha YHT-299',200,N'Tốt',N'Có')

go
----PROC ThemPhongChieu
create PROC ThemPhongChieu(@mapc varchar(10),@tenpc NVARCHAR(40),@socho INT,@maychieu NVARCHAR(100), @loa NVARCHAR(100), @dientich INT, @tinhtrang NVARCHAR(20), @trangthietbikhac NVARCHAR(100))

as
begin
 insert into PhongChieu(MAPC,TENPC,SOCHO,MAYCHIEU,LOA,DIENTICH,TINHTRANG,TRANGTHIETBIKHAC) VALUES (@mapc,@tenpc,@socho,@maychieu,@loa,@dientich,@tinhtrang,@trangthietbikhac)
 end

 go
 -----PROC XoaPhongChieu
 CREATE PROC XoaPhongChieu(@mapc varchar(10))
 as
 begin
 DELETE FROM PHONGCHIEU
  WHERE PHONGCHIEU.MAPC=@mapc
end

-- exec XoaPhongChieu 'NV1'

  go
  ---PROC SuaPhongChieu
  CREATE PROC SuaPhongChieu(@mapc varchar(10),@tenpc NVARCHAR(40),@socho INT,@maychieu NVARCHAR(100), @loa NVARCHAR(100), @dientich INT, @tinhtrang NVARCHAR(20), @trangthietbikhac NVARCHAR(100))
  as
  begin
  update PHONGCHIEU
  set MAPC=@mapc,
  TENPC=@tenpc,
  SOCHO=@socho,
  MAYCHIEU=@maychieu,
  LOA=@loa,
  DIENTICH=@dientich,
  TINHTRANG=@tinhtrang,
  TRANGTHIETBIKHAC=@trangthietbikhac
  WHERE MAPC=@mapc
  end

  go
   -----PROC TIMTHEOMAPC
  CREATE PROC TimTheoMaPC(@mapc varchar(10))
  as
  begin
  select * from PHONGCHIEU where MAPC like '%'+ @mapc +'%'
  end
  -- drop PROC Timtheo_manv
  -- exec TimTheomapc 'NV1'

  go
  ---PROC TIMTHEOtenpc
  CREATE PROC TimTheoTenPhongChieu(@tenpc nvarchar(40))
  as
  begin
  select * from PhongChieu where TENPC like '%'+ @tenpc +'%'
  --select * from NHANVIEN where lower(tenpc) like '%' + lower(RTRIM(@tenpc)) + '%'
  end
go




CREATE TABLE LOAIPHIM
(
    STT INT IDENTITY,
	MALP VARCHAR(10) PRIMARY KEY ,
	TENLP NVARCHAR(40),
	MOTA NVARCHAR(1000) --MÔ TẢ
)
SELECT *FROM LOAIPHIM ORDER BY STT ASC
-- drop table LOAIPHIM
go
INSERT INTO LOAIPHIM(MALP,TENLP,MOTA) VALUES 
('LP1',N'Phim hành động',N'là một thể loại điện ảnh trong đó một hoặc nhiều nhân vật anh hùng bị đẩy vào một loạt những thử thách, thường bao gồm những kì công vật lý, các cảnh hành động kéo dài, yếu tố bạo lực và những cuộc rượt đuổi điên cuồng. Phim hành động có xu hướng mô tả một nhân vật có tài xoay xở đấu tranh chống lại những xung đột không tưởng, bao gồm các tình huống đe dọa đến tính mạng, một phản diện hay một sự theo đuổi mà thường kết thúc trong thắng lợi cho anh hùng')

go
create proc LoadLoaiPhim
as 
begin 
select * from LOAIPHIM ORDER BY STT ASC
end

--  exec LoadLoaiPhim
go
CREATE PROC Themloaiphim(@malp varchar(10),@tenlp nvarchar(40),@mota nvarchar(1000))
as
begin 
insert into LOAIPHIM(MALP,TENLP,MOTA) values (@malp,@tenlp,@mota)
end
go
---PROC SUALOAIPHIM
CREATE PROC Sualoaiphim(@malp varchar(10),@tenlp nvarchar(40),@mota nvarchar(1000))
as
begin
update LOAIPHIM
set MALP=@malp,TENLP=@tenlp,MOTA=@mota
where MALP=@malp
end 
go
---proc Xoaphongchieu
create proc Xoaloaiphim(@malp varchar(10))
as 
begin
delete from LOAIPHIM where MALP=@malp
end
go
---PROC TIMTHEOMALP
CREATE PROC TimTheoMaLP(@malp varchar(10))
  as
  begin
  select * from LOAIPHIM where MALP like '%'+ @malp +'%'
  end
  go
  ---proc tìm theo tên loại phim
CREATE PROC TimTheoTenlp(@tenlp nvarchar(40))
  as
  begin
  select * from LOAIPHIM where TENLP like '%'+ @tenlp +'%'
  end
  go


exec Themloaiphim 'LP2',N'Phim hoạt hình',N'Phim hoạt hình là phim người đóng hoặc phim hoạt họa là một hình thức sử dụng ảo ảnh quang học về sự chuyển động do nhiều hình ảnh tĩnh được chiếu tiếp diễn liên tục. Trong phim và trong kỹ nghệ dàn dựng, hoạt họa ám chỉ đến kỹ thuật trong đó từng khung hình của phim(frame) được chế tác riêng rẽ. Người ta có thể dùng máy tính, hay bằng cách chụp từng hình ảnh đã vẽ, đã được tô màu, hoặc bằng cách chụp những cử động rất nhỏ của các mô hình để tạo nên những hình ảnh này'
go



CREATE TABLE PHIM
(
    STT INT IDENTITY,
	MAPHIM VARCHAR(10) PRIMARY KEY ,
	TENPHIM NVARCHAR(40),
	DAODIEN NVARCHAR(100),
	DIENVIEN NVARCHAR(100),
	MALP VARCHAR(10),
	NOIDUNG NVARCHAR(1000),
	NAMSX VARCHAR(10),
	NUOCSX NVARCHAR(100),
	THOILUONG NVARCHAR(100)
	-- DANHGIA INT (SỐ SAO)
	CONSTRAINT FK_PHIM_MALP FOREIGN KEY(MALP) REFERENCES LOAIPHIM(MALP) ON DELETE CASCADE
)
-- drop table phim
go
create proc LoadPhim
as 
begin 
select * from PHIM ORDER BY STT ASC
end

go
INSERT INTO PHIM(MAPHIM,TENPHIM,DAODIEN,DIENVIEN,MALP,NOIDUNG,NAMSX,NUOCSX,THOILUONG) VALUES 
('PHIM1',N'Quái Vật Venom',N'Ruben Fleischer',N'Tom Hardy, Michelle William, Riz Ahmed','LP1',N'Quái Vật Venom là một kẻ thù nguy hiểm và nặng ký của Người nhện trong loạt series của Marvel. Chàng phóng viên Eddie Brock (do Tom Hardy thủ vai) bí mật theo dõi âm mưu xấu xa của một tổ chức và đã không may mắn khi nhiễm phải loại cộng sinh trùng ngoài hành tinh (Symbiote) và từ đó đã không còn làm chủ bản thân về thể chất lẫn tinh thần. Điều này đã dần biến anh thành quái vật đen tối và nguy hiểm nhất chống lại người Nhện - Venom','2018',N'Mỹ','115 phút')
go

---PROC Themphim
create proc Themphim(@map varchar(10) ,@tenphim nvarchar(40),@daodien nvarchar(100),@dienvien nvarchar(100),@malp varchar(10),@noidung nvarchar(1000),@namsx varchar(10),@nuocsx nvarchar(100),@thoiluong nvarchar(100))
as
begin
insert into PHIM(MAPHIM,TENPHIM,DAODIEN,DIENVIEN,MALP,NOIDUNG,NAMSX,NUOCSX,THOILUONG) values(@map,@tenphim,@daodien,@dienvien,@malp,@noidung,@namsx,@nuocsx,@thoiluong)
end 
go
---proc Suaphim
create proc Suaphim(@map varchar(10) ,@tenphim nvarchar(40),@daodien nvarchar(100),@dienvien nvarchar(100),@malp varchar(10),@noidung nvarchar(1000),@namsx varchar(10),@nuocsx nvarchar(100),@thoiluong nvarchar(100))
as
begin
update PHIM
set MAPHIM=@map,TENPHIM=@tenphim,DAODIEN=@daodien,
DIENVIEN=@dienvien,MALP=@malp,NOIDUNG=@noidung,NAMSX=@namsx,NUOCSX=@nuocsx,THOILUONG=@thoiluong
where MAPHIM=@map
end 
go
--exec Suaphim 'PHIM1',N'Quái Vật Venomn',N'Ruben Fleischer',N'Tom Hardy, Michelle William, Riz Ahmed','LP1',N'Quái Vật Venom là một kẻ thù nguy hiểm và nặng ký của Người nhện trong loạt series của Marvel. Chàng phóng viên Eddie Brock (do Tom Hardy thủ vai) bí mật theo dõi âm mưu xấu xa của một tổ chức và đã không may mắn khi nhiễm phải loại cộng sinh trùng ngoài hành tinh (Symbiote) và từ đó đã không còn làm chủ bản thân về thể chất lẫn tinh thần. Điều này đã dần biến anh thành quái vật đen tối và nguy hiểm nhất chống lại người Nhện - Venom','2018',N'Mỹ','115 phút'
---proc Xoaphim
create proc Xoaphim(@map varchar(10))
as begin
delete from PHIM where MAPHIM=@map 
end
go
---proc Timtheo ma phim
CREATE PROC TimTheoMaP(@map varchar(10))
  as
  begin
  select * from PHIM where MAPHIM like '%'+ @map +'%'
  end
  go

  CREATE PROC TimTheoTenP(@tenp varchar(10))
  as
  begin
  select * from PHIM where TENPHIM like '%'+ @tenp +'%'
  end
  go


CREATE TABLE CACHIEU
(
    STT INT IDENTITY,
	MACC VARCHAR(10) PRIMARY KEY,
	TENCC NVARCHAR(100),
	BATDAU TIME,
	KETHUC TIME
	--BATDAU <= THOILUONG <= KETTHUC
)
-- DROP TABLE CACHIEU
GO
INSERT INTO CACHIEU(MACC,TENCC,BATDAU,KETHUC) VALUES 
('CC1',N'Ca 1','8:00:00','10:00:00')

CREATE TABLE LICHCHIEU
(
    STT INT IDENTITY,
	NGAYCHIEU DATE,
	MAPHIM VARCHAR(10),
	MACC VARCHAR(10), -- CA CHIẾU
	MAPC VARCHAR(10),
	CONSTRAINT PK_LICHCHIEU PRIMARY KEY(NGAYCHIEU,MAPHIM,MACC,MAPC),
	CONSTRAINT FK_LICHCHIEU_MAPHIM FOREIGN KEY(MAPHIM) REFERENCES PHIM(MAPHIM) ON DELETE CASCADE,
	CONSTRAINT FK_LICHCHIEU_MACACHIEU FOREIGN KEY(MACC) REFERENCES CACHIEU(MACC) ON DELETE CASCADE,
	CONSTRAINT FK_LICHCHIEU_MAPC FOREIGN KEY(MAPC) REFERENCES PHONGCHIEU(MAPC) ON DELETE CASCADE
)
GO
INSERT INTO LICHCHIEU(NGAYCHIEU,MAPHIM,MACC,MAPC) VALUES 
('6-8-2020','PHIM1','CC1','PC1')

GO
CREATE TABLE LOAIVE
(
STT INT IDENTITY,
MALV VARCHAR(10) PRIMARY KEY,
TENLV NVARCHAR(100),
--MALP VARCHAR(10),
LOAICHONGOI NVARCHAR(100), -- LOAI CHO NGOI
GIA MONEY
)
GO
INSERT INTO LOAIVE(MALV,TENLV,LOAICHONGOI,GIA) VALUES 
('LV1',N'Vé thường',N'Ghế thường',40000),
('LV2',N'Vé VIP',N'Ghế VIP',50000),
('LV3',N'Vé đôi',N'Ghế đôi',110000)
-- select * from loaive
go
  -------PROC LOADDSLOAIVE
  CREATE PROC LoadDSLoaiVe
  as
  BEGIN
  select *from LOAIVE ORDER BY STT ASC
  END
-- exec LoadDSLoaiVe
go
----PROC Them loai ve
create PROC ThemLoaiVe(@malv varchar(10),@tenlv NVARCHAR(100),@loaichongoi NVARCHAR(100),@gia MONEY)
as
begin
 insert into LOAIVE(malv,tenlv,loaichongoi,gia) VALUES (@malv,@tenlv,@loaichongoi,@gia)
end

go
----PROC Them loai ve
create PROC SuaLoaiVe(@malv varchar(10),@tenlv NVARCHAR(100),@loaichongoi NVARCHAR(100),@gia MONEY)
as
begin
 UPDATE LOAIVE 
 SET MALV=@malv,TENLV=@tenlv,LOAICHONGOI=@loaichongoi,GIA=@gia WHERE MALV=@malv
end 

GO
---proc Xoa loai ve
create proc XoaLoaiVe(@malv varchar(10))
as 
begin
delete from LOAIVE where MALV=@malv
end

go
   -----PROC tim theo ma loai ve
  CREATE PROC TimTheoMaLV(@malv varchar(10))
  as
  begin
  select * from LOAIVE where MALV like '%'+ @malv +'%'
  end

go
 -----PROC tim theo ma loai ve
  CREATE PROC TimTheoTenLV(@tenlv NVARCHAR(100))
  as
  begin
  select * from LOAIVE where TENLV like '%'+ @tenlv +'%'
  end

GO
CREATE TABLE VE
(
STT INT IDENTITY,
MAVE VARCHAR(10) PRIMARY KEY,
MAPHIM VARCHAR(10),
MAPC VARCHAR(10),
MALV VARCHAR(10),
MACACHIEU VARCHAR(10)
)
--GO
--INSERT INTO VE(MAPHIM,MAPC,MALV,MACACHIEU) VALUES 
--('PHIM1','PC1','LV1','CC1')
--GO



























CREATE TABLE NHACUNGCAP
(
STT INT IDENTITY,
MANCC VARCHAR(10) PRIMARY KEY,
TENNCC NVARCHAR(100),
SDT VARCHAR(20),
DIACHI NVARCHAR(100),
TONGTIENHANG MONEY
)
GO
CREATE TABLE HANGHOA
(
    STT INT IDENTITY,
	MAHH VARCHAR(10)  PRIMARY KEY ,
	TENHH NVARCHAR(100) ,
	DVT NVARCHAR(10), 
	TONKHO INT, --CHECK(SL>=0),
	GIA MONEY ,
	MANCC VARCHAR(10),
	NUOCSX NVARCHAR(50),
	LOAISP NVARCHAR(50) ,
	TINHTRANG NVARCHAR(10),
	CONSTRAINT FK_HANGHOA_MANCC FOREIGN KEY(MANCC) REFERENCES NHACUNGCAP(MANCC) ON DELETE CASCADE
)

--SELECT HH.STT,HH.MAHH,HH.TENHH,HH.DVT,HH.TONKHO,HH.GIA,NCC.TENNCC,HH.NUOCSX,HH.LOAISP,HH.TINHTRANG
--FROM HANGHOA HH JOIN NHACUNGCAP NCC ON NCC.MANCC=HH.MANCC
--ORDER BY HH.STT ASC
GO
CREATE TABLE QUAYHANG
(
MAQUAY VARCHAR(10) PRIMARY KEY,
TENQUAY NVARCHAR(50),
)
GO
CREATE TABLE CTQUAYHANG
(
MAQUAY VARCHAR(10),
MAHH VARCHAR(10),
SL INT, --CHECK(SL>=0),
CONSTRAINT PK_CTQUAYHANG PRIMARY KEY(MAQUAY,MAHH),
CONSTRAINT FK_CTQUAYHANG_MAHH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH) ON DELETE CASCADE,
CONSTRAINT FK_CTQUAYHANG_MAQUAY FOREIGN KEY(MAQUAY) REFERENCES QUAYHANG(MAQUAY) ON DELETE CASCADE
)
GO
CREATE TABLE KHOHANG
(
STT INT IDENTITY,
MAKHO VARCHAR(10) PRIMARY KEY,
TENKHO NVARCHAR(100),
DIACHI NVARCHAR(100),
MANV VARCHAR(10),
CONSTRAINT FK_KHOHANG_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV) ON DELETE CASCADE
)

CREATE TABLE CTKHO
(
MAKHO VARCHAR(10),
MAHH VARCHAR(10) ,
SL INT,
CONSTRAINT PK_CTKHO PRIMARY KEY(MAKHO,MAHH),
CONSTRAINT FK_CTKHO_MAKHO FOREIGN KEY(MAKHO) REFERENCES KHOHANG(MAKHO) ON DELETE CASCADE,
CONSTRAINT FK_CTKHO_MAHH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH) ON DELETE CASCADE
)

 SELECT HH.MAHH,HH.TENHH,HH.DVT,HH.GIA,CTK.SL
            FROM CTKHO CTK JOIN KHOHANG KH ON CTK.MAKHO=KH.MAKHO
             JOIN HANGHOA HH ON HH.MAHH = CTK.MAHH 
            WHERE CTK.MAKHO='KHO1'
			ORDER BY HH.STT

CREATE TABLE NHAPKHO
(
STT INT IDENTITY,
MANK VARCHAR(10) PRIMARY KEY,
MAKHO VARCHAR(10),
MANCC VARCHAR(10),
NGAYNHAP DATE,
TONGTIENNHAP MONEY,
CONSTRAINT FK_NHAPKHO_MANCC FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC) ON DELETE CASCADE,
CONSTRAINT FK_NHAPKHO_MAKHO FOREIGN KEY (MAKHO) REFERENCES KHOHANG(MAKHO) ON DELETE CASCADE
)

CREATE TABLE CTNHAPKHO
(
MANK VARCHAR(10),
MAHH VARCHAR(10) ,
SL INT,
GIANHAP MONEY,
CONSTRAINT PK_CTNHAPKHO PRIMARY KEY(MANK,MAHH),
CONSTRAINT FK_CTNHAPKHO_MANHKHO FOREIGN KEY(MANK) REFERENCES NHAPKHO(MANK) ON DELETE CASCADE,
CONSTRAINT FK_CTNHAPKHO_MAHH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH)
)


CREATE TABLE XUATKHO
(
STT INT IDENTITY,
MAXK VARCHAR(10) PRIMARY KEY,
MAKHO VARCHAR(10),
NGAYXUAT DATE,
SOLUONGXUAT INT,
CONSTRAINT FK_XUATKHO_MAKHO FOREIGN KEY (MAKHO) REFERENCES KHOHANG(MAKHO) ON DELETE CASCADE,
)

CREATE TABLE CTXUATKHO
(
MAXK VARCHAR(10),
MAHH VARCHAR(10),
SL INT,
MAQUAY VARCHAR(10),
CONSTRAINT PK_CTXUATKHO PRIMARY KEY(MAXK,MAHH),
CONSTRAINT FK_CTXUATKHO_MANHKHO FOREIGN KEY(MAXK) REFERENCES XUATKHO(MAXK) ON DELETE CASCADE,
CONSTRAINT FK_CTXUATKHO_MAHH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH) ON DELETE CASCADE,
CONSTRAINT FK_CTXUATKHO_MAQUAY FOREIGN KEY(MAQUAY) REFERENCES QUAYHANG(MAQUAY) ON DELETE CASCADE
)

CREATE TABLE QUAYTN
(
MAQTN VARCHAR(10) PRIMARY KEY,
TENQTN NVARCHAR(50),
MANV VARCHAR(10),
CONSTRAINT FK_QUAYTN_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV) ON DELETE CASCADE
)

CREATE TABLE HOADON
(
STT INT IDENTITY,
SOHD VARCHAR(10) PRIMARY KEY,
NGAYHD DATE,
GIOHD TIME,
MAKH VARCHAR(10),
MAQTN VARCHAR(10),
TONGCONG MONEY,
CONSTRAINT FK_HOADON_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANGTHANTHIET(MAKH) ON DELETE CASCADE,
CONSTRAINT FK_HOADON_MAQTN FOREIGN KEY(MAQTN) REFERENCES QUAYTN(MAQTN) ON DELETE CASCADE,
)

CREATE TABLE CTHD
(
SOHD VARCHAR(10),
MAHH VARCHAR(10),
SL INT,
THANHTIEN MONEY,
CONSTRAINT PK_CTHD PRIMARY KEY(SOHD,MAHH),
CONSTRAINT FK_CTHD_SOHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD) ON DELETE CASCADE,
CONSTRAINT FK_CTHD_MAHH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH) ON DELETE CASCADE
)

CREATE TABLE VOUCHER
(
STT INT IDENTITY,
GIFTCODE VARCHAR(9) NOT NULL PRIMARY KEY,
GIATRI  decimal(18,3) NOT NULL,
NGAYTAO DATE NOT NULL,
NGAYHETHAN DATE NOT NULL,
TINHTRANG NVARCHAR(20),
MAKH VARCHAR(10),
CONSTRAINT FK_VOUCHER_MAKH FOREIGN KEY(MAKH) REFERENCES KHACHHANGTHANTHIET(MAKH) ON DELETE CASCADE,
)

---- NCC



----



-----Kho
GO
CREATE TRIGGER TRIGGER_CHECK_CHUCVU_KHO ON KHOHANG
-- KIỂM TRA MÃ HH CÓ TRÊN QUẦY ĐỂ XUẤT
FOR INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM NHANVIEN NV JOIN INSERTED I ON I.MANV=NV.MANV
   WHERE NV.CHUCVU=N'Thủ Kho')<1
 BEGIN
   PRINT N'Nhân viên phải là thủ kho'
   ROLLBACK TRAN
 END
END

------

----------CT HÓA ĐƠN-----------------
GO
CREATE TRIGGER TRIGGER_CHECK_MAHH_CTQUAYHANG_CTHD ON CTHD
-- KIỂM TRA MÃ HH CÓ TRÊN QUẦY ĐỂ XUẤT
FOR INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM CTQUAYHANG CTQH JOIN INSERTED I ON I.MAHH=CTQH.MAHH
   WHERE CTQH.MAHH=I.MAHH)<1
 BEGIN
   PRINT N'Hàng chưa có trên quầy,lấy gì bán?'
   ROLLBACK TRAN
 END
END

GO
CREATE TRIGGER TRIGGER_UPDATE_TONGCONG_HOADON_AFTER_CTHD ON CTHD
-- TĂNG TIỀN TỔNG CỘNG MỖI KHI NHẬP 1 CTHD
AFTER INSERT AS
BEGIN
 UPDATE HOADON
 SET HOADON.TONGCONG=HOADON.TONGCONG+(SELECT I.THANHTIEN
            FROM INSERTED I
			WHERE I.SOHD=HOADON.SOHD)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.SOHD=HOADON.SOHD)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END



GO
CREATE TRIGGER TRIGGER_CHECK_THANHTIEN ON CTHD
--KIỂM TRA THÀNH TIỀN CỦA CTHD CÓ ĐÚNG K
FOR INSERT AS
BEGIN
 IF(SELECT COUNT(*) 
   FROM HANGHOA HH JOIN INSERTED I ON I.MAHH=HH.MAHH
   WHERE I.THANHTIEN<>(I.SL*HH.GIA))>0
 BEGIN
   PRINT N'Thành tiền không chính xác'
   ROLLBACK TRAN
 END
END

GO
CREATE TRIGGER TRIGGER_UPDATE_SL_AFTER_CTHD ON CTHD
-- GIẢM SL HÀNG TRÊN QUẦY  MỖI KHI NHẬP 1 CTHD
AFTER INSERT AS
BEGIN
 UPDATE CTQUAYHANG
 SET CTQUAYHANG.SL=CTQUAYHANG.SL-(SELECT I.SL
            FROM INSERTED I
			WHERE I.MAHH=CTQUAYHANG.MAHH)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MAHH=CTQUAYHANG.MAHH)-- CHỈ SELECT NHỮNG SP ĐƯỢC BÁN
END
----------------------------------

---------CT NHẬP KHO-------------
GO
CREATE TRIGGER TRIGGER_UPDATE_SL_HANGHOA_AFTER_CTNHAPKHO ON CTNHAPKHO 
-- TĂNG SL HÀNG HÓA SAU KHI NHẬP KHO
AFTER INSERT AS
BEGIN
 UPDATE HANGHOA
 SET HANGHOA.TONKHO=HANGHOA.TONKHO+(SELECT I.SL
            FROM INSERTED I
			WHERE I.MAHH=HANGHOA.MAHH)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MAHH=HANGHOA.MAHH)-- CHỈ SELECT NHỮNG SP ĐƯỢC NHẬP
END

GO
CREATE TRIGGER TRIGGER_UPDATE__TONGTIENNHAP_AFTER_CTNHAPKHO ON CTNHAPKHO
-- TĂNG TỔNG TIỀN NHẬP MỖI KHI NHẬP 1 CTNHAPKHO
AFTER INSERT AS
BEGIN
 UPDATE NHAPKHO
 SET NHAPKHO.TONGTIENNHAP=NHAPKHO.TONGTIENNHAP+(SELECT I.GIANHAP
            FROM INSERTED I
			WHERE I.MANK=NHAPKHO.MANK)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MANK=NHAPKHO.MANK)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END

GO
CREATE TRIGGER TRIGGER_UPDATE__TONGTIENHANG_AFTER_CTNHAPKHO ON NHAPKHO
-- TĂNG TỔNG TIỀN NHẬP MỖI KHI NHẬP 1 CTNHAPKHO
AFTER UPDATE AS
BEGIN
 UPDATE NHACUNGCAP
 SET NHACUNGCAP.TONGTIENHANG=NHACUNGCAP.TONGTIENHANG +(SELECT I.TONGTIENNHAP
            FROM INSERTED I
			WHERE I.MANCC=NHACUNGCAP.MANCC)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MANCC=NHACUNGCAP.MANCC)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END
---------------------------

-----CT XUẤT KHO-------------------
GO
CREATE TRIGGER TRIGGER_CHECK_SL_HANGHOA_ON_CTXUATKHO ON CTXUATKHO 
-- KIỂM TRA SL XUẤT KHO VS SL TỒN KHO
FOR INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM HANGHOA HH JOIN INSERTED I ON I.MAHH=HH.MAHH
   WHERE HH.TONKHO<I.SL)>0
 BEGIN
   PRINT N'Số lượng xuất kho của hàng hóa không thể lớn hơn số lượng tồn kho của hàng hóa'
   ROLLBACK TRAN
 END
END

GO
CREATE TRIGGER TRIGGER_CHECK_MAHH_CTQUAYHANG ON CTXUATKHO 
-- KIỂM TRA MÃ HH CÓ TRÊN QUẦY ĐỂ XUẤT
FOR INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM CTQUAYHANG CTQH JOIN INSERTED I ON I.MAQUAY=CTQH.MAQUAY
   WHERE CTQH.MAHH=I.MAHH)<1
 BEGIN
   PRINT N'Hàng chưa có trên quầy,không xuất kho được'
   ROLLBACK TRAN
 END
END


GO
CREATE TRIGGER TRIGGER_UPDATE_SL_HANGHOA_AFTER_CTXUATKHO ON CTXUATKHO 
-- GIẢM SỐ LƯỢNG TỒN KHO SAU KHI XUẤT KHO
AFTER INSERT AS
BEGIN
 UPDATE HANGHOA
 SET HANGHOA.TONKHO=HANGHOA.TONKHO-(SELECT I.SL
            FROM INSERTED I
			WHERE I.MAHH=HANGHOA.MAHH)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MAHH=HANGHOA.MAHH)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END

GO
CREATE TRIGGER TRIGGER_UPDATE_SL_CTQUAYHANG_AFTER_CTXUATKHO ON CTXUATKHO 
-- TĂNG SỐ LƯỢNG SẢN PHẨM TRÊN QUẦY SAU KHI XUẤT KHO
AFTER INSERT AS
BEGIN
 UPDATE CTQUAYHANG
 SET  CTQUAYHANG.SL=CTQUAYHANG.SL+(SELECT I.SL
            FROM INSERTED I
			WHERE I.MAHH=CTQUAYHANG.MAHH)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MAHH=CTQUAYHANG.MAHH)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END

GO
CREATE TRIGGER TRIGGER_CHECK_MAQUAY_CTQUAYHANG_AFTER_CTXUATKHO ON CTXUATKHO
--kiểm tra mã quầy của hàng hóa khi xuất kho
FOR INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM CTQUAYHANG CTQH JOIN INSERTED I ON I.MAHH=CTQH.MAHH
   WHERE CTQH.MAQUAY<>I.MAQUAY)>0
 BEGIN
   PRINT N'Mã quầy không chính xác'
   ROLLBACK TRAN
 END
END

GO
CREATE TRIGGER TRIGGER_UPDATE__SOLUONGXUAT_AFTER_CTXUATKHO ON CTXUATKHO
-- TĂNG SỐ LƯỢNG XUẤT MỖI KHI XUẤT 1 CTNHAPKHO
AFTER INSERT AS
BEGIN
 UPDATE XUATKHO
 SET XUATKHO.SOLUONGXUAT=XUATKHO.SOLUONGXUAT+(SELECT I.SL
            FROM INSERTED I
			WHERE I.MAXK=XUATKHO.MAXK)
 WHERE EXISTS (SELECT *
               FROM INSERTED
		       WHERE INSERTED.MAXK=XUATKHO.MAXK)-- CHỈ SELECT NHỮNG SP ĐƯỢC XUẤT
END

GO
CREATE TRIGGER UPDATE_TINHTRANG_HANGHOA_AFTER_CTHD ON CTXUATKHO
-- THAY ĐỔI TÌNH TRẠNG HH KHI SL HÀNG BÉ HƠN 20
AFTER INSERT AS
BEGIN
IF(SELECT COUNT(*) 
   FROM HANGHOA HH JOIN INSERTED I ON I.MAHH=HH.MAHH
   WHERE HH.TONKHO BETWEEN 1 AND 20)>0
 BEGIN
   UPDATE HANGHOA
   SET TINHTRANG=N'Sắp hết'
   FROM inserted I
   WHERE HANGHOA.MAHH=I.MAHH
 END
ELSE IF(SELECT COUNT(*) 
        FROM HANGHOA HH JOIN INSERTED I ON I.MAHH=HH.MAHH
        WHERE HH.TONKHO=0)>0
 BEGIN
   UPDATE HANGHOA
   SET TINHTRANG=N'Hết hàng'
   FROM inserted I
   WHERE HANGHOA.MAHH=I.MAHH
 END
END

------------------------------------








       




INSERT INTO NHACUNGCAP VALUES
('NCC1',N'Chợ đầu mối Kim Biên','0973780808',N'Chợ Kim Biên, P.13, Q.5',0),
('NCC2',N'CÔNG TY CỔ PHẦN BỘT GIẶT LIX','028 - 38 964 072',N'Số 3 Đường Số 2, P. Linh Trung, Q. Thủ Đức, TP. HCM.',0),
('NCC3',N'Công ty Cổ phần Tập đoàn Phú Thái','0946126969',N'44B Lý Thường Kiệt,Hoàn Kiếm, Hà Nội',0),
('NCC4',N'Công ty TNHH Nước giải khát SUNTORY PEPSICO Việt Nam','(84 28) 3 821 9437',N'88 Đường Đồng Khởi, Quận 1, Thành phố Hồ Chí Minh',0),
--pepsi,coca,7up,revive,mirinda,tropicana,sting,aquafina,lipton,sting,lipton,aquafina,tropicana,pepsi,ô long,7up,revive,mirinda,moutain dew
('NCC5',N'Công ty cổ phần Bia - Rượu - Nước giải khát Hà Nội HABECO','024.38453843',N'183 Hoàng Hoa Thám, Ba Đình, Hà Nội',0),
('NCC6',N'Công ty TNHH Lavie',' (+84 272) 3511801 ',N'Quốc Lộ 1A, Khu phố Tường Khánh, Phường Khánh Hậu, Thành phố Tân An, Tỉnh Long An',0),
--lavie
('NCC7',N'Công ty TNHH Thương Mại-Dịch Vụ Tân Hiệp Phát','0898-760-066',N'219 Đại Lộ Bình Dương,Tx Thuận An,Bình Dương',0),
--numb1,tra xanh 0 do,dr thanh,tr
('NCC8',N'Công ty TNHH Red Bull','0983295462',N'Xa lộ Hà Nội, Bình Thắng, Dĩ An, Bình Dương',0),
--RED BULL
('NCC9',N'Công ty Cổ phần Sữa Việt Nam Vinamilk','(028) 54 155 555',N'Số 10, Đường Tân Trào, phường Tân Phú, quận 7, Tp. HCM',0),
('NCC10',N'Công ty Unilever','(028) 3892024',N'A2-3, Khu công nghiệp Tây Bắc Củ Chi, Huyện Củ Chi, Tp Hồ Chí Minh',0),
--knorr
('NCC11',N'Công ty cổ phần kỹ nghệ thực phẩm Việt Nam (VIFON)','028.38153933',N'913 Trường Chinh, phường Tây Thạnh, quận Tân Phú, TPHCM',0),
('NCC12',N'Công ty TNHH Dầu thực vật Cái Lân (CALOFIC)','(84 33) 3846 993',N' Lầu 12, Phòng 1202, tòa nhà Royal, 235 Nguyễn Văn Cừ, Quận 1, Tp.Hồ Chí Minh',0),
--Neptune, Simply, Meizan
('NCC13',N'Công ty Ajinomoto Việt Nam','(028) 3930 8784',N'Tầng 5, Golden Tower Số 6, Nguyễn Thị Minh Khai, P. Đa Kao, Q.1, TP.HCM',0),
--aji....
('NCC14',N'MONDELEZ KINH ĐÔ VIỆT NAM','(84) (28) 38270838',N'138 – 142, Hai Bà Trưng, Phường Đa Kao, Quận 1, TP.HCM',0),
--OREO
('NCC15',N'Strongbow Apple Ciders Việt Nam','(84-8) 38 222 755',N'Tầng 15, Me Linh Point Tower, 2, Ngô Đức Kế, Q. 1, Tp. Hồ Chí Minh',0),
--STRONG BOW
('NCC16',N'Công ty TNHH Nestlé Việt Nam','(028) 3911 3737',N'Lầu 5, Empress Tower, 138-142 Hai Bà Trưng, Phường Đa Kao, Quận 1, Tp.Hồ Chí Minh',0),
--maggi , nesvita
('NCC17',N'Công ty cổ phần Hàng tiêu dùng Masan','(84.28) 62 555 660',N'Tầng 12, tòa nhà MPlaza Saigon Số 39 Lê Duẩn, Phường Bến Nghé, Quận 1, Tp. Hồ Chí Minh',0),
--cholimex , chin-su ,OMACHI
('NCC18',N'Công ty cổ phần đồ hộp Hạ Long (HALONG CANFOCO)','84.225.3 836 692',N'Số 71 Lê Lai, Phường Máy Chai, Quận Ngô Quyền, Thành Phố Hải Phòng',0),
('NCC19',N'Công ty TNHH công nghiệp thực phẩm Việt Hưng (Uniben)','028-37125697',N'32 Phan Văn Đối, Bà Điểm, Hóc Môn Bà Điểm Hóc Môn Hồ Chí Minh, Bà Điểm, Hóc Môn, Hồ Chí Minh',0),
--reeva,3 miền
('NCC20',N'Công ty TNHH thực phẩm Việt Hàn Phương Nga','0971 515 719',N'100/21 Đường 49, P.Hiệp Bình Chánh, Quận Thủ Đức',0),
--koreno
('NCC21',N'Công ty cổ phần Dầu Thực Vật Tường An','028 3872 7832',N'Lầu 10, Tòa nhà Empress Tower, Số 138-142 Đường Hai Bà Trưng, Phường Đa Kao, Quận 1, TPHCM',0),
--tường an
('NCC22',N'CÔNG TY TNHH THỰC PHẨM ÂN NAM','+84 28 3512 6400',N'322 Điện Biên Phủ,Phường 22, Quận Bình Thạnh, TP. HCM',0),
-- dầu Olive Latino Bella
('NCC23',N'CÔNG TY TNHH THỰC PHẨM ORION VINA','0650-3553700',N'Lô E13 - CN - KCN Mỹ Phước 2 - Thị trấn Mỹ Phước - Huyện Bến Cát - Tỉnh Bình Dương',0),
-- CHOCOPIE
('NCC24',N'Công Ty TNHH Procter & Gamble Việt Nam P&G','028 3521 4545',N'11 Floor, MPlaza, 39 Lê Duẩn, Bến Nghé, Quận 1, Hồ Chí Minh',0)
-- TIDE,ARIEL,DOWNY,HEAD SHOULDER,REJOICE,PANTENE


INSERT INTO HANGHOA VALUES ('SP1',N'Hạt nêm Neptune heo 380g',N'Bịch',100,27800,'NCC12',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP2',N'Hạt nêm Aji-ngon 900g',N'Bịch',100,57000,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP3',N'Sữa tắm Lifebuoy Detox 850g',N'Chai',100,152800,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP4',N'Xốt ướp thịt nướng Cholimex 600g',N'Hũ',100,43900,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP5',N'Bún bò Huế Hoàng Gia VIFON 120g',N'Gói',100,13900,'NCC11',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP6',N'Nước mắm Chin-su cá hồi 500ml',N'Chai',100,33900,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP7',N'Cá ngừ ngâm dầu Hạ Long 175g',N'Hộp',100,34900,'NCC18',N'Việt Nam',N'Thực Phẩm',N'Hết Hàng')
INSERT INTO HANGHOA VALUES('SP8',N'Dầu Oliu Ajinomoto 70g',N'Chai',100,46000,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP9',N'Phở thịt bò Hoàng Gia VIFON 120g',N'Gói',100,13900,'NCC11',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')
INSERT INTO HANGHOA VALUES('SP10',N'Mì 3 miền Reeva 65g',N'Gói',100,2900,'NCC19',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')

INSERT INTO HANGHOA VALUES('SP11',N'Nước mắm Chin-su Nam Ngư 750ml',N'Chai',100,32500,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP12',N'Sữa Milo Nestle 1kg ','Lon',100,257000,'NCC16',N'Úc',N'Sữa nước',N'Còn Hàng'),
('SP13',N'Dầu hoa cải Ajinomoto',N'Chai',100,90000,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP14',N'Mì ly Ngon Ngon VIFON 60g',N'Ly',500,6600,'NCC11',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng'),
('SP15',N'Tương ớt Cholimex','Chai',100,40000,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP16',N'Mì giấy VIFON tôm chua cay 75g',N'Gói',500,3200,'NCC11',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng'),
('SP17',N'Dầu mè Ajinomoto 70g',N'Chai',100,55000,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP18',N'Dầu đậu nành Meizan 1L',N'Chai','100',39000,'NCC12',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP19',N'Lô 6 chai Isotonic 7up Revive chanh muối 390ml','Lô',100,34800,'NCC4',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
('SP20',N'Sữa tắm Lifebuoy 850g','Chai',100,131400,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP21',N'Nước rửa chén khử mùi tanh Sunlight Matcha trà Nhật 3,6kg',N'Chai',100,99000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP22',N'Nước lau nhà Sunlight hương hoa hạ 4L','Chai',100,92000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP23',N'Nước lau sàn Sunlight Tinh dầu thiên nhiên hương thiên thảo 3.8L',N'Chai',100,78000,'NCC10',N'Việt Nam ',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP24',N'Nước rửa chén Sunlight Thiên nhiên mới 750g',N'Bịch',100,23000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP25',N'Nước rửa chén Sunlight Chanh 750g',N'Chai',100,22000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP26',N'Nước rửa chén Sunlight Trà xanh 1,5kg',N'Chai',100,47000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP27',N'Thùng 24 lon bia Tiger 330ml',N'Thùng',100,323000,'NCC5',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Hết Hàng'),
 ('SP28',N'Sữa tắm Enchanteur có hạt 650g',N'Chai',100,158900,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
 ('SP29',N'Mì Omachi xốt bò hầm 82g',N'Gói',500,5800,'NCC17',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng'),
 ('SP30',N'Nước lau sàn Sunlight tinh dầu thiên nhiên hương hoa Lily 2,6kg',N'Bịch',100,52000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES ('SP31',N'Lốc 6 lon nước tăng lực Sting dâu 330ml',N'Lốc',100,45800,'NCC4',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
 ('SP32',N'Nước rửa chén diệt khuẩn Sunlight Chanh và lá bạc hà 3,6kg',N'Chai',100,99000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP33',N'Nước rửa chén Sunlight Thiên Nhiên 750g',N'Chai',100,27000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP34',N'Nước rửa chén Sunlight Diệt khuẩn 750g',N'Chai',100,27000,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
 ('SP35',N'Xốt Mayonnaise Aji-Mayo 130g',N'Chai',100,14900,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
 ('SP36',N'Nui Meizan cao cấp 400g',N'Gói','100',16500,'NCC12',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng'),
 ('SP37',N'Nước tương đậu nành Maggi 300ml',N'Chai','100',10100,'NCC16',N'Việt Nam',N'Gia Vị',N'Hết Hàng'),
 ('SP38',N'Bột tẩm khô chiên giòn Aji-Quick 210g',N'Gói','100',23500,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
 ('SP39',N'Mì Omachi tôm chua cay 5 sao 78g','Gói',500,5800,'NCC17',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng'),
 ('SP40',N'Mì Omachi sườn hầm ngũ quả 80g','Gói',500,5800,'NCC17',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES ('SP41',N'Nước ngọt 7up 1,5L',N'Chai',100,13500,'NCC4',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP42',N'Mì Omachi bò hầm sốt vang 92g',N'Gói',500,7000,'NCC17',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP43',N'Hạt nêm Knorr heo 1,2kg',N'Gói',100,66700,'NCC10',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP44',N'Mì Koreno 100g',N'Gói',500,11100,'NCC20',N'Việt Nam',N'Bún/miến/mì/nui',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP45',N'Tương ớt Chinsu','Chai',100,40000,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP46',N'Cà phê Nestcafe 3 trong 1 đậm đà 46 gói*17g',N'Bịch',100,85400,'NCC16',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP47',N'Nước ngọt Pepsi 1.5L',N'Chai',100,13500,'NCC4',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Hết Hàng')
 INSERT INTO HANGHOA VALUES('SP48',N'Sữa tắm Dove 900g',N'Chai',100,168900,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP49',N'Lốc 6 lon thức uống lúa mạch Milo Active Go 240ml',N'Lốc',100,78000,'NCC16',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng')
 INSERT INTO HANGHOA VALUES('SP50',N'Lốc 4 hộp sữa Milo 180ml',N'Lốc',100,24300,'NCC16',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES ('SP51',N'Thanh Long ','kg','100',20000,'NCC1',N'Việt Nam',N'Trái cây',N'Còn Hàng'),
 ('SP52',N'Dầu xào ngũ hạt Tường An chai 500ml',N'Chai',100,39000,'NCC20',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
 ('SP53',N'Kem dâu Vinamilk hộp 1L',N'Hộp',100,65600,'NCC9',N'Việt Nam',N'Kem',N'Còn Hàng'),
 ('SP54',N'Hộp Milo bột lúa mạch 285g',N'Hộp',100,38200,'NCC16',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP55',N'Bột ngũ cốc dinh dưỡng Nesvita 16 gói*25g',N'Bịch',100,40400,'NCC16',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng'),
 ('SP56',N'Dầu đậu nành Tường An 5L',N'Chai','100',196200,'NCC21',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng'),
 ('SP57',N'Dầu Cooking Neptune Gold 2L',N'Chai',100,85000,'NCC12',N'Việt Nam',N'Gia Vị',N'Hết Hàng'),
 ('SP58',N'Bột ngọt Ajinomoto 454g',N'Bịch',100,29500,'NCC13',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
 ('SP59',N'Dầu Hướng Dương Simply 2L',N'Chai',100,117700,'NCC12',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng'), 
 ('SP60',N'Nước lọc Lavie 500ml','Chai','100',10000,'NCC6',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng')
 
  INSERT INTO HANGHOA VALUES('SP61',N'Dầu Oliu Latino Bella 250ml',N'Chai',100,83400,'NCC22',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng'),
 ('SP62',N'Dầu gội Pantene 900ml','Chai',100,116800,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
 ('SP63',N'Dầu gội Pantene 1,2L','Chai',100,151900,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
 ('SP64',N'Dầu cooking Meizan 5L','Bình',100,155500,'NCC12',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
 ('SP65',N'Sữa Vinamilk',N'Hộp',100,40000,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP66',N'Nước tăng lực Redbull','Chai',100,20000,'NCC8',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
 ('SP67',N'StrongBow','Chai','10',10000,'NCC15',N'Thái Lan',N'Nước ngọt,nước khoáng',N'Hết Hàng'),
 ('SP68',N'Sữa tươi tiệt trùng Vinamilk 100% Tách béo không đường - hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP69',N'Sữa tươi tiệt trùng Vinamilk 100% Tách béo có đường - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP70',N'Sữa tươi tiệt trùng Vinamilk 100% Chocolate - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP71',N'Sữa tươi tiệt trùng Vinamilk 100% Chocolate - 4 hộp 110ml',N'Lốc','100',19600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP72',N'Sữa tươi tiệt trùng Vinamilk 100% Organic không đường - 4 hộp 180ml',N'Lốc','100',40480,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP73',N'Sữa tươi tiệt trùng Vinamilk 100% Organic không đường - hộp 1L',N'Hộp','100',48930,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP74',N'Sữa tươi tiệt trùng Vinamilk 100% Không đường - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP75',N'Sữa tươi tiệt trùng Vinamilk 100% Không đường - hộp giấy 1L',N'Hộp','100',28900,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP76',N'Sữa tươi tiệt trùng Vinamilk 100% Ít đường - 4 hộp 110ml',N'Lốc','100',19500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP77',N'Sữa tươi tiệt trùng Vinamilk 100% Ít đường - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP78',N'Sữa tươi tiệt trùng Vinamilk 100% Ít đường - Hộp giấy 1L',N'Hộp','100',28900,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP79',N'Sữa tươi tiệt trùng Vinamilk 100% Hương dâu - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP80',N'Sữa tươi tiệt trùng Vinamilk 100% Hương dâu - 4 hộp 110ml',N'Lốc','100',19500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP81',N'Sữa tươi tiệt trùng Vinamilk 100% Có đường - 4 hộp 180ml',N'Lốc','100',30800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP82',N'Sữa tươi tiệt trùng Vinamilk 100% Có đường - 4 hộp 110ml',N'Lốc','100',19600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP83',N'Sữa tươi tiệt trùng Vinamilk 100% Có đường - Hộp giấy 1L',N'Hộp','100',28900,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP84',N'Sữa tươi nguyên chất tiệt trùng Vinamilk 100% A2 - Hộp giấy 1L',N'Hộp','100',42075,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP85',N'Sữa dinh dưỡng Vinamilk ADM Gold Hương dâu - Lốc 4 hộp x 110ml',N'Lốc','100',17100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP86',N'Sữa dinh dưỡng Vinamilk ADM Gold Hương dâu - Lốc 4 hộp x 180ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP87',N'Sữa dinh dưỡng Vinamilk ADM Gold Hương Chocolate - Lốc 4 hộp x 110ml',N'Lốc','100',17100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP88',N'Sữa dinh dưỡng Vinamilk ADM Gold Hương Chocolate - Lốc 4 hộp x 180ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP89',N'Sữa dinh dưỡng Vinamilk ADM Gold Có đường - Lốc 4 hộp x 180ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP90',N'Sữa tiệt trùng Flex không Lactose - Lốc 4 hộp x 180ml',N'Lốc','100',28600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP91',N'Sữa tiệt trùng Flex không đường - Hộp giấy 1L',N'Hộp','100',30400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP92',N'Sữa Cacao Lúa mạch Super SuSu - Lốc 4 hộp x 180ml',N'Lốc','100',26500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP93',N'Sữa Cacao Lúa mạch Super SuSu - Lốc 4 hộp x 110ml',N'Lốc','100',16800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP94',N'Sữa Cacao Lúa mạch Super SuSu - Lốc 4 chai màng nhôm x 80ml',N'Lốc','100',16400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP95',N'Sữa dinh dưỡng Vinamilk Hương dâu - Bịch 220ml',N'Bịch','100',6500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP96',N'Sữa dinh dưỡng Vinamilk Hương chocolate - Bịch 220ml',N'Bịch','100',6500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP97',N'Sữa dinh dưỡng Vinamilk Có đường - Bịch 220ml',N'Bịch','100',6500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP98',N'Sữa dinh dưỡng Vinamilk Không đường - Bịch 220ml',N'Bịch','100',6500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP99',N'Sữa tươi thanh trùng Vinamilk 100% Có đường - Hộp 200ml',N'Hộp','100',8600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP100',N'Sữa tươi thanh trùng Vinamilk 100% Có đường - Hộp 900ml',N'Hộp','100',35700,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
INSERT INTO HANGHOA VALUES ('SP101',N'Sữa tươi thanh trùng Vinamilk 100% Không đường - Hộp 900ml',N'Hộp','100',35700,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP102',N'Sữa tươi thanh trùng Vinamilk 100% Không đường - Hộp 200ml',N'Hộp','100',8600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP103',N'Sữa Cacao Lúa mạch Super SuSu - Lốc 6 chai màng nhôm x 80ml',N'Lốc','100',24600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP104',N'Sữa tươi tiệt trùng Vinamilk 100% Ít đường - Hộp giấy 1L',N'Hộp','100',28900,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP105',N'Sữa dinh dưỡng Vinamilk Ít đường - Bịch 220ml',N'Bịch','100',6500,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP106',N'Sữa dinh dưỡng Vinamilk ADM Gold Chuối - Lốc 4 hộp x 150ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP107',N'Thùng 12 hộp Sữa tươi tiệt trùng Vinamilk 100% Ít Đường 1L',N'Thùng','100',377400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP108',N'Thức uống năng lượng Vinamilk Power Hương Chocolate - Chai 300ml',N'Chai','100',10200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP109',N'Thức uống năng lượng Vinamilk Power Hương Cam Đào - Chai 300ml',N'Chai','100',10200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP110',N'Thức uống năng lượng Vinamilk Power Hương Chocolate - Lốc 4 hộp x 180ml',N'Lốc','100',29600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP111',N'Sữa tươi tiệt trùng Vinamilk 100% Organic không đường - Hộp giấy 1L',N'Hộp','100',53200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP112',N'Sữa dinh dưỡng Vinamilk ADM Gold Chuối - Lốc 4 hộp x 110ml',N'Lốc','100',17100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP113',N'Sữa dinh dưỡng Vinamilk ADM Gold Có đường - Lốc 4 hộp x 110ml',N'Lốc','100',17100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP114',N'Thùng 12 hộp Sữa tươi tiệt trùng Vinamilk 100% Có đường 1L',N'Thùng','100',377400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP115',N'Thùng 48 hộp Sữa dinh dưỡng ADM Gold Chuối 110ml',N'Thùng','100',204300,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP116',N'Thùng 12 hộp Sữa tươi tiệt trùng Vinamilk 100% Không đường 1L',N'Thùng','100',377400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP117',N'Sữa dinh dưỡng Vinamilk Happy Star Có đường - Bịch 220ml',N'Bịch','100',5900,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP118',N'Thùng 12 hộp Sữa dinh dưỡng Vinamilk ADM Gold Có đường 180ml',N'Thùng','100',322080,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP119',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Có đường 110ml',N'Thùng','100',234400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP120',N'Thùng 48 hộp Sữa dinh dưỡng Vinamilk ADM Gold Hương dâu 180ml',N'Thùng','100',322080,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP121',N'Thức uống năng lượng Vinamilk Power Hương Cam Đào - Lốc 4 hộp x 180ml',N'Lốc','100',29600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP122',N'Thức uống năng lượng Vinamilk My Joy Hương Cam Đào - Lốc 4 hộp x 180ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP123',N'Thức uống năng lượng Vinamilk My Joy Hương Chocolate - Lốc 4 hộp x 180ml',N'Lốc','100',26800,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP124',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Chocolate 180ml',N'Thùng','100',369600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP125',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Ít Đường 180ml',N'Thùng','100',369600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP126',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Hương Dâu 180ml',N'Thùng','100',369600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP127',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Không Đường 180ml',N'Thùng','100',369600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP128',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Ít Đường 110ml',N'Thùng','100',234400,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP129',N'Thùng 48 bịch Sữa dinh dưỡng Vinamilk 100% Chocolate 220ml',N'Thùng','100',315200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP130',N'Thùng 48 bịch Sữa dinh dưỡng Vinamilk 100% Không Đường 220ml',N'Thùng','100',315200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP131',N'Thùng 48 bịch Sữa dinh dưỡng Vinamilk 100% Hương Dâu 220ml',N'Thùng','100',315200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP132',N'Thùng 48 bịch Sữa dinh dưỡng Vinamilk 100% Có Đường 220ml',N'Thùng','100',315200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP133',N'Thùng 48 hộp thức uống năng lượng Vinamilk Power Chocolate 180ml',N'Thùng','100',355300,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP134',N'Thùng 48 hộp thức uống năng lượng Vinamilk Power Hương Cam Đào 180ml',N'Thùng','100',355300,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP135',N'Thùng 24 chai thức uống năng lượng Vinamilk Power Chocolate 300ml',N'Thùng','100',247100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP136',N'Thùng 24 chai thức uống năng lượng Vinamilk Power Hương Cam Đào 300ml',N'Thùng','100',247100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP137',N'Thùng 12 lốc sữa tươi tiệt trùng 180ml Vinamilk 100% Organic không đường',N'Thùng','100',528000,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP138',N'Thùng 24 chai sữa dinh dưỡng ADM Gold Chuối 150ml',N'Thùng','100',161040,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP139',N'Thức uống năng lượng Vinamilk My Joy Chocolate - Chai 300ml',N'Chai','100',10200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
 ('SP140',N'Thùng 24 chai thức uống năng lượng Vinamilk My Joy Chocolate 300ml',N'Thùng','100',247100,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng')
 
 INSERT INTO HANGHOA VALUES('SP141',N'Thùng 12 hộp sữa tươi tiệt trùng 1L Vinamilk 100% Organic không đường',N'Thùng','100',638220,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
('SP142',N'Thùng 48 hộp Sữa tươi tiệt trùng Vinamilk 100% Có Đường 180ml',N'Thùng','100',369600,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
('SP143',N'Thùng 48 hộp dinh dưỡng Vinamilk ADM Gold Chocolate 180ml',N'Thùng','100',322080,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
('SP144',N'Lô 6 chai trà thanh nhiệt Dr.Thanh 455ml',N'Lô',100,52900,'NCC7',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
('SP145',N'Thùng 48 bịch Sữa dinh dưỡng Vinamilk Ít Đường 220ml',N'Thùng','100',315200,'NCC9',N'Việt Nam',N'Sữa nước',N'Còn Hàng'),
('SP146',N'Lô 6 lon nước khoáng Lavie Sparking 330ml',N'Lô',100,57000,'NCC6',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
('SP147',N'Lô 6 chai nước táo lên men Strongbow 330ml',N'Lô',100,88500,'NCC15',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
('SP148',N'Lô 6 chai nước ngọt Coca-Cola 390ml',N'Lô',100,34800,'NCC4',N'Việt Nam',N'Nước ngọt,nước khoáng',N'Còn Hàng'),
('SP149',N'Bánh Oreo 133g',N'Gói',100,11500,'NCC14',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng'),
('SP150',N'Bánh Choco-Pie Chocolate hộp 12 gói 369g',N'Lô',100,42900,'NCC23',N'Việt Nam',N'Thực Phẩm',N'Còn Hàng')

 INSERT INTO HANGHOA VALUES('SP151',N'Dầu gội TRESemmé 640 ml',N'Chai',100,159300,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP152',N'Dầu gội Rejoice hương nước hoa 632ml',N'Chai',100,103500,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP153',N'Dầu gội Head & Shoulders 550ml',N'Chai',100,135900,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP154',N'Dầu gội Dove 900ml',N'Chai',100,156900,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP155',N'Dầu gội Sunsilk 650g các loại',N'Chai',100,109200,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP156',N'Dầu gội Clear Bạc hà 900ml',N'Chai',100,175400,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP157',N'Dầu gội Clear Thảo dược 900ml',N'Chai',100,194900,'NCC9',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP158',N'Nước rửa chén Lipon 550ml',N'Túi',100,21500,'NCC9',N'Việt Nam',N'Nước rửa chén',N'Còn Hàng'),
('SP159',N'Nước rửa chén Lix chanh siêu đậm đặc 4kg',N'Bình',100,53900,'NCC9',N'Việt Nam',N'Nước rửa chén',N'Còn Hàng'),
('SP160',N'Nước giặt Ariel Matic giữ màu túi 2,15Kg',N'Túi',100,106900,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng')

INSERT INTO HANGHOA VALUES('SP161',N'Nước xả vải Downy Đam mê túi 2,3L',N'Túi',100,118700,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP162',N'Nước giặt Ariel Matic dịu nhẹ túi 2,15Kg',N'Túi',100,106900,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP163',N'Nước xả vải Downy Huyền bí túi 2,3L',N'Túi',100,118700,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP164',N'Nước xả vải Downy Tươi trẻ túi 2,3L',N'Túi',100,118700,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP165',N'Nước xả vải Downy Sakura túi 2,3L',N'Túi',100,118700,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP166',N'Nước xả vải Downy Cuốn hút túi 2,3L',N'Túi',100,118700,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP167',N'Nước giặt Surf Cỏ hoa bịch 3.8Kg',N'Bịch',100,84200,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP168',N'Nước giặt Surf Sương mai bịch 3.8Kg',N'Bịch',100,84200,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP169',N'Nước giặt Downy Vườn hoa túi 2.1Kg',N'Túi',100,115900,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP170',N'Nước giặt Downy Biển xanh túi 2.1Kg',N'Túi',100,115900,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng')

INSERT INTO HANGHOA VALUES('SP171',N'Bột giặt Lix nước hoa 5,5Kg',N'Bịch',100,207900,'NCC2',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP172',N'Bột giặt Tide hương Downy 6.8Kg',N'Bịch',100,245900,'NCC24',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP173',N'Nước giặt Carefor Pink 2L',N'Túi',100,128300,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP174',N'Nước giặt xả Maxkleen hoa huyền diệu 2.4Kg',N'Bình',100,139900,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP175',N'Nước giặt xả vải Lix Sớm mai 3.8L',N'Bình',100,89600,'NCC2',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP176',N'Xịt côn trùng Jumbo 300ml',N'Chai',100,32900,'NCC9',N'Việt Nam',N'Diệt côn trùng',N'Còn Hàng'),
('SP177',N'Xịt côn trùng Ars jet 600ml',N'Chai',100,53500,'NCC9',N'Việt Nam',N'Diệt côn trùng',N'Còn Hàng'),
('SP178',N'Xịt côn trùng Raid 600ml',N'Chai',100,64800,'NCC9',N'Việt Nam',N'Diệt côn trùng',N'Còn Hàng'),
('SP179',N'Nước giặt Omo Matic hương Comfort túi 2.3Kg',N'Túi',100,118000,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP180',N'Nước xả vải Comfort Bella',N'Túi',100,143400,'NCC9',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng')

INSERT INTO HANGHOA VALUES('SP181',N'Bột giặt Omo Comfort 4Kg',N'Bịch',100,170100,'NCC10',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP182',N'Nước xả vải Comfort da nhạy cảm 2.6L',N'Túi',100,128500,'NCC10',N'Việt Nam',N'Bột giặt/nước giặt',N'Còn Hàng'),
('SP183',N'Nước tẩy bồn cầu Vim xanh biển 900ml',N'Chai',100,29800,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP184',N'Nước lau sàn Sunlight Hoa Diên Vỹ 2.6Kg',N'Túi',100,49500,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP185',N'Nước lau sàn Sunlight Hoa lily 2.6Kg',N'Túi',100,49500,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP186',N'Nước lau kính SWAT 4Kg',N'Bình',100,68900,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP187',N'Tẩy đa năng Cif chanh 690g',N'Chai',100,31400,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP188',N'Tẩy lau bếp Cif chanh 520ml',N'Chai',100,31400,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP189',N'Nước lau sàn Gift 3.8Kg',N'Bình',100,72900,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng'),
('SP190',N'Vỉ 4 viên tẩy toilet Hando',N'Vỉ',100,44600,'NCC10',N'Việt Nam',N'Nước lau sàn/kính',N'Còn Hàng')

INSERT INTO HANGHOA VALUES('SP191',N'Nước mắm Chinsu thượng hạng 35N 500ml',N'Chai',100,62400,'NCC17',N'Việt Nam',N'Gia Vị',N'Còn Hàng'),
('SP192',N'Cam Navel loại 1','Kg',500,69900,'NCC1',N'Úc',N'Trái cây',N'Còn Hàng'),
('SP193',N'Quýt vàng lọa 1','Kg',500,69900,'NCC1',N'Úc',N'Trái cây',N'Còn Hàng'),
('SP194',N'Táo Pink Lady','Kg',500,69900,'NCC1',N'New Zealand',N'Trái cây',N'Còn Hàng'),
('SP195',N'Lê Hàn Quốc','Kg',500,69900,'NCC1',N'Hàn Quốc',N'Trái cây',N'Còn Hàng'),
('SP196',N'Lê Forelle','Kg',500,69900,'NCC1',N'Nam Phi',N'Trái cây',N'Còn Hàng'),
('SP197',N'Dầu gội X-men Wood Sport 650g',N'Chai',100,150000,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP198',N'Dầu gội Enchanteur Charming 650g',N'Chai',100,135000,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP199',N'Dầu gội Romano Classic VIP',N'Chai 650g',100,167000,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng'),
('SP200',N'Dầu gội Sunsilk óng mượt rạng ngời 1.4Kg',N'Chai',100,242600,'NCC10',N'Việt Nam',N'Sữa tắm/Dầu gội',N'Còn Hàng')

--select * from hanghoa
 
INSERT INTO QUAYHANG VALUES('QUAY1','Quầy Đồ Uống')
--nước ngọt,nước khoáng / 
INSERT INTO QUAYHANG VALUES('QUAY2','Quầy Thực phẩm khô')
--bún,miến,mì,nui
INSERT INTO QUAYHANG VALUES('QUAY3','Quầy Chăm sóc tóc')
INSERT INTO QUAYHANG VALUES('QUAY4','Quầy Sữa và Thực phẩm từ sữa')
--sữa nước
INSERT INTO QUAYHANG VALUES('QUAY5','Quầy Kem')
INSERT INTO QUAYHANG VALUES('QUAY6','Quầy Giặt giũ & chăm sóc nhà cửa')
--nước rửa chén / nước lau sàn,kính /
INSERT INTO QUAYHANG VALUES('QUAY7','Quầy Gia Vị')
INSERT INTO QUAYHANG VALUES('QUAY8','Quầy Chưa biết')


INSERT INTO CTQUAYHANG VALUES('QUAY1','SP19',50)--nước ngọt,nước khoáng
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP27',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP31',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP41',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP47',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP49',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP54',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP60',21)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP65',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP66',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP67',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP144',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP145',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP146',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP147',50)
INSERT INTO CTQUAYHANG VALUES('QUAY1','SP148',50)




INSERT INTO CTQUAYHANG VALUES('QUAY2','SP5',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP10',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP14',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP16',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP29',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP39',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP40',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP42',50)
INSERT INTO CTQUAYHANG VALUES('QUAY2','SP44',50)

-- Chăm sóc tóc
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP3',50)--dầu gội,sữa tắm
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP20',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP28',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP48',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP62',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP63',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP151',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP152',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP153',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP154',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP155',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP156',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP157',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP197',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP198',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP199',50)
INSERT INTO CTQUAYHANG VALUES('QUAY3','SP200',50)

--sữa và thực phẩm từ sữa
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP68',50)--sữa
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP69',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP70',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP71',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP72',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP73',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP74',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP75',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP76',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP77',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP78',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP79',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP80',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP81',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP82',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP83',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP84',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP85',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP86',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP87',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP88',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP89',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP90',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP91',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP92',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP93',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP94',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP95',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP96',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP97',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP98',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP99',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP100',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP101',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP102',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP103',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP104',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP105',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP106',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP107',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP108',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP109',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP110',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP111',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP112',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP113',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP114',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP115',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP116',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP117',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP118',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP119',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP120',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP121',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP122',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP123',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP124',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP125',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP126',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP127',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP128',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP129',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP130',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP131',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP132',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP133',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP134',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP135',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP136',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP137',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP138',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP139',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP140',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP141',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP142',50)
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP143',50)

--quầy kem
INSERT INTO CTQUAYHANG VALUES('QUAY4','SP53',50)--kem

--
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP21',50)--nước lau sàn/kính
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP22',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP24',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP25',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP26',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP30',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP32',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP33',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP34',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP183',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP184',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP185',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP186',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP187',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP176',50)--Diệt côn trùng
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP177',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP178',50)
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP158',50)--nước rửa chén
INSERT INTO CTQUAYHANG VALUES('QUAY6','SP159',50)

INSERT INTO CTQUAYHANG VALUES('QUAY7','SP1',50)--gia vị
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP2',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP4',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP6',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP8',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP11',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP13',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP15',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP17',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP18',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP35',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP37',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP38',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP43',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP45',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP52',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP57',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP58',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP64',50)
INSERT INTO CTQUAYHANG VALUES('QUAY7','SP191',50)

INSERT INTO CTQUAYHANG VALUES('QUAY8','SP12',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP149',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP150',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP160',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP161',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP162',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP163',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP164',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP165',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP166',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP167',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP168',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP169',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP170',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP171',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP172',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP173',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP174',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP175',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP179',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP180',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP181',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP182',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP188',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP189',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP190',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP192',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP193',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP194',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP195',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP196',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP23',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP36',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP46',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP50',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP51',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP55',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP56',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP59',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP61',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP7',50)
INSERT INTO CTQUAYHANG VALUES('QUAY8','SP9',50)

--select * from CTQUAYHANG

--SELECT * FROM HANGHOA where loaisp=N'Thực phẩm' order by stt asc

--select loaisp from hanghoa group by loaisp


INSERT INTO KHOHANG VALUES('KHO1',N'Nhà Kho Số 1',N'92 Nam Kỳ Khởi Nghĩa, P. Bến Nghé, Quận 1, TP. HCM','NV15')
INSERT INTO KHOHANG VALUES('KHO2',N'Nhà Kho Số 2',N'40 Đồng Nai, P. 15, Quận 10, TP. HCM','NV16')
INSERT INTO KHOHANG VALUES('KHO3',N'Nhà Kho Số 3',N'145 Chấn Hưng, P. 6, Quận Tân Bình, TP. HCM','NV17')
INSERT INTO KHOHANG VALUES('KHO4',N'Nhà Kho Số 4',N'336 Tôn Đản, P. 4, Quận 4, TP. HCM','NV18')
INSERT INTO KHOHANG VALUES('KHO5',N'Nhà Kho Số 5',N'447 Huỳnh Văn Bánh, P. 13, Quận Phú Nhuận, TP. HCM','NV19')
INSERT INTO KHOHANG VALUES('KHO6',N'Nhà Kho Số 6',N'25/1 Giải Phóng, P. 4, Tân Bình, TP. HCM','NV20')

-- INSERT INTO KHOHANG VALUES('KHO7',N'Nhà Kho Số 6',N'25/1 Giải Phóng, P. 4, Tân Bình, TP. HCM','NV2')

INSERT INTO NHAPKHO VALUES('NK1','KHO1','NCC1','1/1/2018',0)
INSERT INTO NHAPKHO VALUES('NK2','KHO2','NCC11','1/1/2018',0)
INSERT INTO NHAPKHO VALUES('NK3','KHO3','NCC12','1/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK4','KHO4','NCC13','1/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK5','KHO5','NCC16','1/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK6','KHO1','NCC17','8/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK7','KHO2','NCC10','8/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK8','KHO3','NCC10','8/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK9','KHO4','NCC9','2/2/2018',0)
INSERT INTO NHAPKHO VALUES('NK10','KHO5','NCC10','2/2/2018',0)
--SELECT * FROM NHAPKHO
--SELECT TENHH,MANCC FROM HANGHOA GROUP BY MANCC,TENHH
-- SELECT * FROM HANGHOA WHERE MANCC='NCC9'

INSERT INTO CTNHAPKHO VALUES('NK1','SP51',100,18000)
INSERT INTO CTNHAPKHO VALUES('NK1','SP192',100,62910)
INSERT INTO CTNHAPKHO VALUES('NK1','SP193',100,62910)
INSERT INTO CTNHAPKHO VALUES('NK1','SP194',100,62910)
INSERT INTO CTNHAPKHO VALUES('NK1','SP195',100,62910)
INSERT INTO CTNHAPKHO VALUES('NK1','SP196',100,62910)

INSERT INTO CTKHO VALUES('KHO1','SP51',100)
INSERT INTO CTKHO VALUES('KHO1','SP192',100)
INSERT INTO CTKHO VALUES('KHO1','SP193',100)
INSERT INTO CTKHO VALUES('KHO1','SP194',100)
INSERT INTO CTKHO VALUES('KHO1','SP195',100)
INSERT INTO CTKHO VALUES('KHO1','SP196',100)


INSERT INTO CTNHAPKHO VALUES('NK2','SP14',100,5940)
INSERT INTO CTNHAPKHO VALUES('NK2','SP16',100,2880)
INSERT INTO CTNHAPKHO VALUES('NK2','SP5',100,12510)
INSERT INTO CTNHAPKHO VALUES('NK2','SP9',100,12510)

INSERT INTO CTKHO VALUES('KHO2','SP14',100)
INSERT INTO CTKHO VALUES('KHO2','SP16',100)
INSERT INTO CTKHO VALUES('KHO2','SP5',100)

INSERT INTO CTNHAPKHO VALUES('NK3','SP1',100,25020)
INSERT INTO CTNHAPKHO VALUES('NK3','SP18',100,35100)
INSERT INTO CTNHAPKHO VALUES('NK3','SP36',100,14850)
INSERT INTO CTNHAPKHO VALUES('NK3','SP57',100,76500)
INSERT INTO CTNHAPKHO VALUES('NK3','SP59',100,105930)
INSERT INTO CTNHAPKHO VALUES('NK3','SP64',100,139950)
INSERT INTO CTNHAPKHO VALUES('NK4','SP13',100,81000)
INSERT INTO CTNHAPKHO VALUES('NK4','SP17',100,49500)
INSERT INTO CTNHAPKHO VALUES('NK4','SP2',100,51300)
INSERT INTO CTNHAPKHO VALUES('NK4','SP35',100,13410)
INSERT INTO CTNHAPKHO VALUES('NK4','SP38',100,21150)
INSERT INTO CTNHAPKHO VALUES('NK4','SP58',100,26550)
INSERT INTO CTNHAPKHO VALUES('NK4','SP8',100,41400)
INSERT INTO CTNHAPKHO VALUES('NK5','SP12',100,231300)
INSERT INTO CTNHAPKHO VALUES('NK5','SP37',100,9090)
INSERT INTO CTNHAPKHO VALUES('NK5','SP46',100,76860)
INSERT INTO CTNHAPKHO VALUES('NK5','SP49',100,70200)
INSERT INTO CTNHAPKHO VALUES('NK5','SP50',100,21870)
INSERT INTO CTNHAPKHO VALUES('NK5','SP54',100,34380)
INSERT INTO CTNHAPKHO VALUES('NK5','SP55',100,36360)
INSERT INTO CTNHAPKHO VALUES('NK6','SP11',100,29250)
INSERT INTO CTNHAPKHO VALUES('NK6','SP15',100,36000)
INSERT INTO CTNHAPKHO VALUES('NK6','SP191',100,56160)
INSERT INTO CTNHAPKHO VALUES('NK6','SP29',100,5220)
INSERT INTO CTNHAPKHO VALUES('NK6','SP39',100,5220)
INSERT INTO CTNHAPKHO VALUES('NK6','SP4',100,39510)
INSERT INTO CTNHAPKHO VALUES('NK6','SP40',100,5220)
INSERT INTO CTNHAPKHO VALUES('NK6','SP42',100,6300)
INSERT INTO CTNHAPKHO VALUES('NK6','SP45',100,36000)
INSERT INTO CTNHAPKHO VALUES('NK6','SP6',100,30510)
INSERT INTO CTNHAPKHO VALUES('NK7','SP181',100,153090)
INSERT INTO CTNHAPKHO VALUES('NK7','SP182',100,115650)
INSERT INTO CTNHAPKHO VALUES('NK7','SP183',100,26820)
INSERT INTO CTNHAPKHO VALUES('NK7','SP184',100,44550)
INSERT INTO CTNHAPKHO VALUES('NK7','SP185',100,44550)
INSERT INTO CTNHAPKHO VALUES('NK7','SP186',100,62010)
INSERT INTO CTNHAPKHO VALUES('NK7','SP187',100,28260)
INSERT INTO CTNHAPKHO VALUES('NK7','SP188',100,28260)
INSERT INTO CTNHAPKHO VALUES('NK7','SP189',100,65610)
INSERT INTO CTNHAPKHO VALUES('NK7','SP190',100,40140)

INSERT INTO CTNHAPKHO VALUES('NK8','SP197',100,135000)
INSERT INTO CTNHAPKHO VALUES('NK8','SP198',100,121500)
INSERT INTO CTNHAPKHO VALUES('NK8','SP199',100,150300)
INSERT INTO CTNHAPKHO VALUES('NK8','SP20',100,118260)
INSERT INTO CTNHAPKHO VALUES('NK8','SP200',100,218340)
INSERT INTO CTNHAPKHO VALUES('NK8','SP21',100,89100)
INSERT INTO CTNHAPKHO VALUES('NK8','SP22',100,82800)
INSERT INTO CTNHAPKHO VALUES('NK8','SP23',100,70200)
INSERT INTO CTNHAPKHO VALUES('NK8','SP24',100,20700)
INSERT INTO CTNHAPKHO VALUES('NK8','SP25',100,19800)
INSERT INTO CTNHAPKHO VALUES('NK8','SP26',100,42300)
INSERT INTO CTNHAPKHO VALUES('NK8','SP28',100,143010)
INSERT INTO CTNHAPKHO VALUES('NK9','SP100',100,32130)
INSERT INTO CTNHAPKHO VALUES('NK9','SP101',100,32130)
INSERT INTO CTNHAPKHO VALUES('NK9','SP102',100,7740)
INSERT INTO CTNHAPKHO VALUES('NK9','SP103',100,22140)
INSERT INTO CTNHAPKHO VALUES('NK9','SP104',100,26010)
INSERT INTO CTNHAPKHO VALUES('NK9','SP105',100,5850)
INSERT INTO CTNHAPKHO VALUES('NK9','SP106',100,24120)
INSERT INTO CTNHAPKHO VALUES('NK9','SP108',100,9180)
INSERT INTO CTNHAPKHO VALUES('NK10','SP109',100,5940)
INSERT INTO CTNHAPKHO VALUES('NK10','SP110',100,26640)
INSERT INTO CTNHAPKHO VALUES('NK10','SP111',100,47880)
INSERT INTO CTNHAPKHO VALUES('NK10','SP112',100,15390)
INSERT INTO CTNHAPKHO VALUES('NK10','SP113',100,15390)
INSERT INTO CTNHAPKHO VALUES('NK10','SP117',100,5310)
INSERT INTO CTNHAPKHO VALUES('NK10','SP121',100,26640)
INSERT INTO CTNHAPKHO VALUES('NK10','SP122',100,24120)

--select * from hanghoa WHERE MANCC='NCC10'

INSERT INTO XUATKHO VALUES('XK1','KHO1','2/1/2018',0)
insert into XUATKHO values('XK2','KHO2','2/1/2018',0)
insert into XUATKHO values('XK3','KHO3','3/12/2018',0)
insert into XUATKHO values('XK4','KHO4','13/1/2018',0)
insert into XUATKHO values('XK5','KHO1','23/9/2018',0)
insert into XUATKHO values('XK6','KHO5','27/8/2018',0)
insert into XUATKHO values('XK7','KHO5','17/4/2018',0)
insert into XUATKHO values('XK8','KHO3','6/10/2018',0)
insert into XUATKHO values('XK9','KHO2','19/5/2018',0)
insert into XUATKHO values('XK10','KHO5','2/5/2018',0)

--select * from  XUATKHO

--INSERT INTO CTXUATKHO VALUES('XK1','SP7',100,'QUAY1') -- HÀNG CHƯA CÓ TRÊN QUẦY
INSERT INTO CTXUATKHO VALUES('XK1','SP1',100,'QUAY7')
INSERT INTO CTXUATKHO VALUES('XK1','SP2',190,'QUAY7')--mã quầy k đúng
INSERT INTO CTXUATKHO VALUES('XK1','SP4',100,'QUAY7')
--INSERT INTO CTXUATKHO VALUES('XK1','SP1',100,'QUAY1')
--select * from CTQUAYHANG WHERE MAQUAY='QUAY1'

INSERT INTO QUAYTN VALUES('QTN1',N'Quầy thu ngân 1','NV1')
INSERT INTO QUAYTN VALUES('QTN2',N'Quầy thu ngân 2','NV2')
INSERT INTO QUAYTN VALUES('QTN3',N'Quầy thu ngân 3','NV3')
INSERT INTO QUAYTN VALUES('QTN4',N'Quầy thu ngân 4','NV4')
INSERT INTO QUAYTN VALUES('QTN5',N'Quầy thu ngân 5','NV5')
INSERT INTO QUAYTN VALUES('QTN6',N'Quầy thu ngân 6','NV6')
INSERT INTO QUAYTN VALUES('QTN7',N'Quầy thu ngân 7','NV8')
INSERT INTO QUAYTN VALUES('QTN8',N'Quầy thu ngân 8','NV9')
INSERT INTO QUAYTN VALUES('QTN9',N'Quầy thu ngân 9','NV10')
INSERT INTO QUAYTN VALUES('QTN10',N'Quầy thu ngân 10','NV14')

INSERT INTO HOADON VALUES('HD1','3/4/2018','14:00','KH1','QTN1',0),--1444277
 ('HD2', '2019-6-25', '10:4', 'KH99', 'QTN4', 0),--3660700.0
 ('HD3', '2019-4-30', '21:18', 'KH81', 'QTN4',0 ),--654725.0
 ('HD4', '2019-7-16', '9:31', 'KH5', 'QTN4', 0),--976400.0
 ('HD5', '2019-2-13', '7:3', 'KH77', 'QTN2',0 ),--169600.0
 ('HD6', '2019-6-17', '14:3', 'KH21', 'QTN3', 0),--3574200.0
 ('HD7', '2019-10-29', '9:24', 'KH83', 'QTN4', 0),--759700.0
 ('HD8', '2019-1-27', '17:20', 'KH85', 'QTN10', 0),--3273000.0
 ('HD9', '2019-9-12', '19:15', 'KH83', 'QTN3', 0),--2618600.0
 ('HD10', '2019-12-24', '10:43', 'KH50', 'QTN9', 0),--1060000.0
 ('HD11', '2019-4-21', '16:15', 'KH82', 'QTN2', 0),--157000.0
 ('HD12', '2019-4-25', '21:11', 'KH80', 'QTN3', 0),--1047400.0
 ('HD13', '2019-9-23', '14:3', 'KH97', 'QTN8', 0),--2684500.0
 ('HD14', '2019-4-19', '19:3', 'KH21', 'QTN10', 0),--257040.0
 ('HD15', '2019-12-20', '16:57', 'KH67', 'QTN4', 0),--5548100.0
 ('HD16', '2019-8-19', '18:48', 'KH96', 'QTN2', 0),--1193600.0
 ('HD17', '2019-2-7', '19:32', 'KH46', 'QTN1', 0),--346000.0
 ('HD18', '2019-3-27', '20:19', 'KH30', 'QTN3', 0),--1295500.0
 ('HD19', '2019-11-6', '12:55', 'KH34', 'QTN5', 0),--466600.0
 ('HD20', '2019-5-6', '17:31', 'KH96', 'QTN4', 0),--1758400.0
 ('HD21', '2019-2-26', '15:36', 'KH55', 'QTN6', 0),--60200.0
 ('HD22', '2019-10-25', '21:16', 'KH30', 'QTN5', 0),--1546900.0
 ('HD23', '2019-4-11', '8:48', 'KH84', 'QTN4', 0),--2479400.0
 ('HD24', '2019-12-8', '7:27', 'KH25', 'QTN7', 0),--2805000.0
 ('HD25', '2019-1-20', '11:3', 'KH20', 'QTN10', 0),--6919500.0
 ('HD26', '2019-8-27', '12:28', 'KH84', 'QTN7', 0),--1834500.0
 ('HD27', '2019-9-20', '19:8', 'KH31', 'QTN8', 0),--3792200.0
 ('HD28', '2019-4-18', '16:1', 'KH8', 'QTN1', 0),--1605900.0
 ('HD29', '2019-1-21', '14:34', 'KH12', 'QTN3', 0),--4225000.0
 ('HD30', '2019-11-12', '15:6', 'KH54', 'QTN2', 0),--5794700.0
 ('HD31', '2019-2-15', '8:22', 'KH95', 'QTN2', 0),--6340500.0
 ('HD32', '2019-12-9', '19:11', 'KH36', 'QTN2', 0),--2314800.0
 ('HD33', '2019-11-14', '11:8', 'KH95', 'QTN2', 0),--3664800.0
 ('HD34', '2019-2-22', '19:18', 'KH98', 'QTN7', 0),--7679500.0
 ('HD35', '2019-7-3', '13:39', 'KH61', 'QTN3', 0),--540600.0
 ('HD36', '2019-9-1', '12:50', 'KH47', 'QTN3', 0),--2748600.0
 ('HD37', '2019-11-23', '21:4', 'KH2', 'QTN8', 0),--1798700.0
 ('HD38', '2019-7-2', '21:24', 'KH81', 'QTN1', 0),--2587200.0
 ('HD39', '2019-2-1', '21:8', 'KH63', 'QTN4', 0),--2038400.0
 ('HD40', '2019-5-18', '17:10', 'KH76', 'QTN5', 0),--3302000.0
 ('HD41', '2019-10-7', '14:19', 'KH33', 'QTN1', 0),--968400.0
 ('HD42', '2019-4-1', '20:58', 'KH66', 'QTN5', 0),--2836800.0
 ('HD43', '2019-9-22', '7:26', 'KH92', 'QTN2', 0),--3209300.0
 ('HD44', '2019-9-11', '15:52', 'KH72', 'QTN7', 0),--564700.0
 ('HD45', '2019-11-7', '9:8', 'KH60', 'QTN10', 0),--65800.0
 ('HD46', '2019-7-16', '10:40', 'KH80', 'QTN8', 0),--4177100.0
 ('HD47', '2019-3-18', '15:48', 'KH62', 'QTN2', 0),--1046000.0
 ('HD48', '2019-8-27', '17:36', 'KH64', 'QTN4', 0),--540000.0
 ('HD49', '2019-9-19', '13:56', 'KH23', 'QTN10', 0),--1152000.0
 ('HD50', '2019-9-27', '7:15', 'KH57', 'QTN7', 0),--837300.0
 ('HD51', '2019-7-19', '8:25', 'KH67', 'QTN6', 0),--3455400.0
 ('HD52', '2019-12-15', '11:18', 'KH23', 'QTN4', 0),--335500.0
 ('HD53', '2019-2-25', '20:59', 'KH66', 'QTN3', 0),--42000.0
 ('HD54', '2019-9-24', '16:15', 'KH12', 'QTN7', 0),--1271200.0
 ('HD55', '2019-5-6', '14:5', 'KH34', 'QTN10', 0),--1126100.0
 ('HD56', '2019-1-10', '20:11', 'KH46', 'QTN8', 0),--39000.0
 ('HD57', '2019-12-5', '7:56', 'KH19', 'QTN9', 0),--2356900.0
 ('HD58', '2019-10-19', '8:53', 'KH80', 'QTN10', 0),--1569600.0
 ('HD59', '2019-6-6', '18:12', 'KH61', 'QTN2', 0),--1821600.0
 ('HD60', '2019-7-21', '8:57', 'KH40', 'QTN8', 0),--1141600.0
 ('HD61', '2019-1-3', '16:45', 'KH84', 'QTN9', 0),--561700.0
 ('HD62', '2019-1-3', '10:4', 'KH41', 'QTN1', 0),--1423400.0
 ('HD63', '2019-4-23', '14:33', 'KH37', 'QTN7', 0),--1891200.0
 ('HD64', '2019-6-22', '10:5', 'KH99', 'QTN5', 0),--581400.0
 ('HD65', '2019-5-30', '14:2', 'KH58', 'QTN8', 0),--1985600.0
 ('HD66', '2019-6-30', '7:5', 'KH17', 'QTN9', 0),--1403200.0
 ('HD67', '2019-3-17', '10:38', 'KH24', 'QTN1', 0),--764000.0
 ('HD68', '2019-2-9', '7:50', 'KH30', 'QTN6', 0),--5496000.0
 ('HD69', '2019-9-13', '8:55', 'KH61', 'QTN9', 0),--2662900.0
 ('HD70', '2019-7-22', '21:56', 'KH48', 'QTN1', 0),--543500.0
 ('HD71', '2019-9-23', '18:18', 'KH71', 'QTN6', 0),--1053800.0
 ('HD72', '2019-2-26', '21:37', 'KH21', 'QTN4', 0),--927100.0
 ('HD73', '2019-11-10', '16:48', 'KH57', 'QTN2', 0),--1163300.0
 ('HD74', '2019-10-27', '19:35', 'KH93', 'QTN7', 0),--1943900.0
 ('HD75', '2019-7-24', '11:20', 'KH58', 'QTN8', 0),--3702000.0
 ('HD76', '2019-5-17', '21:17', 'KH97', 'QTN9', 0),--3701500.0
 ('HD77', '2019-10-7', '15:57', 'KH34', 'QTN10', 0),--952900.0
 ('HD78', '2019-10-27', '17:44', 'KH21', 'QTN1', 0),--1878600.0
 ('HD79', '2019-1-19', '10:25', 'KH73', 'QTN10', 0),--1026500.0
 ('HD80', '2019-3-26', '21:50', 'KH5', 'QTN1', 0),--1367100.0
 ('HD81', '2019-1-30', '17:5', 'KH1', 'QTN7', 0),--4582400.0
 ('HD82', '2019-8-18', '10:18', 'KH8', 'QTN1', 0),--2133020.0
 ('HD83', '2019-12-25', '12:5', 'KH50', 'QTN8', 0),--243000.0
 ('HD84', '2019-12-3', '9:55', 'KH75', 'QTN3', 0),--20400.0
 ('HD85', '2019-7-7', '18:33', 'KH94', 'QTN4', 0),--3012200.0
 ('HD86', '2019-7-1', '10:50', 'KH8', 'QTN1', 0),--740700.0
 ('HD87', '2019-6-15', '14:36', 'KH53', 'QTN1', 0),--330300.0
 ('HD88', '2019-10-7', '10:22', 'KH23', 'QTN4', 0),--2716300.0
 ('HD89', '2019-6-5', '15:34', 'KH55', 'QTN10', 0),--2056080.0
 ('HD90', '2019-4-29', '13:24', 'KH46', 'QTN1', 0),--5825800.0
 ('HD91', '2019-9-27', '14:22', 'KH40', 'QTN9', 0),--1218200.0
 ('HD92', '2019-12-6', '17:36', 'KH58', 'QTN6', 0),--1954850.0
 ('HD93', '2019-6-26', '18:24', 'KH99', 'QTN1', 0),--8475400.0
 ('HD94', '2019-8-29', '19:12', 'KH90', 'QTN8', 0),--3168900.0
 ('HD95', '2019-11-26', '14:37', 'KH72', 'QTN5', 0),--1215000.0
 ('HD96', '2019-2-27', '16:51', 'KH55', 'QTN9', 0),--564800.0
 ('HD97', '2019-10-24', '20:22', 'KH41', 'QTN2', 0),--117400.0
 ('HD98', '2019-8-9', '21:39', 'KH55', 'QTN6', 0),--7588780.0
 ('HD99', '2019-10-9', '20:4', 'KH72', 'QTN2', 0),--2913000.0
 ('HD100', '2019-11-11', '8:18', 'KH73', 'QTN5', 0),--1504100.0
 ('HD101', '2019-6-27', '20:25', 'KH5', 'QTN1', 0),--643400.0
 ('HD102', '2019-9-2', '16:56', 'KH62', 'QTN9', 0),--518000.0
 ('HD103', '2019-12-11', '11:15', 'KH35', 'QTN5', 0),--3342070.0
 ('HD104', '2019-1-6', '8:27', 'KH83', 'QTN5', 0),--3847510.0
 ('HD105', '2019-8-19', '9:18', 'KH5', 'QTN6', 0),--1122000.0
 ('HD106', '2019-10-7', '13:18', 'KH48', 'QTN1', 0),--6367000.0
 ('HD107', '2019-5-27', '11:59', 'KH7', 'QTN4', 0),--2643400.0
 ('HD108', '2019-12-12', '16:53', 'KH47', 'QTN8', 0),--25800.0
 ('HD109', '2019-10-20', '7:24', 'KH2', 'QTN9', 0),--5268400.0
 ('HD110', '2019-9-12', '14:53', 'KH15', 'QTN6', 0),--344000.0
 ('HD111', '2019-10-14', '19:33', 'KH2', 'QTN3', 0),--4832820.0
 ('HD112', '2019-4-13', '20:29', 'KH100', 'QTN4', 0),--3889800.0
 ('HD113', '2019-3-29', '19:48', 'KH36', 'QTN9', 0),--3859800.0
 ('HD114', '2019-4-5', '11:33', 'KH90', 'QTN5', 0),--1949900.0
 ('HD115', '2019-11-28', '8:42', 'KH65', 'QTN8', 0),--3587640.0
 ('HD116', '2019-8-4', '11:1', 'KH80', 'QTN6', 0),--755400.0
 ('HD117', '2019-2-2', '11:5', 'KH59', 'QTN5', 0),--838500.0
 ('HD118', '2019-3-9', '19:21', 'KH85', 'QTN4', 0),--1243900.0
 ('HD119', '2019-3-2', '13:56', 'KH100', 'QTN7', 0),--2030400.0
 ('HD120', '2019-7-25', '19:58', 'KH71', 'QTN9', 0),--3297200.0
 ('HD121', '2019-6-20', '20:39', 'KH25', 'QTN1', 0),--1332000.0
 ('HD122', '2019-1-15', '19:28', 'KH52', 'QTN9', 0),--328200.0
 ('HD123', '2019-2-4', '9:9', 'KH90', 'QTN2', 0),--2985000.0
 ('HD124', '2019-1-1', '15:36', 'KH73', 'QTN1', 0),--863400.0
 ('HD125', '2019-8-9', '12:5', 'KH61', 'QTN4', 0),--213800.0
 ('HD126', '2019-11-5', '14:6', 'KH54', 'QTN1', 0),--2135900.0
 ('HD127', '2019-9-23', '14:24', 'KH22', 'QTN6', 0),--340230.0
 ('HD128', '2019-5-4', '21:34', 'KH55', 'QTN5', 0),--5799800.0
 ('HD129', '2019-2-7', '17:29', 'KH74', 'QTN9', 0),--1595000.0
 ('HD130', '2019-11-5', '13:15', 'KH90', 'QTN3', 0),--2091500.0
 ('HD131', '2019-10-26', '18:13', 'KH80', 'QTN3', 0),--1068300.0
 ('HD132', '2019-4-28', '13:57', 'KH31', 'QTN1', 0),--3556000.0
 ('HD133', '2019-12-15', '21:14', 'KH1', 'QTN4', 0),--233600.0
 ('HD134', '2019-12-8', '7:47', 'KH98', 'QTN1', 0),--156000.0
 ('HD135', '2019-10-16', '10:38', 'KH49', 'QTN8', 0),--3731200.0
 ('HD136', '2019-7-3', '9:6', 'KH85', 'QTN6', 0),--1454000.0
 ('HD137', '2019-1-3', '10:9', 'KH26', 'QTN4',0),-- 1702480.0
 ('HD138', '2019-6-21', '15:35', 'KH41', 'QTN2', 0),--390000.0
 ('HD139', '2019-2-10', '21:9', 'KH3', 'QTN6', 0),--1426300.0
 ('HD140', '2019-12-15', '10:13', 'KH100', 'QTN6', 0),--1102300.0
 ('HD141', '2019-3-14', '13:14', 'KH12', 'QTN8', 0),--2743775.0
 ('HD142', '2019-8-29', '16:49', 'KH50', 'QTN9', 0),--6439360.0
 ('HD143', '2019-3-21', '19:24', 'KH64', 'QTN3', 0),--2972200.0
 ('HD144', '2019-9-2', '14:53', 'KH65', 'QTN7', 0),--2765300.0
 ('HD145', '2019-8-10', '17:35', 'KH23', 'QTN8',0),-- 80400.0
 ('HD146', '2019-8-20', '15:23', 'KH61', 'QTN6', 0),--3800000.0
 ('HD147', '2019-11-16', '11:33', 'KH55', 'QTN4', 0),--4356600.0
 ('HD148', '2019-3-5', '10:52', 'KH61', 'QTN3', 0),--605600.0
 ('HD149', '2019-1-1', '13:43', 'KH39', 'QTN2', 0),--4326580.0
 ('HD150', '2019-2-27', '11:4', 'KH23', 'QTN3', 0),--2815200.0
 ('HD151', '2019-7-30', '7:44', 'KH38', 'QTN3', 0),--1184200.0
 ('HD152', '2019-9-24', '19:47', 'KH92', 'QTN6', 0),--1879700.0
 ('HD153', '2019-11-14', '7:27', 'KH23', 'QTN2', 0),--1057800.0
 ('HD154', '2019-1-13', '13:16', 'KH2', 'QTN5', 0),--2502700.0
 ('HD155', '2019-4-29', '13:9', 'KH99', 'QTN3',0),-- 9374400.0
 ('HD156', '2019-2-4', '19:36', 'KH94', 'QTN10', 0),--3722600.0
 ('HD157', '2019-5-13', '16:42', 'KH85', 'QTN3', 0),--2713200.0
 ('HD158', '2019-9-19', '12:3', 'KH44', 'QTN4', 0),--1934000.0
 ('HD159', '2019-6-13', '18:4', 'KH24', 'QTN6', 0),--3671600.0
 ('HD160', '2019-12-6', '8:7', 'KH97', 'QTN2', 0),--1244600.0
 ('HD161', '2019-4-30', '11:55', 'KH53', 'QTN7', 0),--2400400.0
 ('HD162', '2019-5-4', '14:9', 'KH75', 'QTN8', 0),--4920500.0
 ('HD163', '2019-4-15', '17:4', 'KH50', 'QTN7', 0),--1697200.0
 ('HD164', '2019-9-18', '21:52', 'KH58', 'QTN6', 0),--82000.0
 ('HD165', '2019-11-12', '19:16', 'KH96', 'QTN4', 0),--1456800.0
 ('HD166', '2019-2-6', '15:8', 'KH8', 'QTN9', 0),--2125900.0
 ('HD167', '2019-12-18', '20:3', 'KH7', 'QTN2', 0),--3237480.0
 ('HD168', '2019-11-30', '10:52', 'KH83', 'QTN9', 0),--377200.0
 ('HD169', '2019-11-25', '20:4', 'KH14', 'QTN2', 0),--3341200.0
 ('HD170', '2019-5-10', '11:33', 'KH75', 'QTN3', 0),--359200.0
 ('HD171', '2019-4-1', '9:46', 'KH80', 'QTN8', 0),--1111600.0
 ('HD172', '2019-7-6', '7:25', 'KH47', 'QTN4', 0),--3097000.0
 ('HD173', '2019-2-3', '9:13', 'KH66', 'QTN9', 0),--308000.0
 ('HD174', '2019-11-28', '17:41', 'KH95', 'QTN7', 0),--2129420.0
 ('HD175', '2019-11-4', '16:7', 'KH53', 'QTN5', 0),--1686900.0
 ('HD176', '2019-5-22', '14:21', 'KH43', 'QTN9', 0),--1412500.0
 ('HD177', '2019-3-30', '14:8', 'KH20', 'QTN8', 0),--1917240.0
 ('HD178', '2019-1-14', '7:33', 'KH88', 'QTN3', 0),--5409800.0
 ('HD179', '2019-1-25', '15:22', 'KH57', 'QTN4', 0),--1055600.0
 ('HD180', '2019-1-27', '17:53', 'KH79', 'QTN1', 0),--1009700.0
 ('HD181', '2019-7-19', '14:32', 'KH94', 'QTN9', 0),--4195900.0
 ('HD182', '2019-6-6', '14:40', 'KH86', 'QTN1', 0),--1200400.0
 ('HD183', '2019-11-21', '13:54', 'KH38', 'QTN1', 0),--193900.0
 ('HD184', '2019-7-12', '19:2', 'KH15', 'QTN10', 0),--2144600.0
 ('HD185', '2019-4-9', '9:10', 'KH5', 'QTN3', 0),--1875700.0
 ('HD186', '2019-1-16', '9:26', 'KH44', 'QTN6', 0),--586800.0
 ('HD187', '2019-5-9', '8:34', 'KH31', 'QTN8', 0),--2090800.0
 ('HD188', '2019-12-21', '18:11', 'KH94', 'QTN4', 0),--212800.0
 ('HD189', '2019-11-21', '10:6', 'KH81', 'QTN6', 0),--6003740.0
 ('HD190', '2019-9-25', '10:15', 'KH60', 'QTN9', 0),--2130760.0
 ('HD191', '2019-4-17', '20:43', 'KH86', 'QTN3', 0),--3880900.0
 ('HD192', '2019-3-6', '16:39', 'KH42', 'QTN4', 0),--4081400.0
 ('HD193', '2019-4-24', '17:48', 'KH31', 'QTN6', 0),--603000.0
 ('HD194', '2019-3-12', '7:14', 'KH95', 'QTN9', 0),--3297000.0
 ('HD195', '2019-5-25', '8:45', 'KH32', 'QTN1', 0),--52200.0
 ('HD196', '2019-5-14', '11:16', 'KH54', 'QTN5', 0),--1605500.0
 ('HD197', '2019-11-22', '19:23', 'KH95', 'QTN4', 0),--5441800.0
 ('HD198', '2019-4-2', '11:49', 'KH80', 'QTN5', 0),--3055600.0
 ('HD199', '2019-10-19', '21:30', 'KH71', 'QTN4', 0),--1182300.0
 ('HD200', '2019-4-8', '10:51', 'KH71', 'QTN3', 0)--5466000.0
--select * from hoadon

INSERT INTO CTHD VALUES('HD1','SP8',8,368000)
INSERT INTO CTHD VALUES('HD1','SP6',1,33900)
INSERT INTO CTHD VALUES('HD1','SP2',5,285000)
INSERT INTO CTHD VALUES('HD1','SP7',1,34900)
INSERT INTO CTHD VALUES('HD1','SP1',2,55600)
INSERT INTO CTHD VALUES('HD1','SP3',3,458400)
INSERT INTO CTHD VALUES('HD1','SP9',4,55600)
INSERT INTO CTHD VALUES('HD1','SP4',4,175600)
INSERT INTO CTHD VALUES('HD1','SP10',40,116000)

INSERT INTO CTHD VALUES ('HD2', 'SP81', 4, 123200.0)
INSERT INTO CTHD VALUES ('HD2', 'SP174', 10, 1399000.0)
INSERT INTO CTHD VALUES ('HD2', 'SP30', 10, 520000.0)
INSERT INTO CTHD VALUES ('HD2', 'SP58', 5, 147500.0)
INSERT INTO CTHD VALUES ('HD2', 'SP170', 10, 1159000.0)
INSERT INTO CTHD VALUES ('HD2', 'SP18', 8, 312000.0)

INSERT INTO CTHD VALUES ('HD3', 'SP84', 3, 126225.0)
INSERT INTO CTHD VALUES ('HD3', 'SP185', 8, 396000.0)
INSERT INTO CTHD VALUES ('HD3', 'SP92', 5, 132500.0)

INSERT INTO CTHD VALUES ('HD4', 'SP69', 8, 246400.0)
INSERT INTO CTHD VALUES ('HD4', 'SP180', 5, 717000.0)
INSERT INTO CTHD VALUES ('HD4', 'SP97', 2, 13000.0)

INSERT INTO CTHD VALUES ('HD5', 'SP104', 4, 115600.0)
INSERT INTO CTHD VALUES ('HD5', 'SP34', 2, 54000.0)

INSERT INTO CTHD VALUES ('HD6', 'SP67', 6, 60000.0)
INSERT INTO CTHD VALUES ('HD6', 'SP115', 5, 1021500.0)
INSERT INTO CTHD VALUES ('HD6', 'SP88', 9, 241200.0)
INSERT INTO CTHD VALUES ('HD6', 'SP177', 8, 428000.0)
INSERT INTO CTHD VALUES ('HD6', 'SP184', 5, 247500.0)
INSERT INTO CTHD VALUES ('HD6', 'SP130', 5, 1576000.0)

INSERT INTO CTHD VALUES ('HD7', 'SP139', 4, 40800.0)
INSERT INTO CTHD VALUES ('HD7', 'SP15', 8, 320000.0)
INSERT INTO CTHD VALUES ('HD7', 'SP98', 1, 6500.0)
INSERT INTO CTHD VALUES ('HD7', 'SP56', 2, 392400.0)
INSERT INTO CTHD VALUES ('HD8', 'SP152', 6, 621000.0)
INSERT INTO CTHD VALUES ('HD8', 'SP108', 1, 10200.0)
INSERT INTO CTHD VALUES ('HD8', 'SP114', 7, 2641800.0)
INSERT INTO CTHD VALUES ('HD9', 'SP66', 6, 120000.0)
INSERT INTO CTHD VALUES ('HD9', 'SP176', 6, 197400.0)
INSERT INTO CTHD VALUES ('HD9', 'SP70', 3, 92400.0)
INSERT INTO CTHD VALUES ('HD9', 'SP119', 8, 1875200.0)
INSERT INTO CTHD VALUES ('HD9', 'SP61', 4, 333600.0)
INSERT INTO CTHD VALUES ('HD10', 'SP83', 10, 289000.0)
INSERT INTO CTHD VALUES ('HD10', 'SP12', 3, 771000.0)
INSERT INTO CTHD VALUES ('HD11', 'SP187', 5, 157000.0)
INSERT INTO CTHD VALUES ('HD12', 'SP99', 9, 77400.0)
INSERT INTO CTHD VALUES ('HD12', 'SP33', 5, 135000.0)
INSERT INTO CTHD VALUES ('HD12', 'SP199', 5, 835000.0)
INSERT INTO CTHD VALUES ('HD13', 'SP128', 2, 468800.0)
INSERT INTO CTHD VALUES ('HD13', 'SP129', 6, 1891200.0)
INSERT INTO CTHD VALUES ('HD13', 'SP66', 9, 180000.0)
INSERT INTO CTHD VALUES ('HD13', 'SP83', 5, 144500.0)
INSERT INTO CTHD VALUES ('HD14', 'SP6', 4, 135600.0)
INSERT INTO CTHD VALUES ('HD14', 'SP72', 3, 121440.0)
INSERT INTO CTHD VALUES ('HD15', 'SP66', 1, 20000.0)
INSERT INTO CTHD VALUES ('HD15', 'SP131', 10, 3152000.0)
INSERT INTO CTHD VALUES ('HD15', 'SP92', 8, 212000.0)
INSERT INTO CTHD VALUES ('HD15', 'SP78', 1, 28900.0)
INSERT INTO CTHD VALUES ('HD15', 'SP16', 8, 25600.0)
INSERT INTO CTHD VALUES ('HD15', 'SP128', 9, 2109600.0)
INSERT INTO CTHD VALUES ('HD16', 'SP131', 3, 945600.0)
INSERT INTO CTHD VALUES ('HD16', 'SP86', 5, 134000.0)
INSERT INTO CTHD VALUES ('HD16', 'SP2', 2, 114000.0)
INSERT INTO CTHD VALUES ('HD17', 'SP94', 7, 114800.0)
INSERT INTO CTHD VALUES ('HD17', 'SP104', 8, 231200.0)
INSERT INTO CTHD VALUES ('HD18', 'SP23', 9, 702000.0)
INSERT INTO CTHD VALUES ('HD18', 'SP164', 5, 593500.0)
INSERT INTO CTHD VALUES ('HD19', 'SP176', 2, 65800.0)
INSERT INTO CTHD VALUES ('HD19', 'SP97', 7, 45500.0)
INSERT INTO CTHD VALUES ('HD19', 'SP133', 1, 355300.0)
INSERT INTO CTHD VALUES ('HD20', 'SP90', 4, 114400.0)
INSERT INTO CTHD VALUES ('HD20', 'SP137', 3, 1584000.0)
INSERT INTO CTHD VALUES ('HD20', 'SP51', 3, 60000.0)
INSERT INTO CTHD VALUES ('HD21', 'SP102', 7, 60200.0)
INSERT INTO CTHD VALUES ('HD22', 'SP28', 6, 953400.0)
INSERT INTO CTHD VALUES ('HD22', 'SP164', 5, 593500.0)
INSERT INTO CTHD VALUES ('HD23', 'SP74', 2, 61600.0)
INSERT INTO CTHD VALUES ('HD23', 'SP66', 3, 60000.0)
INSERT INTO CTHD VALUES ('HD23', 'SP182', 6, 771000.0)
INSERT INTO CTHD VALUES ('HD23', 'SP57', 9, 765000.0)
INSERT INTO CTHD VALUES ('HD23', 'SP3', 5, 764000.0)
INSERT INTO CTHD VALUES ('HD23', 'SP104', 2, 57800.0)
INSERT INTO CTHD VALUES ('HD24', 'SP77', 10, 308000.0)
INSERT INTO CTHD VALUES ('HD24', 'SP119', 9, 2109600.0)
INSERT INTO CTHD VALUES ('HD24', 'SP87', 1, 17100.0)
INSERT INTO CTHD VALUES ('HD24', 'SP144', 7, 370300.0)
INSERT INTO CTHD VALUES ('HD25', 'SP142', 2, 739200.0)
INSERT INTO CTHD VALUES ('HD25', 'SP114', 4, 1509600.0)
INSERT INTO CTHD VALUES ('HD25', 'SP15', 2, 80000.0)
INSERT INTO CTHD VALUES ('HD25', 'SP141', 5, 3191100.0)
INSERT INTO CTHD VALUES ('HD25', 'SP40', 8, 46400.0)
INSERT INTO CTHD VALUES ('HD25', 'SP108', 6, 61200.0)
INSERT INTO CTHD VALUES ('HD25', 'SP27', 4, 1292000.0)
INSERT INTO CTHD VALUES ('HD26', 'SP21', 2, 198000.0)
INSERT INTO CTHD VALUES ('HD26', 'SP48', 3, 506700.0)
INSERT INTO CTHD VALUES ('HD26', 'SP3', 3, 458400.0)
INSERT INTO CTHD VALUES ('HD26', 'SP53', 9, 590400.0)
INSERT INTO CTHD VALUES ('HD26', 'SP41', 6, 81000.0)
INSERT INTO CTHD VALUES ('HD27', 'SP13', 6, 540000.0)
INSERT INTO CTHD VALUES ('HD27', 'SP151', 7, 1115100.0)
INSERT INTO CTHD VALUES ('HD27', 'SP145', 6, 1891200.0)
INSERT INTO CTHD VALUES ('HD27', 'SP172', 1, 245900.0)
INSERT INTO CTHD VALUES ('HD28', 'SP70', 4, 123200.0)
INSERT INTO CTHD VALUES ('HD28', 'SP146', 7, 399000.0)
INSERT INTO CTHD VALUES ('HD28', 'SP7', 7, 244300.0)
INSERT INTO CTHD VALUES ('HD28', 'SP174', 6, 839400.0)
INSERT INTO CTHD VALUES ('HD29', 'SP167', 8, 673600.0)
INSERT INTO CTHD VALUES ('HD29', 'SP32', 5, 495000.0)
INSERT INTO CTHD VALUES ('HD29', 'SP47', 9, 121500.0)
INSERT INTO CTHD VALUES ('HD29', 'SP135', 10, 2471000.0)
INSERT INTO CTHD VALUES ('HD29', 'SP71', 10, 196000.0)
INSERT INTO CTHD VALUES ('HD29', 'SP69', 8, 246400.0)
INSERT INTO CTHD VALUES ('HD29', 'SP158', 1, 21500.0)
INSERT INTO CTHD VALUES ('HD30', 'SP33', 7, 189000.0)
INSERT INTO CTHD VALUES ('HD30', 'SP8', 5, 230000.0)
INSERT INTO CTHD VALUES ('HD30', 'SP10', 8, 23200.0)
INSERT INTO CTHD VALUES ('HD30', 'SP32', 9, 891000.0)
INSERT INTO CTHD VALUES ('HD30', 'SP1', 7, 194600.0)
INSERT INTO CTHD VALUES ('HD30', 'SP130', 9, 2836800.0)
INSERT INTO CTHD VALUES ('HD30', 'SP115', 7, 1430100.0)
INSERT INTO CTHD VALUES ('HD31', 'SP39', 9, 52200.0)
INSERT INTO CTHD VALUES ('HD31', 'SP4', 9, 395100.0)
INSERT INTO CTHD VALUES ('HD31', 'SP27', 10, 3230000.0)
INSERT INTO CTHD VALUES ('HD31', 'SP81', 7, 215600.0)
INSERT INTO CTHD VALUES ('HD31', 'SP132', 7, 2206400.0)
INSERT INTO CTHD VALUES ('HD31', 'SP88', 9, 241200.0)
INSERT INTO CTHD VALUES ('HD32', 'SP74', 6, 184800.0)
INSERT INTO CTHD VALUES ('HD32', 'SP60', 6, 60000.0)
INSERT INTO CTHD VALUES ('HD32', 'SP128', 2, 468800.0)
INSERT INTO CTHD VALUES ('HD32', 'SP164', 10, 1187000.0)
INSERT INTO CTHD VALUES ('HD32', 'SP109', 10, 102000.0)
INSERT INTO CTHD VALUES ('HD32', 'SP190', 7, 312200.0)
INSERT INTO CTHD VALUES ('HD33', 'SP96', 2, 13000.0)
INSERT INTO CTHD VALUES ('HD33', 'SP42', 9, 63000.0)
INSERT INTO CTHD VALUES ('HD33', 'SP90', 6, 171600.0)
INSERT INTO CTHD VALUES ('HD33', 'SP131', 8, 2521600.0)
INSERT INTO CTHD VALUES ('HD33', 'SP20', 6, 788400.0)
INSERT INTO CTHD VALUES ('HD33', 'SP123', 4, 107200.0)
INSERT INTO CTHD VALUES ('HD34', 'SP166', 9, 1068300.0)
INSERT INTO CTHD VALUES ('HD34', 'SP87', 8, 136800.0)
INSERT INTO CTHD VALUES ('HD34', 'SP130', 8, 2521600.0)
INSERT INTO CTHD VALUES ('HD34', 'SP161', 2, 237400.0)
INSERT INTO CTHD VALUES ('HD34', 'SP49', 10, 780000.0)
INSERT INTO CTHD VALUES ('HD34', 'SP189', 10, 729000.0)
INSERT INTO CTHD VALUES ('HD34', 'SP145', 7, 2206400.0)
INSERT INTO CTHD VALUES ('HD35', 'SP121', 3, 88800.0)
INSERT INTO CTHD VALUES ('HD35', 'SP192', 2, 139800.0)
INSERT INTO CTHD VALUES ('HD35', 'SP49', 4, 312000.0)
INSERT INTO CTHD VALUES ('HD36', 'SP168', 10, 842000.0)
INSERT INTO CTHD VALUES ('HD36', 'SP192', 6, 419400.0)
INSERT INTO CTHD VALUES ('HD36', 'SP165', 8, 949600.0)
INSERT INTO CTHD VALUES ('HD36', 'SP175', 6, 537600.0)
INSERT INTO CTHD VALUES ('HD37', 'SP87', 2, 34200.0)
INSERT INTO CTHD VALUES ('HD37', 'SP47', 9, 121500.0)
INSERT INTO CTHD VALUES ('HD37', 'SP32', 10, 990000.0)
INSERT INTO CTHD VALUES ('HD37', 'SP193', 2, 139800.0)
INSERT INTO CTHD VALUES ('HD37', 'SP173', 4, 513200.0)
INSERT INTO CTHD VALUES ('HD38', 'SP124', 7, 2587200.0)
INSERT INTO CTHD VALUES ('HD39', 'SP64', 2, 311000.0)
INSERT INTO CTHD VALUES ('HD39', 'SP78', 4, 115600.0)
INSERT INTO CTHD VALUES ('HD39', 'SP157', 4, 779600.0)
INSERT INTO CTHD VALUES ('HD39', 'SP39', 9, 52200.0)
INSERT INTO CTHD VALUES ('HD39', 'SP23', 10, 780000.0)
INSERT INTO CTHD VALUES ('HD40', 'SP178', 7, 453600.0)
INSERT INTO CTHD VALUES ('HD40', 'SP15', 7, 280000.0)
INSERT INTO CTHD VALUES ('HD40', 'SP18', 8, 312000.0)
INSERT INTO CTHD VALUES ('HD40', 'SP98', 5, 32500.0)
INSERT INTO CTHD VALUES ('HD40', 'SP135', 9, 2223900.0)
INSERT INTO CTHD VALUES ('HD41', 'SP177', 8, 428000.0)
INSERT INTO CTHD VALUES ('HD41', 'SP100', 4, 142800.0)
INSERT INTO CTHD VALUES ('HD41', 'SP187', 9, 282600.0)
INSERT INTO CTHD VALUES ('HD41', 'SP149', 10, 115000.0)
INSERT INTO CTHD VALUES ('HD42', 'SP131', 9, 2836800.0)
INSERT INTO CTHD VALUES ('HD43', 'SP166', 6, 712200.0)
INSERT INTO CTHD VALUES ('HD43', 'SP130', 6, 1891200.0)
INSERT INTO CTHD VALUES ('HD43', 'SP177', 1, 53500.0)
INSERT INTO CTHD VALUES ('HD43', 'SP74', 7, 215600.0)
INSERT INTO CTHD VALUES ('HD43', 'SP167', 4, 336800.0)
INSERT INTO CTHD VALUES ('HD44', 'SP185', 1, 49500.0)
INSERT INTO CTHD VALUES ('HD44', 'SP106', 7, 187600.0)
INSERT INTO CTHD VALUES ('HD44', 'SP169', 1, 115900.0)
INSERT INTO CTHD VALUES ('HD44', 'SP20', 1, 131400.0)
INSERT INTO CTHD VALUES ('HD44', 'SP98', 7, 45500.0)
INSERT INTO CTHD VALUES ('HD44', 'SP19', 1, 34800.0)
INSERT INTO CTHD VALUES ('HD45', 'SP176', 2, 65800.0)
INSERT INTO CTHD VALUES ('HD46', 'SP153', 9, 1223100.0)
INSERT INTO CTHD VALUES ('HD46', 'SP102', 4, 34400.0)
INSERT INTO CTHD VALUES ('HD46', 'SP3', 6, 916800.0)
INSERT INTO CTHD VALUES ('HD46', 'SP93', 6, 100800.0)
INSERT INTO CTHD VALUES ('HD46', 'SP187', 3, 94200.0)
INSERT INTO CTHD VALUES ('HD46', 'SP75', 6, 173400.0)
INSERT INTO CTHD VALUES ('HD46', 'SP115', 8, 1634400.0)
INSERT INTO CTHD VALUES ('HD47', 'SP51', 7, 140000.0)
INSERT INTO CTHD VALUES ('HD47', 'SP123', 2, 53600.0)
INSERT INTO CTHD VALUES ('HD47', 'SP29', 5, 29000.0)
INSERT INTO CTHD VALUES ('HD47', 'SP7', 10, 349000.0)
INSERT INTO CTHD VALUES ('HD47', 'SP179', 2, 236000.0)
INSERT INTO CTHD VALUES ('HD47', 'SP183', 8, 238400.0)
INSERT INTO CTHD VALUES ('HD48', 'SP13', 6, 540000.0)
INSERT INTO CTHD VALUES ('HD49', 'SP101', 6, 214200.0)
INSERT INTO CTHD VALUES ('HD49', 'SP30', 6, 312000.0)
INSERT INTO CTHD VALUES ('HD49', 'SP178', 6, 388800.0)
INSERT INTO CTHD VALUES ('HD49', 'SP50', 5, 121500.0)
INSERT INTO CTHD VALUES ('HD49', 'SP36', 7, 115500.0)
INSERT INTO CTHD VALUES ('HD50', 'SP67', 7, 70000.0)
INSERT INTO CTHD VALUES ('HD50', 'SP156', 4, 701600.0)
INSERT INTO CTHD VALUES ('HD50', 'SP96', 3, 19500.0)
INSERT INTO CTHD VALUES ('HD50', 'SP14', 7, 46200.0)

INSERT INTO CTHD VALUES ('HD51', 'SP157', 9, 1754100.0)
INSERT INTO CTHD VALUES ('HD51', 'SP42', 6, 42000.0)
INSERT INTO CTHD VALUES ('HD51', 'SP192', 2, 139800.0)
INSERT INTO CTHD VALUES ('HD51', 'SP23', 6, 468000.0)
INSERT INTO CTHD VALUES ('HD51', 'SP199', 4, 668000.0)
INSERT INTO CTHD VALUES ('HD51', 'SP124', 1, 369600.0)
INSERT INTO CTHD VALUES ('HD51', 'SP9', 1, 13900.0)
INSERT INTO CTHD VALUES ('HD52', 'SP71', 1, 19600.0)
INSERT INTO CTHD VALUES ('HD52', 'SP31', 3, 137400.0)
INSERT INTO CTHD VALUES ('HD52', 'SP101', 5, 178500.0)
INSERT INTO CTHD VALUES ('HD53', 'SP42', 6, 42000.0)
INSERT INTO CTHD VALUES ('HD54', 'SP28', 8, 1271200.0)
INSERT INTO CTHD VALUES ('HD55', 'SP99', 9, 77400.0)
INSERT INTO CTHD VALUES ('HD55', 'SP168', 10, 842000.0)
INSERT INTO CTHD VALUES ('HD55', 'SP186', 3, 206700.0)
INSERT INTO CTHD VALUES ('HD56', 'SP52', 1, 39000.0)
INSERT INTO CTHD VALUES ('HD57', 'SP54', 6, 229200.0)
INSERT INTO CTHD VALUES ('HD57', 'SP50', 1, 24300.0)
INSERT INTO CTHD VALUES ('HD57', 'SP157', 1, 194900.0)
INSERT INTO CTHD VALUES ('HD57', 'SP166', 4, 474800.0)
INSERT INTO CTHD VALUES ('HD57', 'SP151', 9, 1433700.0)
INSERT INTO CTHD VALUES ('HD58', 'SP56', 8, 1569600.0)
INSERT INTO CTHD VALUES ('HD59', 'SP119', 5, 1172000.0)
INSERT INTO CTHD VALUES ('HD59', 'SP6', 6, 203400.0)
INSERT INTO CTHD VALUES ('HD59', 'SP139', 6, 61200.0)
INSERT INTO CTHD VALUES ('HD59', 'SP17', 7, 385000.0)
INSERT INTO CTHD VALUES ('HD60', 'SP197', 1, 150000.0)
INSERT INTO CTHD VALUES ('HD60', 'SP70', 6, 184800.0)
INSERT INTO CTHD VALUES ('HD60', 'SP31', 6, 274800.0)
INSERT INTO CTHD VALUES ('HD60', 'SP111', 10, 532000.0)
INSERT INTO CTHD VALUES ('HD61', 'SP34', 9, 243000.0)
INSERT INTO CTHD VALUES ('HD61', 'SP161', 1, 118700.0)
INSERT INTO CTHD VALUES ('HD61', 'SP65', 5, 200000.0)
INSERT INTO CTHD VALUES ('HD62', 'SP109', 7, 71400.0)
INSERT INTO CTHD VALUES ('HD62', 'SP56', 5, 981000.0)
INSERT INTO CTHD VALUES ('HD62', 'SP158', 10, 215000.0)
INSERT INTO CTHD VALUES ('HD62', 'SP52', 4, 156000.0)
INSERT INTO CTHD VALUES ('HD63', 'SP145', 6, 1891200.0)
INSERT INTO CTHD VALUES ('HD64', 'SP189', 5, 364500.0)
INSERT INTO CTHD VALUES ('HD64', 'SP112', 5, 85500.0)
INSERT INTO CTHD VALUES ('HD64', 'SP20', 1, 131400.0)
INSERT INTO CTHD VALUES ('HD65', 'SP64', 2, 311000.0)
INSERT INTO CTHD VALUES ('HD65', 'SP68', 2, 61600.0)
INSERT INTO CTHD VALUES ('HD65', 'SP55', 8, 323200.0)
INSERT INTO CTHD VALUES ('HD65', 'SP182', 3, 385500.0)
INSERT INTO CTHD VALUES ('HD65', 'SP25', 3, 66000.0)
INSERT INTO CTHD VALUES ('HD65', 'SP73', 10, 489300.0)
INSERT INTO CTHD VALUES ('HD65', 'SP7', 10, 349000.0)
INSERT INTO CTHD VALUES ('HD66', 'SP172', 2, 491800.0)
INSERT INTO CTHD VALUES ('HD66', 'SP99', 9, 77400.0)
INSERT INTO CTHD VALUES ('HD66', 'SP90', 10, 286000.0)
INSERT INTO CTHD VALUES ('HD66', 'SP177', 10, 535000.0)
INSERT INTO CTHD VALUES ('HD66', 'SP97', 2, 13000.0)
INSERT INTO CTHD VALUES ('HD67', 'SP121', 10, 296000.0)
INSERT INTO CTHD VALUES ('HD67', 'SP23', 5, 390000.0)
INSERT INTO CTHD VALUES ('HD67', 'SP76', 4, 78000.0)
INSERT INTO CTHD VALUES ('HD68', 'SP10', 3, 8700.0)
INSERT INTO CTHD VALUES ('HD68', 'SP99', 2, 17200.0)
INSERT INTO CTHD VALUES ('HD68', 'SP197', 5, 750000.0)
INSERT INTO CTHD VALUES ('HD68', 'SP93', 10, 168000.0)
INSERT INTO CTHD VALUES ('HD68', 'SP43', 3, 200100.0)
INSERT INTO CTHD VALUES ('HD68', 'SP53', 10, 656000.0)
INSERT INTO CTHD VALUES ('HD68', 'SP127', 10, 3696000.0)
INSERT INTO CTHD VALUES ('HD69', 'SP10', 8, 23200.0)
INSERT INTO CTHD VALUES ('HD69', 'SP6', 8, 271200.0)
INSERT INTO CTHD VALUES ('HD69', 'SP65', 2, 80000.0)
INSERT INTO CTHD VALUES ('HD69', 'SP162', 5, 534500.0)
INSERT INTO CTHD VALUES ('HD69', 'SP156', 10, 1754000.0)
INSERT INTO CTHD VALUES ('HD70', 'SP44', 8, 88800.0)
INSERT INTO CTHD VALUES ('HD70', 'SP48', 1, 168900.0)
INSERT INTO CTHD VALUES ('HD70', 'SP81', 1, 30800.0)
INSERT INTO CTHD VALUES ('HD70', 'SP82', 6, 117600.0)
INSERT INTO CTHD VALUES ('HD70', 'SP31', 3, 137400.0)
INSERT INTO CTHD VALUES ('HD71', 'SP26', 10, 470000.0)
INSERT INTO CTHD VALUES ('HD71', 'SP61', 7, 583800.0)
INSERT INTO CTHD VALUES ('HD72', 'SP166', 5, 593500.0)
INSERT INTO CTHD VALUES ('HD72', 'SP61', 4, 333600.0)
INSERT INTO CTHD VALUES ('HD73', 'SP67', 1, 10000.0)
INSERT INTO CTHD VALUES ('HD73', 'SP121', 3, 88800.0)
INSERT INTO CTHD VALUES ('HD73', 'SP147', 9, 796500.0)
INSERT INTO CTHD VALUES ('HD73', 'SP108', 1, 10200.0)
INSERT INTO CTHD VALUES ('HD73', 'SP186', 3, 206700.0)
INSERT INTO CTHD VALUES ('HD73', 'SP158', 1, 21500.0)
INSERT INTO CTHD VALUES ('HD74', 'SP150', 7, 300300.0)
INSERT INTO CTHD VALUES ('HD74', 'SP155', 6, 655200.0)
INSERT INTO CTHD VALUES ('HD74', 'SP140', 4, 988400.0)
INSERT INTO CTHD VALUES ('HD75', 'SP34', 9, 243000.0)
INSERT INTO CTHD VALUES ('HD75', 'SP77', 1, 30800.0)
INSERT INTO CTHD VALUES ('HD75', 'SP158', 2, 43000.0)
INSERT INTO CTHD VALUES ('HD75', 'SP82', 3, 58800.0)
INSERT INTO CTHD VALUES ('HD75', 'SP127', 9, 3326400.0)
INSERT INTO CTHD VALUES ('HD76', 'SP182', 6, 771000.0)
INSERT INTO CTHD VALUES ('HD76', 'SP125', 3, 1108800.0)
INSERT INTO CTHD VALUES ('HD76', 'SP131', 1, 315200.0)
INSERT INTO CTHD VALUES ('HD76', 'SP21', 2, 198000.0)
INSERT INTO CTHD VALUES ('HD76', 'SP186', 10, 689000.0)
INSERT INTO CTHD VALUES ('HD76', 'SP147', 7, 619500.0)
INSERT INTO CTHD VALUES ('HD77', 'SP196', 7, 489300.0)
INSERT INTO CTHD VALUES ('HD77', 'SP169', 4, 463600.0)
INSERT INTO CTHD VALUES ('HD78', 'SP5', 8, 111200.0)
INSERT INTO CTHD VALUES ('HD78', 'SP22', 5, 460000.0)
INSERT INTO CTHD VALUES ('HD78', 'SP79', 7, 215600.0)
INSERT INTO CTHD VALUES ('HD78', 'SP25', 7, 154000.0)
INSERT INTO CTHD VALUES ('HD78', 'SP42', 1, 7000.0)
INSERT INTO CTHD VALUES ('HD78', 'SP90', 2, 57200.0)
INSERT INTO CTHD VALUES ('HD78', 'SP155', 8, 873600.0)
INSERT INTO CTHD VALUES ('HD79', 'SP23', 3, 234000.0)
INSERT INTO CTHD VALUES ('HD79', 'SP27', 1, 323000.0)
INSERT INTO CTHD VALUES ('HD79', 'SP9', 5, 69500.0)
INSERT INTO CTHD VALUES ('HD79', 'SP15', 10, 400000.0)
INSERT INTO CTHD VALUES ('HD80', 'SP63', 9, 1367100.0)
INSERT INTO CTHD VALUES ('HD81', 'SP193', 10, 699000.0)
INSERT INTO CTHD VALUES ('HD81', 'SP94', 3, 49200.0)
INSERT INTO CTHD VALUES ('HD81', 'SP148', 1, 34800.0)
INSERT INTO CTHD VALUES ('HD81', 'SP34', 2, 54000.0)
INSERT INTO CTHD VALUES ('HD81', 'SP126', 8, 2956800.0)
INSERT INTO CTHD VALUES ('HD81', 'SP20', 5, 657000.0)
INSERT INTO CTHD VALUES ('HD81', 'SP176', 4, 131600.0)
INSERT INTO CTHD VALUES ('HD82', 'SP72', 9, 364320.0)
INSERT INTO CTHD VALUES ('HD82', 'SP76', 9, 175500.0)
INSERT INTO CTHD VALUES ('HD82', 'SP180', 7, 1003800.0)
INSERT INTO CTHD VALUES ('HD82', 'SP168', 7, 589400.0)
INSERT INTO CTHD VALUES ('HD83', 'SP33', 9, 243000.0)
INSERT INTO CTHD VALUES ('HD84', 'SP108', 2, 20400.0)
INSERT INTO CTHD VALUES ('HD85', 'SP126', 7, 2587200.0)
INSERT INTO CTHD VALUES ('HD85', 'SP57', 5, 425000.0)
INSERT INTO CTHD VALUES ('HD86', 'SP78', 1, 28900.0)
INSERT INTO CTHD VALUES ('HD86', 'SP102', 1, 8600.0)
INSERT INTO CTHD VALUES ('HD86', 'SP119', 3, 703200.0)
INSERT INTO CTHD VALUES ('HD87', 'SP69', 3, 92400.0)
INSERT INTO CTHD VALUES ('HD87', 'SP177', 3, 160500.0)
INSERT INTO CTHD VALUES ('HD87', 'SP99', 9, 77400.0)
INSERT INTO CTHD VALUES ('HD88', 'SP119', 8, 1875200.0)
INSERT INTO CTHD VALUES ('HD88', 'SP17', 4, 220000.0)
INSERT INTO CTHD VALUES ('HD88', 'SP69', 7, 215600.0)
INSERT INTO CTHD VALUES ('HD88', 'SP173', 1, 128300.0)
INSERT INTO CTHD VALUES ('HD88', 'SP81', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD89', 'SP10', 6, 17400.0)
INSERT INTO CTHD VALUES ('HD89', 'SP138', 7, 1127280.0)
INSERT INTO CTHD VALUES ('HD89', 'SP63', 6, 911400.0)
INSERT INTO CTHD VALUES ('HD90', 'SP15', 5, 200000.0)
INSERT INTO CTHD VALUES ('HD90', 'SP124', 4, 1478400.0)
INSERT INTO CTHD VALUES ('HD90', 'SP7', 3, 104700.0)
INSERT INTO CTHD VALUES ('HD90', 'SP41', 8, 108000.0)
INSERT INTO CTHD VALUES ('HD90', 'SP125', 8, 2956800.0)
INSERT INTO CTHD VALUES ('HD90', 'SP152', 9, 931500.0)
INSERT INTO CTHD VALUES ('HD90', 'SP29', 8, 46400.0)
INSERT INTO CTHD VALUES ('HD91', 'SP16', 4, 12800.0)
INSERT INTO CTHD VALUES ('HD91', 'SP88', 8, 214400.0)
INSERT INTO CTHD VALUES ('HD91', 'SP58', 7, 206500.0)
INSERT INTO CTHD VALUES ('HD91', 'SP12', 1, 257000.0)
INSERT INTO CTHD VALUES ('HD91', 'SP136', 2, 494200.0)
INSERT INTO CTHD VALUES ('HD91', 'SP44', 3, 33300.0)
INSERT INTO CTHD VALUES ('HD92', 'SP12', 2, 514000.0)
INSERT INTO CTHD VALUES ('HD92', 'SP76', 6, 117000.0)
INSERT INTO CTHD VALUES ('HD92', 'SP49', 9, 702000.0)
INSERT INTO CTHD VALUES ('HD92', 'SP94', 1, 16400.0)
INSERT INTO CTHD VALUES ('HD92', 'SP188', 10, 314000.0)
INSERT INTO CTHD VALUES ('HD92', 'SP84', 6, 252450.0)
INSERT INTO CTHD VALUES ('HD93', 'SP12', 6, 1542000.0)
INSERT INTO CTHD VALUES ('HD93', 'SP114', 9, 3396600.0)
INSERT INTO CTHD VALUES ('HD93', 'SP161', 8, 949600.0)
INSERT INTO CTHD VALUES ('HD93', 'SP125', 7, 2587200.0)
INSERT INTO CTHD VALUES ('HD94', 'SP52', 9, 351000.0)
INSERT INTO CTHD VALUES ('HD94', 'SP146', 6, 342000.0)
INSERT INTO CTHD VALUES ('HD94', 'SP192', 9, 629100.0)
INSERT INTO CTHD VALUES ('HD94', 'SP56', 8, 1569600.0)
INSERT INTO CTHD VALUES ('HD94', 'SP79', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD95', 'SP198', 9, 1215000.0)
INSERT INTO CTHD VALUES ('HD96', 'SP102', 10, 86000.0)
INSERT INTO CTHD VALUES ('HD96', 'SP139', 2, 20400.0)
INSERT INTO CTHD VALUES ('HD96', 'SP3', 3, 458400.0)
INSERT INTO CTHD VALUES ('HD97', 'SP66', 5, 100000.0)
INSERT INTO CTHD VALUES ('HD97', 'SP10', 6, 17400.0)

INSERT INTO CTHD VALUES ('HD98', 'SP118', 6, 1932480.0)
INSERT INTO CTHD VALUES ('HD98', 'SP133', 9, 3197700.0)
INSERT INTO CTHD VALUES ('HD98', 'SP97', 2, 13000.0)
INSERT INTO CTHD VALUES ('HD98', 'SP161', 3, 356100.0)
INSERT INTO CTHD VALUES ('HD98', 'SP115', 10, 2043000.0)
INSERT INTO CTHD VALUES ('HD98', 'SP67', 4, 40000.0)

INSERT INTO CTHD VALUES ('HD99', 'SP155', 8, 873600.0)
INSERT INTO CTHD VALUES ('HD99', 'SP171', 6, 1247400.0)
INSERT INTO CTHD VALUES ('HD99', 'SP32', 8, 792000.0)
INSERT INTO CTHD VALUES ('HD100', 'SP91', 6, 182400.0)
INSERT INTO CTHD VALUES ('HD100', 'SP160', 6, 641400.0)
INSERT INTO CTHD VALUES ('HD100', 'SP150', 5, 214500.0)
INSERT INTO CTHD VALUES ('HD100', 'SP42', 7, 49000.0)
INSERT INTO CTHD VALUES ('HD100', 'SP65', 2, 80000.0)
INSERT INTO CTHD VALUES ('HD100', 'SP168', 4, 336800.0)

INSERT INTO CTHD VALUES ('HD101', 'SP30', 9, 468000.0)
INSERT INTO CTHD VALUES ('HD101', 'SP82', 6, 117600.0)
INSERT INTO CTHD VALUES ('HD101', 'SP104', 2, 57800.0)
INSERT INTO CTHD VALUES ('HD102', 'SP67', 7, 70000.0)
INSERT INTO CTHD VALUES ('HD102', 'SP167', 2, 168400.0)
INSERT INTO CTHD VALUES ('HD102', 'SP193', 4, 279600.0)
INSERT INTO CTHD VALUES ('HD103', 'SP112', 3, 51300.0)
INSERT INTO CTHD VALUES ('HD103', 'SP17', 6, 330000.0)
INSERT INTO CTHD VALUES ('HD103', 'SP146', 5, 285000.0)
INSERT INTO CTHD VALUES ('HD103', 'SP64', 10, 1555000.0)
INSERT INTO CTHD VALUES ('HD103', 'SP67', 9, 90000.0)
INSERT INTO CTHD VALUES ('HD103', 'SP53', 9, 590400.0)
INSERT INTO CTHD VALUES ('HD103', 'SP73', 9, 440370.0)
INSERT INTO CTHD VALUES ('HD104', 'SP110', 4, 118400.0)
INSERT INTO CTHD VALUES ('HD104', 'SP73', 7, 342510.0)
INSERT INTO CTHD VALUES ('HD104', 'SP46', 10, 854000.0)
INSERT INTO CTHD VALUES ('HD104', 'SP105', 7, 45500.0)
INSERT INTO CTHD VALUES ('HD104', 'SP134', 7, 2487100.0)
INSERT INTO CTHD VALUES ('HD105', 'SP164', 6, 712200.0)
INSERT INTO CTHD VALUES ('HD105', 'SP24', 4, 92000.0)
INSERT INTO CTHD VALUES ('HD105', 'SP187', 5, 157000.0)
INSERT INTO CTHD VALUES ('HD105', 'SP106', 6, 160800.0)
INSERT INTO CTHD VALUES ('HD106', 'SP77', 3, 92400.0)
INSERT INTO CTHD VALUES ('HD106', 'SP27', 10, 3230000.0)
INSERT INTO CTHD VALUES ('HD106', 'SP133', 8, 2842400.0)
INSERT INTO CTHD VALUES ('HD106', 'SP93', 4, 67200.0)
INSERT INTO CTHD VALUES ('HD106', 'SP34', 5, 135000.0)
INSERT INTO CTHD VALUES ('HD107', 'SP24', 7, 161000.0)
INSERT INTO CTHD VALUES ('HD107', 'SP99', 9, 77400.0)
INSERT INTO CTHD VALUES ('HD107', 'SP49', 6, 468000.0)
INSERT INTO CTHD VALUES ('HD107', 'SP60', 5, 50000.0)
INSERT INTO CTHD VALUES ('HD107', 'SP116', 5, 1887000.0)
INSERT INTO CTHD VALUES ('HD108', 'SP102', 3, 25800.0)
INSERT INTO CTHD VALUES ('HD109', 'SP29', 4, 23200.0)
INSERT INTO CTHD VALUES ('HD109', 'SP126', 5, 1848000.0)
INSERT INTO CTHD VALUES ('HD109', 'SP197', 9, 1350000.0)
INSERT INTO CTHD VALUES ('HD109', 'SP129', 6, 1891200.0)
INSERT INTO CTHD VALUES ('HD109', 'SP49', 2, 156000.0)
INSERT INTO CTHD VALUES ('HD110', 'SP121', 7, 207200.0)
INSERT INTO CTHD VALUES ('HD110', 'SP87', 8, 136800.0)
INSERT INTO CTHD VALUES ('HD111', 'SP107', 4, 1509600.0)
INSERT INTO CTHD VALUES ('HD111', 'SP76', 4, 78000.0)
INSERT INTO CTHD VALUES ('HD111', 'SP36', 1, 16500.0)
INSERT INTO CTHD VALUES ('HD111', 'SP120', 9, 2898720.0)
INSERT INTO CTHD VALUES ('HD111', 'SP23', 2, 156000.0)
INSERT INTO CTHD VALUES ('HD111', 'SP19', 5, 174000.0)
INSERT INTO CTHD VALUES ('HD112', 'SP45', 5, 200000.0)
INSERT INTO CTHD VALUES ('HD112', 'SP85', 8, 136800.0)
INSERT INTO CTHD VALUES ('HD112', 'SP134', 10, 3553000.0)
INSERT INTO CTHD VALUES ('HD113', 'SP123', 7, 187600.0)
INSERT INTO CTHD VALUES ('HD113', 'SP99', 1, 8600.0)
INSERT INTO CTHD VALUES ('HD113', 'SP14', 5, 33000.0)
INSERT INTO CTHD VALUES ('HD113', 'SP125', 6, 2217600.0)
INSERT INTO CTHD VALUES ('HD113', 'SP178', 2, 129600.0)
INSERT INTO CTHD VALUES ('HD113', 'SP159', 1, 53900.0)
INSERT INTO CTHD VALUES ('HD113', 'SP172', 5, 1229500.0)
INSERT INTO CTHD VALUES ('HD114', 'SP89', 7, 187600.0)
INSERT INTO CTHD VALUES ('HD114', 'SP63', 7, 1063300.0)
INSERT INTO CTHD VALUES ('HD114', 'SP194', 10, 699000.0)
INSERT INTO CTHD VALUES ('HD115', 'SP7', 8, 279200.0)
INSERT INTO CTHD VALUES ('HD115', 'SP173', 8, 1026400.0)
INSERT INTO CTHD VALUES ('HD115', 'SP2', 9, 513000.0)
INSERT INTO CTHD VALUES ('HD115', 'SP62', 10, 1168000.0)
INSERT INTO CTHD VALUES ('HD115', 'SP70', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD115', 'SP72', 8, 323840.0)
INSERT INTO CTHD VALUES ('HD116', 'SP153', 3, 407700.0)
INSERT INTO CTHD VALUES ('HD116', 'SP169', 3, 347700.0)
INSERT INTO CTHD VALUES ('HD117', 'SP113', 1, 17100.0)
INSERT INTO CTHD VALUES ('HD117', 'SP168', 4, 336800.0)
INSERT INTO CTHD VALUES ('HD117', 'SP54', 3, 114600.0)
INSERT INTO CTHD VALUES ('HD117', 'SP100', 6, 214200.0)
INSERT INTO CTHD VALUES ('HD117', 'SP188', 4, 125600.0)
INSERT INTO CTHD VALUES ('HD117', 'SP67', 2, 20000.0)
INSERT INTO CTHD VALUES ('HD117', 'SP139', 1, 10200.0)
INSERT INTO CTHD VALUES ('HD118', 'SP35', 2, 29800.0)
INSERT INTO CTHD VALUES ('HD118', 'SP176', 2, 65800.0)
INSERT INTO CTHD VALUES ('HD118', 'SP7', 2, 69800.0)
INSERT INTO CTHD VALUES ('HD118', 'SP189', 10, 729000.0)
INSERT INTO CTHD VALUES ('HD118', 'SP193', 5, 349500.0)
INSERT INTO CTHD VALUES ('HD119', 'SP15', 10, 400000.0)
INSERT INTO CTHD VALUES ('HD119', 'SP145', 4, 1260800.0)
INSERT INTO CTHD VALUES ('HD119', 'SP125', 1, 369600.0)
INSERT INTO CTHD VALUES ('HD120', 'SP147', 1, 88500.0)
INSERT INTO CTHD VALUES ('HD120', 'SP13', 10, 900000.0)
INSERT INTO CTHD VALUES ('HD120', 'SP135', 5, 1235500.0)
INSERT INTO CTHD VALUES ('HD120', 'SP87', 5, 85500.0)
INSERT INTO CTHD VALUES ('HD120', 'SP81', 8, 246400.0)
INSERT INTO CTHD VALUES ('HD121', 'SP13', 1, 90000.0)
INSERT INTO CTHD VALUES ('HD121', 'SP58', 2, 59000.0)
INSERT INTO CTHD VALUES ('HD121', 'SP46', 10, 854000.0)
INSERT INTO CTHD VALUES ('HD121', 'SP44', 5, 55500.0)
INSERT INTO CTHD VALUES ('HD121', 'SP36', 7, 115500.0)
INSERT INTO CTHD VALUES ('HD121', 'SP148', 1, 34800.0)
INSERT INTO CTHD VALUES ('HD121', 'SP79', 4, 123200.0)
INSERT INTO CTHD VALUES ('HD122', 'SP109', 5, 51000.0)
INSERT INTO CTHD VALUES ('HD122', 'SP50', 4, 97200.0)
INSERT INTO CTHD VALUES ('HD122', 'SP13', 2, 180000.0)
INSERT INTO CTHD VALUES ('HD123', 'SP77', 8, 246400.0)
INSERT INTO CTHD VALUES ('HD123', 'SP119', 3, 703200.0)
INSERT INTO CTHD VALUES ('HD123', 'SP151', 9, 1433700.0)
INSERT INTO CTHD VALUES ('HD123', 'SP90', 8, 228800.0)
INSERT INTO CTHD VALUES ('HD123', 'SP187', 9, 282600.0)
INSERT INTO CTHD VALUES ('HD123', 'SP189', 1, 72900.0)
INSERT INTO CTHD VALUES ('HD123', 'SP39', 3, 17400.0)
INSERT INTO CTHD VALUES ('HD124', 'SP11', 1, 32500.0)
INSERT INTO CTHD VALUES ('HD124', 'SP163', 7, 830900.0)
INSERT INTO CTHD VALUES ('HD125', 'SP160', 2, 213800.0)
INSERT INTO CTHD VALUES ('HD126', 'SP57', 8, 680000.0)
INSERT INTO CTHD VALUES ('HD126', 'SP103', 2, 49200.0)
INSERT INTO CTHD VALUES ('HD126', 'SP63', 7, 1063300.0)
INSERT INTO CTHD VALUES ('HD126', 'SP80', 5, 97500.0)
INSERT INTO CTHD VALUES ('HD126', 'SP172', 1, 245900.0)
INSERT INTO CTHD VALUES ('HD127', 'SP10', 4, 11600.0)
INSERT INTO CTHD VALUES ('HD127', 'SP73', 1, 48930.0)
INSERT INTO CTHD VALUES ('HD127', 'SP176', 2, 65800.0)
INSERT INTO CTHD VALUES ('HD127', 'SP95', 10, 65000.0)
INSERT INTO CTHD VALUES ('HD127', 'SP35', 1, 14900.0)
INSERT INTO CTHD VALUES ('HD127', 'SP88', 5, 134000.0)
INSERT INTO CTHD VALUES ('HD128', 'SP115', 3, 612900.0)
INSERT INTO CTHD VALUES ('HD128', 'SP32', 8, 792000.0)
INSERT INTO CTHD VALUES ('HD128', 'SP3', 7, 1069600.0)
INSERT INTO CTHD VALUES ('HD128', 'SP136', 3, 741300.0)
INSERT INTO CTHD VALUES ('HD128', 'SP27', 8, 2584000.0)
INSERT INTO CTHD VALUES ('HD129', 'SP28', 5, 794500.0)
INSERT INTO CTHD VALUES ('HD129', 'SP111', 6, 319200.0)
INSERT INTO CTHD VALUES ('HD129', 'SP177', 4, 214000.0)
INSERT INTO CTHD VALUES ('HD129', 'SP99', 1, 8600.0)
INSERT INTO CTHD VALUES ('HD129', 'SP117', 9, 53100.0)
INSERT INTO CTHD VALUES ('HD129', 'SP66', 7, 140000.0)
INSERT INTO CTHD VALUES ('HD129', 'SP53', 1, 65600.0)
INSERT INTO CTHD VALUES ('HD130', 'SP157', 8, 1559200.0)
INSERT INTO CTHD VALUES ('HD130', 'SP139', 9, 91800.0)
INSERT INTO CTHD VALUES ('HD130', 'SP168', 5, 421000.0)
INSERT INTO CTHD VALUES ('HD130', 'SP97', 3, 19500.0)
INSERT INTO CTHD VALUES ('HD131', 'SP161', 9, 1068300.0)
INSERT INTO CTHD VALUES ('HD132', 'SP37', 4, 40400.0)
INSERT INTO CTHD VALUES ('HD132', 'SP20', 8, 1051200.0)
INSERT INTO CTHD VALUES ('HD132', 'SP167', 3, 252600.0)
INSERT INTO CTHD VALUES ('HD132', 'SP64', 6, 933000.0)
INSERT INTO CTHD VALUES ('HD132', 'SP150', 7, 300300.0)
INSERT INTO CTHD VALUES ('HD132', 'SP98', 7, 45500.0)

INSERT INTO CTHD VALUES ('HD133', 'SP157', 1, 194900.0)
INSERT INTO CTHD VALUES ('HD133', 'SP176', 6, 197400.0)
INSERT INTO CTHD VALUES ('HD133', 'SP136', 4, 988400.0)
INSERT INTO CTHD VALUES ('HD133', 'SP37', 4, 40400.0)

INSERT INTO CTHD VALUES ('HD134', 'SP52', 4, 156000.0)
INSERT INTO CTHD VALUES ('HD135', 'SP77', 1, 30800.0)
INSERT INTO CTHD VALUES ('HD135', 'SP63', 2, 303800.0)
INSERT INTO CTHD VALUES ('HD135', 'SP114', 9, 3396600.0)
INSERT INTO CTHD VALUES ('HD136', 'SP157', 1, 194900.0)
INSERT INTO CTHD VALUES ('HD136', 'SP113', 10, 171000.0)
INSERT INTO CTHD VALUES ('HD136', 'SP192', 8, 559200.0)
INSERT INTO CTHD VALUES ('HD136', 'SP106', 8, 214400.0)
INSERT INTO CTHD VALUES ('HD136', 'SP158', 6, 129000.0)
INSERT INTO CTHD VALUES ('HD136', 'SP92', 7, 185500.0)
INSERT INTO CTHD VALUES ('HD137', 'SP176', 6, 197400.0)
INSERT INTO CTHD VALUES ('HD137', 'SP24', 4, 92000.0)
INSERT INTO CTHD VALUES ('HD137', 'SP120', 1, 322080.0)
INSERT INTO CTHD VALUES ('HD137', 'SP112', 6, 102600.0)
INSERT INTO CTHD VALUES ('HD137', 'SP136', 4, 988400.0)
INSERT INTO CTHD VALUES ('HD138', 'SP23', 5, 390000.0)
INSERT INTO CTHD VALUES ('HD139', 'SP80', 8, 156000.0)
INSERT INTO CTHD VALUES ('HD139', 'SP39', 6, 34800.0)
INSERT INTO CTHD VALUES ('HD139', 'SP140', 5, 1235500.0)
INSERT INTO CTHD VALUES ('HD140', 'SP7', 6, 209400.0)
INSERT INTO CTHD VALUES ('HD140', 'SP86', 9, 241200.0)

INSERT INTO CTHD VALUES ('HD140', 'SP35', 4, 59600.0)
INSERT INTO CTHD VALUES ('HD140', 'SP4', 1, 43900.0)
INSERT INTO CTHD VALUES ('HD140', 'SP25', 9, 198000.0)
INSERT INTO CTHD VALUES ('HD140', 'SP33', 9, 243000.0)
INSERT INTO CTHD VALUES ('HD141', 'SP84', 1, 42075.0)
INSERT INTO CTHD VALUES ('HD141', 'SP83', 1, 28900.0)
INSERT INTO CTHD VALUES ('HD141', 'SP89', 5, 134000.0)
INSERT INTO CTHD VALUES ('HD141', 'SP54', 7, 267400.0)
INSERT INTO CTHD VALUES ('HD141', 'SP131', 5, 1576000.0)
INSERT INTO CTHD VALUES ('HD141', 'SP170', 6, 695400.0)
INSERT INTO CTHD VALUES ('HD142', 'SP113', 1, 17100.0)
INSERT INTO CTHD VALUES ('HD142', 'SP182', 3, 385500.0)
INSERT INTO CTHD VALUES ('HD142', 'SP183', 6, 178800.0)
INSERT INTO CTHD VALUES ('HD142', 'SP115', 1, 204300.0)
INSERT INTO CTHD VALUES ('HD142', 'SP118', 2, 644160.0)
INSERT INTO CTHD VALUES ('HD142', 'SP135', 5, 1235500.0)
INSERT INTO CTHD VALUES ('HD142', 'SP116', 10, 3774000.0)
INSERT INTO CTHD VALUES ('HD143', 'SP158', 7, 150500.0)
INSERT INTO CTHD VALUES ('HD143', 'SP121', 7, 207200.0)
INSERT INTO CTHD VALUES ('HD143', 'SP78', 6, 173400.0)
INSERT INTO CTHD VALUES ('HD143', 'SP116', 4, 1509600.0)
INSERT INTO CTHD VALUES ('HD143', 'SP152', 9, 931500.0)
INSERT INTO CTHD VALUES ('HD144', 'SP144', 1, 52900.0)
INSERT INTO CTHD VALUES ('HD144', 'SP177', 7, 374500.0)
INSERT INTO CTHD VALUES ('HD144', 'SP153', 9, 1223100.0)
INSERT INTO CTHD VALUES ('HD144', 'SP196', 9, 629100.0)
INSERT INTO CTHD VALUES ('HD144', 'SP43', 3, 200100.0)
INSERT INTO CTHD VALUES ('HD144', 'SP101', 8, 285600.0)
INSERT INTO CTHD VALUES ('HD145', 'SP86', 3, 80400.0)
INSERT INTO CTHD VALUES ('HD146', 'SP157', 4, 779600.0)
INSERT INTO CTHD VALUES ('HD146', 'SP17', 6, 330000.0)
INSERT INTO CTHD VALUES ('HD146', 'SP167', 6, 505200.0)
INSERT INTO CTHD VALUES ('HD146', 'SP166', 7, 830900.0)
INSERT INTO CTHD VALUES ('HD146', 'SP58', 10, 295000.0)
INSERT INTO CTHD VALUES ('HD146', 'SP59', 9, 1059300.0)
INSERT INTO CTHD VALUES ('HD147', 'SP194', 6, 419400.0)
INSERT INTO CTHD VALUES ('HD147', 'SP125', 10, 3696000.0)
INSERT INTO CTHD VALUES ('HD147', 'SP86', 9, 241200.0)
INSERT INTO CTHD VALUES ('HD148', 'SP82', 7, 137200.0)
INSERT INTO CTHD VALUES ('HD148', 'SP109', 2, 20400.0)
INSERT INTO CTHD VALUES ('HD148', 'SP175', 5, 448000.0)
INSERT INTO CTHD VALUES ('HD149', 'SP141', 4, 2552880.0)
INSERT INTO CTHD VALUES ('HD149', 'SP190', 10, 446000.0)
INSERT INTO CTHD VALUES ('HD149', 'SP174', 6, 839400.0)
INSERT INTO CTHD VALUES ('HD149', 'SP5', 5, 69500.0)
INSERT INTO CTHD VALUES ('HD149', 'SP4', 4, 175600.0)
INSERT INTO CTHD VALUES ('HD149', 'SP91', 8, 243200.0)
INSERT INTO CTHD VALUES ('HD150', 'SP179', 8, 944000.0)
INSERT INTO CTHD VALUES ('HD150', 'SP170', 8, 927200.0)
INSERT INTO CTHD VALUES ('HD150', 'SP147', 4, 354000.0)

INSERT INTO CTHD VALUES ('HD151', 'SP167', 2, 168400.0)
INSERT INTO CTHD VALUES ('HD151', 'SP50', 3, 72900.0)
INSERT INTO CTHD VALUES ('HD151', 'SP192', 6, 419400.0)
INSERT INTO CTHD VALUES ('HD151', 'SP185', 9, 445500.0)
INSERT INTO CTHD VALUES ('HD151', 'SP52', 2, 78000.0)
INSERT INTO CTHD VALUES ('HD152', 'SP133', 2, 710600.0)
INSERT INTO CTHD VALUES ('HD152', 'SP158', 9, 193500.0)
INSERT INTO CTHD VALUES ('HD152', 'SP161', 8, 949600.0)
INSERT INTO CTHD VALUES ('HD152', 'SP105', 4, 26000.0)
INSERT INTO CTHD VALUES ('HD153', 'SP8', 7, 322000.0)
INSERT INTO CTHD VALUES ('HD153', 'SP177', 9, 481500.0)
INSERT INTO CTHD VALUES ('HD153', 'SP97', 7, 45500.0)
INSERT INTO CTHD VALUES ('HD153', 'SP19', 6, 208800.0)
INSERT INTO CTHD VALUES ('HD154', 'SP140', 2, 494200.0)
INSERT INTO CTHD VALUES ('HD154', 'SP33', 2, 54000.0)
INSERT INTO CTHD VALUES ('HD154', 'SP10', 1, 2900.0)
INSERT INTO CTHD VALUES ('HD154', 'SP157', 4, 779600.0)
INSERT INTO CTHD VALUES ('HD154', 'SP128', 5, 1172000.0)
INSERT INTO CTHD VALUES ('HD155', 'SP180', 10, 1434000.0)
INSERT INTO CTHD VALUES ('HD155', 'SP15', 6, 240000.0)
INSERT INTO CTHD VALUES ('HD155', 'SP141', 10, 6382200.0)

INSERT INTO CTHD VALUES ('HD155', 'SP119', 1, 234400.0)
INSERT INTO CTHD VALUES ('HD155', 'SP65', 2, 80000.0)
INSERT INTO CTHD VALUES ('HD156', 'SP49', 6, 468000.0)
INSERT INTO CTHD VALUES ('HD156', 'SP85', 6, 102600.0)
INSERT INTO CTHD VALUES ('HD156', 'SP130', 10, 3152000.0)
INSERT INTO CTHD VALUES ('HD157', 'SP177', 2, 107000.0)
INSERT INTO CTHD VALUES ('HD157', 'SP191', 9, 561600.0)
INSERT INTO CTHD VALUES ('HD157', 'SP62', 3, 350400.0)
INSERT INTO CTHD VALUES ('HD157', 'SP144', 7, 370300.0)
INSERT INTO CTHD VALUES ('HD157', 'SP152', 3, 310500.0)
INSERT INTO CTHD VALUES ('HD157', 'SP48', 6, 1013400.0)
INSERT INTO CTHD VALUES ('HD158', 'SP162', 4, 427600.0)
INSERT INTO CTHD VALUES ('HD158', 'SP93', 8, 134400.0)
INSERT INTO CTHD VALUES ('HD158', 'SP150', 6, 257400.0)
INSERT INTO CTHD VALUES ('HD158', 'SP30', 10, 520000.0)
INSERT INTO CTHD VALUES ('HD158', 'SP2', 6, 342000.0)
INSERT INTO CTHD VALUES ('HD158', 'SP167', 3, 252600.0)
INSERT INTO CTHD VALUES ('HD159', 'SP70', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD159', 'SP145', 10, 3152000.0)
INSERT INTO CTHD VALUES ('HD159', 'SP55', 6, 242400.0)
INSERT INTO CTHD VALUES ('HD160', 'SP185', 5, 247500.0)
INSERT INTO CTHD VALUES ('HD160', 'SP92', 2, 53000.0)
INSERT INTO CTHD VALUES ('HD160', 'SP148', 9, 313200.0)
INSERT INTO CTHD VALUES ('HD160', 'SP19', 8, 278400.0)
INSERT INTO CTHD VALUES ('HD160', 'SP51', 8, 160000.0)
INSERT INTO CTHD VALUES ('HD160', 'SP165', 1, 118700.0)
INSERT INTO CTHD VALUES ('HD160', 'SP103', 3, 73800.0)
INSERT INTO CTHD VALUES ('HD161', 'SP30', 10, 520000.0)
INSERT INTO CTHD VALUES ('HD161', 'SP161', 5, 593500.0)
INSERT INTO CTHD VALUES ('HD161', 'SP132', 3, 945600.0)
INSERT INTO CTHD VALUES ('HD161', 'SP83', 8, 231200.0)
INSERT INTO CTHD VALUES ('HD161', 'SP113', 5, 85500.0)
INSERT INTO CTHD VALUES ('HD161', 'SP103', 1, 24600.0)
INSERT INTO CTHD VALUES ('HD162', 'SP145', 2, 630400.0)
INSERT INTO CTHD VALUES ('HD162', 'SP18', 3, 117000.0)
INSERT INTO CTHD VALUES ('HD162', 'SP88', 5, 134000.0)
INSERT INTO CTHD VALUES ('HD162', 'SP58', 1, 29500.0)
INSERT INTO CTHD VALUES ('HD162', 'SP46', 8, 683200.0)
INSERT INTO CTHD VALUES ('HD162', 'SP142', 9, 3326400.0)
INSERT INTO CTHD VALUES ('HD163', 'SP66', 3, 60000.0)
INSERT INTO CTHD VALUES ('HD163', 'SP32', 7, 693000.0)
INSERT INTO CTHD VALUES ('HD163', 'SP65', 8, 320000.0)
INSERT INTO CTHD VALUES ('HD163', 'SP41', 2, 27000.0)
INSERT INTO CTHD VALUES ('HD163', 'SP139', 8, 81600.0)
INSERT INTO CTHD VALUES ('HD163', 'SP167', 4, 336800.0)
INSERT INTO CTHD VALUES ('HD163', 'SP183', 6, 178800.0)
INSERT INTO CTHD VALUES ('HD164', 'SP94', 5, 82000.0)
INSERT INTO CTHD VALUES ('HD165', 'SP157', 5, 974500.0)
INSERT INTO CTHD VALUES ('HD165', 'SP186', 7, 482300.0)
INSERT INTO CTHD VALUES ('HD166', 'SP145', 2, 630400.0)
INSERT INTO CTHD VALUES ('HD166', 'SP154', 7, 1098300.0)
INSERT INTO CTHD VALUES ('HD166', 'SP79', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD166', 'SP45', 3, 120000.0)
INSERT INTO CTHD VALUES ('HD167', 'SP118', 6, 1932480.0)
INSERT INTO CTHD VALUES ('HD167', 'SP103', 7, 172200.0)
INSERT INTO CTHD VALUES ('HD167', 'SP32', 9, 891000.0)
INSERT INTO CTHD VALUES ('HD167', 'SP100', 4, 142800.0)
INSERT INTO CTHD VALUES ('HD167', 'SP21', 1, 99000.0)
INSERT INTO CTHD VALUES ('HD168', 'SP14', 6, 39600.0)
INSERT INTO CTHD VALUES ('HD168', 'SP90', 10, 286000.0)
INSERT INTO CTHD VALUES ('HD168', 'SP99', 6, 51600.0)
INSERT INTO CTHD VALUES ('HD169', 'SP16', 6, 19200.0)
INSERT INTO CTHD VALUES ('HD169', 'SP124', 5, 1848000.0)
INSERT INTO CTHD VALUES ('HD169', 'SP59', 6, 706200.0)
INSERT INTO CTHD VALUES ('HD169', 'SP107', 2, 754800.0)
INSERT INTO CTHD VALUES ('HD169', 'SP97', 2, 13000.0)
INSERT INTO CTHD VALUES ('HD170', 'SP179', 1, 118000.0)
INSERT INTO CTHD VALUES ('HD170', 'SP122', 9, 241200.0)
INSERT INTO CTHD VALUES ('HD171', 'SP173', 8, 1026400.0)
INSERT INTO CTHD VALUES ('HD171', 'SP10', 5, 14500.0)
INSERT INTO CTHD VALUES ('HD171', 'SP37', 7, 70700.0)
INSERT INTO CTHD VALUES ('HD172', 'SP83', 5, 144500.0)
INSERT INTO CTHD VALUES ('HD172', 'SP9', 1, 13900.0)
INSERT INTO CTHD VALUES ('HD172', 'SP143', 5, 1610400.0)
INSERT INTO CTHD VALUES ('HD172', 'SP70', 10, 308000.0)
INSERT INTO CTHD VALUES ('HD172', 'SP139', 3, 30600.0)
INSERT INTO CTHD VALUES ('HD172', 'SP67', 4, 40000.0)
INSERT INTO CTHD VALUES ('HD172', 'SP166', 8, 949600.0)
INSERT INTO CTHD VALUES ('HD173', 'SP70', 10, 308000.0)
INSERT INTO CTHD VALUES ('HD174', 'SP171', 1, 207900.0)
INSERT INTO CTHD VALUES ('HD174', 'SP180', 4, 573600.0)
INSERT INTO CTHD VALUES ('HD174', 'SP143', 4, 1288320.0)
INSERT INTO CTHD VALUES ('HD174', 'SP98', 1, 6500.0)
INSERT INTO CTHD VALUES ('HD174', 'SP117', 9, 53100.0)
INSERT INTO CTHD VALUES ('HD175', 'SP169', 2, 231800.0)
INSERT INTO CTHD VALUES ('HD175', 'SP177', 8, 428000.0)
INSERT INTO CTHD VALUES ('HD175', 'SP134', 1, 355300.0)
INSERT INTO CTHD VALUES ('HD175', 'SP95', 9, 58500.0)
INSERT INTO CTHD VALUES ('HD175', 'SP43', 7, 466900.0)
INSERT INTO CTHD VALUES ('HD175', 'SP70', 4, 123200.0)
INSERT INTO CTHD VALUES ('HD175', 'SP40', 4, 23200.0)
INSERT INTO CTHD VALUES ('HD176', 'SP3', 8, 1222400.0)
INSERT INTO CTHD VALUES ('HD176', 'SP161', 1, 118700.0)
INSERT INTO CTHD VALUES ('HD176', 'SP108', 7, 71400.0)
INSERT INTO CTHD VALUES ('HD177', 'SP69', 6, 184800.0)
INSERT INTO CTHD VALUES ('HD177', 'SP46', 7, 597800.0)
INSERT INTO CTHD VALUES ('HD177', 'SP167', 2, 168400.0)
INSERT INTO CTHD VALUES ('HD177', 'SP138', 6, 966240.0)
INSERT INTO CTHD VALUES ('HD178', 'SP190', 7, 312200.0)
INSERT INTO CTHD VALUES ('HD178', 'SP3', 3, 458400.0)
INSERT INTO CTHD VALUES ('HD178', 'SP24', 2, 46000.0)
INSERT INTO CTHD VALUES ('HD178', 'SP133', 7, 2487100.0)
INSERT INTO CTHD VALUES ('HD178', 'SP156', 9, 1578600.0)
INSERT INTO CTHD VALUES ('HD178', 'SP104', 9, 260100.0)
INSERT INTO CTHD VALUES ('HD178', 'SP54', 7, 267400.0)
INSERT INTO CTHD VALUES ('HD179', 'SP78', 6, 173400.0)
INSERT INTO CTHD VALUES ('HD179', 'SP57', 2, 170000.0)
INSERT INTO CTHD VALUES ('HD179', 'SP164', 6, 712200.0)
INSERT INTO CTHD VALUES ('HD180', 'SP20', 6, 788400.0)
INSERT INTO CTHD VALUES ('HD180', 'SP144', 2, 105800.0)
INSERT INTO CTHD VALUES ('HD180', 'SP58', 3, 88500.0)
INSERT INTO CTHD VALUES ('HD180', 'SP47', 2, 27000.0)
INSERT INTO CTHD VALUES ('HD181', 'SP24', 7, 161000.0)
INSERT INTO CTHD VALUES ('HD181', 'SP125', 10, 3696000.0)
INSERT INTO CTHD VALUES ('HD181', 'SP33', 3, 81000.0)
INSERT INTO CTHD VALUES ('HD181', 'SP9', 5, 69500.0)
INSERT INTO CTHD VALUES ('HD181', 'SP187', 6, 188400.0)
INSERT INTO CTHD VALUES ('HD182', 'SP106', 8, 214400.0)
INSERT INTO CTHD VALUES ('HD182', 'SP17', 6, 330000.0)
INSERT INTO CTHD VALUES ('HD182', 'SP53', 10, 656000.0)
INSERT INTO CTHD VALUES ('HD183', 'SP104', 3, 86700.0)
INSERT INTO CTHD VALUES ('HD183', 'SP88', 4, 107200.0)
INSERT INTO CTHD VALUES ('HD184', 'SP34', 8, 216000.0)
INSERT INTO CTHD VALUES ('HD184', 'SP197', 4, 600000.0)
INSERT INTO CTHD VALUES ('HD184', 'SP181', 6, 1020600.0)
INSERT INTO CTHD VALUES ('HD184', 'SP69', 10, 308000.0)
INSERT INTO CTHD VALUES ('HD185', 'SP133', 3, 1065900.0)
INSERT INTO CTHD VALUES ('HD185', 'SP16', 8, 25600.0)
INSERT INTO CTHD VALUES ('HD185', 'SP140', 2, 494200.0)
INSERT INTO CTHD VALUES ('HD185', 'SP1', 2, 55600.0)
INSERT INTO CTHD VALUES ('HD185', 'SP119', 1, 234400.0)
INSERT INTO CTHD VALUES ('HD186', 'SP161', 2, 237400.0)
INSERT INTO CTHD VALUES ('HD186', 'SP33', 9, 243000.0)
INSERT INTO CTHD VALUES ('HD186', 'SP111', 2, 106400.0)
INSERT INTO CTHD VALUES ('HD187', 'SP186', 10, 689000.0)
INSERT INTO CTHD VALUES ('HD187', 'SP44', 5, 55500.0)
INSERT INTO CTHD VALUES ('HD187', 'SP36', 10, 165000.0)
INSERT INTO CTHD VALUES ('HD187', 'SP48', 5, 844500.0)
INSERT INTO CTHD VALUES ('HD187', 'SP168', 4, 336800.0)
INSERT INTO CTHD VALUES ('HD188', 'SP91', 7, 212800.0)
INSERT INTO CTHD VALUES ('HD189', 'SP97', 2, 13000.0)
INSERT INTO CTHD VALUES ('HD189', 'SP49', 7, 546000.0)
INSERT INTO CTHD VALUES ('HD189', 'SP197', 8, 1200000.0)
INSERT INTO CTHD VALUES ('HD189', 'SP164', 9, 1068300.0)
INSERT INTO CTHD VALUES ('HD189', 'SP118', 8, 2576640.0)
INSERT INTO CTHD VALUES ('HD189', 'SP8', 4, 184000.0)
INSERT INTO CTHD VALUES ('HD189', 'SP171', 2, 415800.0)
INSERT INTO CTHD VALUES ('HD190', 'SP141', 3, 1914660.0)
INSERT INTO CTHD VALUES ('HD190', 'SP149', 4, 46000.0)
INSERT INTO CTHD VALUES ('HD190', 'SP50', 7, 170100.0)
INSERT INTO CTHD VALUES ('HD191', 'SP144', 8, 423200.0)
INSERT INTO CTHD VALUES ('HD191', 'SP194', 6, 419400.0)
INSERT INTO CTHD VALUES ('HD191', 'SP99', 4, 34400.0)
INSERT INTO CTHD VALUES ('HD191', 'SP177', 7, 374500.0)
INSERT INTO CTHD VALUES ('HD191', 'SP131', 5, 1576000.0)
INSERT INTO CTHD VALUES ('HD191', 'SP171', 5, 1039500.0)
INSERT INTO CTHD VALUES ('HD191', 'SP9', 1, 13900.0)
INSERT INTO CTHD VALUES ('HD192', 'SP134', 10, 3553000.0)
INSERT INTO CTHD VALUES ('HD192', 'SP164', 4, 474800.0)
INSERT INTO CTHD VALUES ('HD192', 'SP123', 2, 53600.0)
INSERT INTO CTHD VALUES ('HD193', 'SP92', 6, 159000.0)
INSERT INTO CTHD VALUES ('HD193', 'SP24', 1, 23000.0)
INSERT INTO CTHD VALUES ('HD193', 'SP168', 5, 421000.0)
INSERT INTO CTHD VALUES ('HD194', 'SP38', 8, 188000.0)
INSERT INTO CTHD VALUES ('HD194', 'SP3', 8, 1222400.0)
INSERT INTO CTHD VALUES ('HD194', 'SP173', 10, 1283000.0)
INSERT INTO CTHD VALUES ('HD194', 'SP19', 7, 243600.0)
INSERT INTO CTHD VALUES ('HD194', 'SP13', 4, 360000.0)
INSERT INTO CTHD VALUES ('HD195', 'SP29', 9, 52200.0)
INSERT INTO CTHD VALUES ('HD196', 'SP51', 5, 100000.0)
INSERT INTO CTHD VALUES ('HD196', 'SP23', 6, 468000.0)
INSERT INTO CTHD VALUES ('HD196', 'SP87', 9, 153900.0)
INSERT INTO CTHD VALUES ('HD196', 'SP111', 8, 425600.0)
INSERT INTO CTHD VALUES ('HD196', 'SP31', 10, 458000.0)
INSERT INTO CTHD VALUES ('HD197', 'SP34', 8, 216000.0)
INSERT INTO CTHD VALUES ('HD197', 'SP125', 8, 2956800.0)
INSERT INTO CTHD VALUES ('HD197', 'SP140', 7, 1729700.0)
INSERT INTO CTHD VALUES ('HD197', 'SP78', 7, 202300.0)
INSERT INTO CTHD VALUES ('HD197', 'SP58', 6, 177000.0)
INSERT INTO CTHD VALUES ('HD197', 'SP66', 8, 160000.0)
INSERT INTO CTHD VALUES ('HD198', 'SP51', 3, 60000.0)
INSERT INTO CTHD VALUES ('HD198', 'SP46', 9, 768600.0)
INSERT INTO CTHD VALUES ('HD198', 'SP121', 4, 118400.0)
INSERT INTO CTHD VALUES ('HD198', 'SP69', 9, 277200.0)
INSERT INTO CTHD VALUES ('HD198', 'SP89', 6, 160800.0)
INSERT INTO CTHD VALUES ('HD198', 'SP8', 2, 92000.0)
INSERT INTO CTHD VALUES ('HD198', 'SP156', 9, 1578600.0)
INSERT INTO CTHD VALUES ('HD199', 'SP136', 2, 494200.0)
INSERT INTO CTHD VALUES ('HD199', 'SP58', 2, 59000.0)
INSERT INTO CTHD VALUES ('HD199', 'SP192', 9, 629100.0)
INSERT INTO CTHD VALUES ('HD200', 'SP163', 3, 356100.0)
INSERT INTO CTHD VALUES ('HD200', 'SP182', 7, 899500.0)
INSERT INTO CTHD VALUES ('HD200', 'SP144', 3, 158700.0)
INSERT INTO CTHD VALUES ('HD200', 'SP164', 7, 830900.0)
INSERT INTO CTHD VALUES ('HD200', 'SP118', 10, 3220800.0)
--SELECT * FROM CTHD

--SELECT * FROM HANGHOA

INSERT INTO VOUCHER VALUES('158097353',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('664359166',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('805268957',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('723357126',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('542993309',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('668464957',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('460758692',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('706712612',100.000,'14/1/2018','21/1/2018',N'Chưa dùng',null)
INSERT INTO VOUCHER VALUES('423712612',100.000,'14/1/2018','21/1/2018',N'Đã dùng','KH10')
INSERT INTO VOUCHER VALUES('706712432',100.000,'14/1/2018','21/1/2018',N'Đã dùng','KH2')
INSERT INTO VOUCHER(GIFTCODE,GIATRI,NGAYTAO,NGAYHETHAN,TINHTRANG) VALUES ('706756756',100.000,'14/1/2018','21/1/2018',N'Chưa dùng')
--select * from voucher

GO
CREATE PROC TOP_5_SP_HOT
AS
SELECT TOP 5 TENHH,COUNT(CTHD.MAHH) AS 'Số lần bán'
FROM CTHD INNER JOIN HANGHOA HH ON HH.MAHH=CTHD.MAHH
GROUP BY CTHD.MAHH,TENHH
ORDER BY COUNT(CTHD.MAHH) DESC


GO
CREATE PROC SoSPBanDuocMoiLoai
AS
SELECT TOP 5 HH.LOAISP,COUNT(CTHD.MAHH) as 'Số SP bán được'
FROM HANGHOA HH JOIN CTHD ON CTHD.MAHH=HH.MAHH
GROUP BY HH.LOAISP
ORDER BY COUNT(CTHD.MAHH) DESC


SELECT MONTH(HD.NGAYHD) AS 'THANG',SUM(HD.TONGCONG) AS 'LOI NHUAN' 
FROM HOADON HD 
WHERE YEAR(HD.NGAYHD)=2018
GROUP BY MONTH(HD.NGAYHD)

SELECT MONTH(NK.NGAYNHAP) AS 'THANG',SUM(NK.TONGTIENNHAP) AS 'VON' 
FROM NHAPKHO NK
WHERE YEAR(NK.NGAYNHAP)=2018
GROUP BY MONTH(NK.NGAYNHAP)

go
CREATE PROC SLHangHoa
AS
SELECT COUNT(MAHH)
FROM HANGHOA

go
CREATE PROC SLKhachHang
AS
SELECT COUNT(MAKH)
FROM KHACHHANGTHANTHIET

go
CREATE PROC SLNhanVien
AS
SELECT COUNT(MANV)
FROM NHANVIEN


GO
CREATE PROC LOINHUANMOITHANG
AS
SELECT MONTH(HD.NGAYHD) AS 'THÁNG',SUM(HD.TONGCONG)-(SELECT SUM(NK.TONGTIENNHAP)
                                                     FROM NHAPKHO NK
                                                     WHERE YEAR(NK.NGAYNHAP)=2018 
													 AND MONTH(NK.NGAYNHAP)=MONTH(HD.NGAYHD)
                                                     GROUP BY MONTH(NK.NGAYNHAP)
													 )
FROM HOADON HD 
WHERE YEAR(HD.NGAYHD)=2018
GROUP BY MONTH(HD.NGAYHD)

go
CREATE PROC TongDoanhThu
AS
SELECT SUM(HD.TONGCONG)-(SELECT SUM(NK.TONGTIENNHAP)
                       FROM NHAPKHO NK
                       WHERE YEAR(NK.NGAYNHAP)=2018 
					   )
FROM HOADON HD 
WHERE YEAR(HD.NGAYHD)=2018

go
CREATE PROC TienBanHang
AS
SELECT SUM(HD.TONGCONG)
FROM HOADON HD 
WHERE YEAR(HD.NGAYHD)=2018

