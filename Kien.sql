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


CREATE FUNCTION AUTO_IDHD()
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
go



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


select dbo.AUTO_IDHD()