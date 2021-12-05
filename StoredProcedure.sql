--Storeprocedure
---------------------------- BỘ PHẬN ----------------------------
--Lấy danh sách bảng bộ phận
CREATE PROC sp_DSBoPhan
	AS
		BEGIN 
			SELECT * FROM BoPhan
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
exec sp_ThemBoPhan 'BP03', N'Chăm sóc khách hàng', '123456787', NULL
exec sp_ThemBoPhan 'BP02', N'Thu Ngân', '123456788', NULL	
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
GO
CREATE PROC sp_TimBoPhan(@MaBP varchar(10))
AS
	BEGIN 
		SELECT * 
		FROM BoPhan
		WHERE MaBP = @MaBP
	END

---------------------------- NHÂN VIÊN ----------------------------
--Lấy ds bảng nhân viên
GO 
CREATE PROC sp_LayNhanVien
AS
	BEGIN 
		SELECT * 
		FROM NhanVien
	END


--Thêm nhân viên
GO

CREATE PROC sp_ThemNhanVien(@MaNV varchar(10), @HoNV nvarchar(50), @TenNV nvarchar(10), @SDT varchar(11), @GioiTinh nvarchar(3),
 @CCCD varchar(12), @NgaySinh date, @DiaChi nvarchar(100), @NgayVaoLam date, @MaBP varchar(10), @MaTK varchar(10))
AS
	BEGIN 
		INSERT INTO NhanVien(MaNV, HoNV, TenNV, SDT, GioiTinh, CCCD, NgaySinh, DiaChi, NgayVaoLam, MaBP, MaTK)
		VALUES(@MaNV, @HoNV, @TenNV, @SDT, @GioiTinh, @CCCD, @NgaySinh, @DiaChi, @NgayVaoLam, @MaBP, @MaTK)
	END
	INSERT INTO NhanVien(MaNV, HoNV, TenNV, SDT, GioiTinh, CCCD, NgaySinh, DiaChi, NgayVaoLam, MaBP, MaTK)
		VALUES('NV01', N'Nguyễn', N'Thanh Long', '012365478', 'Nam', '216547851', '2002-11-01', N'Quận 2', '2021-11-05', 'MaBP', 'TK02')
--Sửa nhân viên
exec sp_ThemNhanVien 'NV01', N'Nguyễn', N'Thanh Long', '012365478', 'Nam', '216547851', '2002-11-01', N'Quận 2', '2021-11-05', 'BP01', 'TK02'
exec sp_ThemNhanVien 'NV03', N'Nguyễn', N'Thanh Long', '012365478', 'Nam', '216547851', '2002-11-01', N'Quận 2', '2021-11-05', 'BP02', 'TK02'
exec sp_ThemNhanVien 'NV04', N'Nguyễn', N'Thanh Long', '012365478', 'Nam', '216547851', '2002-11-01', N'Quận 2', '2021-11-05', 'BP03', 'TK02'
exec sp_LayNhanVien
GO
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
--láy nhân viên theo mã bp
GO
CREATE PROC sp_LayNhanVienTheoBP(@MaBP varchar(10))
AS
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE MaBP= @MaBP
	 END
	 exec sp_LayNhanVienTheoBP 'BP02'
--Tìm Nhân viên
GO
CREATE PROC sp_TimNhanVien(@MaNV varchar(10))
AS
	BEGIN
		SELECT * 
		FROM NhanVien
		WHERE MaNV= @MaNV
	 END

---------------------------- TÀI KHOẢN ----------------------------
--Lấy danh sách tài khoản
GO
CREATE PROC sp_LayTaiKhoan
AS
	BEGIN
		SELECT * FROM TaiKhoan
	END

--Thêm tài khoản
GO

CREATE PROC sp_ThemTaiKhoan(@MaTK varchar(10), @TenDangNhap varchar(20), @MatKhau varchar(20), @MaLoaiTK varchar(10))
AS
	BEGIN
		INSERT INTO TaiKhoan(MaTK, TenDangNhap, MatKhau, MaLoaiTK)
		VALUES (@MaTK, @TenDangNhap, @MatKhau, @MaLoaiTK)	
	END
GO
-- Insert mẫu
	INSERT INTO TaiKhoan(MaTK, TenDangNhap, MatKhau, MaLoaiTK)
		VALUES ('TK01', 'ngocthu', '1234', 'ML01')	

	exec sp_ThemTaiKhoan 'TK02', 'ductri', '1234', 'ML01'

--Sửa tài khoản
GO

CREATE PROC sp_SuaTaiKhoan(@MaTK varchar(10), @TenDangNhap varchar(20), @MatKhau varchar(20), @MaLoaiTK varchar(10))
AS
	BEGIN
		UPDATE TaiKhoan
		SET TenDangNhap = @TenDangNhap ,MatKhau = @MatKhau, MaLoaiTK = @MaLoaiTK
		WHERE MaTK = @MaTK
	END
GO

--UPDATE TaiKhoan
--		SET TenDangNhap = 'thanhquoc' ,MatKhau = '1234', MaLoaiTK = 'ML01'
--		WHERE MaTK = 'TK03'

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
	
---------------------------- LOẠI TÀI KHOẢN ----------------------------
-- Lấy LoaiTaiKhoan
CREATE PROC sp_LayLoaiTaiKhoan
AS
	BEGIN
		SELECT * FROM LoaiTaiKhoan
	END

--Thêm LoaiTaiKhoan
GO
CREATE PROC sp_ThemLoaiTaiKhoan(@MaLoaiTK varchar(10), @TenLoaiTK nvarchar(50))
AS
	BEGIN
		INSERT INTO LoaiTaiKhoan(MaLoaiTK,TenLoaiTK)
		VALUES (@MaLoaiTK, @TenLoaiTK)	
	END
exec sp_ThemLoaiTaiKhoan 'ML01','Admin'
--Sửa LoaiTaiKhoan
GO
CREATE PROC sp_SuaLoaiTaiKhoan(@MaLoaiTK varchar(10), @TenLoaiTK nvarchar(50))
AS
	BEGIN
		UPDATE LoaiTaiKhoan
		SET  TenLoaiTK = @TenLoaiTK
		WHERE MaLoaiTK = @MaLoaiTK
	END

--Xóa LoaiTaiKhoan
GO
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

---------------------------- KHÁCH HÀNG ----------------------------
--Lấy danh sách khách hàng
GO
CREATE PROC sp_LayKhachHang
AS
	BEGIN
		SELECT * FROM KhachHang
	END

--Thêm khách hàng
GO
CREATE PROC sp_ThemKhachHang(@MaKH varchar(10), @HoTenKH nvarchar(50), @GioiTinh nvarchar(3), @SDT varchar(11), @DiaChi nvarchar(100)
, @DiemTL int)
AS
	BEGIN
		INSERT INTO KhachHang(MaKH, HoTenKH, GioiTinh, SDT, DiaChi, DiemTL)
		VALUES (@MaKH, @HoTenKH, @GioiTinh, @SDT, @DiaChi, @DiemTL)	
	END

--Sửa khách hàng
GO
CREATE PROC sp_SuaKhachHang(@MaKH varchar(10), @HoTenKH nvarchar(50), @GioiTinh nvarchar(3), @SDT varchar(11), @DiaChi nvarchar(100)
, @DiemTL int)
AS
	BEGIN
		UPDATE KhachHang
		SET HoTenKH = @HoTenKH,GioiTinh = @GioiTinh,SDT = @SDT, DiaChi = @DiaChi, DiemTL = @DiemTL
		WHERE MaKH = @MaKH
	END

--Xóa khách hàng
GO
CREATE PROC SP_XoaKhachHang(@MaKH varchar(10))
AS
	BEGIN
		DELETE KhachHang
		WHERE MaKH = @MaKH
	END



---------------------------- HÀNG HÓA ----------------------------
drop proc sp_ThemHangHoa
--lấy ds bảng hành hóa
GO
CREATE PROC sp_LayHangHoa
AS
	BEGIN 
		SELECT * FROM HangHoa
	END

--Thêm hàng hóa
GO
CREATE PROC sp_ThemHangHoa(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit, @MaKM varchar(10))
AS
	BEGIN
		INSERT INTO HangHoa(MaHH ,TenHH, DVTinh, Gia, MaDM, BaoHanh, MaKM)
		VALUES(@MaHH ,@TenHH, @DVTinh, @Gia, @MaDM, @BaoHanh, @MaKM)
	END
	exec sp_ThemHangHoa 'HH01', N'Thực Phẩm', 'DVT01', 23000, 'DM01',1,'KM01'
	exec sp_ThemHangHoa 'HH010', N'Coca', 'DVT01', 23000, 'DM02',1,'KM01'
	exec sp_ThemHangHoa 'HH011', N'Chổi', 'DVT01', 23000, 'DM03',1,'KM01'
--Sửa hàng hóa
GO
CREATE PROC sp_SuaHangHoa(@MaHH varchar(10),@TenHH nvarchar(50), @DVTinh varchar(10), @Gia int, @MaDM varchar(10), @BaoHanh bit, @MaKM varchar(10))
AS
	BEGIN
		UPDATE HangHoa 
		SET TenHH = @TenHH, DVTinh = @DVTinh, Gia = @Gia, MaDM = @MaDM, BaoHanh = @BaoHanh, MaKM = @MaKM
		WHERE MaHH = @MaHH
	END

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
CREATE PROC sp_TimHangHoa(@MaHH varchar(10))
AS
	BEGIN
		SELECT *
		FROM HangHoa
		WHERE MaHH = @MaHH
	END
--Lấy ds hàng hóa theo dmhh
CREATE PROC sp_LayDSHangHoaTheoDM(@MaDM varchar(10))
AS
	BEGIN
		SELECT *
		FROM HangHoa
		WHERE MaDM = @MaDM
	END
exec sp_LayDSHangHoaTheoDM 'DM03'


---------------------------- ĐƠN VỊ TÍNH ----------------------------
--Lấy dánh sách đơn vị tính
GO
CREATE PROC sp_LayDonViTinh
AS
	BEGIN
		SELECT * FROM DonViTinh
	END

-- Thêm Đơn vị tính
GO
CREATE PROC sp_ThemDonViTinh(@MaDVT varchar(10), @TenDVT nvarchar(50))
AS
	BEGIN	 
	INSERT INTO DonViTinh(MaDVT, TenDVT)
	VALUES(@MaDVT, @TenDVT)
	END

--Sửa đơn vị tính
GO
CREATE PROC sp_SuaDonViTinh(@MaDVT varchar(10), @TenDVT nvarchar(50))
AS
	BEGIN
		UPDATE DonViTinh
		SET TenDVT = @TenDVT
		WHERE MaDVT = @MaDVT
	END

--Xóa đơn vị tính 
GO
CREATE PROC sp_XoaDonViTinh(@MaDVT varchar(10))
AS
	BEGIN
		DELETE
		FROM DonViTinh
		WHERE MaDVT = @MaDVT
	END


---------------------------- DANH MỤC HÀNG HÓA ----------------------------
--Lấy ds Danh mục hàng hóa
GO
CREATE PROC sp_LayDanhMucHH
AS
	BEGIN
		SELECT * FROM DanhMucHH
	END

--Thêm danh mục hàng hoá
GO
CREATE PROC sp_ThemDanhMucHH(@MaDM varchar(10), @TenDM nvarchar(50))
AS
	BEGIN 
		INSERT INTO DanhMucHH(MaDM, TenDM)
		VALUES(@MaDM, @TenDM)
	END

--Sửa danh mục hàng hóa
GO
CREATE PROC sp_SuaDanhMucHH(@MaDM varchar(10), @TenDM nvarchar(50))
AS
	BEGIN 
		UPDATE DanhMucHH
		SET  TenDM = @TenDM
		WHERE MaDM = @MaDM
	END

--Xóa danh mục hàng hóa
GO
CREATE PROC sp_XoaDanhMucHH(@MaDM varchar(10))
AS
	BEGIN 
		DELETE
		FROM DanhMucHH
		WHERE MaDM = @MaDM
	END


---------------------------- KHUYẾN MÃI ----------------------------
drop proc sp_LayKhuyenMai
--lấy danh sách Khuyến mãi
GO
CREATE PROC sp_LayKhuyenMai
AS
	BEGIN 
		SELECT * FROM KhuyenMai
	END

--Thêm khuyến mãi
GO
CREATE PROC sp_ThemKhuyenMai(@MaKM varchar(10), @TenKM nvarchar(50), @LoaiKM varchar(10), @NgayBatDauKM  smalldatetime, @NgayKetThucKM smalldatetime)
AS
	BEGIN 
		INSERT INTO KhuyenMai(MaKM, TenKM, LoaiKM, GiaTriKM, NgayBatDauKM, NgayKetThucKM)
		VALUES(@MaKM, @TenKM, @LoaiKM, @NgayBatDauKM, @NgayKetThucKM)
	END

	INSERT INTO KhuyenMai(MaKM, TenKM, LoaiKM, GiaTriKM, NgayBatDauKM, NgayKetThucKM)
		VALUES('KM01',	N'KM Ngày Lễ',	'LKM01', 2 ,	'2021-04-12',	'2021-10-29')
-- Sửa khuyến mãi
GO 
CREATE PROC sp_SuaKhuyenMai(@MaKM varchar(10), @TenKM nvarchar(50), @LoaiKM varchar(10), @NgayBatDauKM  smalldatetime, @NgayKetThucKM smalldatetime)
AS
	BEGIN 
		UPDATE KhuyenMai 
		SET TenKM = @TenKM, LoaiKM = @LoaiKM, NgayBatDauKM = @NgayBatDauKM, NgayKetThucKM = @NgayKetThucKM
		WHERE MaKM = @MaKM
	END

--Xóa khuyến mãi
GO 
CREATE PROC sp_XoaKhuyenMai(@MaKM varchar(10))
AS
	BEGIN 
		DELETE 
		FROM KhuyenMai 
		WHERE MaKM = @MaKM
	END




---------------------------- LOẠI HÌNH KHUYẾN MÃI ----------------------------
--Lấy dánh sách loại hình khuyến mãi 
GO
CREATE PROC sp_LayLoaiHinhKM
AS
	BEGIN
		SELECT * FROM LoaiHinhKM
	END

--Thêm loại hình khuyến mãi
GO 
CREATE PROC sp_ThemLoaiHinhKM(@MaLoaiKM varchar(10), @MoTaKM nvarchar(100), @GiaTriKM decimal(2,2))
AS
	BEGIN
		INSERT INTO LoaiHinhKM(MaLoaiKM, MoTaKM, GiaTriKM)
		VALUES(@MaLoaiKM, @MoTaKM, @GiaTriKM)
	END

--Sửa Loại hình km
GO 
CREATE PROC sp_SuaLoaiHinhKM(@MaLoaiKM varchar(10), @MoTaKM nvarchar(100), @GiaTriKM decimal(2,2))
AS
	BEGIN
		UPDATE LoaiHinhKM 
		SET  MoTaKM = @MaLoaiKM, GiaTriKM= @GiaTriKM
		where MaLoaiKM = @MaLoaiKM
	END

--Xóa loại hình khuyến mãi
GO 
CREATE PROC sp_XoaLoaiHinhKM(@MaLoaiKM varchar(10))
AS
	BEGIN
		DELETE 
		FROM LoaiHinhKM 
		where MaLoaiKM = @MaLoaiKM
	END



---------------------------- THẺ KHÁCH HÀNG ----------------------------
--Lấy danh sách Thẻ khách hàng
Go
CREATE PROC sp_LayTheKhachHang
AS
	BEGIN
		SELECT * FROM TheKhachHang
	END
	
--Thêm thẻ khách hàng
GO
CREATE PROC sp_ThemTheKhachHang(@MaTheKH varchar(16), @LoaiThe varchar(10), @TinhTrang bit)
AS
	BEGIN
		INSERT INTO TheKhachHang(MaTheKH, LoaiThe, TinhTrang)
		VALUES(@MaTheKH, @LoaiThe, @TinhTrang)
	END
	--exec sp_ThemTheKhachHang 'MT01', ''
--Sửa thẻ khách hàng
GO
CREATE PROC sp_SuaTheKhachHang(@MaTheKH varchar(16), @LoaiThe varchar(10), @TinhTrang bit)
AS
	BEGIN
		UPDATE TheKhachHang 
		SET LoaiThe = @LoaiThe, TinhTrang = @TinhTrang
		WHERE MaTheKH = @MaTheKH
	END

--Xóa thẻ khách hàng
GO
CREATE PROC sp_XoaTheKhachHang(@MaTheKH varchar(16))
AS
	BEGIN
		DELETE 
		FROM TheKhachHang
		WHERE MaTheKH =  @MaTheKH
	END
GO
--tìm thẻ kh
GO
CREATE PROC sp_TimTheKhachHang(@MaTheKH varchar(16))
AS
	BEGIN
		SELECT *
		FROM TheKhachHang
		WHERE MaTheKH =  @MaTheKH
	END
GO
---------------------------- LOẠI THẺ KHÁCH HÀNG ----------------------------
--- Lấy LoaiTheKH
CREATE PROC sp_LayLoaiTheKH
AS
	BEGIN
		SELECT * FROM LoaiTheKH
	END
GO
--exec sp_LayLoaiTheKH

---Thêm LoaiTheKH
CREATE PROC sp_ThemLoaiTheKH(@Ma char(10), @Ten nvarchar(10))
AS 
	BEGIN
		INSERT INTO LoaiTheKH(MaLoaiThe,TenLoaiThe)
		VALUES(@Ma,@Ten)
	END
GO
EXEC sp_ThemLoaiTheKH 'LT01', 'Vàng'

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

---------------------------- HÓA ĐƠN ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayHoaDon
AS 
	BEGIN
		SELECT * FROM HoaDon
	END
GO

--Them HoaDon
CREATE PROC sp_ThemHoaDon(@MaHD varchar(20) ,@MaTheKH varchar(16),@MaNV varchar(10),@Thoigian smalldatetime)
AS 
	BEGIN
		INSERT INTO HoaDon(MaHD,MaTheKH,MaNV,ThoiGianTT)
		VALUES(@MaHD,@MaTheKH,@MaNV,@Thoigian)
	END
GO

---Sua HoaDon
CREATE PROC sp_SuaHoaDon(@MaHD varchar(20) ,@MaTheKH varchar(16),@MaNV varchar(10),@Thoigian smalldatetime)
AS 
	BEGIN
		UPDATE HoaDon
		SET MaTheKH=@MaTheKH , MaNV=@MaNV , ThoiGianTT=@Thoigian
		WHERE MaHD=@MaHD
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


---------------------------- CHI TIẾT HÓA ĐƠN ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayChiTietHoaDon
AS 
	BEGIN
		SELECT * FROM ChiTietHoaDon
	END
GO

---Them ChiTietHoaDon
CREATE PROC sp_ThemChiTietHoaDon(@MaHD varchar(20) ,@MaHH varchar(16),@SL int,@Gia int,@Thanhtien int)
AS 
	BEGIN
		INSERT INTO ChiTietHoaDon(MaHD,MaHH,SL,Gia,ThanhTien)
		VALUES(@MaHD,@MaHH,@SL,@Gia,@Thanhtien)
	END
GO

---Sua ChiTietHoaDon
CREATE PROC sp_SuaChiTietHoaDon(@MaHD varchar(20) ,@MaHH varchar(16),@SL int,@Gia int,@Thanhtien int)
AS
	BEGIN
		UPDATE ChiTietHoaDon
		SET SL=@SL , Gia=@Gia,ThanhTien=@Thanhtien
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO

---Xoa ChiTietHoaDon
CREATE PROC sp_XoaChiTietHoaDon(@MaHD varchar(20) ,@MaHH varchar(16))
AS
	BEGIN
		DELETE FROM ChiTietHoaDon
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO

---------------------------- KHO ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayKho
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
CREATE PROC sp_XoaKho(@MaKho varchar(20))
AS
	BEGIN 
		delete from Kho
		WHERE MaKho=@MaKho
	END
GO


---------------------------- TỒN KHO ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayTonKho
AS 
	BEGIN
		SELECT * FROM TonKho
	END
GO

---Them tonKho
CREATE PROC sp_ThemTonKho(@MaHH varchar(10),@MaKho varchar(10),@SL int)
AS 
	 BEGIN
		 INSERT INTO TonKho(MaHH,MaKho,SL)
		 VALUES(@MaHH,@MaKho,@SL)
	 END
GO

 ---Sua TonKho
 CREATE PROC sp_SuaTonKho(@MaHH varchar(10),@MaKho varchar(10),@SL int)
 AS 
	 BEGIN
		 UPDATE TonKho
		 SET SL=@SL
		 WHERE MaHH=@MaHH and  MaKho=@MaKho
	 END
GO

 --- Xoa tonKho
 CREATE PROC sp_XoaTonKho(@maHH varchar(10))
 AS
	 BEGIN
		 DELETE FROM TonKho
		 WHERE MaHH=@maHH
	 END
 GO


---------------------------- NHÀ CUNG CẤP ----------------------------
--Lấy HoaDon
CREATE PROC sp_LayNhaCungCap
AS 
	BEGIN
		SELECT * FROM NhaCungCap
	END
GO

 --Them NhaCungCap
 CREATE PROC sp_ThemNhaCungCap(@Ma varchar(10),@Ten varchar(50),@DiaChi nvarchar(100),@SDT varchar(11),@Email varchar(50))
 AS
	 BEGIN 
		 INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi	,SDT,Email)
		 VALUES(@Ma,@Ten,@DiaChi,@SDT,@Email)
	 END
GO

 ---Sua NhaCungCap
 CREATE PROC sp_SuaNhaCungCap(@Ma varchar(10),@Ten varchar(50),@DiaChi nvarchar(100),@SDT varchar(11),@Email varchar(50))
 AS
	 BEGIN
		 UPDATE NhaCungCap
		 SET TenNCC=@Ten,DiaChi=@DiaChi,SDT=@SDT,Email=@Email
		 WHERE MaNCC=@Ma
	 END
GO

 ---Xoa NhaCungCap
 CREATE PROC sp_XoaNhaCungCap(@Ma varchar(10))
 AS
	 BEGIN
		 DELETE FROM NhaCungCap
		 WHERE MaNCC=@Ma
	 END
GO
 
 ---------------------------- HÓA ĐƠN NHẬP HÀNG ----------------------------
 --Lay HoaDonNhapHang
CREATE PROC sp_LayHoaDonNhapHang
AS
	BEGIN
		SELECT* FROM HoaDonNhapHang
	END
GO

 ---Them HoaDonNhapHang
 CREATE PROC sp_ThemHoaDonNhapHang(@MaHD varchar(10),@MaNCC varchar(10),@MaNV varchar(10),@MaKho varchar(10),@Thoigian smalldatetime)
 AS
	 BEGIN
		 INSERT INTO HoaDonNhapHang(MaHD,MaNCC,MaNV,MaKho,ThoiGian)
		 VALUES(@MaHD,@MaNCC,@MaNV,@MaKho,@Thoigian)
	 END
GO

 ---Sua HoaDonNhapHang
 CREATE PROC sp_SuaHoaDonNhapHang(@MaHD varchar(10),@MaNCC varchar(10),@MaNV varchar(10),@MaKho varchar(10),@Thoigian smalldatetime)
 AS
	 BEGIN
		 UPDATE HoaDonNhapHang
		 SET MaNCC=@MaNCC,MaNV=@MaNV,MaKho=@MaKho,ThoiGian=@Thoigian
		 WHERE MaHD=@MaHD
	 END	
 GO

 ---Xoa HoaDonNhapHang
 CREATE PROC sp_XoaHoaDonNhapHang(@MaHD varchar(10))
 AS
	 BEGIN
		 DELETE FROM HoaDonNhapHang
		 WHERE MaHD=@MaHD
	 END
GO


---------------------------- CHI TIẾT NHẬP HÀNG ----------------------------
--Lay ChiTietNhapHang
CREATE PROC sp_LayChiTietNhapHang
AS
	BEGIN
		SELECT* FROM ChiTietNhapHang
	END
GO

 -- Them ChiTietNhapHang
CREATE PROC sp_NhapChiTietNhapHang(@MaHD varchar(10),@MaHH varchar(10),@SL int,@Gia int,@ThanhTien int)
AS
	BEGIN
		INSERT INTO ChiTietNhapHang(MaHD,MaHH,SL,Gia,ThanhTien)
		VALUES(@MaHD,@MaHH,@SL,@Gia,@ThanhTien)
	END
GO

---Sua ChiTietNhapHang
CREATE PROC sp_SuaChiTietNhapHang(@MaHD varchar(10),@MaHH varchar(10),@SL int,@Gia int,@ThanhTien int)
AS
	BEGIN
		UPDATE ChiTietNhapHang
		SET SL=@SL,Gia=@Gia,ThanhTien=@ThanhTien
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO

---Xoa ChiTietNhapHang
CREATE PROC sp_XoaChiTietNhapHang(@MaHD varchar(10),@MaHH varchar(10))
AS
	BEGIN
		DELETE FROM ChiTietNhapHang
		WHERE MaHD=@MaHD and MaHH=@MaHH
	END
GO


---------------------------- NHÀ SẢN XUẤT ----------------------------
--Lay NhaSanXuat
CREATE PROC sp_LayNhaSanXuat
AS
	BEGIN
		SELECT* FROM NhaSanXuat
	END
GO

 ---Them NhaSanXuat
  GO
CREATE PROC sp_ThemNhaSanXuat(@MaNSX varchar(10),@TenNSX nvarchar(50),@DiaChi nvarchar(100),@SDT varchar(10),@MaQG varchar(2))
AS
	BEGIN
		INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,SDT,MaQG)
		VALUES(@MaNSX,@TenNSX,@DiaChi,@SDT,@MaQG)
	END
GO

--- Sua NhaSanXuat
CREATE PROC sp_SuaNhaSanXuat(@MaNSX varchar(10),@TenNSX nvarchar(50),@DiaChi nvarchar(100),@SDT varchar(10),@MaQG varchar(2))
AS
	BEGIN
		UPDATE NhaSanXuat
		SET TenNSX=@TenNSX,DiaChi=@DiaChi,SDT=@SDT,MaQG=@MaQG
		WHERE MaNSX=@MaNSX
	END
GO

---Xoa NhaSanXuat
CREATE PROC sp_XoaNhaSanXuat(@MaNSX varchar(10))
AS
	BEGIN
		DELETE FROM NhaSanXuat
		WHERE MaNSX=@MaNSX
	END


---------------------------- PHIẾU BẢO HÀNH ----------------------------
--Lay PhieuBaoHanh
 GO
CREATE PROC sp_LayPhieuBaoHanh
AS
	BEGIN
		SELECT* FROM PhieuBaoHanh
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

exec sp_ThemPhieuBaoHanh 'BH01','HH01','KH01','2021-11-02','2022-11-07'
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
		WHERE MaPhieuBH = @MaPhieuBH
	END
GO
--tìm 
CREATE PROC sp_TimPhieuBaoHanh(@MaPhieuBH varchar(10))
AS
	BEGIN
		SELECT * FROM PhieuBaoHanh
		WHERE MaPhieuBH = @MaPhieuBH
	END
GO
drop proc sp_TimPhieuBaoHanh

---------------------------- XUẤT XỨ ----------------------------
--Lay XuatXu
CREATE PROC sp_LayXuatXu
AS
	BEGIN
		SELECT* FROM XuatXu
	END
GO

---Them XuatXu
CREATE PROC sp_ThemXuatXu(@MaQuocGia varchar(2),@TenQuocGia nvarchar(20))
AS
	BEGIN
		INSERT INTO XuatXu(MaQuocGia,TenQuocGia)
		VALUES(@MaQuocGia,@TenQuocGia)
	END
GO

---Sua XuatXu
CREATE PROC sp_SuaXuatXu(@MaQuocGia varchar(2),@TenQuocGia nvarchar(20))
AS 
	BEGIN
		UPDATE XuatXu
		SET TenQuocGia=@TenQuocGia
		WHERE MaQuocGia=@MaQuocGia
	END
GO

---Xoa XuatXu
CREATE PROC sp_XoaXuatXu(@MaQuocGia varchar(2))
AS
	BEGIN 
		DELETE FROM XuatXu
		WHERE MaQuocGia=@MaQuocGia
	END

