create table Teacher(
tid bigint not null,
firstName varchar(50) not null,
lastName varchar(50) not null,
birthDate varchar(50) not null,
telephone varchar(10) not null,
address varchar(100) not null,
image image,
constraint teacher_pk primary key(tid))