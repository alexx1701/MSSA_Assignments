use SQL_ProjectWareHouse;

select * from sys.tables;

create table Warehouse (
	warehouseID int,
	place varchar(100),
	capacity int
	PRIMARY KEY (warehouseID) --warehouseId int IDENTITY(1,1) PRIMARY KEY 
)

create table Boxes (
	refNumber char(5),
	content varchar(100),
	amount int,
	warehouseID int FOREIGN KEY REFERENCES Warehouse(warehouseId)
	PRIMARY KEY (refNumber)
)
alter table Warehouses
add city varchar(80)
drop table Boxes

insert into Warehouses (warehouseID, city)
values (1, 'Austin')
insert into Warehouses (warehouseID, city)
values (2, 'Tokyo')
insert into Warehouses (warehouseID, city)
values (3, 'Atlanta')
insert into Warehouses (warehouseID, city)
values (4, 'San Diego')
insert into Warehouses (warehouseID, city)
values (5, 'Miami')
insert into Warehouses (warehouseID, city)
values (6, 'London')

insert into Boxes (refNumber, warehouseID)
values (1, 1)
insert into Boxes (refNumber, warehouseID)
values (2, 4)
insert into Boxes (refNumber, warehouseID)
values (3, 3)
insert into Boxes (refNumber, warehouseID)
values (4, 3)
insert into Boxes (refNumber, warehouseID)
values (5, 2)
insert into Boxes (refNumber, warehouseID)
values (6, 1)
insert into Boxes (refNumber, warehouseID)
values (7, 5)
insert into Boxes (refNumber, warehouseID)
values (8, 6)
insert into Boxes (refNumber, warehouseID)
values (9, 6)
insert into Boxes (refNumber, warehouseID)
values (10, 2)

select * from Warehouse

update Boxes
set amount = (200)

insert into Warehouse (warehouseId, capacity, city)
values (7, 5, 'Barcelona')

insert into Boxes (refNumber, wareHouseID, content, amount)
values (11, 3, 'Paper', 3500)