USE [master]
GO

CREATE DATABASE [QuanLyNhaSach]
GO

USE [QuanLyNhaSach]
GO

SET DATEFORMAT DMY;
GO

CREATE TABLE [dbo].[THELOAI]
(
	[MaTheLoai]		[int]				NOT NULL IDENTITY(1, 1),
	[TenTheLoai]	[nvarchar](50)		NOT NULL,
	CONSTRAINT [PK_THELOAI] PRIMARY KEY ([MaTheLoai])
)
GO

CREATE TABLE [dbo].[DAUSACH] 
(
	[MaDauSach]		[int]				NOT NULL IDENTITY(1, 1),
	[TenDauSach]	[nvarchar](200)		NOT NULL,
	[MaTheLoai]		[int]				NOT NULL,
	CONSTRAINT [PK_DAUSACH] PRIMARY KEY ([MaDauSach])
)
GO

CREATE TABLE [dbo].[CT_TACGIA] 
(
	[MaDauSach]		[int]				NOT NULL,
	[TacGia]		[nvarchar](50)		NOT NULL,
	CONSTRAINT [PK_CT_TACGIA] PRIMARY KEY ([MaDauSach], [TacGia])
)
GO

CREATE TABLE [dbo].[SACH] 
(
	[MaSach]		[int]				NOT NULL IDENTITY(1, 1),
	[MaDauSach]		[int]				NOT NULL,
	[NhaXuatBan]	[nvarchar](200)		NOT NULL,
	[NamXuatBan]	[int]				NOT NULL,
	[SoLuongTon]	[int]				NOT NULL,
	[DonGiaBan]		[int]				NOT NULL,
	CONSTRAINT [PK_SACH] PRIMARY KEY ([MaSach])
)
GO

CREATE TABLE [dbo].[PHIEUNHAPSACH]
(
	[SoPNS]		[int]	NOT NULL IDENTITY(1, 1),
	[NgayLap]	[date]	NOT NULL,
	[TongTien]	[int]	NOT NULL DEFAULT 0,
	CONSTRAINT [PK_PHIEUNHAPSACH] PRIMARY KEY ([SoPNS])
)
GO

CREATE TABLE [dbo].[CT_PHIEUNHAPSACH]
(
	[SoPNS]			[int]	NOT NULL,
	[MaSach]		[int]	NOT NULL,
	[SoLuongNhap]	[int]	NOT NULL,
	[DonGiaNhap]	[int]	NOT NULL,
	[ThanhTien]		[int]	NOT NULL,
	CONSTRAINT [PK_CT_PHIEUNHAPSACH] PRIMARY KEY ([SoPNS], [MaSach])
)
GO

CREATE TABLE [dbo].[KHACHHANG]
(
	[MaKhachHang]	[int]			NOT NULL IDENTITY(1, 1),
	[TenKhachHang]	[nvarchar](50)	NOT NULL,
	[DiaChi]		[nvarchar](200)	NOT NULL,
	[SDT]			[nvarchar](15)	NOT NULL,
	[Email]			[nvarchar](50)	NOT NULL,
	[SoTienNo]		[int]			NOT NULL DEFAULT 0,
	CONSTRAINT [PK_KHACHHANG] PRIMARY KEY ([MaKhachHang])
)
GO

CREATE TABLE [dbo].[HOADON]
(
	[SoHD]			[int]	NOT NULL IDENTITY(1, 1),
	[MaKhachHang]	[int]	NOT NULL,
	[NgayLap]		[date]	NOT NULL,
	[TongTien]		[int]	NOT NULL DEFAULT 0,
	[ThanhToan]		[int]	NOT NULL DEFAULT 0,
	[ConLai]		[int]	NOT NULL DEFAULT 0,
	CONSTRAINT [PK_HOADON] PRIMARY KEY ([SoHD])
)
GO

CREATE TABLE [dbo].[CT_HOADON]
(
	[SoHD]			[int]	NOT NULL,
	[MaSach]		[int]	NOT NULL,
	[SoLuong]		[int]	NOT NULL,
	[DonGia]		[int]	NOT NULL,
	[ThanhTien]		[int]	NOT NULL,
	CONSTRAINT [PK_CT_HOADON] PRIMARY KEY ([SoHD], [MaSach])
)
GO

CREATE TABLE [dbo].[PHIEUTHUTIEN]
(
	[SoPT]			[int]	NOT NULL IDENTITY(1, 1),
	[MaKhachHang]	[int]	NOT NULL,
	[NgayLap]		[date]	NOT NULL,
	[SoTienThu]		[int]	NOT NULL DEFAULT 0,
	CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY ([SoPT])
)
GO

CREATE TABLE [dbo].[BAOCAOTON]
(
	[Thang]			[int]	NOT NULL,
	[Nam]			[int]	NOT NULL,
	[MaSach]		[int]	NOT NULL,
	[TonDau]		[int]	NOT NULL,
	[PhatSinh]		[int]	NOT NULL,
	[TonCuoi]		[int]	NOT NULL,
	CONSTRAINT [PK_BAOCAOTON] PRIMARY KEY ([Thang], [Nam], [MaSach])
)
GO

CREATE TABLE [dbo].[BAOCAOCONGNO]
(
	[Thang]			[int]	NOT NULL,
	[Nam]			[int]	NOT NULL,
	[MaKhachHang]	[int]	NOT NULL,
	[NoDau]			[int]	NOT NULL,
	[PhatSinh]		[int]	NOT NULL,
	[NoCuoi]		[int]	NOT NULL,
	CONSTRAINT [PK_BAOCAOCONGNO] PRIMARY KEY ([Thang], [Nam], [MaKhachHang])
)
GO

CREATE TABLE [dbo].[THAMSO]
(
	[TenThamSo]		[nvarchar](200)		NOT NULL,
	[GiaTri]		[int]				NOT NULL,
	CONSTRAINT [PK_THAMSO] PRIMARY KEY ([TenThamSo])
)
GO

CREATE TABLE [dbo].[TAIKHOAN]
(
	[TenDangNhap]	[varchar](50)	NOT NULL,
	[TenHienThi]	[nvarchar](200) NOT NULL,	
	[MatKhau]		[varchar](50)	NOT NULL,
	[PhanQuyen]		[int]			NOT NULL, --- 1. Chủ nhà sách / 2. Nhân viên
	CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY ([TenDangNhap])
)
GO

ALTER TABLE [dbo].[DAUSACH] ADD CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY ([MaTheLoai]) REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[CT_TACGIA] ADD CONSTRAINT [FK_CT_TACGIA_DAUSACH] FOREIGN KEY ([MaDauSach]) REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] ADD CONSTRAINT [FK_SACH_DAUSACH] FOREIGN KEY ([MaDauSach]) REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH] ADD CONSTRAINT [FK_CT_PHIEUNHAPSACH_PHIEUNHAPSACH] FOREIGN KEY ([SoPNS]) REFERENCES [dbo].[PHIEUNHAPSACH] ([SoPNS])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAPSACH] ADD CONSTRAINT [FK_CT_PHIEUNHAPSACH_SACH] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[HOADON] ADD CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[CT_HOADON] ADD CONSTRAINT [FK_CT_HOADON_HOADON] FOREIGN KEY ([SoHD]) REFERENCES [dbo].[HOADON] ([SoHD])
GO
ALTER TABLE [dbo].[CT_HOADON] ADD CONSTRAINT [FK_CT_HOADON_SACH] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] ADD CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[BAOCAOTON] ADD CONSTRAINT [FK_BAOCAOTON_SACH] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[BAOCAOCONGNO] ADD CONSTRAINT [FK_BAOCAOCONGNO_KHACHHANG] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO

INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'TiLeTinhDonGiaBan', 105)
GO
INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'SoLuongNhapToiThieu', 150)
GO
INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'SoLuongTonToiThieuSauBan', 20)
GO
INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'SoLuongTonToiDaTruocNhap', 300)
GO
INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'SoTienNoToiDa', 20000)
GO
INSERT INTO [THAMSO] ([TenThamSo], [GiaTri]) VALUES (N'ApDungQD4', 1)
GO

INSERT INTO [TAIKHOAN] ([TenDangNhap], [TenHienThi], [MatKhau], [PhanQuyen]) VALUES ('admin', N'Ông chủ', '1', 1)
GO
INSERT INTO [TAIKHOAN] ([TenDangNhap], [TenHienThi], [MatKhau], [PhanQuyen]) VALUES ('employee', N'Nhân viên A', '1', 2)
GO

select * from [TAIKHOAN]