CREATE TABLE payment_info_tb(
	Id bigint not null primary key identity(1,1),
	EmployeeId bigint not null foreign key references employee_tb(Id),
	GenerateOn date not null,
	OT money not null default 0,
	Bonus money not null default 0,
	Deduction money not null default 0,
	Total money not null
);