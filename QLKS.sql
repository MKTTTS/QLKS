USE [master]
GO
/****** Object:  Database [QLKS]    Script Date: 11/2/2020 2:04:37 PM ******/
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
/****** Object:  Table [dbo].[DangNhap]    Script Date: 11/2/2020 2:04:38 PM ******/
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
/****** Object:  Table [dbo].[DatPhong]    Script Date: 11/2/2020 2:04:38 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/2/2020 2:04:38 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/2/2020 2:04:38 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/2/2020 2:04:38 PM ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 11/2/2020 2:04:38 PM ******/
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
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 11/2/2020 2:04:38 PM ******/
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
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'manhson99    ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'trivan77     ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'vankien99    ', N'123456          ')
INSERT [dbo].[DangNhap] ([UserName], [PassWords]) VALUES (N'xuantung98   ', N'123456          ')
GO
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'11220113  ', N'113    ', N'987678567 ', 500000, CAST(N'2020-12-01' AS Date), CAST(N'2020-12-06' AS Date))
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'11220213  ', N'213    ', N'0912134536', 300000, CAST(N'2020-12-01' AS Date), CAST(N'2020-12-03' AS Date))
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'151120311 ', N'311    ', N'0973467123', 400000, CAST(N'2020-11-15' AS Date), CAST(N'2020-11-19' AS Date))
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'171220211 ', N'211    ', N'946575757 ', 500000, CAST(N'2020-12-17' AS Date), CAST(N'2020-12-19' AS Date))
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'281020112 ', N'112    ', N'967656564 ', 500000, CAST(N'2020-10-28' AS Date), CAST(N'2020-10-30' AS Date))
INSERT [dbo].[DatPhong] ([MaDat], [MaPhong], [SoDT], [TienCoc], [NgaySuDung], [NgayKetThuc]) VALUES (N'291120312 ', N'312    ', N'0983273689', 450000, CAST(N'2020-11-29' AS Date), CAST(N'2020-12-01' AS Date))
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaNV], [SoDT], [NgayLap], [TongTien]) VALUES (N'HD0001  ', N'LT001  ', N'0974162436', CAST(N'2020-10-28' AS Date), 1500000)
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
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'112    ', N'3    ', 650000, N'Coc       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'113    ', N'2    ', 600000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'211    ', N'2    ', 550000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'212    ', N'3    ', 800000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'213    ', N'2    ', 700000, N'Coc       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'214    ', N'3    ', 900000, N'Het       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'311    ', N'2    ', 600000, N'Coc       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'312    ', N'2    ', 750000, N'Coc       ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [GiaPhong], [TinhTrang]) VALUES (N'313    ', N'3    ', 800000, N'Trong     ')
GO
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00001  ', N'0974162436', N'111    ', CAST(N'2020-10-25' AS Date), CAST(N'2020-10-28' AS Date))
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00002  ', N'0912193236', N'212    ', CAST(N'2020-11-03' AS Date), CAST(N'2020-11-05' AS Date))
INSERT [dbo].[ThuePhong] ([MaThue], [SoDT], [MaPhong], [NgayThue], [NgayTraPhong]) VALUES (N'T00003  ', N'0912834753', N'214    ', CAST(N'2020-10-30' AS Date), CAST(N'2020-11-03' AS Date))
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
USE [master]
GO
ALTER DATABASE [QLKS] SET  READ_WRITE 
GO
