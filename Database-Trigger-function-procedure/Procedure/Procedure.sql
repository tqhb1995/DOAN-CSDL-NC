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
  @tenDangNhap varchar(30), @matKhau varchar(16)
as
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
	@LoaiPhong varchar(20),
	@TenKS nvarchar(100),
	@Quan nvarchar(100),
	@ThanhPho nvarchar(100),
	@NgayBatDau datetime,  
	@NgayTraPhong datetime,  
	@NgayDat datetime,
	@MoTa nvarchar(100),
	@TinhTrang varchar(20),
	@SDT VARCHAR(11)
)  
AS  
BEGIN
	if(NOT EXISTS (SELECT *
					FROM dbo.LoaiPhong
					WHERE @LoaiPhong = maLoaiPhong ))
		BEGIN
			print N'Loại phòng không hợp lệ.'
		END 
	ELSE IF (NOT EXISTS (SELECT *
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
			DECLARE @maLoaiPhong varchar(20)
			DECLARE @DonGia float
			--Lấy dữ liệu
			SELECT @maDP = dbo.Auto_IdDP()
			SELECT @maKH FROM dbo.KhachHang WHERE @SDT = soDienThoai
			SELECT @maKS FROM dbo.KhachSan WHERE @Quan = quan AND @ThanhPho = thanhPho
			SELECT @maLoaiPhong from dbo.LoaiPhong WHERE @maKS = maKS
			SELECT @DonGia FROM dbo.LoaiPhong WHERE @DonGia = donGia
			INSERT INTO DatPhong(maDP, maLoaiPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa, tinhTrang)
			VALUES (@maDP, @maLoaiPhong, @maKH, @NgayBatDau, @ngayTraPhong, @NgayDat, @DonGia, @MoTa, @TinhTrang)
		END
END 





