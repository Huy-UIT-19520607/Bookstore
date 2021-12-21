use QuanLyNhaSach

go

-- Thay đổi giá trị
create proc sp_change_value_parameter
@name nvarchar(200),
@value int
as
begin
	if @name=N'TiLeTinhDonGiaBan'
	begin
		declare @old_value int
		select @old_value = GiaTri from THAMSO where TenThamSo=N'TiLeTinhDonGiaBan'
		update SACH
		set
			DonGiaBan=(DonGiaBan*100/@old_value)*@value/100
	end

	update THAMSO
	set GiaTri=@value
	where TenThamSo=@name
end
go