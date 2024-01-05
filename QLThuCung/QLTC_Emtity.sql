create database QLTC;
go 
use QLTC;

create table ThuCung (
	MaDon Nvarchar(20) primary key, 
	TenThuCung Nvarchar(20) ,
	ChungLoai Nvarchar(20) ,
	CanNang int ,
	NgayNhan Date ,
	TinhTrang Nvarchar(20),
	DichVu Nvarchar(20) ,
	SoNgay int,
	ChiPhiThuoc float,
	TongChiPhi float
)

insert into ThuCung Values ('01' , 'doggy' , 'Corgi' ,'20' , '2023/4/2' , N'Sốt nhẹ' , N'Chữa Bệnh' , '' , '100000' , '200000' )

select * from ThuCung
