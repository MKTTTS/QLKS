USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 12/23/2020 8:13:21 AM ******/
CREATE DATABASE [QLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKS', N'ON'
GO
ALTER DATABASE [QLKS] SET QUERY_STORE = OFF
GO
USE [QLKS]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHD]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDHD]()
RETURNS CHAR(8)
AS
BEGIN
	DECLARE @ID CHAR(8)
	IF (SELECT COUNT(MaHD) FROM HoaDon) = 0
		begin
		SET @ID = 'HD000001'
		end
	ELSE
		begin
		SELECT @ID = MAX(RIGHT(MaHD, 6)) FROM HoaDon
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 and @ID < 99 THEN 'HD0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 and @ID < 999 THEN 'HD000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 and @ID < 9999 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 and @ID < 99999 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 THEN 'HD' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
		end
	RETURN @ID
END
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[UserName] [char](13) NOT NULL,
	[PassWords] [char](16) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaDat] [char](10) NOT NULL,
	[MaPhong] [char](7) NULL,
	[SoDT] [char](10) NULL,
	[TienCoc] [int] NULL,
	[NgaySuDung] [date] NULL,
	[NgayKetThuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](8) NOT NULL,
	[MaNV] [char](7) NULL,
	[SoDT] [char](10) NULL,
	[NgayLap] [date] NULL,
	[TongTien] [int] NULL,
	[DaThanhToan] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[TenKH] [nvarchar](27) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [char](3) NULL,
	[SoCMT] [char](9) NULL,
	[SoDT] [char](10) NOT NULL,
	[QueQuan] [char](7) NULL,
	[QuocTich] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](7) NOT NULL,
	[UserName] [char](13) NULL,
	[HoTen] [char](27) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [char](3) NULL,
	[SoCMT] [char](9) NULL,
	[DiaChi] [char](50) NULL,
	[SDT] [char](10) NULL,
	[ChucVu] [char](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [char](7) NOT NULL,
	[LoaiPhong] [char](5) NULL,
	[GiaPhong] [int] NULL,
	[TinhTrang] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[MaThue] [char](8) NULL,
	[SoDT] [char](10) NULL,
	[MaPhong] [char](7) NULL,
	[NgayThue] [date] NULL,
	[NgayTraPhong] [date] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'admin1       ', N'1               ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'admin2       ', N'1               ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'manhson99    ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'trivan77     ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'vankien99    ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'xuantung98   ', N'123456          ')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SoDT], [NgayLap], [TongTien], [DaThanhToan]) VALUES (N'HD000002', N'LT001  ', N'0912193236', CAST(N'2020-11-25' AS Date), 1600000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SoDT], [NgayLap], [TongTien], [DaThanhToan]) VALUES (N'HD000003', N'LT001  ', N'0912834753', CAST(N'2020-11-25' AS Date), 3600000, 1)
GO
INSERT [dbo].[KhachHang] ([TenKH], [NgaySinh], [GioiTinh], [SoCMT], [SoDT], [QueQuan], [QuocTich]) VALUES (N'Tran Bao Thanh', CAST(N'1970-02-23' AS Date), N'Nam', N'187622364', N'0912193236', N'Ha Tinh', NULL)
INSERT [dbo].[KhachHang] ([TenKH], [NgaySinh], [GioiTinh], [SoCMT], [SoDT], [QueQuan], [QuocTich]) VALUES (N'Cristiano Ronaldo', CAST(N'1985-02-05' AS Date), N'Nam', NULL, N'0912834753', NULL, N'Portugal')
INSERT [dbo].[KhachHang] ([TenKH], [NgaySinh], [GioiTinh], [SoCMT], [SoDT], [QueQuan], [QuocTich]) VALUES (N'Nguyen Thi Bay', CAST(N'1972-05-19' AS Date), N'Nu ', N'187633465', N'0974162436', N'Nghe An', NULL)
GO
INSERT [dbo].[NhanVien] ([MaNV], [UserName], [HoTen], [NgaySinh], [GioiTinh], [SoCMT], [DiaChi], [SDT], [ChucVu]) VALUES (N'LT001  ', N'manhson99    ', N'Nguyen Manh Son            ', CAST(N'1999-01-20' AS Date), N'Nam', N'187688374', N'Hai Phong                                         ', N'0974163435', N'Le Tan      ')
INSERT [dbo].[NhanVien] ([MaNV], [UserName], [HoTen], [NgaySinh], [GioiTinh], [SoCMT], [DiaChi], [SDT], [ChucVu]) VALUES (N'LT002  ', N'vankien99    ', N'Nguyen Van Kien            ', CAST(N'1999-09-06' AS Date), N'Nam', N'187633463', N'Hung Yen                                          ', N'0912342387', N'Le Tan      ')
INSERT [dbo].[NhanVien] ([MaNV], [UserName], [HoTen], [NgaySinh], [GioiTinh], [SoCMT], [DiaChi], [SDT], [ChucVu]) VALUES (N'LT003  ', N'xuantung98   ', N'Dinh Xuan Tung             ', CAST(N'1998-04-15' AS Date), N'Nam', N'189733475', N'Ha Noi                                            ', N'0912349875', N'Le Tan      ')
INSERT [dbo].[NhanVien] ([MaNV], [UserName], [HoTen], [NgaySinh], [GioiTinh], [SoCMT], [DiaChi], [SDT], [ChucVu]) VALUES (N'QL001  ', N'trivan77     ', N'Tran Bao Tri               ', CAST(N'1999-10-01' AS Date), N'Nam', N'187699495', N'Nghe An                                           ', N'0868994610', N'Quan Ly     ')
GO
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'111    ', N'2    ', 500000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'112    ', N'3    ', 650000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'113    ', N'2    ', 600000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'211    ', N'2    ', 550000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'212    ', N'3    ', 800000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'213    ', N'2    ', 700000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'214    ', N'3    ', 900000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'311    ', N'2    ', 600000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'312    ', N'2    ', 750000, N'Trong     ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'313    ', N'3    ', 800000, N'Trong     ')
GO
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00001  ', N'0974162436', N'111    ', CAST(N'2020-10-25' AS Date), CAST(N'2020-10-28' AS Date))
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00002  ', N'0912193236', N'212    ', CAST(N'2020-11-03' AS Date), CAST(N'2020-11-05' AS Date))
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00003  ', N'0912834753', N'214    ', CAST(N'2020-10-30' AS Date), CAST(N'2020-11-03' AS Date))
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [DaThanhToan]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([SoDT])
REFERENCES [dbo].[KhachHang] ([SoDT])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([UserName])
REFERENCES [dbo].[DangNhap] ([UserName])
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD FOREIGN KEY([SoDT])
REFERENCES [dbo].[KhachHang] ([SoDT])
GO
/****** Object:  StoredProcedure [dbo].[CHECKCMND]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CHECKCMND] @cmnd nvarchar(15)
AS
BEGIN
SELECT
CASE
WHEN EXISTS(SELECT * FRom NhanVien WHERE NhanVien.SoCMT = @cmnd) THEN 1
WHEN NOT EXISTS(SELECT * FRom NhanVien WHERE NhanVien.SoCMT = @cmnd) THEN 0
END AS TonTai
END
GO
/****** Object:  StoredProcedure [dbo].[HistoryOfCustomer]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HistoryOfCustomer]
@sdt varchar(10)
AS
BEGIN
	SELECT ThuePhong.MaPhong as N'Phòng', ThuePhong.NgayThue as N'Ngày thuê', ThuePhong.NgayTraPhong as N'Ngày trả phòng'
	FROM ThuePhong WHERE ThuePhong.SoDT = @sdt
END
GO
/****** Object:  StoredProcedure [dbo].[HistoryOfRoom]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HistoryOfRoom]
@maphong varchar(7),
@from date,
@to date
AS
BEGIN
	SELECT ThuePhong.SoDT as N'Số điện thoại', TenKH as 'Họ tên người thuê', NgayThue as N'Ngày thuê', NgayTraPhong as N'Ngày trả phòng'
	FROM ThuePhong LEFT JOIN KhachHang ON ThuePhong.SoDT = KhachHang.SoDT
	WHERE (DATEDIFF(Day, @from, NgayThue)) >= 0 AND (DATEDIFF(Day, @to, NgayThue)) < 0 AND ThuePhong.MaPhong = @maphong
END
GO
/****** Object:  StoredProcedure [dbo].[MANVMAX]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MANVMAX]
@chucvu char(12)
AS
BEGIN
	IF (EXISTS (SELECT * FROM NhanVien WHERE ChucVu = @chucvu))
	BEGIN
	SELECT TOP(1)(CAST(RIGHT(MaNV, 5) AS INT)) as MaLonNhat FROM NHANVIEN WHERE ChucVu = @chucvu ORDER BY (CAST(RIGHT(MaNV, 5) AS INT)) DESC
	END
	ELSE
	BEGIN
	SELECT 0 as MaLonNhat
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SEARCHPHONG]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SEARCHPHONG]
@trangthai1 varchar(10),
@trangthai2 varchar(10),
@trangthai3 varchar(10),
@maphong varchar(7)
AS
BEGIN
	
	SELECT Phong.MaPhong as N'Phòng', Phong.LoaiPhong as N'Loại phòng', Phong.GiaPhong as N'Giá phòng', Phong.TinhTrang as N'Tình trạng'
	FROM Phong 
	WHERE (TinhTrang = @trangthai1 OR TinhTrang = @trangthai2 OR TinhTrang = @trangthai3) and MaPhong like '%'+@maphong+ '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTKHACHHANG]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTKHACHHANG]
@tukhoa nvarchar(30)
AS
BEGIN
SELECT KhachHang.TenKH as N'Tên khách hàng', KhachHang.GioiTinh as N'Giới tính', CONVERT(VARCHAR(10),KhachHang.NgaySinh, 103) as N'Ngày sinh', KhachHang.SoCMT as N'Số CMND', 
KhachHang.SoDT as N'Số điện thoại', KhachHang.QueQuan as N'Quên quán', KhachHang.QuocTich as N'Quốc tịch' FROM KhachHang
WHERE TenKH like '%'+@tukhoa+'%' OR SoCMT like '%'+@tukhoa+'%' OR SoDT like '%'+@tukhoa+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTNhanVien]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTNhanVien]
	@manhanvien char(7)
AS
BEGIN
	SELECT 
		HoTen,
		CONVERT(VARCHAR(10),NgaySinh, 103) as NgaySinh,
		GioiTinh,
		DiaChi,
		SDT,
		SoCMT,
		ChucVu
	FROM NhanVien WHERE NhanVien.MaNV = @manhanvien
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTNHANVIENTHEOTUKHOA]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECTNHANVIENTHEOTUKHOA] 
@tukhoa nvarchar(20)
AS
BEGIN
	SELECT NhanVien.MaNV as N'Mã nhân viên', 
		HoTen as N'Họ tên', 
		GioiTinh as N'Giới tính',
		SDT as N'Số điện thoại'
		
		FROM NhanVien WHERE (NhanVien.MaNV like '%'+@tukhoa + '%' OR lower(HoTen) like '%'+lower(@tukhoa) + '%' OR SDT like '%'+@tukhoa + '%' )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_Login]
(
	@UserName CHAR(13),
	@PassWords  CHAR(16)
)
as
begin
	select * from DANGNHAP where UserName = @UserName and PassWords = @PassWords
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ThanhToan]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_ThanhToan] 
(
	@MaHD char(8)
)
as
begin
	UPDATE HoaDon
	SET DaThanhToan = 1
	WHERE MaHD = @MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemPhongThue]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_TimKiemPhongThue] (@SoDT varchar(10))
as
begin
if @SoDT = ''
	SELECT       dbo.HoaDon.MaHD, dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
else 
	SELECT     dbo.HoaDon.MaHD, dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.SoDT = @SoDT
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemPhongThueCMTND]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_TimKiemPhongThueCMTND] (@CMTND char(9))
as
begin
	SELECT     dbo.HoaDon.MaHD,   dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.SoCMT = @CMTND
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemPhongThueMaPhongf]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_TimKiemPhongThueMaPhongf] (@MaPhong char(7))
as
begin
	SELECT     dbo.HoaDon.MaHD,   dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.ThuePhong.MaPhong = @MaPhong
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemPhongThueTen]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_TimKiemPhongThueTen] (@Name varchar(40))
as
begin
	SELECT     dbo.HoaDon.MaHD,   dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.TenKH = @Name
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XuatHoaDon]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_XuatHoaDon] 
(
	@MaNV char(7),
	@SoDT char(10),
	@NgayLap varchar(50),
	@TongTien varchar(20)
)
as
begin
	Declare @MaHD char(8)
	set @MaHD = dbo.AUTO_IDHD()
	INSERT INTO HoaDon(MaHD, MaNV, SoDT, NgayLap, TongTien)
	VALUES (@MaHD,@MaNV,@SoDT,CONVERT(datetime, @NgayLap, 103),CONVERT(int, @TongTien));
end
GO
/****** Object:  StoredProcedure [dbo].[THEMNHANVIEN]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMNHANVIEN]
@manhanvien char(7),
@hoten char(27),
@ngaysinh date,
@gioitinh char(3),
@socmnd char(9),
@diachi char(50),
@sdt char(10),
@chucvu char(12),
@password char(16)
AS
BEGIN
	INSERT INTO DangNhap(UserName, PassWords) VALUES (@manhanvien, @password)
	INSERT INTO NhanVien(MaNV, UserName, HoTen, NgaySinh, GioiTinh, SoCMT, DiaChi, SDT, ChucVu)
	VALUES (@manhanvien, @manhanvien, @hoten, @ngaysinh, @gioitinh, @socmnd, @diachi, @sdt, @chucvu)
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATENV]    Script Date: 12/23/2020 8:13:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATENV]
@manhanvien char(7),
@hoten char(27),
@ngaysinh date,
@gioitinh char(3),
@socmnd char(9),
@diachi char(50),
@sdt char(10),
@chucvu char(12)
AS
BEGIN
	UPDATE NhanVien SET
	HoTen = @hoten,
	NgaySinh = @ngaysinh,
	GioiTinh = @gioitinh,
	SoCMT = @socmnd,
	DiaChi = @diachi,
	SDT = @sdt,
	ChucVu = @chucvu
	WHERE MaNV = @manhanvien
END
GO
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
