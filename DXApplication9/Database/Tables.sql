﻿﻿USE master
GO

CREATE DATABASE QuanLyHocSinh
GO

USE QuanLyHocSinh
GO

--===================================================================================================================================================
-- RANG BUOC --


CREATE TABLE LOAINGUOIDUNG
(
	MaLoai VARCHAR(4) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(30) NOT NULL
)

INSERT INTO LOAINGUOIDUNG VALUES('LND1', N'Ban Giám Hiệu')
INSERT INTO LOAINGUOIDUNG VALUES('LND2', N'Quản Trị')
INSERT INTO LOAINGUOIDUNG VALUES('LND3', N'Giáo Vụ')

--===================================================================================================================================================

CREATE TABLE NGUOIDUNG
(
	MaNguoiDung VARCHAR(6) NOT NULL PRIMARY KEY,
	MaLoai VARCHAR(4) NOT NULL,
	TenNguoiDung NVARCHAR(30) NOT NULL,
	TenDangNhap NVARCHAR(30) NOT NULL,
	MatKhau VARCHAR(64) NOT NULL,

	CONSTRAINT FK_NGUOIDUNG_LOAINGUOIDUNG FOREIGN KEY(MaLoai) REFERENCES LOAINGUOIDUNG(MaLoai)
)



--===================================================================================================================================================

CREATE TABLE NAMHOC
(
	MaNamHoc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenNamHoc NVARCHAR(30) NOT NULL
)

INSERT INTO NAMHOC VALUES('NH2021', '2020-2021')
INSERT INTO NAMHOC VALUES('NH2122', '2021-2022')
INSERT INTO NAMHOC VALUES('NH2223', '2022-2023')

--===================================================================================================================================================

CREATE TABLE HOCKY
(
	MaHocKy VARCHAR(3) NOT NULL PRIMARY KEY,
	TenHocKy NVARCHAR(30) NOT NULL,
	HeSoHK INT,
	CONSTRAINT CK_HOCKY CHECK(CAST(RIGHT(MaHocKy, 1) AS INT) BETWEEN 1 AND 3)
)

INSERT INTO HOCKY VALUES('HK1', N'Học Kỳ 1', 1)
INSERT INTO HOCKY VALUES('HK2', N'Học Kỳ 2', 2)

--===================================================================================================================================================

CREATE TABLE HOCLUC
(
	MaHocLuc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenHocLuc NVARCHAR(30) NOT NULL,
	DiemCanDuoi FLOAT NOT NULL,
	DiemCanTren FLOAT NOT NULL,
	DiemKhongChe FLOAT NOT NULL,

	CONSTRAINT CK_DiemCanDuoi CHECK(DiemCanDuoi BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemCanTren CHECK(DiemCanTren BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemKhongChe CHECK(DiemKhongChe BETWEEN 0 AND 10),
)

INSERT INTO HOCLUC VALUES('HL0001', N'Giỏi', 8.0, 10.0, 6.5)
INSERT INTO HOCLUC VALUES('HL0002', N'Khá', 6.5, 7.9, 5.0)
INSERT INTO HOCLUC VALUES('HL0003', N'Trung bình', 5.0, 6.4, 3.5)
INSERT INTO HOCLUC VALUES('HL0004', N'Yếu', 3.5, 4.9, 2.0)
INSERT INTO HOCLUC VALUES('HL0005', N'Kém', 0.0, 3.4, 0.0)

--===================================================================================================================================================

CREATE TABLE HANHKIEM
(
	MaHanhKiem VARCHAR(4) NOT NULL PRIMARY KEY,
	TenHanhKiem NVARCHAR(30) NOT NULL
)

INSERT INTO HANHKIEM VALUES('HK01', N'Tốt')
INSERT INTO HANHKIEM VALUES('HK02', N'Khá')
INSERT INTO HANHKIEM VALUES('HK03', N'Trung bình')
INSERT INTO HANHKIEM VALUES('HK04', N'Yếu')

--===================================================================================================================================================


CREATE TABLE KETQUA
(
	MaKetQua VARCHAR(4) NOT NULL PRIMARY KEY,
	TenKetQua NVARCHAR(30) NOT NULL
)

INSERT INTO KETQUA VALUES('KQ01', N'Lên lớp')
INSERT INTO KETQUA VALUES('KQ02', N'Thi lại')
INSERT INTO KETQUA VALUES('KQ03', N'Rèn luyện hè')
INSERT INTO KETQUA VALUES('KQ04', N'Ở lại')

--===================================================================================================================================================

CREATE TABLE KHOILOP
(
	MaKhoiLop VARCHAR(6) NOT NULL PRIMARY KEY,
	TenKhoiLop NVARCHAR(30) NOT NULL
)

INSERT INTO KHOILOP VALUES('KHOI10', N'Khối 10')
INSERT INTO KHOILOP VALUES('KHOI11', N'Khối 11')
INSERT INTO KHOILOP VALUES('KHOI12', N'Khối 12')

--==================================================================================================================================================

CREATE TABLE LOP
(
	MaLop VARCHAR(10) NOT NULL PRIMARY KEY,
	TenLop NVARCHAR(30) NOT NULL,
	MaKhoiLop VARCHAR(6) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	SiSo INT NOT NULL,
 
	CONSTRAINT FK_LOP_KHOILOP FOREIGN KEY(MaKhoiLop) REFERENCES KHOILOP(MaKhoiLop),
	CONSTRAINT FK_LOP_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
)

INSERT INTO LOP VALUES('LOP1012021', '10A1', 'KHOI10', 'NH2021', 35)
INSERT INTO LOP VALUES('LOP1022021', '10A2', 'KHOI10', 'NH2021', 36)
INSERT INTO LOP VALUES('LOP1032021', '10A3', 'KHOI10', 'NH2021', 34)
INSERT INTO LOP VALUES('LOP1112021', '11A1', 'KHOI11', 'NH2021', 37)
INSERT INTO LOP VALUES('LOP1122021', '11A2', 'KHOI11', 'NH2021', 38)
INSERT INTO LOP VALUES('LOP1212021', '12A1', 'KHOI12', 'NH2021', 39)


--===================================================================================================================================================


CREATE TABLE HOCSINH
(
	MaHocSinh VARCHAR(6) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh BIT,
	NgaySinh DATETIME,
	DiaChi NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL UNIQUE,
)

-- TAO DU LIEU HOCSINH
INSERT INTO HOCSINH VALUES('HS0001', N'Nguyễn Văn Tú', '0', '01/02/2005', N'Long Xuyên', 'hs001@gmail.com')
INSERT INTO HOCSINH VALUES('HS0002', N'Nguyễn Ngọc An', '0', '01/02/2005', N'Bến Tre', 'hs002@gmail.com')
INSERT INTO HOCSINH VALUES('HS0003', N'Lê Hoàng Anh', '0', '04/15/2005', N'Chợ Mới', 'hs003@gmail.com')
INSERT INTO HOCSINH VALUES('HS0004', N'Huỳnh Thiên Chí', '0', '01/02/2004', N'Đồng Tháp', 'hs004@gmail.com')
INSERT INTO HOCSINH VALUES('HS0005', N'Lý Ngọc Duy', '0', '01/02/2005', N'Long Xuyên', 'hs005@gmail.com')
INSERT INTO HOCSINH VALUES('HS0006', N'Huỳnh Ngọc Điệp', '1', '01/02/2005', N'Bến Tre', 'hs006@gmail.com')
INSERT INTO HOCSINH VALUES('HS0007', N'Trần Thị Huệ', '1', '04/15/2005', N'Chợ Mới', 'hs007@gmail.com')
INSERT INTO HOCSINH VALUES('HS0008', N'Nguyễn Thanh Huy', '0', '01/02/2004', N'Đồng Tháp', 'hs008@gmail.com')
INSERT INTO HOCSINH VALUES('HS0009', N'Trần Phước Lập', '0', '01/02/2005', N'Long Xuyên', 'hs009@gmail.com')
INSERT INTO HOCSINH VALUES('HS0010', N'Trương Thị Nga', '1', '01/02/2005', N'Bến Tre', 'hs010@gmail.com')
INSERT INTO HOCSINH VALUES('HS0011', N'Nguyễn Thị Nga', '1', '04/15/2005', N'Chợ Mới', 'hs011@gmail.com')
INSERT INTO HOCSINH VALUES('HS0012', N'Trần Thị Hồng Nghi', '1', '01/02/2004', N'Đồng Tháp', 'hs012@gmail.com')
INSERT INTO HOCSINH VALUES('HS0013', N'Huỳnh Thị Mỹ Ngọc', '1', '01/02/2005', N'Long Xuyên', 'hs013@gmail.com')
INSERT INTO HOCSINH VALUES('HS0014', N'Trần Thị My Nhân', '1', '01/02/2005', N'Bến Tre', 'hs014@gmail.com')
INSERT INTO HOCSINH VALUES('HS0015', N'Trương Thị Ngoc Nhung', '1', '04/15/2005', N'Chợ Mới', 'hs015@gmail.com')
INSERT INTO HOCSINH VALUES('HS0016', N'Huỳnh Quốc Phuong', '0', '01/02/2004', N'Đồng Tháp', 'hs016@gmail.com')
INSERT INTO HOCSINH VALUES('HS0017', N'Lý Ngọc Phương', '1', '01/02/2005', N'Long Xuyên', 'hs017@gmail.com')
INSERT INTO HOCSINH VALUES('HS0018', N'Nguyễn Thị Phương', '1', '01/02/2005', N'Bến Tre', 'hs018@gmail.com')
INSERT INTO HOCSINH VALUES('HS0019', N'Nguyễn Phú Quốc', '0', '04/15/2005', N'Chợ Mới', 'hs019@gmail.com')
INSERT INTO HOCSINH VALUES('HS0020', N'Võ Thiên Quốc', '0', '01/02/2004', N'Đồng Tháp', 'hs020@gmail.com')
INSERT INTO HOCSINH VALUES('HS0021', N'Trần Văn Rang', '0', '01/02/2004', N'Long Xuyên', 'hs021@gmail.com')
INSERT INTO HOCSINH VALUES('HS0022', N'Võ Hưu Tanh', '0', '01/02/2004', N'Bến Tre', 'hs022@gmail.com')
INSERT INTO HOCSINH VALUES('HS0023', N'Lê Minh Tâm', '0', '04/15/2004', N'Chợ Mới', 'hs023@gmail.com')
INSERT INTO HOCSINH VALUES('HS0024', N'Nguyễn Đức Tâm', '0', '01/02/2003', N'Đồng Tháp', 'hs024@gmail.com')
INSERT INTO HOCSINH VALUES('HS0025', N'Nguyễn Thanh Tâm', '0', '01/02/2004', N'Long Xuyên', 'hs025@gmail.com')
INSERT INTO HOCSINH VALUES('HS0026', N'Trần Ngọc Minh Tân', '0', '01/02/2004', N'Bến Tre', 'hs026@gmail.com')
INSERT INTO HOCSINH VALUES('HS0027', N'Dương Kim Thanh', '1', '04/15/2004', N'Chợ Mới', 'hs027@gmail.com')
INSERT INTO HOCSINH VALUES('HS0028', N'Vang Si Thanh', '0', '01/02/2004', N'Đồng Tháp', 'hs028@gmail.com')
INSERT INTO HOCSINH VALUES('HS0029', N'Đỗ Thị Bích Thảo', '1', '01/02/2004', N'Long Xuyên', 'hs029@gmail.com')
INSERT INTO HOCSINH VALUES('HS0030', N'Hồ Minh Thiên', '0', '01/02/2004', N'Bến Tre', 'hs030@gmail.com')
INSERT INTO HOCSINH VALUES('HS0031', N'Nguyễn Thị Anh Thư', '1', '04/15/2004', N'Chợ Mới', 'hs031@gmail.com')
INSERT INTO HOCSINH VALUES('HS0032', N'Phạm Nguyễn B.Trinh', '1', '01/02/2003', N'Đồng Tháp', 'hs032@gmail.com')
INSERT INTO HOCSINH VALUES('HS0033', N'Võ Ngọc Trinh', '1', '01/02/2004', N'Long Xuyên', 'hs033@gmail.com')
INSERT INTO HOCSINH VALUES('HS0034', N'Nguyễn Huỳnh Minh Trí', '0', '01/02/2004', N'Bến Tre', 'hs034@gmail.com')
INSERT INTO HOCSINH VALUES('HS0035', N'Đỗ Xuân Trinh', '0', '04/15/2004', N'Chợ Mới', 'hs035@gmail.com')
INSERT INTO HOCSINH VALUES('HS0036', N'Nguyễn Hiếu Trung', '0', '01/02/2003', N'Đồng Tháp', 'hs036@gmail.com')
INSERT INTO HOCSINH VALUES('HS0037', N'Nguyễn Thanh Trung', '0', '01/02/2004', N'Long Xuyên', 'hs037@gmail.com')
INSERT INTO HOCSINH VALUES('HS0038', N'Trần Thanh Trúc', '1', '01/02/2004', N'Bến Tre', 'hs038@gmail.com')
INSERT INTO HOCSINH VALUES('HS0039', N'Cao Minh Tuấn', '0', '04/15/2004', N'Chợ Mới', 'hs039@gmail.com')
INSERT INTO HOCSINH VALUES('HS0040', N'Nguyễn Hoang Tuấn', '0', '01/02/2004', N'Đồng Tháp', 'hs040@gmail.com')
INSERT INTO HOCSINH VALUES('HS0041', N'Trương Minh Tuyên', '0', '01/02/2003', N'Long Xuyên', 'hs041@gmail.com')
INSERT INTO HOCSINH VALUES('HS0042', N'Lê Thanh Tung', '0', '01/02/2003', N'Bến Tre', 'hs042@gmail.com')
INSERT INTO HOCSINH VALUES('HS0043', N'Phạm Thị Bích Vi', '1', '04/15/2003', N'Chợ Mới', 'hs043@gmail.com')
INSERT INTO HOCSINH VALUES('HS0044', N'Đặng Quang Vinh', '0', '01/02/2003', N'Đồng Tháp', 'hs044@gmail.com')
INSERT INTO HOCSINH VALUES('HS0045', N'Âu Ngọc Vũ', '0', '01/02/2003', N'Long Xuyên', 'hs045@gmail.com')


--===================================================================================================================================================

CREATE TABLE MONHOC
(
	MaMonHoc VARCHAR(6) NOT NULL PRIMARY KEY,
	TenMonHoc NVARCHAR(30) NOT NULL,
	HeSo INT NOT NULL
)

INSERT INTO MONHOC VALUES('MH0001', N'Toán', 2)
INSERT INTO MONHOC VALUES('MH0002', N'Vật Lý', 1)
INSERT INTO MONHOC VALUES('MH0003', N'Hóa Học', 1)
INSERT INTO MONHOC VALUES('MH0004', N'Sinh Học', 1)
INSERT INTO MONHOC VALUES('MH0005', N'Lịch Sử', 1)
INSERT INTO MONHOC VALUES('MH0006', N'Địa Lý', 1)
INSERT INTO MONHOC VALUES('MH0007', N'Ngữ Văn', 2)
INSERT INTO MONHOC VALUES('MH0008', N'Đạo Đức', 1)
INSERT INTO MONHOC VALUES('MH0009', N'Thể Dục', 1)

--===================================================================================================================================================

CREATE TABLE LOAIDIEM
(
	MaLoaiDiem VARCHAR(4) NOT NULL PRIMARY KEY,
	TenLoaiDiem NVARCHAR(30) NOT NULL,
	HeSo INT NOT NULL
)

INSERT INTO LOAIDIEM VALUES('LD01', N'Kiểm tra miệng', 1)
INSERT INTO LOAIDIEM VALUES('LD02', N'Kiểm tra 15 phút', 1)
INSERT INTO LOAIDIEM VALUES('LD03', N'Kiểm tra 1 tiết', 2)
INSERT INTO LOAIDIEM VALUES('LD04', N'Thi học kỳ', 3)

--===================================================================================================================================================
CREATE TABLE DIEM
(
	STT INT IDENTITY PRIMARY KEY,
	MaHocSinh VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaLop VARCHAR(10) NOT NULL,
	MaLoaiDiem VARCHAR(4) NOT NULL,
	Diem FLOAT NOT NULL,
 
	CONSTRAINT FK_DIEM_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_DIEM_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_DIEM_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
	CONSTRAINT FK_DIEM_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_DIEM_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_DIEM_LOAIDIEM FOREIGN KEY(MaLoaiDiem) REFERENCES LOAIDIEM(MaLoaiDiem),
	CONSTRAINT CK_DIEM CHECK(Diem BETWEEN 0 AND 10)
)

--===================================================================================================================================================

CREATE TABLE KQ_HOCSINH_MONHOC
(
	MaHocSinh VARCHAR(6) NOT NULL,
	MaLop VARCHAR(10) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	DiemMiengTB FLOAT NOT NULL,
	Diem15PhutTB FLOAT NOT NULL,
	Diem45PhutTB FLOAT NOT NULL,
	DiemThi FLOAT NOT NULL,
	DiemTBHK FLOAT NOT NULL,
	PRIMARY KEY(MaHocSinh, MaLop, MaNamHoc, MaMonHoc, MaHocKy),

	CONSTRAINT FK_KQHSMH_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_KQHSMH_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQHSMH_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQHSMH_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_KQHSMH_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),

	CONSTRAINT CK_DiemMiengTB CHECK(DiemMiengTB BETWEEN 0 AND 10),
	CONSTRAINT CK_Diem15PhutTB CHECK(Diem15PhutTB BETWEEN 0 AND 10),
	CONSTRAINT CK_Diem45PhutTB CHECK(Diem45PhutTB BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemThi CHECK(DiemThi BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBHK CHECK(DiemTBHK BETWEEN 0 AND 10),
)

--===================================================================================================================================================

CREATE TABLE KQ_HOCSINH_CANAM
(
	MaHocSinh VARCHAR(6) NOT NULL,
	MaLop VARCHAR(10) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaHocLuc VARCHAR(6) NOT NULL,
	MaHanhKiem VARCHAR(4) NOT NULL,
	MaKetQua VARCHAR(4) NOT NULL,
	DiemTBHK1 FLOAT NOT NULL,
	DiemTBHK2 FLOAT NOT NULL,
	DiemTBCN FLOAT NOT NULL, 
	PRIMARY KEY(MaHocSinh, MaLop, MaNamHoc),
 
	CONSTRAINT FK_KQHSCN_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh),
	CONSTRAINT FK_KQHSCN_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQHSCN_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQHSCN_HOCLUC FOREIGN KEY(MaHocLuc) REFERENCES HOCLUC(MaHocLuc),
	CONSTRAINT FK_KQHSCN_HANHKIEM FOREIGN KEY(MaHanhKiem) REFERENCES HANHKIEM(MaHanhKiem),
	CONSTRAINT FK_KQHSCN_KETQUA FOREIGN KEY(MaKetQua) REFERENCES KETQUA(MaKetQua),

	CONSTRAINT CK_DiemTBHK1 CHECK(DiemTBHK1 BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBHK2 CHECK(DiemTBHK2 BETWEEN 0 AND 10),
	CONSTRAINT CK_DiemTBCN CHECK(DiemTBCN BETWEEN 0 AND 10),
)

--===================================================================================================================================================

CREATE TABLE KQ_LOPHOC_MONHOC
(
	MaLop VARCHAR(10) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaMonHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	SoLuongDat INT NOT NULL,
	TiLe FLOAT NOT NULL,
	PRIMARY KEY(MaLop, MaNamHoc, MaMonHoc, MaHocKy),

	CONSTRAINT FK_KQLHMH_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQLHMH_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQLHMH_MONHOC FOREIGN KEY(MaMonHoc) REFERENCES MONHOC(MaMonHoc),
	CONSTRAINT FK_KQLHMH_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
)

--===================================================================================================================================================

CREATE TABLE KQ_LOPHOC_HOCKY
(
	MaLop VARCHAR(10) NOT NULL,
	MaNamHoc VARCHAR(6) NOT NULL,
	MaHocKy VARCHAR(3) NOT NULL,
	SoLuongDat INT NOT NULL,
	TiLe FLOAT NOT NULL,
	PRIMARY KEY(MaLop, MaNamHoc, MaHocKy),

	CONSTRAINT FK_KQLHHK_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_KQLHHK_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_KQLHHK_HOCKY FOREIGN KEY(MaHocKy) REFERENCES HOCKY(MaHocKy),
)

--===================================================================================================================================================

CREATE TABLE QUYDINH
(
	TuoiCanDuoi INT NOT NULL,
	TuoiCanTren INT NOT NULL,
	SiSoCanDuoi INT NOT NULL,
	SiSoCanTren INT NOT NULL,
	DiemDat INT NOT NULL,
)

INSERT INTO QUYDINH VALUES(15, 20, 30, 40, 5)


--===========================================================================================================================

CREATE TABLE PHANLOP
(
	MaNamHoc VARCHAR(6) NOT NULL,
	MaKhoiLop VARCHAR(6) NOT NULL,
	MaLop VARCHAR(10) NOT NULL,
	MaHocSinh VARCHAR(6) NOT NULL,
	PRIMARY KEY(MaNamHoc, MaKhoiLop, MaLop, MaHocSinh),

	CONSTRAINT FK_PHANLOP_NAMHOC FOREIGN KEY(MaNamHoc) REFERENCES NAMHOC(MaNamHoc),
	CONSTRAINT FK_PHANLOP_KHOI FOREIGN KEY(MaKhoiLop) REFERENCES KHOILOP(MaKhoiLop),
	CONSTRAINT FK_PHANLOP_LOP FOREIGN KEY(MaLop) REFERENCES LOP(MaLop),
	CONSTRAINT FK_PHANLOP_HOCSINH FOREIGN KEY(MaHocSinh) REFERENCES HOCSINH(MaHocSinh)
)

INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0001')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0002')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0003')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0004')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0005')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0006')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0007')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0008')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0009')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1012021', 'HS0010')

INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0011')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0012')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0013')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0014')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0015')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0016')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0017')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0018')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0019')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI10', 'LOP1022021', 'HS0020')

INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0021')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0022')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0023')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0024')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0025')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0026')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0027')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0028')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0029')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1112021', 'HS0030')

INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0031')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0032')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0033')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0034')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0035')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0036')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0037')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0038')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0039')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI11', 'LOP1122021', 'HS0040')

INSERT INTO PHANLOP VALUES('NH2021', 'KHOI12', 'LOP1212021', 'HS0041')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI12', 'LOP1212021', 'HS0042')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI12', 'LOP1212021', 'HS0043')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI12', 'LOP1212021', 'HS0044')
INSERT INTO PHANLOP VALUES('NH2021', 'KHOI12', 'LOP1212021', 'HS0045')
