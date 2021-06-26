use QuanLyNhaSach

go

-- Thêm phiếu
create proc sp_add_cash_receipt
@customer_id int,
@date date,
@amount int
as
begin
	insert into PHIEUTHUTIEN(MaKhachHang, NgayLap, SoTienThu)
	values (@customer_id, @date, @amount);

	select SoPT
	from PHIEUTHUTIEN
	where MaKhachHang=@customer_id
	and NgayLap=@date
	and SoTienThu=@amount
end
go

-- Xóa phiếu
create proc sp_remove_cash_receipt
@id int
as
	delete from PHIEUTHUTIEN
	where SoPT=@id
go

-- Sửa phiếu
create proc sp_update_cash_receipt
@id int,
@customer_id int,
@date date,
@amount int
as
begin
	update PHIEUTHUTIEN
	set
		MaKhachHang=@customer_id,
		NgayLap=@date,
		SoTienThu=@amount
	where SoPT=@id
end
go