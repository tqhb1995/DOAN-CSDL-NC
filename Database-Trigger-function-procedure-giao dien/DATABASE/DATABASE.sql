create DATABASE DatKhachSanOnline
go
USE DatKhachSanOnline
go
/*
	DROP DATABASE DatKhachSanOnline;
	DROP TABLE KhachHang;
	DROP TABLE KhachSan;
	DROP TABLE LoaiPhong;
	DROP TABLE Phong;
	DROP TABLE TrangThaiPhong;
	DROP TABLE DatPhong;
	DROP TABLE HoaDon;
*/
--Create table
CREATE TABLE KhachHang (
	maKH CHAR(10) NOT null,
	hoTen nvarchar(100),
	tenDangNhap varchar(30),
	matKhau varchar(16),
	soCMND varchar(12),
	diaChi nvarchar(200),
	soDienThoai varchar(13),
	moTa nvarchar(1000),
	email varchar(100),
	primary key (maKH)
)
go
CREATE TABLE NhanVien
(
	maNV char(10) not null,
	hoTen nvarchar(100),
	tenDangNhap varchar(30),
	matKhau varchar(30),
	maKS char(10),
	PRIMARY KEY(maNV)
)
go
CREATE TABLE KhachSan (
	maKS CHAR(10) not null,
	tenKS nvarchar(100),
	soSao char(2),
	soNha varchar(10),
	duong nvarchar(100),
	quan nvarchar(100),
	thanhPho nvarchar(100),
	giaTB int,
	moTa nvarchar(1000),
	primary key (maKS)
)
go
CREATE TABLE LoaiPhong (
	maLoaiPhong char(10) not null,
	tenLoaiPhong nvarchar(30),
	maKS char(10) not null,
	donGia int,
	moTa nvarchar(1000),
	slTrong int,
	primary key (maLoaiPhong)
)
go
CREATE TABLE Phong (
	maPhong char(10) not null,
	loaiPhong char(10),
	soPhong int,
	primary key (maPhong)
)
go
CREATE TABLE TrangThaiPhong (
	maPhong char(10) NOT NULL,
	ngay DATETIME,
	tinhTrang nvarchar(14),
	primary key (maPhong, ngay)
)
go
CREATE TABLE DatPhong (
	maDP CHAR(10) not null,
	maLoaiPhong char(10) NOT NULL,
	maPhong char(10),
	maKH CHAR(10) not null,
	ngayBatDau datetime,
	ngayTraPhong datetime,
	ngayDat datetime,
	donGia int,
	moTa nvarchar(1000),
	tinhTrang nvarchar(15),
	primary key (maDP)
)
go
CREATE TABLE HoaDon (
	maHD CHAR(10) NOT NULL,
	ngayThanhToan datetime,
	tongTien int,
	maDP CHAR(10),
	primary key (maHD)
)


go

--Tạo khóa ngoại

alter table LoaiPhong add constraint FK_LoaiPhong_KhachSan foreign key (maKS) references KhachSan(maKS)
alter table Phong add constraint FK_Phong_LoaiPhong foreign key (loaiPhong) references LoaiPhong(maLoaiPhong)
alter table TrangThaiPhong add constraint FK_TrangThaiPhong_Phong foreign key (maPhong) references Phong(maPhong)
alter table DatPhong add constraint FK_DatPhong_Phong foreign key (maPhong) references Phong(maPhong)
alter table DatPhong add constraint FK_DatPhong_KhachHang foreign key (maKH) references KhachHang(maKH)
alter table DatPhong add constraint FK_DatPhong_LoaiPhong foreign key (maLoaiPhong) references LoaiPhong(maLoaiPhong)
alter table HoaDon add constraint FK_HoaDon_DatPhong foreign key (maDP) references DatPhong(maDP)
alter table NhanVien add constraint FK_NhanVien_KhachSan foreign key (maKS) references KhachSan(maKS)




