/*
Đề tài: Quản lý siêu thị Coopmart
Thành viên: 
	Huỳnh Thị Ngọc Thư
	Nguyễn Thành Đức Trí
	Đàng Thanh Quốc
*/
--drop database NHOM3_QLSIEUTHICOOPMART
CREATE DATABASE NHOM3_QLSIEUTHICOOPMART
GO
USE NHOM3_QLSIEUTHICOOPMART
GO
SET DATEFORMAT dmy
------------ Tạo bảng Bộ Phận ------------
CREATE TABLE BoPhan 
(
	MaBP varchar(10) primary key,-- Mã bộ phận 
	TenBP nvarchar(30) not null, -- Tên bộ phận 
	SDT varchar(11) not null, -- Số điện thoại 
	MaQL varchar(10) default null -- Mã quản lý 
)
GO

--drop table NhanVien
------------ Tạo bảng Nhân Viên ------------
CREATE TABLE NhanVien 
(
	MaNV varchar(10) primary key, -- Mã nhân viên 
	HoNV nvarchar(50) not null, -- Họ nhân viên 
	TenNV nvarchar(10) not null, -- Tên Nhân viên
	SDT varchar(11) not null, -- Số điện thoại 
	GioiTinh nvarchar(3) not null, -- Giới tính 
	CCCD varchar(12) not null, -- Căn cước công dân
	NgaySinh date not null, -- Ngày sinh
	DiaChi nvarchar(100), -- Địa chỉ
	NgayVaoLam date not null, -- Ngày vào làm
	MaBP varchar(10), -- Mã bộ phận quản lý
	MaTK varchar (10) -- Tài khoản đăng nhập
)
GO

------------ Tạo bảng Tài khoản đăng nhập ------------
CREATE TABLE TaiKhoan
(
	MaTK varchar(10) primary key, -- Mã tài khoản
	TenDangNhap varchar(20) not null, -- Tên đăng nhập
	MatKhau varchar(20) not null, -- Mật khẩu đăng nhập
	MaLoaiTK varchar(10) -- Mã loai tài khoản
) 

------------ Tạo bảng Loại tài khoản ------------
CREATE TABLE LoaiTaiKhoan
(
	MaLoaiTK varchar(10) primary key, -- Mã vai trò
	TenLoaiTK nvarchar(50) not null, -- Tên vai trò trong đăng nhập
)
GO
------------ Tạo bảng Khách Hàng ------------
CREATE TABLE KhachHang
(
	MaKH varchar(10) primary key, -- Mã Khách hàng
	HoTenKH nvarchar(50) not null, -- Họ tên khách hàng
	GioiTinh nvarchar(3), -- Giới tính
	SDT varchar(11) not null, -- Số điện thoại 
	DiaChi nvarchar(100), -- Địa chỉ 
	MaTheKH varchar(16) NULL -- Mã thẻ KH
)
GO

------------ Tạo bảng Hàng Hóa ------------
CREATE TABLE HangHoa
(
	MaHH varchar(10) primary key, -- Mã hàng hóa
	TenHH nvarchar(50) not null, -- Tên hàng hóa
	MaDVT varchar(10), -- Đơn vị tính
	Gia int not null, -- Đơn giá
	MaDM varchar(10) , -- Mã danh mục
	BaoHanh bit, -- Có bảo hành hay không
	MaKM varchar(10) null -- Mã khuyến mãi
)

GO

----------- Tạo bảng Đơn Vị Tính ------------
CREATE TABLE DonViTinh
(
	MaDVT varchar(10) primary key, -- Mã đơn vị tính
	TenDVT nvarchar(50) not null, -- Tên đơn vị tính
)
GO

------------ Tạo bảng Danh Mục Sản Phẩm ------------
CREATE TABLE DanhMucHH
(
	MaDM varchar(10) primary key, -- Mã danh mục
	TenDM nvarchar(50) not null -- Tên danh mục
)
GO


------------ Tạo bảng Khuyến Mãi ------------
CREATE TABLE KhuyenMai
(
	MaKM varchar(10) primary key, -- Mã khuyến mãi
	TenKM nvarchar(50) not null, -- Tên khuyến mãi
	GiaTriKM int not null, -- Giá trị khuyến mãi
	NgayBatDauKM  smalldatetime not null, -- Ngày bắt đầu khuyến mãi
	NgayKetThucKM smalldatetime not null, -- Ngày kết thúc khuyến mãi
)
GO

------------ Tạo bảng Phiếu Đăng ký Thẻ KH ------------
CREATE TABLE PhieuDangKyTheKH
(
	MaPhieu varchar(10) primary key, -- Mã phiếu đăng ký thẻ KH
	MaNV varchar(10) , -- Mã nhân viên
	MaTheKH varchar(16) , -- Mã thẻ khách hàng
	MaKH varchar(10) , -- Mã khách hàng
	NgayDangKy date not null default CURRENT_TIMESTAMP, -- Ngày đăng ký
) 
GO


------------ Tạo bảng Thẻ Khách Hàng ------------
CREATE TABLE TheKhachHang
(
	MaTheKH varchar(16) primary key, -- Mã thẻ khách hàng
	LoaiThe varchar(10) not null, -- Loại thẻ
	TinhTrang bit default 0 ,-- Tình trạng thẻ (Sử dụng hay chưa)
	DiemTL int default 0,-- Điểm tích lũy
)
GO

------------ Tạo bảng Loại Thẻ Khách Hàng ------------
CREATE TABLE LoaiTheKH
(
	MaLoaiThe varchar(10) primary key, -- Mã loại thẻ
	TenLoaiThe nvarchar(10) not null, -- Tên loại thẻ
)
GO

------------ Tạo bảng Hóa Đơn ------------
CREATE TABLE HoaDon
(
	MaHD varchar(20) primary key, -- Mã hóa đơn
	MaTheKH varchar(16),  -- Mã thẻ khách hàng
	MaNV varchar(10) , -- Mã nhân viên
	ThoiGianTT smalldatetime not null default CURRENT_TIMESTAMP, -- Thời gian thanh toán
	GhiChu nvarchar(200),
	TienHang int,
	KhuyenMai int,
	ChietKhau int,
	TongTien int,
	DiemTL int default 0,
	TienKhachDua int,
	TienThoi int,
)
GO

------------ Tạo bảng Chi Tiết Hóa Đơn ------------
CREATE TABLE ChiTietHoaDon
(
	MaHD varchar(20), -- Mã hóa đơn
	MaHH varchar(10), -- Mã hàng hóa
	SL int, -- Số lượng
	Gia int, -- Giá
	KhuyenMai int,
	ThanhTien int, -- Thành tiền
	primary key(MaHD, MaHH)
)
GO

------------ Tạo bảng Kho ------------
CREATE TABLE Kho
(
	MaKho varchar(10) primary key , -- Mã kho
	TenKho nvarchar(50) not null -- Tên kho
)
GO

------------ Tạo bảng Tồn Kho ------------
CREATE TABLE TonKho
(
	MaHH varchar(10), -- Mã hàng hóa
	MaKho varchar(10), -- Mã kho
	SL int not null, -- Số lượng
	primary key (MaHH, MaKho)
)
GO

------------ Tạo bảng Nhà Cung Cấp ------------
CREATE TABLE NhaCungCap
(
	MaNCC varchar(10) primary key, -- Mã nhà cung cấp
	TenNCC nvarchar(50) not null, -- Tên nhà cung cấp
	DiaChi nvarchar(100) not null, -- Địa chỉ
	SDT varchar(11) not null, -- Số điện thoại
	Email varchar(50) -- Email
)
GO

------------ Tạo bảng Hóa Đơn Nhập Hàng ------------
CREATE TABLE HoaDonNhapHang
(
	MaHD varchar(10) primary key , -- Mã hóa đơn nhập
	MaNCC varchar(10), -- Mã nhà cung cấp
	MaNV varchar(10), -- Mã nhân viên nhập hàng
	ThoiGian smalldatetime not null default CURRENT_TIMESTAMP ,-- Thời gian nhập hàng
	TongTien int,
	TraTruoc int,
	CongNo int
)

GO

------------ Tạo bảng Chi Tiết Nhập Hàng ------------
CREATE TABLE ChiTietNhapHang
(
	MaHD varchar(10) , -- Mã hóa đơn
	MaHH varchar(10), -- Mã hàng hóa
	SL int not null, -- Số lượng
	Gia int not null, -- Đơn giá
	ThanhTien int, -- Thành tiền
	MaKho varchar(10), -- Mã kho
	primary key(MaHD,MaHH, MaKho)
)
GO


------------ Tạo bảng Phiếu Bảo Hành ------------
CREATE TABLE PhieuBaoHanh
(
	MaPhieuBH varchar(10) primary key, -- Mã phiếu bảo hành
	MaHH varchar(10), -- Mã hàng hóa
	MaKH varchar(10), -- Mã khách hàng
	NgayMua date, -- Ngày mua
	ThoiHanBH date, -- Thời hạn bảo hành
)
GO


-- Thêm khóa ngoại cho cột MaBP của bảng BoPhan
ALTER TABLE BoPhan
ADD CONSTRAINT FK_BoPhan_NhanVien
FOREIGN KEY (MaQL) REFERENCES NhanVien(MaNV) on delete set null
--GO

-- Thêm khóa ngoại cho cột MaBP của bảng Nhân Viên
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_BoPhan
FOREIGN KEY (MaBP) REFERENCES BoPhan(MaBP) on delete set null
GO

-- Thêm khóa ngoại cho cột MaTK của bảng Nhân Viên
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_TaiKhoan
FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK) on delete set null
GO


-- Thêm khóa ngoại cho cột MaTheKH của bảng Khách hàng
ALTER TABLE KhachHang
ADD CONSTRAINT FK_KhachHang_TheKH
FOREIGN KEY (MaTheKH) REFERENCES TheKhachHang(MaTheKH) on delete set null
GO

-- Thêm khóa ngoại cho cột LoaiVaiTro của bảng Nhân Viên
ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_LoaiTaiKhoan
FOREIGN KEY (MaLoaiTK) REFERENCES LoaiTaiKhoan(MaLoaiTK) on delete set null
GO

-- Thêm khóa ngoại cho cột MaDM của bảng Hàng Hóa
ALTER TABLE HangHoa
ADD CONSTRAINT FK_HangHoa_DanhMucHH
FOREIGN KEY (MaDM) REFERENCES DanhMucHH(MaDM) on delete set null
GO

-- Thêm khóa ngoại cho cột MaKM của bảng Hàng Hóa
ALTER TABLE HangHoa
ADD CONSTRAINT FK_HangHoa_KhuyenMai
FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM) on delete set null
GO

ALTER TABLE HangHoa
ADD CONSTRAINT FK_HangHoa_DonViTinh
FOREIGN KEY (MaDVT) REFERENCES DonViTinh(MaDVT)  on delete set null
GO

--Thêm khóa ngoại cho cột MaNV của bảng Phiếu đăng ký Thẻ KH
ALTER TABLE PhieuDangKyTheKH
ADD CONSTRAINT FK_PhieuDangKyTheKH_NhanVien
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete set null
GO

--Thêm khóa ngoại cho cột MaTheKH của bảng Phiếu đăng ký Thẻ KH
ALTER TABLE PhieuDangKyTheKH
ADD CONSTRAINT FK_PhieuDangKyTheKH_TheKhachHang
FOREIGN KEY (MaTheKH) REFERENCES TheKhachHang(MaTheKH) on delete set null
GO

--Thêm khóa ngoại cho cột MaKH của bảng Phiếu đăng ký Thẻ KH 
ALTER TABLE PhieuDangKyTheKH
ADD CONSTRAINT FK_PhieuDangKyTheKH_KhachHang
FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete set null
GO

-- Thêm khóa ngoại cho cột LoaiThe của bảng Thẻ Khách Hàng
ALTER TABLE TheKhachHang
ADD CONSTRAINT FK_TheKhachHang_LoaiTheKH
FOREIGN KEY (LoaiThe) REFERENCES LoaiTheKH(MaLoaiThe)
GO

-- Thêm khóa ngoại cho cột MaNV của bảng Hóa Đơn
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_NhanVien
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete set null
GO

-- Thêm khóa ngoại cho cột MaTheKH của bảng Hóa Đơn
ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_TheKhachHang
FOREIGN KEY (MaTheKH) REFERENCES TheKhachHang(MaTheKH) on delete set null
GO

-- Thêm khóa ngoại cho cột MaHD của bảng Chi Tiết Hóa Đơn
ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon
FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) on delete cascade
GO

-- Thêm khóa ngoại cho cột MaHH của bảng Chi Tiết Hóa Đơn
ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_HangHoa
FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH) on delete cascade
GO
-- Thêm khóa ngoại cho cột MaHH của bảng Tồn Kho
ALTER TABLE TonKho
ADD CONSTRAINT FK_TonKho_HangHoa
FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH) 
GO

-- Thêm khóa ngoại cho cột MaKho của bảng Tồn Kho
ALTER TABLE TonKho
ADD CONSTRAINT FK_TonKho_Kho
FOREIGN KEY (MaKho) REFERENCES Kho(MaKho)
GO

-- Thêm khóa ngoại cho cột MaNCC của bảng Hóa Đơn Nhập Hàng
ALTER TABLE HoaDonNhapHang
ADD CONSTRAINT FK_HoaDonNhapHang_NhaCungCap
FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC) on delete set null
GO

-- Thêm khóa ngoại cho cột MaNV của bảng Hóa Đơn Nhập Hàng
ALTER TABLE HoaDonNhapHang
ADD CONSTRAINT FK_HoaDonNhapHang_NhanVien
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete set null
GO

-- Thêm khóa ngoại cho cột MaKho của bảng Hóa Đơn Nhập Hàng
ALTER TABLE ChiTietNhapHang
ADD CONSTRAINT FK_ChiTietNhapHang_Kho
FOREIGN KEY (MaKho) REFERENCES Kho(MaKho) on delete no action
GO

-- Thêm khóa ngoại cho cột MaHD của bảng Chi Tiết Nhập Hàng
ALTER TABLE ChiTietNhapHang
ADD CONSTRAINT FK_ChiTietNhapHang_HoaDonNhapHang
FOREIGN KEY (MaHD) REFERENCES HoaDonNhapHang(MaHD) on delete cascade
GO

-- Thêm khóa ngoại cho cột MaHH của bảng Chi Tiết Nhập Hàng
ALTER TABLE ChiTietNhapHang
ADD CONSTRAINT FK_ChiTietNhapHang_HangHoa
FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH)  on delete cascade
GO

-- Thêm khóa ngoại cho cột MaHH của bảng Phiếu Bảo Hành 
ALTER TABLE PhieuBaoHanh
ADD CONSTRAINT FK_PhieuBaoHanh_HangHoa
FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH)  on delete set null
GO

-- Thêm khóa ngoại cho cột MaKH của bảng Phiếu Bảo Hành 
ALTER TABLE PhieuBaoHanh
ADD CONSTRAINT FK_PhieuBaoHanh_KhachHang
FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)  on delete set null
GO
















