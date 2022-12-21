CREATE DATABASE QuanLyTiemBanhMi
GO
USE QuanLyTiemBanhMi
GO

CREATE TABLE LoaiKH(
	MaLoaiKH INT NOT NULL PRIMARY KEY, 
	TenLoaiKH NVARCHAR(100), 
	SoDiemTichLuy INT,
	Xoa BIT DEFAULT(0)
)

CREATE TABLE KhachHang(
	MaKH INT NOT NULL PRIMARY KEY, 
	MaLoaiKH INT NOT NULL, 
	HoTen NVARCHAR(100), 
	NgaySinh DATE, 
	GioiTinh CHAR(3),
	SDT CHAR(10), 
	DiemTichLuy INT DEFAULT(0),
	FOREIGN KEY (MaLoaiKH) REFERENCES dbo.LoaiKH(MaLoaiKH),
	Xoa BIT DEFAULT(0)

)
CREATE TABLE NhanVien(
	MaNV INT NOT NULL PRIMARY KEY, 
	TenNV NVARCHAR(100), 
	UserName VARCHAR(40), 
	Pass VARCHAR(40), 
	NamSinh DATE, 
	DiaChi NVARCHAR(100), 
	ChucVu VARCHAR(100), 
	GioiTinh VARCHAR(3),
	Xoa BIT DEFAULT(0)
)
CREATE TABLE NhaCungCap(
	MaNCC int PRIMARY KEY NOT NULL,
	TenNCC NVARCHAR(100) NOT NULL UNIQUE,
	DiaChi NVARCHAR(200),
	SDT CHAR(10),
	Xoa BIT DEFAULT(0)
)

CREATE TABLE NguyenVatLieu(
	MSNVL int PRIMARY KEY NOT NULL,
	TenNVL NVARCHAR(100) NOT NULL UNIQUE,
	MoTa NVARCHAR(200),
	DVT VARCHAR(3) NOT NULL CONSTRAINT DVT_NVL_Check CHECK(DVT IN ('kg','g','mg','m','mm','lit','ml')), 
	SLTon INT NOT NULL CONSTRAINT SLT_NVL_Check CHECK(SLTon >=0),
	Xoa BIT DEFAULT(0)
)

CREATE TABLE PhieuNhapHang(
	MaPhieuNhap INT NOT NULL PRIMARY KEY, 
	NgayTao DATETIME DEFAULT(GETDATE()), 
	MaNCC INT NOT NULL, 
	MaNV INT NOT NULL,
	FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC), 
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TongTien INT,
	Xoa BIT DEFAULT(0)
)

--DanhMucSanPham (MaDM, TenDanhMuc)
CREATE TABLE DanhMucSanPham(
	MaDM INT NOT NULL PRIMARY KEY, 
	TenDanhMuc NVARCHAR(100),
	Xoa BIT DEFAULT(0)
)


--SanPham (MaSP, TenSP, MoTa, MaNH, MaDM, AnhSP).
CREATE TABLE SanPham(
	MaSP INT NOT NULL PRIMARY KEY, 
	TenSP NVARCHAR(100), 
	MoTa NVARCHAR(200),  
	MaDM INT NOT NULL, 
	GiaBan INT NOT NULL, 
	FOREIGN KEY(MaDM) REFERENCES dbo.DanhMucSanPham(MaDM),
	Xoa BIT DEFAULT(0)
)

CREATE TABLE CaLam(
	MaCaLam INT NOT NULL PRIMARY KEY, 
	BatDau TIME, 
	KetThuc TIME,
	Xoa BIT DEFAULT(0)
)

--LichLamViec (MaCaLam, MaNV, NgayLamViec)
CREATE TABLE LichLamViec (
	MaCaLam INT	NOT NULL, 
	MaNV INT NOT NULL,
	NgayLamViec DATE,
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), 
	FOREIGN KEY(MaCaLam) REFERENCES dbo.CaLam(MaCaLam), 
	CONSTRAINT PK_LichLamViec PRIMARY KEY(MaCaLam, MaNV, NgayLamViec),
)

--HinhThucThanhToan (MaThanhToan, TenLoaiHinhThucThanhToan)
CREATE TABLE HinhThucThanhToan(
	MaThanhToan INT NOT NULL PRIMARY KEY, 
	TenLoaiHinhThucThanhToan NVARCHAR(100),
	Xoa BIT DEFAULT(0)
)


--HoaDon (MaHD, MaNV, NgayTao, MaKH, MaThanhToan)
CREATE TABLE HoaDon (
	MaHD INT NOT NULL PRIMARY KEY, 
	MaNV INT NOT NULL, 
	NgayTao DATETime, 
	MaKH INT NOT NULL, 
	MaThanhToan INT NOT NULL, 
	TongTien INT,
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), 
	FOREIGN KEY(MaKH) REFERENCES dbo.KhachHang(MaKH), 
	FOREIGN KEY(MaThanhToan) REFERENCES dbo.HinhThucThanhToan(MaThanhToan),
	Xoa BIT DEFAULT(0)
)

--ChuongTrinhKhuyenMai (MaKM,TenKM,PhanTramGiamGia, AnhKMQR)

CREATE TABLE ChuongTrinhKhuyenMai(
	MaKM INT NOT NULL PRIMARY KEY, 
	TenKM NVARCHAR(100), 
	PhanTramGiamGia INT,
	NgayBatDau DATETIME not null DEFAULT(GETDATE()),
	NgayKetThuc DATETIME not null DEFAULT(GETDATE()),
	Xoa BIT DEFAULT(0)
)


--ChiTietPhieuNhapHang (MaPhieuNhap, MaSP, MoTa, SL)
CREATE TABLE ChiTietPhieuNhapHang(
	MaPhieuNhap INT NOT NULL, 
	MSNVL INT NOT NULL, 
	DonGia INT NOT NULL, 
	SL INT NOT NULL, 
	CONSTRAINT PK_ChiTietPhieuNhapHang PRIMARY KEY(MaPhieuNhap, MSNVL), 
	FOREIGN KEY(MaPhieuNhap) REFERENCES dbo.PhieuNhapHang(MaPhieuNhap), 
	FOREIGN KEY(MSNVL) REFERENCES dbo.NguyenVatLieu(MSNVL),
	
)

--ChiTietKhuyenMai (MaKM, MaHD, MaKH)
CREATE TABLE ChiTietKhuyenMai(
	MaKM INT NOT NULL, 
	MaHD INT NOT NULL, 
	MAKH INT NOT NULL, 
	FOREIGN KEY(MaKM) REFERENCES dbo.ChuongTrinhKhuyenMai(MaKM), 
	FOREIGN KEY(MaHD) REFERENCES dbo.HoaDon(MaHD), 
	FOREIGN KEY(MAKH) REFERENCES dbo.KhachHang(MaKH), 
	CONSTRAINT PK_ChiTietKhuyenMai PRIMARY KEY(MaKM, MaHD, MAKH)
)


--ChiTietHoaDon (MaHD, MaSP, MoTa, SL, TenNH)
CREATE TABLE ChiTietHoaDon(
	MaHD INT NOT NULL, 
	MaSP INT NOT NULL, 
	SL INT, 
	DonGia INT,
	FOREIGN KEY(MaHD) REFERENCES dbo.HoaDon(MaHD), 
	FOREIGN KEY(MaSP) REFERENCES dbo.SanPham(MaSP), 
	CONSTRAINT PL_ChiTietHoaDon PRIMARY KEY(MaHD, MaSP)
)

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

INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(1,N'Nguyễn Hữu Huân','nvbh01','123','09-03-2000',N'Hà Nội','Nhan Vien Ban Hang','Nam')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(2,N'Nguyễn Thị Thanh','nvk01','123','04-05-1997',N'Hà Nội','Nhan Vien Kho','Nu')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(3,N'Trần Đình Phái','ad01','123','12-12-2000',N'Hà Nam','Quan Ly','Nam')
INSERT dbo.NhanVien(MaNV,TenNV,UserName,Pass,NamSinh,DiaChi,ChucVu,GioiTinh)VALUES(4,N'Lê Thị Linh','nvbh02','123','02-18-1999',N'Bắc Kạn','Nhan Vien Ban Hang','Nu')

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

INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(1,N'Bánh mì nấm thập cẩm',N'Có nấm, rau, không cay',1,25000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(2,N'Bánh mì đậu hũ nướng',N'Có đậu, rau, cay vừa phải',1,20000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(3,N'Bánh mì thịt chả',N'Có thịt, chả giò, rau, không cay',2,15000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(4,N'Bánh mì xíu mại',N'Có xíu mại, rau, không cay',2,20000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(5,N'Bánh mì gà quay',N'Có gà, rau, cay',2,25000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(6,N'Burger Bò',N'Có bò, rau, dưa leo, cà chua',3,30000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(7,N'CocaCola',N'Phiên bản original',4,12000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(8,N'Sữa Đậu',N'Sữa đậu nành',4,7000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(9,N'Xúc xích',N'ngon',5,10000)
INSERT dbo.SanPham(MaSP,TenSP,MoTa,MaDM,GiaBan)VALUES(10,N'Khoai tây chiên',N'Giòn',5,25000)

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

INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(1,1,4,25000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(2,1,2,25000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(2,3,4,30000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(2,6,1,30000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(3,8,5,10000)
INSERT dbo.ChiTietHoaDon(MaHD,MaSP,SL,DonGia)VALUES(3,4,5,20000)



--Chương trình khuyến mãi
CREATE OR ALTER PROC Them_CTKM (@MaKM INT, @TenKM NVARCHAR(100),@PhanTramGiamGia INT,@NgayBatDau DATETIME,@NgayKetThuc DATETIME)
AS
BEGIN
	INSERT dbo.ChuongTrinhKhuyenMai
	(
	    MaKM,
	    TenKM,
	    PhanTramGiamGia,
	    NgayBatDau,
	    NgayKetThuc,
	    Xoa
	)
	VALUES
	(  @MaKM,@TenKM,@PhanTramGiamGia,@NgayBatDau,@NgayKetThuc,0)
END
GO

CREATE OR ALTER PROC Sua_CTKM (@MaKM INT, @TenKM NVARCHAR(100),@PhanTramGiamGia INT,@NgayBatDau DATETIME,@NgayKetThuc DATETIME)
AS
BEGIN
	UPDATE dbo.ChuongTrinhKhuyenMai 
	SET TenKM = @TenKM, PhanTramGiamGia=@PhanTramGiamGia,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc
	WHERE MaKM=@MaKM
END
GO

--Sản Phẩm
CREATE OR ALTER PROC Them_SP (@MaSP INT, @TenSP NVARCHAR(100),@MaDM INT,@MoTa NVARCHAR(200),@GiaBan INT)
AS
BEGIN
	INSERT dbo.SanPham
	(
	    MaSP,
	    TenSP,
	    MoTa,
	    MaDM,
	    Xoa,
	    GiaBan
	)
	VALUES
	(   @MaSP,@TenSP,@MoTa,@MaDM,0,@GiaBan)
END
GO

CREATE OR ALTER PROC Sua_SP (@MaSP INT, @TenSP NVARCHAR(100),@MaDM INT,@MoTa NVARCHAR(200),@GiaBan INT)
AS
BEGIN
	UPDATE dbo.SanPham SET
	TenSP = @TenSP,MaDM=@MaDM,MoTa=@MoTa,GiaBan=@GiaBan
	WHERE MaSP = @MaSP
END
GO

CREATE OR ALTER PROC Xoa_SP (@MaSP INT)
AS
BEGIN
	UPDATE dbo.SanPham SET Xoa=1 WHERE MaSP=@MaSP
END
	
GO
--Danh Mục Sản Phẩm
CREATE OR ALTER PROC Them_DMSP (@MaDM INT, @TenDanhMuc NVARCHAR(100))
AS
BEGIN
	INSERT dbo.DanhMucSanPham
	(MaDM,TenDanhMuc, Xoa)VALUES(@MaDM,@TenDanhMuc,0)
END
GO

CREATE OR ALTER PROC Sua_DMSP (@MaDM INT, @TenDanhMuc NVARCHAR(100))
AS
BEGIN
	UPDATE dbo.DanhMucSanPham SET TenDanhMuc = @TenDanhMuc WHERE MaDM= @MaDM
END
GO
--Chi Tiet Khuyen Mai
CREATE OR ALTER PROC Them_CTKM (@MaKM INT, @MaHD INT, @MaKH INT)
AS
BEGIN
	INSERT dbo.ChiTietKhuyenMai
	(
	    MaKM,
	    MaHD,
	    MAKH
	)
	VALUES
	(   @MaKM, -- MaKM - int
	    @MaHD, -- MaHD - int
	    @MaKH  -- MAKH - int
	    )
	
END
GO
--Chi Tiết Hoá Đơn
CREATE OR ALTER PROC Them_CTHD (@MaHD INT, @MaSP INT, @SL INT,@DonGia INT)
AS
BEGIN
IF EXISTS(SELECT MaSP FROM dbo.ChiTietHoaDon WHERE MaHD = @MaHD)
	UPDATE dbo.ChiTietHoaDon SET SL = SL + @SL WHERE MaHD = @MaHD AND MaSP = @MaSP
ELSE
	INSERT dbo.ChiTietHoaDon
	(
	    MaHD,
	    MaSP,
	    SL,
	    DonGia
	)
	VALUES
	(   @MaHD,   -- MaHD - int
	    @MaSP,   -- MaSP - int
	    @SL,   -- SL - int
	    @DonGia    -- DonGia - int
	    )
END
GO

--Hoá Đơn
CREATE OR ALTER PROC Them_HoaDon (@MaHD INT, @MaNV INT, @NgayTao DATETIME, @MaKH INT,@MaThanhToan INT,@TongTien int)
AS
BEGIN
	INSERT dbo.HoaDon
	(
	    MaHD,
	    MaNV,
	    NgayTao,
	    MaKH,
	    MaThanhToan,
	    TongTien,
	    Xoa
	)
	VALUES
	(   @MaHD,         -- MaHD - int
	    @MaNV,         -- MaNV - int
	    @NgayTao, -- NgayTao - datetime
	    @MaKH,         -- MaKH - int
	    @MaThanhToan,         -- MaThanhToan - int
	    @TongTien,         -- TongTien - int
	    0       -- Xoa - bit
	    )
	
END
GO

--Khách Hàng
CREATE OR ALTER PROC Them_KH (@MaKH INT,@HoTen NVARCHAR(100),@NgaySinh DATE,@SDT CHAR(10), @GioiTinh CHAR(3))
AS
BEGIN
	INSERT dbo.KhachHang
	(
	    MaKH,
	    MaLoaiKH,
	    HoTen,
	    NgaySinh,
	    GioiTinh,
	    SDT,
	    DiemTichLuy
	)
	VALUES
	(   @MaKH,         -- MaKH - int
	    5,         -- MaLoaiKH - int
	    @HoTen,       -- HoTen - nvarchar(100)
	    @NgaySinh, -- NgaySinh - date
	    @GioiTinh,        -- GioiTinh - char(3)
	    @SDT,        -- SDT - char(10)
	    0          -- DiemTichLuy - int
	    )
	
	
END
GO

CREATE OR ALTER PROC Sua_KH (@MaKH INT, @HoTen NVARCHAR(100),@NgaySinh DATE,@SDT CHAR(10), @GioiTinh CHAR(3))
AS
BEGIN
	UPDATE dbo.KhachHang SET
		HoTen= @HoTen,
		NgaySinh = @NgaySinh, 
		SDT = @SDT,
		GioiTinh = @GioiTinh
	WHERE MaKH = @MaKH
END
GO
--Doi Mat Khau
CREATE   PROC [dbo].[DoiMatKhau](@tendangnhap VARCHAR(40),@matkhau VARCHAR(40))
AS
BEGIN
	UPDATE dbo.NhanVien SET Pass = @matkhau WHERE UserName = @tendangnhap
END
GO


--LichLamViec
CREATE OR ALTER PROC Them_LichLamViec (@MaNV INT, @MaCaLam int, @NgayLamViec DATE)
AS
BEGIN
	INSERT dbo.LichLamViec
	(
	    MaCaLam,
	    MaNV,
	    NgayLamViec
	)
	VALUES
	(   @MaCaLam,        -- MaCaLam - int
	    @MaNV,        -- MaNV - int
	   @NgayLamViec -- NgayLamViec - date
	    )
END
GO


--NhanVien
CREATE OR ALTER PROC Xoa_NhanVien (@MaNV INT)
AS
BEGIN
	UPDATE dbo.NhanVien SET 
		Xoa = 1
	WHERE MaNV = @MaNV
END
GO

CREATE OR ALTER PROC Them_NV (@MaNV INT, @TenNV NVARCHAR(100), @UserName VARCHAR(40),@Pass VARCHAR(40),
					@NamSinh DATE, @DiaChi NVARCHAR(100), @ChucVu VARCHAR(100), @GioiTinh VARCHAR(3))
AS
BEGIN
	INSERT dbo.NhanVien
	(
	    MaNV,
	    TenNV,
	    UserName,
	    Pass,
	    NamSinh,
	    DiaChi,
	    ChucVu,
	    GioiTinh,
	    Xoa
	)
	VALUES
	(@MaNV,@TenNV,@UserName,@Pass,@NamSinh,@DiaChi,@ChucVu,@GioiTinh,0)
	
END
GO

CREATE OR ALTER PROC Sua_NV (@MaNV INT, @TenNV NVARCHAR(100),@NamSinh DATE, @DiaChi NVARCHAR(100), @ChucVu VARCHAR(100), @GioiTinh VARCHAR(3))
AS
BEGIN
	UPDATE dbo.NhanVien SET 
		TenNV = @TenNV,
		DiaChi = @DiaChi, 
		GioiTinh = @GioiTinh,
		NamSinh = @NamSinh,
		ChucVu = @ChucVu
	WHERE MaNV = @MaNV
END
GO


--Nhà Cung Cấp
CREATE OR ALTER PROC Them_NCC (@MaNCC INT, @TenNCC NVARCHAR(100), @DiaChi NVARCHAR(200), @SDT CHAR(10))
AS
BEGIN
	INSERT dbo.NhaCungCap
	(
	    MaNCC,
	    TenNCC,
	    DiaChi,
	    SDT,
	    Xoa
	)
	VALUES
	(  @MaNCC, @TenNCC, @DiaChi, @SDT, 0 )
END
GO

CREATE OR ALTER PROC Sua_NCC (@MaNCC INT, @TenNCC NVARCHAR(100), @DiaChi NVARCHAR(200), @SDT CHAR(10))
AS
BEGIN
	UPDATE dbo.NhaCungCap SET 
		TenNCC = @TenNCC,
		DiaChi = @DiaChi, 
		SDT = @SDT
	WHERE MaNCC = @MaNCC
END
GO

CREATE OR ALTER PROC Xoa_NCC (@MaNCC INT)
AS
BEGIN
	UPDATE dbo.NhaCungCap SET 
		Xoa = 1
	WHERE MaNCC = @MaNCC
END
GO

--Nguyên Vật Liệu

CREATE OR ALTER PROC Them_NVL (@MaNVL INT, @TenNVL NVARCHAR(100), @Mota NVARCHAR(200), @DVT VARCHAR(3), @SLTon INT)
AS
BEGIN
	INSERT dbo.NguyenVatLieu
	(
	    MSNVL,
	    TenNVL,
	    MoTa,
	    DVT,
	    SLTon,
	    Xoa
	)
	VALUES
	(  @MaNVL, @TenNVL, @Mota, @DVT, @SLTon, 0
	    )
END
GO

CREATE OR ALTER PROC Sua_NVL (@MaNVL INT, @TenNVL NVARCHAR(100), @Mota NVARCHAR(200), @DVT VARCHAR(3), @SLTon INT)
AS
BEGIN
	UPDATE dbo.NguyenVatLieu SET
		TenNVL = @TenNVL, 
		MoTa = @Mota, 
		DVT = @DVT, 
		SLTon = @SLTon
		WHERE MSNVL = @MaNVL
END
GO

CREATE OR ALTER PROC Xoa_NVL (@MaNVL INT)
AS
BEGIN
	UPDATE dbo.NguyenVatLieu SET 
		Xoa = 1
	WHERE MSNVL = @MaNVL
END
GO

--Chi tiết phiếu nhập hàng
CREATE OR ALTER PROC Them_ChiTietPhieuNhapHang (@MaPhieuNhap INT, @MSNVL INT, @DonGia INT, @SL INT)
AS
BEGIN
	INSERT dbo.ChiTietPhieuNhapHang
	(
	    MaPhieuNhap,
	    MSNVL,
	    DonGia,
	    SL
	)
	VALUES
	(   @MaPhieuNhap, @MSNVL, @DonGia, @SL
	    )
END
GO

CREATE OR ALTER PROC Sua_ChiTietPhieuNhapHang (@MaPhieuNhap INT, @MSNVL INT, @DonGia INT, @SL INT)
AS
BEGIN
	UPDATE dbo.ChiTietPhieuNhapHang SET 
	DonGia = @DonGia, 
	SL = @SL
	WHERE MaPhieuNhap = @MaPhieuNhap AND MSNVL=@MSNVL
END
GO

CREATE OR ALTER PROC Xoa_ChiTietPhieuNhapHang (@MaPhieuNhap INT, @MSNVL INT)
AS
BEGIN
	DELETE dbo.ChiTietPhieuNhapHang WHERE MaPhieuNhap = @MaPhieuNhap AND MSNVL = @MSNVL
END
GO

--Phiếu nhập hàng
CREATE OR ALTER PROC Them_PhieuNhapHang (@MaPhieuNhap INT, @NgayTao DATETIME,@MaNCC INT, @MaNV INT)
AS
BEGIN
	INSERT dbo.PhieuNhapHang
	(
	    MaPhieuNhap,
	    NgayTao,
	    MaNCC,
	    MaNV,
	    TongTien,
	    Xoa
	)
	VALUES
	(@MaPhieuNhap,@NgayTao,@MaNCC,@MaNV,0,0)
END
GO

CREATE OR ALTER PROC Sua_PhieuNhapHang (@MaPhieuNhap INT, @MaNCC INT)
AS
BEGIN
	UPDATE dbo.PhieuNhapHang
	SET	 MaNCC = @MaNCC
	WHERE MaPhieuNhap = @MaPhieuNhap
END
GO