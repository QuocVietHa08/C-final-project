create database QuanLyDocGia_DoiTuong
go

use QuanLyDocGia_DoiTuong
go


create table DoiTuong(
 MaDoiTuong nvarchar(10) primary key,
 TenDoiTuong nvarchar(30)
 )

 drop table DocGia
 create table DocGia(
  MaDocGia nvarchar(10) primary key,
  HoTen nvarchar(30),
  GioiTinh nvarchar(10),
  NgaySinh nvarchar(10),
  MaDoiTuong nvarchar(10),
  NgayCap date,
  NgayHetHan date,
  foreign key (MaDoiTuong) references DoiTuong(MaDoiTuong),
  )
	
 insert into DoiTuong values
 ('madt01','sinh vien'),
 ('madt02','nhan vien'),
 ('madt03','hoc sinh'),
 ('madt04','cong nhan')





 insert into DocGia values
 ('madg01','Ha quoc viet','Nam','08/01/2000','madt01','2021/05/01','2021/06/01'),
 ('madg02','Nguyen Van A','Nu','01/01/2001','madt02','2021/06/01','2021/07/01'),
('madg03','Hoang Van B','Nam','02/02/2002','madt03','2021/08/01','2021/09/01'),
('madg04','Le Thi C','Nu','03/03/2003','madt04','2021/10/01','2021/11/01'),
('madg05','Tran Van D','Nam','04/04/2004','madt01','2021/12/01','2021/12/21')

create table TaiKhoan(
	TaiKhoanId nvarchar(10) primary key,
	TenTaiKhoan nvarchar(30),
	MatKhauTaiKhoan nvarchar(30),
)

insert into TaiKhoan values
('tk1','admin','12345'),
('tk2','canbo','54321')

select * from DoiTuong
select * from DocGia
 
  select * from DocGia where NgayCap between  '05/04/2021' and  '01/01/2021'