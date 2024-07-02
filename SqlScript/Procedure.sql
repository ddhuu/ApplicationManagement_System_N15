use QLHoSoUngTuyen;
drop procedure checkLogin;
drop procedure addUserDN;
drop procedure addUserUV;
drop procedure GetPosts;
drop procedure GetPostDetail;

create procedure checkLogin( @username varchar(30), @password varchar(255))
as
BEGIN
	if exists (select 1 from NguoiDung where TenDangNhap = @username AND MatKhau	= @password)
		begin
			select top 1 VaiTro from NguoiDung where TenDangNhap = @username AND MatKhau	= @password;
		end;
END;

create procedure addUserDN(@username varchar(50), @password varchar(255), @companyName nvarchar(50), @taxCode nvarchar(50), @nameDD nvarchar(50),@address nvarchar(50),@email nvarchar(50))
as
BEGIN
	declare @idUser INT;
	Set @idUser = 0;
	declare @id INT;
	Set @id = 0;
	if not exists (select 1 from NguoiDung where TenDangNhap = @username AND MatKhau	= @password)
		begin
			select TOP 1 @idUser = ID from NguoiDung ORDER BY ID DESC;
			if @idUser is null
				set @idUser = 1;
			else
				set @idUser = @idUser + 1;
			insert into NguoiDung values(@idUser,@username,@password,'DoanhNghiep');
			SELECT TOP 1 @id = MADN FROM DoanhNghiep ORDER BY MADN DESC;
			if @id is null
				set @id = 1;
			else
				set @id = @id + 1;
			insert into DoanhNghiep values(@id,@companyName,@address,@nameDD,@email,0,@idUser);
		end
END;


create procedure addUserUV(@username varchar(50), @password varchar(255), @candidateName varchar(50), @gender nvarchar(50), @address nvarchar(50),@CCCD nvarchar(50) ,@email varchar(50), @phoneNumber varchar(50))
as
BEGIN
	declare @idUser INT;
	Set @idUser = 0;
	declare @id INT;
	Set @id = 0;
	if not exists (select 1 from NguoiDung where TenDangNhap = @username AND MatKhau	= @password)
		begin
			select TOP 1 @idUser = ID from NguoiDung ORDER BY ID DESC;
			if @idUser is null
				set @idUser = 1;
			else
				set @idUser = @idUser + 1;
			insert into NguoiDung values(@idUser,@username,@password,'UngVien');
			SELECT TOP 1 @id = MAUV FROM UngVien ORDER BY MAUV DESC;
			if @id is null
				set @id = 1;
			else
				set @id = @id + 1;
			insert into UngVien values(@id,@candidateName,@gender,@address,@CCCD,@phoneNumber,@email,@idUser);
		end
END;

EXEC addUserUV @username = 'bakiet', @password = '123', @candidateName = 'kiet', @gender = 'Nam', @address = 'abc', @CCCD = '0123123',@phoneNumber ='123213213',@email ='abc@gamil.com';

CREATE PROCEDURE GetPosts
AS
BEGIN
    select ROW_NUMBER() OVER (ORDER BY d.TenDN) AS STT, p.MaPhieuDT, d.TenDN, d.Email, n.ViTriCanTuyen, n.SoLuongTuyen, n.NgayBatDau
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n
	where p.MaDN = d.MaDN and p.MaND = n.MaND and p.TrangThai = N'Chấp nhận'
END;

exec GetPosts

CREATE PROCEDURE GetPostDetail @id int
AS
BEGIN
    select d.TenDN, d.DiaChi, d.Email, n.*, t.MoTa
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n, TieuChi as t
	where p.MaDN = d.MaDN and p.MaND = n.MaND and t.MaND = n.MaND and p.TrangThai = N'Chấp nhận' and p.MaPhieuDT = @id
END;

exec GetPostDetail 15

CREATE PROCEDURE GetCandidateInformation @username varchar(50)
AS
BEGIN
    select u.*
	from NguoiDung n, UngVien u
	where n.ID = u.ID_NguoiDung and n.TenDangNhap = @username
END;

exec GetCandidateInformation NgoQuocHuy