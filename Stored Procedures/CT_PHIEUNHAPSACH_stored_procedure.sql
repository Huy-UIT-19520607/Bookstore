use QuanLyNhaSach

go

-- Thêm chi tiết
create proc sp_add_book_receipt_detail
@book_id int,
@number int,
@receive_price int,
@total int
as
begin
	insert into CT_PHIEUNHAPSACH(MaSach, SoLuongNhap, DonGiaNhap, ThanhTien)
	values (@book_id, @number, @receive_price, @total);

	select SoPNS
	from CT_PHIEUNHAPSACH
	where MaSach=@book_id
	and SoLuongNhap=@number
	and DonGiaNhap=@receive_price
	and ThanhTien=@total
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
		MaSach=@book_id,
		SoLuongNhap=@number,
		DonGiaNhap=@receive_price,
		ThanhTien=@total
	where SoPNS=@id
go

-- Xóa chi tiết
create proc sp_remove_book_receipt_detail
@id int
as
	delete from CT_PHIEUNHAPSACH
	where SoPNS=@id
go

drop proc sp_remove_book_receipt_detail, sp_update_book_receipt_detail, sp_add_book_receipt_detail