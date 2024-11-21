-- Ovo je SQL skripta tipovi auta

use master;
go

drop database if exists tipoviauta;
go

create database tipoviauta collate Croatian_CI_AS;
go

use tipoviauta;
go

create table proizvodjaci(
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
godiste int,
serija varchar(100),
proizvodjaci int not null references proizvodjaci(sifra),
vrsteauta int not null references vrsteauta(sifra)
);

insert into proizvodjaci(naziv, zemlja)
values
--1
('Bmw', 'Njemačka'),
--2
('Mercedes', 'Njemačka'),
--3
('Ferrari', 'Italija'),
--4
('Alfa_romeo', 'Italija'),
--5
('Cupra', 'Španjolska'),
--6
('Seat', 'Španjolska'),
--7
('Renault','Francuska'),
--8
('Peugeot', 'Francuska');

insert into vrsteauta(naziv)
values
(1),(2),(3),(4),(5),(6),(7),(8);

insert into automobili(nazivauta, gorivo, model, godiste, serija, proizvodjaci, vrsteauta)
values
(1, 'hibrid', 'serija1', null, null, 1, 1), (1, 'hibrid', 'serija2', null, null, 1, 1),
(1, 'hibrid', 'serija3', null, null, 1, 1), (1, 'hibrid', 'serija4', null, null, 1, 1),
(1, 'hibrid', 'serija5', null, null, 1, 1), (1, 'hibrid', 'serija6', null, null, 1, 1),
(1, 'hibrid', 'serija7', null, null, 1, 1), (1, 'hibrid', 'serija8', null, null, 1, 1),
(2, 'hibrid', 'Aklasa', null, null, 2, 2), (2, 'hibrid', 'Bklasa', null, null, 2, 2),
(2, 'hibrid', 'Cklasa', null, null, 2, 2), (2, 'hibrid', 'Eklasa', null, null, 2, 2),
(2, 'hibrid', 'Sklasa', null, null, 2, 2), (3, 'hibrid', 'F40', null, null, 3, 3),
(3, 'hibrid', 'F50', null, null, 3, 3), (3, 'hibrid', 'Dino', null, null, 3, 3),
(3, 'hibrid', 'Enzo', null, null, 3, 3), (4, 'hibrid', 'Giulia', null, null, 4, 4), 
(4, 'hibrid', 'Giulietta', null, null, 4, 4), (4, 'hibrid', 'Spider', null, null, 4, 4),
(4, 'hibrid', 'Stelvio', null, null, 4, 4), (4, 'hibrid', 'GTV', null, null, 4, 4),
(5, 'hibrid', 'Alteca', null, null, 5, 5), (5, 'hibrid', 'Born', null, null, 5, 5),
(5, 'hibrid', 'Formentor', null, null, 5, 5), (5, 'hibrid', 'Leon', null, null, 5, 5),
(6, 'hibrid', 'Ibiza', null, null, 6, 6), (6, 'hibrid', 'Cordoba', null, null, 6, 6),
(6, 'hibrid', 'Malaga', null, null, 6, 6), (6, 'hibrid', 'Toledo', null, null, 6, 6),
(7, 'hibrid', 'Megan', null, null, 7, 7), (7, 'hibrid', 'Talisman', null, null, 7, 7),
(7, 'hibrid', 'Capture', null, null, 7, 7), (7, 'hibrid', 'Fluence', null, null, 7, 7),
(8, 'hibrid', '208', null, null, 8, 8), (8, 'hibrid', '308', null, null, 8, 8),
(8, 'hibrid', '408', null, null, 8, 8), (8, 'hibrid', '508', null, null, 8, 8),
(8, 'hibrid', '2008', null, null, 8, 8), (8, 'hibrid', '3008', null, null, 8, 8),
(8, 'hibrid', '4008', null, null, 8, 8), (8, 'hibrid', '5008', null, null, 8, 8);
