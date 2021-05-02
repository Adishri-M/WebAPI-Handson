create database StudentDB;
GO
Use StudentDB
GO
Create table Students(
ID int primary key identity,
FirstName nvarchar(50)not null,
LastName nvarchar(30)not null,
Gender nvarchar(15)not null,
Address nvarchar(200)not null)
go
Insert into Students values('Jerome','Smith','Male',13)
Insert into Students values('Peter','Cursie','Male',12)
Insert into Students values('Sam','Allen','Female',13)
Insert into Students values('Leo','Son','Male',12)
Insert into Students values('Mary','Williams','Female',12)
Go

select * from Students