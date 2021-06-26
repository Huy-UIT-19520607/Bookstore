use QuanLyNhaSach

go

-- Thay đổi giá trị
create proc sp_change_value_parameter
@name nvarchar(200),
@value int
as
	update THAMSO
	set GiaTri=@value
	where TenThamSo=@name
go