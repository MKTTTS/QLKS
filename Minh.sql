use QLKS
GO
 
 --A. THEM DU LIEU
          create PROCEDURE sp_insPHONG
          
        @MaPhong char(7),
		@LoaiPhong char(5),
		@GiaPhong int
          
          AS
          BEGIN
          insert into Phong
          (
            MaPhong ,
			LoaiPhong ,
			GiaPhong ,
			TinhTrang
          )
           values (@MaPhong,@LoaiPhong,@GiaPhong,'Trong')
         END
      --B. XOA DU LIEU
          create procedure sp_delPHONG
          @MaPhong char(15)
          as
            delete from Phong
            where MaPhong=@MaPhong
      --C. HIEN THI DU LIEU
          create proc sp_showPhong
          as
            select * from Phong
   
      --D. SUA DU LIEU
          create procedure sp_updatePhong
          (
			@MaPhong varchar(15),
			@LoaiPhong varchar(5),
			@GiaPhong int
          )
          as

          update Phong
            set  
               LoaiPhong=@LoaiPhong,
			   GiaPhong=@GiaPhong
				where MaPhong = @MaPhong
 
 drop proc sp_updatePhong