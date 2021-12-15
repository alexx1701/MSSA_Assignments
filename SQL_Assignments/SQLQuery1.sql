use SQL_Proj1

select * from sys.tables;

create table CustomerInfo (
	ID int,
	Shipping_Address varchar(50),
	Balance int,
	Credit_Limit int,
	Customer_Number int
	PRIMARY KEY (ID)
)
create table OrderInfo (
	Shipping_Address varchar(50),
	Order_Date varchar(50),
	Item_Number int FOREIGN KEY REFERENCES Item(Item_Number),
	Order_Quantity int,
	CustomerID int FOREIGN KEY REFERENCES CustomerInfo(ID) --create foreign key and then derive from table
)
create table Item (
	Stock int,
	Item_Description varchar(50),
	Item_Number int,
	PRIMARY KEY (Item_Number)
)
select * from CustomerInfo;
drop table OrderInfo;
drop table Item;