Use QuanLyNhaSach

go

-- Thêm báo cáo
create proc sp_add_debt_report
@month int,
@year int,
@customer_id int,
@first int,
@change int,
@final int
as
	insert into BAOCAOCONGNO
	values (@month, @year, @customer_id, @first, @change, @final);
go

-- Xóa báo cáo
create proc sp_remove_debt_report
@month int,
@year int,
@customer_id int
as
	delete from BAOCAOCONGNO
	where Thang=@month
	and Nam=@year
	and MaKhachHang=@customer_id
go

-- Sửa báo cáo
create proc sp_update_debt_report
@month int,
@year int,
@customer_id int,
@first int,
@change int,
@final int
as
	update BAOCAOCONGNO
	set
		NoDau=@first,
		PhatSinh=@change,
		NoCuoi=@final
	where Thang=@month and Nam=@year and MaKhachHang=@customer_id
go