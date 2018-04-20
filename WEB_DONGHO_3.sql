go
CREATE DATABASE WEB_DONGHO
GO
USE WEB_DONGHO
GO
--CREATE TABLE Account
--(
--name VARCHAR(50) PRIMARY KEY,
--password VARCHAR(50)
--)

--GO
--CREATE TABLE Direction
--(
--id CHAR(10) PRIMARY KEY,
--name NVARCHAR(50),
--address NVARCHAR(50),
--phone CHAR(11),
--identification CHAR(11),
--email VARCHAR(20),
--account VARCHAR(50) REFERENCES dbo.Account(name)
--)
--GO
--CREATE TABLE Customer
--(
--id CHAR(10) PRIMARY KEY,
--name NVARCHAR(50),
--address_ship NVARCHAR(50),
--phone CHAR(11),
--identification CHAR(11),
--email VARCHAR(20),
--age CHAR(3),
--sex BIT,
--account VARCHAR(50) REFERENCES dbo.Account(name)

--)
GO
CREATE TABLE Bill
(
id INT IDENTITY PRIMARY KEY,
name NVARCHAR(50),
phone CHAR(12),
email NVARCHAR(50),
date DATETIME,
address NVARCHAR(50)
)
GO
CREATE TABLE Color
(
id CHAR(10) PRIMARY KEY,
name NVARCHAR(10)

)
GO
CREATE TABLE Brand
(
id CHAR(10) PRIMARY KEY,
 name NVARCHAR(20)
)
GO
CREATE TABLE stype
(
	id CHAR(10) primary key,
	name CHAR(20)
)
GO

CREATE TABLE Product
(
id CHAR(10) PRIMARY KEY,
id_brand CHAR(10) REFERENCES dbo.Brand(id),
id_color CHAR(10) REFERENCES dbo.Color(id),
id_stype CHAR(10) REFERENCES dbo.Stype(id),
image VARCHAR(20),
info NVARCHAR(50),
ole_price FLOAT,
new_price FLOAT,
name NVARCHAR(20),
date_make DATETIME
)

GO
CREATE TABLE Sale
(
id CHAR(10) PRIMARY KEY,
id_Products CHAR(10) REFERENCES dbo.Product(id),
info NVARCHAR(20)
)

GO
CREATE TABLE Bill_Details
(
id int PRIMARY KEY IDENTITY,
id_Product CHAR(10) REFERENCES dbo.Product(id),
id_bill INT  REFERENCES dbo.Bill(id),
total_price FLOAT,
quantity int

)
--Thêm dữ liệu bảng Stype--
GO
INSERT dbo.Stype VALUES ( '001','MEN' )
INSERT dbo.Stype VALUES ( '002','WOMEN' )
INSERT dbo.Stype VALUES ( '003','KIDS' )
INSERT dbo.Stype VALUES ( '004','PAIR' )

--THêm dữ liệu bảng Thương hiệu--
GO
INSERT dbo.Brand VALUES  ( 'NG001',N'CASINO')
INSERT dbo.Brand VALUES  ( 'NG002',N'CITIZEN')
INSERT dbo.Brand VALUES  ( 'NG003',N'OP')
INSERT dbo.Brand VALUES  ( 'NG004',N'DOXA')
INSERT dbo.Brand VALUES  ( 'NG005',N'TISSOT')

--thêm dữ liệu bảng Color--
GO
INSERT dbo.Color VALUES  ( 'STT001',N'RED')
INSERT dbo.Color VALUES  ( 'STT002',N'BLACK')
INSERT dbo.Color VALUES  ( 'STT003',N'BLUE')
INSERT dbo.Color VALUES  ( 'STT004',N'YELLOW')
  
--Dữ liệu bảng Images



--Dữ liệu bảng hóa đơn--


--Dữ liệu bảng sản phẩm--
GO
INSERT dbo.Product VALUES  ( 'SP001' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , 99.0 , N'MOVADO' ,N'10/22/1999')
INSERT dbo.Product VALUES  ( 'SP002' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , 99.0 , N'GSHOCK' ,N'05/02/2000')
INSERT dbo.Product VALUES  ( 'SP003' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0 , 250.0 , N'ORIEN' ,N'06/24/2001')
INSERT dbo.Product VALUES  ( 'SP004' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , 120.0 , N'QUEEN' ,N'09/11/1997')
INSERT dbo.Product VALUES  ( 'SP005' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0 , 150.0 , N'XIAO' ,N'3/25/2018')
INSERT dbo.Product VALUES  ( 'SP006' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , 99.0 , N'MOVADO' ,N'10/22/1999')
INSERT dbo.Product VALUES  ( 'SP007' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , 99.0 , N'GSHOCK' ,N'05/02/2000')
INSERT dbo.Product VALUES  ( 'SP008' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0 , 250.0 , N'ORIEN' ,N'06/24/2001')
INSERT dbo.Product VALUES  ( 'SP009' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , 120.0 , N'QUEEN' ,N'09/11/1997')
INSERT dbo.Product VALUES  ( 'SP010' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0 , 150.0 , N'XIAO' ,N'3/25/2018')
INSERT dbo.Product VALUES  ( 'SP011' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , 99.0 , N'MOVADO' ,N'10/22/1999')
INSERT dbo.Product VALUES  ( 'SP012' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , 99.0 , N'GSHOCK' ,N'05/02/2000')
INSERT dbo.Product VALUES  ( 'SP013' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0 , 250.0 , N'ORIEN' ,N'06/24/2001')
INSERT dbo.Product VALUES  ( 'SP014' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , 120.0 , N'QUEEN' ,N'09/11/1997')
INSERT dbo.Product VALUES  ( 'SP015' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0 , 150.0 , N'XIAO' ,N'3/25/2018')
INSERT dbo.Product VALUES  ( 'SP016' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , 99.0 , N'MOVADO' ,N'10/22/1999')
INSERT dbo.Product VALUES  ( 'SP017' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , 99.0 , N'GSHOCK' ,N'05/02/2000')
INSERT dbo.Product VALUES  ( 'SP018' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0 , 250.0 , N'ORIEN' ,N'06/24/2001')
INSERT dbo.Product VALUES  ( 'SP019' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , 120.0 , N'QUEEN' ,N'09/11/1997')
INSERT dbo.Product VALUES  ( 'SP020' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0 , 150.0 , N'XIAO' ,N'3/25/2018')
INSERT dbo.Product VALUES  ( 'SP021' ,'NG001' ,'STT002' ,'001' ,'p-1.png' , N'Nhập Châu Âu' , 100.0 , 99.0 , N'MOVADO' ,N'10/22/1999')
INSERT dbo.Product VALUES  ( 'SP022' ,'NG003' ,'STT001' ,'003' ,'p-2.png' , N'Nhập từ Ấn Độ' , 200.0 , 99.0 , N'GSHOCK' ,N'05/02/2000')
INSERT dbo.Product VALUES  ( 'SP023' ,'NG001' ,'STT003' ,'003' ,'p-3.png' , N'Nhập từ Thụy Sĩ' , 300.0 , 250.0 , N'ORIEN' ,N'06/24/2001')
INSERT dbo.Product VALUES  ( 'SP024' ,'NG002' ,'STT001' ,'001' ,'p-4.png' , N'Trong nước' , 150.0 , 120.0 , N'QUEEN' ,N'09/11/1997')
INSERT dbo.Product VALUES  ( 'SP025' ,'NG003' ,'STT004' ,'004' ,'p-5.png' , N'Trung Quốc' , 170.0 , 150.0 , N'XIAO' ,N'3/25/2018')
					
--Dữ liệu bảng chi tiết hóa đơn--

--Dữ liệu bảng giảm giá--
GO
INSERT dbo.Sale VALUES  ( 'GG001','SP001',N'10%')
INSERT dbo.Sale VALUES  ( 'GG002','SP002',N'20%')
INSERT dbo.Sale VALUES  ( 'GG003','SP003',N'30%')
INSERT dbo.Sale VALUES  ( 'GG004','SP004',N'20%')
INSERT dbo.Sale VALUES  ( 'GG005','SP005',N'15%')
--Dữ liệu bảng admin



--GO
--INSERT dbo.Direction VALUES  ( 'QL001' , N'BÙI KHẮC TUẤN' ,N'NGHỆ AN' ,'0123456789' ,'12354656754' ,'TUAN@GMAIL.COM' ,'QL001')
--INSERT dbo.Direction VALUES  ( 'QL002' , N'LÊ THỊ HUYỀN' ,N'NGHỆ AN' ,'0123423789' ,'15324656754' ,'HUYEN@GMAIL.COM' ,'QL002')
--INSERT dbo.Direction VALUES  ( 'QL003' , N'BÙI ĐĂNG CƯỜNG' ,N'BẮC GIANG' ,'0167456789' ,'89854656754' ,'CUONG@GMAIL.COM' ,'QL003')
--INSERT dbo.Direction VALUES  ( 'QL004' , N'VŨ NGỌC HÀ' ,N'HÀ NAM' ,'0187456789' ,'87654656754' ,'HA@GMAIL.COM' ,'QL004')
--INSERT dbo.Direction VALUES  ( 'QL005' , N'ĐẶNG VĂN HÙNG' ,N'THÁI BÌNH' ,'0123123789' ,'12354321344' ,'HUNG@GMAIL.COM' ,'QL005')

--GO
--INSERT dbo.Account VALUES  ( 'KH001', 'QWE1243252' )
--INSERT dbo.Account VALUES  ( 'KH002', 'MJYHGGGGJ6' )
--INSERT dbo.Account VALUES  ( 'KH003', 'MJYSDGGGGJ6' )
--INSERT dbo.Account VALUES  ( 'KH004', 'SDGJYHGGGGJ6' )
--INSERT dbo.Account VALUES  ( 'KH005', 'MJ23HGGGGJ6' )
--INSERT dbo.Account VALUES  ( 'QL001', '5656HGFNG' )
--INSERT dbo.Account VALUES  ( 'QL002', 'CXGR4666666R' )
--INSERT dbo.Account VALUES  ( 'QL003', '2432++==' )
--INSERT dbo.Account VALUES  ( 'QL004', '243A2++==' )
--INSERT dbo.Account VALUES  ( 'QL005', '243D2++==' )
---- Dữ liệu bảng khách hàng
--GO

--INSERT dbo.Customer VALUES  ( 'KH001' , N'BÙI KHẮC TUẤN' ,N'NGHỆ AN' ,'0123456789' ,'12354656754' ,'TUAN@GMAIL.COM' ,'20' ,1 ,'KH001')
--INSERT dbo.Customer VALUES  ( 'KH002' , N'LÊ THỊ HUYỀN' ,N'NGHỆ AN' ,'0123423789' ,'15324656754' ,'HUYEN@GMAIL.COM' ,'20' ,0 ,'KH002')
--INSERT dbo.Customer VALUES  ( 'KH003' , N'BÙI ĐĂNG CƯỜNG' ,N'BẮC GIANG' ,'0167456789' ,'89854656754' ,'CUONG@GMAIL.COM' ,'20' ,1 ,'KH003')
--INSERT dbo.Customer VALUES  ( 'KH004' , N'VŨ NGỌC HÀ' ,N'HÀ NAM' ,'0187456789' ,'87654656754' ,'HA@GMAIL.COM' ,'20' ,0 ,'KH004')
--INSERT dbo.Customer VALUES  ( 'KH005' , N'ĐẶNG VĂN HÙNG' ,N'THÁI BÌNH' ,'0123123789' ,'12354321344' ,'HUNG@GMAIL.COM' ,'20' ,1 ,'KH005')


GO
 --DROP TABLE dbo.Direction
 --DROP TABLE dbo.Customer
 --DROP TABLE dbo.Account
 --GO
 --DROP TABLE users
 --DROP TABLE Roles
 --DROP TABLE Credit
 --DROP TABLE GroupUser
 CREATE TABLE GroupUser
 (
	Id VARCHAR(10) PRIMARY KEY,
	name VARCHAR(10)
 )
 CREATE TABLE UserLogin
(
account VARCHAR(50) PRIMARY KEY,
groupId VARCHAR(10) REFERENCES dbo.GroupUser(Id),
password VARCHAR(50),
name NVARCHAR(50),
address_ship NVARCHAR(50),
phone CHAR(11),
identification CHAR(11),
email VARCHAR(20),
age CHAR(3),
sex nchar(3)
)

CREATE TABLE Roles
(
	Id VARCHAR(10) PRIMARY KEY,
	name VARCHAR(10)
)

CREATE TABLE Credit
(
	id INT IDENTITY PRIMARY KEY,
	Id_Role VARCHAR(10) REFERENCES dbo.Roles(Id),
	Id_group VARCHAR(10) REFERENCES dbo.GroupUser(Id)
	
)

--DELETE dbo.Users
--DELETE dbo.Roles 
--DELETE dbo.GroupUser
--DELETE dbo.Credit
INSERT dbo.GroupUser VALUES  ( 'ADMIN',  'ADMIN'  )
INSERT dbo.GroupUser VALUES  ( 'MOD',  'MOD'  )
INSERT dbo.GroupUser VALUES  ( 'MEMBER',  'MEMBER'  )
INSERT dbo.GroupUser VALUES  ( 'MEMBER2',  'MEMBER'  )

GO
INSERT dbo.UserLogin VALUES  ( 'admin' , 'ADMIN' ,'admin' ,N'BÙI KHẮC TUẤN' ,  N'NGHỆ AN' , '0123456789' , '12354656754' ,  'TUAN@GMAIL.COM' , '20' ,  N'Nam'   )
INSERT dbo.UserLogin VALUES  ( 'mod' , 'MOD' ,'mod' ,N'BÙI KHẮC TUẤN' ,  N'NGHỆ AN' , '0123456789' , '12354656754' ,  'TUAN@GMAIL.COM' , '20' ,  N'Nam'   )
INSERT dbo.UserLogin VALUES  ( 'member' , 'MEMBER' ,'member' ,N'BÙI KHẮC TUẤN' ,  N'NGHỆ AN' , '0123456789' , '12354656754' ,  'TUAN@GMAIL.COM' , '20' ,  N'Nam'   )

GO
INSERT dbo.Roles VALUES  ( 'VIEW', 'VIEW' )
INSERT dbo.Roles VALUES  ( 'ADD', 'ADD' )
INSERT dbo.Roles VALUES  ( 'EDIT', 'EDIT' )
INSERT dbo.Roles VALUES  ( 'DEL', 'DEL' )

INSERT dbo.Credit VALUES  ( 'VIEW',  'ADMIN'   )
INSERT dbo.Credit VALUES  ( 'ADD',  'ADMIN'   )
INSERT dbo.Credit VALUES  ( 'EDIT',  'ADMIN'   )
INSERT dbo.Credit VALUES  ( 'DEL',  'ADMIN'   )
INSERT dbo.Credit VALUES  ( 'VIEW',  'MOD'   )
INSERT dbo.Credit VALUES  ( 'ADD',  'MOD'   )

