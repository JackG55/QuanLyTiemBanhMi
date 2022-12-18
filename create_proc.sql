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
