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
('serija1'), ('serija2'), ('serija3'), ('serija4'), ('serija5'), ('serija6'), ('serija7'), ('serija8'), 
('Aklasa'), ('Bklasa'), ('Cklasa'), ('Eklasa'), ('Sklasa'), 
('F40'), ('F50'), ('Dino'), ('Enzo'), 
('Giulia'), ('Giulietta'), ('Spider'), ('Stelvio'), ('GTV'), 
('Alteca'), ('Born'), ('Formentor'), ('Leon'), 
('Ibiza'), ('Cordoba'), ('Malaga'), ('Toledo'), 
('Megan'), ('Talisman'), ('Capture'), ('Fluence'), 
('208'), ('308'), ('408'), ('508'), 
('2008'), ('3008'), ('4008'), ('5008');


insert into automobili(nazivauta, gorivo, model, godiste, proizvodjaci, vrsteauta)
values
('Bmw', 'hibrid', 'serija1', null, 1, 1), ('Bmw', 'hibrid', 'serija2', null, 1, 1),
('Bmw', 'hibrid', 'serija3', null, 1, 1), ('Bmw', 'hibrid', 'serija4', null, 1, 1),
('Bmw', 'hibrid', 'serija5', null, 1, 1), ('Bmw', 'hibrid', 'serija6', null, 1, 1),
('Bmw', 'hibrid', 'serija7', null, 1, 1), ('Bmw', 'hibrid', 'serija8', null, 1, 1),
('Mercedes', 'hibrid', 'Aklasa', null, 2, 2), ('Mercedes', 'hibrid', 'Bklasa', null, 2, 2),
('Mercedes', 'hibrid', 'Cklasa', null, 2, 2), ('Mercedes', 'hibrid', 'Eklasa', null, 2, 2),
('Mercedes', 'hibrid', 'Sklasa', null, 2, 2), ('Ferrari', 'hibrid', 'F40', null, 3, 3),
('Ferrari', 'hibrid', 'F50', null, 3, 3), ('Ferrari', 'hibrid', 'Dino', null, 3, 3),
('Ferrari', 'hibrid', 'Enzo', null, 3, 3), ('Alfa_romeo', 'hibrid', 'Giulia', null, 4, 4), 
('Alfa_romeo', 'hibrid', 'Giulietta', null, 4, 4), ('Alfa_romeo', 'hibrid', 'Spider', null, 4, 4),
('Alfa_romeo', 'hibrid', 'Stelvio', null, 4, 4), ('Alfa_romeo', 'hibrid', 'GTV', null, 4, 4),
('Cupra', 'hibrid', 'Alteca', null, 5, 5), ('Cupra', 'hibrid', 'Born', null, 5, 5),
('Cupra', 'hibrid', 'Formentor', null, 5, 5), ('Cupra', 'hibrid', 'Leon', null, 5, 5),
('Seat', 'hibrid', 'Ibiza', null, 6, 6), ('Seat', 'hibrid', 'Cordoba', null, 6, 6),
('Seat', 'hibrid', 'Malaga', null, 6, 6), ('Seat', 'hibrid', 'Toledo', null, 6, 6),
('Renault', 'hibrid', 'Megan', null, 7, 7), ('Renault', 'hibrid', 'Talisman', null, 7, 7),
('Renault', 'hibrid', 'Capture', null, 7, 7), ('Renault', 'hibrid', 'Fluence', null, 7, 7),
('Peugeot', 'hibrid', '208', null, 8, 8), ('Peugeot', 'hibrid', '308', null, 8, 8),
('Peugeot', 'hibrid', '408', null, 8, 8), ('Peugeot', 'hibrid', '508', null, 8, 8),
('Peugeot', 'hibrid', '2008', null, 8, 8), ('Peugeot', 'hibrid', '3008', null, 8, 8),
('Peugeot', 'hibrid', '4008', null, 8, 8), ('Peugeot', 'hibrid', '5008', null, 8, 8);
