create database QLHoSoUngTuyen
use QLHoSoUngTuyen
go

--drop database QLHoSoUngTuyen

create table NguoiDung (
	ID int,
	TenDangNhap varchar(50),
	MatKhau varchar(255),
	VaiTro varchar(30),
	primary key (ID),
)
go



create table NhanVien (
	MaNV int,
	TenNV nvarchar(50),
	GioiTinh nvarchar(5),
	DiaChi nvarchar(50),
	NgaySinh date,
	CCCD varchar(12),
	ViTri nvarchar(20),
	SoDT varchar(12),
	Email varchar(50),
	ID_NguoiDung int,
	primary key (MaNV)
)
go

create table UngVien (
	MaUV int,
	TenUV nvarchar(50),
	GioiTinh nvarchar(5),
	NgaySinh DATE,
	DiaChi nvarchar(50),
	CCCD varchar(12),
	SoDT varchar(12),
	Email varchar(50),
	ID_NguoiDung int,
	primary key (MaUV)
)
go

create table PhieuUngTuyen (
	MaPhieuUT int,
	ViTri nvarchar(20),
	NgayNop date,
	TrangThai nvarchar(50),
	MaUV int,
	MaPhieuDT int,
	MaHoSo varchar(255),
	primary key (MaPhieuUT)
)
go

create table DoanhNghiep (
	MaDN int,
	TenDN nvarchar(50),
	DiaChi nvarchar(50),
	NguoiDaiDien nvarchar(50),
	MaSoThue varchar(20),
	Email varchar(50),
	TiemNang int,
	ID_NguoiDung int,
	primary key (MaDN)
)
go

create table PhieuDangTuyen (
	MaPhieuDT int,
	MaND int,
	TrangThai nvarchar(50),
	TongTien int,
	MaDN int,
	MaNVDangTuyen int,
	primary key (MaPhieuDT)
)
go

create table NoiDungDangTuyen (
	MaND int,
	SoLuongTuyen int,
	ViTriCanTuyen nvarchar(50),
	ThoiGianDangTuyen int,
	MoTa text,
	NgayBatDau date,
	NgayKetThuc date,
	primary key (MaND)
)
go

create table TieuChi (
	MaTieuChi int,
	MoTa text,
	UuTien int,
	MaND int,
	primary key (MaTieuChi)
)
go

create table DonHieuChinh (
	MaDon int,
	TenDon nvarchar(50),
	MaND int,
	NgayYeuCau date,
	TrangThai nvarchar(50),
	MaPhieuDT int,
	MaNVXetDuyet int,
	primary key (MaDon)
)
go

create table QuangCao (
	MaQuangCao int,
	NgayBatDau date,
	NgayKetThuc date,
	HinhThuc nvarchar(50),
	MaPhieuDT int,
	primary key (MaQuangCao)
)
go

create table HoaDon (
	MaHoaDon int,
	ThoiGianThanhToan datetime,
	SoTien int,
	HinhThuc nvarchar(20),
	LanGiaHan int,
	DotThanhToan int,
	MaPhieuDT int,
	MaNVThanhToan int,
	primary key (MaHoaDon)
)
go

create table HopDong (
	MaHopDong int,
	TenHopDong nvarchar(50),
	NgayKy date,
	NgayHetHan date,
	TrangThai nvarchar(50),
	MaPhieuDT int,
	LanGiaHan int,
	primary key (MaHopDong)
)
go

create table ChienLuocUuDai (
	MaChienLuoc int,
	TenChienLuoc nvarchar(50),
	Mota text,
	NgayBatDau date,
	NgayKetThuc date,
	UuDai int,
	MaBanLanhDao int,
	primary key (MaChienLuoc)
)
go

create table DoanhNghiep_UuDai (
	MaChienLuoc int,
	MaDN int,
	primary key (MaChienLuoc, MaDN)
)
go


ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_NguoiDung
FOREIGN KEY (ID_NguoiDung) REFERENCES NguoiDung(ID);

ALTER TABLE DoanhNghiep
ADD CONSTRAINT FK_DoanhNghiep_NguoiDung
FOREIGN KEY (ID_NguoiDung) REFERENCES NguoiDung(ID);

ALTER TABLE UngVien
ADD CONSTRAINT FK_UngVien_NguoiDung
FOREIGN KEY (ID_NguoiDung) REFERENCES NguoiDung(ID);

ALTER TABLE PhieuUngTuyen
ADD CONSTRAINT FK_PhieuUngTuyen_UngVien
FOREIGN KEY (MaUV) REFERENCES UngVien(MaUV),
	CONSTRAINT FK_PhieuUngTuyen_PhieuDangTuyen
FOREIGN KEY (MaPhieuDT) REFERENCES PhieuDangTuyen(MaPhieuDT);

ALTER TABLE PhieuDangTuyen
ADD CONSTRAINT FK_PhieuDangTuyen_NhanVien
FOREIGN KEY (MaNVDangTuyen) REFERENCES NhanVien(MaNV),
	CONSTRAINT FK_PhieuDangTuyen_NoiDungDangTuyen
FOREIGN KEY (MaND) REFERENCES NoiDungDangTuyen(MaND),
	CONSTRAINT FK_PhieuDangTuyen_DoanhNghiep
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaDN);

ALTER TABLE TieuChi
ADD CONSTRAINT FK_TieuChi_NoiDungDangTuyen
FOREIGN KEY (MaND) REFERENCES NoiDungDangTuyen(MaND);

ALTER TABLE DonHieuChinh
ADD CONSTRAINT FK_DonHieuChinh_NhanVien
FOREIGN KEY (MaNVXetDuyet) REFERENCES NhanVien(MaNV),
	CONSTRAINT FK_DonHieuChinh_PhieuDangTuyen
FOREIGN KEY (MaPhieuDT) REFERENCES PhieuDangTuyen(MaPhieuDT),
	CONSTRAINT FK_DonHieuChinh_NoiDungDangTuyen
FOREIGN KEY (MaND) REFERENCES NoiDungDangTuyen(MaND);

ALTER TABLE QuangCao
ADD CONSTRAINT FK_QuangCao_PhieuDangTuyen
FOREIGN KEY (MaPhieuDT) REFERENCES PhieuDangTuyen(MaPhieuDT);

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_PhieuDangTuyen
FOREIGN KEY (MaPhieuDT) REFERENCES PhieuDangTuyen(MaPhieuDT),
	CONSTRAINT FK_HoaDon_NhanVien
FOREIGN KEY (MaNVThanhToan) REFERENCES NhanVien(MaNV);

ALTER TABLE HopDong
ADD CONSTRAINT FK_HopDong_PhieuDangTuyen
FOREIGN KEY (MaPhieuDT) REFERENCES PhieuDangTuyen(MaPhieuDT);

ALTER TABLE ChienLuocUuDai
ADD CONSTRAINT FK_ChienLuocUuDai_NhanVien
FOREIGN KEY (MaBanLanhDao) REFERENCES NhanVien(MaNV);

ALTER TABLE DoanhNghiep_UuDai
ADD CONSTRAINT FK_DoanhNghiep_UuDai_DoanhNghiep
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaDN),
	CONSTRAINT FK_DoanhNghiep_UuDai_ChienLuocUuDai
FOREIGN KEY (MaChienLuoc) REFERENCES ChienLuocUuDai(MaChienLuoc);


ALTER TABLE PhieuDangTuyen
ADD CONSTRAINT Domain_TrangThai_PhieuDangTuyen
CHECK (TrangThai in (N'Đang xét duyệt', N'Chấp nhận', N'Từ chối'));

ALTER TABLE PhieuUngTuyen
ADD CONSTRAINT Domain_TrangThai_PhieuUngTuyen
CHECK (TrangThai in (N'Đang xét duyệt', N'Không đủ điều kiện', N'Đã xử lý', N'Đạt', N'Không đạt'));

ALTER TABLE HopDong
ADD CONSTRAINT Domain_TrangThai_HopDong
CHECK (TrangThai in (N'Chưa thanh toán', N'Đang hiệu lực', N'Hết hạn'));



