USE QLKS
GO
SELECT * FROM dbo.DangNhap
INSERT INTO dbo.DangNhap
(
    UserName,
    PassWords
)
VALUES
(   'admin1', -- UserName - char(13)
    '1'  -- PassWords - char(16)
    )

INSERT INTO dbo.DangNhap
(
    UserName,
    PassWords
)
VALUES
(   'admin2', -- UserName - char(13)
    '1'  -- PassWords - char(16)
    )

SELECT COUNT(*) FROM dbo.DangNhap WHERE UserName = 'admin1' AND PassWords ='1'
SELECT COUNT(*) FROM dbo.DangNhap WHERE UserName = 'admin2' AND PassWords ='1'

  
create proc SP_Login
(
	@UserName CHAR(13),
	@PassWords  CHAR(16)
)
as
begin
	select * from DANGNHAP where UserName = @UserName and PassWords = @PassWords
end

SP_Login @UserName = 'admin1', @PassWords = '1'