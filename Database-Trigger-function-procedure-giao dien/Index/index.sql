--=======================================================
----------------------Create Index------------------------
--=======================================================
--Tạo index trên bảng KhachHang
create nonclustered index IX_tenDangNhap_matKhau
on KhachHang(tenDangNhap, matKhau)

create nonclustered index IX_soCMND
on KhachHang(soCMND)

--Tạo index trên bảng KhachSan
create nonclustered index IX_soSao_thanhPho
on KhachSan(soSao, thanhPho)

create nonclustered index IX_giaTB_thanhPho
on KhachSan(giaTB, thanhPho)

create nonclustered index IX_thanhPho
on KhachSan(thanhPho)

--Tạo index trên bảng LoaiPhong
create nonclustered index IX_maKS
on LoaiPhong(maKS)

create nonclustered index IX_maKS_donGia
on LoaiPhong(maKS, donGia)

--Tạo index trên bảng Phong
create nonclustered index IX_loaiPhong
on Phong(loaiPhong)

--Tạo index trên bảng TrangThaiPhong
create nonclustered index IX_maPhong
on TrangThaiPhong(maPhong)

--Tạo index trên bảng DatPhong
create nonclustered index IX_maLoaiPhong
on DatPhong(maLoaiPhong)

create nonclustered index IX_maKH
on DatPhong(maKH)

--Tạo index trên bảng HoaDon
create nonclustered index IX_maDP
on HoaDon(maDP)

create nonclustered index IX_ngayThanhToan_tongTien
on HoaDon(ngayThanhToan, tongTien)