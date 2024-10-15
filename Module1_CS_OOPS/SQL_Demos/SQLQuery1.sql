create database CGIDB

go

create table employee
(
	ecode int,
	ename varchar(25),
	salary int,
	deptid int
)

--to add more columns
alter table employee add city varchar(20)

--to remove a columns
alter table employee drop column city

--alter the column size
alter table employee alter column ename varchar(20)

--deleting the table
drop table employee   --be sure before use


--inserting records
insert into employee(ecode,ename,salary,deptid) 
			values(101,'Ravi',1111,201)

insert into employee(ecode,ename,salary,deptid) 
			values(103,'Rakesh',3333,203),
				(104,'Suresh',4444,203),
				(105,'John',5555,205)

--0 is not same as null or ''

--insert in fewer columns
insert into employee(ecode,salary) values(106,666)

--deleting all the records 
delete from employee   --careful as it deletes all the records 

--delete selected records based on condition(s)
delete from employee where ecode=105

--deleting records based on null value
delete from employee where deptid is null

delete from employee where salary>2000 and deptid=202

<,<=,>,>=,!=,=,
and , or , not

--modifying the existing records
update employee set salary =salary + 1000 where ecode=103

update employee set salary =salary + 1000,deptid=204 where ecode=103


--selecting all the records and all columns
select * from employee

--selecting only few columns
select ecode,ename from employee

--selecting filtered records
select * from employee where salary>2000

--getting computed columns
select *, 0.1*salary as [Bonus of emp] from employee

--constraints:- are the rules and restructions on the table to 
--maintain correct data inside the database

--1)PRIMARY KEY:- this maintains the records unique in the table, 
--duplicate value is not allowed, null value also not allowed.
--per table only one primary key is allowed

drop table test

create table test
(
	ecode int,
	ename varchar(20),
	salary int 
	constraint pk1 primary key(ecode)
)

--2) CHECK constraints:- it allows only acceptable values, also called domain
--constraint.
drop table test
create table test
(
	ecode int primary key,
	ename varchar(20),
	salary int check(salary between 5000 and 10000),
	deptid int check(deptid in (201,203,205)),
	gender char(1) check(gender='M' or gender='F'),
	city varchar(20) check(city in ('BLR','CHN','DLI'))
)

insert into test values(101,'ravi',8000,'M','BLR')

--3) UNIQUE constraint:- This is to maintain unique values in a 
--column of a table.
--it allows one null value at max
--can have more than one unique constraint
drop table test
create table test
(
 ecode int primary key,
 ename varchar(20) not null,
 phno char(10) unique,
 email varchar(25) unique
)

primary = unique + not null


4) NULL/NOT NULL:- if a column value is mandatory , NOT NULL is used
--default in sql server is null

insert into test(ecode,phno) values(101,'9986017462')

5) DEFAULT constraint:- to specify some default value to a column
--if not specified while inserting
drop table test
create table test
(
ecode int primary key,
salary int default 5000,
city varchar(10) default 'BLR'
)
insert into test values(101,1000,'HYD')
insert into test(ecode,salary) values(102,2000)
insert into test(ecode) values(103)

6) FOREIGN KEY constraint:- It is a referential integrity constraint
--which makes sure that the value is already existing somewhere 
--in the database.

create table dept
(
deptid int primary key,
dname varchar(10)
)

create table emp
(
ecode int primary key,
ename varchar(20),
deptid int 
constraint fk1 foreign key(deptid) references dept(deptid)
)

select * from dept
select * from emp

insert into dept values(201,'account')
insert into dept values(202,'admin')
insert into dept values(203,'sales')


insert into emp values(101,'ravi',201)


insert into emp values(102,'raman',201)
insert into emp values(103,'rakesh',204)
insert into emp values(104,'david',202)




select * from test







employee---ecode(pk),ename,salary,deptid,phno(unique),emailid(unique)

customer---->emailid,phno,cid,cname,city

bank----->savingsaccount (accno,emailid,phno,cid,cname,city)



insert into test values(101,'Ravi',1111)

select * from test

select * from employee

insert into employee values(101,'ramnath',5555,201)


--sorting the records
select * from employee order by salary desc, deptid desc

--select distinct records
select distinct ecode,deptid from employee

--grouping and group functions
select sum(salary) as TotalSal,
avg(isnull(salary,0)) as AvgSal,
max(salary) as MaxSal,
min(salary) as MinSal,
count(isnull(salary,0)) as NoOfEmps
from employee

--Note: group functions ignore null values
select * from employee


select deptid,sum(salary) as TotalSal,
avg(isnull(salary,0)) as AvgSal,
max(salary) as MaxSal,
min(salary) as MinSal,
count(isnull(salary,0)) as NoOfEmps
from employee
group by deptid
having avg(isnull(salary,0))>2000
order by max(salary) desc

--Note: in group by only either group column is taken and/or group functions are allowed

--pattern matching operator for character data
LIKE is used as pattern matching operator along with :
 %-----is for multiple any character replacement
 _ -----underscore is used for any single-character replacement

 select * from employee where ename like '%i%'
 select * from employee where ename like 'R____' 


 ------------Nested query--------------
 --query within a query
 --Q. find the employees working in deptid of the employee whose ecode is 105
 select * 
 from employee 
 where deptid in (select deptid 
			      from employee 
			      where ecode=105)

--Join query:- These queries are used to join records from multiple tables
--which scattered due to normalization.

--Types of joins:-
--a) INNER Join:- In thise query we get only matching records from the joined 
--tables. Non matching records based on joining conditions will be ignored



syntax=>
	select e.ecode,e.ename,e.salary,d.deptid,d.dname
	from employee as e
	join dept as d
	on (e.deptid=d.deptid)

	--OR

	select e.ecode,e.ename,e.salary,d.deptid,d.dname
	from employee as e,dept as d
	where (e.deptid=d.deptid)


--b) OUTER Joins:-
--i) LEFT OUTER JOIN:- matching from both the tables and non-matching from 
--left side table
syntax =>

	select * from employee
	select * from dept

	select e.ecode,e.ename,e.salary,d.deptid,d.dname
	from employee as e
	left outer join dept as d
	on (e.deptid=d.deptid)


--ii) RIGHT OUTER JOIN:-matching from both the tables and non-matching from 
--right side table
syntax =>

	select * from employee
	select * from dept

	select e.ecode,e.ename,e.salary,d.deptid,d.dname
	from employee as e
	right outer join dept as d
	on (e.deptid=d.deptid)
--iii) FULL OUTER JOIN:-these considers non matching records also from both side
--tables
	select e.ecode,e.ename,e.salary,d.deptid,d.dname
	from employee as e
	full outer join dept as d
	on (e.deptid=d.deptid)



--SELF-JOIN:- It is a special case of inner join when a table is joined
--with itself

	select * from dept
	select * from employee













select ecode,ename,isnull(salary,0),deptid from employee


insert into employee values(105,'Rohit',null,201)
