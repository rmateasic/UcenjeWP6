-- Ovo je SQL skripta tipovi auta

use master;
go

drop database if exists tipoviauta;
go

create database tipoviauta collate Croatian_CI_AS;
go

use tipoviauta;
go

create table proizvodjac(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
zemlja varchar(100) not null
);

create table vrsteauta(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null
);

create table automobili(
sifra int not null primary key identity(1,1),
nazivauta varchar(100) not null ,
gorivo varchar(100) not null,
model varchar(100) not null,
godiste datetime,
serija varchar(100),
proizvodjac int not null references proizvodjac(sifra),
vrsteauta int not null references vrsteauta(sifra)
);

insert into proizvodjac (naziv, zemlja)
values 
('ime_auta', 'ime_zemlje');

insert into vrsteauta(naziv)
values
('serija');
