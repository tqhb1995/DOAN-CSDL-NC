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