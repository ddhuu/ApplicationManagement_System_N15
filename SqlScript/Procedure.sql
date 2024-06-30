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
			insert into NguoiDung values(@idUser,@username,@password,N'Doanh nghiệp');
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
			insert into NguoiDung values(@idUser,@username,@password,N'Ứng viên');
			SELECT TOP 1 @id = MAUV FROM UngVien ORDER BY MAUV DESC;
			if @id is null
				set @id = 1;
			else
				set @id = @id + 1;
			insert into UngVien values(@id,@candidateName,@gender,@address,@CCCD,@phoneNumber,@email,@idUser);
		end
END;

EXEC addUserUV @username = 'bakiet', @password = '123', @candidateName = 'kiet', @gender = 'Nam', @address = 'abc', @CCCD = '0123123',@phoneNumber ='123213213',@email ='abc@gamil.com';