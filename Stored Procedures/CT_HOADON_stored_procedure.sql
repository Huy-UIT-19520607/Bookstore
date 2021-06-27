use QuanLyNhaSach

go

-- Thêm chi tiết
create proc sp_add_bill_detail
@id int,
@book_id int,
@number int,
@price int,
@total int
as
	insert into CT_HOADON
	values (@id, @book_id, @number, @price, @total)
go

-- Sửa chi tiết
create proc sp_update_bill_detail
@id int,
@book_id int,
@number int,
@price int,
@total int
as
	update CT_HOADON
	set
		SoLuong=@number,
		DonGia=@price,
		ThanhTien=@total
	where SoHD=@id and MaSach=@book_id
go

-- Xóa chi tiết
create proc sp_remove_bill_detail
@id int,
@book_id int
as
	delete from CT_HOADON
	where SoHD=@id and MaSach=@book_id
go