-- Ovo je SQL skripta webshop

use master;
go

drop database if exists webshop;
go

create database webshop collate Croatian_CI_AS;
go

use webshop;
go

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
datum_nabave datetime,
cijena decimal (10,2),
aktivan bit
);

create table racuni(
sifra int not null primary key identity(1,1),
datum datetime,
kupac varchar(100) not null,
status bit
);

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(100) not null,
prezime varchar(100) not null,
ulica varchar(100) not null,
mjesto varchar(100) not null
);

create table stavke(
sifra int not null primary key identity(1,1),
racun int not null references racuni(sifra),
proizvod int not null references proizvodi(sifra),
kolicina int not null,
cijena decimal(10,2) null
);