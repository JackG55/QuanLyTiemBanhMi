USE QuanLyTiemBanhMi
GO

INSERT dbo.LoaiKH(MaLoaiKH,TenLoaiKH,SoDiemTichLuy) VALUES(1,  N'Kim cương', 1000)
INSERT dbo.LoaiKH(MaLoaiKH,TenLoaiKH,SoDiemTichLuy) VALUES(2,  N'Vàng', 800)
INSERT dbo.LoaiKH(MaLoaiKH,TenLoaiKH,SoDiemTichLuy) VALUES(3,  N'Bạc', 500)
INSERT dbo.LoaiKH(MaLoaiKH,TenLoaiKH,SoDiemTichLuy) VALUES(4,  N'Đồng', 100)
INSERT dbo.LoaiKH(MaLoaiKH,TenLoaiKH,SoDiemTichLuy) VALUES(5,  N'Tân Binh', 0)

INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(1,2,N'Nguyễn Văn Nam','02-03-2000','Nam','0938837654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(2,1,N'Nguyễn Văn Khánh','03-03-2001','Nam','0939287654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(3,2,N'Trần Thị Linh','02-03-2002','Nu','0938987024')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(4,2,N'Nguyễn Ngọc Nam','02-03-2000','Nam','0938987654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(5,4,N'Trần Thanh Tâm','12-04-1998','Nu','0938987342')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(6,4,N'Bùi Ngọc Khánh','12-02-1999','Nam','0939847654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(7,3,N'Phạm Văn Ninh','02-05-2002','Nam','0938096354')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(8,1,N'Phạm Trọng Tiến','10-19-2000','Nam','0938387654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(9,4,N'Đỗ Đình Hương','12-03-1997','Nam','0931287654')
INSERT dbo.KhachHang(MaKH,MaLoaiKH,HoTen,NgaySinh,GioiTinh,SDT)VALUES(10,4,N'Nguyễn Văn Tiến','09-03-2000','Nam','0945987693')

INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(1,N'Nguyễn Hữu Huân','nvbh01','123','09-03-2000',N'Hà Nội','Ban Hang','Nam')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(2,N'Nguyễn Thị Thanh','nvk01','123','04-05-1997',N'Hà Nội','Nhan Vien Kho','Nu')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(3,N'Trần Đình Phái','ad01','123','12-12-2000',N'Hà Nam','Quan Ly','Nam')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(4,N'Lê Thị Linh','nvbh02','123','02-18-1999',N'Bắc Kạn','Ban Hang','Nu')

INSERT dbo.NhaCungCap(MaNCC,TenNCC,DiaChi,SDT)VALUES(1,N'Kinh Đô',N'Hà Nội','0987638467')
INSERT dbo.NhaCungCap(MaNCC,TenNCC,DiaChi,SDT)VALUES(2,N'Trường An',N'Bắc Ninh','0927836734')
INSERT dbo.NhaCungCap(MaNCC,TenNCC,DiaChi,SDT)VALUES(3,N'KingBread',N'Hà Nội','0987612312')

INSERT dbo.NguyenVatLieu(MSNVL,TenNVL,MoTa,DVT,SLTon)VALUES(1,N'Bột',N'Bột làm bánh mì','kg',50)
INSERT dbo.NguyenVatLieu(MSNVL,TenNVL,MoTa,DVT,SLTon)VALUES(2,N'Bơ',N'Bơ làm bánh mì','kg',20)
INSERT dbo.NguyenVatLieu(MSNVL,TenNVL,MoTa,DVT,SLTon)VALUES(3,N'Sữa',N'Sữa tươi không đường','lit',80)
INSERT dbo.NguyenVatLieu(MSNVL,TenNVL,MoTa,DVT,SLTon)VALUES(4,N'Đường',N'Đường','kg',20)

INSERT dbo.PhieuNhapHang(MaPhieuNhap,NgayTao,MaNCC,MaNV,TongTien)VALUES(1,'12-14-2022',1,3,1000000)
INSERT dbo.PhieuNhapHang(MaPhieuNhap,NgayTao,MaNCC,MaNV,TongTien)VALUES(2,'12-15-2022',2,3,5000000)
INSERT dbo.PhieuNhapHang(MaPhieuNhap,NgayTao,MaNCC,MaNV,TongTien)VALUES(3,'12-16-2022',3,3,6540000)

INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(1,1,200000,2)
INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(1,2,300000,2)
INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(2,3,400000,2)
INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(2,1,200000,1)
INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(3,1,200000,3)
INSERT dbo.ChiTietPhieuNhapHang(MaPhieuNhap,MSNVL,DonGia,SL)VALUES(3,2,54000,1)


INSERT dbo.DanhMucSanPham(MaDM,TenDanhMuc)VALUES(1,N'Bánh mì Chay')
INSERT dbo.DanhMucSanPham(MaDM,TenDanhMuc)VALUES(2,N'Bánh mì Thịt')
INSERT dbo.DanhMucSanPham(MaDM,TenDanhMuc)VALUES(3,N'Burger')
INSERT dbo.DanhMucSanPham(MaDM,TenDanhMuc)VALUES(4,N'Đồ uống')
INSERT dbo.DanhMucSanPham(MaDM,TenDanhMuc)VALUES(5,N'Đồ ăn thêm')

INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(1,N'Bánh mì nấm thập cẩm',N'Có nấm, rau, không cay',1,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(2,N'Bánh mì đậu hũ nướng',N'Có đậu, rau, cay vừa phải',1,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(3,N'Bánh mì thịt chả',N'Có thịt, chả giò, rau, không cay',2,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(4,N'Bánh mì xíu mại',N'Có xíu mại, rau, không cay',2,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(5,N'Bánh mì gà quay',N'Có gà, rau, cay',2,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(6,N'Burger Bò',N'Có bò, rau, dưa leo, cà chua',3,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(7,N'CocaCola',N'Phiên bản original',4,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(8,N'Sữa Đậu',N'Sữa đậu nành',4,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(9,N'Xúc xích',N'ngon',5,N'link')
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,AnhSP)VALUES(10,N'Khoai tây chiên',N'Giòn',5,N'link')

INSERT dbo.CaLam(MaCaLam,BatDau,KetThuc)VALUES(1,'07:00:00','11:00:00')
INSERT dbo.CaLam(MaCaLam,BatDau,KetThuc)VALUES(2,'11:00:00','17:00:00')
INSERT dbo.CaLam(MaCaLam,BatDau,KetThuc)VALUES(3,'17:00:00','22:00:00')

INSERT dbo.LichLamViec(MaCaLam,MaNV,NgayLamViec)VALUES(1,3,'12-14-2022')
INSERT dbo.LichLamViec(MaCaLam,MaNV,NgayLamViec)VALUES(1,1,'12-14-2022')
INSERT dbo.LichLamViec(MaCaLam,MaNV,NgayLamViec)VALUES(2,4,'12-14-2022')
INSERT dbo.LichLamViec(MaCaLam,MaNV,NgayLamViec)VALUES(3,1,'12-14-2022')
INSERT dbo.LichLamViec(MaCaLam,MaNV,NgayLamViec)VALUES(2,2,'12-14-2022')

INSERT dbo.HinhThucThanhToan(MaThanhToan,TenLoaiHinhThucThanhToan)VALUES(1,N'Tiền mặt')
INSERT dbo.HinhThucThanhToan(MaThanhToan,TenLoaiHinhThucThanhToan)VALUES(2,N'Thẻ tín dụng')
INSERT dbo.HinhThucThanhToan(MaThanhToan,TenLoaiHinhThucThanhToan)VALUES(3,N'Chuyển khoản')

INSERT dbo.HoaDon(MaHD,MaNV,NgayTao,MaKH,MaThanhToan,TongTien)VALUES(1,1,'12-14-2022',1,1,100000)
INSERT dbo.HoaDon(MaHD,MaNV,NgayTao,MaKH,MaThanhToan,TongTien)VALUES(2,1,'12-14-2022',2,2,200000)
INSERT dbo.HoaDon(MaHD,MaNV,NgayTao,MaKH,MaThanhToan,TongTien)VALUES(3,4,'12-14-2022',3,3,150000)

INSERT dbo.ChuongTrinhKhuyenMai(MaKM,TenKM,PhanTramGiamGia,NgayBatDau,NgayKetThuc)VALUES(1,N'Noel',10,'12-01-2022','12-31-2022')
INSERT dbo.ChuongTrinhKhuyenMai(MaKM,TenKM,PhanTramGiamGia,NgayBatDau,NgayKetThuc)VALUES(2,N'Khách hàng thân thiết',20,'12-01-2022','12-31-2022')

INSERT dbo.ChiTietKhuyenMai(MaKM,MaHD,MAKH)VALUES(2,1,1)

INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(1,1,N'',4,25000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(2,1,N'',2,25000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(2,3,N'',4,30000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(2,6,N'',1,30000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(3,8,N'',5,10000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,MoTa,SL,DonGia)VALUES(3,4,N'',5,20000)