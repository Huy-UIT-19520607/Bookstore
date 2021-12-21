use QuanLyNhaSach

go

-- Thêm chi tiết
create proc sp_add_book_receipt_detail
@id int,
@book_id int,
@number int,
@receive_price int,
@total int
as
begin
	insert into CT_PHIEUNHAPSACH
	values (@id, @book_id, @number, @receive_price, @total);
end;
go

-- Sửa chi tiết
create proc sp_update_book_receipt_detail
@id int,
@book_id int,
@number int,
@receive_price int,
@total int
as
	update CT_PHIEUNHAPSACH
	set
		SoLuongNhap=@number,
		DonGiaNhap=@receive_price,
		ThanhTien=@total
	where SoPNS=@id and MaSach=@book_id
go

-- Xóa chi tiết
create proc sp_remove_book_receipt_detail
@id int,
@book_id int
as
	delete from CT_PHIEUNHAPSACH
	where SoPNS=@id and MaSach=@book_id
go