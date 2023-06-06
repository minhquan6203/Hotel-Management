
USE HotelManagement 

GO
create proc [dbo].[GetIDReceiveRoomCurrent]
as
begin
	select MAX(id)
	from ReceiveRoom
end

GO
CREATE proc [dbo].[InsertReceiveRoom]
@idBookRoom int,@idRoom int
as
begin
	insert into ReceiveRoom(IDBookRoom,IDRoom)
	values(@idBookRoom,@idRoom)
	update Room
	set IDStatusRoom=2
	where ID=@idRoom
end

GO
create proc [dbo].[InsertReceiveRoomDetails]
@idReceiveRoom int,@idCustomer int
as
begin
	insert into ReceiveRoomDetails(IDReceiveRoom,IDCustomerOther)
	values(@idReceiveRoom,@idCustomer)
end

GO
create proc [dbo].[ShowBookRoomInfo]
@idBookRoom int
as
begin
	select B.Name[FullName],B.IDCard[IDCard],C.Name[RoomTypeName],A.DateCheckIn[DateCheckIn],A.DateCheckOut[DateCheckOut],C.LimitPerson[LimitPerson],C.Price[Price]
	from BookRoom A,Customer B,RoomType C
	where A.ID=@idBookRoom and A.IDCustomer=B.ID and A.IDRoomType=C.ID
end

GO
CREATE PROC [dbo].[USP_ChekcAccess] 
@username NVARCHAR(100), @formname NVARCHAR(100)
AS
BEGIN
	SELECT UserName FROM dbo.Staff INNER JOIN dbo.StaffType ON StaffType.ID = Staff.IDStaffType 
	INNER JOIN access ON access.Idstafftype = stafftype.ID INNER JOIN job ON job.id = access.idjob
	WHERE UserName = @username AND @formname LIKE NameForm
END
GO

GO
CREATE PROC [dbo].[USP_DeleteAccess]
@idJob INT, @idStaffType int
AS
BEGIN
	DELETE access WHERE @idJob = idjob AND @idStaffType = idStaffType
END

GO
create proc [dbo].[USP_DeleteBookRoom]
@id int
as
begin
	delete from BookRoom
	where ID=@id
end

GO
create proc [dbo].[USP_DeleteReceiveRoomDetails]
@idReceiveRoom int,@idCustomer int
as
begin
	delete from ReceiveRoomDetails
	where IDCustomerOther=@idCustomer and IDReceiveRoom=@idReceiveRoom
end

GO
CREATE PROC [dbo].[USP_DeleteStaffType]
@id int
AS
begin
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM staff WHERE @id = staff.IDStaffType
	IF(@count = 0)
	begin
		delete access where idstafftype = @id
		DELETE staffType WHERE @id = id
	end
END

GO
CREATE proc [dbo].[USP_GetCustomerTypeNameByIdCard]
@idCard nvarchar(100)
as
begin
	select B.Name
	from Customer A, CustomerType B
	where A.IDCustomerType=B.ID and A.IDCard=@idCard
end

GO
CREATE proc [dbo].[USP_GetIdBillFromIdRoom]
@idRoom int
as
begin
	select B.*
	from ReceiveRoom A,Bill B
	where A.ID=B.IDReceiveRoom and B.IDStatusBill=1 and A.IDRoom=@idRoom
end

GO
create proc [dbo].[USP_GetIdBillMax]
as
select MAX(id)
from Bill

GO
create proc [dbo].[USP_GetIDCustomerFromBookRoom]
@idReceiveRoom int
as
begin
	select B.IDCustomer
	from ReceiveRoom A,BookRoom B
	where A.ID=@idReceiveRoom and A.IDBookRoom=B.ID
end

GO
CREATE proc [dbo].[USP_GetIdReceiRoomFromIdRoom]--IdRoom đưa vào có trạng thái "Có người"
@idRoom int
as
begin
select *
from ReceiveRoom
where IDRoom=@idRoom
order by ID desc
end

GO
create proc [dbo].[USP_GetIDRoomFromReceiveRoom]
@idReceiveRoom int
as
begin
	select IDRoom
	from ReceiveRoom
	where ID=@idReceiveRoom
end

GO
create proc [dbo].[USP_GetMaxPersonByRoomType]
@idRoomType int
as
begin
	if(@idRoomType=1)
	select *
	from Parameter
	where Name=N'QĐ1'

	if(@idRoomType=2)
	select *
	from Parameter
	where Name=N'QĐ1'

	if(@idRoomType=3)
	select *
	from Parameter
	where Name=N'QĐ1'
end

GO
create proc [dbo].[USP_GetNameStaffTypeByUserName]
@username nvarchar(100)
as
begin
	select B.*
	from Staff A, StaffType B
	where a.IDStaffType=B.ID and A.UserName=@username
end

GO
create proc [dbo].[USP_GetPeoples]
@idBill int
as
begin
	select COUNT(B.IDReceiveRoom)
	from ReceiveRoom A,ReceiveRoomDetails B,Bill C
	where A.ID=C.IDReceiveRoom and A.ID=B.IDReceiveRoom and C.ID=@idBill
end

GO
create proc [dbo].[USP_GetRoomTypeByIdBookRoom]
@idBookRoom int
as
begin
	select B.*
	from BookRoom A, RoomType B
	where A.ID=@idBookRoom and A.IDRoomType=B.ID
end

GO
create proc [dbo].[USP_GetRoomTypeByIdRoom]
@idRoom int
as
begin
	select B.*
	from Room A,RoomType B
	where A.IDRoomType=B.ID and A.ID=@idRoom
end

GO
create proc [dbo].[USP_GetStaffSetUp]
@idBill int
as
begin
	select B.*
	from Bill A, Staff B
	where A.ID=@idBill and A.StaffSetUp=B.UserName
end

GO
CREATE PROC [dbo].[USP_InsertAccess]
@idJob INT, @idStaffType int
AS
BEGIN
	INSERT INTO access(idjob, idstafftype) VALUES(@idJob, @idStaffType)
END

GO
create proc [dbo].[USP_InsertBill]
@idReceiveRoom int,@staffSetUp nvarchar(100)
as
begin
	insert into Bill(IDReceiveRoom,StaffSetUp)
	values(@idReceiveRoom,@staffSetUp)
end

GO
CREATE proc [dbo].[USP_InsertBillDetails]
@idBill int,@idService int,@count int
as
begin
		declare @totalPrice int,@price int
		select @price=Price
		from Service
		where ID=@idService
		set @totalPrice=@price*@count
		insert into BillDetails(IDBill,IDService,Count,TotalPrice)
		values(@idBill,@idService,@count,@totalPrice)
end

GO
create proc [dbo].[USP_InsertBookRoom]
@idCustomer int,@idRoomType int,@datecheckin date,@datecheckout date,@datebookroom smalldatetime
as
begin
	insert into BookRoom (IDCustomer,IDRoomType,DateCheckIn,DateCheckOut,DateBookRoom)
	values(@idCustomer,@idRoomType,@datecheckin,@datecheckout,@datebookroom)
end

GO
CREATE PROC [dbo].[USP_InsertCustomer]
@customerName NVARCHAR(100), @idCustomerType int, @idCard NVARCHAR(100),
@address NVARCHAR(200), @dateOfBirth date, @phoneNumber int,
@sex NVARCHAR(100), @nationality NVARCHAR(100)
AS
BEGIN
DECLARE @count INT =0
SELECT @count = COUNT(*) FROM customer WHERE IDCard = @idCard
IF(@count=0)
INSERT INTO dbo.Customer(IDCard,IDCustomerType, Name, DateOfBirth, Address, PhoneNumber, Sex, Nationality)
	VALUES(@idCard, @idCustomerType, @customerName, @dateOfBirth, @address, @phoneNumber, @sex, @nationality)
end

GO
create proc [dbo].[USP_InsertCustomer_]
@idCard nvarchar(100),@name nvarchar(100),@idCustomerType int, @dateOfBirth Date,@address nvarchar(200),@phoneNumber int,@sex nvarchar(100),@nationality nvarchar(100)
as
begin
	insert into Customer(IDCard,Name,IDCustomerType,DateOfBirth,Address,PhoneNumber,Sex,Nationality)
	values(@idCard,@name,@idCustomerType,@dateOfBirth,@address,@phoneNumber,@sex,@nationality)
end

GO
CREATE Proc [dbo].[USP_InsertReport]
@idBill int
AS
BEGIN
	DECLARE @month INT = 0
	DECLARE @year INT = 0
	DECLARE @id INT = 0
	DECLARE @price INT = 0
	SELECT @id = dbo.ROOM.IDRoomType, @month = MONTH(bill.DateOfCreate), @year = YEAR(bill.DateOfCreate), @price = bill.TotalPrice
	FROM bill INNER JOIN dbo.RECEIVEROOM ON RECEIVEROOM.ID = bill.IDReceiveRoom 
		INNER JOIN dbo.ROOM ON ROOM.ID = RECEIVEROOM.IDRoom
	WHERE bill.ID = @idBill

	DECLARE @count INT = 0	
	SELECT @count = COUNT(*) FROM report WHERE month = @month AND year = @year and idRoomType = @id
	IF(@count=0) -- khong ton tai roomtype
    BEGIN
		
		INSERT INTO report(idRoomType, Month, Year) SELECT roomtype.ID, @month, @year FROM roomtype 
	END
    UPDATE dbo.REPORT SET value = value + @price WHERE Year = @year AND Month = @month AND idRoomType = @id
END

GO
CREATE PROC [dbo].[USP_InsertRoom]
@nameRoom NVARCHAR(100), @idRoomType INT, @idStatusRoom INT
AS
INSERT INTO dbo.Room(Name, IDRoomType, IDStatusRoom)
VALUES(@nameRoom, @idRoomType, @idStatusRoom)

GO
CREATE PROC [dbo].[USP_InsertService]
@name NVARCHAR(200), @idServiceType INT, @price int
AS
BEGIN
	INSERT INTO dbo.Service(Name,IDServiceType,Price)
	VALUES(@name, @idServiceType, @price)
END

GO
CREATE PROC [dbo].[USP_InsertServiceType]
@name NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.ServiceType(name)
	VALUES(@name)
END

GO
CREATE PROC [dbo].[USP_InsertStaff]
@user NVARCHAR(100), @name NVARCHAR(100), @pass NVARCHAR(100),
@idStaffType INT,@idCard NVARCHAR(100), @dateOfBirth DATE, @sex NVARCHAR(100),
@address NVARCHAR(200), @phoneNumber INT, @startDay date
AS
BEGIN
	DECLARE @count INT =0
	SELECT @count = COUNT(*) FROM dbo.Staff WHERE UserName = @user OR IDCard = @idCard
	IF(@count >0) RETURN
	INSERT INTO dbo.Staff(UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay)
	VALUES (@user, @name, @pass, @idStaffType,@idCard, @dateOfBirth, @sex, @address, @phoneNumber, @startDay)
END

GO
CREATE PROC [dbo].[USP_InsertStaffType] 
@name NVARCHAR(100)
AS
BEGIN
    INSERT INTO staffType(Name) VALUES(@name)
END

GO
create Proc [dbo].[USP_IsExistBillDetailsOfRoom]--Kq > 0 :TH3, ngược lại TH2. Tuy nhiên, trước khi kt đk này phải chắc chắn tồn tại Bill
@idRoom int,@idservice int
as
begin
	select *
	from Bill A,BillDetails B,ReceiveRoom C
	where A.IDStatusBill=1 and A.ID=B.IDBill and C.ID=A.IDReceiveRoom and C.IDRoom=@idRoom and B.IDService=@idservice
end

GO
CREATE proc [dbo].[USP_IsExistBillOfRoom]--Trả về count > 0: tức là đã tồn tại Bill
@idRoom int
as
begin
	select *
	from Bill A,ReceiveRoom B
	where A.IDStatusBill=1 and A.IDReceiveRoom=B.ID and B.IDRoom=@idRoom
end

GO
create proc [dbo].[USP_IsIDBookRoomExists]
@idBookRoom int,@dateNow date
as
begin
	select *
	from BookRoom 
	where ID=@idBookRoom and DateCheckIn>=@dateNow and ID not in
	(
		select IDBookRoom
		from ReceiveRoom
	)
end
GO
CREATE proc [dbo].[USP_IsIdCardExists]
@idCard nvarchar(100)
as
begin
select *
from Customer
where IDCard=@idCard
end

GO
create proc [dbo].[USP_IsIdCardExistsAcc]
@idCard nvarchar(100)
as
begin
	select *
	from Staff
	where IDCard=@idCard
end

GO
CREATE proc [dbo].[USP_LoadBookRoomsByDate]
@date Date
as
begin
	select A.ID[Mã đặt phòng], b.Name[Họ và tên],b.IDCard[CMND],C.Name[Loại phòng],A.DateCheckIn[Ngày nhận],A.DateCheckOut[Ngày trả]
	from BookRoom A,Customer B, RoomType C
	where a.IDRoomType=c.ID and A.IDCustomer=B.ID and A.DateBookRoom>=@date
	order by A.DateBookRoom desc
end

GO
CREATE proc [dbo].[USP_LoadEmptyRoom]
@idRoomType int
as
begin
	select *
	from Room
	where IDStatusRoom=1 and IDRoomType=@idRoomType
end

GO
CREATE PROC [dbo].[USP_LoadFullAccessNow]
@idStaffType INT
AS
BEGIN
	SELECT Job.Name, job.ID FROM job INNER JOIN access ON job.Id = Access.IDJob
	WHERE @idStaffType = dbo.Access.IDStaffType
END

GO
create PROC [dbo].[USP_LoadFullAccessRest]
@idStaffType INT
AS
BEGIN
	SELECT j.Name, j.Id FROM job j
	WHERE NOT EXISTS 
	(
		SELECT * FROM job INNER JOIN access ON job.Id = access.IdJob
		WHERE j.Id = job.Id AND access.idStaffType = @idStaffType
	)
END

GO
CREATE PROC [dbo].[USP_LoadFUllBill] 
AS
BEGIN
	SELECT bill.id, room.Name AS [roomName], Customer.Name as [customerName], StaffSetUp, DateOfCreate, STATUSBILL.Name, TotalPrice, (cast(Discount as nvarchar(4)) + '%') [Discount], cast(TotalPrice*( (100-Discount)/100.0) as int) [FinalPrice]
    FROM dbo.BILL INNER JOIN dbo.RECEIVEROOM ON RECEIVEROOM.ID = BILL.IDReceiveRoom
					INNER JOIN dbo.STATUSBILL ON STATUSBILL.id = bill.IDStatusBill
					INNER JOIN dbo.ROOM ON ROOM.ID = RECEIVEROOM.IDRoom
					inner join bookroom on bookroom.id = RECEIVEROOM.IDBookRoom
					inner join Customer on Customer.ID = BookRoom.IDCustomer
	ORDER BY DateOfCreate DESC
END

GO
CREATE PROC [dbo].[USP_LoadFullCustomer]
AS
SELECT CUSTOMER.ID, Customer.Name, IDCard, CustomerType.Name as [NameCustomerType], Sex, DateOfBirth, PhoneNumber, Address, Nationality, IDCustomerType 
FROM dbo.Customer INNER JOIN dbo.CustomerType ON CustomerType.ID = Customer.IDCustomerType

GO
--------------------------------------------------------------
--Customer Type
--------------------------------------------------------------

CREATE PROC [dbo].[USP_LoadFullCustomerType]
AS
SELECT * FROM dbo.CustomerType

GO
CREATE PROC [dbo].[USP_LoadFullParameter]
AS
SELECT * FROM dbo.PARAMETER

GO
CREATE PROC [dbo].[USP_LoadFullReport]
@month INT, @year int
AS
BEGIN
	SELECT name, value FROM dbo.REPORT INNER JOIN dbo.ROOMTYPE ON ROOMTYPE.ID = REPORT.idRoomType
	WHERE Month = @month AND Year = @year
END

GO
CREATE PROC [dbo].[USP_LoadFullRoom]
AS
SELECT Room.ID, Room.Name,RoomType.Name AS [nameRoomType], Price, LimitPerson,
StatusRoom.Name AS [nameStatusRoom], IDRoomType, IDStatusRoom
FROM dbo.Room INNER JOIN dbo.RoomType 
ON roomtype.id = room.IDRoomType
INNER JOIN dbo.StatusRoom ON statusroom.id = room.IDStatusRoom

GO
CREATE PROC [dbo].[USP_LoadFullRoomType]
AS
SELECT * FROM dbo.RoomType
GO
CREATE PROC [dbo].[USP_LoadFullService]
AS
SELECT Service.ID, Service.Name, Price, ServiceType.Name AS [nameServiceType], IDServiceType
FROM dbo.Service INNER JOIN dbo.ServiceType ON ServiceType.ID = Service.IDServiceType

GO
CREATE PROC [dbo].[USP_LoadFullServiceType]
AS
SELECT * FROM ServiceType

GO
CREATE PROC [dbo].[USP_LoadFullStaff]
AS
BEGIN
	SELECT UserName, DisplayName, Name, IDCard,
			DateOfBirth, Sex, PhoneNumber, StartDay, Address, IDStaffType
    FROM dbo.Staff INNER JOIN dbo.StaffType ON StaffType.ID = Staff.IDStaffType
END

GO
------------------------------------------------------------
--Staff type
--------------------------------------------------------------

CREATE PROC [dbo].[USP_LoadFullStaffType]
AS
begin
SELECT * FROM dbo.StaffType
end

GO
--------------------------------------------------------------

--Status Room
--------------------------------------------------------------
CREATE PROC [dbo].[USP_LoadFullStatusRoom]
AS
SELECT * FROM dbo.StatusRoom

GO
CREATE proc [dbo].[USP_LoadListFullRoom]
@getToday Date
as
begin
	select distinct A.*
	from Room A,ReceiveRoom B, BookRoom C
	where A.IDStatusRoom=2 and A.ID=B.IDRoom and B.IDBookRoom=C.ID and C.DateCheckOut>=@getToday
	order by A.ID asc
end

GO
create proc [dbo].[USP_LoadReceiveRoomsByDate]
@date Date
as
begin
	select A.ID[Mã nhận phòng], b.Name[Họ và tên],b.IDCard[CMND],C.Name[Tên phòng],D.DateCheckIn[Ngày nhận],D.DateCheckOut[Ngày trả]
	from ReceiveRoom A,Customer B, Room C,BookRoom D
	where A.IDBookRoom=D.ID and D.IDCustomer=B.ID and A.IDRoom=C.ID and D.DateCheckIn>=@date
	order by A.ID desc
end

GO
create proc [dbo].[USP_LoadServiceByServiceType]
@idServiceType int
as
begin
	select *
	from Service
	where IDServiceType=@idServiceType
end

GO
create proc [dbo].[USP_LoadStaffInforByUserName]
@username nvarchar(100)
as
begin
	select *
	from Staff
	where UserName=@username
end

GO
create proc [dbo].[USP_Login]
@userName nvarchar(100),@passWord nvarchar(100)
as
Select * from Staff where UserName=@userName and PassWord=@passWord

GO
create proc [dbo].[USP_RoomTypeInfo]
@id int
as
begin
select * 
from RoomType
where ID=@id
end

GO
CREATE PROC [dbo].[USP_SearchBill]
@string NVARCHAR(100), @mode int
AS
BEGIN
	SELECT @string = '%' + [dbo].[ConvertString](@string) + '%'
	DECLARE @table TABLE(id int)
	IF(@mode = 0)
		INSERT INTO @table SELECT bill.id FROM bill WHERE CAST(id AS NVARCHAR(100)) LIKE @string
	ELSE IF(@mode = 1)
		INSERT INTO @table SELECT bill.id  FROM bill INNER JOIN dbo.ReceiveRoom ON ReceiveRoom.ID = Bill.IDReceiveRoom
		INNER JOIN dbo.BookRoom ON BookRoom.ID = ReceiveRoom.IDBookRoom INNER JOIN dbo.Customer ON Customer.ID = BookRoom.IDCustomer 
		WHERE [dbo].ConvertString(Customer.Name) LIKE @string
	ELSE IF(@mode = 2)
		INSERT INTO @table SELECT bill.id  FROM bill INNER JOIN dbo.ReceiveRoom ON ReceiveRoom.ID = Bill.IDReceiveRoom
		INNER JOIN dbo.BookRoom ON BookRoom.ID = ReceiveRoom.IDBookRoom INNER JOIN dbo.Customer ON Customer.ID = BookRoom.IDCustomer
		WHERE [dbo].ConvertString(Customer.IDCard) LIKE @string
	ELSE IF(@mode = 3)
		INSERT INTO @table SELECT bill.id  FROM bill INNER JOIN dbo.ReceiveRoom ON ReceiveRoom.ID = Bill.IDReceiveRoom
		INNER JOIN dbo.BookRoom ON BookRoom.ID = ReceiveRoom.IDBookRoom INNER JOIN dbo.Customer ON Customer.ID = BookRoom.IDCustomer
		WHERE CAST(dbo.Customer.PhoneNumber AS NVARCHAR(100)) LIKE @string

	SELECT bill.id, room.Name AS [roomName], Customer.Name as [customerName], bill.StaffSetUp, bill.DateOfCreate, STATUSBILL.Name, bill.TotalPrice, (cast(bill.Discount as nvarchar(4)) + '%') [Discount], cast(bill.TotalPrice*( (100-bill.Discount)/100.0) as int) [FinalPrice]
    FROM dbo.BILL INNER JOIN dbo.RECEIVEROOM ON RECEIVEROOM.ID = BILL.IDReceiveRoom 
	INNER JOIN dbo.STATUSBILL ON STATUSBILL.id = bill.IDStatusBill 
	INNER JOIN dbo.ROOM ON ROOM.ID = RECEIVEROOM.IDRoom
	INNER JOIN @table ON bill.id = [@table].id
	inner join bookroom on bookroom.id = RECEIVEROOM.IDBookRoom
	inner join Customer on Customer.ID = BookRoom.IDCustomer
	ORDER BY DateOfCreate DESC
END

GO
	CREATE PROC [dbo].[USP_SearchCustomer]
	@string NVARCHAR(100), @mode INT
	AS
	BEGIN
		SELECT @string = '%' + [dbo].[ConvertString](@string) + '%'
		DECLARE @table TABLE(id INT)

		IF(@mode = 0)
			INSERT INTO @table SELECT id FROM [dbo].customer WHERE CAST(id AS NVARCHAR(100)) LIKE @string;
		ELSE IF(@mode = 1)
			INSERT INTO @table SELECT id FROM [dbo].customer WHERE [dbo].[ConvertString](name) LIKE @string;
		ELSE IF(@mode = 2)
			INSERT INTO @table SELECT id FROM [dbo].customer WHERE [dbo].[ConvertString](IDCard) LIKE @string;
		ELSE IF(@mode = 3)
			INSERT INTO @table SELECT id FROM [dbo].customer WHERE CAST(PhoneNumber AS NVARCHAR(100)) LIKE @string;

	    SELECT CUSTOMER.ID, Customer.Name, IDCard, CustomerType.Name as [NameCustomerType], Sex, DateOfBirth, PhoneNumber, Address, Nationality, IDCustomerType
		FROM Customer INNER JOIN @table ON [@table].id = CUSTOMER.ID INNER JOIN dbo.CustomerType ON CustomerType.ID = Customer.IDCustomerType
	END


GO
--------------------------------------------------------------
--parameter
--------------------------------------------------------------
CREATE PROC [dbo].[USP_SearchParameter]
@string NVARCHAR(200)
AS
BEGIN
	SELECT @string = '%' + [dbo].[convertstring](@string) + '%'
	SELECT * FROM dbo.PARAMETER
	WHERE [dbo].[convertstring](name) like @string
END

GO
--------------------------------------------------------------

--Room
--------------------------------------------------------------
CREATE PROC [dbo].[USP_SearchRoom]
@string NVARCHAR(100), @int INT
AS
BEGIN
	SELECT @string = '%' + [dbo].[convertString](@string) + '%'
	SELECT Room.ID, Room.Name,RoomType.Name AS [nameRoomType], Price, LimitPerson,
	StatusRoom.Name AS [nameStatusRoom], IDRoomType, IDStatusRoom
	FROM dbo.Room INNER JOIN dbo.RoomType ON roomtype.id = room.IDRoomType INNER JOIN dbo.StatusRoom ON statusroom.id = room.IDStatusRoom
	WHERE dbo.ConvertString(dbo.Room.name) LIKE @string OR dbo.Room.id = @int
END

GO
--------------------------------------------------------------

--Room Type
--------------------------------------------------------------
CREATE PROC [dbo].[USP_SearchRoomType]
@string NVARCHAR(100), @int INT
AS
BEGIN
	SELECT @string = '%' + [dbo].[convertstring](@string) + '%'
	SELECT * FROM dbo.ROOMTYPE
	WHERE [dbo].[convertstring](name) LIKE @string OR id = @int
end

GO
CREATE PROC [dbo].[USP_SearchService]
@string NVARCHAR(100), @int int
AS
BEGIN
		DECLARE @table TABLE
		(
			id INT
		)
		SELECT @string = '%' + [dbo].[ConvertString](@string) + '%'
		INSERT INTO @table
			SELECT id FROM dbo.SERVICE WHERE [dbo].[ConvertString](name) like @string OR id = @int
		SELECT Service.ID, Service.Name, Price, ServiceType.Name AS [nameServiceType], IDServiceType
		FROM @table INNER JOIN dbo.SERVICE ON SERVICE.ID = [@table].id INNER JOIN dbo.ServiceType ON ServiceType.ID = Service.IDServiceType
END

GO
---------------------------

--------------------------------------------------------------

--Service Type
--------------------------------------------------------------
CREATE PROC [dbo].[USP_SearchServiceType]
@string NVARCHAR(100), @int INT
AS
BEGIN
	DECLARE @table table( id int)
	SELECT @string ='%' + [dbo].[ConvertString](@string) + '%'
	INSERT INTO @table SELECT id FROM ServiceType WHERE [dbo].[ConvertString](name) LIKE @string OR id = @int
	SELECT dbo.SERVICETYPE.ID, Name FROM @table INNER JOIN servicetype ON  SERVICETYPE.ID = [@table].id
END

GO
--------------------------------------------------------------

--Staff 
--------------------------------------------------------------
CREATE PROC [dbo].[USP_SearchStaff]
@string NVARCHAR(100), @int int
AS
BEGIN
	SELECT @string = '%' + [dbo].[ConvertString](@string) + '%'
	DECLARE @table TABLE( username NVARCHAR(100))
	IF(@int < 1)
	begin
		INSERT INTO @table SELECT username FROM staff 
		WHERE username LIKE @string OR [dbo].[ConvertString](DisplayName) LIKE @string
		OR  idcard LIKE @string
	END
	ELSE
    BEGIN
		INSERT INTO @table SELECT username FROM staff 
		WHERE username LIKE @string OR [dbo].[ConvertString](DisplayName) LIKE @string
		OR  idcard LIKE @string OR cast(PhoneNumber AS NVARCHAR(100)) LIKE @string
	END
	SELECT Staff.UserName, DisplayName, Name, IDCard, DateOfBirth, Sex, PhoneNumber, StartDay, Address, IDStaffType
    FROM dbo.Staff INNER JOIN  @table ON [@table].username = STAFF.UserName INNER JOIN dbo.StaffType ON StaffType.ID = Staff.IDStaffType
end

GO
CREATE proc [dbo].[USP_ShowBill]
@idRoom int
as
begin
	select D.Name [Tên dịch vụ],D.Price[Đơn giá],B.Count[Số lượng],B.TotalPrice[Thành tiền]
	from Bill A, BillDetails B, ReceiveRoom C, Service D
	where A.IDStatusBill=1 and A.ID=b.IDBill and A.IDReceiveRoom=C.ID and C.IDRoom=@idRoom and B.IDService=D.ID
end

GO
CREATE proc [dbo].[USP_ShowBillInfo]
@idBill int
as
begin
select D.Name[HoTen],D.IDCard[CMND],D.PhoneNumber[SDT],E.Name[LoaiKH],D.Address[DiaChi],D.Nationality[QuocTich],F.Name[TenPhong],G.Name[LoaiPhong],G.Price[DonGia],C.DateCheckIn[NgayDen],C.DateCheckOut[NgayDi],A.RoomPrice[TienPhong],A.ServicePrice[TienDichVu],A.Surcharge[PhuThu],A.TotalPrice[ThanhTien],A.Discount[GiamGia]
from Bill A, ReceiveRoom B,BookRoom C, Customer D,CustomerType E,Room F,RoomType G
where A.IDReceiveRoom=B.ID and B.IDBookRoom=C.ID and C.IDCustomer=D.ID and D.IDCustomerType=E.ID and B.IDRoom=F.ID and F.IDRoomType=G.ID and A.ID=@idBill
end

GO
CREATE proc [dbo].[USP_ShowBillPreView]
@idBill int
as
begin
	select D.Name [Tên dịch vụ],D.Price[Đơn giá],B.Count[Số lượng],B.TotalPrice[Thành tiền]
	from Bill A, BillDetails B, Service D
	where A.IDStatusBill=2 and A.ID=b.IDBill and A.ID=@idBill and B.IDService=D.ID
end

GO
CREATE proc [dbo].[USP_ShowBillRoom]--Muốn proc thực thi được thì phải thực thi USP_UpdateBill trước(nếu có thể)
@getToday Date,@idRoom int
as
begin

	select A.Name [Tên phòng],D.Price[Đơn giá] ,C.DateCheckIn [Ngày nhận],C.DateCheckOut[Ngày trả] ,E.RoomPrice[Tiền phòng],E.Surcharge[Phụ thu]
	from Room A,ReceiveRoom B, BookRoom C,RoomType D,Bill E
	where E.IDReceiveRoom=B.ID and IDStatusRoom=2 and A.ID=B.IDRoom and B.IDBookRoom=C.ID and A.IDRoomType=D.ID and C.DateCheckOut>=@getToday and B.IDRoom=@idRoom and E.IDStatusBill=1
end

GO
CREATE proc [dbo].[USP_ShowCustomerFromReceiveRoom]
@idReceiveRoom int
as
begin
	select C.Name[Tên khách hàng],C.IDCard[CMND],C.Address[Địa chỉ],C.PhoneNumber[Số điện thoại],C.Nationality[Quốc tịch]
	from ReceiveRoom A, BookRoom B, Customer C
	where A.ID=@idReceiveRoom and A.IDBookRoom=B.ID and B.IDCustomer=C.ID
	union
	select C.Name[Tên khách hàng],C.IDCard[CMND],C.Address[Địa chỉ],C.PhoneNumber[Số điện thoại],C.Nationality[Quốc tịch]
	from ReceiveRoom A,ReceiveRoomDetails B,Customer C
	where A.ID=@idReceiveRoom and A.ID=B.IDReceiveRoom and B.IDCustomerOther=C.ID
end

GO
create proc [dbo].[USP_ShowReceiveRoom]
@idReceiveRoom int
as
begin
	select A.ID[Mã nhận phòng], C.Name[Tên phòng],B.DateCheckIn[Ngày nhận],B.DateCheckOut[Ngày trả]
	from ReceiveRoom A,BookRoom B,Room C
	where A.IDBookRoom=B.ID and A.IDRoom=C.ID and A.ID=@idReceiveRoom
end

GO
create proc [dbo].[USP_UpdateAccount3]
@username nvarchar(100),@address nvarchar(100),@phonenumber int
as
begin
	update Staff
	set Address=@address,PhoneNumber=@phonenumber
	where UserName=@username
end

GO
CREATE proc [dbo].[USP_UpdateBill_Other]
@idBill int,@discount int
as
begin
	declare @totalPrice int=0,@idRoom int
	select @totalPrice=RoomPrice+ServicePrice+ Surcharge
	from Bill
	where ID=@idBill

	update Bill
	set DateOfCreate=GETDATE(), TotalPrice=@totalPrice,Discount=@discount,IDStatusBill=2
	where ID=@idBill

	select @idRoom=B.IDRoom
	from Bill A, ReceiveRoom B
	where A.IDReceiveRoom=B.ID

	update Room
	set IDStatusRoom=1
	where ID=@idRoom
end

GO
CREATE proc [dbo].[USP_UpdateBill_RoomPrice]
@idBill int
as
begin
	declare @idReceiveRoom int,@roomPrice int =0,@price int,@days int,@countCustomer int,@limitPerson int,@check1 int,@check2 int,@surcharge int =0

	select @days=DATEDIFF(day,C.DateCheckIn,C.DateCheckOut),@price=D.Price,@limitPerson=D.LimitPerson,@idReceiveRoom=A.IDReceiveRoom
	from Bill A,ReceiveRoom B,BookRoom C,RoomType D,Room E
	where A.ID=@idBill and A.IDReceiveRoom=B.ID and B.IDRoom=E.ID and E.IDRoomType=D.ID and C.ID=B.IDBookRoom

	select @countCustomer=COUNT(B.IDReceiveRoom)
	from ReceiveRoom A,ReceiveRoomDetails B
	where A.ID=@idReceiveRoom and A.ID=B.IDReceiveRoom

	set @roomPrice=@price*@days;

	declare @QD2 float = 0 -- phu thu them
	select @QD2 = value from Parameter where Name = N'QĐ2'

	declare @QD3 float = 0 -- khach nuoc ngoai
	select @QD3 = value from Parameter where Name = N'QĐ3'

	if((@countCustomer+1-@limitPerson)>=0)
	set @surcharge=@roomPrice*@QD2*(@countCustomer+1-@limitPerson)

	select @check1=COUNT(*)
	from ReceiveRoom A,BookRoom B,Customer D
	where A.IDBookRoom=B.ID and B.IDCustomer=D.ID and D.Nationality!=N'Việt Nam' and A.ID=@idReceiveRoom
	select @check2=COUNT(*)
	from ReceiveRoom A,ReceiveRoomDetails C,Customer D
	where A.ID=C.IDReceiveRoom and D.ID=C.IDCustomerOther and D.Nationality!=N'Việt Nam' and A.ID=@idReceiveRoom

	if((@check1+@check2)>0) 
	set @surcharge=@surcharge + @roomPrice*(@QD3 - 1)

	update Bill
	set RoomPrice=@roomPrice, Surcharge=@surcharge
	where id=@idBill
end

GO
CREATE proc [dbo].[USP_UpdateBill_ServicePrice]
@idBill int
as
begin
	declare @totalServicePrice int=0
	select @totalServicePrice=SUM(TotalPrice)
	from BillDetails
	where IDBill=@idBill
	if(@totalServicePrice is null)
	set @totalServicePrice=0
	update Bill 
	set ServicePrice=@totalServicePrice
	where ID=@idBill
end

GO
CREATE proc [dbo].[USP_UpdateBillDetails]
@idBill int,@idService int,@_count int
as
begin
	declare @totalPrice int,@price int,@count int

	select @price=Price
	from Service
	where ID=@idService

	select @count=Count
	from Bill A,BillDetails B
	where A.ID=B.IDBill and A.ID=@idBill and A.IDStatusBill=1 and B.IDService=@idService

	set @count=@count+@_count
	if(@count>0)
	begin
		set @totalPrice=@count*@price
		update BillDetails
		set Count=@count,TotalPrice=@totalPrice
		where IDBill=@idBill and IDService=@idService
	end
	else
	begin
		delete from BillDetails
		where IDBill=@idBill and IDService=@idService
	end
end

GO
create proc [dbo].[USP_UpdateBookRoom]
@id int,@idRoomType int,@dateCheckIn date,@datecheckOut date
as
begin
	update BookRoom
	set IDRoomType=@idRoomType,DateCheckIn=@dateCheckIn,DateCheckOut=@datecheckOut
	where ID=@id
end

GO
CREATE PROC [dbo].[USP_UpdateCustomer]
@id INT, @customerName NVARCHAR(100), @idCustomerType int, @idCardNow NVARCHAR(100), @address NVARCHAR(200),
@dateOfBirth date, @phoneNumber int, @sex NVARCHAR(100), @nationality NVARCHAR(100), @idCardPre NVARCHAR(100)
AS
BEGIN
	IF(@idCardPre != @idCardNow)
	begin
		DECLARE @count INT=0
		SELECT @count=COUNT(*)
		FROM dbo.Customer
		WHERE IDCard = @idCardNow
		IF(@count=0)
		BEGIN
			UPDATE dbo.Customer 
			SET 
			Name =@customerName, IDCustomerType = @idCustomerType, IDCard =@idCardNow,
			Address = @address, DateOfBirth =@dateOfBirth, PhoneNumber =@phoneNumber,
			Nationality = @nationality, Sex = @sex
			WHERE ID = @id
		END
	END
	ELSE
	BEGIN
		UPDATE dbo.Customer 
			SET 
			Name =@customerName, IDCustomerType = @idCustomerType,Address = @address,
			DateOfBirth =@dateOfBirth, PhoneNumber =@phoneNumber,
			Nationality = @nationality, Sex = @sex
			WHERE ID = @id
	end
END

GO
create proc [dbo].[USP_UpdateCustomer_]
@id int,@name nvarchar(50),@idCard nvarchar(50),@idCustomerType int,@phoneNumber int, @dateOfBirth date,@address nvarchar(100),@sex nvarchar(20),@nationality nvarchar(100)
as
begin
	update Customer
	set Name=@name,IDCard=@idCard,IDCustomerType=@idCustomerType,PhoneNumber=@phoneNumber,DateOfBirth=@dateOfBirth,Address=@address,Sex=@sex,Nationality=@nationality
	where ID=@id
end

GO
create proc [dbo].[USP_UpdateDisplayName]
@username nvarchar(100),@displayname nvarchar(100)
as
begin
	update Staff
	set DisplayName=@displayname
	where UserName=@username
end

GO
CREATE proc [dbo].[USP_UpdateInfo]
@username nvarchar(100),@address nvarchar(100),@phonenumber int,@idcard nvarchar(100),@dateOfBirth date,@sex nvarchar(50)
as
begin
	update Staff
	set Address=@address,PhoneNumber=@phonenumber,IDCard=@idcard,Sex=@sex, DateOfBirth=@dateOfBirth
	where UserName=@username
end

GO
CREATE PROC [dbo].[USP_UpdateParameter]
@name NVARCHAR(200), @value float, @describe NVARCHAR(200)
AS
BEGIN
UPDATE dbo.PARAMETER
	SET
	Value = @value,
	Describe = @describe,
	datemodify = GETDATE()
	WHERE name = @name
	SELECT @name = [dbo].[ConvertString](@name)
	IF(@name = 'QD2.1')
		UPDATE dbo.ROOMTYPE SET LimitPerson = @value WHERE ID = 1
	ELSE IF(@name = 'QD2.2')
		UPDATE dbo.ROOMTYPE SET LimitPerson = @value WHERE ID = 2
	ELSE IF(@name = 'QD2.3')
		UPDATE dbo.ROOMTYPE SET LimitPerson = @value WHERE ID = 3
	ELSE IF(@name = 'QD2.4')
		UPDATE dbo.ROOMTYPE SET LimitPerson = @value WHERE ID = 4
END

GO
create proc [dbo].[USP_UpdatePassword]
@username nvarchar(100),@password nvarchar(100)
as
begin
	update Staff
	set PassWord=@password
	where UserName=@username
end

GO
CREATE proc [dbo].[USP_UpdateReceiveRoom]
@id int,@idRoom int
as
begin
	update ReceiveRoom
	set IDRoom=@idRoom
	where ID=@id

	update Room
	set IDStatusRoom=2
	where ID=@idRoom
end	

GO
CREATE PROC [dbo].[USP_UpdateRoom]
@id INT, @nameRoom NVARCHAR(100), @idRoomType INT, @idStatusRoom INT
AS
UPDATE dbo.Room
SET
	Name = @nameRoom, IDRoomType = @idRoomType, IDStatusRoom = @idStatusRoom
WHERE ID = @id
GO
CREATE PROC [dbo].[USP_UpdateRoomType]
@id INT, @name NVARCHAR(100), @price int, @limitPerson int
AS
	UPDATE RoomType
	SET
    name = @name, Price = @price, LimitPerson = @limitPerson
	WHERE id =@id
GO
create proc [dbo].[USP_UpdateService]
@id int, @name nvarchar(200), @idServiceType int, @price int
as
begin
	update service
	set
	name = @name,
	idservicetype = @idservicetype,
	price = @price
	where id = @id
END

GO
CREATE PROC [dbo].[USP_UpdateServiceType]
@id INT, @name NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.ServiceType
	SET
    name = @name
	WHERE id =@id
END
GO
CREATE PROC [dbo].[USP_UpdateStaff]
@user NVARCHAR(100), @name NVARCHAR(100),@idStaffType INT,
@idCard NVARCHAR(100), @dateOfBirth DATE, @sex NVARCHAR(100),
@address NVARCHAR(200), @phoneNumber INT, @startDay DATE
AS
BEGIN
	DECLARE @count INT = 0
	SELECT @count=COUNT(*) FROM staff
	WHERE IDCard = @idCard AND UserName != @user
	IF(@count = 0)
	UPDATE dbo.STAFF
	SET
    displayname = @name, idstafftype = @idstafftype,
	idcard= @idCard, DateOfBirth = @dateOfBirth, sex = @sex,
	Address = @address, PhoneNumber = @phoneNumber, StartDay = @startDay
	WHERE UserName = @user
END

GO
CREATE PROC [dbo].[USP_UpdateStaffType] 
@id int, @name NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.StaffType
	SET
    Name = @name
	WHERE ID = @id
END

GO
create proc [dbo].[USP_UpdateStatusRoom]
@idRoom int
as
begin
	update Room
	set IDStatusRoom=1
	where ID=@idRoom
end
GO
