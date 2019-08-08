//login and get roleId
create procedure systemLogin
@userName varchar(50),
@password varchar(50)
as
select 
u.userName as 'userName',
u.roleId as 'roleId'
from users u
where u.userName = @userName and u.password = @password