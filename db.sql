create database QuanLyDocGia_DoiTuong
go

use QuanLyDocGia_DoiTuong
go


create table DoiTuong(
 MaDoiTuong nvarchar(10) primary key,
 TenDoiTuong nvarchar(30)
 )

 create table DocGia(
  MaDocGia nvarchar(10) primary key,
  HoTen nvarchar(30),
  GioiTinh nvarchar(10),
  NgaySinh nvarchar(10),
  MaDoiTuong nvarchar(10),
  NgayCap nvarchar(10),
  NgayHetHan nvarchar(10),
  foreign key (MaDoiTuong) references DoiTuong(MaDoiTuong)
  )


