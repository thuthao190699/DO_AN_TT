create database DATT
go 
use DATT

go
create table SanPham (
MaSP int primary key, 
TenSP nvarchar(50),
Gia float, 
HinhAnh image,
SoLuongTon int, 
MaTL int)

go
create table LoaiSP(
MaTL int primary key,
TenTL nvarchar(50))

go 
create table HoaDonNhap(
MaHDN int primary key, 
MaNCC int,
MaNV int,
NgayNhap date,
ThanhTien float
)

go
create table CTHDN(
MaSP int,
MaHDN int,
Dongia float, 
Soluong int, 
primary key(MaSP,MaHDN))

go
create table HoaDonXuat(
MaHDX int primary key, 
MaKH int,
MaNV int,
NgayXuat date,
ThanhTien float)
go
create table CTHDX(
MaSP int,
MaHDX int,
Soluong int,
ThanhTien float,
primary key(MaSP,MaHDX))

go
create table NhaCC(
MaNCC int primary key,
TenNCC nvarchar(50),
SDT text,
Diachi nvarchar(50) )

go
create table KhachHang(
MaKH int primary key,
TenKH nvarchar(50),
SDT text,
DiaChi nvarchar(50),
Email nvarchar(50))

go
create table NhanVien(
MaNV int primary key,
TenNV nvarchar(50),
SDT text,
Email nvarchar(50),
TK nvarchar(50),
MK nvarchar(50),
MaCV int)

go
create table ChucVu(
MaCV int primary key,
TenCV nvarchar(50),
LuongCoBan float)

go
alter table NhanVien add foreign key(MaCV) references ChucVu(MaCV)
go
alter table HoaDonNhap add foreign key (MaNCC) references NhaCC (MaNCC)
go
alter table HoaDonNhap add foreign key (MaNV) references NhanVien(MaNV)
go
alter table HoaDonXuat add foreign key (MaKH) references KhachHang(MaKH)
go
alter table HoaDonXuat add foreign key (MaNV) references NhanVien(MaNV)
go
alter table SanPham add foreign key (MaTL) references LoaiSP (MaTL)
go
alter table CTHDN add foreign key (MaSP) references SanPham(MaSP)
go
alter table CTHDN add foreign key (MaHDN) references HoaDonNhap(MaHDN)
go
alter table CTHDX add foreign key (MaSP) references SanPham(MaSP)
go
alter table CTHDX add foreign key (MaHDX) references HoaDonXuat(MaHDX)
go

insert into LoaiSP values(1,N'CPU')
insert into LoaiSP values(2,N'Mainboard')
insert into LoaiSP values(3,N'VGA')
insert into LoaiSP values(4,N'RAM')
insert into LoaiSP values(5,N'Hard Drive')
insert into LoaiSP values(6,N'PSU')
insert into LoaiSP values(7,N'Cooling')
insert into LoaiSP values(8,N'Case')
insert into LoaiSP values(9,N'Thermal paste')

go
insert into SanPham values(1,N'Ram',20000,null,5,4)
insert into SanPham values(2,N'CPU',35000,null,3,1)
insert into SanPham values(3,N'Mainboard',40000,null,2,2)
insert into SanPham values(4,N'VGA',15000,null,1,3)
insert into SanPham values(5,N'Pin',50000,null,1,5)
insert into SanPham values(6,N'SSD',90000,null,4,6)
insert into SanPham values(7,N'HDD',70000,null,2,5)
insert into SanPham values(8,N'Colling',30000,null,2,7)
insert into SanPham values(9,N'Mouse',20000,null,5,5)

go
insert into KhachHang values(101,N'Nguyen Phuc Bao','0123456',N'145 Lê Văn Việt, Q9',N'PhucBao@gmail.com')
insert into KhachHang values(102,N'Nguyen Thanh Binh','0456789',N'132 Điện Biên Phủ, Q3',N'ThanhBinh@gmail.com')
insert into KhachHang values(103,N'Nguyen Thi Thu Cam','1234567',N'1272 Lê Thị Riêng, Q5',N'ThuCam@gmail.com')
insert into KhachHang values(104,N'Van Thi Ngan Ha','0123789',N'245 Lê Văn Việt, Q9',N'NganHa@gmail.com')
insert into KhachHang values(105,N'Nguyen Thi Ngoc Hien','07891564',N'198 Kha Vạn Cân, Thủ Đức',N'NgocHien@gmail.com')
insert into KhachHang values(106,N'Nguyen Thi Thu Hong','098745236',N'520 Lê Văn Sĩ, Q3',N'ThuHong@gmail.com')
insert into KhachHang values(107,N'Tran Tuyet Nhu','076391489',N'213 Huỳnh Tấn Phát, Q7 Lê Văn Việt Q9',N'TuyetNhu@gmail.com')

go
insert into ChucVu values(1,N'admin',50000)
insert into ChucVu values(2,N'Quản lý',60000)
insert into ChucVu values(3,N'Nhân viên',55000)

go
insert into NhanVien values (1001,N'Nguyễn Thị Thu Thảo','0763914365',N'gienninguyen@gmail.com',N'thao',N'thuthao',1)
insert into NhanVien values (1002,N'Dinh Hoang Vu','6200556565',N'dhv0612@gmail.com',N'dhv0612',N'dhv06123',2)
insert into NhanVien values (1003,N'Lê Quang Vũ','48994565',N'phongthan99@gmail.com',N'qVu99',N'qVu123',3)
insert into NhanVien values (1004,N'Vuong Thi Thao','0123456789',N'VuongThao@gmail.com',N'vtt',N'vtt123',3)

go
insert into NhaCC values (111,N'Hùng Phát','1579483',N'420 Hai Bà Trưng,Q6,HCM')
insert into NhaCC values (112,N'Hồng Vân','789654312',N'172 Bùi Viện,Q1,HCM')
insert into NhaCC values (113,N'NamYang','465798227',N'960 Tao Đàn,Q1,HCM')
insert into NhaCC values (114,N'Phong Vũ','11557946',N'450 Lê Văn Việt,Q9,HCM')

go
insert into HoaDonNhap values (1,111,1002,'03-12-2020',200000)
insert into HoaDonNhap values (2,112,1003,'04-22-2020',355000)
insert into HoaDonNhap values (3,113,1004,'05-15-2020',320000)
insert into HoaDonNhap values (4,114,1001,'06-18-2020',200000)
insert into HoaDonNhap values (5,112,1002,'07-01-2020',350000)

go
insert into CTHDN values (1,1,20000,10)
insert into CTHDN values (2,2,35000,5)
insert into CTHDN values (3,3,40000,8)
insert into CTHDN values (4,4,15000,4)
insert into CTHDN values (5,5,50000,7)
insert into CTHDN values (6,2,90000,2)
insert into CTHDN values (7,4,70000,2)

go
insert into HoaDonXuat values (121,101,1003,'04-10-2020',40000)
insert into HoaDonXuat values (122,102,1002,'04-11-2020',90000)
insert into HoaDonXuat values (123,103,1002,'05-02-2020',105000)
insert into HoaDonXuat values (124,104,1003,'06-12-2020',200000)
insert into HoaDonXuat values (125,105,1004,'06-13-2020',280000)
insert into HoaDonXuat values (126,106,1004,'07-01-2020',45000)

go
insert into CTHDX values (1,121,2,40000)
insert into CTHDX values (6,122,1,90000)
insert into CTHDX values (2,123,3,105000)
insert into CTHDX values (3,124,5,200000)
insert into CTHDX values (7,125,4,280000)
insert into CTHDX values (4,126,3,45000)