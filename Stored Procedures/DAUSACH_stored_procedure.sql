USE QuanLyNhaSach;

GO

-- Thêm đầu sách
CREATE PROC sp_add_title
@name nvarchar(200),
@category_id int
AS
BEGIN
	INSERT INTO DAUSACH(TenDauSach, MaTheLoai)
	VALUES (@name, @category_id);

	SELECT MaDauSach
	FROM DAUSACH
	WHERE TenDauSach=@name AND MaTheLoai=@category_id
END
GO

-- Lấy đầu sách theo dữ liệu (loại bỏ)
--CREATE PROC sp_get_title_by_data
--@name nvarchar(200),
--@category_id int
--AS
--	SELECT * 
--	FROM DAUSACH
--	WHERE TenDauSach=@name AND MaTheLoai=@category_id
--GO

-- Xóa đầu sách
CREATE PROC sp_remove_title
@id int
AS
	DELETE FROM DAUSACH
	WHERE MaDauSach=@id
GO

-- Sửa đầu sách
CREATE PROC sp_update_title
@id int,
@name nvarchar(200),
@category_id int
AS
	UPDATE DAUSACH
	SET
		TenDauSach=@name,
		MaTheLoai=@category_id
	WHERE MaDauSach=@id
GO