create database DBBoards
go

use DBBoards
go

create table Board
(
	BoardId		uniqueidentifier		primary key,
	Name		varchar(max)			not null
)
go

create table Interation
(
	InterationId	uniqueidentifier	primary key,
	BoardId			uniqueidentifier	not null,
	Name			varchar(max)		not null,
	StartDate		datetime			not null,
	EndDate			datetime			not null
	constraint FK_BoardInteration
	foreign key (BoardId) references Board(BoardId)
)
go

insert into Board values (NEWID(), 'Board 1')
go

insert into Interation 
	values (NEWID(),
	'9EC0DDA0-6326-4AFD-B127-4D635A8E0BCA',
	'Interation 1',
	GETDATE(),
	GETDATE() + 1
	)
go

select * from Board
go

select * from Interation
go

select * from Interation INNER JOIN Board ON Interation.BoardId = Board.BoardId
go

create view interations as
	select InterationId,
			Board.BoardId,
			Interation.Name,
			StartDate,
			EndDate,
			Board.Name as BoardName
		from Interation
		INNER JOIN Board ON Interation.BoardId = Board.BoardId

select * from interations



