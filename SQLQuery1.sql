Use HS
--Owner Application
Drop View PlotAvailable
Create View PlotAvailable 
As
Select Number, [Block], [Plot_Address], Size From Plot Where Owner_Id is Null
Drop Procedure NewOwnerApplication

Create Procedure NewOwnerApplication
@FName  varchar(50),  @LName varchar(50),  @Gender varchar(2),  @Phone_Number varchar(11), @Number int, @Block int
As
If Not Exists (Select Phone_Number From [Owner Application] Where Phone_Number = @Phone_Number) 
	Insert into [Owner Application]([First Name], [Last Name], TitleOfCourtesy, Phone_Number, Plot_Id) 
	Values(
	@FName,
	@LName,
	@Gender,
	@Phone_Number,

(Select Id From Plot Where [Block] = @Block and Number = @Number)
)
Select * From [Resident Application]

--Resident Application

Drop View ResidentialPlotAvailable
Create View ResidentialPlotAvailable 
As
Select P.Number, P.[Block], P.Plot_Address, PT.[Description] From Plot P Join PlotType PT On (PT.Id = P.Type_Id) Where Rent = 1

Drop Procedure NewResidentApplication

Create Procedure NewResidentApplication
@FName  varchar(50),  @LName varchar(50),  @Gender varchar(2),  @Phone_Number varchar(11), @Number int, @Block int, @tenant tinyint
As
If Not Exists (Select Phone_Number From [Resident Application] Where Phone_Number = @Phone_Number) 
	Insert into [Resident Application]([First Name], [Last Name], TitleOfCourtesy, Phone_Number, Plot_Id, Tenant) 
	Values(
	@FName,
	@LName,
	@Gender,
	@Phone_Number,
(Select Id From Plot Where [Block] = @Block and Number = @Number),
@tenant
)


--EmployeeApplication
Drop Procedure NewEmployeeApplication

Create Procedure NewEmployeeApplication
@FName  varchar(50),  @LName varchar(50),  @Gender varchar(2),  @Phone_Number varchar(11),  @dName varchar(50), @pName varchar(50)
As

If Not Exists (Select Phone_Number From [Employee Application] Where Phone_Number = @Phone_Number) 
	insert into [Employee Application]([First Name], [Last Name], TitleOfCourtesy, Phone_Number, Department_Id, Position) 
	values(
	@FName, 
	@LName, 
	@Gender, 
	@Phone_Number,  
	(Select Id From SocietyDepartment Where [Name] = @dName),
	(Select Id From Position Where [Description] = @pName)
)

Exec NewEmployeeApplication 'Aqib', 'Ansari','Mr', '0301973444', 'Fire', 'Assistant'

--Resident Login--
Drop Procedure ResidentLogin

Create Procedure ResidentLogin
@RId int
As
If @RId In (Select Id From Resident)
	Select R.Id as ResidentId, R.[First Name] as FirstName, R.[Last Name] as LastName, R.PhoneNumber as PhoneNumber, P.Id as PlotId, O.TitleOfCourtesy + ' ' + O.[First Name] + ' ' + O.[Last Name] LandLord, P.Plot_Address as [Address] 
	From Resident R 
	Left Join Plot P On (R.Plot_Id = P.Id)
	Left Join PlotOwner O On (O.Id = P.Owner_Id)
	Where R.Id = @RId

Create Procedure UpdateFName
	@RId int, @Fname varchar(50)
As
If @RId in (Select Id From Resident)
	Update Resident
	Set [First Name] = @Fname
	Where Id = @RId

Create Procedure UpdateLName
	@RId int, @Lname varchar(50)
As
If @RId in (Select Id From Resident)
	Update Resident
	Set [Last Name] = @Lname
	Where Id = @RId

Drop Procedure UpdatePhoneNumber
Create Procedure UpdatePhoneNumber
	@RId int, @Phone varchar(11)
As
If @RId in (Select Id From Resident)
	If @Phone Not In (Select PhoneNumber From Resident)
		Update Resident
		Set PhoneNumber = @Phone
		Where Id = @RId

Exec UpdatePhoneNumber 1, '03028480888'

Create Procedure ResidentRequest
	@RID int, @Department_Name varchar(50)
As
	Insert Into Request(Resident_Id, Department_Id)
	Values(@RID, (Select Id From SocietyDepartment Where [Name] = @Department_Name))

Exec ResidentLogin 2

--OwnerLogin--

Create Procedure OwnerLogin
@Id int
As
Select * From PlotOwner Where Id = @Id

Create Procedure UpdateOwnerFName
	@RId int, @Fname varchar(50)
As
If @RId in (Select Id From PlotOwner)
	Update PlotOwner
	Set [First Name] = @Fname
	Where Id = @RId

Drop Procedure UpdateOwnerLName
Create Procedure UpdateOwnerLName
	@RId int, @Lname varchar(50)
As
If @RId in (Select Id From PlotOwner)
	Update PlotOwner
	Set [Last Name] = @Lname
	Where Id = @RId

Drop Procedure UpdateOwnerPhoneNumber
aLTER Procedure UpdateOwnerPhoneNumber
	@RId int, @Phone varchar(11)
As
If @RId in (Select Id From PlotOwner)
	If @Phone Not In (Select Phone_Number From PlotOwner)
		Update Plot
		Set Owner_PhoneNumber = @Phone
		Where Owner_Id = @RId
		Update PlotOwner
		Set Phone_Number = @Phone
		Where Id = @RId

Create Procedure OwnerProperties
@Id int
As
Select * From Plot Where Owner_Id = @Id



Drop Procedure AvailableProperties
Create Procedure AvailableProperties
As
Select * From Plot Where Owner_Id is Null

Drop Procedure SellOwnerPlot
Create Procedure SellOwnerPlot
@OID int,
@PId int
As
Update Plot
Set Owner_Id = Null 
Where Id = @PId
Update Plot
Set Purchase_Date = Null
Where Id = @PId 
Update Plot
Set Owner_PhoneNumber = Null
Where Id = @PId

Create Procedure OpenClosePlot
@PId int
As
Update Plot
Set Rent = 1 ^ Rent
Where Id = @PId
Exec OpenClosePlot 7

Drop Procedure PurchasePlot
Select * From REQUEST
Alter Procedure PurchasePlot
@OId int, @Id int
As 
Update Plot
Set Owner_Id = @OId
Where Id = @Id
Update Plot
Set Purchase_Date = getdate()
Where Id = @Id
Update Plot
Set Owner_PhoneNumber = (Select Phone_Number From PlotOwner Where Id = @OID)
Where Id = @Id
Drop Procedure OwnerResidents
Create Procedure OwnerResidents
@OID int
As
Select R.Plot_Id as PlotId, R.[First Name] as FirstName, R.[Last Name] as LastName , R.Is_Tenant , R.Rent, R.PhoneNumber From PlotOwner O
Left Join Plot P On (P.Owner_Id = O.Id)
Left Join Resident R On (R.Plot_Id = P.Id)
Where O.Id = @OID

Drop Procedure OwnerResidentApllications
Create Procedure OwnerResidentApllications
@OID int
As
Select * From [Resident Application] Where Plot_Id in (Select Plot_Id From Plot Where Owner_ID = @OID)
Drop Procedure RentResident
Create Procedure RentResident
@OId int,
@FName varchar(50), @LName varchar(50), @PhoneNumber varchar(11),@Rent int
As
Update Resident
Set Rent = @Rent
Where [First Name] = @FName and [Last Name] = @LName and PhoneNumber = @PhoneNumber and Plot_Id = 
(
Select R.Plot_Id From PlotOwner O Left Join Plot P On (P.Owner_Id = O.Id) Left Join Resident R On(R.Plot_Id = P.Id)
Where R.[First Name] = @FName and R.[Last Name] = @LName and R.PhoneNumber = @PhoneNumber
)

Drop Procedure EvictResident
Create Procedure EvictResident
@OId int,
@FName varchar(50), @LName varchar(50), @PhoneNumber varchar(11)
As
Update Resident
Set Plot_Id = Null
Where [First Name] = @FName and [Last Name] = @LName and PhoneNumber = @PhoneNumber and Plot_Id = 
(
Select R.Plot_Id From PlotOwner O Left Join Plot P On (P.Owner_Id = O.Id) Left Join Resident R On(R.Plot_Id = P.Id)
Where R.[First Name] = @FName and R.[Last Name] = @LName and R.PhoneNumber = @PhoneNumber
)

Drop Procedure ApproveResidentApplication
Create Procedure ApproveResidentApplication
@FName varchar(50), @LName varchar(50), @PhoneNumber varchar(11), @PlotId int, @Gender varchar(2), @Tenant tinyint
As
If Not Exists (Select PhoneNumber From [Resident] Where PhoneNumber = @PhoneNumber) 
	Insert Into Resident([First Name], [Last Name], PhoneNumber, Plot_Id, TitleOfCourtesy, Is_Tenant)
	Values(@FName, @LName, @PhoneNumber, @PlotId, @Gender, @Tenant)

	Delete [Resident Application]
	Where Phone_Number = @PhoneNumber

Drop Procedure RejectResidentApplication

Create Procedure RejectResidentApplication
@PhoneNumber varchar(11)
As
	Delete [Resident Application]
	Where Phone_Number = @PhoneNumber
--Employee--
Alter Procedure ExecLogin
@Id int
As
Select * From Employee Where Id = @Id and Department_Id = (Select Id From SocietyDepartment Where [Name] = 'Executive Branch ')
Exec ExecLogin 8
Drop Procedure EmployeeLogin
--Owner Applications_-
Drop Procedure OwnerApplications
Create Procedure OwnerApplications
As
Select * From [Owner Application]

Drop Procedure ApproveOwnerApplication
Select * From SocietyDepartment
Alter Procedure ApproveOwnerApplication
@FName varchar(50), @LName varchar(50), @Gender varchar(2), @PhoneNumber varchar(11), @PlotId int
As
		Insert Into PlotOwner([First Name], [Last Name], TitleOfCourtesy, Phone_Number)
		Values(@FName, @LName, @Gender, @PhoneNumber)
		Update Plot
		Set Owner_Id = (Select Id From PlotOwner Where Phone_Number = @PhoneNumber)
		Where Id = @PlotId
		Update Plot
		Set Owner_PhoneNumber = @PhoneNumber
		Where Id = @PlotId
		Update Plot
		Set Purchase_Date = GETDATE()
		Where Id = @PlotId
		Delete [Owner Application]
		Where Phone_Number = @PhoneNumber
Exec ApproveOwnerApplication 'Najeeb', 'Jilani', 'Mr', '0308767077', '5'

Drop Procedure RejectOwnerApplication
Create Procedure RejectOwnerApplication
@PhoneNumber varchar(11)
As
If Exists (Select Phone_Number From [Owner Application] Where Phone_Number = @PhoneNumber) 
	Delete [Owner Application]
	Where Phone_Number = @PhoneNumber

--EmployeeApplications--
Alter Procedure ExecutiveEmployeeApplications
As
Select E.[First Name] as FirstName, E.[Last Name] As LastName, E.TitleOfCourtesy as TitleOfCourtesy, E.Phone_Number AS PhoneNumber, E.Department_Id as DepartmentId, S.[Name] as DepartmentName, P.Id as PositionId,P.[Description] As Position 
From [Employee Application] E 
Left Join Position P On (P.Id = E.Position) 
Left Join SocietyDepartment S On (S.Id = E.Department_Id) 

Drop Procedure ExecutiveEmployeeApplications
Create Procedure ExecutiveEmployeeData
As
Select * From Employee E Left Join Position P On (P.Id = E.Position)

Drop Procedure ApproveEmployeeApplication
Alter Procedure ApproveEmployeeApplication
@FName varchar(50), @LName varchar(50), @Gender varchar(2), @PhoneNumber varchar(11), @DId int, @PId int
As
If Not Exists (Select * From Employee Where [First Name] = @FName and [Last Name] = @LName and Phone_Number = @PhoneNumber)
	Insert Into Employee([First Name], [Last Name], TitleOfCourtesy, Phone_Number,Department_Id,Position,Start_Date)
	Values(@FName, @LName, @Gender, @PhoneNumber, @DID, @PID,GETDATE())
	Delete [Employee Application]
	Where [First Name] = @FName and [Last Name] = @LName and Phone_Number = @PhoneNumber

Alter Procedure RejectEmployeeApplication
@FName varchar(50), @LName varchar(50), @Gender varchar(2), @PhoneNumber varchar(11)
As
If Exists (Select * From [Employee Application] Where [First Name] = @FName and [Last Name] = @LName and Phone_Number = @PhoneNumber)
	Delete [Employee Application]
	Where [First Name] = @FName and [Last Name] = @LName and Phone_Number = @PhoneNumber

--Update Employee--
Create Procedure EmployeeData
@Id int
As
Select * From Employee
Where Id = @Id

Select * From Employee
Create Procedure UpdateEmployeeFName
@Id int, @FName varchar(50)
As 
If Exists (Select * From Employee Where Id = @Id)
	Update Employee
	Set [First Name] = @FName
	Where Id = @Id

Create Procedure UpdateEmployeeLName
@Id int, @LName varchar(50)
As 
If Exists (Select * From Employee Where Id = @Id)
	Update Employee
	Set [Last Name]= @LName
	Where Id = @Id

Create Procedure UpdateEmployeePhoneNumber
@Id int, @PhoneNumber varchar(50)
As 
If Exists (Select * From Employee Where Id = @Id)
	Update Employee
	Set [Phone_Number] = @PhoneNumber
	Where Id = @Id

Alter Procedure UpdateEmployeeSalary
@FName varchar(50), @LName varchar(50), @PhoneNumber varchar(11), @Salary int
As 
If Exists (Select * From Employee Where [First Name] = @FName and [Last Name] = @LName and [Phone_Number] = @PhoneNumber)
	Update Employee
	Set Salary = @Salary
	Where [First Name] = @FName and [Last Name] = @LName and [Phone_Number] = @PhoneNumber 

Alter Procedure ExecutiveEmployeeApplications
As
Select * From [Employee Application] E Left Join Position P On (P.Id = E.Position)

Alter Procedure ExecutiveEmployeeData
As
Select * From Employee E Left Join Position P On (P.Id = E.Position)

Create Procedure FireEmployee
@FName varchar(50), @LName varchar(50), @PhoneNumber varchar(11)
As 
If Exists (Select * From Employee Where [First Name] = @FName and [Last Name] = @LName and [Phone_Number] = @PhoneNumber)
	Delete Employee
	Where [First Name] = @FName and [Last Name] = @LName and [Phone_Number] = @PhoneNumber 

--Emergency Login--
Alter Procedure EmergencyLogin
@Id int
As
Select * From Employee E Left Join SocietyDepartment D On E.Department_Id = D.Id Left Join [Service] S On (S.Department_Id = D.[Id])
Where S.[Description] = 'Emergency' and E.Id = @Id 

Create Procedure EmergencyRequests
As
Select RE.ID As RequestId, R.[First Name] + ' ' + R.[Last Name] AS [Full Name], S.[Name] From Request RE Join Resident R On (R.Id = RE.Resident_Id) Join SocietyDepartment S On (S.Id = RE.Department_Id)
Join [Service] SE On (S.Id = SE.Department_Id)
Where SE.[Description] = 'Emergency'
Select * From [Service]

Create Procedure ResolveRequests
@Id int
As
Delete Request
Where Id= @Id

Create Procedure TransportLogin
@Id int
As
Select * From Employee E Left Join SocietyDepartment D On E.Department_Id = D.Id Left Join [Service] S On (S.Department_Id = D.[Id])
Where S.[Description] = 'Public Transport' and E.Id = @Id 

Create Procedure TransportRequests
As
Select RE.ID As RequestId, R.[First Name] + ' ' + R.[Last Name] AS [Full Name], S.[Name] From Request RE Join Resident R On (R.Id = RE.Resident_Id) Join SocietyDepartment S On (S.Id = RE.Department_Id)
Join [Service] SE On (S.Id = SE.Department_Id)
Where SE.[Description] = 'Public Transport'
Select * From [Service]
