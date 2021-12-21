Use QuanLyNhaSach

go

-- Thêm báo cáo
create proc sp_add_inventory_report
@month int,
@year int,
@book_id int,
@first int,
@change int,
@final int
as
	insert into BAOCAOTON
	values (@month, @year, @book_id, @first, @change, @final);
go

-- Xóa báo cáo
create proc sp_remove_inventory_report
@month int,
@year int,
@book_id int
as
	delete from BAOCAOTON
	where Thang=@month
	and Nam=@year
	and MaSach=@book_id
go

-- Sửa báo cáo
create proc sp_update_inventory_report
@month int,
@year int,
@book_id int,
@first int,
@change int,
@final int
as
	update BAOCAOTON
	set
		TonDau=@first,
		PhatSinh=@change,
		TonCuoi=@final
	where Thang=@month and Nam=@year and MaSach=@book_id
go