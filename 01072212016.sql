USE [master]
GO
/****** Object:  Database [QLBH_CuaHangBanMayTinhVaLinhKien]    Script Date: 22-Jan-16 01:07:28 ******/
CREATE DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH_CuaHangBanMayTinhVaLinhKien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLBH_CuaHangBanMayTinhVaLinhKien.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLBH_CuaHangBanMayTinhVaLinhKien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLBH_CuaHangBanMayTinhVaLinhKien_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH_CuaHangBanMayTinhVaLinhKien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH_CuaHangBanMayTinhVaLinhKien', N'ON'
GO
USE [QLBH_CuaHangBanMayTinhVaLinhKien]
GO
/****** Object:  StoredProcedure [dbo].[AddDeliveryBill]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddDeliveryBill]
@MaPhieuXuatKho nvarchar(10),
@NgayLapPhieu smalldatetime,
@MaNguoiNhan nvarchar(10),
@MaNguoiLapPhieu nvarchar(10),
@GhiChu nvarchar(100)
as 
insert into PHIEUXUATKHO
values(@MaPhieuXuatKho, @NgayLapPhieu, @MaNguoiNhan, @MaNguoiLapPhieu, @GhiChu) 




GO
/****** Object:  StoredProcedure [dbo].[AddDeliveryBillDetail]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddDeliveryBillDetail]
@MaChiTietPhieuXuatKho nvarchar(10),
@MaPhieuXuatKho nvarchar(10),
@MaSanPham nvarchar(10),
@Soluong int,
@GhiChu nvarchar(100)
as 
insert into CHITIETPHIEUXUATKHO
values(@MaChiTietPhieuXuatKho, @MaPhieuXuatKho, @MaSanPham, @Soluong, @GhiChu)




GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddProduct]
@MaSanPham nvarchar(10),
@TenSanPham nvarchar(50), 
@ThoiGianBaohanh int,
@LoaiSanPham nvarchar(50),
@DonGiaNhap float,
@DonGiaBan float,
@SoLuong int, 
@DonViTinh nvarchar(50),
@GhiChu nvarchar(100)
as
	insert into SANPHAM(MaSanPham, TenSanPham, LoaiSanPham, ThoiGianBaoHanh, DonGiaNhap, DonGiaBan, SoLuong, DonViTinh, GhiChu)
	values(@MaSanPham, @TenSanPham, @LoaiSanPham, @ThoiGianBaohanh, @DonGiaNhap, @DonGiaBan, @SoLuong, @DonViTinh, @GhiChu)




GO
/****** Object:  StoredProcedure [dbo].[AddWarehouse]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddWarehouse]
@MaKho nvarchar(10),
@TenKho nvarchar(50), 
@GhiChu nvarchar(100)
as
	insert into KHO(MaKho, TenKho, Ghichu)
	values(@MaKho, @TenKho, @GhiChu)




GO
/****** Object:  StoredProcedure [dbo].[AddWarehouseBill]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddWarehouseBill]
@MaPhieuNhapKho nvarchar(10),
@NgayLapPhieu smalldatetime,
@MaNguoiLapPhieu nvarchar(10),
@GhiChu nvarchar(100)
as 
insert into PHIEUNHAPKHO
values(@MaPhieuNhapKho, @NgayLapPhieu, @MaNguoiLapPhieu, @GhiChu)




GO
/****** Object:  StoredProcedure [dbo].[AddWarehouseBillDetail]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddWarehouseBillDetail]
@MaPhieuNhapKho nvarchar(10),
@MaSanPham nvarchar(10),
@Soluong int,
@GhiChu nvarchar(100)
as 
insert into CHITIETPHIEUNHAPKHO
values(@MaPhieuNhapKho, @MaSanPham, @Soluong, @GhiChu)




GO
/****** Object:  StoredProcedure [dbo].[CreateFuntion]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
CREATE proc [dbo].[CreateFuntion]
@MaChucNang nvarchar(10),
@BanHang int,
@Kho int,
@BaoHanh int,
@ThongKe int,
@ThietLap int
as
begin
Insert into CHUCNANG values(@MaChucNang,@BanHang,@Kho,@BaoHanh,@ThongKe,@ThietLap);
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------------------------------------
create proc [dbo].[DeleteEmployee]
@MaNV nvarchar(10),
@TrangThai nvarchar(50)
as
begin
update NHANVIEN SET TrangThai=@TrangThai  
where MaNV=@MaNV
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[DeletePosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
create proc [dbo].[DeletePosition]
@MaChucVu nvarchar(10)
as
begin
update CHUCVU SET  DaXoa='1'
where MaChucVu=@MaChucVu
end
--------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DeleteProduct] 
@MaSanPham nvarchar(10)
as 
delete from SANPHAM 
where MaSanPham = @MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[EditProduct]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EditProduct]
@MaSanPham nvarchar(10),
@TenSanPham nvarchar(50), 
@LoaiSanPham nvarchar(50),
@ThoiGianBaoHanh int,
@DonGiaNhap float,
@DonGiaBan float,
@DonViTinh nvarchar(50),
@GhiChu nvarchar(100)
as
	update SANPHAM
	set 
	TenSanPham = @TenSanPham,
	LoaiSanPham = @LoaiSanPham,
	ThoiGianBaoHanh = @ThoiGianBaoHanh,
	DonGiaNhap =  @DonGiaNhap,
	DonGiaBan = @DonGiaBan,
	DonViTinh = @DonViTinh,
	GhiChu = @GhiChu
	where MaSanPham = @MaSanPham




GO
/****** Object:  StoredProcedure [dbo].[EditWarehouse]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EditWarehouse]
@MaKho nvarchar(10),
@TenKho nvarchar(50), 
@GhiChu nvarchar(100)
as
	update KHO
	set TenKho = @TenKho,
	Ghichu = @GhiChu
	where Makho = @MaKho




GO
/****** Object:  StoredProcedure [dbo].[GeCountEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------
create proc [dbo].[GeCountEmployee]
as
begin
Select count(*)from NHANVIEN;
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetAllChangingBill]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllChangingBill]
as
begin
Select MaHDD, NgayDoi, HOADONDOI.MaKH, TenKH, MaNV, MaHD, s1.TenSanPham, s2.TenSanPham, PhiDoi, PhiHoan from HOADONDOI join KHACHHANG on HOADONDOI.MaKH=KHACHHANG.MaKH join SANPHAM s1 on s1.MaSanPham=HOADONDOI.MaSanPham join SANPHAM s2 on s2.MaSanPham=HOADONDOI.MaSanPhamThayThe
end


GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------------------
create proc [dbo].[GetAllEmployee]
as
begin
Select *
from NHANVIEN
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetAllPosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------
create proc [dbo].[GetAllPosition]
as
begin
Select *
from CHUCVU 
where DaXoa='0'
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetAllReturningBill]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllReturningBill]
as
Select MaHDT, NgayTra, HOADONTRA.MaKH, TenKH, MaNV, MaHD, SANPHAM.TenSanPham, PhiHoan from HOADONTRA join KHACHHANG on HOADONTRA.MaKH=KHACHHANG.MaKH join SANPHAM on SANPHAM.MaSanPham=HOADONTRA.MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[GetCountEmployeeUsePosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------
create proc [dbo].[GetCountEmployeeUsePosition]
@MaChucVu nvarchar(10)
as
begin
Select count(*)from NHANVIEN where ChucVu = @MaChucVu
end
--------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[GetCountProductByID]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetCountProductByID]
@MaSanPham nvarchar(10)
as 
select SoLuong
from SANPHAM
where MaSanPham = @MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryBillDetailList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDeliveryBillDetailList] 
as 
select MaChiTietPhieuXuatKho, 
MaPHieuXuatKho,
CHITIETPHIEUXUATKHO.MaSanPham,
SANPHAM.DonGiaNhap,
CHITIETPHIEUXUATKHO.SoLuong,
CHITIETPHIEUXUATKHO.GhiChu
from CHITIETPHIEUXUATKHO 
inner join SANPHAM
on SANPHAM.MaSanPham = CHITIETPHIEUXUATKHO.MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryBillDetailListWithMaPhieuXuatKho]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDeliveryBillDetailListWithMaPhieuXuatKho]
@MaPhieuXuatKho nvarchar(10)
as 
select MaChiTietPhieuXuatKho, 
MaPHieuXuatKho,
CHITIETPHIEUXUATKHO.MaSanPham,
SANPHAM.DonGiaNhap,
CHITIETPHIEUXUATKHO.SoLuong,
CHITIETPHIEUXUATKHO.GhiChu
from CHITIETPHIEUXUATKHO 
inner join SANPHAM
on SANPHAM.MaSanPham = CHITIETPHIEUXUATKHO.MaSanPham
where MaPhieuXuatKho = @MaPhieuXuatKho


GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryBillList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDeliveryBillList]
as 
select *
from PHIEUXUATKHO


GO
/****** Object:  StoredProcedure [dbo].[GetDistributorList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDistributorList]
as 
select MaNhaPhanPhoi,
TenNhaPhanPhoi,
DiaChi, 
SoDienThoai, 
Email,
MaSoThue,
GhiChu 
from NHAPHANPHOI 


GO
/****** Object:  StoredProcedure [dbo].[GetEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------
create proc [dbo].[GetEmployee]
@MaNV nvarchar(10)
as
begin
Select * 
from NHANVIEN 
where  MaNV=@MaNV
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetEmployeeList]
as
select * 
from NHANVIEN


GO
/****** Object:  StoredProcedure [dbo].[GetFuntion]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
create proc [dbo].[GetFuntion]
@MaCN nvarchar(10)
as
begin
Select *
from CHUCNANG where  MaCN = @MaCN
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[GetFuntionByPositionID]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetFuntionByPositionID]
@MaCN nvarchar(10)
as
begin
select CHUCNANG.BanHang, CHUCNANG.Kho, CHUCNANG.BaoHanh, CHUCNANG.ThongKe, CHUCNANG.ThietLap from CHUCNANG where MaCN = @MaCN;
end

GO
/****** Object:  StoredProcedure [dbo].[GetImage]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------------------------------------
create proc [dbo].[GetImage]
@MaNV nvarchar(10)
as
begin
 Select AnhThe
from NHANVIEN 
where MaNV =@MaNV;
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetIncomeByDate]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetIncomeByDate](@dateFrom SmallDateTime, @dateTo SmallDateTime)
as
-- Lấy danh tổng thành tiền và tổng cố lượng sản phẩm gom nhóm theo theo tháng
Select sum(CHITIETHOADON.SoLuong) as SoLuongBan, sum(ThanhTien) as DoanhThu from HOADON join CHITIETHOADON ON HOADON.MaHD= CHITIETHOADON.MaHD where NgayHD>= @dateFrom and NgayHD<=@dateTo


GO
/****** Object:  StoredProcedure [dbo].[GetIncomeByYear]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetIncomeByYear](@yearFrom int, @yearTo int)
as
-- Lấy danh tổng thành tiền và tổng cố lượng sản phẩm gom nhóm theo theo năm
Select year(NgayHD) as Nam, sum(CHITIETHOADON.SoLuong) as SoLuongBan, sum(ThanhTien) as DoanhThu from HOADON join CHITIETHOADON ON HOADON.MaHD= CHITIETHOADON.MaHD where year(NgayHD)>= @yearFrom and year(NgayHD)<=@yearTo Group by year(NgayHD)

GO
/****** Object:  StoredProcedure [dbo].[GetListProducts]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetListProducts]
as
select *
	from SANPHAM


GO
/****** Object:  StoredProcedure [dbo].[GetListWarehouses]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetListWarehouses]
as
select [MaKho]
      ,[TenKho]
      ,[GhiChu]
  from [QLBH_CuaHangBanMayTinhVaLinhKien].[dbo].[KHO]


GO
/****** Object:  StoredProcedure [dbo].[GetPasswordEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetPasswordEmployee]
@MaNV nvarchar(10)
as
begin
select PassWord from NHANVIEN where MaNV = @MaNV;
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[GetPosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- co the dung lai 
create proc [dbo].[GetPosition]
@Machucvu nvarchar(10)
as
begin
Select *
from CHUCVU
where MaChucVu =@Machucvu and DaXoa='0';
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[GetPositionCount]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
CREATE proc [dbo].[GetPositionCount]
as
begin
Select COUNT (*)
from CHUCVU 
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetPositionName]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- co the dung lai 
create proc [dbo].[GetPositionName]
@Machucvu nvarchar(10)
as
begin
Select TenChucVu
from CHUCVU
where MaChucVu =@Machucvu and DaXoa='0';
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[GetWarehouseBillDetailList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetWarehouseBillDetailList] 
as 
select MaChiTietPhieuNhapKHo, 
MaPHieuNhapKho,
CHITIETPHIEUNHAPKHO.MaSanPham,
SANPHAM.DonGiaNhap,
CHITIETPHIEUNHAPKHO.SoLuong,
CHITIETPHIEUNHAPKHO.GhiChu
from CHITIETPHIEUNHAPKHO 
inner join SANPHAM
on SANPHAM.MaSanPham = CHITIETPHIEUNHAPKHO.MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[GetWarehouseBillDetailListWithMaPhieuNhapKho]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetWarehouseBillDetailListWithMaPhieuNhapKho]
@MaPhieuNhapKho nvarchar(10)
as 
select MaChiTietPhieuNhapKHo, 
MaPHieuNhapKho,
CHITIETPHIEUNHAPKHO.MaSanPham,
SANPHAM.DonGiaNhap,
CHITIETPHIEUNHAPKHO.SoLuong,
CHITIETPHIEUNHAPKHO.GhiChu
from CHITIETPHIEUNHAPKHO 
inner join SANPHAM
on SANPHAM.MaSanPham = CHITIETPHIEUNHAPKHO.MaSanPham
where MaPhieuNhapKho = @MaPhieuNhapKho


GO
/****** Object:  StoredProcedure [dbo].[GetWarehouseBillList]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetWarehouseBillList]
as 
select *
from PHIEUNHAPKHO


GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------------------------------
create proc [dbo].[InsertEmployee]
@MaNV nvarchar(10),
@Ten nvarchar(50),
@GioiTinh nvarchar(50),
@CMND nvarchar(15),
@SDT nvarchar(15),
@NgaySinh smalldatetime,
@DiaChi nvarchar(50),
@NoiSinh nvarchar(50),
@Tuoi nvarchar(10),
@ChucVu nvarchar(10),
@Luong nvarchar(50),
@NgayVaoLam smalldatetime,
@AnhThe image,
@TrangThai nvarchar(50),
@Password nvarchar(16),
@MaCN nvarchar(10)
as
begin
insert into NHANVIEN values(@MaNV,@Ten,@GioiTinh,@CMND,@SDT,@NgaySinh,@DiaChi,@NoiSinh
,@Tuoi,@ChucVu,@Luong,@NgayVaoLam,@AnhThe,@TrangThai,@Password,@MaCN);
end
--------------------------------------------------------------
--------------------------------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[SavePosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
create proc [dbo].[SavePosition]
@MaChucVu nvarchar(10),
@TenChucVu nvarchar(20),
@Luong nvarchar(50),
@MaCN nvarchar(10)
as
begin
insert into CHUCVU values(@MaChucVu,@TenChucVu,@Luong,@MaCN,'0')
end
--------------------------------------------------------------



GO
/****** Object:  StoredProcedure [dbo].[SearchWarehouse]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SearchWarehouse]
@Query nvarchar(50)
as 
	select [MaKho]
      ,[TenKho]
      ,[GhiChu]
	  from [QLBH_CuaHangBanMayTinhVaLinhKien].[dbo].[KHO]
	  where 
	  MaKho like '%' + @Query + '%' or 
	  TenKho like '%' + @Query + '%' or 
	  GhiChu like '%' + @Query + '%' 


GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllPTHBHByMaPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllPTHBHByMaPTNBH]
@MaPTNBH nvarchar(10)
as
begin
	select ctptnbh.MaSanPham, ctptnbh.MoTaLoi, ctptnbh.SoLuong
	from CHITIETPHIEUTIEPNHANBAOHANH ctptnbh
	where ctptnbh.MaPTNBH = @MaPTNBH
end



GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllPTNBH]
as
begin
	select * 
	from PHIEUTIEPNHANBAOHANH
end




GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaHD]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetMaHD]
as
begin
	select MaHD
	from HOADON
end


GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaNV]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_GetMaNV]
as
begin 
	select MaNV
	from NHANVIEN
end



GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetMaPTNBH]
as
begin 
	select MaPTNBH
	from PHIEUTIEPNHANBAOHANH
end



GO
/****** Object:  StoredProcedure [dbo].[sp_GetPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_GetPTNBH]
@MaPTNBH nvarchar(10)
as
begin
	select *
	from PHIEUTIEPNHANBAOHANH ptnbh
	where ptnbh.MaPTNBH = @MaPTNBH
end





GO
/****** Object:  StoredProcedure [dbo].[sp_GetSanPhamByMaHD]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetSanPhamByMaHD]
@MaHD nvarchar(10)
as
begin
	select sp.MaSanPham, sp.TenSanPham, cthd.SoLuong, sp.ThoiGianBaoHanh, hd.NgayHD
	from SANPHAM sp, HOADON hd, CHITIETHOADON cthd
	where hd.MaHD = @MaHD and hd.MaHD = cthd.MaHD and cthd.MaSanPham = sp.MaSanPham
end

GO
/****** Object:  StoredProcedure [dbo].[sp_GetSanPhamByMaSanPham]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetSanPhamByMaSanPham]
@MaSanPham nvarchar(10)
as
begin
	select * 
	from SANPHAM
	where SANPHAM.MaSanPham = @MaSanPham
end



GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTPTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertCTPTHBH]
@MaPTHBH nvarchar(10),
@MaSanPham nvarchar(10),
@MoTaLoi nvarchar(100),
@SoLuong int,
@GhiChu nvarchar(100)
as 
begin
	INSERT INTO [dbo].[CHITIETPHIEUTRAHANGBAOHANH]
           ([MaPTHBH]
           ,[MaSanPham]
           ,[MoTaLoi]
           ,[SoLuong]
           ,[GhiChu])
     VALUES
           (@MaPTHBH
           ,@MaSanPham
           ,@MoTaLoi
           ,@SoLuong
           ,@GhiChu)
end


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InsertCTPTNBH]
@MaHoaDon nvarchar(10),
@MaSanPham nvarchar(10),
@MoTaLoi  nvarchar(100),
@SoLuong int,
@MaPTNBH  nvarchar(10)
as
begin 
	INSERT INTO [dbo].[CHITIETPHIEUTIEPNHANBAOHANH]
           (--[MaCTPTNBH],
			[MaHoaDon]
           ,[MaSanPham]
           ,[MoTaLoi]
           ,[SoLuong]
           ,[MaPTNBH])
     VALUES
           (--@MaCTPTNBH,
			@MaHoaDon
           ,@MaSanPham
           ,@MoTaLoi
           ,@SoLuong
           ,@MaPTNBH)
end



GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCTPXLK]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_InsertCTPXLK]
@MaCTPXLK int,
@MaPXLKBH nvarchar(10),
@MaLinhKien nvarchar(10),
@SoLuong int
as
begin
INSERT INTO [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH]
           ([MaCTPXLK]
           ,[MaPXLKBH]
           ,[MaLinhKien]
           ,[SoLuong]
			)
     VALUES
           (@MaCTPXLK
           ,@MaPXLKBH
           ,@MaLinhKien
           ,@SoLuong)
end


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertPTHBH]
@MaPTHBH nvarchar(10),
@MaNV nvarchar(10),
@MaPTNBH nvarchar(10),
@NgayLap smalldatetime
as
begin
	INSERT INTO [dbo].[PHIEUTRAHANGBAOHANH]
           ([MaPTHBH]
           ,[MaNV]
           ,[MaPTNBH]
           ,[NgayLapPhieu])
     VALUES
           (@MaPTHBH
           ,@MaNV
           ,@MaPTNBH
           ,@NgayLap)
end


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertPTNBH]
@MaPTNBH nvarchar(10),
@MaNV nvarchar(10),
@NgayLap smalldatetime
as
begin
	INSERT INTO [dbo].[PHIEUTIEPNHANBAOHANH]
           ([MaPTNBH]
           ,[MaNV]
           ,[NgayLap])
     VALUES
           (@MaPTNBH
           ,@MaNV
           ,@NgayLap)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertPXLK]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_InsertPXLK]
@MaPXLKBH nvarchar(10),
@MaPTNBH nvarchar(10),
@MaNVKT nvarchar(10),
@MaNVKho nvarchar(10),
@NgayLap smalldatetime
as
begin
	INSERT INTO [dbo].[PHIEUXUATLINHKIENBAOHANH]
           ([MaPXLKBH]
		   ,[MaPTNBH]
           ,[MaNVKT]
           ,[MaNVKho]
           ,[NgayLap])
     VALUES
           (@MaPXLKBH
		   ,@MaPTNBH
           ,@MaNVKT
           ,@MaNVKho
           ,@NgayLap)
end



GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHangByPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_KhachHangByPTNBH]
@MaPTNBH nvarchar(10)
as
begin 
	select kh.MaKH, kh.TenKH
	from KHACHHANG kh, PHIEUTIEPNHANBAOHANH ptnbh, CHITIETPHIEUTIEPNHANBAOHANH ctptnbh, HOADON hd
	where ptnbh.MaPTNBH = @MaPTNBH and ptnbh.MaPTNBH = ctptnbh.MaPTNBH and ctptnbh.MaHoaDon = hd.MaHD and hd.MaKH = kh.MaKH
end

GO
/****** Object:  StoredProcedure [dbo].[sp_PrintPTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_PrintPTHBH]
@TuNgay smalldatetime,
@DenNgay smalldatetime
as
begin
	select *
	from PHIEUTRAHANGBAOHANH pthbh
	where @TuNgay < pthbh.NgayLapPhieu and pthbh.NgayLapPhieu < @DenNgay
end

GO
/****** Object:  StoredProcedure [dbo].[sp_PrintPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_PrintPTNBH]
@TuNgay smalldatetime,
@DenNgay smalldatetime
as
begin
	select *
	from PHIEUTIEPNHANBAOHANH ptnbh
	where @TuNgay < ptnbh.NgayLap and ptnbh.NgayLap < @DenNgay
end


GO
/****** Object:  StoredProcedure [dbo].[sp_SprintPTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SprintPTHBH]
@MaPTHBH nvarchar(10)
as
begin 
	select ctpthbh.MaPTHBH, ctpthbh.MaSanPham, sp.TenSanPham, ctpthbh.MoTaLoi, ctpthbh.SoLuong, ctpthbh.GhiChu
	from PHIEUTRAHANGBAOHANH pthbh, CHITIETPHIEUTRAHANGBAOHANH ctpthbh, SANPHAM sp
	where pthbh.MaPTHBH = @MaPTHBH and ctpthbh.MaPTHBH = pthbh.MaPTHBH and ctpthbh.MaSanPham = sp.MaSanPham
end



GO
/****** Object:  StoredProcedure [dbo].[sp_SprintPTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SprintPTNBH]
@MaPTNBH nvarchar(10)
as
begin
	select ptnbh.MaPTNBH, hd.MaHD, sp.MaSanPham, sp.TenSanPham, ctptnbh.MoTaLoi, ctptnbh.SoLuong
	from PHIEUTIEPNHANBAOHANH ptnbh, CHITIETPHIEUTIEPNHANBAOHANH ctptnbh, SANPHAM sp, HOADON hd
	where ptnbh.MaPTNBH = @MaPTNBH and ptnbh.MaPTNBH = ctptnbh.MaPTNBH and ctptnbh.MaSanPham = sp.MaSanPham and ctptnbh.MaHoaDon = hd.MaHD
end


GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKePTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ThongKePTHBH]
@TuNgay smalldatetime,
@DenNgay smalldatetime
as
begin
	select pthbh.MaPTHBH as'Mã phiếu trả hàng bảo hành', pthbh.MaPTNBH as'Mã phiếu tiếp nhận bảo hành', pthbh.MaNV as'Mã nhân viên', pthbh.NgayLapPhieu as'Ngày lập'
	from PHIEUTRAHANGBAOHANH pthbh
	where @TuNgay < pthbh.NgayLapPhieu and pthbh.NgayLapPhieu < @DenNgay
end


GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKePTNBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_ThongKePTNBH]
@TuNgay smalldatetime,
@DenNgay smalldatetime
as
begin
	select ptnbh.MaPTNBH as 'Mã phiếu tiếp nhận', ptnbh.MaNV as 'Mã nhân viên', ptnbh.NgayLap as 'Ngày lập'
	from PHIEUTIEPNHANBAOHANH ptnbh
	where @TuNgay < ptnbh.NgayLap and ptnbh.NgayLap < @DenNgay
end


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCTPTHBH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateCTPTHBH]
@MaCTPTHBH int,
@GhiChu nvarchar(100)
as
begin
UPDATE [dbo].[CHITIETPHIEUTRAHANGBAOHANH]
   SET
      [GhiChu] = @GhiChu
 WHERE MaCTPTHBH = @MaCTPTHBH
end


GO
/****** Object:  StoredProcedure [dbo].[SumTotal]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SumTotal]
@MaPhieuNhapKho nvarchar(10)
as 
select SUM(SANPHAM.DonGiaNhap)
from CHITIETPHIEUNHAPKHO 
inner join SANPHAM
on SANPHAM.MaSanPham = CHITIETPHIEUNHAPKHO.MaSanPham
where MaPhieuNhapKho = @MaPhieuNhapKho


GO
/****** Object:  StoredProcedure [dbo].[UpdateCountProduct]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateCountProduct]
@MaSanPham nvarchar(10),
@SoLuong int 
as 
update SANPHAM
set
SoLuong = SoLuong + @SoLuong
where MaSanPham = @MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[UpdateCountProductOut]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateCountProductOut]
@MaSanPham nvarchar(10),
@SoLuong int
as 
update SANPHAM
set 
SoLuong = SoLuong - @SoLuong
where MaSanPham = @MaSanPham


GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateEmployee]
@MaNV nvarchar(10),
@Ten nvarchar(50),
@GioiTinh nvarchar(50),
@CMND nvarchar(15),
@SDT nvarchar(15),
@NgaySinh smalldatetime,
@DiaChi nvarchar(50),
@NoiSinh nvarchar(50),
@Tuoi nvarchar(10),
@ChucVu nvarchar(10),
@Luong nvarchar(50),
@NgayVaoLam smalldatetime,
@AnhThe image,
@TrangThai nvarchar(50),
@Password nvarchar(16),
@MaCN nvarchar(10)
as
begin
update NHANVIEN SET Ten=@Ten,GioiTinh=@GioiTinh,CMND=@CMND,SDT=@SDT,
NgaySinh=@NgaySinh,DiaChi=@DiaChi,NoiSinh=@NoiSinh,Tuoi=@Tuoi,ChucVu=@ChucVu,
Luong=@Luong,NgayVaoLam=@NgayVaoLam,AnhThe=@AnhThe,TrangThai=@TrangThai,PassWord=@Password 
where MaNV=@MaNV
end
--------------------------------------------------------------




GO
/****** Object:  StoredProcedure [dbo].[UpdateFuntion]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
CREATE proc [dbo].[UpdateFuntion]
@MaChucNang nvarchar(10),
@BanHang int,
@Kho int,
@BaoHanh int,
@ThongKe int,
@ThietLap int
as
begin
update CHUCNANG SET  BanHang=@BanHang,Kho=@Kho,BaoHanh= @BaoHanh,ThongKe= @ThongKe,ThietLap= @ThietLap
where MaCN=@MaChucNang
end
--------------------------------------------------------------


GO
/****** Object:  StoredProcedure [dbo].[UpdatePosition]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------- ------------ 
create proc [dbo].[UpdatePosition]
@MaChucVu nvarchar(10),
@TenChucVu nvarchar(20),
@Luong nvarchar(50),
@MaCN nvarchar(10),
@DaXoa int
as
begin
update CHUCVU SET  TenChucVu=@TenChucVu,Luong=@Luong,MaCN=@MaCN,
DaXoa=@DaXoa
where MaChucVu=@MaChucVu
end
--------------------------------------------------------------




GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETHOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAPKHO]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAPKHO](
	[MaChiTietPhieuNhapKho] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhapKho] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK__CHITIETP__A95AFEDFE55770B3] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUTIEPNHANBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTIEPNHANBAOHANH](
	[MaCTPTNBH] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaSanPham] [nchar](10) NOT NULL,
	[MoTaLoi] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaPTNBH] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__CHITIETP__258D1C65E6E481FB] PRIMARY KEY CLUSTERED 
(
	[MaCTPTNBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRAHANG]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTRAHANG](
	[MaChiTietPhieuTraHang] [nvarchar](10) NOT NULL,
	[MaPhieuTraHang] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuTraHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRAHANGBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTRAHANGBAOHANH](
	[MaCTPTHBH] [int] IDENTITY(1,1) NOT NULL,
	[MaPTHBH] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[MoTaLoi] [nvarchar](100) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__CHITIETP__1DC5F9DA1BA0D0FC] PRIMARY KEY CLUSTERED 
(
	[MaCTPTHBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUATKHO]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUATKHO](
	[MaChiTietPhieuXuatKho] [nvarchar](10) NOT NULL,
	[MaPhieuXuatKho] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuXuatKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH](
	[MaCTPXLK] [int] NOT NULL,
	[MaPXLKBH] [nvarchar](10) NOT NULL,
	[MaLinhKien] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK__CHITIETP__9DC118B5AAFAE93F] PRIMARY KEY CLUSTERED 
(
	[MaCTPXLK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCNANG]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCNANG](
	[MaCN] [nvarchar](10) NOT NULL,
	[BanHang] [int] NOT NULL,
	[Kho] [int] NULL,
	[BaoHanh] [int] NULL,
	[ThongKe] [int] NULL,
	[ThietLap] [int] NULL,
 CONSTRAINT [PK_CHUCNANG] PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [nvarchar](10) NOT NULL,
	[TenChucVu] [nvarchar](20) NOT NULL,
	[Luong] [nvarchar](50) NOT NULL,
	[MaCN] [nvarchar](10) NOT NULL,
	[DaXoa] [int] NOT NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](10) NOT NULL,
	[NgayHD] [smalldatetime] NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [PK__HOADON__2725A6E0F181CAEC] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONDOI]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONDOI](
	[MaHDD] [nvarchar](10) NOT NULL,
	[NgayDoi] [smalldatetime] NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[MaSanPhamThayThe] [nvarchar](10) NULL,
	[PhiDoi] [money] NOT NULL,
	[PhiHoan] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONTRA]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONTRA](
	[MaHDT] [nvarchar](10) NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSanPham] [nvarchar](10) NOT NULL,
	[PhiHoan] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](500) NULL,
	[SoDT] [nvarchar](20) NOT NULL,
	[CMND] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK__KHACHHAN__2725CF1E596A1DD9] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[CMND] [nvarchar](15) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[NgaySinh] [smalldatetime] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NoiSinh] [nvarchar](50) NOT NULL,
	[Tuoi] [nvarchar](10) NOT NULL,
	[ChucVu] [nvarchar](10) NOT NULL,
	[Luong] [nvarchar](50) NOT NULL,
	[NgayVaoLam] [smalldatetime] NOT NULL,
	[AnhThe] [image] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](16) NOT NULL,
	[MaCN] [nvarchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAPKHO]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPKHO](
	[MaPhieuNhapKho] [nvarchar](10) NOT NULL,
	[NgayLapPhieu] [smalldatetime] NOT NULL,
	[MaNguoiLapPhieu] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTIEPNHANBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTIEPNHANBAOHANH](
	[MaPTNBH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPTNBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTRAHANG]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRAHANG](
	[MaPhieuTraHang] [nvarchar](10) NOT NULL,
	[NgayLap] [smalldatetime] NOT NULL,
	[MaNguoiLapPhieu] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuTraHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTRAHANGBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRAHANGBAOHANH](
	[MaPTHBH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaPTNBH] [nvarchar](10) NOT NULL,
	[NgayLapPhieu] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PHIEUTRA__68B9DC64CFB836A1] PRIMARY KEY CLUSTERED 
(
	[MaPTHBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUATKHO]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUATKHO](
	[MaPhieuXuatKho] [nvarchar](10) NOT NULL,
	[NgayLapPhieu] [smalldatetime] NOT NULL,
	[MaNguoiNhan] [nvarchar](10) NOT NULL,
	[MaNguoiLapPhieu] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuatKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUATLINHKIENBAOHANH]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUATLINHKIENBAOHANH](
	[MaPXLKBH] [nvarchar](10) NOT NULL,
	[MaPTNBH] [nvarchar](10) NULL,
	[MaNVKT] [nvarchar](10) NOT NULL,
	[MaNVKho] [nvarchar](10) NOT NULL,
	[NgayLap] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PHIEUXUA__5498ACF3B5D4974E] PRIMARY KEY CLUSTERED 
(
	[MaPXLKBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSanPham] [nvarchar](10) NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[LoaiSanPham] [nvarchar](50) NOT NULL,
	[ThoiGianBaoHanh] [int] NOT NULL,
	[DonGiaNhap] [money] NOT NULL,
	[DonGiaBan] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaTS] [int] IDENTITY(0,1) NOT NULL,
	[TenTS] [nvarchar](100) NOT NULL,
	[GiaTri] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[GetQuanlitysWarrantyReturn]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GetQuanlitysWarrantyReturn]
AS
SELECT        SUM(dbo.CHITIETPHIEUTRAHANGBAOHANH.SoLuong) AS Expr1
FROM            dbo.PHIEUTRAHANGBAOHANH INNER JOIN
                         dbo.CHITIETPHIEUTRAHANGBAOHANH ON dbo.PHIEUTRAHANGBAOHANH.MaPTHBH = dbo.CHITIETPHIEUTRAHANGBAOHANH.MaPTHBH INNER JOIN
                         dbo.PHIEUTIEPNHANBAOHANH ON dbo.PHIEUTRAHANGBAOHANH.MaPTNBH = dbo.PHIEUTIEPNHANBAOHANH.MaPTNBH INNER JOIN
                         dbo.CHITIETPHIEUTIEPNHANBAOHANH ON dbo.PHIEUTIEPNHANBAOHANH.MaPTNBH = dbo.CHITIETPHIEUTIEPNHANBAOHANH.MaPTNBH
WHERE        (dbo.CHITIETPHIEUTIEPNHANBAOHANH.MaHoaDon = 'HD1') AND (dbo.CHITIETPHIEUTRAHANGBAOHANH.MaSanPham = 'SP1')

GO
/****** Object:  View [dbo].[ViewPhieuNhapKho]    Script Date: 22-Jan-16 01:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewPhieuNhapKho]
AS
SELECT        dbo.CHITIETPHIEUNHAPKHO.MaPhieuNhapKho, dbo.CHITIETPHIEUNHAPKHO.MaSanPham, dbo.CHITIETPHIEUNHAPKHO.SoLuong, dbo.CHITIETPHIEUNHAPKHO.GhiChu, dbo.PHIEUNHAPKHO.NgayLapPhieu, 
                         dbo.PHIEUNHAPKHO.MaNguoiLapPhieu, dbo.SANPHAM.TenSanPham, dbo.PHIEUNHAPKHO.GhiChu AS GhiChuPhieuNhap
FROM            dbo.CHITIETPHIEUNHAPKHO INNER JOIN
                         dbo.PHIEUNHAPKHO ON dbo.CHITIETPHIEUNHAPKHO.MaPhieuNhapKho = dbo.PHIEUNHAPKHO.MaPhieuNhapKho INNER JOIN
                         dbo.SANPHAM ON dbo.CHITIETPHIEUNHAPKHO.MaSanPham = dbo.SANPHAM.MaSanPham

GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETHOA__MaHD__239E4DCF] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK__CHITIETHOA__MaHD__239E4DCF]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAPKHO_PHIEUNHAPKHO] FOREIGN KEY([MaPhieuNhapKho])
REFERENCES [dbo].[PHIEUNHAPKHO] ([MaPhieuNhapKho])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPKHO] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAPKHO_PHIEUNHAPKHO]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPKHO]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAPKHO_SANPHAM] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAPKHO] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAPKHO_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTIEPNHANBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaHoa__4D94879B] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTIEPNHANBAOHANH] CHECK CONSTRAINT [FK__CHITIETPH__MaHoa__4D94879B]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTIEPNHANBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaPTN__4E88ABD4] FOREIGN KEY([MaPTNBH])
REFERENCES [dbo].[PHIEUTIEPNHANBAOHANH] ([MaPTNBH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTIEPNHANBAOHANH] CHECK CONSTRAINT [FK__CHITIETPH__MaPTN__4E88ABD4]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRAHANG]  WITH CHECK ADD FOREIGN KEY([MaPhieuTraHang])
REFERENCES [dbo].[PHIEUTRAHANG] ([MaPhieuTraHang])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRAHANG]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRAHANGBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRAHANGBAOHANH_PHIEUTRAHANGBAOHANH] FOREIGN KEY([MaPTHBH])
REFERENCES [dbo].[PHIEUTRAHANGBAOHANH] ([MaPTHBH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRAHANGBAOHANH] CHECK CONSTRAINT [FK_CHITIETPHIEUTRAHANGBAOHANH_PHIEUTRAHANGBAOHANH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATKHO]  WITH CHECK ADD FOREIGN KEY([MaPhieuXuatKho])
REFERENCES [dbo].[PHIEUXUATKHO] ([MaPhieuXuatKho])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATKHO]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaPTN__5BE2A6F2] FOREIGN KEY([MaLinhKien])
REFERENCES [dbo].[PHIEUTIEPNHANBAOHANH] ([MaPTNBH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH] CHECK CONSTRAINT [FK__CHITIETPH__MaPTN__5BE2A6F2]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK__CHITIETPH__MaPXL__5AEE82B9] FOREIGN KEY([MaPXLKBH])
REFERENCES [dbo].[PHIEUXUATLINHKIENBAOHANH] ([MaPXLKBH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATLINHKIENBAOHANH] CHECK CONSTRAINT [FK__CHITIETPH__MaPXL__5AEE82B9]
GO
ALTER TABLE [dbo].[CHUCVU]  WITH CHECK ADD  CONSTRAINT [FK_CHUCVU_CHUCNANG] FOREIGN KEY([MaCN])
REFERENCES [dbo].[CHUCNANG] ([MaCN])
GO
ALTER TABLE [dbo].[CHUCVU] CHECK CONSTRAINT [FK_CHUCVU_CHUCNANG]
GO
ALTER TABLE [dbo].[HOADONDOI]  WITH CHECK ADD  CONSTRAINT [FK__HOADONDOI__MaHD__29572725] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[HOADONDOI] CHECK CONSTRAINT [FK__HOADONDOI__MaHD__29572725]
GO
ALTER TABLE [dbo].[HOADONDOI]  WITH CHECK ADD  CONSTRAINT [FK__HOADONDOI__MaKH__276EDEB3] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADONDOI] CHECK CONSTRAINT [FK__HOADONDOI__MaKH__276EDEB3]
GO
ALTER TABLE [dbo].[HOADONDOI]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[HOADONDOI]  WITH CHECK ADD  CONSTRAINT [FK_HOADONDOI_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONDOI] CHECK CONSTRAINT [FK_HOADONDOI_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADONTRA]  WITH CHECK ADD  CONSTRAINT [FK__HOADONTRA__MaHD__2F10007B] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[HOADONTRA] CHECK CONSTRAINT [FK__HOADONTRA__MaHD__2F10007B]
GO
ALTER TABLE [dbo].[HOADONTRA]  WITH CHECK ADD  CONSTRAINT [FK__HOADONTRA__MaKH__2D27B809] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADONTRA] CHECK CONSTRAINT [FK__HOADONTRA__MaKH__2D27B809]
GO
ALTER TABLE [dbo].[HOADONTRA]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[HOADONTRA]  WITH CHECK ADD  CONSTRAINT [FK_HOADONTRA_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONTRA] CHECK CONSTRAINT [FK_HOADONTRA_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCNANG] FOREIGN KEY([MaCN])
REFERENCES [dbo].[CHUCNANG] ([MaCN])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCNANG]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[PHIEUNHAPKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPKHO_NHANVIEN] FOREIGN KEY([MaNguoiLapPhieu])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPKHO] CHECK CONSTRAINT [FK_PHIEUNHAPKHO_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTIEPNHANBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTIEPNHANBAOHANH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTIEPNHANBAOHANH] CHECK CONSTRAINT [FK_PHIEUTIEPNHANBAOHANH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRAHANG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRAHANG_NHANVIEN] FOREIGN KEY([MaNguoiLapPhieu])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTRAHANG] CHECK CONSTRAINT [FK_PHIEUTRAHANG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRAHANGBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRAHANGBAOHANH_PHIEUTIEPNHANBAOHANH] FOREIGN KEY([MaPTNBH])
REFERENCES [dbo].[PHIEUTIEPNHANBAOHANH] ([MaPTNBH])
GO
ALTER TABLE [dbo].[PHIEUTRAHANGBAOHANH] CHECK CONSTRAINT [FK_PHIEUTRAHANGBAOHANH_PHIEUTIEPNHANBAOHANH]
GO
ALTER TABLE [dbo].[PHIEUXUATKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUATKHO_NHANVIEN] FOREIGN KEY([MaNguoiLapPhieu])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUATKHO] CHECK CONSTRAINT [FK_PHIEUXUATKHO_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUATKHO]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUATKHO_NHANVIEN1] FOREIGN KEY([MaNguoiNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUATKHO] CHECK CONSTRAINT [FK_PHIEUXUATKHO_NHANVIEN1]
GO
ALTER TABLE [dbo].[PHIEUXUATLINHKIENBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUATLINHKIENBAOHANH_NHANVIEN] FOREIGN KEY([MaNVKT])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUATLINHKIENBAOHANH] CHECK CONSTRAINT [FK_PHIEUXUATLINHKIENBAOHANH_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUATLINHKIENBAOHANH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUATLINHKIENBAOHANH_NHANVIEN1] FOREIGN KEY([MaNVKho])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUATLINHKIENBAOHANH] CHECK CONSTRAINT [FK_PHIEUXUATLINHKIENBAOHANH_NHANVIEN1]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRAHANG]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUATKHO]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD CHECK  (([ThoiGianBaoHanh]>=(0) AND [SoLuong]>=(0) AND [DonGiaNhap]>(0) AND [DonGiaBan]>=[DonGiaNhap]))
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD CHECK  (([ThoiGianBaoHanh]>=(0) AND [SoLuong]>=(0) AND [DonGiaNhap]>(0) AND [DonGiaBan]>=[DonGiaNhap]))
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[29] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -141
      End
      Begin Tables = 
         Begin Table = "CHITIETPHIEUTRAHANGBAOHANH"
            Begin Extent = 
               Top = 26
               Left = 931
               Bottom = 248
               Right = 1340
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "PHIEUTRAHANGBAOHANH"
            Begin Extent = 
               Top = 12
               Left = 614
               Bottom = 142
               Right = 784
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PHIEUTIEPNHANBAOHANH"
            Begin Extent = 
               Top = 86
               Left = 247
               Bottom = 216
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CHITIETPHIEUTIEPNHANBAOHANH"
            Begin Extent = 
               Top = 173
               Left = 613
               Bottom = 303
               Right = 783
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 20
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidth' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetQuanlitysWarrantyReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N's = 12
         Column = 1380
         Alias = 645
         Table = 3090
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetQuanlitysWarrantyReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'GetQuanlitysWarrantyReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[29] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CHITIETPHIEUNHAPKHO"
            Begin Extent = 
               Top = 39
               Left = 129
               Bottom = 169
               Right = 353
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "PHIEUNHAPKHO"
            Begin Extent = 
               Top = 0
               Left = 429
               Bottom = 130
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SANPHAM"
            Begin Extent = 
               Top = 144
               Left = 431
               Bottom = 274
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1710
         Table = 1590
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewPhieuNhapKho'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewPhieuNhapKho'
GO
USE [master]
GO
ALTER DATABASE [QLBH_CuaHangBanMayTinhVaLinhKien] SET  READ_WRITE 
GO
