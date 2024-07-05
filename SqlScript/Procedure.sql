use QLHoSoUngTuyen;

drop procedure checkLogin;
drop procedure addUserDN;
drop procedure addUserUV;
drop procedure GetPosts;
drop procedure GetPostDetail;
drop procedure GetCandidateInformation;
drop procedure AddPUT;
drop procedure getAPhieuDT;
drop function getTienConLai;
drop function getHighestBatch;
drop procedure insertThanhToan;
drop function getMaNV;
DROP PROCEDURE getListTT;

create procedure checkLogin( @username varchar(30), @password varchar(255))
as
BEGIN
	if exists (select 1 from NguoiDung where TenDangNhap = @username AND MatKhau	= @password)
		begin
			select top 1 VaiTro from NguoiDung where TenDangNhap = @username AND MatKhau	= @password;
		end;
END;

create procedure addUserDN(@username varchar(50), @password varchar(255), @companyName nvarchar(50), @taxCode varchar(20), @nameDD nvarchar(50),@address nvarchar(50),@email varchar(50))
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
			insert into DoanhNghiep values(@id,@companyName,@address,@nameDD,@taxCode,@email,0,@idUser);
		end
END;


create procedure addUserUV(@username varchar(50), @password varchar(255), @candidateName nvarchar(50), @gender nvarchar(5),@ngaySinh varchar(50), @address nvarchar(50),@CCCD varchar(50) ,@email varchar(50), @phoneNumber varchar(50))
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
			declare @ngayS DATE;
			set @ngayS = PARSE(@ngaySinh as date USING 'AR-LB');
			insert into UngVien values(@id,@candidateName,@gender,@ngayS,@address,@CCCD,@phoneNumber,@email,@idUser);
		end
END;


CREATE PROCEDURE GetPosts
AS
BEGIN
    select ROW_NUMBER() OVER (ORDER BY d.TenDN) AS STT, p.MaPhieuDT, d.TenDN, d.Email, n.ViTriCanTuyen, n.SoLuongTuyen, n.NgayBatDau
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n
	where p.MaDN = d.MaDN and p.MaND = n.MaND and p.TrangThai = N'Chấp nhận' and n.NgayKetThuc > GETDATE()
END;



CREATE PROCEDURE GetPostDetail @id int
AS
BEGIN
    select d.TenDN, d.DiaChi, d.Email, n.*, t.MoTa as TieuChi
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n, TieuChi as t
	where p.MaDN = d.MaDN and p.MaND = n.MaND and t.MaND = n.MaND and p.TrangThai = N'Chấp nhận' and p.MaPhieuDT = @id
END;


CREATE PROCEDURE GetCandidateInformation @username varchar(50)
AS
BEGIN
    select u.*
	from NguoiDung n, UngVien u
	where n.ID = u.ID_NguoiDung and n.TenDangNhap = @username
END;

exec GetCandidateInformation NgoQuocHuy

CREATE PROCEDURE AddPUT @ViTri nvarchar(20), @MaUV int, @MaPhieuDT int, @username varchar(255), @Message nvarchar(255) OUTPUT, @NewMaPhieuUT int OUTPUT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM PhieuUngTuyen WHERE MaUV = @MaUV AND MaPhieuDT = @MaPhieuDT)
    BEGIN
        SET @Message = N'Ứng viên đã ứng tuyển vị trí này, không thể ứng tuyển nữa.';
        RETURN;
    END

    SELECT @NewMaPhieuUT = ISNULL(MAX(MaPhieuUT), 0) + 1 FROM PhieuUngTuyen;

    INSERT INTO PhieuUngTuyen (MaPhieuUT, ViTri, NgayNop, TrangThai, MaUV, MaPhieuDT, MaHoSo)
    VALUES (@NewMaPhieuUT, @ViTri, GETDATE(), N'Đang xét duyệt', @MaUV, @MaPhieuDT, @MaPhieuDT + '_' + @username + '_' + CAST(@NewMaPhieuUT AS varchar(50)) + '.pdf');

    SET @Message = N'Ứng tuyển thành công.';
END;


create procedure getAPhieuDT(@MaPhieuDT int) 
as
BEGIN
	SELECT A.MAPHIEUDT as MaPhieuDT,A.TONGTIEN AS TongTien,B.LanGiaHan AS LanGiaHan FROM PhieuDangTuyen AS A JOIN HopDong AS B ON A.MaPhieuDT = B.MaPhieuDT
	WHERE A.MaPhieuDT = @MaPhieuDT;
END;


EXEC getAPhieuDT @MaPhieuDT = 1;


create function getTienConLai(@MaPhieuDT int, @LanThanhToan int) 
RETURNS INT
AS
BEGIN
	DECLARE @TONGTIEN INT;
	DECLARE @TIENDATHANHTOAN INT;
	SELECT @TONGTIEN = TongTien FROM PhieuDangTuyen WHERE MaPhieuDT = @MaPhieuDT;
	SELECT @tiendathanhtoan = SUM(SOTIEN) FROM HOADON WHERE MaPhieuDT = @MaPhieuDT AND LanGiaHan = @LanThanhToan;
	if @TIENDATHANHTOAN is null
		SET @TIENDATHANHTOAN = 0;
	DECLARE @SOTIEN INT;
	SET @SOTIEN = @TONGTIEN - @TIENDATHANHTOAN;
	RETURN @SOTIEN;
END;

EXEC getTienConLai  @MaPhieuDT = 1;

create function getHighestBatch(@MaPhieuDT INT, @LanThanhToan INT)
RETURNS INT
AS
BEGIN
	DECLARE @RESULT INT;
	SELECT @RESULT = MAX(DotThanhToan) + 1FROM HOADON WHERE MaPhieuDT = @MaPhieuDT AND LanGiaHan = @LanThanhToan ;
	IF @RESULT IS NULL
		SET @RESULT = 1;
	RETURN @RESULT;
END;

CREATE PROCEDURE INSERTTHANHTOAN(@SoTien int, @HinhThuc nvarchar(20),@LanGiaHan int,@DotThanhToan int,@MaPhieuDT int, @MaNV int)
as
begin
	DECLARE @ID INT;
	SELECT TOP 1 @ID = MaHoaDon + 1 FROM HoaDon ORDER BY MaHoaDon DESC;
	IF @ID IS NULL
		SET @ID = 1;
	INSERT INTO HoaDon VALUES(@ID,GETDATE(),@SoTien,@HinhThuc,@LanGiaHan,@DotThanhToan,@MaPhieuDT,@MaNV);
	DECLARE @TONGTIEN INT;
	SELECT @TONGTIEN = SUM(SoTien) FROM HoaDon WHERE MaPhieuDT = @MaPhieuDT AND LanGiaHan = @LanGiaHan;
	DECLARE @TIENINPDT INT;
	SELECT @TIENINPDT = TONGTIEN FROM PhieuDangTuyen WHERE MaPhieuDT = @MaPhieuDT;
	IF @TONGTIEN >= @TIENINPDT
		UPDATE HOPDONG
		SET TrangThai = N'Đang hiệu lực'
		WHERE MaPhieuDT = @MaPhieuDT;
end;


CREATE FUNCTION getMaNV(@UserName varchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @ID INT;
	SELECT TOP 1 @ID = MaNV FROM NhanVien WHERE ID_NguoiDung = (SELECT TOP 1 ID FROM NguoiDung WHERE TenDangNhap = @UserName);
	RETURN @ID;
END;

CREATE procedure getListTT
AS
BEGIN
	SELECT MaPhieuDT,TongTien FROM PhieuDangTuyen Where MaPhieuDT IN (SELECT MaPhieuDT FROM HopDong WHERE TrangThai = N'Chưa thanh toán') 
END;

EXEC getListTT;