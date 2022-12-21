SELECT DISTINCT dbo.HoaDon.*, dbo.HinhThucThanhToan.*,dbo.KhachHang.HoTen, TenNV
                    FROM dbo.HoaDon JOIN dbo.HinhThucThanhToan ON HinhThucThanhToan.MaThanhToan = HoaDon.MaThanhToan 
                    JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDon.MaKH JOIN dbo.NhanVien ON NhanVien.MaNV = HoaDon.MaNV
					WHERE HoaDon.Xoa = 0
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