﻿--==================================
--====Đăng kí khách hàng============
--==================================
CREATE PROCEDURE DangKiKH
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
--================================
--======Thêm khách sạn============
--================================
go
CREATE PROCEDURE ThemKhachSan
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

--============================================
--=============Thêm nhân viên=================
--============================================
go
create procedure ThemNhanVien
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
--======================================================
--============Đăng nhập hệ thống========================
--======================================================
go
create  procedure DangNhapHeThong
  @tenDangNhap varchar(30), @matKhau varchar(16), @isNhanVien  int
as
if (@isNhanVien = 1)
Select * from NhanVien
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau
else
  Select * from KhachHang
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau


--======================================================
--================Lập Hóa Đơn===========================
--===============Input: maDP============================
--===========Output: thông tin hóa đơn==================
go
CREATE PROCEDURE lapHoaDon
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
			UPDATE TrangThaiPhong
			SET tinhTrang = N'còn trống',
				ngay = GETDATE()
			WHERE maPhong = @maPhong
		END
END

--DROP PROCEDURE lapHoaDon
--EXECUTE lapHoaDon 'DP00000001'
--drop database DatKhachSanOnline
----S
----select * from TrangThaiPhong
--go
--declare @maHD char(10)
--EXECUTE lapHoaDon 'DP00000002', @maHD out
--print @maHD

--=============================================
--==============ĐẶT PHÒNG======================
--=============================================
CREATE PROCEDURE proc_DatPhong  
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
			DECLARE @maLoaiPhong varchar(100)
			DECLARE @SLTrong int
			DECLARE @soPhongTrong int
			--=================================
			--========Lấy dữ liệu==============
			--=================================
			--Lấy mã phát sinh tự động để tạo đặt phòng 
			SELECT @maDP = dbo.Auto_IdDP()
			--Lấy mã khách hàng dựa trên số điện thoại
			SELECT @maKH = maKH FROM dbo.KhachHang WHERE @SDT = soDienThoai
			--Lấy mã khách sạn dựa trên thông tin đường quận thành phố.
			--SELECT @maKS = maKS FROM dbo.KhachSan WHERE @Quan = quan AND @ThanhPho = thanhPho
			SELECT @maLoaiPhong = maLoaiPhong from dbo.LoaiPhong WHERE @maKS = maKS AND @tenLoaiPhong = tenLoaiPhong
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
				VALUES (@maDP, @maLoaiPhong, NULL, @maKH, @NgayBatDau, @ngayTraPhong, GETDATE(), @DonGia, @MoTa, N'Chưa xác nhận')

				--Update số lượng trống của Loại phòng đó trong bảng Loại Phòng
				UPDATE dbo.LoaiPhong
				SET slTrong = @soPhongTrong
				WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS

			END
		END
END 

--================================================================
--==============Các thao tác tên Phòng, Loại Phòng================
--================================================================
---------------------------Thêm Loại Phòng------------------------
CREATE PROCEDURE ThemLoaiPhong (@malp CHAR(10), @TenLP NVARCHAR(30), @MaKS CHAR(10), @DonGia FLOAT, @mota NVARCHAR(1000), @sltrong INT)
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


----------------------------Thêm Phòng-------------------------------
CREATE PROCEDURE ThemPhong (@mp CHAR(10), @lp CHAR(10), @sophong INT) 
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


---------------------------Sửa phòng-----------------------------------
CREATE PROCEDURE SuaPhong(@ma CHAR(10), @lp CHAR(10), @sophong INT)
AS
BEGIN
UPDATE dbo.Phong
SET loaiPhong = @lp, soPhong= @sophong
WHERE maPhong = @ma
END 


-------------------------------Sửa Loại Phòng----------------------------------
CREATE PROCEDURE SuaLoaiPhong (@malp CHAR(10), @TenLP NVARCHAR(30), @MaKS CHAR(10), @DonGia FLOAT, @mota NVARCHAR(1000), @sltrong INT)
AS
BEGIN
UPDATE dbo.LoaiPhong
SET tenLoaiPhong = @TenLP, maKS = @MaKS, donGia = @DonGia, moTa = @mota, slTrong=@sltrong
WHERE maLoaiPhong = @malp
END 


-----------------------------------Sửa Khách hàng-------------------------------------
CREATE PROCEDURE SuaKhachHang (@makh CHAR(10), @hoten NVARCHAR(100), @tendangnhap VARCHAR(10), @matkhau VARCHAR(16),
@CMND VARCHAR(12), @diachi NVARCHAR(200), @sodienthoai VARCHAR(13), @moto NVARCHAR(1000),@email VARCHAR(100))
AS
BEGIN
UPDATE dbo.KhachHang
SET hoTen=@hoten, tenDangNhap = @tendangnhap, matKhau = @matkhau, soCMND = @CMND, diaChi = @diachi, soDienThoai = @sodienthoai,
moTa = @moto, email = @email
WHERE maKH = @makh
END

--=============================================================================
--================STORED PROCEDURE Tìm kiếm khách sạn==========================
--=============================================================================
create procedure search_KS
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

