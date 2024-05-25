CREATE DATABASE lab04_DTB
GO

USE lab04_DTB
GO

CREATE TABLE PHONGBAN
(
	MaPhongBan int NOT NULL PRIMARY KEY,
	TenPhongBan nvarchar(50),
	SoDT char(10),
	DiaDiem nvarchar(50)
)
GO

CREATE TABLE NHANVIEN
(
	MaNhanVien int NOT NULL PRIMARY KEY,
	HoTen nvarchar(50),
	DiaChi nvarchar(50),
	SoDienThoai char(10),
	MaPhongBan int,
	FOREIGN KEY (MaPhongBan) REFERENCES PHONGBAN(MaPhongBan) ON DELETE CASCADE
)
GO

INSERT INTO NHANVIEN (MaNhanVien, HoTen, DiaChi, SoDienThoai, MaPhongBan)
VALUES
(1, N'Nguyễn Văn A', N'123 Đường 1, Quận 1', '0123456789', 1),
(2, N'Trần Thị B', N'456 Đường 2, Quận 2', '0234567891', 1),
(3, N'Phạm Văn C', N'789 Đường 3, Quận 3', '0345678912', 2),
(4, N'Lê Thị D', N'321 Đường 4, Quận 4', '0456789123', 3);
GO

INSERT INTO PHONGBAN (MaPhongBan, TenPhongBan, SoDT, DiaDiem)
VALUES 
(1, N'Phòng Kế Toán', '0123456789', N'Hồ Chí Minh'),
(2, N'Phòng Nhân Sự', '0987654321', N'Hà Nội'),
(3, N'Phòng Kỹ Thuật', '1234567890', N'Đà Nẵng'),
(4, N'Phòng Kinh Doanh', '9876543210', N'Cần Thơ');
GO