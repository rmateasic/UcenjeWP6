-- ovo je SQL skripta sport

use master;
go

drop database if exists sport;
go

create database sport;
go


use sport;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime,
stadion varchar(50) not null,
predsjednik varchar(50) not null,
drzava varchar(50) not null,
liga varchar(50) not null
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime,
vrijeme datetime,
lokacija varchar(50) not null,
stadion varchar(50) not null,
domaci_klub int not null references klub(sifra),
gostujuci_klub int not null references klub(sifra)
);