USE [DatKhachSanOnline11]
GO
/****** Object:  UserDefinedFunction [dbo].[Auto_IdDP]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE FUNCTION [dbo].[Auto_IdDP]()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maDP) FROM dbo.DatPhong) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maDP, 8)))) FROM dbo.DatPhong)
	SET @id = CASE
		WHEN @temp >= 0 and @temp < 9 THEN 'DP0000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9 AND @temp < 99 THEN 'DP000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99 AND @temp < 999 THEN 'DP000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'DP00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'DP0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'DP000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'DP00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999999 AND @temp < 99999999 THEN 'DP0' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END
GO
/****** Object:  UserDefinedFunction [dbo].[Auto_IdHD]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Auto_IdHD]()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maHD) FROM dbo.HoaDon) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maHD, 8)))) FROM dbo.HoaDon)
	SET @id = CASE
		WHEN @temp >= 0 and @temp < 9 THEN 'HD0000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9 AND @temp < 99 THEN 'HD000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99 AND @temp < 999 THEN 'HD00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'HD0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'HD000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'HD00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'HD0' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999999 AND @temp < 99999999 THEN 'HD' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END

GO
/****** Object:  UserDefinedFunction [dbo].[Auto_IdKH]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Auto_IdKH]()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maKH) FROM dbo.KhachHang) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maKH, 8)))) FROM dbo.KhachHang)
	SET @id = CASE
		WHEN @temp >= 0 and @temp < 9 THEN 'KH0000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9 AND @temp < 99 THEN 'KH000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99 AND @temp < 999 THEN 'KH00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'KH0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'KH000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'KH00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'KH0' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END
GO
/****** Object:  UserDefinedFunction [dbo].[Auto_IdKS]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Auto_IdKS]()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maKS) FROM dbo.KhachSan) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maKS, 8)))) FROM dbo.KhachSan)
	SET @id = CASE
		WHEN @temp >= 0 and @temp < 9 THEN 'KS0000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9 AND @temp < 99 THEN 'KS000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99 AND @temp < 999 THEN 'KS00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'KS0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'KS000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'KS00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'KS0' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END

GO
/****** Object:  UserDefinedFunction [dbo].[Auto_IdNV]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Auto_IdNV]()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maNV) FROM dbo.NhanVien) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maNV, 8)))) FROM dbo.NhanVien)
	SET @id = CASE
		WHEN @temp >= 0 and @temp < 9 THEN 'NV0000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9 AND @temp < 99 THEN 'NV000000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99 AND @temp < 999 THEN 'NV00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'NV0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'NV000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'NV00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'NV0' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[maDP] [char](10) NOT NULL,
	[maLoaiPhong] [char](10) NULL,
	[maPhong] [char](10) NULL,
	[maKH] [char](10) NOT NULL,
	[ngayBatDau] [datetime] NULL,
	[ngayTraPhong] [datetime] NULL,
	[ngayDat] [datetime] NULL,
	[donGia] [int] NULL,
	[moTa] [nvarchar](1000) NULL,
	[tinhTrang] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[maDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHD] [char](10) NOT NULL,
	[ngayThanhToan] [datetime] NULL,
	[tongTien] [int] NULL,
	[maDP] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKH] [char](10) NOT NULL,
	[hoTen] [nvarchar](100) NULL,
	[tenDangNhap] [varchar](30) NULL,
	[matKhau] [varchar](16) NULL,
	[soCMND] [varchar](12) NULL,
	[diaChi] [nvarchar](200) NULL,
	[soDienThoai] [varchar](13) NULL,
	[moTa] [nvarchar](1000) NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachSan]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachSan](
	[maKS] [char](10) NOT NULL,
	[tenKS] [nvarchar](100) NULL,
	[soSao] [char](2) NULL,
	[soNha] [varchar](10) NULL,
	[duong] [nvarchar](100) NULL,
	[quan] [nvarchar](100) NULL,
	[thanhPho] [nvarchar](100) NULL,
	[giaTB] [int] NULL,
	[moTa] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[maLoaiPhong] [char](10) NOT NULL,
	[tenLoaiPhong] [nvarchar](30) NULL,
	[maKS] [char](10) NOT NULL,
	[donGia] [int] NULL,
	[moTa] [nvarchar](1000) NULL,
	[slTrong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [char](10) NOT NULL,
	[hoTen] [nvarchar](100) NULL,
	[tenDangNhap] [varchar](30) NULL,
	[matKhau] [varchar](30) NULL,
	[maKS] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[maPhong] [char](10) NOT NULL,
	[loaiPhong] [char](10) NULL,
	[soPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiPhong](
	[maPhong] [char](10) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[tinhTrang] [nvarchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[maPhong] ASC,
	[ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatPhong] ADD  DEFAULT ([dbo].[Auto_IdDP]()) FOR [maDP]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ([dbo].[Auto_IdHD]()) FOR [maHD]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ([dbo].[Auto_IdKH]()) FOR [maKH]
GO
ALTER TABLE [dbo].[KhachSan] ADD  DEFAULT ([dbo].[Auto_IdKS]()) FOR [maKS]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ([dbo].[Auto_IdNV]()) FOR [maNV]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_KhachHang]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_LoaiPhong] FOREIGN KEY([maLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([maLoaiPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_LoaiPhong]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DatPhong] FOREIGN KEY([maDP])
REFERENCES [dbo].[DatPhong] ([maDP])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DatPhong]
GO
ALTER TABLE [dbo].[LoaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_LoaiPhong_KhachSan] FOREIGN KEY([maKS])
REFERENCES [dbo].[KhachSan] ([maKS])
GO
ALTER TABLE [dbo].[LoaiPhong] CHECK CONSTRAINT [FK_LoaiPhong_KhachSan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_KhachSan] FOREIGN KEY([maKS])
REFERENCES [dbo].[KhachSan] ([maKS])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_KhachSan]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([loaiPhong])
REFERENCES [dbo].[LoaiPhong] ([maLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[TrangThaiPhong]  WITH CHECK ADD  CONSTRAINT [FK_TrangThaiPhong_Phong] FOREIGN KEY([maPhong])
REFERENCES [dbo].[Phong] ([maPhong])
GO
ALTER TABLE [dbo].[TrangThaiPhong] CHECK CONSTRAINT [FK_TrangThaiPhong_Phong]
GO
/****** Object:  StoredProcedure [dbo].[DangKiKH]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DangKiKH]
	@hoTen nvarchar(100), @tenDangNhap varCHAR(30), @matKhau varCHAR(16), @soCMND varCHAR(12), @diaChi nvarchar(200), @soDienThoai varCHAR(13), @moTa nvarchar(1000), @email varCHAR(100)
  AS	
   IF(EXISTS(SELECT * FROM dbo.KhachHang WHERE tenDangNhap = @tenDangNhap OR soCMND = @soCMND OR soDienThoai = @soDienThoai OR email = @email))
   BEGIN
   RAISERROR('Lỗi!',16,1)
   RETURN
   END

   INSERT INTO dbo.KhachHang
           ( hoTen ,
             tenDangNhap ,
             matKhau ,
             soCMND ,
             diaChi ,
             soDienThoai ,
             moTa ,
             email
           )
   VALUES  ( @hoTen , -- hoTen - nvarchar(30)
             @tenDangNhap , -- tenDangNhap - char(16)
             @matKhau , -- matKhau - char(16)
             @soCMND , -- soCMND - char(10)
             @diaChi , -- diaChi - nvarchar(30)
             @soDienThoai , -- soDienThoai - char(13)
             @moTa , -- moTa - nvarchar(30)
             @email  -- email - char(20)
           )
GO
/****** Object:  StoredProcedure [dbo].[DangNhapHeThong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  procedure [dbo].[DangNhapHeThong]
  @tenDangNhap varchar(30), @matKhau varchar(16), @isNhanVien  int
as
if (@isNhanVien = 1)
Select * from NhanVien
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau
else
  Select * from KhachHang
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau
GO
/****** Object:  StoredProcedure [dbo].[DanhSachLoaiPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DanhSachLoaiPhong]
	@manv char(10)
as
begin
	select distinct LP.tenLoaiPhong
	from dbo.LoaiPhong LP, dbo.NhanVien NV, dbo.KhachSan KS
	where NV.maNV=@manv and NV.maKS=KS.maKS and KS.maKS=LP.maKS
end
GO
/****** Object:  StoredProcedure [dbo].[KiemTraTinhTrangPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[KiemTraTinhTrangPhong]
	@tenloaiphong nvarchar (30),
	@manv char(10),
	@ngaydat datetime
as
begin
	select distinct P.maPhong, P.loaiPhong, P.soPhong, KS.tenKS
	from dbo.Phong P, dbo.KhachSan KS, dbo.NhanVien NV, dbo.LoaiPhong LP, dbo.TrangThaiPhong TTP
	where NV.maNV = @manv and NV.maKS=KS.maKS and KS.maKS=LP.maKS and LP.maLoaiPhong=P.loaiPhong and LP.tenLoaiPhong=@tenloaiphong and P.maPhong=TTP.maPhong and TTP.ngay<@ngaydat
end
GO
/****** Object:  StoredProcedure [dbo].[lapHoaDon]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lapHoaDon]
	@maDP char(10),
	@maHD char(10) output
AS
BEGIN
	SET NOCOUNT ON;
	if(NOT EXISTS (SELECT *
					FROM DatPhong
					WHERE @maDP = maDP ))
		BEGIN
			print N'Mã đặt phòng không hợp lệ.'
		END
	else
		BEGIN
			-- Tính tổng tiền
			DECLARE @ngayTraPhong date
			DECLARE @ngayBD date
			DECLARE @soNgay int
			DECLARE @tongTien int
			DECLARE @donGia int
			DECLARE @maPhong char(10)
			--DECLARE @maHD char(10)

			SELECT @ngayTraPhong = a.ngayTraPhong from DatPhong a where a.maDP = @maDP
			SELECT @ngayBD = b.ngayBatDau from DatPhong b where b.maDP = @maDP
			SELECT @donGia = c.donGia from DatPhong c where c.maDP = @maDP
			SELECT @maPhong = d.maPhong from DatPhong d where d.maDP = @maDP
			SELECT @maHD = dbo.Auto_IdHD()

			SET @soNgay = CAST(DATEDIFF(dd,@ngayBD,@ngayTraPhong) as INT)
			SET @tongTien = @soNgay * @donGia
			---- INSERT dữ liệu vào table Hóa Đơn
			INSERT INTO HoaDon(maHD,ngayThanhToan,tongTien,maDP)
			VALUES (@maHD,GETDATE(),@tongTien,@maDP)
			----- UPDATE Số lượng phòng trống
			DECLARE @maLoaiPhong char(10)
			SELECT @maLoaiPhong = x.loaiPhong from Phong x where x.maPhong = @maPhong
			UPDATE LOAIPHONG
			SET slTrong = slTrong + 1
			WHERE maLoaiPhong = @maLoaiPhong
			----- UPDATE trạng thái phòng
			INSERT INTO TrangThaiPhong VALUES (@maPhong, GETDATE(),N'còn trống')
		END
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DatPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DatPhong]  
(  
	@maKS varchar(20),
	@maLoaiPhong varchar(20),	
	@NgayBatDau datetime,  
	@NgayTraPhong datetime,
	@MoTa nvarchar(100),
	@SDT VARCHAR(11)
)  
AS  
BEGIN
	IF (NOT EXISTS (SELECT *
					FROM dbo.KhachHang
					WHERE @SDT = soDienThoai ))
		BEGIN
			print N'Khách hàng không tồn tại.'
		END
	ELSE
		BEGIN
			--Khai báo
			DECLARE @maDP char(10)
			DECLARE @maKH char(10)
			--DECLARE @maKS nvarchar(100)
			DECLARE @DonGia float
			--DECLARE @maL 
			DECLARE @SLTrong int
			DECLARE @soPhongTrong int
			--=================================
			--========Lấy dữ liệu==============
			--=================================
			--Lấy mã phát sinh tự động để tạo đặt phòng 
			set @maDP = dbo.Auto_IdDP()
			--Lấy mã khách hàng dựa trên số điện thoại
			SELECT @maKH = maKH FROM dbo.KhachHang WHERE @SDT = soDienThoai
			--Lấy mã khách sạn dựa trên thông tin đường quận thành phố.
			--SELECT @maKS = maKS FROM dbo.KhachSan WHERE @Quan = quan AND @ThanhPho = thanhPho
			--SELECT @maLoaiPhong = maLoaiPhong from dbo.LoaiPhong WHERE @maKS = maKS AND @tenLoaiPhong = tenLoaiPhong
			SELECT @DonGia = donGia FROM dbo.LoaiPhong WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS
			SELECT @SLTrong = slTrong FROM dbo.LoaiPhong WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS
			--Lấy giá trị phòng khi có người đặt.
			SET @soPhongTrong = @SLTrong - 1
			IF (@SLTrong <= 0)
			BEGIN
				print N'Đã hết phòng. Xin chọn lại!'
			END
			ELSE
			BEGIN
				INSERT INTO DatPhong(maDP, maLoaiPhong, maPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa, tinhTrang)
				VALUES ( @maDP, @maLoaiPhong, NULL, @maKH, @NgayBatDau, @ngayTraPhong, GETDATE(), @DonGia, @MoTa, N'Chưa xác nhận')

				--Update số lượng trống của Loại phòng đó trong bảng Loại Phòng
				UPDATE dbo.LoaiPhong
				SET slTrong = @soPhongTrong
				WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS

			END
		END
END 
GO
/****** Object:  StoredProcedure [dbo].[search_KS]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[search_KS]
	@gia1 int,
	@gia2 int,
	@sao char(2),
	@tp nvarchar(100)
as
begin
	create table #result
		(
		rs_maKS char(10),
		rs_tenKS nvarchar(100),
		rs_soSao char(2),
		rs_soNha varchar(10),
		rs_duong nvarchar(100),
		rs_quan nvarchar(100),
		rs_thanhPho nvarchar(100),
		rs_giaTB int,
		rs_moTa nvarchar(1000)
		)
	if @gia1 is not null
		begin 
			if @gia2 is not null
				begin 
					insert into #result 
					select *
					from dbo.KhachSan
					where giaTB between @gia1 and @gia2
				end
			else
				begin 
					insert into #result 
					select *
					from dbo.KhachSan
					where giaTB >= @gia1
				end
		end
	else 
		begin
			if @gia2 is not null
				begin 
					insert into #result 
					select *
					from dbo.KhachSan
					where giaTB <= @gia2
				end
			else
				begin
				if @sao is not null
					begin
						insert into #result
						select *
						from dbo.KhachSan
						where soSao=@sao
					end
				else
					if @tp is not null
						begin
							insert into #result
							select *
							from dbo.KhachSan
							where thanhPho=@tp
						end
					else
						begin
							insert into #result
							select *
							from dbo.KhachSan
						end
				end
		end
	-- Xuat ket qua
	if @sao is not null
		begin 
			if @tp is not null
				begin
					select * 
					from #result
					where rs_soSao=@sao and rs_thanhPho=@tp
				end
			else
				begin
					select *
					from #result
					where rs_soSao=@sao
				end
		end
	else
		begin
			if @tp is not null
				begin
					select *
					from #result
					where rs_thanhPho=@tp
				end
			else
				begin
					select *
					from #result
				end
		end
----------------
	drop table #result
end

GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------Sửa Khách hàng-------------------------------------
CREATE PROCEDURE [dbo].[SuaKhachHang] (@makh CHAR(10), @hoten NVARCHAR(100), @tendangnhap VARCHAR(10), @matkhau VARCHAR(16),
@CMND VARCHAR(12), @diachi NVARCHAR(200), @sodienthoai VARCHAR(13), @moto NVARCHAR(1000),@email VARCHAR(100))
AS
BEGIN
UPDATE dbo.KhachHang
SET hoTen=@hoten, tenDangNhap = @tendangnhap, matKhau = @matkhau, soCMND = @CMND, diaChi = @diachi, soDienThoai = @sodienthoai,
moTa = @moto, email = @email
WHERE maKH = @makh
END
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------Sửa Loại Phòng----------------------------------
CREATE PROCEDURE [dbo].[SuaLoaiPhong] (@malp CHAR(10), @TenLP NVARCHAR(30), @MaKS CHAR(10), @DonGia FLOAT, @mota NVARCHAR(1000), @sltrong INT)
AS
BEGIN
UPDATE dbo.LoaiPhong
SET tenLoaiPhong = @TenLP, maKS = @MaKS, donGia = @DonGia, moTa = @mota, slTrong=@sltrong
WHERE maLoaiPhong = @malp
END 
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaPhong](@ma CHAR(10), @lp CHAR(10), @sophong INT)
AS
BEGIN
UPDATE dbo.Phong
SET loaiPhong = @lp, soPhong= @sophong
WHERE maPhong = @ma
END 
GO
/****** Object:  StoredProcedure [dbo].[ThemKhachSan]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemKhachSan]
  (
  @tenKS nvarchar(100), 
  @soSao CHAR(2), 
  @soNha varCHAR(10), 
  @duong nvarCHAR(100), 
  @quan nvarchar(100), 
  @thanhPho nvarCHAR(100), 
  @moTa nvarchar(1000), 
  @giaTB int
  )
   AS
    IF(EXISTS(SELECT * FROM dbo.KhachSan WHERE tenKS = @tenKS and soSao = @soSao and soNha = @soNha 
	and duong = @duong and quan = @quan and thanhPho = @thanhPho))
   BEGIN
   RAISERROR('Khách Sạn đã tồn tại!',16,1)
   RETURN
   END
   begin
   INSERT INTO dbo.KhachSan
           ( tenKS ,
             soSao ,
             soNha ,
             duong ,
             quan ,
             thanhPho ,
             moTa ,
             giaTB
           )
   VALUES  ( @tenKS , 
             @soSao , 
             @soNha , 
             @duong , 
             @quan , 
             @thanhPho , 
             @moTa , 
             @giaTB  
           )
	 end

GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemLoaiPhong] (@malp CHAR(10), @TenLP NVARCHAR(30), @MaKS CHAR(10), @DonGia FLOAT, @mota NVARCHAR(1000), @sltrong INT)
AS
BEGIN
IF(EXISTS(SELECT * FROM dbo.LoaiPhong WHERE maLoaiPhong = @malp))
   BEGIN
   RAISERROR('Lỗi!',16,1)
   RETURN
   END
INSERT INTO dbo.LoaiPhong
(
	maLoaiPhong,
    tenLoaiPhong,
    maKS,
    donGia,
    moTa,
    slTrong
)
VALUES
(   
	@malp, -- maLoaiPhong - char(10)
	@TenLP, -- tenLoaiPhong - nvarchar(30)
    @MaKS,  -- maKS - char(10)
    @DonGia, -- donGia - float
    @mota, -- moTa - nvarchar(1000)
    @sltrong    -- slTrong - int
)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemNhanVien]
@hoTen nvarchar(100), @tenDangNhap varchar(30), @matKhau varchar(30), @maKS char(10)
as
begin
	if (NOT EXISTS(select * from dbo.KhachSan where maKS = @maKS))
	begin
		print N'Mã khách sạn không tồn tại!'
	end
	
	IF(EXISTS(SELECT * FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap and matKhau = @matKhau and maKS = @maKS)
	or EXISTS(SELECT * FROM dbo.NhanVien WHERE tenDangNhap = @tenDangNhap) )
   BEGIN
   RAISERROR('Lỗi!',16,1)
   RETURN
   END

   insert into dbo.NhanVien
   (
		hoTen,
		tenDangNhap,
		matKhau,
		maKS
   )
   values
   (
	@hoTen,
	@tenDangNhap,
	@matKhau,
	@maKS
   )
end
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 12/15/2018 7:07:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemPhong] (@mp CHAR(10), @lp CHAR(10), @sophong INT) 
AS
BEGIN
IF(EXISTS(SELECT * FROM dbo.Phong WHERE maPhong = @mp))
   BEGIN
   RAISERROR('Lỗi!',16,1)
   RETURN
   END
INSERT INTO dbo.Phong
(
	maPhong,
    loaiPhong,
    soPhong
)
VALUES
(   
	@mp, -- maPhong
    @lp, -- loaiPhong - char(10)
    @sophong   -- soPhong - int
    )
END 

GO
