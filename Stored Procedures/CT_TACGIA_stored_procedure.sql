use QuanLyNhaSach

go

-- Thêm tác giả
create proc sp_add_author
@title_id int,
@name nvarchar(50)
as
	insert into CT_TACGIA
	values (@title_id, @name);
go

-- Xóa tác giả
create proc sp_remove_author
@title_id int,
@name nvarchar(50)
as
	delete from CT_TACGIA
	where MaDauSach = @title_id and TacGia=@name
go

-- Sửa tác giả
create proc sp_update_author
@title_id int,
@old_name nvarchar(50),
@new_name nvarchar(50)
as
	Update CT_TACGIA
	set
		TacGia=@new_name
	where TacGia=@old_name and MaDauSach=@title_id
go