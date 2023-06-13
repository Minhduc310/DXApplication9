USE QuanLyHocSinh
GO

CREATE PROCEDURE DangNhap
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64)
AS
BEGIN
	SELECT * FROM NGUOIDUNG 
	WHERE TenDangNhap = @tendangnhap
	  AND MatKhau = HASHBYTES('SHA2_512', @tenDangNhap + '@!?#?' + @matKhau)
END
GO

CREATE PROCEDURE DoiMatKhau
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64) 
AS
BEGIN
	UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDangNhap = @tendangnhap
END
GO

=====================================================================================================

CREATE PROCEDURE CapNhatQuyDinhDoTuoi
	@tuoiCanDuoi INT,
	@tuoiCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhSiSo
	@siSoCanDuoi INT,
	@siSoCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhDiemDat @diemDat INT 
AS
BEGIN
	UPDATE QUYDINH SET DiemDat = @diemDat
END
GO

==================================================================================================
CREATE PROCEDURE LayDanhSachHocSinh
	@maNamHoc VARCHAR(6),
	@maLop VARCHAR(10),
	@tatCaCot BIT
AS
BEGIN
	IF @tatCaCot = 1
		SELECT PL.MaHocSinh, HS.* FROM HOCSINH HS 
		INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
		INNER JOIN LOP L ON L.MaLop = PL.MaLop 
		WHERE PL.MaNamHoc = @maNamHoc AND PL.MaLop = @maLop
	ELSE
		SELECT PL.MaHocSinh, HS.HoTen FROM HOCSINH HS 
		INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
		INNER JOIN LOP L ON L.MaLop = PL.MaLop 
		WHERE PL.MaNamHoc = @maNamHoc AND PL.MaLop = @maLop
END
GO

CREATE PROCEDURE LayDanhSachHocSinhTheoNamHoc @maNamHoc VARCHAR(6)
AS
BEGIN
	SELECT PL.MaHocSinh, HS.HoTen, LOP.TenLop FROM HOCSINH HS 
	INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
	INNER JOIN LOP ON LOP.MaLop = PL.MaLop 
	WHERE PL.MaNamHoc = @maNamHoc
END
GO

CREATE PROCEDURE LayDanhSachHocSinhTheoLop
	@maNamHoc VARCHAR(6),
	@maKhoiLop VARCHAR(10),
	@maLop VARCHAR(10)
AS
BEGIN
	SELECT PL.MaHocSinh, HS.HoTen, LOP.TenLop FROM HOCSINH HS 
	INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
	INNER JOIN KHOILOP KL ON KL.MaKhoiLop = PL.MaKhoiLop 
	INNER JOIN LOP ON LOP.MaLop = PL.MaLop 
	WHERE PL.MaNamHoc = @maNamHoc AND PL.MaKhoiLop = @maKhoiLop AND PL.MaLop = @maLop 
END
GO

CREATE PROCEDURE ThemHocSinh
	@maHocSinh VARCHAR(6), 
	@hoTen NVARCHAR(30), 
	@gioiTinh BIT, 
	@ngaySinh DATETIME, 
	@diaChi NVARCHAR(50), 
	@email NVARCHAR(50)
AS
BEGIN
	INSERT INTO HOCSINH (MaHocSinh, HoTen, GioiTinh, NgaySinh, DiaChi, Email) 
	VALUES (@maHocSinh, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @email)
END
GO

================================================================================================

CREATE PROCEDURE CapNhatQuyDinhDoTuoi
	@tuoiCanDuoi INT,
	@tuoiCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhSiSo
	@siSoCanDuoi INT,
	@siSoCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhDiemDat @diemDat INT 
AS
BEGIN
	UPDATE QUYDINH SET DiemDat = @diemDat
END
GO
