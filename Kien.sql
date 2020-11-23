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

[SP_TimKiemPhongThueMaPhongf] @MaPhong= '111    '

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