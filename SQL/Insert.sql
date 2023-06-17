
USE HotelManagement
GO

INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 1)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 2)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 3)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 4)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 5)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 6)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 7)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 8)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 9)
INSERT ACCESS (IDStaffType, IDJob) VALUES (1, 10)
INSERT ACCESS (IDStaffType, IDJob) VALUES (2, 1)
INSERT ACCESS (IDStaffType, IDJob) VALUES (2, 2)
INSERT ACCESS (IDStaffType, IDJob) VALUES (2, 3)

SET IDENTITY_INSERT CustomerType ON 
INSERT CustomerType (ID, Name, Rate) VALUES (1, N'Khách nội địa', 1)
INSERT CustomerType (ID, Name, Rate) VALUES (2, N'Khách nước ngoài', 1.5)
SET IDENTITY_INSERT CustomerType OFF

SET IDENTITY_INSERT JOB ON 
INSERT JOB (ID, Name, NameForm) VALUES (1, N'Đặt Phòng', N'fBookRoom')
INSERT JOB (ID, Name, NameForm) VALUES (2, N'Nhận Phòng', N'fReceiveRoom')
INSERT JOB (ID, Name, NameForm) VALUES (3, N'Sử dụng dịch vụ và Thanh toán', N'fUseService')
INSERT JOB (ID, Name, NameForm) VALUES (4, N'Thống kê và doanh thu', N'fReport')
INSERT JOB (ID, Name, NameForm) VALUES (5, N'Quản lí phòng', N'fRoom')
INSERT JOB (ID, Name, NameForm) VALUES (6, N'Quản lí nhân viên', N'fStaff')
INSERT JOB (ID, Name, NameForm) VALUES (7, N'Quản lí khách hàng', N'fCustomer')
INSERT JOB (ID, Name, NameForm) VALUES (8, N'Quản lí hoá đơn', N'fBill')
INSERT JOB (ID, Name, NameForm) VALUES (9, N'Quản lí dịch vụ', N'fService')
INSERT JOB (ID, Name, NameForm) VALUES (10, N'Quy định', N'fParameter')
SET IDENTITY_INSERT JOB OFF


INSERT Parameter (Name, Value, Describe, DateModify) VALUES (N'QĐ1', 3, N'Mỗi phòng có tối đa 3 khách', NULL)
INSERT Parameter (Name, Value, Describe, DateModify) VALUES (N'QĐ2', 2, N'Số người không phụ thu', NULL)

INSERT SurchargeRate (Name, Value, DateModify) VALUES (3, 0.25, NULL)
 
SET IDENTITY_INSERT Room ON
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (1, N'101', 1, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (2, N'102', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (3, N'103', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (4, N'104', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (5, N'105', 1, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (6, N'106', 1, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (7, N'107', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (8, N'108', 1, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (9, N'109', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (10, N'201', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (11, N'202', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (12, N'203', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (13, N'204', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (14, N'205', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (15, N'206', 3, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (16, N'207', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (17, N'208', 1, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (18, N'209', 2, 1)
INSERT Room (ID, Name, IDRoomType, IDStatusRoom) VALUES (19, N'210', 3, 1)
SET IDENTITY_INSERT Room OFF

SET IDENTITY_INSERT RoomType ON 
INSERT RoomType (ID, Name, Price, LimitPerson) VALUES (1, N'A', 150000, 3)
INSERT RoomType (ID, Name, Price, LimitPerson) VALUES (2, N'B', 170000, 3)
INSERT RoomType (ID, Name, Price, LimitPerson) VALUES (3, N'C', 200000, 3)
SET IDENTITY_INSERT RoomType OFF

SET IDENTITY_INSERT ServiceType ON 
INSERT ServiceType (ID, Name) VALUES (1, N'Ăn uống')
INSERT ServiceType (ID, Name) VALUES (2, N'Giải trí')
INSERT ServiceType (ID, Name) VALUES (3, N'Tiện ích')
SET IDENTITY_INSERT ServiceType OFF

SET IDENTITY_INSERT Service ON 
INSERT Service (ID, Name, IDServiceType, Price) VALUES (1, N'Food', 1, 50000)
INSERT Service (ID, Name, IDServiceType, Price) VALUES (2, N'Drink', 1, 50000)
INSERT Service (ID, Name, IDServiceType, Price) VALUES (3, N'Cầu trượt', 2, 100000)
INSERT Service (ID, Name, IDServiceType, Price) VALUES (4, N'Cosplay', 2, 200000)
INSERT Service (ID, Name, IDServiceType, Price) VALUES (5, N'Spa', 3, 200000)
SET IDENTITY_INSERT Service OFF


INSERT Staff (UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay) VALUES (N'admin', N'Nguyễn Văn Quân', N'c4ca4238a0b923820dcc509a6f75849b', 1, N'123456', CAST(N'2003-02-06' AS Date), N'Nam', N'Hà Nội', 147852, CAST(N'2023-05-05' AS Date))
INSERT Staff (UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay) VALUES (N'vee', N'Nguyễn Thị Tường Vee', N'c4ca4238a0b923820dcc509a6f75849b', 2, N'1234567', CAST(N'2003-02-06' AS Date), N'Nữ', N'HCM', 123456789, CAST(N'2023-05-05' AS Date))
INSERT Staff (UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay) VALUES (N'meo', N'chú mèo mập', N'c4ca4238a0b923820dcc509a6f75849b', 3, N'12345678', CAST(N'2003-02-06' AS Date), N'Nam', N'Little Sài Gòn', 123456789, CAST(N'2023-05-05' AS Date))
INSERT Staff (UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay) VALUES (N'quanquan', N'Nguyễn Văn Quân', N'c4ca4238a0b923820dcc509a6f75849b', 1, N'123456789', CAST(N'2003-02-06' AS Date), N'Nữ', N'Cali', 0969399209, CAST(N'2023-05-05' AS Date))
INSERT Staff (UserName, DisplayName, PassWord, IDStaffType, IDCard, DateOfBirth, Sex, Address, PhoneNumber, StartDay) VALUES (N'quan', N'Nguyễn Văn Quân', N'c4ca4238a0b923820dcc509a6f75849b', 1, N'1234567890', CAST(N'2003-02-06' AS Date), N'Nam', N'LA', 0969399209, CAST(N'2023-05-05' AS Date))


SET IDENTITY_INSERT StaffType ON 
INSERT StaffType (ID, Name) VALUES (1, N'Quản lí')
INSERT StaffType (ID, Name) VALUES (2, N'Lễ tân')
INSERT StaffType (ID, Name) VALUES (3, N'Kế toán')
SET IDENTITY_INSERT StaffType OFF

SET IDENTITY_INSERT StatusBill ON 
INSERT StatusBill (ID, Name) VALUES (1, N'Chưa thanh toán')
INSERT StatusBill (ID, Name) VALUES (2, N'Đã thanh toán')
SET IDENTITY_INSERT StatusBill OFF

SET IDENTITY_INSERT StatusRoom ON 
INSERT StatusRoom (ID, Name) VALUES (1, N'Trống')
INSERT StatusRoom (ID, Name) VALUES (2, N'Đang thuê')
SET IDENTITY_INSERT StatusRoom OFF
GO

ALTER TABLE Customer ADD UNIQUE NONCLUSTERED 
(
	IDCard ASC
)
GO

ALTER TABLE Parameter ADD UNIQUE NONCLUSTERED 
(
	Name ASC
)
GO

ALTER TABLE Staff ADD UNIQUE NONCLUSTERED 
(
	IDCard ASC
)
GO
ALTER TABLE Bill ADD  DEFAULT (getdate()) FOR DateOfCreate
GO
ALTER TABLE Bill ADD  DEFAULT ((0)) FOR RoomPrice
GO
ALTER TABLE Bill ADD  DEFAULT ((0)) FOR ServicePrice
GO
ALTER TABLE Bill ADD  DEFAULT ((0)) FOR TotalPrice
GO
ALTER TABLE Bill ADD  DEFAULT ((0)) FOR Discount
GO
ALTER TABLE Bill ADD  CONSTRAINT DF__Bill__IDStatusBi__1DB06A4F  DEFAULT ((1)) FOR IDStatusBill
GO
ALTER TABLE Bill ADD  DEFAULT ((0)) FOR Surcharge
GO
ALTER TABLE BillDetails ADD  DEFAULT ((0)) FOR TotalPrice
GO
ALTER TABLE Customer ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE CustomerType ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE Parameter ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE Parameter ADD  DEFAULT (getdate()) FOR DateModify
GO
ALTER TABLE REPORT ADD  DEFAULT ((0)) FOR value
GO
ALTER TABLE REPORT ADD  DEFAULT ((1)) FOR Month
GO
ALTER TABLE REPORT ADD  DEFAULT ((1990)) FOR Year
GO
ALTER TABLE Room ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE RoomType ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE Service ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE ServiceType ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE Staff ADD  DEFAULT (N'No Name') FOR DisplayName
GO
ALTER TABLE StaffType ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE StatusBill ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE StatusRoom ADD  DEFAULT (N'No Name') FOR Name
GO
ALTER TABLE ACCESS  WITH CHECK ADD FOREIGN KEY(IDJob)
REFERENCES JOB (ID)
GO
ALTER TABLE ACCESS  WITH CHECK ADD FOREIGN KEY(IDStaffType)
REFERENCES StaffType (ID)
GO
ALTER TABLE Bill  WITH CHECK ADD FOREIGN KEY(IDReceiveRoom)
REFERENCES ReceiveRoom (ID)
GO
ALTER TABLE Bill  WITH CHECK ADD FOREIGN KEY(IDStatusBill)
REFERENCES StatusBill (ID)
GO
ALTER TABLE Bill  WITH CHECK ADD FOREIGN KEY(StaffSetUp)
REFERENCES Staff (UserName)
GO
ALTER TABLE BillDetails  WITH CHECK ADD FOREIGN KEY(IDBill)
REFERENCES Bill (ID)
GO
ALTER TABLE BillDetails  WITH CHECK ADD FOREIGN KEY(IDService)
REFERENCES Service (ID)
GO
ALTER TABLE BookRoom  WITH CHECK ADD FOREIGN KEY(IDCustomer)
REFERENCES Customer (ID)
GO
ALTER TABLE BookRoom  WITH CHECK ADD FOREIGN KEY(IDRoomType)
REFERENCES RoomType (ID)
GO
ALTER TABLE Customer  WITH CHECK ADD FOREIGN KEY(IDCustomerType)
REFERENCES CustomerType (ID)
GO
ALTER TABLE ReceiveRoom  WITH CHECK ADD FOREIGN KEY(IDBookRoom)
REFERENCES BookRoom (ID)
GO
ALTER TABLE ReceiveRoom  WITH CHECK ADD FOREIGN KEY(IDRoom)
REFERENCES Room (ID)
GO
ALTER TABLE ReceiveRoomDetails  WITH CHECK ADD FOREIGN KEY(IDCustomerOther)
REFERENCES Customer (ID)
GO
ALTER TABLE ReceiveRoomDetails  WITH CHECK ADD FOREIGN KEY(IDReceiveRoom)
REFERENCES ReceiveRoom (ID)
GO
ALTER TABLE REPORT  WITH CHECK ADD FOREIGN KEY(idRoomType)
REFERENCES RoomType (ID)
GO
ALTER TABLE Room  WITH CHECK ADD FOREIGN KEY(IDRoomType)
REFERENCES RoomType (ID)
GO
ALTER TABLE Room  WITH CHECK ADD FOREIGN KEY(IDStatusRoom)
REFERENCES StatusRoom (ID)
GO
ALTER TABLE Service  WITH CHECK ADD FOREIGN KEY(IDServiceType)
REFERENCES ServiceType (ID)
GO
ALTER TABLE Staff  WITH CHECK ADD FOREIGN KEY(IDStaffType)
REFERENCES StaffType (ID)
GO
