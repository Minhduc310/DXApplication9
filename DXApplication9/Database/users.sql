﻿﻿USE QuanLyHocSinh
GO

CREATE TRIGGER ThemNguoiDung ON NGUOIDUNG 
AFTER INSERT, UPDATE
AS
BEGIN
	UPDATE NguoiDung SET MatKhau = HASHBYTES('SHA2_512', I.TenDangNhap + '@!?#?' + I.MatKhau)
	FROM NguoiDung ND INNER JOIN Inserted I ON I.MaNguoiDung = ND.MaNguoiDung
END
GO

INSERT INTO NGUOIDUNG VALUES('ND0001', 'LND1', 'HIEU TRUONG', 'HIEUTRUONG123', '123456')
INSERT INTO NGUOIDUNG VALUES('ND0002', 'LND2', '215221168-TNGA', '21521168', '*9240@')
INSERT INTO NGUOIDUNG VALUES('ND0003', 'LND2', '21520383-NHI', '21520383', '123456')