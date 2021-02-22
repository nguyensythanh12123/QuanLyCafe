create database QL_QuanCaFe
use QL_QuanCaFe
create table QUANLY
(
	MaQL char(10) not null primary key,
	TenQL nvarchar(max),
	NgaySinh date,
	GioiTinh nchar(5),
	SDT char(11),
	MatKhau char(10)
)
create table BOPHAN
(
	MaBP char(10) not null primary key,
	TenBP nvarchar(max),
)
create table NHANVIEN
(
	MaNV char(10) not null primary key,
	TenNV nvarchar(max),
	NgaySinh date,
	GioiTinh nchar(5),
	DiaChi nvarchar(max),
	SDT char(11),
	NgayVaoLam date,
	MaQL char(10) not null,
	MaBP char(10),
	MatKhauDN nvarchar(10)
)
create table LOAIMON
(
	MaLoai char(10) not null primary key,
	TenLoai nvarchar(max)
)
create table MENU
(
	MaMon char(10) not null primary key,
	TenMon nvarchar(255) ,
	MaLoai char(10),
	DVT nvarchar(10),
	HinhAnh nVARchar(max),
	Gia float,
	unique(TenMon)
)
create table GIAMGIA
(
	MaGiamGia char(10) not null primary key,
	PhanTram float,
	NgayGiamGia date
)

create table BAN
(
	MaBan char(10) not null primary key,
	TenBan nvarchar(255),
	SoCho int,
	TrangThai nvarchar(50),
	unique(TenBan)
)
create table HOADON
(
	MaHD char(10) not null primary key,
	MaNV char(10) not null,
	NgayTao date,
	MaBan char(10),
	ThanhToan float,
	TrangThaiTT nvarchar(max),
	MaGiamGia char(10),
	TienNhan float,
	TienThoi float,
)
create table CTHOADON
(
	MaHD char(10) not null,
	MaMon char(10) not null,
	SoLuong int not null,
	ThanhTien float,
	primary key(MaHD, MaMon)
)
create table CALAM
(
	MaCa char(10) not null primary key,
	BuoiCa nvarchar(max),
	SoTieng int,
	ChiTietCa nvarchar(max)
)
create table BANGLUONG
(
	MaBL char(10) not null primary key,
	TenBL nvarchar(50)
)
create table LUONGNV
(
	MaBL char(10) not null,
	MaNV char(10) not null,
	NgayPhatLuong date,
	Luong float,
	primary key(MaBL,MaNV)
)
create table CTBANGLUONG
(
	MaBL char(10) not null,
	MaNV char(10) not null,
	MaCa char(10) not null,
	NgayLam date,
	SoTien float,
	ThanhTien float,
	primary key(MaBL, MaNV, MaCa,NgayLam)
)
create table NHACUNGCAP
(
	MaNCC char(10) not null primary key,
	TenNCC nvarchar(max),
	DChi nvarchar(max),
	DienThoai char(10),
)

create table NGUYENLIEU
(
	MaNL char(10) not null primary key,
	TenNL nvarchar(max),
	DVT nvarchar(30),
	Soluongton int,--số lượng trong kho còn
	MaLoai char(10),
	MaNCC char(10)
)
create table PHIEUNHAP
(
	MaPN char(10) not null primary key,
	NgayNhap date,
	MaQL char(10),
	TienNhap float
)
create table CTPHIEUNHAP
(
	MaPN char(10) not null,
	MaNL char(10) not null,
	SoLuong int,--số lượng nhập dô (viết trigger cộng dồn số lượng trong kho)
	DonGia float,
	ThanhTien float,
	primary key(MaPN, MaNL)
)
create table PHIEUXUAT
(
	MaPX char(10) not null primary key,
	MaNV char(10),
	NgayXuat date

)
create table CTPHIEUXUAT
(
	MaPX char(10) not null,
	MaNL char(10) not null,
	SoLuong int,--số lượng xuất ra 
	primary key(MaPX, MaNL)
)
/*------CÀI ĐẶT KHÓA NGOẠI---------------*/

alter table NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_BOPHAN FOREIGN KEY (MABP) REFERENCES BOPHAN(MABP),
	CONSTRAINT FK_NHANVIEN_QUANLY FOREIGN KEY (MAQL) REFERENCES QUANLY(MAQL)
alter table MENU
ADD CONSTRAINT FK_MENU_LOAIMON FOREIGN KEY (MALOAI) REFERENCES LOAIMON(MALOAI)
alter table HOADON
ADD CONSTRAINT FK_HOADON_BAN FOREIGN KEY (MABAN) REFERENCES BAN(MABAN),
	constraint FK_HOADON_GIAMGIA FOREIGN KEY (MaGiamGia) REFERENCES GIAMGIA(MaGiamGia),
	CONSTRAINT FK_HD_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
alter table CTHOADON
ADD CONSTRAINT FK_CTHD_HOADON FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
alter table CTHOADON
ADD CONSTRAINT FK_CTHD_MENU FOREIGN KEY (MAMON) REFERENCES MENU(MAMON)
alter table LUONGNV
ADD CONSTRAINT FK_LUONGNV_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_LUONGNV_BANGLUONG FOREIGN KEY (MABL) REFERENCES BANGLUONG(MABL)
alter table CTBANGLUONG
ADD CONSTRAINT FK_CTBL_CALAM FOREIGN KEY (MACA) REFERENCES CALAM(MACA)
alter table CTBANGLUONG
add CONSTRAINT FK_CTBL_LUONGNV FOREIGN KEY (MaBL,MANV) REFERENCES LUONGNV(MaBL,MANV)
--
alter table NGUYENLIEU
add constraint FK_NGUYENLIEU_NHACC FOREIGN KEY (MaNCC) REFERENCES NHACUNGCAP(MaNCC),
	constraint FK_NGUYENLIEU_LOAIMON FOREIGN KEY (MaLoai) REFERENCES LOAIMON(MaLoai)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_QUANLY FOREIGN KEY (MaQL) REFERENCES QUANLY(MaQL)
alter table CTPHIEUNHAP
add constraint FK_CTPN_PN FOREIGN KEY (MaPN) REFERENCES PHIEUNHAP(MaPN),
	constraint FK_CTPN_NGUYENLIEU FOREIGN KEY (MaNL) REFERENCES NGUYENLIEU(MaNL)
alter table PHIEUXUAT
ADD CONSTRAINT FK_PHIEUXUAT_NHANVIEN FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
alter table CTPHIEUXUAT
add constraint FK_CTPX_PHIEUXUAT FOREIGN KEY (MaPX) REFERENCES PHIEUXUAT(MaPX),
	constraint FK_CTPX_NGUYENLIEU FOREIGN KEY (MaNL) REFERENCES NGUYENLIEU(MaNL)


/*--------------TRIGGER NÈ MỌI NGƯỜI-----------------------*/
/*--------------TRẠNG THÁI CỦA BÀN-----------------------*/
--cập nhập bàn nếu tạo hóa đơn thì chuyển trạng thái thành đã có người
CREATE TRIGGER UPDATETTBAN
ON HOADON
FOR INSERT 
AS
UPDATE BAN
SET TrangThai=N'Đã Có Người' where MaBan=(select MaBan from inserted)

-----------------text-----------------------------
insert into HOADON values ('HD012','07/08/2020','MB08',0,N'Chưa Thanh Toán')
select * from BAN
drop trigger UPDATETTBAN
----------------------------------------------------------------------
/*--------------TÍNH TIỀN HÓA ĐƠN - XUẤT RA TIỀN KHI GỌI MÓN-----------------------*/
--cập nhật chi tiết hóa đơn ra thành tiền(Tính tiền trong 1 món)
Create trigger UpdateCTHOADON
on CTHOADON
for insert,UPDATE
as
update CTHOADON
set ThanhTien=SoLuong*(select Gia from MENU where MaMon=(select MaMon from inserted))
where MaHD=(select MaHD from inserted) and MaMon=(select MaMon from inserted)

--DROP TRIGGER UpdateCTHOADON
--cập nhật hóa đơn

--Cập nhập lại số tiền cần phải trả khi Thêm món ở CTHOADON(Nhiều món)
create trigger updateTTHOADON
on CTHOADON
for insert,update
as
update HOADON
set ThanhToan=(select sum(ThanhTien) from CTHOADON where MaHD=(select MaHD from inserted))
where MaHD=(select MaHD from inserted)

create trigger updateTTHOADONdelet
on CTHOADON
for delete
as
update HOADON
set ThanhToan= (select sum(ThanhTien) from CTHOADON where MaHD=(select MaHD from deleted)) 
where MaHD=(select MaHD from deleted)
drop trigger updateTTHOADON
/*create trigger xoaTTHOADON
on CTHOADON
for delete
as
update HOADON
set ThanhToan=ThanhToan-(select ThanhTien from CTHOADON where MaHD=(select MaHD from deleted) AND MAMON=(SELECT MAMON FROM DELETED))
where MaHD=(select MaHD from deleted) */


----------------------text---------------------------------------------------------
insert into CTHOADON (MaHD,MaNV,MaMon,SoLuong) VALUES ('HD08','NV01','MON05',2)
SELECT * FROM CTHOADON
DROP TRIGGER UpdateThanhTien

SELECT * FROM HOADON
------------------------------------------------------
/*--------------TÍNH LƯƠNG CHO NHÂN VIÊN-----------------------*/
--cập nhập lại bảng chi tiết bảng lương thành tiền(Tính trong 1 ngày)
create trigger updateCTTienNV
on CTBANGLUONG
for insert
as
update CTBANGLUONG
set ThanhTien=SoTien*(select SoTieng from CALAM where MaCa=(select MaCa from inserted))
where MaCa=(select MaCa from inserted)
--cập nhập luong lại trong LUONGNV(tính lương trong 1 tháng)
create trigger updateLuongNV
on CTBANGLUONG
for insert
as
update LUONGNV
set Luong=(select sum(ThanhTien) from CTBANGLUONG where MaBL=(select MaBL from inserted) and MaNV=(select MaNV from inserted))
where MaBL=(select MaBL from inserted) and MaNV=(select MaNV from inserted)

create trigger DelectLuongNV
on CTBANGLUONG
for delete
as
update LUONGNV
set Luong= (select sum(ThanhTien) from CTBANGLUONG where MaBL=(select MaBL from deleted) and MaNV = (select MaNV from deleted)) 
where MaBL=(select MaBL from deleted) and MaNV = (select MaNV from deleted)
--------------------------Text-----------------------------
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV01','CA01','11/04/2020',21000),
('BL04','NV02','CA03','11/04/2020',23000)

select * from CTBANGLUONG
drop trigger updateTienNV
---------------------------------------------------------------
/*--------------XUẤT _ NHẬP NGUYÊN LIỆU-----------------------*/
--Cập nhập lại số lương hàng khi xuất hàng ra
create trigger updateSLXuatthem
on CTPHIEUXUAT
for insert
as
update NGUYENLIEU
set SoLuongton=SoLuongton-(select SoLuong from inserted)
where MaNL=(select MaNL from inserted)

create trigger updateSLXuatSauXoa
on CTPHIEUXUAT
for delete
as
update NGUYENLIEU
set SoLuongton=SoLuongton+(select SoLuong from deleted)
where MaNL=(select MaNL from deleted)

create trigger updateSLXuatSausua
on CTPHIEUXUAT
for update
as
update NGUYENLIEU
set SoLuongton=SoLuongton+(select SoLuongton from inserted)-(select SoLuong from deleted)
where MaNL=(select MaNL from deleted)

drop trigger updateSLXuatSauXoa
--Cập nhập lại số lượng hàng khi nhập hàng vào
create trigger updateSLNhapthem
on CTPHIEUNHAP
for insert
as
update NGUYENLIEU
set SoLuongton=SoLuongton+(select SoLuong from inserted)
where MaNL=(select MaNL from inserted)

create trigger updateSLNhapSauXoa
on CTPHIEUNHAP
for delete
as
update NGUYENLIEU
set SoLuongton=SoLuongton-(select SoLuong from deleted)
where MaNL=(select MaNL from deleted)

create trigger updateSLNhapSauSua
on CTPHIEUNHAP
for update
as
update NGUYENLIEU
set SoLuongton=SoLuongton+(select SoLuong from inserted)-(select SoLuong from deleted)
where MaNL=(select MaNL from deleted)
--cập nhập ThanhTien khi nhập Nguyên liệu trong bảng CTPHIEUNHAP(Trong 1 NGUYENLIEU)
create trigger updateCTTienNL
on CTPHIEUNHAP
for insert,update
as
update CTPHIEUNHAP
set ThanhTien=SoLuong*DonGia
where MaNL=(select MaNL from inserted) and MaPN=(select MaPN from inserted)
--drop trigger updateCTTienNL
---Cập nhập tiền khi nhập Nguyên liệu trong bảng CTPHIEUNHAP(Trong Nhiều NGUYENLIEU)
create trigger updateTienNL
on CTPHIEUNHAP
for insert,update
as
update PHIEUNHAP
set TienNhap=(select sum(ThanhTien) from CTPHIEUNHAP where  MaPN=(select MaPN from inserted))
where MaPN=(select MaPN from inserted)

create trigger updatetienKhiXoa
on CTPHIEUNHAP
for delete,update
as
update PHIEUNHAP
set TienNhap=(select sum(ThanhTien) from CTPHIEUNHAP where  MaPN=(select MaPN from deleted))
where MaPN=(select MaPN from deleted)
--Kiểm tra số lượng xuất nguyên liệu phải lớn hơn số lượng tồn
--create trigger KT_SOLUONG_TON on CTPHIEUXUAT for insert
--as
--if((select soluong from inserted) >= (select Soluongton from NGUYENLIEU 
--																where MaNL = (select MaNL 
--																				from inserted)) and (select soluong from inserted)> 0)
--	commit tran
--else 
--	begin 
--	print 'Số lượng k đủ'
--	rollback tran 
--	end

--Cập nhập lại số lượng có trong kho khi nhập nguyên liệu vào
--create trigger updateSoLuongNhapNL
--on CTPHIEUNHAP
--for insert
--as
--update NGUYENLIEU
--set SoLuong=SoLuong + (select SoLuong from CTPHIEUNHAP where  MaNL=(select MaNL from inserted))
--where MaNL=(select MaNL from inserted)
insert into XUATNLIEU
values('LM02',N'NL10','2020-08-06',3)
select * from XUATNLIEU
select * from NHAPNLIEU
drop trigger capnhatSoluongKhoNhap


insert into CTHOADON
values('HD04','NV01','MON06',2,0)
select * from HOADON
select * from CTHOADON
drop trigger tinhTongThanhToan
----------------------------------------------------
--Cập nhập lại khi đã thanh toán 
 /*create trigger ThanhToanTien
on CTHOADON
for insert
as
update HOADON
set TrangThaiTT = N'Đã Thanh Toán' from inserted,HOADON where inserted.MaHD=HOADON.MaHD
update BAN
set TrangThai= N'Bàn trống'  from inserted,HOADON where inserted.MaHD=HOADON.MaHD */
select *from BAN
insert into CTHOADON
values('HD01','NV04','MON09',4,0)

select * from HOADON
select * from CTHOADON
drop trigger updathd
select * from HoaDon hd , BAN where hd.MaBan = BAN.MaBan and  hd.MaBan='MB05      ' and TrangThai= N'Đã Có Người'
delete from HOADON where MaHD = 'HD18'
-----------------------------------------------------------

/*--------------INSERT INTO------------------*/

set dateformat DMY
insert into QUANLY 
values('QL01',N'Đỗ Thanh Tùng','02/02/1998',N'Nữ','0987621621','123'),
('QL02',N'Phạm Thị Vi','02/02/1998',N'Nữ','0987621621','123'),
('QL03',N'Nguyễn Sỹ Thành','02/02/1998','Nam','0987621621','123')
select*from QUANLY
insert into BOPHAN 
values('BP01',N'Pha Chế'),
('BP02',N'Thu Ngân'),
('BP03',N'Phục Vụ')
select*from BOPHAN
insert into NHANVIEN 
values('NV01',N'Lý Thanh Liêm','02/12/1999','Nam',N'TPHCM','098898789','12/10/2018','QL01','BP01','123'),
('NV02',N'Kiều Thanh Nhã','12/09/2000','Nam',N'TP.Vinh','0812156212','09/10/2019','QL01','BP01','123'),
('NV03',N'Phùng Minh Hưng','17/05/2001','Nam',N'Quảng Bình','0928738281','09/01/2020','QL01','BP02','123'),
('NV04',N'Trần Kim Anh','16/01/1998',N'Nữ',N'Nghệ An','09213784637','05/06/2019','QL02','BP02','123'),
('NV05',N'Nguyễn Yến Nhi','28/10/2000',N'Nữ',N'Hà Tĩnh','0317682912','21/12/2018','QL02','BP03','123'),
('NV06',N'Hồ Hạnh Nhân','05/04/2000','Nam',N'TPHCM','0774563738','13/04/2018','QL02','BP01','123'),
('NV07',N'Đỗ Thanh Trà My','18/11/1999',N'Nữ',N'TPHCM','0982211467','18/10/2019','QL03','BP02','123'),
('NV08',N'Nguyễn Trần Minh Quân','09/02/1998','Nam',N'Đồng Tháp','0973736117','17/08/2019','QL03','BP02','123'),
('NV09',N'Kim Thanh Nhã','02/03/2001',N'Nữ',N'Bến Tre','0985677483','01/02/2020','QL03','BP03','123'),
('NV010',N'Lý Thanh Quỳnh Như','14/08/2000',N'Nữ',N'Vĩnh Long','0876756473','21/07/2019','QL01','BP02','123')
select*from NHANVIEN
insert into LOAIMON 
values('LM01',N'Đồ Uống'),
('LM02',N'Thức Ăn')
select*from LOAIMON
insert into MENU 
values('MON01',N'Cafe đen','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh1.png',15000),
('MON02',N'Cafe sữa','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh2.png',20000),
('MON03',N'Bạc Xỉu','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh3.png',25000),
('MON04',N'Espresso','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh4.png',30000),
('MON05',N'Cappuchino','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh5.png',35000),
('MON06',N'Mocha','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh6.png',35000),
('MON07',N'Ép Táo','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh7.png',25000),
('MON08',N'Ép Xoài','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh8.png',25000),
('MON09',N'Ép Dưa Hấu','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh9.png',25000),
('MON010',N'Mousse CaCao','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh10.png',39000),
('MON011',N'Mousse Đào','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh11.png',39000),
('MON012',N'Phô Mai Chanh Dây','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh12.png',39000),
('MON013',N'Choccolate đá xay','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh13.png',38000),
('MON014',N'Capochino đá xay','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh14.png',38000),
('MON015',N'Mật ong chanh đào sả','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/Hinh15.png',40000),
('MON016',N'Socola nóng','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh16.png',38000),
('MON017',N'Cafe trứng','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh17.png',45000),
('MON018',N'Cafe nước cốt dừa','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh18.png',45000),
('MON019',N'CaCao nóng','LM01',N'Ly',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh19.png',45000),
('MON020',N'Bánh Mousse Đào','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh20.png',30000),
('MON021',N'Bánh Mousse Cacao','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh21.png',40000),
('MON022',N'Bánh Phô Mai Cafe','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh22.png',45000),
('MON023',N'Bánh Socola','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh23.png',30000),
('MON024',N'Bánh Phô Mai Trà Xanh','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh24.png',20000),
('MON025',N'Bánh Caramel Phô Mai','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh25.png',40000),
('MON026',N'Bánh Mochi Nhật','LM02',N'Hộp',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh26.png',100000),
('MON027',N'Bánh Macaron Pháp','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh27.png',40000),
('MON028',N'Bánh Táo','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh28.png',30000),
('MON029',N'Bánh Pandan','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh29.png',50000),
('MON030',N'Bánh Crepe','LM02',N'Cái',N'D:/HỌC TẬP/DoAn/CongNghe.net/HinhAnh/HinhAnhMenu/hinh30.png',40000)
select*from MENU
insert into BAN 
values ('MB01',N'Bàn số 01',2,N'Bàn Trống'),
	('MB02',N'Bàn số 02',4,N'Bàn Trống'),
	('MB03',N'Bàn số 03',3,N'Bàn Trống'),
	('MB04',N'Bàn số 04',2,N'Bàn Trống'),
	('MB05',N'Bàn số 05',4,N'Bàn Trống'),
	('MB06',N'Bàn số 06',4,N'Bàn Trống'),
	('MB07',N'Bàn số 07',3,N'Bàn Trống'),
	('MB08',N'Bàn số 08',2,N'Bàn Trống'),
	('MB09',N'Bàn số 09',4,N'Bàn Trống'),
	('MB10',N'Bàn số 10',3,N'Bàn Trống'),
	('MB11',N'Bàn số 11',2,N'Bàn Trống'),
	('MB12',N'Bàn số 12',6,N'Bàn Trống')
select * from BAN
SET DATEFORMAT DMY
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD01','NV01','07/08/2020','MB01',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD02', 'NV04','07/08/2020','MB04',0,N'Chưa Thanh Toán')--
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD03','NV05','08/08/2020','MB02',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD04','NV02','13/08/2020','MB03',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD05', 'NV01','04/10/2020','MB05',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD06', 'NV08','09/12/2019','MB09',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD07','NV04','02/11/2019','MB10',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD08','NV07','08/07/2020','MB11',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD09','NV01','12/04/2020','MB07',0,N'Chưa Thanh Toán')
insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT)
values('HD010','NV02','06/05/2020','MB06',0,N'Chưa Thanh Toán')
select*from HOADON
/*Kiếm Tra trigger bàn nè*/
select * from BAN
insert into CTHOADON
values('HD01','MON01',2,0)
insert into CTHOADON
values('HD01','MON02',3,0)
insert into CTHOADON
values('HD01','MON030',1,0)--
insert into CTHOADON
values('HD02','MON03',4,0)
insert into CTHOADON
values('HD03','MON05',2,0)
insert into CTHOADON
values('HD04','MON029',3,0)
insert into CTHOADON
values('HD05','MON08',5,0)
insert into CTHOADON
values('HD06','MON09',1,0)
insert into CTHOADON
values('HD07','MON010',3,0)
insert into CTHOADON
values('HD08','MON010',2,0)
insert into CTHOADON
values('HD010','MON010',2,0)
insert into CTHOADON
values('HD09','MON010',2,0)
select*from CTHOADON
select*from HOADON
/*Kiếm Tra trigger bàn nè*/
select * from BAN
/*Kiểm Tra Thành tiền trong CTHD nè nè*/
insert into CALAM 
values('CA01',N'Sáng',8,N'Từ 6h Đến 18h'),
('CA02',N'Sáng',4,N'Từ 6h Đến 10h'),
('CA03',N'Chiều',8,N'Từ 14h Đến 22h'),
('CA04',N'Chiều',4,N'Từ 14h Đến 18h'),
('CA05',N'Tối',4,N'Từ 18h-22h')
select*from CALAM

insert into BANGLUONG --mỗi tháng sẽ có một bảng lương khác nhau
VALUES('BL01',N'Bảng Lương 1'),
('BL02',N'Bảng Lương 2'),
('BL03',N'Bảng Lương 3'),
('BL04',N'Bảng Lương 4'),
('BL05',N'Bảng Lương 5')
--mỗi nhân viên sẽ sẽ có một bảng lương nếu nhân viên đó có làm trong tháng đó
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL01','NV01','10/02/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)--
values('BL01','NV02','10/02/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL01','NV03','10/02/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL01','NV04','10/02/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL02','NV03','10/03/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL02','NV04','10/03/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL02','NV05','10/03/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL03','NV06','10/04/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL03','NV07','10/04/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL03','NV08','10/04/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL04','NV09','10/05/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL04','NV010','10/05/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL04','NV01','10/05/2020')
insert into LUONGNV(MaBL,MaNV,NgayPhatLuong)
values('BL04','NV02','10/05/2020')
select*from LUONGNV

insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien) --số tiền mặt định bao nhiêu 1 tiếng
values('BL01','NV01','CA01','10/02/2020',25000)--làm ngày 10/01/2020 --Đã chạy
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV02','CA03','10/02/2020',20000)--đây là bảng lương tháng 1 của mấy nhân viên này làm trong ngày 10 và 11
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV03','CA02','10/02/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV04','CA04','10/02/2020',22000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV01','CA01','11/02/2020',25000)--làm ngày 11/01/2020 và sẽ được nhận tiền vào ngày 10/2/2020.--Đã chạy
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV02','CA03','11/02/2020',20000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV03','CA02','11/02/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL01','NV04','CA04','11/02/2020',22000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien) 
values('BL01','NV01','CA02','12/02/2020',25000)----Đã chạy
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV03','CA01','12/03/2020',25000)----đây là bảng lương tháng 2 của mấy nhân viên này làm trong ngày 10 và 11
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV04','CA03','12/03/2020',22000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV05','CA05','12/03/2020',20000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV03','CA01','13/03/2020',25000)--
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV04','CA03','13/03/2020',22000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL02','NV05','CA05','13/03/2020',20000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL03','NV06','CA01','10/04/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL03','NV07','CA03','10/04/2020',23000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL03','NV06','CA01','11/04/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL03','NV07','CA03','11/04/2020',23000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL03','NV08','CA03','11/04/2020',23000)

insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV09','CA01','10/05/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV010','CA03','10/05/2020',23000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV01','CA01','11/05/2020',21000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV02','CA03','11/05/2020',23000)
insert into CTBANGLUONG(MaBL,MaNV,MaCa,NgayLam,SoTien)
values('BL04','NV09','CA03','11/05/2020',23000)
select*from CTBANGLUONG
select *from LUONGNV

insert into NHACUNGCAP
values('NCC01',N'Cafe Trung Nguyên',N'Đaklak','098787972'),
('NCC02',N'90S Coffee',N'Q.Thủ Đức','0897378729'),
('NCC03',N'Vua cafe sạch',N'Bình Thạnh,TP HCM','0886376633'),
('NCC04',N'Taf Coffee',N'Quận 5, Hồ Chí Minh','0862565161'),
('NCC05',N'Café Motherland',N'Tân Phú,Hồ Chí Minh','0976362818'),
('NCC06',N'Favio Coffee',N'Thủ Đức,Hồ Chí Minh','0326172637'),
('NCC07',N'ABC Bakery',N'Hồ Chí Minh','0286527771'),
('NCC08',N'Kinh Do',N'Q.1,TP.HCM','0286676676'),
('NCC09',N'Walls',N'Q.3,Hồ Chí Minh','0289888898'),
('NCC10',N'Đại Thành Bakery',N'Bình Thạnh,Hồ Chí Minh','0284545445')
select *from NHACUNGCAP

insert into NGUYENLIEU
values('NL01',N'Cafe hạt',N'Thùng',5,'LM02','NCC01'),
('NL02',N'Cafe Xây',N'Thùng',10,'LM02','NCC02'),
('NL03',N'Bột trà xanh',N'Bịch',5,'LM01','NCC07'),
('NL04',N'Bột ca cao',N'Bịch',10,'LM01','NCC08'),
('NL05',N'Đường phụ phẩm',N'Thùng',5,'LM01','NCC03'),
('NL06',N'Trà sen',N'Thùng',3,'LM02','NCC04'),
('NL07',N'Bột Onemix',N'Bịch',6,'LM01','NCC05'),
('NL08',N'Bột cafe hòa tan',N'Thùng',8,'LM02','NCC02'),
('NL09',N'Camen',N'Chai',5,'LM01','NCC07'),
('NL010',N'Pudding',N'Bịch',8,'LM01','NCC10')
select*from NGUYENLIEU

insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN1','09/04/2019','QL01')--Đã chạy
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN2','10/04/2019','QL02')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN3','20/05/2019','QL01')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN4','26/05/2019','QL03')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN5','18/10/2019','QL03')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN6','01/01/2020','QL02')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN7','28/04/2020','QL01')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN8','19/05/2020','QL03')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN9','25/06/2020','QL02')
insert into PHIEUNHAP(MaPN, NgayNhap, MaQL)
values('PN10','29/06/2020','QL02')
select*from PHIEUNHAP

insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN1','NL01',8,30000)--Đã chạy
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN1','NL02',4,45000)--Đã chạy
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN2','NL02',10,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN2','NL03',10,50000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN3','NL03',5,50000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN3','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN4','NL04',10,55000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN4','NL03',5,50000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN4','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN5','NL05',5,60000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN5','NL03',5,50000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN5','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN6','NL06',3,400000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN6','NL05',5,60000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN6','NL03',5,50000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN7','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN7','NL07',6,48000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN8','NL08',8,39000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN8','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN8','NL07',6,48000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN9','NL09',5,60000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN9','NL02',5,45000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN9','NL07',6,48000)
insert into CTPHIEUNHAP(MaPN,MaNL,SoLuong,DonGia)
values('PN10','NL010',8,280000)
select*from CTPHIEUNHAP
select*from PHIEUNHAP
select *from NGUYENLIEU

set dateformat dmy
insert into PHIEUXUAT
values('PX01','NV02','13/05/2019')
insert into PHIEUXUAT
values('PX02','NV02','22/6/2019')--
insert into PHIEUXUAT
values('PX03','NV02','28/08/2019')
insert into PHIEUXUAT
values('PX04','NV02','29/09/2019')
insert into PHIEUXUAT
values('PX05','NV02','17/12/2019')
insert into PHIEUXUAT
values('PX06','NV02','09/03/2020')
insert into PHIEUXUAT
values('PX07','NV02','24/07/2020')
insert into PHIEUXUAT
values('PX08','NV02','09/08/2020')
insert into PHIEUXUAT
values('PX09','NV02','23/09/2020')
insert into PHIEUXUAT
values('PX010','NV01','13/10/2020')
select*from PHIEUXUAT

insert into CTPHIEUXUAT
values('PX01','NL01',1)
insert into CTPHIEUXUAT
values('PX01','NL02',2)
insert into CTPHIEUXUAT
values('PX01','NL03',2)
insert into CTPHIEUXUAT
values('PX01','NL04',2)
insert into CTPHIEUXUAT
values('PX01','NL05',2)--
insert into CTPHIEUXUAT
values('PX02','NL02',3)
insert into CTPHIEUXUAT
values('PX03','NL03',1)
insert into CTPHIEUXUAT
values('PX04','NL04',3)
insert into CTPHIEUXUAT
values('PX05','NL05',4)
insert into CTPHIEUXUAT
values('PX06','NL06',2)
insert into CTPHIEUXUAT
values('PX07','NL07',3)
insert into CTPHIEUXUAT
values('PX08','NL08',1)
insert into CTPHIEUXUAT
values('PX09','NL09',2)
insert into CTPHIEUXUAT
values('PX010','NL010',4)
select*from CTPHIEUXUAT
select *from NGUYENLIEU

insert into GIAMGIA
values ('GG1', 0.1, '02/12/2020'),
	   ('GG2', 0.3, '04/12/2020'),
	   ('GG3', 0.2, '05/12/2020'),
	   ('GG4', 0.4, '03/12/2020'),
	   ('GG5', 0.06, '12/12/2020'),
	   ('GG6', 0.5, '02/12/2020'),
	   ('GG7', 0.04, '10/12/2020'),
	   ('GG8', 0.02, '11/12/2020'),
	   ('GG9', 0.1, '24/11/2020'),
	   ('GG10', 0.06, '23/11/2020')


select * from ban where tenban=N'Bàn Số 01'
select * from HOADON where MaHD = 'HD59'
Update HOADON set ThanhToan = 67500 where MaHD= 'HD59'

delete from cthoadon where mahd='HD73' and mamon='MON027'
SELECT * FROM HOADON
Update HOADON set TienThoi = TienNhan - ThanhToan where MaHD='HD04'