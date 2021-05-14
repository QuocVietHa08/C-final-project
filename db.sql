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
	
 insert into DoiTuong values
 ('madt01','sinh vien'),
 ('madt02','nhan vien'),
 ('madt03','hoc sinh'),
 ('madt04','cong nhan')


 insert into DocGia values
 ('madg01','Ha quoc viet','Nam','08/01/2000','madt01','01/05/2021','01/06/2021'),
 ('madg02','Nguyen Van A','Nu','01/01/2001','madt02','02/07/2021','02/08,2021'),
('madg03','Hoang Van B','Nam','02/02/2002','madt03','04/09/2021','03/10/2021'),
('madg04','Le Thi C','Nu','03/03/2003','madt04','05/11/2021','05/12/2021'),
('madg05','Tran Van D','Nam','04/04/2004','madt01','05/12/2021','31/12/2021')