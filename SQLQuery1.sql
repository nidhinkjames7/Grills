create procedure sp_registration @reg_id int=0,@fullname varchar(50)='',@address varchar(100)='',@dob date='',@email varchar(50)='',@phoneno numeric(18,0)='',@username varchar(50)='',@password varchar(50)='',@cpassword varchar(50)='',@flag  int=0
as
	if(@flag=0)
begin
	insert into registration values(@fullname,@address,@dob,@email,@phoneno,@username,@password,@cpassword)
end
if(@flag=1)
begin
	select * from registration
end