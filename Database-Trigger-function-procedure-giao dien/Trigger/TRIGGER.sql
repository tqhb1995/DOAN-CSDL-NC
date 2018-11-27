----==================================================================================
-----=-=============================TRIGGER--==========================================
-----===========================================================================
CREATE TRIGGER trg_DatPhong_NgayThangNam
ON DatPhong
FOR UPDATE, INSERT
AS
BEGIN
	IF (exists(SELECT * FROM DatPhong dp 
				Where dp.ngayBatDau > dp.ngayTraPhong 
					OR DATEDIFF (MM, dp.ngayBatDau, dp.ngayTraPhong) > 1))
	Begin
		Raiserror ('Ngày tháng không hợp lệ!',0,1)
		Rollback transaction
	End
END