USE QuanLyNhaSach

go

-- Thêm khách hàng
Create proc sp_add_customer
@name nvarchar(50),
@address nvarchar(200),
@phone_number nvarchar(15),
@email nvarchar(50),
@debt int
as
begin
	insert into KHACHHANG(TenKhachHang, DiaChi, SDT, Email, SoTienNo)
	values (@name, @address, @phone_number, @email, @debt);

	select MaKhachHang
	from KHACHHANG
	where TenKhachHang=@name
	and DiaChi=@address
	and SDT=@phone_number
	and Email=@email
	and SoTienNo=@debt
end;
go

-- Sửa khách hàng
create proc sp_update_customer
@id int,
@name nvarchar(50),
@address nvarchar(200),
@phone_number nvarchar(15),
@email nvarchar(50),
@debt int
as
	update KHACHHANG
	set
		TenKhachHang=@name,
		DiaChi=@address,
		SDT=@phone_number,
		Email=@email,
		SoTienNo=@debt
	where MaKhachHang=@id
go

-- Xóa khách hàng
create proc sp_remove_customer
@id int
as
	delete from KHACHHANG
	where MaKhachHang=@id
go