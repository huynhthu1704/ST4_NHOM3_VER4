set dateformat dmy
GO
--Stored procedure
---------------------------- BỘ PHẬN ----------------------------
--Lấy danh sách bảng bộ phận
drop database NHOM3_QLSIEUTHICOOPMART
CREATE PROC sp_DSBoPhan
	AS
		BEGIN 
			SELECT * FROM BoPhan 
	END

GO

CREATE PROC sp_DSBoPhanGiamDan
	AS
		BEGIN 
			SELECT * FROM BoPhan ORDER BY MaBP DESC
	END
GO


--Thêm ds bộ phận
CREATE PROC sp_ThemBoPhan(@MaBP varchar(10),@TenBP nvarchar(30),@SDT varchar(11),@MaQL varchar(10))
AS
	BEGIN 
		INSERT INTO BoPhan(MaBP, TenBP, SDT, MaQL)
		VALUES(@MaBP, @TenBP, @SDT, @MaQL)
	END
GO

--Thêm ds bộ phận
CREATE PROC sp_ThemBoPhanKhCoQL(@MaBP varchar(10),@TenBP nvarchar(30),@SDT varchar(11))
AS
	BEGIN 
		INSERT INTO BoPhan(MaBP, TenBP, SDT)
		VALUES(@MaBP, @TenBP, @SDT)
	END
GO

--Sửa ds bộ phận
CREATE PROC sp_SuaBoPhan(@MaBP varchar(10),@TenBP nvarchar(30),@SDT varchar(11),@MaQL varchar(10))
AS
	BEGIN 
		UPDATE BoPhan
		SET TenBP=@TenBP,SDT=@SDT,MaQL=@MaQL
		WHERE MaBP=@MaBP
	END
GO

-- Xóa ds bộ phận
CREATE PROC sp_XoaBoPhan(@MaBP varchar(10))
AS
	BEGIN 
		DELETE 
		FROM BoPhan
		Where MaBP = @MaBP
	END
GO

-- Tìm mã bộ phận
CREATE PROC sp_TimBoPhan(@MaBP varchar(10))
AS
	BEGIN 
		SELECT * 
		FROM BoPhan
		WHERE MaBP = @MaBP
	END
GO

--- Add values
exec sp_ThemBoPhan 'BP01', N'Ban quản lý', '123456787', NULL
exec sp_ThemBoPhan 'BP02', N'Thu Ngân', '123456788', NULL	
exec sp_ThemBoPhan 'BP03', N'Thủ Kho', '123456789', NULL
exec sp_ThemBoPhan 'BP04', N'Chăm sóc khách hàng', '123456787', NULL	
	
GO

---------------------------- LOẠI TÀI KHOẢN ----------------------------
-- Lấy LoaiTaiKhoan
CREATE PROC sp_LayLoaiTaiKhoan
AS
	BEGIN
		SELECT * FROM LoaiTaiKhoan
		ORDER BY MaLoaiTK desc
	END
GO

--Thêm LoaiTaiKhoan
CREATE PROC sp_ThemLoaiTaiKhoan(@MaLoaiTK varchar(10), @TenLoaiTK nvarchar(50))
AS
	BEGIN
		INSERT INTO LoaiTaiKhoan(MaLoaiTK,TenLoaiTK)
		VALUES (@MaLoaiTK, @TenLoaiTK)	
	END
GO

--Sửa LoaiTaiKhoan
CREATE PROC sp_SuaLoaiTaiKhoan(@MaLoaiTK varchar(10), @TenLoaiTK nvarchar(50))
AS
	BEGIN
		UPDATE LoaiTaiKhoan
		SET  TenLoaiTK = @TenLoaiTK
		WHERE MaLoaiTK = @MaLoaiTK
	END
GO

--Xóa LoaiTaiKhoan
CREATE PROC sp_XoaLoaiTaiKhoan(@MaLoaiTK varchar(10))
AS
	BEGIN
		DELETE 
		FROM LoaiTaiKhoan
		WHERE MaLoaiTK = @MaLoaiTK
	END
GO

--Tìm LoaiTaiKhoan
CREATE PROC sp_TimLoaiTaiKhoan(@MaLoaiTK varchar(10))
AS
	BEGIN
		SELECT * 
		FROM LoaiTaiKhoan
		WHERE MaLoaiTK = @MaLoaiTK
	 END
GO

exec sp_ThemLoaiTaiKhoan 'ML01',N'Admin'
exec sp_ThemLoaiTaiKhoan 'ML02',N'ThuNgan'
exec sp_ThemLoaiTaiKhoan 'ML03',N'ThuKho'
exec sp_ThemLoaiTaiKhoan 'ML04',N'CSKH'

GO

---------------------------- TÀI KHOẢN ----------------------------
--Lấy danh sách tài khoản
GO
CREATE PROC sp_LayTaiKhoan
AS
	BEGIN
		SELECT * FROM TaiKhoan
		ORDER BY MaTK DESC
	END
GO

--Thêm tài khoản
CREATE PROC sp_ThemTaiKhoan(@MaTK varchar(10), @TenDangNhap varchar(20), @MatKhau varchar(20), @MaLoaiTK varchar(10))
AS
	BEGIN
		INSERT INTO TaiKhoan(MaTK, TenDangNhap, MatKhau, MaLoaiTK)
		VALUES (@MaTK, @TenDangNhap, @MatKhau, @MaLoaiTK)	
	END
GO

--Sửa tài khoản
CREATE PROC sp_SuaTaiKhoan(@MaTK varchar(10), @TenDangNhap varchar(20), @MatKhau varchar(20), @MaLoaiTK varchar(10))
AS
	BEGIN
		UPDATE TaiKhoan
		SET TenDangNhap = @TenDangNhap ,MatKhau = @MatKhau, MaLoaiTK = @MaLoaiTK
		WHERE MaTK = @MaTK
	END
GO

--Xóa tài khoản
CREATE PROC sp_XoaTaiKhoan(@MaTK varchar(10))
AS
	BEGIN
		DELETE 
		FROM TaiKhoan
		WHERE MaTK = @MaTK
	END
GO

-- Tìm tài khoản
CREATE PROC sp_TimTaiKhoan(@MaTK varchar(10))
AS
	BEGIN
		SELECT * 
		FROM TaiKhoan
		WHERE MaTK = @MaTK
	END
GO

-- Kiểm tra tài khoản đăng nhập
CREATE PROC sp_KiemTraDN(@TenDangNhap varchar(20), @MatKhau varchar(20))
AS
	BEGIN
		SELECT * 
		FROM TaiKhoan
		WHERE TenDangNhap = @TenDangNhap AND MatKhau =@MatKhau
	END
GO

-- Insert mẫu
exec sp_ThemTaiKhoan 'TK01', 'admin', '1234', 'ML01'
exec sp_ThemTaiKhoan 'TK02', 'thungan', '1234', 'ML02'
exec sp_ThemTaiKhoan 'TK03', 'thukho', '1234', 'ML03'
exec sp_ThemTaiKhoan 'TK04', 'cskh', '1234', 'ML04'
GO

---------------------------- NH N VIÊN ----------------------------
--Lấy ds bảng nhân viên
GO 
CREATE PROC sp_LayNhanVien
AS
	BEGIN 
		SELECT *, HoNV + ' ' +TenNV as 'HoTen' 
		FROM NhanVien
	END
GO


CREATE PROC sp_LayNhanVienGiamDan
AS
	BEGIN 
		SELECT *, HoNV + ' ' +TenNV as 'HoTen' 
		FROM NhanVien
		ORDER BY MaNV desc
	END
GO


--Thêm nhân viên
CREATE PROC sp_ThemNhanVien(@MaNV varchar(10), @HoNV nvarchar(50), @TenNV nvarchar(10), @SDT varchar(11), @GioiTinh nvarchar(3),
 @CCCD varchar(12), @NgaySinh date, @DiaChi nvarchar(100), @NgayVaoLam date, @MaBP varchar(10), @MaTK varchar(10))
AS
	BEGIN 
		INSERT INTO NhanVien(MaNV, HoNV, TenNV, SDT, GioiTinh, CCCD, NgaySinh, DiaChi, NgayVaoLam, MaBP, MaTK)
		VALUES(@MaNV, @HoNV, @TenNV, @SDT, @GioiTinh, @CCCD, @NgaySinh, @DiaChi, @NgayVaoLam, @MaBP, @MaTK)
	END
GO

--Sửa nhân viên
CREATE PROC sp_SuaNhanVien(@MaNV varchar(10), @HoNV nvarchar(50), @TenNV nvarchar(10), @SDT varchar(11), @GioiTinh nvarchar(3),
 @CCCD varchar(12), @NgaySinh date, @DiaChi nvarchar(100), @NgayVaoLam date, @MaBP varchar(10), @MaTK varchar(10))
AS
	BEGIN 
		UPDATE NhanVien
		SET HoNV = @HoNV, TenNV = @TenNV, SDT = @SDT, GioiTinh = @GioiTinh, CCCD = @CCCD, NgaySinh = @NgaySinh, DiaChi = @DiaChi, NgayVaoLam = @NgayVaoLam, MaBP = @MaBP, MaTK = @MaTK
		WHERE MaNV = @MaNV
	END

--Xóa Nhân viên
GO
CREATE PROC sp_XoaNhanVien(@MaNV varchar(10))
AS
	BEGIN
		DELETE 
		FROM NhanVien
		WHERE MaNV= @MaNV
	 END
GO

--Tìm Nhân viên
CREATE PROC sp_TimNhanVien(@MaNV varchar(10))
AS
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE MaNV= @MaNV
	 END
GO

--lấy nhân viên theo mã bp
CREATE PROC sp_LayNhanVienTheoBP(@MaBP varchar(10))
AS
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE MaBP= @MaBP
	 END
GO

--lấy nhân viên theo tài khoản đăng nhập
CREATE PROC sp_TimNVTheoTKDN(@MaTK varchar(10))
AS
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE MaTK= @MaTK
	 END
GO

--	 exec sp_LayNhanVienTheoBP 'BP02'

exec sp_ThemNhanVien 'NV01', N'Huỳnh Thị Ngọc', N'Thư', '123456789', N'Nữ',
 '123456789012', '17/04/2001', N'Thủ Đức', '01/12/2021', 'BP01', 'TK01'
 exec sp_ThemNhanVien 'NV02', N'Nguyễn Thành Đức', N'Trí', '123456789', N'Nam',
 '123456789012', '14/09/2001', N'Thủ Đức', '01/02/2021', 'BP02', 'TK02'
 exec sp_ThemNhanVien 'NV03', N'Đàng Thanh', N'Quốc', '123456789', N'Nam',
 '123456789012', '18/08/2002', N'Quận 9', '21/05/2021', 'BP03', 'TK03'
  exec sp_ThemNhanVien 'NV04', N'Nguyễn Ngọc', N'Vân', '123456789', N'Nữ',
 '123456789012', '18/08/2002', N'Quận 7', '21/05/2021', 'BP04', 'TK04'

GO


---------------------------- LOẠI THẺ KHÁCH HÀNG ----------------------------
--- Lấy LoaiTheKH
CREATE PROC sp_LayLoaiTheKH
AS
	BEGIN
		SELECT * FROM LoaiTheKH ORDER BY MaLoaiThe desc
	END
GO

---Thêm LoaiTheKH
CREATE PROC sp_ThemLoaiTheKH(@Ma char(10), @Ten nvarchar(10))
AS 
	BEGIN
		INSERT INTO LoaiTheKH(MaLoaiThe,TenLoaiThe)
		VALUES(@Ma,@Ten)
	END
GO

--- Sửa LoaiTheKH
CREATE PROC sp_SuaLoaiTheKH(@Ma char(10), @Ten nvarchar(10))
AS
	BEGIN
		UPDATE LoaiTheKH
		SET TenLoaiThe=@Ten
		WHERE MaLoaiThe=@Ma
	END
GO

---Xoa LoaiTheKH
CREATE PROC sp_XoaLoaiTheKH(@Ma char(10))
AS
	BEGIN
		DELETE FROM LoaiTheKH
		WHERE MaLoaiThe=@Ma
	END
GO

--- Lấy LoaiTheKH
CREATE PROC sp_TimLoaiTheKH(@Ma char(10))
AS
	BEGIN
		SELECT * FROM LoaiTheKH WHERE MaLoaiThe=@Ma
	END
GO

exec sp_ThemLoaiTheKH 'LT01', N'Đồng'
exec sp_ThemLoaiTheKH 'LT02', N'Bạc'
exec sp_ThemLoaiTheKH 'LT03', N'Vàng'
exec sp_ThemLoaiTheKH 'LT04', N'Bạch Kim'
GO

---------------------------- THẺ KHÁCH HÀNG ----------------------------
--Lấy danh sách Thẻ khách hàng
Go
CREATE PROC sp_LayTheKhachHang
AS
	BEGIN
		SELECT * FROM TheKhachHang
	END
GO	

CREATE PROC sp_LayTheKHGiamDan
AS
	BEGIN
		SELECT * FROM TheKhachHang ORDER BY MaTheKH DESC
	END
GO	

--Lấy danh sách Thẻ khách hàng theo mã thẻ
CREATE PROC sp_LayTheKHTheoMa(@MaTheKH varchar(16))
AS
	BEGIN
		SELECT * FROM TheKhachHang where MaTheKH = @MaTheKH
	END
GO

--Thêm thẻ khách hàng
CREATE PROC sp_ThemTheKhachHang(@MaTheKH varchar(16))
AS
	BEGIN
		INSERT INTO TheKhachHang(MaTheKH, LoaiThe)
		VALUES(@MaTheKH, 'LT01')
	END
GO

--Sửa thẻ khách hàng
CREATE PROC sp_SuaTheKhachHang(@MaTheKH varchar(16), @LoaiThe varchar(10), @TinhTrang bit)
AS
	BEGIN
		UPDATE TheKhachHang 
		SET LoaiThe = @LoaiThe, TinhTrang = @TinhTrang
		WHERE MaTheKH = @MaTheKH
	END
GO

--Sửa tình trạng thẻ khách hàng
CREATE PROC sp_SuaTinhTrangTheKH(@MaTheKH varchar(16), @TinhTrang bit)
AS
	BEGIN
		UPDATE TheKhachHang 
		SET TinhTrang = @TinhTrang
		WHERE MaTheKH = @MaTheKH
	END
GO

--Sửa điểm thẻ khách hàng
CREATE PROC sp_SuaDiemTheKH(@MaTheKH varchar(16), @DiemTL int)
AS
	BEGIN
		UPDATE TheKhachHang 
		SET DiemTL = @DiemTL
		WHERE MaTheKH = @MaTheKH
	END
GO

--Xóa thẻ khách hàng
CREATE PROC sp_XoaTheKhachHang(@MaTheKH varchar(16))
AS
	BEGIN
		DELETE 
		FROM TheKhachHang
		WHERE MaTheKH =  @MaTheKH
	END
GO

CREATE PROC sp_TimTheKhachHang(@MaTheKH varchar(16)) 
AS
	BEGIN
		SELECT * FROM TheKhachHang WHERE MaTheKH = @MaTheKH
	END
GO

exec sp_ThemTheKhachHang 'TKH001'
exec sp_ThemTheKhachHang 'TKH002'
exec sp_ThemTheKhachHang 'TKH003'
exec sp_ThemTheKhachHang 'TKH004'
GO

---------------------------- KHÁCH HÀNG ----------------------------
--Lấy danh sách khách hàng
GO
CREATE PROC sp_LayKhachHang
AS
	BEGIN
		SELECT * FROM KhachHang
	END
GO

CREATE PROC sp_LayKhachHangGiamDan
AS
	BEGIN
		SELECT * FROM KhachHang ORDER BY MaKH DESC
	END
GO

--Thêm khách hàng
CREATE PROC sp_ThemKhachHang(@MaKH varchar(10), @HoTenKH nvarchar(50), @GioiTinh nvarchar(3), @SDT varchar(11), @DiaChi nvarchar(100))
AS
	BEGIN
		INSERT INTO KhachHang(MaKH, HoTenKH, GioiTinh, SDT, DiaChi)
		VALUES (@MaKH, @HoTenKH, @GioiTinh, @SDT, @DiaChi)	
	END
GO

--Sửa khách hàng
CREATE PROC sp_SuaKhachHang(@MaKH varchar(10), @HoTenKH nvarchar(50), @GioiTinh nvarchar(3), @SDT varchar(11), @DiaChi nvarchar(100))
AS
	BEGIN
		UPDATE KhachHang
		SET HoTenKH = @HoTenKH,GioiTinh = @GioiTinh,SDT = @SDT, DiaChi = @DiaChi
		WHERE MaKH = @MaKH
	END
GO

--Sửa thẻ khách hàng
CREATE PROC sp_SuaTheKH(@MaKH varchar(10),@MaTheKH varchar(16))
AS
	BEGIN
		UPDATE KhachHang
		SET MaTheKH = @MaTheKH
		WHERE MaKH = @MaKH
	END
GO

--Xóa kh
CREATE PROC sp_XoaKhachHang(@MaKH varchar(10))
AS
	BEGIN
		DELETE FROM KhachHang
		WHERE MaKH = @MaKH
	END
GO

--Tìm kh
CREATE PROC sp_TimKhachHang(@MaKH varchar(10))
AS
	BEGIN
		SELECT * FROM KhachHang
		WHERE MaKH = @MaKH
	END
GO

EXEC sp_ThemKhachHang 'KH01',	N'Nguyễn My',	N'Nữ',	'96354785',	N'Quận 2 - HCM'
EXEC sp_ThemKhachHang 'KH02',	N'Nguyễn Nê',	N'Nam',	'026354785',	N'Quận 5 - HCM'
EXEC sp_ThemKhachHang 'KH03',	N'Trần Hoàng Nam',	N'Nam',	'026354755',	N'Quận 9 - HCM'
GO

---------------------------- PHIẾU ĐĂNG KÝ THẺ KHÁCH HÀNG----------------------------

--lấy phieu dk thẻ kh
GO
CREATE PROC SP_LayPhieuDKTheKHTheoMaGiam
AS
	BEGIN 
		SELECT * FROM PhieuDangKyTheKH ORDER BY MaPhieu DESC
	END
GO

CREATE PROC SP_LayPhieuDKTheKH
AS
	BEGIN 
		SELECT * FROM PhieuDangKyTheKH
	END
GO

--Thêm phiếu dk
CREATE PROC sp_ThemPhieuDKTheKH(@MaPhieu varchar(10),@MaNV varchar(10) ,@MaTheKH varchar(16) , @MaKH varchar(10))
AS
	BEGIN
		INSERT INTO PhieuDangKyTheKH(MaPhieu ,MaNV ,MaTheKH, MaKH)
		VALUES(@MaPhieu ,@MaNV ,@MaTheKH, @MaKH)
	END
GO

--Tìm phiếu dk
CREATE PROC sp_TimPhieuDKTheKH(@MaPhieu varchar(10))
AS
	BEGIN
		SELECT * 
		FROM PhieuDangKyTheKH
		WHERE MaPhieu = @MaPhieu
	END
GO

-------------------------- ĐƠN VỊ TÍNH ----------------------------
--Lấy dánh sách đơn vị tính
GO
CREATE PROC sp_LayDonViTinh
AS
	BEGIN
		SELECT * FROM DonViTinh
	END
GO

CREATE PROC sp_LayDonViTinhGiamDan
AS
	BEGIN
		SELECT * FROM DonViTinh ORDER BY MaDVT DESC
	END
GO

-- Thêm Đơn vị tính
CREATE PROC sp_ThemDonViTinh(@MaDVT varchar(10), @TenDVT nvarchar(50))
AS
	BEGIN	 
	INSERT INTO DonViTinh(MaDVT, TenDVT)
	VALUES(@MaDVT, @TenDVT)
	END
GO

--Sửa đơn vị tính
CREATE PROC sp_SuaDonViTinh(@MaDVT varchar(10), @TenDVT nvarchar(50))
AS
	BEGIN
		UPDATE DonViTinh
		SET TenDVT = @TenDVT
		WHERE MaDVT = @MaDVT
	END
GO

--Xóa đơn vị tính 
CREATE PROC sp_XoaDonViTinh(@MaDVT varchar(10))
AS
	BEGIN
		DELETE
		FROM DonViTinh
		WHERE MaDVT = @MaDVT
	END
GO

exec sp_ThemDonViTinh 'DVT01', N'Gói'
exec sp_ThemDonViTinh 'DVT02', N'Cái'
exec sp_ThemDonViTinh 'DVT03', N'Chiếc'
exec sp_ThemDonViTinh 'DVT04', N'Chai'
exec sp_ThemDonViTinh 'DVT05', N'Kg'
exec sp_ThemDonViTinh 'DVT06', N'Hộp'
exec sp_ThemDonViTinh 'DVT07', N'Tuýp'
exec sp_ThemDonViTinh 'DVT08', N'Đôi'

---------------------------- DANH MỤC HÀNG HÓA ----------------------------
--Lấy ds Danh mục hàng hóa
GO
CREATE PROC sp_LayDanhMucHH
AS
	BEGIN
		SELECT * FROM DanhMucHH
	END
GO

CREATE PROC sp_LayDanhMucHHGiamDan
AS
	BEGIN
		SELECT * FROM DanhMucHH ORDER BY MaDM DESC
	END
GO

--Thêm danh mục hàng hoá
CREATE PROC sp_ThemDanhMucHH(@MaDM varchar(10), @TenDM nvarchar(50))
AS
	BEGIN 
		INSERT INTO DanhMucHH(MaDM, TenDM)
		VALUES(@MaDM, @TenDM)
	END
GO

--Sửa danh mục hàng hóa
CREATE PROC sp_SuaDanhMucHH(@MaDM varchar(10), @TenDM nvarchar(50))
AS
	BEGIN 
		UPDATE DanhMucHH
		SET  TenDM = @TenDM
		WHERE MaDM = @MaDM
	END
GO

--Xóa danh mục hàng hóa
CREATE PROC sp_XoaDanhMucHH(@MaDM varchar(10))
AS
	BEGIN 
		DELETE
		FROM DanhMucHH
		WHERE MaDM = @MaDM
	END

GO
exec sp_ThemDanhMucHH 'DM01', N'Bánh Ngọt'
exec sp_ThemDanhMucHH 'DM02', N'Đồ Khô'
exec sp_ThemDanhMucHH 'DM03', N'Trái Cây'
exec sp_ThemDanhMucHH 'DM04', N'Rau Củ'
exec sp_ThemDanhMucHH 'DM05', N'Gia Vị'
exec sp_ThemDanhMucHH 'DM06', N'Gia Dụng'
exec sp_ThemDanhMucHH 'DM07', N'Điện Tử'
exec sp_ThemDanhMucHH 'DM08', N'Thời Trang'
exec sp_ThemDanhMucHH 'DM09', N'Chăm Sóc Cá Nhân'
exec sp_ThemDanhMucHH 'DM10', N'Vệ Sinh Gia Đình'
GO

---------------------------- KHUYẾN MÃI ----------------------------
--lấy danh sách Khuyến mãi
CREATE PROC sp_DSKM
AS
	BEGIN 
		SELECT * FROM KhuyenMai 
	END
GO

CREATE PROC sp_DSKMGiamDan
AS
	BEGIN 
		SELECT * FROM KhuyenMai ORDER BY MaKM DESC
	END
GO

--Thêm khuyến mãi
CREATE PROC sp_ThemKhuyenMai(@MaKM varchar(10), @TenKM nvarchar(50),@GiaTriKM int, @NgayBatDauKM  smalldatetime, @NgayKetThucKM smalldatetime)
AS
	BEGIN 
		INSERT INTO KhuyenMai(MaKM, TenKM, GiaTriKM, NgayBatDauKM, NgayKetThucKM)
		VALUES(@MaKM, @TenKM, @GiaTriKM, @NgayBatDauKM, @NgayKetThucKM)
	END
GO

-- Sửa khuyến mãi
CREATE PROC sp_SuaKhuyenMai(@MaKM varchar(10), @TenKM nvarchar(50), @GiaTriKM int, @NgayBatDauKM  smalldatetime, @NgayKetThucKM smalldatetime)
AS
	BEGIN 
		UPDATE KhuyenMai 
		SET TenKM = @TenKM, NgayBatDauKM = @NgayBatDauKM, NgayKetThucKM = @NgayKetThucKM ,GiaTriKM=@GiaTriKM
		WHERE MaKM = @MaKM
	END
GO

--Xóa khuyến mãi
CREATE PROC sp_XoaKhuyenMai(@MaKM varchar(10))
AS
	BEGIN 
		DELETE 
		FROM KhuyenMai 
		WHERE MaKM = @MaKM
	END
GO

--Tìm KhuyenMai
CREATE PROC sp_TimKhuyenMai(@MaKM varchar(10))
AS
	BEGIN
		SELECT * FROM KhuyenMai
		WHERE MaKM = @MaKM
	END
GO

-- Add values
GO

--EXEC sp_SuaKhuyenMai 'KM01', N'Chào mừng giáng sinh', 5 , '2021-12-01 00:00:00', '2021-12-20 00:00:00'
EXEC sp_ThemKhuyenMai 'KM01', N'Chào mừng giáng sinh', 5 , '06-12-2021 00:00:00', '30-12-2021 00:00:00'
EXEC sp_ThemKhuyenMai 'KM02', N'Mừng năm mới 2022', 10 , '01-12-2021 00:00:00', '30-12-2021 00:00:00'
EXEC sp_ThemKhuyenMai 'KM03', N'Mừng sinh nhật Co.opmart', 10 , '01-12-2021 00:00:00', '20-12-2021 00:00:00'
GO

---------------------------- HÀNG HÓA ----------------------------
--lấy ds bảng hành hóa
GO
CREATE PROC SP_LayHangHoa
AS
	BEGIN 
		SELECT * FROM HangHoa ORDER BY MaHH DESC
	END

--Thêm hàng hóa
GO
CREATE PROC sp_ThemHangHoa(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit, @MaKM varchar(10))
AS
	BEGIN
		INSERT INTO HangHoa(MaHH ,TenHH, DVTinh, Gia, MaDM, BaoHanh, MaKM)
		VALUES(@MaHH ,@TenHH, @DVTinh, @Gia, @MaDM, @BaoHanh, @MaKM)
	END
GO

---- Thêm hàng hóa không có khuyến mãi
CREATE PROC sp_ThemHangHoaKhKM(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit)
AS
	BEGIN
		INSERT INTO HangHoa(MaHH ,TenHH, DVTinh, Gia, MaDM, BaoHanh)
		VALUES(@MaHH ,@TenHH, @DVTinh, @Gia, @MaDM, @BaoHanh)
	END
GO

--Sửa hàng hóa
CREATE PROC sp_SuaHangHoa(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit, @MaKM varchar(10))
AS
	BEGIN
		UPDATE HangHoa 
		SET TenHH = @TenHH, DVTinh = @DVTinh, Gia = @Gia, MaDM = @MaDM, BaoHanh = @BaoHanh, MaKM = @MaKM
		WHERE MaHH = @MaHH
	END
GO

--Sửa hàng hóa không khuyến mãi
CREATE PROC sp_SuaHangHoaKhKM(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit)
AS
	BEGIN
		UPDATE HangHoa 
		SET TenHH = @TenHH, DVTinh = @DVTinh, Gia = @Gia, MaDM = @MaDM, BaoHanh = @BaoHanh
		WHERE MaHH = @MaHH
	END
GO

--Xóa hàng hóa
GO
CREATE PROC sp_XoaHangHoa(@MaHH varchar(10))
AS
	BEGIN
		DELETE 
		FROM HangHoa
		WHERE MaHH = @MaHH
	END
GO

--Xóa hàng hóa
CREATE PROC sp_TimHangHoa(@MaHH varchar(10))
AS
	BEGIN
		SELECT * 
		FROM HangHoa
		WHERE MaHH = @MaHH
	END
GO

--Lấy ds hàng hóa theo dmhh
CREATE PROC sp_LayDSHangHoaTheoDM(@MaDM varchar(10))
AS
	BEGIN
		SELECT *
		FROM HangHoa
		WHERE MaDM = @MaDM 
	END
GO

-- Tìm tên hàng hóa
CREATE PROC sp_TimTenHH(@Ten nvarchar(50))
AS
	BEGIN
		SELECT * 
		FROM HangHoa
		WHERE TenHH= @Ten
	 END
GO
-- Lấy ds hàng hóa có bảo hành
CREATE PROC sp_LayHHCoBaoHanh
AS
	BEGIN
		SELECT *  FROM HangHoa
		WHERE BaoHanh = 1
	END
GO

EXEC sp_ThemHangHoa 'HH01',N'Choco Pie', 'DVT06', 40000, 'DM01', 0, 'KM01'
EXEC sp_ThemHangHoa 'HH02',N'Bánh gạo Kichi', 'DVT01',20000 , 'DM01', 0, 'KM02'
EXEC sp_ThemHangHoa 'HH03',N'Cháo gói Gấu đỏ', 'DVT01', 4000, 'DM01', 0, 'KM03'
EXEC sp_ThemHangHoa 'HH04',N'Mì 3 miền Gold', 'DVT01',3000 , 'DM02', 0, NULL
EXEC sp_ThemHangHoa 'HH05',N'Chuối', 'DVT05',20000 , 'DM03', 0, NULL
EXEC sp_ThemHangHoa 'HH06',N'Cà rốt', 'DVT05',30000 , 'DM04', 0, NULL
EXEC sp_ThemHangHoa 'HH07',N'Dầu ăn Tường An', 'DVT04',35000 , 'DM05', 0, 'KM01'
EXEC sp_ThemHangHoa 'HH08',N'Thớt gỗ Đức Thành', 'DVT02',50000 , 'DM06', 0, NULL
EXEC sp_ThemHangHoa 'HH09',N'Coca Cola', 'DVT05',10000 , 'DM07', 0, NULL
EXEC sp_ThemHangHoa 'HH10',N'Nồi cơm điện Toshiba', 'DVT02', 500000, 'DM08', 1, NULL
EXEC sp_ThemHangHoa 'HH11',N'Máy sấy tóc Panasonic', 'DVT02', 350000, 'DM08', 1, NULL
GO

---------------------------- Nhà Cung Cấp ----------------------------
-- Lấy Danh sách NCC
CREATE PROC sp_DSNCC
	AS
		BEGIN 
			SELECT * FROM NhaCungCap
	END
GO

CREATE PROC sp_DSNCCGiamDan
	AS
		BEGIN 
			SELECT * FROM NhaCungCap ORDER BY MaNCC DESC
	END
GO


-- Thêm NCC
CREATE PROC sp_ThemNCC(@MaNCC varchar(10),@TenNCC nvarchar(50),@DiaChi nvarchar(100),@SDT varchar(11),@Email varchar(50))
AS

	BEGIN 
		INSERT INTO NhaCungCap(MaNCC, TenNCC,DiaChi, SDT, Email)
		VALUES(@MaNCC, @TenNCC, @DiaChi, @SDT,@Email)
	END
GO

-- Sửa NCC
CREATE PROC sp_SuaNCC(@MaNCC varchar(10),@TenNCC nvarchar(50),@DiaChi nvarchar(100),@SDT varchar(11),@Email varchar(50))
AS
	BEGIN 
		UPDATE NhaCungCap
		SET TenNCC=@TenNCC,DiaChi=@DiaChi,SDT=@SDT,Email=@Email
		WHERE MaNCC=@MaNCC
	END
GO

-- Xóa NCC
CREATE PROC sp_XoaNCC(@MaNCC varchar(10))
AS
	BEGIN 
		DELETE 
		FROM NhaCungCap
		Where MaNCC = @MaNCC
END
GO

--Tìm NCC
CREATE PROC sp_TimNCC(@MaNCC varchar(10))
AS
	BEGIN 
		SELECT * 
		FROM NhaCungCap
		WHERE MaNCC = @MaNCC
	END
GO

exec sp_ThemNCC 'NCC01', N'CTy TNHH An Lạc', N'Nha Trang','096532145','anlaccompany@gmail.com'
exec sp_ThemNCC 'NCC02', N'Nhà phân phối Hòa Bình', N'TP.HCM','036598514','hoabinhcompany@gmail'
exec sp_ThemNCC 'NCC03', N'Nhập khẩu Nguyễn Hòa', N'Bến Tre','039652254','nhapkhaungyenhoa@gmail.com'
exec sp_ThemNCC 'NCC04', N'Nước Ngọt Bình Dương', N'Bình Dương','096532542','nuocngotbinhduong@gmail.com'
exec sp_ThemNCC 'NCC05', N'Vinasoy', N'TP.HCM','039443833','vinasoy@gmail.com'
GO

---------------------------- KHO ----------------------------
--Lấy kho
CREATE PROC sp_DSKhoGiamDan
AS 
	BEGIN
		SELECT * FROM Kho ORDER BY MaKho DESC
	END
GO

--Lấy kho
CREATE PROC sp_DSKho
AS 
	BEGIN
		SELECT * FROM Kho
	END
GO

---Them Kho
CREATE PROC sp_ThemKho(@MaKho varchar(10) ,@TenKho nvarchar(50))
AS
	BEGIN
		INSERT INTO Kho(MaKho,TenKho)
		VALUES(@MaKho,@TenKho)
	END
GO

---Sua Kho
CREATE PROC sp_SuaKho(@MaKho varchar(10) ,@TenKho nvarchar(50))
AS
	BEGIN
		update Kho
		set TenKho=@TenKho
		WHERE MaKho=@MaKho
	END
GO

---Xoa Kho
CREATE PROC sp_XoaKho(@MaKho varchar(10))
AS
	BEGIN 
		delete from Kho
		WHERE MaKho=@MaKho
	END
GO

--Tim Kho
CREATE PROC sp_TimKho(@MaKho varchar(10))
AS
BEGIN 
		SELECT * 
		FROM Kho
		WHERE MaKho= @MaKho
	END
GO


-- Tìm kho
CREATE PROC sp_TimMaKho(@MaKho varchar(10))
AS
	BEGIN
		SELECT * 
		FROM Kho
		WHERE MaKho  = @MaKho
	 END
GO

---Add value
EXEC sp_ThemKho 'K01', N'Kho Tầng 1'
EXEC sp_ThemKho 'K02', N'Kho Tầng 2'
GO


---------------------------- HÓA ĐƠN NHẬP HÀNG ----------------------------
--lấy ds HDNH
GO
CREATE PROC sp_LayHDNH
AS
	BEGIN 
		SELECT * FROM HoaDonNhapHang
		ORDER BY MaHD desc
	END
GO

--Thêm HDNH
CREATE PROC sp_ThemHDNH(@MaHD varchar(10),@MaNCC varchar(10), @MaNV varchar(10), @TongTien int, @TraTruoc int, @CongNo int)
AS
	BEGIN
		INSERT INTO HoaDonNhapHang(MaHD ,MaNCC, MaNV, TongTien, TraTruoc, CongNo)
		VALUES(@MaHD ,@MaNCC, @MaNV, @TongTien, @TraTruoc, @CongNo)
	END
GO

--Sửa HDNH
CREATE PROC sp_SuaHDNH(@MaHD varchar(10),@MaNCC varchar(10), @MaNV varchar(10), @TongTien int, @TraTruoc int, @CongNo int)
AS
	BEGIN
		UPDATE HoaDonNhapHang 
		SET MaNCC = @MaNCC, MaNV = @MaNV, TongTien= @TongTien, TraTruoc = @TraTruoc, CongNo = @CongNo
		WHERE MaHD = @MaHD
	END
GO

--Xóa HDNH
CREATE PROC sp_XoaHDNH(@MaHD varchar(10))
AS
	BEGIN
		DELETE 
		FROM HoaDonNhapHang
		WHERE MaHD = @MaHD
	END
GO

--- Tìm HDNH
CREATE PROC sp_TimHDNH(@MaHD varchar(10))
AS
	BEGIN
		SELECT * FROM HoaDonNhapHang WHERE MaHD = @MaHD
	END
GO

exec sp_ThemHDNH 'HD001','NCC01', 'NV02',212000 , 212000, 0

---------------------------- CHI TIẾT HÓA ĐƠN NHẬP HÀNG ----------------------------
--lấy ds HDNH
GO
CREATE PROC SP_LayChiTietNhapHang
AS
	BEGIN 
		SELECT * FROM ChiTietNhapHang
	END
GO

--Thêm HDNH
CREATE PROC sp_ThemChiTietNhapHang(@MaHD varchar(10) ,
									@MaHH varchar(10),
									@SL int , 
									@Gia int,
									@ThanhTien int, 
									@MaKho varchar(10))
AS
	BEGIN
		INSERT INTO ChiTietNhapHang(MaHD ,MaHH, SL, Gia, ThanhTien, MaKho)
		VALUES(@MaHD ,@MaHH, @SL,@Gia ,@ThanhTien ,@MaKho)
	END
GO

--Sửa HDNH
CREATE PROC sp_SuaChiTietNhapHang(@MaHD varchar(10) ,
									@MaHH varchar(10),
									@SL int , 
									@Gia int ,
									@ThanhTien int, 
									@MaKho varchar(10))
AS
	BEGIN
		UPDATE ChiTietNhapHang 
		SET @SL = @SL, @Gia = @Gia, @ThanhTien = @ThanhTien, MaKho = @MaKho
		WHERE MaHD = @MaHD AND MaHH = @MaHH
	END
GO

--Xóa HDNH
CREATE PROC sp_XoaChiTietNhapHang(@MaHD varchar(10), @MaHH varchar(10))
AS
	BEGIN
		DELETE 
		FROM ChiTietNhapHang
		WHERE MaHD = @MaHD AND MaHH = @MaHH
	END
GO

--- Tìm HDNH
CREATE PROC sp_TimChiTietNhapHang(@MaHD varchar(10), @MaHH varchar(10))
AS
	BEGIN
		SELECT * FROM ChiTietNhapHang WHERE MaHD = @MaHD AND MaHH = @MaHH
	END
GO

exec sp_ThemChiTietNhapHang 'HD001' ,'HH01', 4,36000, 144000 ,'K01'
exec sp_ThemChiTietNhapHang 'HD001' ,'HH02', 3,18000, 54000 ,'K01'
exec sp_ThemChiTietNhapHang 'HD001' ,'HH03', 4,3500, 14000 ,'K01'
GO

---------------------------- TỒN KHO ----------------------------
--- Lấy TonKho
CREATE PROC sp_LayTonKho
AS
	BEGIN
		SELECT * FROM TonKho
	END
GO

---Thêm TonKho
CREATE PROC sp_ThemTonKho(@MaHH varchar(10), @MaKho varchar(10), @SL int)
AS 
	BEGIN
		INSERT INTO TonKho(MaHH,MaKho,SL)
		VALUES(@MaHH,@MaKho, @SL)
	END
GO

--- Sửa TonKho
CREATE PROC sp_SuaTonKho(@MaHH varchar(10), @MaKho varchar(10), @SL int)
AS
	BEGIN
		UPDATE TonKho
		SET SL=@SL
		WHERE MaHH=@MaHH and MaKho =@MaKho
	END
GO

--- Tìm TonKho
CREATE PROC sp_TimTonKhoTheoKho(@MaHH varchar(10), @MaKho varchar(10))
AS
	BEGIN
		SELECT * FROM TonKho WHERE MaHH = @MaHH AND MaKho = @MaKho
	END
GO

  --- Tìm tonKho
 CREATE PROC sp_TimTonKho(@MaHH varchar(10))
 AS
	 BEGIN
		 SELECT * FROM TonKho
		 WHERE MaHH=@MaHH 
	 END
 GO

   --- Đếm số lượng tồn
 CREATE PROC sp_DemTonKho(@MaHH varchar(10))
 AS
	 BEGIN
		 SELECT SUM(SL) as 'TongSL' FROM TonKho
		 WHERE MaHH=@MaHH 
	 END
 GO


-- Thêm tồn kho
 exec sp_ThemTonKho 'HH01', 'K01', 4
 exec sp_ThemTonKho 'HH02', 'K01', 3
 exec sp_ThemTonKho 'HH03', 'K01', 4
 GO

---------------------------- PHIẾU BẢO HÀNH ----------------------------
--Lay PhieuBaoHanh
 GO
CREATE PROC sp_LayPhieuBaoHanh
AS
	BEGIN
		SELECT* FROM PhieuBaoHanh
	END
GO


CREATE PROC sp_LayPhieuBaoHanhGiamDan
AS
	BEGIN
		SELECT* FROM PhieuBaoHanh ORDER BY MaPhieuBH DESC
	END
GO
---Them PhieuBaoHanh
CREATE PROC sp_ThemPhieuBaoHanh(@MaPhieuBH varchar(10),@MaHH varchar(10),@MaKH varchar(10),@NgayMua date,@ThoiHanBH date)
AS
	BEGIN
		INSERT INTO PhieuBaoHanh(MaPhieuBH,MaHH,MaKH,NgayMua,ThoiHanBH)
		VALUES(@MaPhieuBH,@MaHH,@MaKH,@NgayMua,@ThoiHanBH)
	END
GO

---Sua PhieuBaoHanh
CREATE PROC sp_SuaPhieuBaoHanh(@MaPhieuBH varchar(10),@MaHH varchar(10),@MaKH varchar(10),@NgayMua date,@ThoiHanBH date)
AS
	BEGIN
		UPDATE PhieuBaoHanh
		SET MaHH=@MaHH,MaKH=@MaKH,NgayMua=@NgayMua,ThoiHanBH=@ThoiHanBH
		WHERE MaPhieuBH=@MaPhieuBH
	END
GO

---Xoa PhieuBaoHanh
CREATE PROC sp_XoaPhieuBaoHanh(@MaPhieuBH varchar(10))
AS
	BEGIN
		DELETE FROM PhieuBaoHanh
		WHERE MaPhieuBH=@MaPhieuBH
	END
GO
---tìm PhieuBaoHanh
CREATE PROC sp_TimPhieuBaoHanh(@MaPhieuBH varchar(10))
AS
	BEGIN
		SELECT * FROM PhieuBaoHanh
		WHERE MaPhieuBH=@MaPhieuBH
	END
GO


------------------------------ HÓA ĐƠN ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayHoaDon
AS 
	BEGIN
		SELECT * FROM HoaDon 
	END
GO
--Lấy HoaDon
CREATE PROC sp_LayHoaDonTheoMaHD(@MaHD varchar(10))
AS 
	BEGIN
		SELECT * FROM HoaDon WHERE MaHD = @MaHD
	END
GO


--Lấy HoaDonTheoMaGiamDan
CREATE PROC sp_LayHoaDonGiamDan
AS 
	BEGIN
		SELECT * FROM HoaDon ORDER BY MaHD DESC
	END
GO

--Them HoaDon đối với khách vãng lai
CREATE PROC sp_ThemHoaDonKhachVL(@MaHD varchar(20),
	@MaNV varchar(10) ,
	@GhiChu nvarchar(200),
	@TienHang int,
	@KhuyenMai int,
	@ChietKhau int,
	@TongTien int,
	@TienKhachDua int,
	@TienThoi int)
AS 
	BEGIN
		INSERT INTO HoaDon(MaHD,MaTheKH,MaNV ,GhiChu,TienHang, KhuyenMai, ChietKhau, TongTien,TienKhachDua, TienThoi)
		VALUES(@MaHD, NULL,@MaNV,@GhiChu,@TienHang, @KhuyenMai, @ChietKhau, @TongTien, @TienKhachDua, @TienThoi)
	END
GO

--Them HoaDon
CREATE PROC sp_ThemHoaDonTheoMaKH(@MaHD varchar(20),
	@MaTheKH varchar(10),
	@MaNV varchar(10) ,
	@GhiChu nvarchar(200),
	@TienHang int,
	@KhuyenMai int,
	@ChietKhau int,
	@TongTien int,
	@DiemTL int,
	@TienKhachDua int,
	@TienThoi int)
AS 
	BEGIN
		INSERT INTO HoaDon(MaHD,MaTheKH,MaNV ,GhiChu,TienHang, KhuyenMai, ChietKhau, TongTien, DiemTL, TienKhachDua, TienThoi)
		VALUES(@MaHD,@MaTheKH,@MaNV ,@GhiChu,@TienHang, @KhuyenMai, @ChietKhau, @TongTien, @DiemTL, @TienKhachDua, @TienThoi)
	END
GO

---Xoa HoaDon
CREATE PROC sp_XoaHoaDon(@MaHD varchar(20))
AS
	BEGIN 
		DELETE FROM HoaDon
		WHERE MaHD=@MaHD
	END
GO


------------------------------ CHI TIẾT HÓA ĐƠN ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayChiTietHD
AS 
	BEGIN
		SELECT * FROM ChiTietHoaDon
	END
GO

--Lấy Chi tiết hóa đơn theo mã hóa đơn
CREATE PROC sp_LayCTHDThemMaHD(@MaHD varchar(10))
AS 
	BEGIN
		SELECT * FROM ChiTietHoaDon WHERE MaHD = @MaHD
	END
GO


---Them ChiTietHoaDon
CREATE PROC sp_ThemChiTietHD(@MaHD varchar(20) ,@MaHH varchar(10),@SL int,@Gia int,@KhuyenMai int,@Thanhtien int)
AS 
	BEGIN
		INSERT INTO ChiTietHoaDon(MaHD,MaHH,SL,Gia,KhuyenMai,ThanhTien)
		VALUES(@MaHD,@MaHH,@SL,@Gia, @KhuyenMai,@Thanhtien)
	END
GO

--Sua ChiTietHoaDon
CREATE PROC sp_SuaChiTietHD(@MaHD varchar(20) ,@MaHH varchar(16),@SL int,@Gia int,@Thanhtien int)
AS
	BEGIN
		UPDATE ChiTietHoaDon
		SET SL=@SL , Gia=@Gia,ThanhTien=@Thanhtien
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO

--Xoa ChiTietHoaDon
CREATE PROC sp_XoaChiTietHoaDon(@MaHD varchar(20) ,@MaHH varchar(16))
AS
	BEGIN
		DELETE FROM ChiTietHoaDon
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO














