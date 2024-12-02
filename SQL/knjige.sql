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

create table osobe(
sifra int not null primary key identity(11,11),
ime varchar(50) not null,
prezime varchar(50) not null,
adresa varchar(50) not null,
email varchar(50) not null,
);

create table knjige(
sifra int not null primary key identity(11,11),
naslov varchar(50) not null,
pisac varchar(50) not null,
vlasnik int not null references vlasnik(sifra),
clan int not null references clan(sifra),
datumpos datetime,
datumvrac datetime
);