
create table Emp(
eid int,
ename varchar(20),
eage int
)
sp_help Emp
alter table Emp drop column ename 
alter table Emp add ename varchar(40)
alter  table Emp alter column ename varchar(20)