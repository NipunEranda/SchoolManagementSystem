create procedure roles_insert
@name varchar(50),
@status tinyint
as
insert into roles values(@name, @status)

create procedure roles_update
@name varchar(50),
@status tinyint,
@roleId int
as
update roles
set roleName = @name,
status = @status
where
roleId = @roleId

create procedure roles_delete
@roleId int
as
delete from roles where roleId = @roleId

create procedure roles_getRoles
as
select r.roleId as 'ID', r.roleName  as 'Role',
case when (r.status = 1) then 'Active' else 'In-active' end as 'Status'
from roles r

create procedure roles_Search
as
select r.roleId as 'ID', r.roleName  as 'Role',
case when (r.status = 1) then 'Active' else 'In-active' end as 'Status'
from roles r where r.roleName LIKE '%' + @name + '%'

create function getRoleId() returns int
begin
declare @ID int
declare @status tinyint
declare @i int
declare @max int
set @status = 0
set @i = 1
select @max = max(roleId) from roles
if(@max is null)
set @ID = 1
while(@i <= @max)
begin
	if((select roleName from roles where roleId = @i) is null)
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

