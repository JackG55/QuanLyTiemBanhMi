--Danh Mục Sản Phẩm
CREATE OR ALTER PROC Them_DMSP (@MaDM INT, @TenDanhMuc NVARCHAR(100))
AS
BEGIN
	INSERT dbo.DanhMucSanPham
	(MaDM,TenDanhMuc, Xoa)VALUES(@MaDM,@TenDanhMuc,0)
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
	(   @MaNV,        -- MaCaLam - int
	    @MaCaLam,        -- MaNV - int
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

--