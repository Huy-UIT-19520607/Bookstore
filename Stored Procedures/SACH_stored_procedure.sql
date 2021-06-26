USE QuanLyNhaSach;

GO

-- Thêm sách
CREATE PROC sp_add_book
@title_id int,
@publisher nvarchar(200),
@publish_year int,
@in_stock int,
@price int
AS
BEGIN
	INSERT INTO SACH(MaDauSach, NhaXuatBan, NamXuatBan, SoLuongTon, DonGiaBan)
	VALUES(@title_id, @publisher, @publish_year, @in_stock, @price);

	SELECT MaSach 
	FROM SACH 
	WHERE MaDauSach=@title_id 
	AND NhaXuatBan=@publisher
	AND NamXuatBan=@publish_year
	AND SoLuongTon=@in_stock
	AND DonGiaBan=@price;
END;
GO

-- Xóa sách
CREATE PROC sp_remove_book
@id int
AS
	DELETE FROM SACH
	WHERE MaSach=@id
GO

-- Sửa sách
CREATE PROC sp_update_book
@id int,
@title_id int,
@publisher nvarchar(200),
@publish_year int,
@in_stock int,
@price int
AS
	UPDATE SACH
	SET
		MaDauSach=@title_id,
		NhaXuatBan=@publisher,
		NamXuatBan=@publish_year,
		SoLuongTon=@in_stock,
		DonGiaBan=@price
	WHERE MaSach=@id
GO