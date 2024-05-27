create table adminn
(
	admin_id int primary key,
	username varchar (50),
	admin_password varchar(50)
);

create table employee
(
	employee_id int primary key,
	username varchar (50),
	age int,
	salary int
);

insert into adminn values (01,'mohamed','mohamed612');
insert into adminn values (02,'taghred','taghred153');
insert into adminn values (03,'selem','selem123');
insert into adminn values (04,'hoor','hoor456');
insert into employee values (11,'reem',20,100);
insert into employee values (12,'ahmed',30,500);
insert into employee values (13,'saged',34,60);
insert into employee values (14,'sagda',43,06);