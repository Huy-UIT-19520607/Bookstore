use QuanLyNhaSach

go

-- Thêm phiếu
create proc sp_add_book_receipt
@date date,
@total int
as
begin
	insert into PHIEUNHAPSACH(NgayLap, TongTien)
	values(@date, @total);

	select top 1 SoPNS
	from PHIEUNHAPSACH
	where NgayLap=@date and TongTien=@total
	order by SoPNS desc
end
go

-- Sửa phiếu
create proc sp_update_book_receipt
@id int,
@date date,
@total int
as
	update PHIEUNHAPSACH
	set
		NgayLap=@date,
		TongTien=@total
	where SoPNS=@id
go

-- Xóa phiếu
create proc sp_remove_book_receipt
@id int
as
	delete from CT_PHIEUNHAPSACH
	where SoPNS=@id;

	delete from PHIEUNHAPSACH
	where SoPNS=@id
go