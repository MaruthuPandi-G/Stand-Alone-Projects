--create database sampledb;
--use sampledb;

--create table EmployeeDetails(
--EmployeeId int primary key identity (1001,1),EmployeeName varchar(30)not null,Gender char(1) not null,EmployeeDateOfBirth varchar(15) not null,
--EmployeeAge int not null,EmployeePhoneNumber varchar(10)unique,EmployeeDepartment varchar(20)not null,
--EmployeeDesignation varchar(20)not null,EmployeeExperience int,EmployeeJoindate varchar(15) not null,
--EmployeeEmail varchar(30)unique,EmployeeAddress varchar(100));
--select * from EmployeeDetails;

--delete from EmployeeDetails where EmployeeId=1111;
--create table EmployeeBankDetails (EmployeeId int identity (1001,1),EmployeeName varchar(30)not null,BankName varchar(40) not null,IfscCode varchar(25)not null,AccountNumber Bigint unique,AadharNumber Bigint unique);

--select * from EmployeeBankDetails;

--create table UserLogin( UserId varchar(30) primary key,UserPassword varchar(20) unique);
--insert into UserLogin values('Maruthu','Maruthu@6112001');

--select * from UserLogin;



--create table EmployeePaymentDetails(EmployeeId int,EmployeeName varchar(25)not null,EmployeePhoneNumber varchar(10) primary key,EmployeeDepartment varchar(20)not null,
--EmployeeDesignation varchar(20)not null,PresentDays int not null,Absentdays int not null,BasicPay int not null,HouseRentAllowance int,BonusAmount int,EmployeeProvidentFund int not null,Salary int not null,SalaryDate varchar(20) not null,Performance varchar(20) not null,foreign key (EmployeeId) references EmployeeDetails (EmployeeId)ON DELETE CASCADE ON UPDATE CASCADE);

--select * from EmployeePaymentDetails;


--select E.Employee_Id,E.Employee_Name,E.Gender,P.Mobile_Number,P.Email,E.Employee_Dob,E.Employee_Join_date,P.Department,P.Designation,P.SalaryDate,P.PresentDays,P.Salary,P.Performance,E.Employee_Address from Employee E inner join EmployeeDataSheet p on E.Employee_Ph_no=P.Mobile_Number where E.Employee_Ph_no='9809097788';


--Create table EmployeeSuggestionDetails(EmployeeId int,EmployeeName varchar(30) not null,EmployeePhoneNumber varchar(10) primary key,EmployeeEmail varchar(40) not null,SuggestionDate varchar(20) not null,SuggestionName varchar(50) not null,SuggestionDescription varchar(300) not null,foreign key (EmployeeId) references EmployeeDetails (EmployeeId) ON DELETE CASCADE ON UPDATE CASCADE);


--select * from EmployeeSuggestionDetails;



--create table ExEmployeeDetails(
--EmployeeId int primary key,EmployeeName varchar(30)not null,Gender char(1) not null,EmployeeDateOfBirth varchar(15) not null,
--EmployeeAge int not null,EmployeePhoneNumber varchar(10)unique,EmployeeDepartment varchar(20)not null,
--EmployeeDesignation varchar(20)not null,EmployeeExperience int,EmployeeJoindate varchar(15) not null,
--EmployeeEmail varchar(30)unique,EmployeeAddress varchar(100));

--EXEC sp_help 'sampledb.EmployeeDetails';
--exec sp_helpdb sampledb;
