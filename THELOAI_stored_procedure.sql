USE QuanLyNhaSach

GO

-- Lấy thể loại theo tên
CREATE PROC sp_get_category_by_name
@name nvarchar(50)
AS
	SELECT * FROM THELOAI
	WHERE TenTheLoai=@name
GO

-- Thêm thể loại
CREATE PROC sp_add_category
@name nvarchar(50)
AS
	INSERT INTO THELOAI(TenTheLoai)
	VALUES (@name)
GO

-- Xóa thể loại
CREATE PROC sp_remove_category
@id int
AS
	DELETE FROM THELOAI
	WHERE MaTheLoai=@id
GO

-- Sửa thể loại
CREATE PROC sp_update_category
@id int,
@name nvarchar(50)
AS
	UPDATE THELOAI
	SET TenTheLoai=@name
	WHERE MaTheLoai=@id
GO
