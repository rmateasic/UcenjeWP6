-- ovo je SQL skripta knjige

use master;
go

drop database if exists knjige;
go

create database knjige;
go


use knjige;
go

create table clan(
sifra int not null primary key identity(11,11),
clbroj int not null
);

create table vlasnik(
sifra int not null primary key identity(11,11),
knjiga int not null
);