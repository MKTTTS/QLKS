CREATE DATABASE QLKS
GO

USE QLKS
GO

CREATE TABLE DangNhap(
	UserName char(13) primary key,
	PassWords char(16)
)

CREATE TABLE NhanVien(
	MaNV char(7) primary key,
	UserName char(13) FOREIGN KEY REFERENCES DangNhap(UserName),
	HoTen char(27),
	NgaySinh date,
	GioiTinh char(3),
	SoCMT char(9),
	DiaChi char(50),
	SDT char(10),
	ChucVu char(12)
)

CREATE TABLE KhachHang(
	TenKH nvarchar(27),
	NgaySinh date,
	GioiTinh char(3),
	SoCMT char(9),
	SoDT char(10) primary key,
	QueQuan char(7),
	QuocTich nvarchar(10)
)

CREATE TABLE Phong(
	MaPhong char(7) primary key,
	LoaiPhong char(5),
	GiaPhong int,
	TinhTrang char(10)  
)

CREATE TABLE DatPhong(
	MaDat char(6) primary key,
	MaPhong char(7) foreign key references Phong(MaPhong),
	SoDT char(10) FOREIGN KEY REFERENCES KhachHang(SoDT),
	TienCoc int,
	NgaySuDung date,
	NgayKetThuc date
)

CREATE TABLE ThuePhong(
	MaThue char(8),
	SoDT char(10) FOREIGN KEY REFERENCES KhachHang(SoDT),
	MaPhong char(7) FOREIGN KEY REFERENCES Phong(MaPhong),
	NgayThue date,
	NgayTraPhong date
)

CREATE TABLE HoaDon(
	MaHD char(8) primary key,
	MaNV char(7) FOREIGN KEY REFERENCES NhanVien(MaNV),
	SoDT char(10) FOREIGN KEY REFERENCES KhachHang(SoDT),
	NgayLap date,
	TongTien int
)