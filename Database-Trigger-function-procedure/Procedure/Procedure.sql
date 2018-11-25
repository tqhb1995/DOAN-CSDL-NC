--Đăng kí khách hàng
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



--Thêm khách sạn

CREATE PROCEDURE ThemKhachSan
  (@tenKS nvarchar(100), @soSao CHAR(2), @soNha varCHAR(10), @duong nvarCHAR(100), @quan nvarchar(100), @thanhPho nvarCHAR(100), @moTa nvarchar(1000), @giaTB int)
   AS
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

--Procedure Đăng nhập hệ thống
create procedure DangNhapHeThong
  @tenDangNhap varchar(30), @matKhau varchar(16), @isNhanVien  bit
as
if (@isNhanVien = 1)
Select * from NhanVien
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau
 else 
  Select * from KhachHang
      where tenDangNhap = @tenDangNhap and matKhau = @matKhau



--------- Lập Hóa Đơn
-- Input: maDP
-- Output: thong tin hoa don vua moi lap

CREATE PROCEDURE lapHoaDon
	@maDP char(10)
AS
BEGIN
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
			--DECLARE @ngayThanhToan datetime
			DECLARE @maHD char(10)
			SELECT @ngayTraPhong = a.ngayTraPhong from DatPhong a where a.maDP = @maDP
			SELECT @ngayBD = b.ngayBatDau from DatPhong b where b.maDP = @maDP
			SELECT @donGia = c.donGia from DatPhong c where c.maDP = @maDP
			--SELECT @ngayThanhToan = GETDATE()
			SELECT @maHD = dbo.Auto_IdHD()
			SET @soNgay = CAST(DATEDIFF(dd,@ngayBD,@ngayTraPhong) as INT)
			SET @tongTien = @soNgay * @donGia
			---- INSERT dữ liệu vào table Hóa Đơn
			INSERT INTO HoaDon(maHD,ngayThanhToan,tongTien,maDP)
			VALUES (@maHD,GETDATE(),@tongTien,@maDP)
			---- Xuất thông tin hóa đơn vừa tạo cho nhân viên
			SELECT * FROM HoaDon
			WHERE maHD = @maHD
		END
END

---------ĐẶT PHÒNG-------
-------------------------
CREATE PROCEDURE proc_DatPhong  
(  
	@TenKS nvarchar(100),
	@Quan nvarchar(100),
	@ThanhPho nvarchar(100),
	@tenLoaiPhong varchar(20),	
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
			DECLARE @maKS nvarchar(100)
			DECLARE @DonGia float
			DECLARE @maLoaiPhong varchar(100)
			DECLARE @SLTrong int
			DECLARE @soPhongTrong int
			DECLARE @MaPhong varchar(20)
			DECLARE @ngay datetime
			DECLARE @tinhTrang nvarchar(50)
			--Lấy dữ liệu
			SELECT @maDP = dbo.Auto_IdDP()
			SELECT @maKH = maKH FROM dbo.KhachHang WHERE @SDT = soDienThoai
			SELECT @maKS = maKS FROM dbo.KhachSan WHERE @Quan = quan AND @ThanhPho = thanhPho
			SELECT @maLoaiPhong = maLoaiPhong from dbo.LoaiPhong WHERE @maKS = maKS AND @tenLoaiPhong = tenLoaiPhong
			SELECT @DonGia = donGia FROM dbo.LoaiPhong WHERE @DonGia = donGia
			SELECT @SLTrong = slTrong FROM dbo.LoaiPhong WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS
			SET @soPhongTrong = @SLTrong - 1
			IF (@SLTrong <= 0)
			BEGIN
				print N'Đã hết phòng. Xin chọn lại!'
			END
			ELSE
			BEGIN
				INSERT INTO DatPhong(maDP, maLoaiPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa)
				VALUES (@maDP, @maLoaiPhong, @maKH, @NgayBatDau, @ngayTraPhong, GETDATE(), @DonGia, @MoTa)

				--Update số lượng trống của Loại phòng đó trong bảng Loại Phòng
				UPDATE dbo.LoaiPhong
				SET slTrong = @soPhongTrong
				WHERE @maLoaiPhong = maLoaiPhong AND @maKS = maKS
			END
		END
END 


-----------------------------------------

--thêm loại phòng, phòng,sửa khách hàng
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


CREATE PROCEDURE SuaPhong(@ma CHAR(10), @lp CHAR(10), @sophong INT)
AS
BEGIN
IF((SELECT COUNT(*) 
	FROM  dbo.Phong 
	WHERE maPhong= @ma) = 0)
   BEGIN
   RAISERROR('Phòng không tồn tại!',16,1)
   RETURN
   END

UPDATE dbo.Phong
SET loaiPhong = @lp, soPhong= @sophong
WHERE maPhong = @ma
END 

CREATE PROCEDURE SuaLoaiPhong (@malp CHAR(10), @TenLP NVARCHAR(30), @MaKS CHAR(10), @DonGia FLOAT, @mota NVARCHAR(1000), @sltrong INT)
AS
BEGIN
IF((SELECT COUNT(*) 
	FROM  dbo.LoaiPhong 
	WHERE maLoaiPhong= @malp) = 0)
   BEGIN
   RAISERROR('Phòng không tồn tại!',16,1)
   RETURN
   END
UPDATE dbo.LoaiPhong
SET tenLoaiPhong = @TenLP, maKS = @MaKS, donGia = @DonGia, moTa = @mota, slTrong=@sltrong
WHERE maLoaiPhong = @malp
END 

CREATE PROCEDURE SuaKhachHang (@makh CHAR(10), @hoten NVARCHAR(100), @tendangnhap VARCHAR(10), @matkhau VARCHAR(16),
@CMND VARCHAR(12), @diachi NVARCHAR(200), @sodienthoai VARCHAR(13), @moto NVARCHAR(1000),@email VARCHAR(100))
AS
BEGIN
IF((SELECT COUNT(*) 
	FROM  dbo.KhachHang
	WHERE maKH= @makh) = 0)
	BEGIN
   RAISERROR('Phòng không tồn tại!',16,1)
   RETURN
   END
UPDATE dbo.KhachHang
SET hoTen=@hoten, tenDangNhap = @tendangnhap, matKhau = @matkhau, soCMND = @CMND, diaChi = @diachi, soDienThoai = @sodienthoai,
moTa = @moto, email = @email
WHERE maKH = @makh
END

---------------------------------------------------------------------------------------

