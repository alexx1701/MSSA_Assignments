use SQL_Proj2
select * from sys.tables;

create table Teams (
	Player varchar,
	Game varchar,
	Brand varchar
)
create table Player (
	Name varchar,
	Age int,
	Champion varchar
)
create table Game (
	Outcome varchar
)