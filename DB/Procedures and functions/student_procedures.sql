/*Insert*/
create procedure student_insert
@nic varchar(50),
@firstName varchar(50),
@lastName varchar(50),
@telephone varchar(10),
@birthDate date,
@address varchar(100),
@gender char(1),
@image image
as
insert into student values(@nic, @firstName, @lastName, @telephone, @birthDate, @address, @gender, @image)

create procedure student_insert_withoutImage
@nic varchar(50),
@firstName varchar(50),
@lastName varchar(50),
@telephone varchar(10),
@birthDate date,
@address varchar(100),
@gender tinyint,
@sid int
as
update student
set
NIC = @nic,
firstName = @firstName,
lastName = @lastName,
telephone = @telephone,
birthDate = @birthDate,
address = @address,
gender = @gender
where
sid = @sid

/*update*/
create procedure student_update
@nic varchar(50),
@firstName varchar(50),
@lastName varchar(50),
@telephone varchar(10),
@birthDate date,
@address varchar(100),
@gender char(1),
@image image,
@sid int
as
update student
set
NIC = @nic,
firstName = @firstName,
lastName = @lastName,
telephone = @telephone,
birthDate = @birthDate,
address = @address,
gender = @gender,
image = @image
where
sid = @sid

/*Update without image*/
create procedure student_update_withoutImage
@nic varchar(50),
@firstName varchar(50),
@lastName varchar(50),
@telephone varchar(10),
@birthDate date,
@address varchar(100),
@gender char(1),
@sid int
as
update student
set
NIC = @nic,
firstName = @firstName,
lastName = @lastName,
telephone = @telephone,
birthDate = @birthDate,
address = @address,
gender = @gender
where
sid = @sid

/*delete*/
create procedure student_delete
@sid int
as
delete from student where sid = @sid

/*getter*/
create procedure student_getStudent
as
select s.sid as 'ID', s.firstName as 'Name' from student s order by s.firstName asc

/*get next student ID*/

create function getStudentId() returns int
begin
declare @ID int
declare @status tinyint
declare @i int
declare @max int
set @status = 0
set @i = 1
select @max = max(sid) from student
if(@max is null)
set @ID = 1
while(@i <= @max)
begin
	if((select firstName from student where sid = @i) is null)
	begin
		set @ID = @i
		set @status = 0
		break
	end
	else
		set @status = 1

	set @i = @i + 1
end
if(@status != 0)
	set @ID = @max + 1
return @ID
end

/*Student Search*/

create procedure student_search
@name varchar(50)
as
select s.sid as 'SID', s.nic  as 'NIC', s.firstName as 'FNAME', s.lastName as 'LNAME', s.birthdate as 'BIRTHDATE', s.address as 'ADDRESS', s.telephone as 'TELEPHONE',
case when (s.gender = 1) then 'Male' else 'Female' end as 'GENDER'
from student s where s.firstName LIKE ('%' + @name + '%') or s.lastName LIKE ('%' + @name + '%')