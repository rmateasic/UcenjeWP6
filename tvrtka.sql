-- Ovo je SQL skripta tvrtka

use master;
go

drop database if exists tvrtka;
go

create database tvrtka collate Croatian_CI_AS;
go

use tvrtka;
go

create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(100) not null,
prezime varchar(100) not null,
datum_rodenja datetime,
placa decimal (10,2),
invalid bit
);

create table slike(
sifra int not null primary key identity(1,1),
zaposlenik int not null references zaposlenici(sifra),
redni_broj int not null,
putanja varchar(100),
);
