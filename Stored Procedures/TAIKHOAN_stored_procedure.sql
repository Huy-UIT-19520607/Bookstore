USE QuanLyNhaSach;

GO;

-- Đăng nhập
CREATE PROC sp_login
@username nvarchar(50),
@password nvarchar(50)
AS
	SELECT * 
	FROM TAIKHOAN 
	WHERE [TenDangNhap]=@username AND [MatKhau]=@password;
GO

-- Thêm tài khoản
CREATE PROC sp_add_account 
@username nvarchar(50),
@displayname nvarchar(200),
@password nvarchar(50),
@permission int
AS
	INSERT INTO TAIKHOAN 
	VALUES(@username, @displayname, @password, @permission);
GO

-- Xóa tài khoản
CREATE PROC sp_remove_account
@username nvarchar(50)
AS
	DELETE FROM TAIKHOAN
	WHERE TenDangNhap=@username
GO

-- Sửa tài khoản
CREATE PROC sp_update_account
@username nvarchar(50),
@displayname nvarchar(200),
@password nvarchar(50),
@permission int
AS
	UPDATE TAIKHOAN
	SET
		TenHienThi=@displayname,
		MatKhau=@password,
		PhanQuyen=@permission
	WHERE TenDangNhap=@username;
GO