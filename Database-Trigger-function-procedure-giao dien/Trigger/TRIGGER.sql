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
go
--trigger RBTV chỉ đơn đặt phòng đã xác nhận mới có hóa đơn
create trigger checkDatPhong on HoaDon
for insert, update
as
if update(maHD)
begin
	if exists(select * from inserted i where exists (select * from DatPhong 
													where DatPhong.maDP=i.maDP and DatPhong.tinhTrang='0'))
	begin
		raiserror(N'lỗi: Đơn đặt phòng chưa xác nhận',16,1)
		rollback
	end
end;
go

create trigger setTongTien on HoaDon
after insert, update
as
begin
	update HoaDon 
	set tongTien=(select datediff(day,dp.ngayBatDau,dp.ngayTraPhong)*dp.donGia from DatPhong dp where dp.maDP=HoaDon.maDP)
end;