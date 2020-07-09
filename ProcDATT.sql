use DATT

---------------SanPham----------------
go
create proc selectSanPham 
as 
begin 
select * from SanPham 
end

go
create proc ThemSanPham(@MaSP int,@TenSP nvarchar(50),@Gia float,@HinhAnh image,@SoLuongTon int,@MaTL int)
as
begin
insert into SanPham  values (@MaSP,@TenSP,@Gia,@HinhAnh,@SoLuongTon,@MaTL)
end
--exec ThemSanPham  10,aaa,2000,null,1,1

go
create proc UpdateSanPham(@MaSP int,@TenSP nvarchar(50),@Gia float,@HinhAnh image, @SoLuongTon int,@MaTL int)
as 
begin
update SanPham set TenSP=@TenSP,Gia=@Gia,HinhAnh=@HinhAnh,SoLuongTon=@SoLuongTon,MaTL=@MaTL where MaSP=@MaSP
end
exec UpdateSanPham  10,'abc',2000,null,2,1
go
create proc DeleteSanPham(@MaSP int)
as 
begin
delete from SanPham where MaSP=@MaSP
end
--exec DeleteSanPham 10
-------------------KhachHang-------------
go
create proc ThemKhachHang(@MaKH int, @TenKH nvarchar(50), @SDT text, @DiaChi nvarchar(50), @Email nvarchar(50))
as
begin
insert into KhachHang values (@MaKH, @TenKH, @SDT, @DiaChi, @Email)
end
--exec ThemKhachHang 108,'aaa','0001111','vhj','aaa@gmail.com'
go
create proc UpdateKhachHang(@MaKH int,@TenKH nvarchar(50),@SDT text,@DiaChi nvarchar(50),@Email nvarchar(50))
as begin
update KhachHang set TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi,Email=@Email where MaKH=@MaKH
end
--exec UpdateKhachHang 108,'ccc','0001111','vhj','aaa@gmail.com'
go 
create proc DeleteKhachHang(@MaKH int)
as 
begin
delete from KhachHang where MaKH=@MaKH
end
--exec DeleteKhachHang 108

----------------------NhanVien----------------
go
create proc select_Nhanvien
as begin
select * from NhanVien
end

go 
create proc ThemNhanVien(@MaNV int, @TenNV nvarchar(50), @SDT text, @Email nvarchar(50), @TK nvarchar(50), @MK nvarchar(50), @MaCV int)
as 
begin
insert into NhanVien values (@MaNV, @TenNV, @SDT, @Email, @TK, @MK, @MaCV)
end
--exec ThemNhanVien 1005,'aaa','1111111','aaa@gmail.com','123456','vv5323',2
go
create proc UpdateNhanVien(@MaNV int, @TenNV nvarchar(50), @SDT text, @Email nvarchar(50), @TK nvarchar(50), @MK nvarchar(50), @MaCV int)
as 
begin
update NhanVien set TenNV=@TenNV,SDT=@SDT,Email=@Email where MaNV=@MaNV
end
--exec UpdateNhanVien 1005,'aba','222','aaa@gmail.com','123456','vv5323',2

go
create proc DeleteNhanVien(@MaNV int)
as
 begin
delete from NhanVien where MaNV=@MaNV
end
--exec DeleteNhanVien 1005

------------LoaiSP----------------
go
create proc ThemLoaiSP(@MaTL int, @TenTL nvarchar(50))
as 
begin
insert into LoaiSP values (@MaTL,@TenTL)
end
--exec ThemLoaiSP 10,'aaa'
go
create proc UpdateLoaiSP(@MaTL int,@TenTL nvarchar(50))
as 
begin
update LoaiSP set TenTL=@TenTL where MaTL=@MaTL
end
--exec UpdateLoaiSP 10,'abc'
go
create proc DeleteLoaiSP(@MaTL int)
as begin
delete from LoaiSP where MaTL=@MaTL
end
--exec DeleteLoaiSP 10
------------------HoaDonNhap----------------
go
create proc ThemHoaDonNhap(@MaHDN int,@MaNCC int,@MaNV int,@NgayNhap date,@ThanhTien int)
as 
begin
insert into HoaDonNhap values(@MaHDN,@MaNCC,@MaNV,@NgayNhap,@ThanhTien)
end
--exec ThemHoaDonNhap 6,111,1002,'07-07-2020',2000 
go
create proc UpdateHoaDonNhap(@MaHDN int,@MaNCC int,@MaNV int,@NgayNhap date,@ThanhTien int)
as 
begin
update HoaDonNhap set MaNCC=@MaNCC,MaNV=@MaNV,NgayNhap=@NgayNhap,ThanhTien=@ThanhTien where MaHDN=@MaHDN
end
exec UpdateHoaDonNhap 6,111,1004,'07-07-2020',null
go
create proc DeleteHoaDonNhap (@MaHDN int)
as begin
delete from HoaDonNhap where MaHDN=@MaHDN
end
--exec DeleteHoaDonNhap 6
------------------------------------
go
alter proc TinhTongTien (@MaHDN int)
as begin
	declare @ThanhTien float
	set @ThanhTien = (select SUM(Soluong*Dongia) as 'ThanhTien'
						from CTHDN,HoaDonNhap
						where CTHDN.MaHDN=HoaDonNhap.MaHDN
						and HoaDonNhap.MaHDN=@MaHDN)

	update HoaDonNhap set ThanhTien= ThanhTien + @ThanhTien where MaHDN = @MaHDN
end
--exec TinhTongTien 6
-------------CTHDN---------------------
go
create proc ThemCTHDN (@MaSP int,@MaHDN int,@Dongia float, @Soluong int)
as 
begin
insert into CTHDN values(@MaSP ,@MaHDN ,@Dongia , @Soluong )
end
--exec ThemCTHDN 1,6,20000,2

go
alter proc UpdateCTHDNGiaBanCu (@MaSP int,@MaHDN int, @Soluong int)
as 
begin
	declare @soluongcu int
	set @soluongcu = (select Soluong from CTHDN where MaHDN=@MaHDN and MaSP = @MaSP)
	if (@soluongcu != NULL)
	begin
		update SanPham set SoLuongTon = SoLuongTon + @Soluong where MaSP = @MaSP
		update CTHDN set Soluong = Soluong + @Soluong where MaHDN=@MaHDN and MaSP = @MaSP
	end
	else
	begin
		set @soluongcu = 0
		update SanPham set SoLuongTon = SoLuongTon + @Soluong where MaSP = @MaSP
		update CTHDN set Soluong =  Soluong + @Soluong where MaHDN=@MaHDN and MaSP = @MaSP
	end
end
--exec UpdateCTHDNGiaBanCu  1,6,4

go
alter proc UpdateCTHDNGiaBanMoi (@MaSP int,@MaHDN int,@Dongia float, @Soluong int)
as 
begin
	declare @soluongcu int
	set @soluongcu = (select SoLuong from CTHDN where MaHDN=@MaHDN and MaSP = @MaSP)
	if (@soluongcu != NULL)
	begin
		update SanPham set Gia = @Dongia, SoLuongTon = SoLuongTon + @Soluong where MaSP = @MaSP
		update CTHDN set Dongia = @Dongia , Soluong = Soluong + @Soluong where MaHDN=@MaHDN and MaSP = @MaSP
	end
	else
	begin
		set @soluongcu = 0
		update SanPham set Gia = @Dongia, SoLuongTon = SoLuongTon + @Soluong where MaSP = @MaSP
		update CTHDN set Dongia = @Dongia, Soluong = Soluong + @Soluong where MaHDN=@MaHDN and MaSP = @MaSP
	end
end
exec UpdateCTHDNGiaBanMoi  1,6,40000,4


go
create proc DeleteCTHDN(@MaHDN int)
as
begin
delete from CTHDN where MaHDN=@MaHDN
end


--------------------HoaDonXuat----------------
go
create proc selectHoaDonXuat
as
begin
select * from HoaDonXuat 
end

go
create proc ThemHoaDonXuat(@MaHDX int,@MaKH int,@MaNV int,@NgayXuat date,@ThanhTien float)
as
begin
insert into HoaDonXuat values(@MaHDX,@MaKH,@MaNV,@NgayXuat,@ThanhTien)
end
--exec ThemHoaDonXuat 127,104,1003,'07-07-2020',null

go
create proc UpdateHoaDonXuat(@MaHDX int,@MaKH int,@MaNV int,@NgayXuat date,@ThanhTien float)
as 
begin
update HoaDonXuat set MaKH=@MaKH,MaNV=@MaNV,NgayXuat=@NgayXuat,ThanhTien=@ThanhTien where MaHDX=@MaHDX
end
--exec UpdateHoaDonXuat 127,104,1002,'07-07-2020',null

go
create proc DeleteHoaDonXuat (@MaHDX int)
as begin
delete from HoaDonXuat where MaHDX=@MaHDX
end

---------------CTHDX---------------
go
create proc ThemCTHDX (@MaSP int,@MaHDX int, @Soluong int)
as 
begin
	insert into CTHDX values(@MaSP ,@MaHDX , @Soluong)
	update SanPham set SoLuongTon = SoLuongTon - @Soluong where MaSP = @MaSP
end
exec ThemCTHDX 1,127,2

go 
create proc UpdateCTHDX(@MaSP int,@MaHDX int, @Soluong int)
as
begin
	declare @soluongcu int
	set @soluongcu = (select Soluong from CTHDX where MaSP = @MaSP and MaHDX = @MaHDX)
	update SanPham set SoLuongTon = SoLuongTon + @soluongcu - @Soluong where MaSP = @MaSP
	update CTHDX set Soluong = @Soluong where MaSP = @MaSP and MaHDX = @MaHDX
end
exec UpdateCTHDX 1,127,2

go 
create proc DeleteCTHDX(@MaSP int,@MaHDX int)
as
begin
	declare @soluongcu int
	set @soluongcu = (select Soluong from CTHDX where MaSP = @MaSP and MaHDX = @MaHDX)
	update SanPham set SoLuongTon = SoLuongTon + @soluongcu where MaSP = @MaSP
	delete from CTHDX where MaSP = @MaSP and MaHDX = @MaHDX
end

exec DeleteCTHDX 1,127
-----------------
go
alter proc TinhTongTienHDX (@MaHDX int)
as begin
	declare @ThanhTien float, @ThanhTienTruoc float
	set @ThanhTienTruoc = (select ThanhTien from HoaDonXuat where MaHDX = @MaHDX)
	set @ThanhTien = (select SUM(CTHDX.Soluong*SanPham.Gia) as 'ThanhTien'
						from CTHDX,SanPham
						where CTHDX.MaSP=SanPham.MaSP and CTHDX.MaHDX=@MaHDX)
	if (@ThanhTienTruoc != NULL)
	begin
		update HoaDonXuat set ThanhTien= ThanhTien + @ThanhTien where MaHDX = @MaHDX
	end
	else
	begin
		set @ThanhTienTruoc = 0
		update HoaDonXuat set ThanhTien= @ThanhTienTruoc + @ThanhTien where MaHDX = @MaHDX
	end
	
end
exec TinhTongTienHDX 127

----------------NhaCC-------------------
go
create proc NhaCungCap
as begin
select * from NhaCC
end

go
create proc ThemNhaCungCap (@MaNCC int,@TenNCC nvarchar(50),@SDT text,@Diacchi nvarchar(50))
as 
begin
insert into NhaCC values(@MaNCC,@TenNCC,@SDT,@Diacchi)
end

go
create proc UpdateNhaCungCap (@MaNCC int,@TenNCC nvarchar(50),@SDT text,@Diacchi nvarchar(50))
as begin
update NhaCC set TenNCC=@TenNCC,SDT=@SDT,Diachi=@Diacchi where MaNCC=@MaNCC
end

go
create proc DeleteNhaCungCap (@MaNCC int)
as begin
delete from NhaCC where MaNCC=@MaNCC
end
------------------------
go
create proc updateSL (@ma int, @SL INT)
as begin
update SanPham set SoLuongTon = @SL where MaSP = @ma
end

go
create proc update_Soluongton(@MaSP int,@SoluongTon int)
as begin
declare @soLuongTam int
declare @soLuongCTHDN int
set @soLuongCTHDN = (select Soluong from CTHDN where MaSP=@MaSP)
set @soluongTam = (select SoLuongTon from SanPham where MaSP=@MaSP)
update SanPham set SoLuongTon=@soLuongTam+@SoluongTon where MaSP=@MaSP
end
--------------------------
go
create proc ThemTongTienXuat(@MaHDX int)
as begin
declare @sum float
set @sum= (select SUM(ct.Soluong*hd.ThanhTien) as 'ThanhTien'
			from CTHDX ct,HoaDonXuat hd
			where ct.MaHDX=hd.MaHDX and hd.MaHDX=@MaHDX)
update HoaDonXuat set ThanhTien=@sum where MaHDX=@MaHDX
end
--------------------------
go
create proc ThemTongTienNhap(@MaHDN int)
as begin
declare @sum float
set @sum= (select SUM(Soluong*ThanhTien) as 'ThanhTien'
			from CTHDN ct,HoaDonNhap hd
			where ct.MaHDN=hd.MaHDN and hd.MaHDN=@MaHDN)
update HoaDonNhap set ThanhTien=@sum where MaHDN=@MaHDN
end
--------------------------
go
create proc updateMK(@MaNV int, @MK nvarchar(50))
as begin
update NhanVien set MK=@MK where MaNV=@MaNV
end
--------------------------
go
create proc tongtienthangtruoc
as begin
	declare @count int
	if(DATEPART (m,GETDATE())-1>0)
	begin
		select @count = COUNT(NgayXuat) 
		from HoaDonXuat hd
		where DATEPART(MONTH,NgayXuat) = DATEPART(MONTH,GETDATe())-1 and DATEPART(YEAR,NgayXuat) = DATEPART(YEAR,GETDATe())
		if(@count>0)
		begin 
		select sum(ThanhTien) as 'thanhtien'from HoaDonXuat
		where DATEPART(MONTH,NgayXuat) = DATEPART(MONTH,GETDATe())-1 and DATEPART(YEAR,NgayXuat) = DATEPART(YEAR,GETDATe())
		end
		else begin
		select 0 as 'thanhtien'
			end
	end
	else
		begin 
		select @count = COUNT(NgayXuat) from HoaDonXuat hd
	where DATEPART(MONTH,NgayXuat) = DATEPART(MONTH,GETDATe())-1 and DATEPART(YEAR,NgayXuat) = DATEPART(YEAR,GETDATe())-1
		if(@count>0)
		begin 
		select sum(ThanhTien) as 'thanhtien'from HoaDonXuat
		where DATEPART(MONTH,NgayXuat) = DATEPART(MONTH,GETDATe())-1 and DATEPART(YEAR,NgayXuat) = DATEPART(YEAR,GETDATe())-1
		end
		else begin
		select 0 
			end
	end
end
-------------------------
go 
create proc tongtienthangnay
as 
begin
	select SUM(ThanhTien) as 'ThanhTien'
	from HoaDonXuat
	where DATEPART(MONTH, NgayXuat) = DATEPART(MONTH, GETDATE())
end
-----------------
go
create proc select_ThongKeSLSP
as 
begin
select MaSP,TenSP,SoLuongTon,TenTL from SanPham,LoaiSP where SoLuongTon <= 2 and SanPham.MaTL=LoaiSP.MaTL
end
-------------
go 
create proc TimSanPham
@text nvarchar(50)
as
begin
select*from SanPham where CONCAT(MaSP, TenSP) like '%'+@text+'%'
end
----------------
go 
create proc TimSDT  
@text nvarchar(50)
as
begin
select*from KhachHang where CONCAT(TenKH, SDT) like '%'+@text+'%'
end