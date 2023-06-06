CREATE DATABASE HotelManagement
GO

--USE master;
--GO
--ALTER DATABASE HotelManagement SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--GO
--DROP DATABASE HotelManagement;

USE HotelManagement

GO
CREATE FUNCTION ConvertString ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE TABLE ACCESS(
	IDStaffType int NOT NULL,
	IDJob int NOT NULL,
 CONSTRAINT PK_Access PRIMARY KEY CLUSTERED 
(
	IDStaffType ASC,
	IDJob ASC
)) 
GO

CREATE TABLE Bill(
	ID int IDENTITY(1,1) NOT NULL,
	IDReceiveRoom int NOT NULL,
	StaffSetUp nvarchar(100) NOT NULL,
	DateOfCreate smalldatetime NULL,
	RoomPrice int NOT NULL,
	ServicePrice int NOT NULL,
	TotalPrice int NOT NULL,
	Discount int NOT NULL,
	IDStatusBill int NOT NULL,
	Surcharge int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE BillDetails(
	IDBill int NOT NULL,
	IDService int NOT NULL,
	Count int NOT NULL,
	TotalPrice int NOT NULL,
 CONSTRAINT PK_BillInfo PRIMARY KEY CLUSTERED 
(
	IDService ASC,
	IDBill ASC
))
GO

CREATE TABLE BookRoom(
	ID int IDENTITY(1,1) NOT NULL,
	IDCustomer int NOT NULL,
	IDRoomType int NOT NULL,
	DateBookRoom smalldatetime NOT NULL,
	DateCheckIn date NOT NULL,
	DateCheckOut date NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE Customer(
	ID int IDENTITY(1,1) NOT NULL,
	IDCard nvarchar(100) NOT NULL,
	IDCustomerType int NOT NULL,
	Name nvarchar(100) NOT NULL,
	DateOfBirth date NOT NULL,
	Address nvarchar(200) NOT NULL,
	PhoneNumber int NOT NULL,
	Sex nvarchar(100) NOT NULL,
	Nationality nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE CustomerType(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE JOB(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
	NameForm nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE Parameter(
	Name nvarchar(100) NOT NULL,
	Value float NULL,
	Describe nvarchar(200) NULL,
	DateModify smalldatetime NULL
)
GO

CREATE TABLE ReceiveRoom(
	ID int IDENTITY(1,1) NOT NULL,
	IDBookRoom int NOT NULL,
	IDRoom int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE ReceiveRoomDetails(
	IDReceiveRoom int NOT NULL,
	IDCustomerOther int NOT NULL,
 CONSTRAINT PK_ReceiveRoomDetails PRIMARY KEY CLUSTERED 
(
	IDReceiveRoom ASC,
	IDCustomerOther ASC
))
GO

CREATE TABLE REPORT(
	idRoomType int NOT NULL,
	value int NOT NULL,
	--rate float NOT NULL,
	Month int NOT NULL,
	Year int NOT NULL,
 CONSTRAINT PK_Report PRIMARY KEY CLUSTERED 
(
	idRoomType ASC,
	Month ASC,
	Year ASC
))
GO

CREATE TABLE Room(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
	IDRoomType int NOT NULL,
	IDStatusRoom int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE RoomType(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
	Price int NOT NULL,
	LimitPerson int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE Service(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(200) NOT NULL,
	IDServiceType int NOT NULL,
	Price int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE ServiceType(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE Staff(
	ID int IDENTITY(1,1) NOT NULL,
	UserName nvarchar(100) NOT NULL,
	DisplayName nvarchar(100) NOT NULL,
	PassWord nvarchar(100) NOT NULL,
	IDStaffType int NOT NULL,
	IDCard nvarchar(100) NOT NULL,
	DateOfBirth date NOT NULL,
	Sex nvarchar(100) NOT NULL,
	Address nvarchar(200) NOT NULL,
	PhoneNumber int NOT NULL,
	StartDay date NOT NULL,
PRIMARY KEY CLUSTERED 
(
	UserName ASC
))
GO

CREATE TABLE StaffType(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE StatusBill(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

CREATE TABLE StatusRoom(
	ID int IDENTITY(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	ID ASC
))
GO

