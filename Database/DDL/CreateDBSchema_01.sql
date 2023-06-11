drop database if exists DndOverlord
go

create database DndOverlord
go

use [DndOverlord]
go

create table Characters(
    CharacterID bigint,
    ClassID bigint,
    Name varchar(50),
    Bio nvarchar(500)
)
go

create table Races(
    RaceID bigint,
    Name varchar(50),
    
)

create table Classes(
    ClassID bigint,
    ClassName varchar(50)
)
go

