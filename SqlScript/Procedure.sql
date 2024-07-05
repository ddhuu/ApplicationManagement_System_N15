
use QLHoSoUngTuyen;
go

drop procedure checkLogin;
drop procedure addUserDN;
drop procedure addUserUV;
drop procedure GetPosts;
drop procedure GetPostDetail;
drop procedure GetCandidateInformation;
drop procedure AddPUT;

go
---------------------------------------------------------
-- Nguyen Dang Ba Kiet
create procedure checkLogin( @username varchar(30), @password varchar(255))
as
BEGIN
	if exists (select 1 from NguoiDung where TenDangNhap = @username AND MatKhau	= @password)
		begin
			select top 1 VaiTro from NguoiDung where TenDangNhap = @username AND MatKhau	= @password;
		end;
END;

go

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

go

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

go
------------------------------------------------------------------
-- Ngo Quoc Huy
CREATE PROCEDURE GetPosts
AS
BEGIN
    select ROW_NUMBER() OVER (ORDER BY d.TenDN) AS STT, p.MaPhieuDT, d.TenDN, d.Email, n.ViTriCanTuyen, n.SoLuongTuyen, n.NgayBatDau
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n
	where p.MaDN = d.MaDN and p.MaND = n.MaND and p.TrangThai = N'Ch?p nh?n' and n.NgayKetThuc > GETDATE()
END;

go

CREATE PROCEDURE GetPostDetail @id int
AS
BEGIN
    select d.TenDN, d.DiaChi, d.Email, n.*, t.MoTa as TieuChi
    from PhieuDangTuyen as p, DoanhNghiep as d, NoiDungDangTuyen as n, TieuChi as t
	where p.MaDN = d.MaDN and p.MaND = n.MaND and t.MaND = n.MaND and p.TrangThai = N'Ch?p nh?n' and p.MaPhieuDT = @id
END;

go

CREATE PROCEDURE GetCandidateInformation @username varchar(50)
AS
BEGIN
    select u.*
	from NguoiDung n, UngVien u
	where n.ID = u.ID_NguoiDung and n.TenDangNhap = @username
END;

go

CREATE PROCEDURE AddPUT @ViTri nvarchar(20), @MaUV int, @MaPhieuDT int, @Message nvarchar(255) OUTPUT, @NewMaPhieuUT int OUTPUT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM PhieuUngTuyen WHERE MaUV = @MaUV AND MaPhieuDT = @MaPhieuDT)
    BEGIN
        SET @Message = N'?ng viên ?ã ?ng tuy?n v? trí này, không th? ?ng tuy?n n?a.';
        RETURN;
    END

    SELECT @NewMaPhieuUT = ISNULL(MAX(MaPhieuUT), 0) + 1 FROM PhieuUngTuyen;

    INSERT INTO PhieuUngTuyen (MaPhieuUT, ViTri, NgayNop, TrangThai, MaUV, MaPhieuDT, TenHoSo, TrangThaiHoSo)
    VALUES (@NewMaPhieuUT, @ViTri, GETDATE(), N'?ang xét duy?t', @MaUV, @MaPhieuDT, NULL, NULL);

    SET @Message = N'?ng tuy?n thành công.';
END;

go
---------------------------------------------------------------------------
-- Doan Duc Huu

CREATE OR ALTER PROCEDURE GetPostByUser
  @USERNAME VARCHAR(50)
AS
BEGIN
  SELECT 
    P.MaPhieuDT as MP,
    ND.ViTriCanTuyen as VT,
	ND.SoLuongTuyen as SL,
	ND.NgayBatDau as NBD,
	ND.NgayKetThuc as NKT
  FROM 
    PhieuDangTuyen P
  INNER JOIN 
    DOANHNGHIEP D ON P.MaDN = D.MaDN
  INNER JOIN 
	NoiDungDangTuyen ND ON ND.MaND = P.MaND 
  INNER JOIN 
    NGUOIDUNG N ON D.ID_NguoiDung = N.ID
  WHERE 

    N.TenDangNhap = @USERNAME
END;

go

CREATE OR ALTER PROCEDURE GetPostById
  @IdPost INT
AS
BEGIN
  SELECT 
    
    ND.ViTriCanTuyen as VT,
	ND.SoLuongTuyen as SL,
	ND.NgayBatDau as NBD,
	ND.NgayKetThuc as NKT,
	ND.MoTa as MT,
	Q.HinhThuc as HTDT,
	P.TongTien as TT
  FROM 
    PhieuDangTuyen P
  INNER JOIN 
    QuangCao Q on Q.MaPhieuDT = P.MaPhieuDT
  INNER JOIN 
	NoiDungDangTuyen ND ON ND.MaND = P.MaND 
  WHERE 

    P.MaPhieuDT = @IdPost
END;


go


CREATE OR ALTER PROCEDURE AddAdvertise
    @startDate DATE,
    @endDate DATE,
    @adType NVARCHAR(50),
	@idCompany INT,
    @AdID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE @MaxID int;
    SELECT @MaxID = ISNULL(MAX(MaQuangCao), 0) + 1 FROM QuangCao;


    INSERT INTO QuangCao (MaQuangCao,NgayBatDau,NgayKetThuc,HinhThuc,MaPhieuDT)
    VALUES (@MaxID,@startDate, @endDate, @adType, @idCompany);
    SET @AdID = @MaxID;
END
go

go

create or alter proc AddJobPost
	@status nvarchar(50),
	@price int,
	@idUser int,
	@idJobDetail int,
	@JobPostId int output
as
begin 
    SET NOCOUNT ON;
    DECLARE @actualCompanyId int;
    SELECT @actualCompanyId = MaDN FROM DoanhNghiep WHERE ID_NguoiDung = @idUser;

	 DECLARE @MaxID int;

    
    SELECT @MaxID = ISNULL(MAX(MaPhieuDT), 0) + 1 FROM PhieuDangTuyen;

	
	insert into PHIEUDANGTUYEN(MaPhieuDT,MaND,TrangThai,TongTien,MaDN,MaNVDangTuyen) values(@MaxID,@idJobDetail,@status,@price,@actualCompanyId,null);
	SET @JobPostId = @MaxID;
end
go

go
create or alter proc AddJobDetail
    @quantity int,
    @position nvarchar(50),
	@description nvarchar(1000),
    @dayPosting int,
    @startDate date,
    @endDate date,
    @idDetailJob int output
as
begin
    SET NOCOUNT ON;

    DECLARE @MaxMaND int;

    
    SELECT @MaxMaND = ISNULL(MAX(MaND), 0) + 1 FROM NoiDungDangTuyen;

    INSERT INTO NoiDungDangTuyen(MaND, SoLuongTuyen, ViTriCanTuyen, ThoiGianDangTuyen,MoTa, NgayBatDau, NgayKetThuc)
    VALUES(@MaxMaND, @quantity, @position, @dayPosting,@description, @startDate, @endDate);

    
    SET @idDetailJob = @MaxMaND;
end
go


go

create or alter procedure GetDisCount @userName varchar(30) , @discount int output
as
begin
	 SELECT @discount = clud.UuDai FROM NguoiDung nd  
                               JOIN DoanhNghiep dn ON nd.ID = dn.ID_NguoiDung 
                               JOIN DoanhNghiep_UuDai dnu ON dn.MaDN = dnu.MaDN 
                               JOIN ChienLuocUuDai clud ON dnu.MaChienLuoc = clud.MaChienLuoc 
                               WHERE nd.TenDangNhap = @userName
end;
go


create or alter procedure  AddContract
    @signDate date,
    @expiredDate date,
    @idPost int
as
begin
   
    DECLARE @MaHopDongMoi int;
    SELECT @MaHopDongMoi = ISNULL(MAX(MaHopDong), 0) + 1 FROM HopDong;

    INSERT INTO HopDong(MaHopDong, TenHopDong, NgayKy, NgayHetHan, TrangThai, MaPhieuDT, LanGiaHan)
    VALUES(@MaHopDongMoi, N'Hợp đồng ' + CAST(@MaHopDongMoi AS nvarchar(10)), @signDate, @expiredDate, N'Chưa thanh toán', @idPost, 0);
end












