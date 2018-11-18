--Tạo mã khách hàng tự động
CREATE FUNCTION Auto_IdKH()
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

ALTER TABLE dbo.KhachHang
ADD DEFAULT dbo.Auto_IdKH() FOR maKH

--Tạo mã nhân viên tự động
CREATE FUNCTION Auto_IdNV()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @id varCHAR(10)
	DECLARE  @temp int
	IF (SELECT COUNT(maNV) FROM dbo.NhanVien) = 0
		SET @temp = 0
	ELSE
		SET @temp = (SELECT MAX(CONVERT(INT, (RIGHT(maKH, 8)))) FROM dbo.KhachHang)
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

ALTER TABLE dbo.NhanVien
ADD DEFAULT dbo.Auto_IdNV() FOR maNV

-- Function tạo mã Khách Sạn
CREATE FUNCTION Auto_IdKS()
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

ALTER TABLE dbo.KhachSan
ADD DEFAULT dbo.Auto_IdKS() FOR maKS
--fUNCTION Tạo mã tự động hóa đơn
CREATE FUNCTION Auto_IdHD()
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
		END
     RETURN @id
END

ALTER TABLE dbo.HoaDon
ADD DEFAULT dbo.Auto_IdHD() FOR maHD

--Function tạo mã đặt phòng--
CREATE FUNCTION Auto_IdDP()
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
		WHEN @temp >= 99 AND @temp < 999 THEN 'DP00000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999 AND @temp < 9999 THEN 'DP0000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 9999 AND @temp < 99999 THEN 'DP000' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 99999 AND @temp < 999999 THEN 'DP00' + CONVERT(CHAR, @temp + 1)
		WHEN @temp >= 999999 AND @temp < 9999999 THEN 'DP0' + CONVERT(CHAR, @temp + 1)
		END
     RETURN @id
END

ALTER TABLE dbo.DatPhong
ADD DEFAULT dbo.Auto_IdDP() FOR maDP
