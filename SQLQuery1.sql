create database QLMatHang
go
use QLMatHang
create table tblMatHang
(
masp nchar(5) primary key,
tensp nvarchar(30),
ngaysx Date,
ngayhh Date,
donvi nvarchar(10),
dongia float,
ghichu nvarchar(200)
)
go
