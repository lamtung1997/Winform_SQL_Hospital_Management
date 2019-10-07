	-- # Phần đầu
use Master								
GO									
If Exists(select* From SysDatabases Where Name='Nhom4_QLBV')		
Drop Database Nhom4_QLBV					
GO									
Create Database Nhom4_QLBV						
GO									
Use Nhom4_QLBV								
GO

	-- # Tạo bảng
CREATE TABLE [BenhNhan]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	HoTen nvarchar(30) NOT NULL,
	NgaySinh Date NOT NULL,
	GioiTinh nvarchar(30) NOT NULL,
	NgheNghiep nvarchar(30) NOT NULL,
	DiaChi nvarchar(30) NOT NULL,
	PRIMARY KEY (MaBenhNhan)
)									
GO

CREATE TABLE [QuaTrinhDieuTri]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	NgayThu nvarchar(20) NOT NULL,
	NgayNhapVien Date NOT NULL,
	TinhTrang nvarchar(30) NOT NULL,	
	PRIMARY KEY (MaBenhNhan,NgayThu)
)									
GO

CREATE TABLE [ThanNhan]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	HoTenThanNhan nvarchar(300) NOT NULL,
	SDT nvarchar(20) NOT NULL,
	DiaChi nvarchar(300) NOT NULL,
	PRIMARY KEY (MaBenhNhan)
)									
GO

CREATE TABLE [NhanVien]
(
	MaNhanVien nvarchar(20) NOT NULL,
	HoTen nvarchar(30) NOT NULL,
	GioiTinh nvarchar(30) NOT NULL,
	NgaySinh Date NOT NULL,
	ChucVu nvarchar(30) NOT NULL,
	SoPhong nvarchar(20) NOT NULL,
	PRIMARY KEY (MaNhanVien)
)									
GO

CREATE TABLE [Thuoc]
(
	MaThuoc nvarchar(20) NOT NULL,
	TenThuoc nvarchar(30) NOT NULL,
	DonVi nvarchar(30) NOT NULL,
	DonGia int NOT NULL,
	NhaCungCap nvarchar(30) NOT NULL,
	SoLuong int NOT NULL,
	PRIMARY KEY (MaThuoc)
)									
GO

CREATE TABLE [NhaCungCapThuoc]
(
	NhaCungCap nvarchar(30) NOT NULL,
	DiaChi nvarchar(30) NOT NULL,
	SDT nvarchar(20) NOT NULL,
	PRIMARY KEY (NhaCungCap)
)									
GO

CREATE TABLE [CoSoYTe]
(
	MaCoSo nvarchar(20) NOT NULL,
	TenCoSo nvarchar(30) NOT NULL,
	DiaChi nvarchar(30) NOT NULL,
	PRIMARY KEY (MaCoSo)
)									
GO

CREATE TABLE [BHYT]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	SoBHYT nvarchar(20),
	PRIMARY KEY (MaBenhNhan)
)									
GO

CREATE TABLE [Phong]
(
	SoPhong nvarchar(20) NOT NULL,
	Khoa nvarchar(30) NOT NULL,
	ChucNang nvarchar(30) NOT NULL,
	PRIMARY KEY (SoPhong)
)									
GO

CREATE TABLE [Giuong]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	SoGiuong nvarchar(20) NOT NULL,
	SoPhong nvarchar(20) NOT NULL,
	PRIMARY KEY (MaBenhNhan)
)									
GO

CREATE TABLE [Khoa]
(
	Khoa nvarchar(30) NOT NULL,
	Tang int NOT NULL,
	SoLuongPhong int NOT NULL,
	MoTa nvarchar(100) NOT NULL,
	PRIMARY KEY (Khoa)
)									
GO

CREATE TABLE [TruongKhoa]
(
	Khoa nvarchar(30) NOT NULL,
	HoTen nvarchar(30) NOT NULL,
	GioiTinh nvarchar(30) NOT NULL,
	NgaySinh Date NOT NULL,
	DiaChi nvarchar(30) NOT NULL,
	SDT nvarchar(20) NOT NULL,	
	PRIMARY KEY (Khoa)
)									
GO

CREATE TABLE [DichVu]
(
	MaDichVu nvarchar(20) NOT NULL,
	TenDichVu nvarchar(30) NOT NULL,
	DonGia int NOT NULL,
	PRIMARY KEY (MaDichVu)
)									
GO

CREATE TABLE [BenhAn]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	SoBenhAn nvarchar(20) NOT NULL,
	LoaiBenhAn nvarchar(30) NOT NULL,
	MaBenh nvarchar(20) NOT NULL,	
	PRIMARY KEY (MaBenhNhan)
)									
GO

CREATE TABLE [BenhLy]
(
	MaBenh nvarchar(20) NOT NULL,
	TenBenh nvarchar(30) NOT NULL,
	PRIMARY KEY (MaBenh)
)									
GO

CREATE TABLE [ChiPhiBenh]
(
	MaBenh nvarchar(20) NOT NULL,
	PhiTuVan int NOT NULL,
	PhiKhamBenh int NOT NULL,
	PhiChuaBenh int NOT NULL,
	PRIMARY KEY (MaBenh)
)									
GO

CREATE TABLE [CaTruc]
(
	Ngay Date NOT NULL,
	MaNhanVien nvarchar(20) NOT NULL,
	Ca int NOT NULL,
	PRIMARY KEY (MaNhanVien,Ngay)
)									
GO

CREATE TABLE [GiayRaVien]
(
	MaBenhNhan nvarchar(20) NOT NULL,
	MaCoSo nvarchar(20) NOT NULL,
	MaDichVu nvarchar(20) NOT NULL,
	KetQua nvarchar(30) NOT NULL,
	LoiKhuyen nvarchar(100) NOT NULL,
	PRIMARY KEY (MaBenhNhan)
)

CREATE TABLE [Users]
(
	ID int NOT NULL,
	Ten nvarchar(30) NOT NULL,
	MatKhau nvarchar(30) NOT NULL,
	PRIMARY KEY (ID)
)

INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0001', N'BA001', N'Bệnh án điều trị', N'B0001')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0002', N'BA002', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0003', N'BA003', N'Bệnh án điều trị', N'B0003')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0004', N'BA004', N'Bệnh án điều trị', N'B0005')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0005', N'BA005', N'Bệnh cấp cứu', N'B0004')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0006', N'BA006', N'Bệnh án điều trị', N'B0001')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0007', N'BA007', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0008', N'BA008', N'Bệnh án điều trị', N'B0003')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0009', N'BA009', N'Bệnh án điều trị', N'B0004')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0010', N'BA010', N'Bệnh án điều trị', N'B0005')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0011', N'BA011', N'Bệnh án điều trị', N'B0001')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0012', N'BA012', N'Bệnh án điều trị', N'B0001')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0013', N'BA013', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0014', N'BA014', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0015', N'BA015', N'Bệnh án điều trị', N'B0003')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0016', N'BA016', N'Bệnh án điều trị', N'B0004')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0017', N'BA017', N'Bệnh án điều trị', N'B0005')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0018', N'BA018', N'Bệnh án điều trị', N'B0001')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0019', N'BA019', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0020', N'BA020', N'Bệnh án điều trị', N'B0002')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0021', N'BA021', N'Bệnh án điều trị', N'B0005')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0022', N'BA022', N'Bệnh án điều trị', N'B0004')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0023', N'BA023', N'Bệnh án điều trị', N'B0005')
INSERT [dbo].[BenhAn] ([MaBenhNhan], [SoBenhAn], [LoaiBenhAn], [MaBenh]) VALUES (N'BN0024', N'BA024', N'Bệnh án điều trị', N'B0003')

INSERT [dbo].[BenhLy] ([MaBenh], [TenBenh]) VALUES (N'B0001', N'Ung Thư')
INSERT [dbo].[BenhLy] ([MaBenh], [TenBenh]) VALUES (N'B0002', N'Tiểu Đường')
INSERT [dbo].[BenhLy] ([MaBenh], [TenBenh]) VALUES (N'B0003', N'Tiêu Chảy')
INSERT [dbo].[BenhLy] ([MaBenh], [TenBenh]) VALUES (N'B0004', N'Viêm Màng Não')
INSERT [dbo].[BenhLy] ([MaBenh], [TenBenh]) VALUES (N'B0005', N'Viêm Giác Mạc')

INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0001', N'Phạm Văn Đồng', CAST(0xC01F0B00 AS Date), N'Nam', N'Công Nhân', N'Hai Bà Trưng,Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0002', N'Trần Thị Oanh', CAST(0x181D0B00 AS Date), N'Nữ', N'Công Nhân', N'Hà Đông,Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0003', N'Vũ Đức Nghĩa', CAST(0x43160B00 AS Date), N'Nam', N'Công Nhân', N'Thường Tín,Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0004', N'Lê Thị Thi', CAST(0x4E1B0B00 AS Date), N'Nữ', N'Công Nhân', N'Nghĩa Lộ,Yên Bái')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0005', N'Dương Hồng Anh', CAST(0xFA1C0B00 AS Date), N'Nam', N'Nông Dân', N'Kim Bảng,Hà Nam')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0006', N'Nguyễn Hoàng Anh', CAST(0x2A1E0B00 AS Date), N'Nữ', N'Giáo viên', N'Quảng Xương, Thanh Hóa')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0007', N'Đỗ Ngọc Quyên', CAST(0xA3F60A00 AS Date), N'Nữ', N'Giảng viên', N'Nghi Lộc, Nghệ Tĩnh')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0008', N'Dương Văn Sơn', CAST(0x33030B00 AS Date), N'Nam', N'Nông dân', N'Từ Sơn, Bắc Ninh')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0009', N'Lại Văn Huy', CAST(0x5C080B00 AS Date), N'Nam', N'Công Nhân', N'Duy Tiên, Hà Nam')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0010', N'Vũ Thị Trang', CAST(0x791B0B00 AS Date), N'Nữ', N'Sinh Viên', N'Đồng Hỷ, Thái Nguyên')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0011', N'Nguyễn Văn Trường', CAST(0xBA120B00 AS Date), N'Nam', N'Công Nhân', N'Kim Bảng, Hà Nam')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0012', N'Nguyễn Quang Tuân', CAST(0xE21C0B00 AS Date), N'Nam', N'Công Nhân', N'Vĩnh Tường, Vĩnh Phúc')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0013', N'Vũ Thị Cỏn', CAST(0xED040B00 AS Date), N'Nữ', N'Nông dân', N'Thường Tín, Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0014', N'Dương Văn Sách', CAST(0xB4090B00 AS Date), N'Nam', N'Công Nhân', N'Tam Điệp, Ninh Bình')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0015', N'Lại Hồng Sơn', CAST(0xB50F0B00 AS Date), N'Nam', N'Kĩ Sư', N'Hà Đông, Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0016', N'Vũ Văn Tiến', CAST(0x0D0C0B00 AS Date), N'Nam', N'Công Nhân', N'Từ Sơn, Bắc Ninh')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0017', N'Nguyễn Thị Huyền', CAST(0x021B0B00 AS Date), N'Nữ', N'Công Nhân', N'Khoái Châu, Hưng Yên')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0018', N'Vũ Mạnh Tuấn', CAST(0x7A1A0B00 AS Date), N'Nam', N'Công An', N'Giao Thủy, Nam Định')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0019', N'Nguyễn Thị Nguyệt', CAST(0x600F0B00 AS Date), N'Nữ', N'Công Nhân', N'Đồng Quan, Thái Bình')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0020', N'Nguyễn Thị May', CAST(0x4E0E0B00 AS Date), N'Nữ', N'Công Nhân', N'Thủy Nguyên, Hải Phòng')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0021', N'Nguyễn Thị Nhi', CAST(0x0D300B00 AS Date), N'Nữ', N'Học Sinh', N'Hải Dương')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0022', N'Lê Tuấn Anh', CAST(0xEA120B00 AS Date), N'Nam', N'Công Nhân', N'Phổ Yên, Thái Nguyên')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0023', N'Ngô Văn Quang', CAST(0x851F0B00 AS Date), N'Nam', N'Sinh Viên', N'Hai Bà Trưng, Hà Nội')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [HoTen], [NgaySinh], [GioiTinh], [NgheNghiep], [DiaChi]) VALUES (N'BN0024', N'Lê Văn Cao', CAST(0xEAEE0A00 AS Date), N'Nam', N'nông Dân', N'Ba Đình, Hà Nội')

INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0001', N'123456780')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0002', N'123456781')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0003', N'123456782')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0004', N'123456783')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0005', N'123456784')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0006', N'123456785')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0007', N'123456786')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0008', N'123456787')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0009', N'123456788')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0010', N'123456789')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0011', N'123456790')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0012', N'123456791')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0013', N'123456791')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0014', N'123456792')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0015', N'123456793')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0016', N'123456794')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0017', N'123456795')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0018', N'123456796')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0019', N'123456797')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0020', N'123456798')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0021', N'123456799')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0022', N'123456710')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0023', N'123456711')
INSERT [dbo].[BHYT] ([MaBenhNhan], [SoBHYT]) VALUES (N'BN0024', N'123456712')

INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x8C3D0B00 AS Date), N'NV001', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x8D3D0B00 AS Date), N'NV002', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x8E3D0B00 AS Date), N'NV003', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x8F3D0B00 AS Date), N'NV004', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x903D0B00 AS Date), N'NV005', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV006', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV007', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV008', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV009', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV010', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV011', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV012', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x913D0B00 AS Date), N'NV013', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x923D0B00 AS Date), N'NV014', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x933D0B00 AS Date), N'NV015', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x943D0B00 AS Date), N'NV016', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x943D0B00 AS Date), N'NV017', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x943D0B00 AS Date), N'NV018', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x943D0B00 AS Date), N'NV019', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x943D0B00 AS Date), N'NV020', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x953D0B00 AS Date), N'NV021', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x953D0B00 AS Date), N'NV022', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x953D0B00 AS Date), N'NV023', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x953D0B00 AS Date), N'NV024', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x953D0B00 AS Date), N'NV025', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV026', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV027', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV028', 4)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV029', 1)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV030', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x963D0B00 AS Date), N'NV031', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x973D0B00 AS Date), N'NV032', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x973D0B00 AS Date), N'NV033', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x973D0B00 AS Date), N'NV034', 2)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x973D0B00 AS Date), N'NV035', 3)
INSERT [dbo].[CaTruc] ([Ngay], [MaNhanVien], [Ca]) VALUES (CAST(0x973D0B00 AS Date), N'NV036', 4)

INSERT [dbo].[ChiPhiBenh] ([MaBenh], [PhiTuVan], [PhiKhamBenh], [PhiChuaBenh]) VALUES (N'B0001', 500, 1000, 20000)
INSERT [dbo].[ChiPhiBenh] ([MaBenh], [PhiTuVan], [PhiKhamBenh], [PhiChuaBenh]) VALUES (N'B0002', 500, 1000, 15000)
INSERT [dbo].[ChiPhiBenh] ([MaBenh], [PhiTuVan], [PhiKhamBenh], [PhiChuaBenh]) VALUES (N'B0003', 500, 1000, 17000)
INSERT [dbo].[ChiPhiBenh] ([MaBenh], [PhiTuVan], [PhiKhamBenh], [PhiChuaBenh]) VALUES (N'B0004', 500, 1000, 23000)
INSERT [dbo].[ChiPhiBenh] ([MaBenh], [PhiTuVan], [PhiKhamBenh], [PhiChuaBenh]) VALUES (N'B0005', 500, 1000, 30000)

INSERT [dbo].[CoSoYTe] ([MaCoSo], [TenCoSo], [DiaChi]) VALUES (N'CS001', N'Bệnh Viện Thanh Nhàn', N'Thanh Nhàn, Hà Nội')
INSERT [dbo].[CoSoYTe] ([MaCoSo], [TenCoSo], [DiaChi]) VALUES (N'CS002', N'Bệnh Viện Thường Tín', N'Thường Tín, Hà Nội')
INSERT [dbo].[CoSoYTe] ([MaCoSo], [TenCoSo], [DiaChi]) VALUES (N'CS003', N'Bệnh Viện Hà Đông', N'Hà Đông, Hà Nội')
INSERT [dbo].[CoSoYTe] ([MaCoSo], [TenCoSo], [DiaChi]) VALUES (N'CS004', N'Bệnh Viện Chương Mỹ', N'Chương Mỹ, Hà Nội')
INSERT [dbo].[CoSoYTe] ([MaCoSo], [TenCoSo], [DiaChi]) VALUES (N'CS005', N'Bệnh Viện Thanh Trì', N'Thanh Trì, Hà Nội')

INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0001', N'Chụp X quang', 300)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0002', N'Nội soi', 200)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0003', N'Xét nghiệm nước tiểu', 350)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0004', N'Xét nghiệm máu ', 350)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0005', N'Xét nghiệp tủy', 500)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [DonGia]) VALUES (N'DV0006', N'Chụp CT', 1000)

INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0001', N'G0231', N'P0023')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0002', N'G0241', N'P0024')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0003', N'G0251', N'P0025')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0004', N'G0531', N'P0053')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0005', N'G0101', N'P0010')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0006', N'G0541', N'P0054')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0007', N'G0551', N'P0055')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0008', N'G0431', N'P0043')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0009', N'G0841', N'P0024')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0010', N'G0451', N'P0045')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0011', N'G0331', N'P0033')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0012', N'G0341', N'P0034')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0013', N'G0351', N'P0035')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0014', N'G0631', N'P0033')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0015', N'G0641', N'P0024')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0016', N'G0651', N'P0055')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0017', N'G0731', N'P0043')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0018', N'G0741', N'P0034')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0019', N'G0751', N'P0025')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0020', N'G0831', N'P0023')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0021', N'G0441', N'P0044')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0022', N'G0851', N'P0035')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0023', N'G0632', N'P0043')
INSERT [dbo].[Giuong] ([MaBenhNhan], [SoGiuong], [SoPhong]) VALUES (N'BN0024', N'G0732', N'P0033')

INSERT [dbo].[Khoa] ([Khoa], [Tang], [SoLuongPhong], [MoTa]) VALUES (N'Khoa Cấp cứu', 1, 1, N'Khoa cấp cứu các bệnh nhân đang trong cơn nguy kịch, nguy hiểm về tính mạng và sức khỏe')
INSERT [dbo].[Khoa] ([Khoa], [Tang], [SoLuongPhong], [MoTa]) VALUES (N'Khoa Ngoại', 3, 5, N'Chữa trị, chuẩn đoán nhưng bệnh bên ngoài cơ thê ')
INSERT [dbo].[Khoa] ([Khoa], [Tang], [SoLuongPhong], [MoTa]) VALUES (N'Khoa Nhi', 4, 5, N'Chữa trị, chuẩn đoán cho đối tượng trẻ em')
INSERT [dbo].[Khoa] ([Khoa], [Tang], [SoLuongPhong], [MoTa]) VALUES (N'Khoa Nội', 2, 5, N'Chữa trị, chuẩn đoán nhưng bệnh bên trong cơ thê ')
INSERT [dbo].[Khoa] ([Khoa], [Tang], [SoLuongPhong], [MoTa]) VALUES (N'Khoa Sản', 5, 5, N'Chữa trị, chuẩn đoán, đỡ đẻ cho phụ nữ co thai')

INSERT [dbo].[NhaCungCapThuoc] ([NhaCungCap], [DiaChi], [SDT]) VALUES (N'Công ty dược ACP', N'Hai Bà Trưng, Hà Nội', N'0412345677')
INSERT [dbo].[NhaCungCapThuoc] ([NhaCungCap], [DiaChi], [SDT]) VALUES (N'Công ty dược Hà Nam', N'Phủ Lý, Hà Nam', N'02263899412')
INSERT [dbo].[NhaCungCapThuoc] ([NhaCungCap], [DiaChi], [SDT]) VALUES (N'Công ty dược Habeco', N'q.Tân Bình, Hồ Chí Minh', N'0212345678')
INSERT [dbo].[NhaCungCapThuoc] ([NhaCungCap], [DiaChi], [SDT]) VALUES (N'Công ty Phú Minh', N'q.Gò Vấp, Hồ Chí Minh', N'0213857959')

INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV001', N'Nguyễn Lâm Tùng', N'Nam', CAST(0xE3150B00 AS Date), N'Bác Sỹ', N'P0010')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV002', N'Nguyễn Thùy Dung', N'Nữ', CAST(0x911E0B00 AS Date), N'Y Tá', N'P0010')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV003', N'Lê Minh Anh', N'Nữ', CAST(0x0B1F0B00 AS Date), N'Y Tá', N'P0010')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV004', N'Lê Minh Như', N'Nữ', CAST(0x0B1F0B00 AS Date), N'Bác Sỹ', N'P0021')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV005', N'Phạm Minh Công', N'Nam', CAST(0x39080B00 AS Date), N'Bác Sỹ', N'P0022')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV006', N'Phạm Minh Thành', N'Nam', CAST(0xA6090B00 AS Date), N'Bác Sỹ', N'P0023')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV007', N'Phạm Thanh Xuân', N'Nữ', CAST(0xEA170B00 AS Date), N'Y Tá', N'P0023')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV008', N'Hoàng Ngọc Anh', N'Nữ', CAST(0x09180B00 AS Date), N'Y Tá', N'P0024')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV009', N'Cao Minh Anh', N'Nữ', CAST(0x21FA0A00 AS Date), N'Bác Sỹ', N'P0024')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV010', N'Trần Bình Trọng', N'Nam', CAST(0x21FA0A00 AS Date), N'Bác Sỹ', N'P0025')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV011', N'Lương Thùy Trang', N'Nữ', CAST(0x2D210B00 AS Date), N'Y Tá', N'P0025')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV012', N'Ngô Trọng Hiếu', N'Nam', CAST(0x06160B00 AS Date), N'Bác Sỹ', N'P0025')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV013', N'Nguyễn Lương Vinh', N'Nam', CAST(0x58FD0A00 AS Date), N'Bác sĩ', N'P0032')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV014', N'Lại Thị Thu', N'Nữ', CAST(0x3B000B00 AS Date), N'Y tá', N'P0031')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV015', N'Nguyễn Kiều Trinh', N'Nữ', CAST(0x9F140B00 AS Date), N'Y tá', N'P0033')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV016', N'Nguyễn Thị Kim Tuyến', N'Nữ', CAST(0x960E0B00 AS Date), N'Y tá', N'P0034')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV017', N'Đào Thị Thắm', N'Nữ', CAST(0x3B1C0B00 AS Date), N'Y tá', N'P0035')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV018', N'Nguyễn Tuấn Anh', N'Nam', CAST(0x8D0D0B00 AS Date), N'Bác sĩ', N'P0042')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV019', N'Nguyễn Thùy Linh', N'Nữ', CAST(0x4B180B00 AS Date), N'Y tá', N'P0041')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV020', N'Nguyễn Thị Phương', N'Nữ', CAST(0x3E170B00 AS Date), N'Y tá', N'P0043')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV021', N'Trần Thị Luyến', N'Nữ', CAST(0x90140B00 AS Date), N'Y tá', N'P0044')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV022', N'Ngô Ngọc Trang', N'Nữ', CAST(0xE71A0B00 AS Date), N'Y tá', N'P0045')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV023', N'Nguyễn Lương Lực', N'Nam', CAST(0x4D050B00 AS Date), N'Bác sĩ', N'P0052')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV024', N'Vũ Thị Oanh', N'Nữ', CAST(0xB21C0B00 AS Date), N'Y tá', N'P0051')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV025', N'Thiều Mai Uyên', N'Nữ', CAST(0xF6170B00 AS Date), N'Y tá', N'P0053')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV026', N'Nguyễn Thùy Chi', N'Nữ', CAST(0x321A0B00 AS Date), N'Y tá', N'P0054')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV027', N'Tăng Thanh Hà', N'Nữ', CAST(0x8F170B00 AS Date), N'Y tá', N'P0055')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV028', N'Ngỗ Đình Cương', N'Nam', CAST(0x70F60A00 AS Date), N'Bác sĩ', N'P0032')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV029', N'Lê Thị Loan', N'Nữ', CAST(0x59170B00 AS Date), N'Y tá', N'P0031')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV030', N'Trần Thị Lụa', N'Nữ', CAST(0x8F180B00 AS Date), N'Y tá', N'P0033')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV031', N'Nguyễn Thị Nhi', N'Nữ', CAST(0x65130B00 AS Date), N'Y tá', N'P0034')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV032', N'Trần Thị Huyền', N'Nữ', CAST(0xC21B0B00 AS Date), N'Y tá', N'P0035')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV033', N'Trần Tuấn Hải', N'Nam', CAST(0x54F40A00 AS Date), N'Bác sĩ', N'P0042')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV034', N'Lưu Thanh Nga', N'Nữ', CAST(0x2E130B00 AS Date), N'Y tá', N'P0041')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV035', N'Vũ Thị Thảo', N'Nữ', CAST(0x34180B00 AS Date), N'Y tá', N'P0043')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV036', N'Mai Ngọc Hiền', N'Nữ', CAST(0x311C0B00 AS Date), N'Y tá', N'P0044')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV037', N'Nguyễn Thị Mỹ Tâm', N'Nữ', CAST(0xFA1A0B00 AS Date), N'Y tá', N'P0045')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [GioiTinh], [NgaySinh], [ChucVu], [SoPhong]) VALUES (N'NV038', N'Từ Ngọc Tĩnh', N'Nam', CAST(0x71E90A00 AS Date), N'Bác sĩ', N'P0010')

INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0010', N'Khoa Cấp cứu', N'Tiếp bệnh nhân cấp cứu')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0021', N'Khoa Nội', N'Hành chính')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0022', N'Khoa Nội', N'Phòng khám')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0023', N'Khoa Nội', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0024', N'Khoa Nội', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0025', N'Khoa Nội', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0031', N'Khoa Ngoại', N'Hành chính')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0032', N'Khoa Ngoại', N'Phòng khám')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0033', N'Khoa Ngoại', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0034', N'Khoa Ngoại', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0035', N'Khoa Ngoại', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0041', N'Khoa Nhi', N'Hành chính')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0042', N'Khoa Nhi', N'Phòng khám')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0043', N'Khoa Nhi', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0044', N'Khoa Nhi', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0045', N'Khoa Nhi', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0051', N'Khoa Sản', N'Hành chính')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0052', N'Khoa Sản', N'Phòng khám')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0053', N'Khoa Sản', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0054', N'Khoa Sản', N'Điều trị')
INSERT [dbo].[Phong] ([SoPhong], [Khoa], [ChucNang]) VALUES (N'P0055', N'Khoa Sản', N'Điều trị')

INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0001', N'1', CAST(0x493C0B00 AS Date), N'Nguy Kịch')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0002', N'1', CAST(0x683C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0003', N'1', CAST(0x843C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0004', N'1', CAST(0xA33C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0005', N'1', CAST(0xC13C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0006', N'1', CAST(0xE03C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0007', N'1', CAST(0xFE3C0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0008', N'1', CAST(0x1D3D0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0009', N'1', CAST(0x3C3D0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0010', N'1', CAST(0x5A3D0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0011', N'1', CAST(0x793D0B00 AS Date), N'Nguy Kịch')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0012', N'1', CAST(0x973D0B00 AS Date), N'Bình Thường')
INSERT [dbo].[QuaTrinhDieuTri] ([MaBenhNhan], [NgayThu], [NgayNhapVien], [TinhTrang]) VALUES (N'BN0013', N'1', CAST(0x493C0B00 AS Date), N'Nguy Kịch')

INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0001', N'Nguyễn Thị Lụa', N'0974551263', N'Hai Bà Trưng,Hà Nội')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0002', N'Đinh Thị Nga', N'01636590677', N'Kim Bảng, Hà Nam')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0003', N'Vũ Văn Quyết', N'093060043', N'Thường Tín,Hà Nội')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0004', N'Nguyễn Thị Thơm', N'0124210453', N'Nghĩa Lộ,Yên Bái')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0005', N'Cao Thế Hùng', N'0914443528', N'Kim Bảng,Hà Nam')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0006', N'Nguyễn Văn Dũng', N'0915498764', N'Hưng Yên')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0007', N'Vũ Thị Mơ', N'0978569598', N'Nghi Lộc, Nghệ Tĩnh')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0008', N'Dương Văn Minh', N'0167648489', N'Từ Sơn, Bắc Ninh')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0009', N'Lại Văn Cường', N'0978494876', N'Duy Tiên, Hà Nam')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0010', N'Vũ Thế Cẩm', N'0969465321', N'Đồng Hỷ, Thái Nguyên')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0011', N'Nguyễn Đài Trang', N'01665658794', N'Hà Nam')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0012', N'Nguyễn Quang Thái', N'0913597456', N'Vĩnh Tường, Vĩnh Phúc')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0013', N'Lê Đức Thọ', N'0914585785', N'Thường Tín, Hà Nội')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0014', N'Dương Văn Tiềm', N'02283852963', N'Tam Điệp, Ninh Bình')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0015', N'Lại Văn Hùng', N'0971852345', N'Thái Bình')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0016', N'Nguyễn Thị Diễm', N'0962685742', N'Từ Sơn, Bắc Ninh')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0017', N'Đoàn Ngọc Hải', N'0912354785', N'Khoái Châu, Hưng Yên')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0018', N'Vũ Mạnh Đức', N'0913652145', N'Giao Thủy, Nam Định')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0019', N'Trần Văn Chiến', N'097415856', N'Đồng Quan, Thái Bình')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0020', N'Hùng Thế Cường', N'0978562314', N'Thủy Nguyên, Hải Phòng')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0021', N'Nguyễn Văn Tám', N'0912938122', N'Hải Dương')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0022', N'Vũ Mai Hương', N'0936254783', N'Phổ Yên, Thái Nguyên')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0023', N'Ngô Văn Dũng', N'0123425852', N'Hai Bà Trưng, Hà Nội')
INSERT [dbo].[ThanNhan] ([MaBenhNhan], [HoTenThanNhan], [SDT], [DiaChi]) VALUES (N'BN0024', N'Lê Ngọc Hải', N'0978413692', N'Ba Đình, Hà Nội')

INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0001', N'Fentany', N'ống', 180, N'Công ty dược ACP', 2000)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0002', N'Halothan', N'ông', 140, N'Công ty dược ACP', 1300)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0003', N'Acid Acetylsalicylic', N'vỉ', 80, N'Công ty dược Hà Nam', 590)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0004', N'Alimemazin', N'ống', 100, N'Công ty dược Habeco', 688)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0005', N'Deferoxamin (mesilat)', N'ống', 350, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0006', N'Atropin sulfat', N'ống', 700, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0007', N'Nimesulid', N'ống', 700, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0008', N'Alpha chymotrypsin', N'ống', 350, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0009', N'Albendazol', N'ống', 350, N'Công ty Phú Minh', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0010', N'Amoxicilin', N'ống', 350, N'Công ty Phú Minh', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0011', N'Clindamycin', N'ống', 350, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0012', N'Folic acid (Vitamin B9)', N'ống', 350, N'Công ty dược Habeco', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0013', N'Glyceryl trinitrat', N'ống', 350, N'Công ty Phú Minh', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0014', N'Amlodipin', N'ống', 350, N'Công ty Phú Minh', 1200)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonVi], [DonGia], [NhaCungCap], [SoLuong]) VALUES (N'T0015', N'Flucina', N'ống', 350, N'Công ty dược Habeco', 1200)

INSERT [dbo].[TruongKhoa] ([Khoa], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Khoa Cấp cứu', N'Nguyễn Tài Thu', N'Nam', CAST(0x27EC0A00 AS Date), N'Ba Đình, Hà Nội', N'0971985391')
INSERT [dbo].[TruongKhoa] ([Khoa], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Khoa Ngoại', N'Nguyễn Lương Vinh', N'Nam', CAST(0x58FD0A00 AS Date), N'Mỹ Đình, Hà Nội', N'091358754')
INSERT [dbo].[TruongKhoa] ([Khoa], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Khoa Nhi', N'Nguyễn Tuấn Anh', N'Nam', CAST(0x8D0D0B00 AS Date), N'Hai Bà Trưng, Hà Nội', N'0963582492')
INSERT [dbo].[TruongKhoa] ([Khoa], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Khoa Nội', N'Nguyễn Lương Lực', N'Nam', CAST(0x4D050B00 AS Date), N'Thanh Nhàn, Hà Nội', N'0917238546')
INSERT [dbo].[TruongKhoa] ([Khoa], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [SDT]) VALUES (N'Khoa Sản', N'Thiều Bảo Tâm', N'Nữ', CAST(0x1CDE0A00 AS Date), N'Long Biên, Hà Nội', N'0984998884')

INSERT [dbo].[Users] ([ID], [Ten], [MatKhau]) VALUES (1, N'NV', N'123')
INSERT [dbo].[Users] ([ID], [Ten], [MatKhau]) VALUES (2, N'DS', N'123')
INSERT [dbo].[Users] ([ID], [Ten], [MatKhau]) VALUES (3, N'QT', N'123')

-- # Tạo khóa ngoài cho các bảng

ALTER TABLE [QuaTrinhDieuTri] 
ADD CONSTRAINT [FK_QuaTrinhDieuTri_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO


ALTER TABLE [ThanNhan] 
ADD CONSTRAINT [FK_ThanNhan_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO

ALTER TABLE [BHYT] 
ADD CONSTRAINT [FK_BHYT_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO

ALTER TABLE [Giuong] 
ADD CONSTRAINT [FK_Giuong_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO

ALTER TABLE [BenhAn] 
ADD CONSTRAINT [FK_BenhAn_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO

ALTER TABLE [GiayRaVien] 
ADD CONSTRAINT [FK_GiayRaVien_BenhNhan] 
FOREIGN KEY 			
( MaBenhNhan )									
REFERENCES [BenhNhan] 						
( MaBenhNhan )									
GO

--

ALTER TABLE [CaTruc] 
ADD CONSTRAINT [FK_CaTruc_NhanVien] 
FOREIGN KEY 			
( MaNhanVien )									
REFERENCES [NhanVien] 						
( MaNhanVien )									
GO

--

ALTER TABLE [Thuoc] 
ADD CONSTRAINT [FK_Thuoc_NhaCungCapThuoc] 
FOREIGN KEY 			
( NhaCungCap )									
REFERENCES [NhaCungCapThuoc] 						
( NhaCungCap )									
GO

--

ALTER TABLE [NhanVien] 
ADD CONSTRAINT [FK_NhanVien_Phong] 
FOREIGN KEY 			
( SoPhong )									
REFERENCES [Phong] 						
( SoPhong )									
GO

ALTER TABLE [Giuong] 
ADD CONSTRAINT [FK_Giuong_Phong] 
FOREIGN KEY 			
( SoPhong )									
REFERENCES [Phong] 						
( SoPhong )									
GO

--

ALTER TABLE [Phong] 
ADD CONSTRAINT [FK_Phong_Khoa] 
FOREIGN KEY 			
( Khoa )									
REFERENCES [Khoa] 						
( Khoa )									
GO

ALTER TABLE [TruongKhoa] 
ADD CONSTRAINT [FK_TruongKhoa_Khoa] 
FOREIGN KEY 			
( Khoa )									
REFERENCES [Khoa] 						
( Khoa )									
GO

--

ALTER TABLE [BenhAn] 
ADD CONSTRAINT [FK_BenhAn_BenhLy] 
FOREIGN KEY 			
( MaBenh )									
REFERENCES [BenhLy] 						
( MaBenh )									
GO

ALTER TABLE [ChiPhiBenh] 
ADD CONSTRAINT [FK_ChiPhiBenh_BenhLy] 
FOREIGN KEY 			
( MaBenh )									
REFERENCES [BenhLy] 						
( MaBenh )									
GO

--

ALTER TABLE [GiayRaVien]
ADD CONSTRAINT [FK_GiayRaVien_DichVu]
FOREIGN KEY
(MaDichVu)
REFERENCES [DichVu]
(MaDichVu)

--

ALTER TABLE [GiayRaVien]
ADD CONSTRAINT [FK_GiayRaVien_CoSoYTe]
FOREIGN KEY
(MaCoSo)
REFERENCES [CoSoYTe]
(MaCoSo)

--

--# Hàm, View, Proc
-- #Function:
--1. Tích
GO
CREATE FUNCTION Tich
(@a FLOAT, @b FLOAT)
RETURNS FLOAT
AS
BEGIN
	RETURN @a*@b
END
GO

--2. Tổng:
GO
CREATE FUNCTION Tong
(@a FLOAT, @b FLOAT)
RETURNS FLOAT
AS
BEGIN
	RETURN @a+@b
END
GO

--3. Tính Tuổi:
GO
CREATE FUNCTION TinhTuoi
(@a DATE)
RETURNS FLOAT
AS
BEGIN
	RETURN YEAR(GETDATE()) - YEAR(@a)
END
GO

--#View:
--1. Xem thông tin tất cả bệnh nhân
GO
CREATE VIEW View_ThongTinBenhNhan
AS
select	BenhNhan.MaBenhNhan as N'Mã Bệnh Nhân',
	HoTen as N'Họ Và Tên',
	NgaySinh as N'Ngày Sinh',
	NgheNghiep as N'Nghề Nghiệp',
	DiaChi as N'Địa Chỉ',
	SoGiuong N'Số Giường',
	SoPhong as N'Số Phòng'
from	benhnhan, Giuong
where	BenhNhan.MaBenhNhan = Giuong.MaBenhNhan
GO

--2. xem thông tin tất cả nhân viên
GO
create view [view_ThongTinNhanVien]
as
Select	MaNhanVien as 'Mã Nhân Viên',	
HoTen as N'Họ Tên',
	GioiTinh as N'Giới Tính',
	NgaySinh as N'Ngày Sinh',
	ChucVu as N'Chức Vụ',
	SoPhong as N'Số Phòng'
from	NhanVien
GO

--3. xem thông tin thuốc:
GO
CREATE VIEW view_ThongTinThuoc
AS
SELECT	MaThuoc as N'Mã Thuốc',
		TenThuoc as N'Tên Thuốc',
		DonVi as N'Đơn Vị',
		DonGia as N'Đơn Giá',
		NhaCungCap as N'Nhà Cung Cấp',
		SoLuong as N'Số lượng còn lại'
FROM Thuoc
GO

--4. Thông tin nhà cung cấp:
GO
CREATE VIEW view_ThongTinNhaCungCap
AS
SELECT	NhaCungCap as N'Nhà Cung Cấp',
		DiaChi as N'Địa Chỉ',
		SDT as N'Số Điện Thoại'
FROM NhaCungCapThuoc
GO

--5. Cơ sở y tế:
GO
CREATE VIEW view_CoSoYTe
AS
SELECT	MaCoSo as N'Mã Cơ Sở',
		TenCoSo as N'Tên Cơ Sở',
		DiaChi as N'Địa Chỉ'
FROM CoSoYTe
GO

--6. Khoa:
GO
CREATE VIEW view_Khoa
AS
SELECT	Khoa as 'Khoa',
		Tang as N'Tầng',
		SoLuongPhong as N'Số Lượng Phòng',
		MoTa as N'Mô Tả'
FROM Khoa
GO

--7. Dịch Vụ:
GO
CREATE VIEW view_DichVu
AS
SELECT	MaDichVu as N'Mã Dịch Vụ',
		TenDichVu as N'Tên Dịch Vụ',
		DonGia as N'Đơn Giá'
FROM DichVu
GO

--8. Ca Trực:
GO
CREATE VIEW view_CaTruc
AS
SELECT	NhanVien.MaNhanVien as N'Mã Nhân Viên',
		NhanVien.HoTen as N'Họ Tên', 
		CaTruc.Ngay as N'Ngày', 
		Ca as N'Ca Trực'
FROM	CaTruc,NhanVien
WHERE	CaTruc.MaNhanVien = NhanVien.MaNhanVien
GO

--9. Giấy Ra Viện:
GO
CREATE VIEW View_GiayRaVien
AS
SELECT	MaBenhNhan as N'Mã Bệnh Nhân',
		CoSoYTe.TenCoSo as N'Tên Cơ Sở',
		DichVu.TenDichVu as N'Tên Dịch Vụ',
		KetQua as N'Kết Quả',
		LoiKhuyen as N'Lời Khuyên'
FROM	GiayRaVien,CoSoYTe,DichVu
WHERE	GiayRaVien.MaCoSo = CoSoYTe.MaCoSo
		AND GiayRaVien.MaDichVu = DichVu.MaDichVu
GO

--#Proc:
--1. Tra cứu bệnh nhân theo tên
GO
CREATE PROCEDURE Proc_ThongTinBenhNhan
(@Ten nvarchar(30))
AS
BEGIN
	select		BenhNhan.MaBenhNhan as N'Mã Bệnh Nhân',
			HoTen as N'Họ Và Tên',
			NgaySinh as N'Ngày Sinh',
			NgheNghiep as N'Nghề Nghiệp',
			DiaChi as N'Địa Chỉ',
			SoGiuong N'Số Giường',
			SoPhong as N'Số Phòng'
	from	benhnhan, Giuong
	where	BenhNhan.MaBenhNhan = Giuong.MaBenhNhan
			and HoTen like @Ten
END
GO

--2. Tra cứu nhân viên theo tên:
GO
CREATE PROCEDURE [Proc_ThongTinNhanVien]
(@Ten nvarchar(30))
AS
BEGIN
	Select	HoTen as N'Họ Tên',
			GioiTinh as N'Giới Tính',
			NgaySinh as N'Ngày Sinh',
			ChucVu as N'Chức Vụ',
			SoPhong as N'Số Phòng'
	from	NhanVien
	where	HoTen like @Ten
END
GO

--3. Xem thông tin trong phòng có những nhân viên nào
GO
CREATE PROC Proc_ThongTinNhanVienPhong
(@SoPhong nvarchar(30))
AS
BEGIN
	SELECT	HoTen as N'Họ Tên',
		ChucVu as N'Chức Vụ'
	FROM	NhanVien
	WHERE	SoPhong like @SoPhong
END
GO

--4. Xem trong phòng có những bệnh nhân nào:
GO
CREATE PROC Proc_ThongTinBenhNhanPhong
(@SoPhong nvarchar(30))
AS
BEGIN
	SELECT	HoTen as N'Họ Tên',
			GioiTinh as N'Giới Tính',
			NgheNghiep as N'Nghề Nghiệp'
	FROM	BenhNhan, Giuong
	WHERE	BenhNhan.MaBenhNhan = Giuong.MaBenhNhan
			AND Giuong.SoPhong like @SoPhong
END
GO

--5. Thêm bệnh nhân:
GO
CREATE PROC Proc_ThemBenhNhan
(@MaBenhNhan nvarchar(30), @TenBenhNhan nvarchar(30), @NgaySinh Date, @GioiTinh nvarchar(30), @NgheNghiep nvarchar(30), @DiaChi nvarchar(30))
AS
BEGIN
	INSERT INTO BenhNhan 
	VALUES (@MaBenhNhan, @TenBenhNhan, @NgaySinh, @GioiTinh, @NgheNghiep, @DiaChi)
END
GO

--6. Thêm thân nhân:
GO
CREATE PROC Proc_ThemThanNhan
(@MaBenhNhan nvarchar(30), @Ten nvarchar(30), @SDT nvarchar(30), @DiaChi nvarchar(30))
AS
BEGIN
	INSERT INTO ThanNhan
	VALUES (@MaBenhNhan, @Ten, @SDT, @DiaChi)
END
GO

--7. thêm bệnh án:
GO
CREATE PROC Proc_ThemBenhAn
(@MaBenhNhan nvarchar(30), @SoBenhAn nvarchar(30), @LoaiBenhAn nvarchar(30), @MaBenh nvarchar(30))
AS
BEGIN
	INSERT INTO BenhAn
	VALUES (@MaBenhNhan, @SoBenhAn, @LoaiBenhAn, @MaBenh)
END
GO

--8. Xem thông tin thuốc:
GO
CREATE PROC Proc_ThongTinThuoc
(@TenThuoc nvarchar(30))
AS
BEGIN
SELECT	MaThuoc as N'Mã Thuốc',
		TenThuoc as N'Tên Thuốc',
		DonVi as N'Đơn Vị',
		DonGia as N'Đơn Giá',
		NhaCungCap as N'Nhà Cung Cấp',
		SoLuong as N'Số Lượng'
FROM Thuoc
WHERE TenThuoc = @TenThuoc
END
GO

--9. Cập nhật tình trạng
GO
CREATE PROC Proc_QuaTrinhDieuTri
(@MaBenhNhan nvarchar(30), @Ngay int, @NhapVien Date, @TinhTrang nvarchar(30))
AS
BEGIN
	INSERT INTO QuaTrinhDieuTri
	VALUES (@MaBenhNhan,@Ngay,@NhapVien,@TinhTrang) 
END
GO

--10. Xem giá Dịch Vụ
GO
CREATE PROC Proc_XemGiaDichVu
(@Ten nvarchar(30))
AS
BEGIN
	SELECT *
	FROM DichVu
	WHERE TenDichVu = @Ten
END
GO

--11. Xem số bệnh nhân nguy kịch hôm nay
GO
CREATE PROC Proc_ThongKe_BenhNhanNguyKich
AS
BEGIN
SELECT COUNT(DISTINCT MaBenhNhan) as N'Số Bệnh Nhân Nguy Kịch'
FROM QuaTrinhDieuTri
WHERE	TinhTrang = N'Nguy Kịch'
		AND NgayNhapVien = GETDATE()
END
GO

--12. Xem số bệnh nhân tử vong
GO
CREATE PROC Proc_ThongKe_SoBenhNhanTuVong
(@M int)
AS
BEGIN
	SELECT COUNT(MaBenhNhan) as N'Số Bệnh Nhân Tử Vong'
	FROM QuaTrinhDieuTri
	WHERE	TinhTrang = N'Tử Vong'
			AND MONTH(NgayNhapVien) = @M
END
GO

--13. Người già nhất mắc bệnh
GO
CREATE PROC Proc_ThongKe_TuoiCaoNhatMacBenh
(@Benh nvarchar(30))
AS
BEGIN
SELECT TOP 1 dbo.TinhTuoi(NgaySinh) as N'Tuổi'
FROM BenhNhan, BenhAn
WHERE	BenhNhan.MaBenhNhan = BenhAn.MaBenhNhan
		AND MaBenh =	( 
						SELECT BenhLy.MaBenh
						FROM BenhLy
						WHERE BenhLy.TenBenh = @Benh
						)
ORDER BY dbo.TinhTuoi(NgaySinh) DESC
END
GO

--14. Người trẻ nhất mắc bệnh
GO
CREATE PROC Proc_ThongKe_TuoiTreNhatMacBenh
(@Benh nvarchar(30))
AS
BEGIN
SELECT TOP 1 YEAR(GETDATE()) - YEAR(NgaySinh) as N'Tuổi'
FROM BenhNhan, BenhAn
WHERE	BenhNhan.MaBenhNhan = BenhAn.MaBenhNhan
		AND MaBenh =	( 
						SELECT BenhLy.MaBenh
						FROM BenhLy
						WHERE BenhLy.TenBenh = @Benh
						)
ORDER BY YEAR(GETDATE()) - YEAR(NgaySinh) ASC
END
GO

--15. Xem bệnh mắc nhiều nhất tháng:
GO
CREATE PROC Proc_ThongKe_BenhMacNhieuNhat
(@M int)
AS
BEGIN
SELECT TenBenh
FROM BenhLy
WHERE MaBenh = (	SELECT TOP 1 BenhAn.MaBenh
			FROM		QuaTrinhDieuTri, BenhAn
			WHERE		QuaTrinhDieuTri.MaBenhNhan = BenhAn.MaBenhNhan
					AND QuaTrinhDieuTri.NgayThu = 1
					AND MONTH(NgayNhapVien) = @M
			GROUP BY MaBenh
			ORDER BY COUNT(MaBenh) DESC)
END
GO

--16. Tuổi mắc bệnh:
GO
CREATE PROC Proc_TuoiMacBenh
(@Benh nvarchar(30))
AS
BEGIN
	SELECT dbo.TinhTuoi(NgaySinh) as N'Tuổi'
	FROM BenhNhan, BenhAn
	WHERE	BenhNhan.MaBenhNhan = BenhAn.MaBenhNhan
			AND MaBenh =	( 
							SELECT BenhLy.MaBenh
							FROM BenhLy
							WHERE BenhLy.TenBenh = @Benh
							)
END
GO

--17. Tìm ca trực theo tên:
GO
CREATE PROC Proc_CaTruc
(@Ten nvarchar(30))
AS
BEGIN
	SELECT	NhanVien.MaNhanVien as N'Mã Nhân Viên',
			NhanVien.HoTen as N'Họ Tên', 
			CaTruc.Ngay as N'Ngày', 
			Ca as N'Ca Trực'
	FROM	CaTruc,NhanVien
	WHERE	CaTruc.MaNhanVien = NhanVien.MaNhanVien
			AND NhanVien.HoTen like @Ten
END
GO

--18. TÌm ca trực theo ngày:
GO
CREATE PROC Proc_CaTruc_2
(@Ngay nvarchar(30))
AS
BEGIN
	SELECT	NhanVien.MaNhanVien as N'Mã Nhân Viên',
			NhanVien.HoTen as N'Họ Tên', 
			CaTruc.Ngay as N'Ngày', 
			Ca as N'Ca Trực'
	FROM	CaTruc,NhanVien
	WHERE	CaTruc.MaNhanVien = NhanVien.MaNhanVien
			AND CaTruc.Ngay = @Ngay
END
GO

--19. In giấy ra viện theo mã bệnh nhân:
GO
CREATE PROC Proc_GiayRaVien
(@Ma nvarchar(30))
AS
BEGIN
	SELECT	MaBenhNhan as N'Mã Bệnh Nhân',
			CoSoYTe.TenCoSo as N'Tên Cơ Sở',
			DichVu.TenDichVu as N'Tên Dịch Vụ',
			KetQua as N'Kết Quả',
			LoiKhuyen as N'Lời Khuyên'
	FROM	GiayRaVien,CoSoYTe,DichVu
	WHERE	GiayRaVien.MaCoSo = CoSoYTe.MaCoSo
			AND GiayRaVien.MaDichVu = DichVu.MaDichVu
			AND MaBenhNhan = @Ma
END
GO