create database QLPV
go 
use QLPV;

create table PhongVien (
	MaPV nvarchar(20) primary key ,
	HoTen nvarchar(20) ,
	GioiTinh nvarchar(20),
	SDT nvarchar(20) ,
	NgayVaoLam Date,
	LoaiPV nvarchar(20) ,
	PhuCap float ,
	SoGioLam int , 
	Luong float
) 

insert into PhongVien values ('NV01' , N'Bùi Minh Quý' ,N'Nam' ,'0332813815' ,'2023/12/1' ,N'Tại Tòa Soạn' , '' , 10, 120000 )