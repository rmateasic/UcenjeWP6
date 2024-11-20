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

insert into proizvodjac(naziv, zemlja)
values
--1
('Bmw', 'Njemacka'),
--2
('Mercedes', 'Njemacka'),
--3
('Ferrari', 'Italija'),
--4
('Alfa_romeo', 'Italija'),
--5
('Cupra', 'Spanjolska'),
--6
('Seat', 'Spanjolska'),
--7
('Renault','Francuska'),
--8
('Peugeot', 'Francuska');

insert into vrsteauta(naziv)
values
(1),(2),(3),(4),(5),(6),(7),(8);

insert into automobili(nazivauta, gorivo, model, godiste, serija, proizvodjac, vrsteauta)
values
('1', 'hibrid', 'serija1', null, null, '1', '1'), ('1', 'hibrid', 'serija2', null, null, '1', '1'),
('1', 'hibrid', 'serija3', null, null, '1', '1'), ('1', 'hibrid', 'serija4', null, null, '1', '1'),
('1', 'hibrid', 'serija5', null, null, '1', '1'), ('1', 'hibrid', 'serija6', null, null, '1', '1'),
('1', 'hibrid', 'serija7', null, null, '1', '1'), ('1', 'hibrid', 'serija8', null, null, '1', '1'),
('2', 'hibrid', 'Aklasa', null, null, '2', '2'), ('2', 'hibrid', 'Bklasa', null, null, '2', '2'),
('2', 'hibrid', 'Cklasa', null, null, '2', '2'), ('2', 'hibrid', 'Eklasa', null, null, '2', '2'),
('2', 'hibrid', 'Sklasa', null, null, '2', '2'), ('3', 'hibrid', 'F40', null, null, '3', '3'),
('3', 'hibrid', 'F50', null, null, '3', '3'), ('3', 'hibrid', 'Dino', null, null, '3', '3'),
('3', 'hibrid', 'Enzo', null, null, '3', '3');
