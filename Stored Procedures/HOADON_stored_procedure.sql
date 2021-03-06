USE QuanLyNhaSach

GO

-- Thêm hóa đơn
CREATE PROC sp_add_bill
@customer_id int,
@date date,
@total int,
@payment int,
@balance int
AS
BEGIN
	INSERT INTO HOADON(MaKhachHang, NgayLap, TongTien, ThanhToan, ConLai)
	VALUES (@customer_id, @date, @total, @payment, @balance);

	SELECT Top 1 SoHD
	FROM HOADON
	WHERE MaKhachHang=@customer_id
	AND NgayLap=@date
	AND TongTien=@total
	AND ThanhToan=@payment
	AND ConLai=@balance
	Order by SoHD desc
END;
GO

-- Xóa hóa đơn
CREATE PROC sp_remove_bill
@id int
AS 
BEGIN
	delete from CT_HOADON
	where SoHD=@id

	DELETE FROM HOADON
	WHERE SoHD=@id
END;
GO

-- Sửa hóa đơn
CREATE PROC sp_update_bill
@id int,
@customer_id int,
@date date,
@total int,
@payment int,
@balance int
AS
	UPDATE HOADON
	SET
		MaKhachHang=@customer_id,
		NgayLap=@date,
		TongTien=@total,
		ThanhToan=@payment,
		ConLai=@balance
	WHERE SoHD=@id
GO