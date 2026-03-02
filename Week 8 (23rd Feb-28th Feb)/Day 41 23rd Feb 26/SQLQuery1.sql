create database BankDB;
use BankDB;

create table Employeetb(
EmpId int,EmpName varchar(20),EmpDesg varchar(50),
EmpDOJ datetime,EmpSal int,EmpDept int
)

insert into Employeetb values(101,'krishna','ProjManger',
7-8-2010,45000,10)
insert into Employeetb values(102,'kumari','Manger',
6-8-2010,50000,20)
insert into Employeetb values(103,'Amit','Manger',
7-9-2010,44000,30)
insert into Employeetb values(101,'krishna','ProjManger',
7-5-2010,55000,20)

DROP PROC IF EXISTS SP_DelRec
GO
create Proc SP_DelRec @PEmpId INT
as
begin
Delete Employeetb where EmpId=105
end
GO

drop proc SP_DelRec

DROP PROC IF EXISTS sp_DelRecP
GO
create proc sp_DelRecP @Pempno int
as
begin
Delete Employeetb where EmpId=@Pempno
end

DROP PROC IF EXISTS SPEmp_Insert
GO
create proc SPEmp_Insert(@PEmpId int,
@PEmpName varchar(20),@PEmpDesg varchar(50)
,@PEmpDOJ datetime,@PEmpSal int,
@PEmpDept int)
as
Begin
insert into Employeetb values(@PEmpId,
@PEmpName,@PEmpDesg,@PEmpDOJ,@PEmpSal,
@PEmpDept)
end

DROP PROC IF EXISTS SPEmp_Update
GO
create proc SPEmp_Update(@PEmpId int,
@PEmpName varchar(20),@PEmpDesg varchar(50),
@PEmpDOJ datetime,@PEmpSal int,@PEmpDept int)
as
begin
update Employeetb set EmpName=@PEmpName,
EmpDesg=@PEmpDesg,EmpDOJ=@PEmpDOJ,
EmpSal=@PEmpSal,EmpDept=@PEmpDept 
where EmpId=@PEmpId
end

drop proc SPEmp_Update

DROP PROC IF EXISTS SPEmp_Del
GO
create proc SPEmp_Del @PEmpId int
as
begin
Delete Employeetb where EmpId=@PEmpId
end

DROP PROC IF EXISTS SPGetSal
GO
create proc SPGetSal (@PEmpId int,
@PEmpSal int output) 
as begin
Select @PEmpSal=Empsal from Employeetb 
where EmpId=@PEmpId
End

drop proc SPGetSal

DROP PROC IF EXISTS SPGetData
GO
create proc SPGetData @PEmpId int,
@PEmpName varchar(50)Output,
@PEmpDesig varchar(50)Output,
@PEmpDOJ datetime Output,@PEmpSal int Output,
@PEmpDept int Output 
as Begin
select @PEmpName=EmpName,@PEmpDesig=EmpDesg,
@PEmpDOJ=EmpDOJ,@PEmpSal=EmpSal,
@PEmpDept=EmpDept from Employeetb 
where EmpId=@PEmpId
end

drop proc SPGetData



