USE [sms]
GO
/****** Object:  StoredProcedure [dbo].[student_advanceSearch]    Script Date: 7/24/2019 2:32:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[student_advanceSearch]
@nic varchar(20),
@sid bigint,
@fName varchar(50),
@lName varchar(50),
@gradeId int,
@classId int
as
if(@nic is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic LIKE '%' + @nic + '%' 

else if(@sid is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class' 
	from student s where sid = @sid

else if(@fName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName

/*else if(@lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where lastName = @lName
end
else if(@gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where gradeId = @gradeId

else if(@classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where classId = @classId

else if(@nic is not null and @sid is not null and @fName is not null and @lName is not null and @gradeId is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and lastName = @lName and gradeId = @gradeId and classId = @classId

else if(@nic is not null and @sid is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid

else if(@nic is not null and @fName is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and firstName = @fName

else if(@nic is not null and @lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and lastName = @lName

else if(@nic is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and gradeId = @gradeId

else if(@nic is not null and @classId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class' 
	from student s where nic = @nic and classId = @classId

else if(@sid is not null and @fName is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName

else if(@sid is not null and @lName is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and lastName = @lName

else if(@sid is not null and @gradeId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and gradeId = @gradeId

else if(@sid is not null and @classId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and classId = @classId

else if(@fName is not null and @lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and lastName = @lName

else if(@fName is not null and @gradeId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and gradeId = @gradeId

else if(@fName is not null and @classId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and classId = @classId

else if(@lName is not null and @gradeId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where lastName = @lName and gradeId = @gradeId
end
else if(@lName is not null and @classId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where lastName = @lName and classId = @classId
end
else if(@gradeId is not null and @classId is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where gradeId = @gradeId and classId = @classId
end
else if(@nic is not null and @sid is not null and @fName is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName
end
else if(@nic is not null and @sid is not null and @lName is not null)
	
	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and lastName = @lName
end
else if(@nic is not null and @sid is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and gradeId = @gradeId
end
else if(@nic is not null and @sid is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and classId = @classId
end
else if(@nic is not null and @fName is not null and @lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and firstName = @fName and lastName = @lName
end
else if(@nic is not null and @fName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and firstName = @fName and gradeId = @gradeId
end
else if(@nic is not null and @fName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and firstName = @fName and classId = @classId
end
else if(@nic is not null and @lName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and lastName = @lName and gradeId = @gradeId
end
else if(@nic is not null and @lName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and lastName = @lName and classId = @classId
end
else if(@nic is not null and @gradeId is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and gradeId = @gradeId and classId = @classId
end
else if(@sid is not null and @fName is not null and @lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName and lastName = @lName
end
else if(@sid is not null and @fName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName and gradeId = @gradeId
end
else if(@sid is not null and @fName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName and classId = @classId
end
else if(@fName is not null and @lName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and lastName = @lName and gradeId = @gradeId
end
else if(@fName is not null and @lName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and @lName = @lName and classId = @classId
end
else if(@lName is not null and @gradeId is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where lastName = @lName and gradeId = @gradeId and classId = @classId
end
else if(@nic is not null and @sid is not null and @fName is not null and @lName is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and lastName = @lName
end
else if(@nic is not null and @sid is not null and @fName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and gradeId = @gradeId
end
else if(@nic is not null and @sid is not null and @fName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and classId = @classId
end
else if(@sid is not null and @fName is not null and @lName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName and lastName = @lName and gradeId = @gradeId
end
else if(@sid is not null and @fName is not null and @lName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where sid = @sid and firstName = @fName and lastName = @lName and classId = @classId
end
else if(@fName is not null and @lName is not null and @gradeId is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where firstName = @fName and lastName = @lName and gradeId = @gradeId and classId = @classId
end
else if(@nic is not null and @sid is not null and @fName is not null and @lName is not null and @gradeId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and lastName = @lName and gradeId = @gradeId
end
else if(@nic is not null and @sid is not null and @fName is not null and @lName is not null and @classId is not null)

	select s.sid as 'sid', s.nic as 'nic', s.firstName as 'firstName', s.lastName as 'lastName', s.birthdate as 'birthdate', s.telephone as 'telephone', s.address as 'address', case when (s.gender = 1) then 'Male' else 'Female' end as 'gender', (select gradeName from Grades where gradeId = s.gradeId) as 'grade', (select className from Class where classId = s.classId) as 'class'
	from student s where nic = @nic and sid = @sid and firstName = @fName and lastName = @lName and classId = @classId
end*/