--TSQL(Transact-SQL): set of sql statements combined with some 
--programming clauses to do some task in database. It is like sql script
--based procedural programming.
sql---sql engine---parse + compile+ execute

--Note : predefined environment variables are reffered using @@
--e.g select @@Version

--declaring variables
declare @n1 int, @n2 int,@result int
--assigning values to variables
select @n1=100,@n2=200
select @result=@n1 + @n2
--display the result
select @n1 as Num1,@n2 as Num2,@result as Result
--print 'sum of ' + convert(varchar(5),@n1) + ' and ' + convert(varchar(5),@n2) + ' is ' + convert(varchar(5),@result)

------------------Stored Procedure----------------
--It is block of TSQL statements which stored with some name in database.
--Stored procedures are compiled and stored in database, we can just call
--and execute them so it is faster than submitting adhoc statement.
--*it can be shared in multiple applications and it database.
--since it is database object, we can have permissions on it.
--Note: Stored procedures do not return value so there is no return type
syntax=>

--to create stored procedure:
create or alter procedure sp_add_numbers(@n1 int,@n2 int)
as
declare @result int
select @result=@n1 + @n2
--display the result
select @n1 as Num1,@n2 as Num2,@result as Result


--to execute stored procedure
exec sp_add_numbers 4,2


--Q. create a stored procedure which takes ecode as parameter and displays
--details of the employee along with bonus as 10% if salary>5000 else 20%.
create or alter procedure sp_calc_bonus(@ec int)
as
declare @en varchar(20),@sal int,@did int, @bonus numeric(5,2)

if exists(select * from employee where ecode=@ec)
begin
	--select the employee record from table
	select @en=ename,@sal=salary,@did=deptid from employee where ecode=@ec
	--calculate bonus
	if @sal>5000
	begin --mandator of more than one statements are in the if block
		select @bonus=0.1*@sal
	end
	else
		select @bonus=0.2*@sal
	--display the details
	select @ec as Ecode,@en as Ename, @sal as Salary,@did as Deptid,@bonus as Bonus
end
else
begin
	print 'ecode does not exist'
end




exec sp_calc_bonus 102


-----parameter direction in stored procedure-------
--1)INPUT:- it is default direction of parameters passed in stored procedure
--means it will pass the copy of the variable. So any changes done with the 
--parameter will not reflect in the parent block once it comes out of the 
--procedure.
--2) OUTPUT:- When a parameter is passed with OUTPUT direction then 
--address or reference of the parameter is passed, hence changes to the
--value of the parameter will retain after coming out of the Stored procedure.

e.g.
create or alter procedure sp_get_emp_salary(@ec int,@sal int output)
as
select @sal=salary from employee where ecode=@ec




declare @ecode int, @salary int=0
select @ecode=104
exec sp_get_emp_salary @ecode,@salary output
select @ecode as Ecode,@salary as Salary

--to remove stored procedure from DB
drop procedure sp_add_numbers

------------------User-defined function-----
--These are also block of TSQL statements like Stored procedure but it also 
--returns value so it has return type also.

create or alter function fn_getbonus(@salary int) returns int
as
begin
	declare @bonus int
	if @salary >5000
		select @bonus=0.1*@salary
	else
		select @bonus=0.2*@salary

	return @bonus
end


--calling a function
select dbo.fn_getbonus(4000) as Bonus



declare @sal int ,@bonus int
select @sal=7000
select @bonus=dbo.fn_getbonus(@sal)
select @sal as Salary,@bonus as Bonus




select *,dbo.fn_getbonus(salary) as Bonus from employee




-----Identity column--------------------
order----->order id column 

create table [order]
(
	id int primary key identity(1,1),
	order_date datetime,
	qty int
)

select * from [order]

insert into [order] values(getdate(),5)

select @@identity




---looping in TSQL-----
create or alter procedure sp_display(@n int)
as
declare @i int, @p int
select @i=1
while @i<=10
begin
	select @p=@n*@i
	print @p
	select @i=@i+1
end


exec sp_display 5


--creating TABLE-VALUED functions
alter function fn_getemps(@did int) returns TABLE
as
return (select ename 
		from employee
		where deptid=@did)


--calling TABLE-VALUED function
select * from dbo.fn_getemps(201)