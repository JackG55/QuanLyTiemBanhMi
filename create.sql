﻿CREATE DATABASE QuanLyTiemBanhMi
GO
USE QuanLyTiemBanhMi
GO

CREATE TABLE LoaiKH(
	MaLoaiKH INT NOT NULL PRIMARY KEY, 
	TenLoaiKH NVARCHAR(100), 
	SoDiemTichLuy INT 
)



CREATE TABLE KhachHang(
	MaKH INT NOT NULL PRIMARY KEY, 
	MaLoaiKH INT NOT NULL, 
	HoTen NVARCHAR(100), 
	NgaySinh DATE, 
	GioiTinh CHAR(3),
	SDT CHAR(10), 
	FOREIGN KEY (MaLoaiKH) REFERENCES dbo.LoaiKH(MaLoaiKH)
)



CREATE TABLE NhanVien(
	MaNV INT NOT NULL PRIMARY KEY, 
	TenNV NVARCHAR(100), 
	UserName VARCHAR(40), 
	Pass VARCHAR(40), 
	NamSinh DATE, 
	DiaChi NVARCHAR(100), 
	ChucVu VARCHAR(100), 
	GioiTinh VARCHAR(3)
)
CREATE TABLE NhaCungCap(
	MaNCC int PRIMARY KEY NOT NULL,
	TenNCC VARCHAR(75) NOT NULL UNIQUE,
	DiaChi NVARCHAR(200),
	SDT CHAR(10)
)

CREATE TABLE NguyenVatLieu(
	MSNVL int PRIMARY KEY NOT NULL,
	TenNVL VARCHAR(75) NOT NULL UNIQUE,
	MoTa NVARCHAR(200),
	DVT VARCHAR(3) NOT NULL CONSTRAINT DVT_NVL_Check CHECK(DVT IN ('kg','g','mg','m','mm','lit','ml')), 
	SLTon INT NOT NULL CONSTRAINT SLT_NVL_Check CHECK(SLTon >=0)
)

CREATE TABLE PhieuNhapHang(
	MaPhieuNhap INT NOT NULL PRIMARY KEY, 
	NgayTao DATETIME DEFAULT(GETDATE()), 
	MaNCC INT NOT NULL, 
	MaNV INT NOT NULL,
	FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC), 
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TongTien INT
)

--DanhMucSanPham (MaDM, TenDanhMuc)
CREATE TABLE DanhMucSanPham(
	MaDM INT NOT NULL PRIMARY KEY, 
	TenDanhMuc NVARCHAR(100)
)


--SanPham (MaSP, TenSP, MoTa, MaNH, MaDM, AnhSP).
CREATE TABLE SanPham(
	MaSP INT NOT NULL PRIMARY KEY, 
	TenSP NVARCHAR(100), 
	MoTa NVARCHAR(200),  
	MaDM INT NOT NULL, 
	AnhSP NVARCHAR(200), 
	FOREIGN KEY(MaDM) REFERENCES dbo.DanhMucSanPham(MaDM)
)


CREATE TABLE CaLam(
	MaCaLam INT NOT NULL PRIMARY KEY, 
	BatDau TIME, 
	KetThuc TIME
)

--LichLamViec (MaCaLam, MaNV, NgayLamViec)
CREATE TABLE LichLamViec (
	MaCaLam INT	NOT NULL, 
	MaNV INT NOT NULL,
	NgayLamViec DATE,
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV), 
	FOREIGN KEY(MaCaLam) REFERENCES dbo.CaLam(MaCaLam), 
	CONSTRAINT PK_LichLamViec PRIMARY KEY(MaCaLam, MaNV)
)

--HinhThucThanhToan (MaThanhToan, TenLoaiHinhThucThanhToan)
CREATE TABLE HinhThucThanhToan(
	MaThanhToan INT NOT NULL PRIMARY KEY, 
	TenLoaiHinhThucThanhToan NVARCHAR(100)
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
	FOREIGN KEY(MaThanhToan) REFERENCES dbo.HinhThucThanhToan(MaThanhToan)
)

--ChuongTrinhKhuyenMai (MaKM,TenKM,PhanTramGiamGia, AnhKMQR)

CREATE TABLE ChuongTrinhKhuyenMai(
	MaKM INT NOT NULL PRIMARY KEY, 
	TenKM NVARCHAR(100), 
	PhanTramGiamGia INT,
	NgayBatDau DATETIME not null DEFAULT(GETDATE()),
	NgayKetThuc DATETIME not null DEFAULT(GETDATE())
)


--ChiTietPhieuNhapHang (MaPhieuNhap, MaSP, MoTa, SL)
CREATE TABLE ChiTietPhieuNhapHang(
	MaPhieuNhap INT NOT NULL, 
	MSNVL INT NOT NULL, 
	DonGia INT NOT NULL, 
	SL INT NOT NULL, 
	CONSTRAINT PK_ChiTietPhieuNhapHang PRIMARY KEY(MaPhieuNhap, MSNVL), 
	FOREIGN KEY(MaPhieuNhap) REFERENCES dbo.PhieuNhapHang(MaPhieuNhap), 
	FOREIGN KEY(MSNVL) REFERENCES dbo.NguyenVatLieu(MSNVL)
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
	MoTa NVARCHAR(100), 
	SL INT, 
	DonGia INT,
	FOREIGN KEY(MaHD) REFERENCES dbo.HoaDon(MaHD), 
	FOREIGN KEY(MaSP) REFERENCES dbo.SanPham(MaSP), 
	CONSTRAINT PL_ChiTietHoaDon PRIMARY KEY(MaHD, MaSP)
)

CREATE TABLE QuyenThaoTac(
	MaQuyen INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenQuyen VARCHAR(150) NOT NULL,
	Xoa BIT DEFAULT(0),
	GhiChu NVARCHAR(200)
)
CREATE TABLE PhanQuyenNguoiDung(
	MaPQND INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	MaNV INT REFERENCES dbo.NhanVien(MaNV),
	MaQuyen INT REFERENCES dbo.QuyenThaoTac(MaQuyen),
	Xoa BIT DEFAULT(0)
)

