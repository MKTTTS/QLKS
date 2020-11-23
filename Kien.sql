Create Proc [dbo].[SP_TimKiemPhongThue] (@SoDT varchar(10))
as
begin
if @SoDT = ''
	SELECT        dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
else 
	SELECT        dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.SoDT = @SoDT
end
GO



SP_TimKiemPhongThue @SoDT = ''

Create Proc [dbo].[SP_TimKiemPhongThueMaPhongf] (@MaPhong char(7))
as
begin
	SELECT        dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.ThuePhong.MaPhong = @MaPhong
end
GO

[SP_TimKiemPhongThueMaPhongf] @MaPhong= '111'

Create Proc [dbo].[SP_TimKiemPhongThueCMTND] (@CMTND char(9))
as
begin
	SELECT        dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.SoCMT = @CMTND
end
GO

Create Proc [dbo].[SP_TimKiemPhongThueTen] (@Name varchar(40))
as
begin
	SELECT        dbo.ThuePhong.MaThue, dbo.KhachHang.TenKH, dbo.KhachHang.NgaySinh, dbo.KhachHang.SoCMT, dbo.KhachHang.SoDT, dbo.Phong.MaPhong, dbo.KhachHang.QueQuan, dbo.ThuePhong.NgayThue, 
							 dbo.ThuePhong.NgayTraPhong, dbo.Phong.GiaPhong, dbo.HoaDon.TongTien, dbo.HoaDon.DaThanhToan
	FROM            dbo.KhachHang left JOIN
							 dbo.HoaDon ON dbo.HoaDon.SoDT = dbo.KhachHang.SoDT INNER JOIN
							 dbo.ThuePhong ON dbo.KhachHang.SoDT = dbo.ThuePhong.SoDT left JOIN
							 dbo.Phong ON dbo.ThuePhong.MaPhong = dbo.Phong.MaPhong
	where dbo.KhachHang.TenKH = @Name
end
GO

Create Proc [dbo].[SP_XuatHoaDon] 
(
	@MaHD char(8),
	@MaNV char(7),
	@SoDT char(10),
	@NgayLap varchar(50),
	@TongTien varchar(20)
)
as
begin
	INSERT INTO HoaDon(MaHD, MaNV, SoDT, NgayLap, TongTien)
	VALUES (@MaHD,@MaNV,@SoDT,CONVERT(datetime, @NgayLap, 103),CONVERT(int, @TongTien));
end
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