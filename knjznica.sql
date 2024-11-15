-- ovo je SQL skripta knjiznica

use master;
go

drop database if exists knjiznica;
go

create database knjiznica;
go


use knjiznica;
go

create table autor(
sifra int not null primary key identity(1,1),
ime nvarchar(50) not null,
prezime nvarchar(50) not null,
datumrodenja datetime
);

create table izdavac(
sifra int not null primary key identity(1,1),
naziv nvarchar(50) not null,
aktivan bit
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv nvarchar(50) not null,
postanskiBroj nvarchar(10) not null,
drzava nvarchar(50) not null
);