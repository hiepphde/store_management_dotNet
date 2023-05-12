drop database QL_CUAHANGXEMAYHT

CREATE DATABASE QL_CUAHANGXEMAYHT
USE QL_CUAHANGXEMAYHT
GO

--QUẢN LÝ NHÂN VIÊN

ALTER AUTHORIZATION ON DATABASE::QL_CUAHANGXEMAYHT TO sa; 
CREATE TABLE PHONGBAN
(
	MaPH NCHAR(10) NOT NULL,
	TeNPH NVARCHAR(50),
	CONSTRAINT PK_PHONGBAN PRIMARY KEY (MaPH),
	
)
CREATE TABLE NHANVIEN
(  
	MaNV NCHAR(10) NOT NULL,
	HoTen NVARCHAR(50),
	TenDangNhap nvarchar(20) ,
	MatKhau nvarchar(45) ,
	Email nvarchar(45) ,
	NGAYSINH DATE,
	DiaChi NVARCHAR(50),
	SĐT NCHAR(20),
	Phai NCHAR(5),	
	Luong FLOAT,
	ChucVu NVARCHAR(100),
	MaPH NCHAR(10),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNV)
	
)

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_PHONGBAN FOREIGN KEY (MaPH)  REFERENCES PHONGBAN (MaPH)

CREATE TABLE KHACHHANG(
	MaKH nchar(10),
	HoTen nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT nchar(11),
	PHAI NCHAR(5),	
	constraint PK_KH primary key(MaKH)
)

CREATE TABLE SANPHAM(
	MaXe nchar(10) PRIMARY KEY,
	TenXe nvarchar(30),
	Loai NVARCHAR(30),
	MauSon NVARCHAR(30),
	SoKhung NVARCHAR(50),
	DungTich NVARCHAR(20),
	HangXe NVARCHAR(50),
	NSX nvarchar(10),
	NgaySX DATETIME,
	TGBH nvarchar(20),
	SoLuong INT,
	GiaBan FLOAT,
	Anh NVARCHAR(200),
	GhiChu NVARCHAR (200),

)


CREATE TABLE NHACC(
	MaNCC nchar(10) PRIMARY KEY,
	TenNCC NVARCHAR(100),
)

CREATE TABLE HDNHAP(
	MaHD_Nhap nchar(10)PRIMARY KEY,
	MaXe nchar(10) ,
	MaNCC NCHAR(10),
	NgayLap DATE,
	SoLuong int,
	GiaNhap float,
	Thue FLOAT,
	TongTien Float,
	MaNV nchar (10),
)

ALTER TABLE HDNHAP
ADD CONSTRAINT FK_HDNHAP_NHACC FOREIGN KEY(MaNCC) REFERENCES NHACC(MaNCC)

ALTER TABLE HDNHAP
ADD CONSTRAINT FK_HDNHAP_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE HDNHAP
ADD CONSTRAINT FK_HDNHAP_SANPHAM FOREIGN KEY (MaXe)  REFERENCES SANPHAM(MaXe)


CREATE TABLE HDXUAT
(
	MaHD_Xuat NCHAR(10) PRIMARY KEY,
	MaXe NCHAR(10),
	DonGia float,
	SoLuong int,
	MaKH nchar(10),
	SDT nchar(11),
	ĐC_GiaoHang NVARCHAR(100),
	NgayLap Date,
	GiamGia float,
	TongTien float,
	MaNV nchar(10),
	
)
ALTER TABLE HDXUAT
ADD CONSTRAINT FK_HDXUAT_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV)
ALTER TABLE HDXUAT
ADD CONSTRAINT FK_HDXUAT_KHACHHANG FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE HDXUAT
ADD CONSTRAINT FK_HDXUAT_SANPHAM FOREIGN KEY(MaXe) REFERENCES SANPHAM(MaXe)



CREATE TABLE BAOCAO(
	MaBC int not null IDENTITY(1,1) PRIMARY KEY,
	MaXe nchar(10),
	SoLuongNhap int,
	SoLuongBan int,
	TonKho int
)

ALTER TABLE BAOCAO
ADD CONSTRAINT FK_BAOCAO_SANPHAM FOREIGN KEY (MaXe)  REFERENCES SANPHAM(MaXe)

CREATE TABLE BAOHANH(
	MaBH nchar (10) PRIMARY KEY,
	MaXe nchar(10),
	Gia float,
	NgayXuat date,
	ThoiGianBH date,
	TinhTrangXe NVARCHAR (100),
	MaNV NCHAR(10),
	MaKH nchar(10)
)

ALTER TABLE BAOHANH
ADD	CONSTRAINT FK_BAOHANH_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE BAOHANH
ADD CONSTRAINT FK_BAOHANH_SANPHAM FOREIGN KEY(MaXe) REFERENCES SANPHAM(MaXe)

ALTER TABLE BAOHANH
ADD CONSTRAINT FK_BAOHANH_KH FOREIGN KEY(MaKH) REFERENCES KHACHHANG(MaKH)


create table NgayCong
(
	MaNV nchar(10) not null primary key,
	soNgay int,
)
alter table ngaycong
add constraint FK_NgayCong_NhanVien foreign key (MaNV) references NHANVIEN(MaNV)

Create table TaiKhoan
(
	TenDN nchar(50) primary key,
	MatKhau char(20),
	MaNV nchar(10),
	Constraint TK_NV foreign key (MaNV) references NhanVien(MaNV)
)
---------------------------CÁC RÀNG BUỘC XỬ LÝ---------------------------------

---------------------------RÀNG BUỘC TOÀN VẸN----------------------------------------------------------------
--Đơn giá trong bảng SANPHAM phải lớn hơn 0
ALTER TABLE SANPHAM
ADD CONSTRAINT CHK_DONGIA CHECK(GiaBan>0) 

--Số lượng trong bảng SANPHAM phải lớn hơn 0
ALTER TABLE SANPHAM
ADD CONSTRAINT CHK_SOLUONG CHECK(SoLuong>0) 

--Đơn giá trong bảng HDNHAP phải lớn hơn 0
ALTER TABLE HDNHAP
ADD CONSTRAINT CHK_DONGIA2 CHECK(GiaNhap>0)
 
--Đơn giá trong bảng HDONXUAT phải lớn hơn 0
ALTER TABLE HDXUAT
ADD CONSTRAINT CHK_DONGIA3 CHECK(DonGia>0)

-- RANG BUOC PHAI NHANVIEN LÀ NAM OR NỮ
ALTER TABLE NHANVIEN
ADD CONSTRAINT CHK_PHAI CHECK(Phai=N'Nam' OR Phai=N'Nữ')

--RANG BUOC PHAI KHACHHANG LÀ NAM OR NỮ
ALTER TABLE KHACHHANG
ADD CONSTRAINT CHK_PHAIKH CHECK(Phai=N'Nam' OR Phai=N'Nữ')
-----------------------TRIGGER-------------------------------------
go
create TRIGGER TrigBaoCao ON SANPHAM
FOR INSERT
AS
	DECLARE @Maxe nchar(10)
	set @Maxe = (select MaXe from inserted)
	insert into BAOCAO(MaXe) values (@Maxe)


go
CREATE TRIGGER SLN_BaoCao ON HDNHAP
FOR INSERT,UPDATE
AS
	BEGIN
		DECLARE @SLN int
		set @SLN = (select SUM(SoLuong) from HDNHAP where MaXe = (SELECT MaXe FROM inserted))

		UPDATE BAOCAO
		SET SoLuongNhap = @SLN
		WHERE MaXe = (SELECT MaXe FROM inserted)
	END
	
go

CREATE TRIGGER SLX_BaoCao ON HDXuat
FOR INSERT,UPDATE
AS
	BEGIN
		DECLARE @SLX int
		set @SLX = (select SUM(SoLuong) from HDXUAT where MaXe = (SELECT MaXe FROM inserted))

		UPDATE BAOCAO
		SET SoLuongBan = @SLX
		WHERE MaXe = (SELECT MaXe FROM inserted) 
	END

-- Thêm cột tồn kho để tính số lượng tồn

-- trigger tồn kho
go
create trigger TonKho on BAOCAO
for update
as
	begin
		update BAOCAO
		set tonKho = (select (SoLuongNhap-SoLuongBan) from inserted)
		where MaXe = (select MaXe from inserted)
	end

go
CREATE trigger set_InsertBaoCao on BAOCAO
for insert
as
	begin
		update BAOCAO
		set SoLuongBan = 0,SoLuongNhap = 0,TonKho = 0
		where MaXe = (select MaXe from inserted)
	end

go
create trigger trigNgayCong on NHANVIEN
for insert
as
	begin
		declare @MaNV nchar(10), @ngay int
		set @MaNV = (select MaNV from inserted)
		set @ngay = 1
		insert into NgayCong values(@MaNV,@ngay)
	end

-- Trigger tài khoản


go
create Trigger trigTaiKhoan on NhanVien
for insert
as
	begin
		declare @TenDN nvarchar(45), @MK nchar(20), @MaNV nchar(10)
		set @TenDN = (select Email from inserted)
		set @MK = 'Nv123'
		set @MaNV = (select MaNV from inserted)
		insert into TaiKhoan values (@TenDN,@MK,@MaNV)
	end

go
create trigger triTK_NV on NhanVien
for delete
as
	begin
		delete from TAIKHOAN where MaNV = (select MaNV from deleted)
	end

insert into TaiKhoan(TenDN,MatKhau) values ('ADMIN','123')

go
create trigger TrigTongTien on HDNHAP
for insert,UPDATE
as
	begin
		declare @thue float, @tong float, @SL int
		set @thue = ((select Thue from inserted)*(select GiaNhap from inserted))
		set @tong = @thue + (select GiaNhap from inserted)
		set @SL = (select SoLuong from inserted)

		update HDNHAP
		set Thue = @thue, TongTien = @tong*@SL
		where MaHD_Nhap = (select MaHD_Nhap from inserted)
	end
GO
CREATE trigger TrigTongTien_XUAT on HDXUAT
for insert,UPDATE
as
	begin
		declare @giam float, @tong float, @SL int
		set @giam = ((select GiamGia from inserted)*(select DonGia from inserted))
		set @tong = (select DonGia from inserted) - @giam
		set @SL = (select SoLuong from inserted)

		update HDXUAT
		set  GiamGia = @giam, TongTien = @tong*@SL
		where MaHD_Xuat = (select MaHD_Xuat from inserted)
	end
go
CREATE TRIGGER TRIG_BAOHANH ON HDXUAT
FOR INSERT
AS	
	BEGIN
		declare @MaBH nchar(10), @MaXe nchar(10), @gia money, @NgayXuat date, @ThoiGian date, @Tinhtrang nvarchar(100), @MaNV nchar(10), @MaKH nchar(10)
		set @MaBH = (select MaHD_Xuat from inserted)
		set @MaXe = (select MaXe from inserted)
		set @gia = (select TongTien from inserted)
		set @NgayXuat = (select NgayLap from inserted)
		set @ThoiGian = (select NgayLap from inserted)
		set @Tinhtrang = N'Xe mới'
		set @MaNV = (select MaNV from inserted)
		set @MaKH = (select MaKH from inserted)

		insert into BAOHANH values (@MaBH,@MaXe,@gia,@NgayXuat,@ThoiGian,@Tinhtrang,@MaNV,@MaKH)
	END

GO
--CREATE TRIGGER TRIG_DelBAOHANH on HDXUAT
--FOR DELETE
--AS
--	BEGIN
--		DELETE FROM BAOHANH WHERE MaBH = (SELECT MaHD_Xuat FROM deleted)
--	END
--DROP TRIGGER TRIG_DelBAOHANH

ALTER TABLE TAIKHOAN 
ADD CONSTRAINT fk_TK_NV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV) ON DELETE CASCADE

ALTER TABLE NGAYCONG 
ADD CONSTRAINT fk_NgayCong_NV FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV) ON DELETE CASCADE

ALTER TABLE BAOCAO 
ADD CONSTRAINT fk_BaoCao_SP FOREIGN KEY (MaXe) REFERENCES SANPHAM(MaXe) ON DELETE CASCADE

ALTER TABLE HDNHAP 
ADD CONSTRAINT fk_HDNHAP_SP FOREIGN KEY (MaXe) REFERENCES SANPHAM(MaXe) ON DELETE CASCADE

ALTER TABLE HDXUAT
ADD CONSTRAINT fk_HDXUAT_SP FOREIGN KEY (MaXe) REFERENCES SANPHAM(MaXe) ON DELETE CASCADE

ALTER TABLE BAOHANH
ADD CONSTRAINT fk_BAOHANH_SP FOREIGN KEY (MaXe) REFERENCES SANPHAM(MaXe) ON DELETE CASCADE

ALTER TABLE BAOCAO 
ADD CONSTRAINT fk_BaoCao_SP FOREIGN KEY (MaXe) REFERENCES SANPHAM(MaXe) ON DELETE CASCADE

---- CSDL ---- 
SET DATEFORMAT DMY

delete from KHACHHANG
insert into KHACHHANG
values
('KH0001',N'Trần Trung Chánh','12/02/1989',N'TP.HCM','0956651331',N'Nam'),
('KH0002',N'Trần Thanh Phong','02/12/1987',N'Vũng Tàu','0989895671',N'Nam'),
('KH0003',N'Nguyễn Thị Yến Vy','12/04/1986',N'TP.HCM','0924671268',N'Nữ'),
('KH0004',N'Lê Xuân Hải','20/08/1989',N'Hà Nội','0967765434',N'Nữ'),
('KH0005',N'Trần Phương Bình','13/09/1980',N'Hà Nội','0969965775',N'Nam'),
('KH0006',N'Trần Văn Ngọc','21/12/1988',N'TP.HCM','0944169614',N'Nam'),
('KH0007',N'Trịnh Kim Ngân','23/01/1987',N'Bến Tre','0989657821',N'Nữ'),
('KH0008',N'Trịnh Thị Xuyến','22/05/1986',N'Bến Tre','0976120846',N'Nữ'),
('KH0009',N'Tô Thanh Bảo','01/07/1988',N'Vũng Tàu','0923561246',N'Nam'),
('KH0010',N'Phan Thanh Mạnh','02/06/1987',N'TP.HCM','0956893523',N'Nam');

DELETE FROM PHONGBAN
insert into PHONGBAN
values
('PH01',N'Phòng quản lý'),
('PH02',N'Phòng nhân sự'),
('PH03',N'Phòng tài chính'),
('PH04',N'Phòng kho'),
('PH05',N'Phòng kỹ thuật'),
('PH06',N'Phòng chăm sóc khách hàng');


DELETE FROM NHANVIEN
SET DATEFORMAT DMY
insert into NHANVIEN values('NV01',N'Dương Minh Huy',N'MinhHuy2503','dmh2503','minhhuyduong7@gmail.com','12/02/2000',N'Kiên Giang','09123456782',N'Nam',300000,N'Quản lý','PH01')
insert into NHANVIEN values('NV02',N'Huỳnh Kiều Khuyên',N'KhuyenHuynh1410','hkk1410','huynha704@gmail.com','25/4/2001',N'Cà Mau','09467834561',N'Nữ',500000,N'TP.Tài chính','PH03')
insert into NHANVIEN values('NV03',N'Trần Thanh Phú',N'ThanhPhu2712','ttp2712','tranthanhphu2712@gmail.com','27/12/2001',N'TP HCM','09984753167',N'Nam',350000,N'TP.Nhân sự','PH02')
insert into NHANVIEN values('NV04',N'Phạm Đình Thúc Đệ',N'PhucDe11/4','pdpd1104','depham2001@gmail.com','11/4/2001',N'Bình Định','09984753867',N'Nam',550000,N'Quản lý kho','PH04')
insert into NHANVIEN values('NV05',N'Nguyễn Trần Tuấn Anh',N'TuanAnh1201','ntta1201','tuananhnguyen01@gmail.com','12/01/2001',N'Bến Tre','09967293581',N'Nam',400000,N'Nhân viên kho','PH04')
insert into NHANVIEN values('NV06',N'Trần Văn Thiện',N'ThienTran1502','tvt1502','tranvanthien152@gmail.com','15/02/1999',N'TP HCM','0991502547',N'Nam',350000,N'Nhân viên kỹ thuật','PH04')
insert into NHANVIEN values('NV07',N'Tô Việt Hoàng',N'ToHoang910','tvh910','toviethoang910@gmail.com','09/10/2001',N'Sóc Trăng','09988520016',N'Nam',260000,N'Nhân viên kỹ thuật','PH04')
insert into NHANVIEN values('NV08',N'Nguyễn Văn Dũng',N'DungNguyen0608','nvd0608','nguyenvandung68@gmail.com','06/08/2000',N'Đà Nẵng','0988390766',N'Nam',420000,N'Nhân viên tư vấn chăm sóc khách hàng','PH05')
insert into NHANVIEN values('NV09',N'Trần Thị Kim Anh',N'KimAnh1609','ttka1609','tranthikimanh1609@gmail.com','16/09/2002',N'Quảng Ngãi','0955182599',N'Nữ',520000,N'Nhân viên bán hàng','PH05')
insert into NHANVIEN values('NV010',N'Phạm Vũ Anh Thư',N'ThuPham1712','pvat1712','pvat1712@gmail.com','17/12/2001',N'Cà Mau','09091146722',N'Nữ',320000,N'Nhân viên tư vấn chăm sóc khách hàng','PH05')


DELETE FROM SANPHAM
insert into SANPHAM values ('X001',N'Wave Alpha 110cc',N'Xe Số',N'Trắng đen bạc',N'FHNA-11884',N'110cc',N'Honda',N'Thái Lan','12/01/1995','3 Năm',100,18000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X002',N'Wave Alpha 110cc',N'Xe Số',N'Đỏ đen bạc',N'JKRE-10985',N'110cc',N'Honda',N'Thái Lan','12/01/1995','3 Năm',100,18000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X003',N'Wave Alpha 110cc',N'Xe Số',N'Xanh đen bạc',N'FRES-2907',N'110cc',N'Honda',N'Thái Lan','12/01/1995','3 Năm',100,18000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X004',N'Future 125 FI',N'Xe Số',N'Bạc nâu đen',N'KAJGGE-34283516',N'125cc',N'Honda',N'Việt Nam','25/2/2011','3 Năm',100,30000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X005',N'Future 125 FI',N'Xe Số',N'Xanh nâu đen',N'BUEJKW-2583062',N'125cc',N'Honda',N'Việt Nam','25/2/2011','3 Năm',100,30000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X006',N'Future 125 FI',N'Xe Số',N'Đỏ nâu đen',N'OEGGSW-08153728',N'125cc',N'Honda',N'Việt Nam','25/2/2011','3 Năm',100,30000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X007',N'Jupiter FI',N'Xe Số',N'Đỏ Đen', N'NFTWAFH-77549012',N'114cc',N'Yamaha',N'Việt Nam','27/12/2000','3 Năm',100,30000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X008',N'Jupiter FI',N'Xe Số',N'Xanh Đen', N'NHIFEH-67893648',N'114cc',N'Yamaha',N'Việt Nam','27/12/2000','3 Năm',100,30000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X009',N'Jupiter FI',N'Xe Số',N'Đỏ Nâu', N'AFHJIT-54559215',N'114cc',N'Yamaha',N'Việt Nam','27/12/2000','3 Năm',100,30000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X010',N'Sirius FI ',N'Xe Số',N'Đỏ Đen', N'LGDFHR-96345626',N'115cc',N'Yamaha',N'Nhật Bản','27/12/2000','3 Năm',100,24000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X011',N'Sirius FI ',N'Xe Số',N'Trắng Đen', N'JGFFHT-123769759',N'115cc',N'Yamaha',N'Nhật Bản','27/12/2000','3 Năm',100,24000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X012',N'Sirius FI ',N'Xe Số',N'Xám Đen', N'FHASWH-92607790',N'115cc',N'Yamaha',N'Nhật Bản','27/12/2000','3 Năm',100,24000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X013',N'Blade 110',N'Xe Số',N'Đen Đỏ Xám', N'KJHUYT-98712365',N'109.1cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,22000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X014',N'Blade 110',N'Xe Số',N'Đen Xanh Xám ', N'MNBYTR-98723476',N'109.1cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,22000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X015',N'Blade 110',N'Xe Số',N'Đen Trắng Bạc', N'OIUDSA-76593476',N'109.1cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,22000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X016',N'Wave RSX FI 110',N'Xe Số',N'Trắng Đen', N'TRAHGFI-98775434',N'109.2cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,25000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X017',N'Wave RSX FI 110',N'Xe Số',N'Xanh Đen', N'QWEDFG-23476512',N'109.2cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,25000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X018',N'Wave RSX FI 110',N'Xe Số',N'Đỏ Đen', N'POIHGF-98767065',N'109.2cc',N'Honda',N'Việt Nam','27/12/2000','3 Năm',100,25000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X019',N'Vision',N'Xe Tay ga',N'Đỏ Nâu Đen', N'UYTMNB-09823476',N'109.5cc',N'Honda',N'Nhật Bản','17/08/2012','3 Năm',100,32000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X020',N'Vision',N'Xe Tay ga',N'Trắng Nâu Đen', N'KQQWOJ-89001275',N'109.5cc',N'Honda',N'Nhật Bản','17/08/2012','3 Năm',100,32000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X021',N'Vision',N'Xe Tay ga',N'Xanh Nâu Đen', N'PIOIUY-76509809',N'109.5cc',N'Honda',N'Nhật Bản','17/08/2012','3 Năm',100,32000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X022',N'Air Blade 125/150',N'Xe Tay ga',N'Đen', N'UYTLHH-02342465',N'124.9/149.3cc',N'Honda',N'Việt Nam','22/03/2011','3 Năm',100,43000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X023',N'Air Blade 125/150',N'Xe Tay ga',N'Xanh Đen', N'BVCGFD-64598712',N'124.9/149.3cc',N'Honda',N'Việt Nam','22/03/2011','3 Năm',100,43000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X024',N'Air Blade 125/150',N'Xe Tay ga',N'Đỏ Đen', N'NHTMJY-65012950',N'124.9/149.3cc',N'Honda',N'Việt Nam','22/03/2011','3 Năm',100,43000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X025',N'Sh Mode 125',N'Xe Tay ga',N'Đỏ Đen', N'CTFVFE-65009165',N'124.8cc',N'Honda',N'Việt Nam','07/02/2009','3 Năm',100,55000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X026',N'Sh Mode 125',N'Xe Tay ga',N'Xanh Đen', N'VFENOK-98709120',N'124.8cc',N'Honda',N'Việt Nam','07/02/2009','3 Năm',100,55000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X027',N'Sh Mode 125',N'Xe Tay ga',N'Bạc Đen', N'MYQZXC-08789012',N'124.8cc',N'Honda',N'Việt Nam','07/02/2009','3 Năm',100,55000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X028',N'SH 125i/150i',N'Xe Tay ga',N'Đỏ Đen', N'ZAQMKP-87623409',N'124.8/156.9cc',N'Honda',N'Việt Nam','18/10/2013','3 Năm',100,72000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X029',N'SH 125i/150i',N'Xe Tay ga',N'Trắng Đen', N'NTQUTY-43209834',N'124.8/156.9cc',N'Honda',N'Việt Nam','18/10/2013','3 Năm',100,72000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X030',N'SH 125i/150i',N'Xe Tay ga',N'Xám Đen', N'UOLNGR-01298764',N'124.8/156.9cc',N'Honda',N'Việt Nam','18/10/2013','3 Năm',100,72000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X031',N'Lead 125 FI',N'Xe Tay ga',N'Vàng Nâu', N'BASPDD-98712300',N'124.8cc',N'Yamaha',N'Nhật Bản','24/09/2001','3 Năm',100,39000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X032',N'Lead 125 FI',N'Xe Tay ga',N'Trắng Nâu', N'TRERNT-76578234',N'124.8cc',N'Yamaha',N'Nhật Bản','24/09/2001','3 Năm',100,39000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X033',N'Lead 125 FI',N'Xe Tay ga',N'Đen Nâu', N'NTOOSD-98734112',N'124.8cc',N'Yamaha',N'Nhật Bản','24/09/2001','3 Năm',100,39000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X034',N'Grande',N'Xe Tay ga',N'Đỏ Đen', N'IUYUVD-66982241',N'125cc',N'Yamaha',N'Nhật Bản','20/11/2008','3 Năm',100,45000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X035',N'Grande',N'Xe Tay ga',N'Trắng Đen', N'NJIQWE-75698122',N'125cc',N'Yamaha',N'Nhật Bản','20/11/2008','3 Năm',100,45000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X036',N'Grande',N'Xe Tay ga',N'Đen', N'VFEQSA-12765998',N'125cc',N'Yamaha',N'Nhật Bản','20/11/2008','3 Năm',100,45000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X037',N'Latte',N'Xe Tay ga',N'Đỏ Đen', N'POINHT-12551242',N'124.9cc',N'Yamaha',N'Việt Nam','27/12/2001','3 Năm',100,38000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X038',N'Latte',N'Xe Tay ga',N'Trắng Đen', N'URTQWE-11654889',N'124.9cc',N'Yamaha',N'Việt Nam','27/12/2001','3 Năm',100,38000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X039',N'Latte',N'Xe Tay ga',N'Đen', N'QWESAD-76566712',N'124.9cc',N'Yamaha',N'Việt Nam','27/12/2001','3 Năm',100,38000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X040',N'Janus',N'Xe Tay ga',N'Đỏ', N'DARKQU-54116586',N'125cc',N'Yamaha',N'Nhật Bản','10/02/2002','3 Năm',100,28000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X041',N'Janus',N'Xe Tay ga',N'Trắng', N'DRFSBV-19568799',N'125cc',N'Yamaha',N'Nhật Bản','10/02/2002','3 Năm',100,28000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X042',N'Janus',N'Xe Tay ga',N'Xám ánh xanh', N'ADUOLK-75623422',N'125cc',N'Yamaha',N'Nhật Bản','10/02/2002','3 Năm',100,28000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X043',N'NVX',N'Xe Tay ga',N' Đen Vàng', N'NGASCV-76577123',N'155.1cc',N'Yamaha',N'Indonesia','27/06/2017','3 Năm',100,53000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X044',N'NVX',N'Xe Tay ga',N' Xanh Xám', N'MJOSDS-98712366',N'155.1cc',N'Yamaha',N'Indonesia','27/06/2017','3 Năm',100,53000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X059',N'NVX',N'Xe Tay ga',N' Đỏ Xám', N'QWSADW-10293856',N'155.1cc',N'Yamaha',N'Indonesia','27/06/2017','3 Năm',100,53000000,N'PDG',N'Xe Mới')
 
insert into SANPHAM values ('X045',N'Winner X',N'Xe Tay côn',N'Xanh Đen Bạc', N'TNHSXC-76509809',N'149.1cc',N'Honda',N'Nhật Bản','20/12/2014','3 Năm',100,46000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X046',N'Winner X',N'Xe Tay côn',N'Đỏ Đen Bạc', N'OQCNZX-12750078',N'149.1cc',N'Honda',N'Nhật Bản','20/12/2014','3 Năm',100,46000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X047',N'Winner X',N'Xe Tay côn',N'Đen Vàng đồng', N'CQSAST-12417789',N'149.1cc',N'Honda',N'Nhật Bản','20/12/2014','3 Năm',100,46000000,N'PDG',N'Xe Mới')


insert into SANPHAM values ('X048',N'CB150R Exmotion',N'Xe Tay côn',N'Đỏ Đen Bạc', N'CQPSDS-97376823',N'149.2cc',N'Honda',N'Thái Lan','27/09/2000','3 Năm',100,105000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X049',N'CB150R Exmotion',N'Xe Tay côn',N'Đen Bạc ', N'NHTASE-86236788',N'149.2cc',N'Honda',N'Thái Lan','27/09/2000','3 Năm',100,105000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X050',N'MSX125',N'Xe Tay côn',N'Trắng Đỏ', N'SDBQWE-08792325',N'50cc',N'Honda',N'Thái Lan','03/02/2000','3 Năm',100,50000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X051',N'MSX125',N'Xe Tay côn',N'Đỏ Xanh', N'TREASD-76512365',N'50cc',N'Honda',N'Thái Lan','03/02/2000','3 Năm',100,50000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X052',N'MSX125',N'Xe Tay côn',N'Vàng Đen', N'NTISAD-97634266',N'50cc',N'Honda',N'Thái Lan','03/02/2000','3 Năm',100,50000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X053',N'EXCITER 155',N'Xe Tay côn',N'Đỏ Đen', N'BUGSWV-65712300',N'155cc',N'Yamaha',N'Malaysia','27/07/2000','3 Năm',100,47000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X054',N'EXCITER 155',N'Xe Tay côn',N'Đen', N'NTCEVU-76570245',N'155cc',N'Yamaha',N'Malaysia','27/07/2000','3 Năm',100,47000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X055',N'EXCITER 155',N'Xe Tay côn',N'Trắng Đỏ Đen', N'QXETCN-57481056',N'155cc',N'Yamaha',N'Malaysia','27/07/2000','3 Năm',100,47000000,N'PDG',N'Xe Mới')

insert into SANPHAM values ('X056',N'Monkey',N'Xe Tay côn ',N'Vàng Trắng Đen', N'NTORZB-98700256',N'149.3cc',N'Honda',N'Thái Lan','20/03/2000','3 Năm',100,85000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X057',N'Monkey',N'Xe Tay côn ', N'Xanh Trắng Đen', N'SAVCOR-65474829',N'149.3cc',N'Honda',N'Thái Lan','20/03/2000','3 Năm',100,85000000,N'PDG',N'Xe Mới')
insert into SANPHAM values ('X058',N'Monkey',N'Xe Tay côn ', N'Đỏ Trắng Đen', N'TCNQOT-19208502',N'149.3cc',N'Honda',N'Thái Lan','20/03/2000','3 Năm',100,85000000,N'PDG',N'Xe Mới')

insert into NHACC
values
('NCC01',N'CÔNG TY TNHH XNK Ô TÔ ĐẠI ĐÔ THÀNH'),
('NCC02',N'CÔNG TY TNHH THƯƠNG MẠI DỊCH VỤ XUẤT NHẬP KHẨU MÃ LỰC'),
('NCC03',N'CÔNG TY TNHH THƯƠNG MẠI NGỌC HOA'),
('NCC04',N'CÔNG TY TNHH PHƯƠNG NGUYỄN');


DELETE FROM HDNHAP
SET DATEFORMAT DMY
insert into HDNHAP values('HDN01','X020','NCC01','11/05/2019',20,32000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN02','X034','NCC02','23/05/2019',30,45000000,0.05,NULL,N'NV05')
insert into HDNHAP values('HDN03','X040','NCC03','30/09/2019',30,28000000,0.05,NULL,N'NV05')
insert into HDNHAP values('HDN04','X045','NCC04','15/02/2019',20,46000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN05','X001','NCC01','11/05/2019',20,18000000,0.05,NULL,N'NV01')
insert into HDNHAP values('HDN06','X002','NCC02','23/05/2019',30,18000000,0.05,NULL,N'NV02')
insert into HDNHAP values('HDN07','X003','NCC03','30/09/2019',30,18000000,0.05,NULL,N'NV03')
insert into HDNHAP values('HDN08','X004','NCC04','15/02/2019',20,30000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN09','X005','NCC01','11/05/2019',20,30000000,0.05,NULL,N'NV01')
insert into HDNHAP values('HDN10','X006','NCC02','23/05/2019',30,24000000,0.05,NULL,N'NV02')
insert into HDNHAP values('HDN11','X007','NCC03','30/09/2019',30,24000000,0.05,NULL,N'NV03')
insert into HDNHAP values('HDN12','X008','NCC04','15/02/2019',20,24000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN13','X009','NCC01','11/05/2019',20,22000000,0.05,NULL,N'NV01')
insert into HDNHAP values('HDN14','X010','NCC02','23/05/2019',30,22000000,0.05,NULL,N'NV02')
insert into HDNHAP values('HDN15','X011','NCC03','30/09/2019',30,22000000,0.05,NULL,N'NV03')
insert into HDNHAP values('HDN16','X012','NCC04','15/02/2019',10,25000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN17','X012','NCC04','15/04/2019',10,25000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN18','X013','NCC02','23/05/2019',30,22000000,0.05,NULL,N'NV02')
insert into HDNHAP values('HDN19','X014','NCC03','30/09/2019',30,22000000,0.05,NULL,N'NV03')
insert into HDNHAP values('HDN20','X015','NCC04','15/02/2019',20,22000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN21','X016','NCC01','11/05/2019',20,25000000,0.05,NULL,N'NV01')
insert into HDNHAP values('HDN22','X017','NCC02','23/05/2019',30,25000000,0.05,NULL,N'NV02')
insert into HDNHAP values('HDN23','X018','NCC03','30/09/2019',30,25000000,0.05,NULL,N'NV03')
insert into HDNHAP values('HDN24','X019','NCC04','15/02/2019',10,32000000,0.05,NULL,N'NV04')
insert into HDNHAP values('HDN25','X021','NCC04','15/04/2019',10,32000000,0.05,NULL,N'NV04')

--SET DATEFORMAT DMY
DELETE FROM HDXUAT
set dateformat dmy
INSERT INTO HDXUAT VALUES('HDX01','X002',18000000,1,'KH0008','0976120846',N'TP.HCM','20/05/2020',NULL,NULL,'NV09')
INSERT INTO HDXUAT VALUES('HDX02','X003',30000000,1,'KH0001','0956651331',N'TP.HCM','21/05/2020',NULL,NULL,'NV09')
INSERT INTO HDXUAT VALUES('HDX03','X004',52000000,1,'KH0003','0924671268',N'TP.HCM','30/05/2020',NULL,NULL,'NV09')
INSERT INTO HDXUAT VALUES('HDX04','X005',46000000,1,'KH0009','0923561246',N'TP.HCM','1/06/2020',NULL,NULL,'NV09')
INSERT INTO HDXUAT VALUES('HDX05','X002',50000000,1,'KH0010','0956893523',N'TP.HCM','20/02/2021',NULL,NULL,'NV09')

--SET DATEFORMAT DMY
--insert into BAOHANH
--values
--('BH01','X002',N'Trịnh Thị Xuyến',18000000,'20/05/2020','20/05/2023',N'Bị trầy xước','NV06'),
--('BH02','X045',N'Tô Thanh Bảo',46000000,'1/06/2020','12/02/2008',N'Động cơ hư','NV07');



