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
('limuzina'), ('karavan'), ('monovolumen'), ('coupe'), ('kabriolet'), ('suv');


insert into automobili(nazivauta, gorivo, model, godiste, proizvodjaci, vrsteauta)
values
('Bmw', 'hibrid', 'serija1', '2015' 'Bmw', 'monovolumen'), ('Bmw', 'hibrid', 'serija2', '2015', 'Bmw', 'monovolumen'),
('Bmw', 'hibrid', 'serija3', '2018', 'Bmw', 'karavan'), ('Bmw', 'hibrid', 'serija4', '2018', 'Bmw', 'limuzina'),
('Bmw', 'hibrid', 'serija5', '2020', 'Bmw', 'karavan'), ('Bmw', 'hibrid', 'serija6', '2020', 'Bmw', 'coupe'),
('Bmw', 'hibrid', 'serija7', '2022', 'Bmw', 'suv'), ('Bmw', 'hibrid', 'serija8', '2022', 'Bmw', 'kabriolet'),
('Mercedes', 'hibrid', 'Aklasa', '2017', 'Mercedes', 'monovolumen'), ('Mercedes', 'hibrid', 'Bklasa', '2017', 'Mercedes', 'monovolumen'),
('Mercedes', 'hibrid', 'Cklasa', '2019', 'Mercedes', 'limuzina'), ('Mercedes', 'hibrid', 'Eklasa', '2020', 'Mercedes', 'limuzina'),
('Mercedes', 'hibrid', 'Sklasa', '2022', 'Mercedes', 'kabriolet'), ('Ferrari', 'hibrid', 'F40', '2015', 'Ferrari', 'coupe'),
('Ferrari', 'hibrid', 'F50', '2017', 'Ferrari', 'kabriolet'), ('Ferrari', 'hibrid', 'Dino', '2018', 'Ferrari', 'coupe'),
('Ferrari', 'hibrid', 'Enzo', '2020', 'Ferrari', 'suv'), ('Alfa_romeo', 'hibrid', 'Giulia', '2018', 'Alfa_romeo', 'kabriolet'), 
('Alfa_romeo', 'hibrid', 'Giulietta', '2020', 'Alfa_romeo', 'monovolumen'), ('Alfa_romeo', 'hibrid', 'Spider', '2024', 'Alfa_romeo', 'suv'),
('Alfa_romeo', 'hibrid', 'Stelvio', '2024', 'Alfa_romeo', 'suv'), ('Alfa_romeo', 'hibrid', 'GTV', '2023', 'Alfa_romeo', 'kabriolet'),
('Cupra', 'hibrid', 'Alteca', '2020', 'Cupra', 'monovolumen'), ('Cupra', 'hibrid', 'Born', '2022', 'Cupra', 'coupe'),
('Cupra', 'hibrid', 'Formentor', '2024', 'Cupra', 'monovolumen'), ('Cupra', 'hibrid', 'Leon', '2018', 'Cupra', 'monovolumen'),
('Seat', 'hibrid', 'Ibiza', '2011', 'Seat', 'monovolumen'), ('Seat', 'hibrid', 'Cordoba', '2016', 'Seat', 'limuzina'),
('Seat', 'hibrid', 'Malaga', '2014', 'Seat', 'monovolumen'), ('Seat', 'hibrid', 'Toledo', '2011', 'Seat', 'limuzina'),
('Renault', 'hibrid', 'Megan', '2018', 'Renault', 'limuzina'), ('Renault', 'hibrid', 'Talisman', '2020', 'Renault', 'limuzina'),
('Renault', 'hibrid', 'Capture', '2022', 'Renault', 'monovolumen'), ('Renault', 'hibrid', 'Fluence', '2022', 'Renault', 'monovolumen'),
('Peugeot', 'hibrid', '208', '2021', 'Peugeot', 'kabriolet'), ('Peugeot', 'hibrid', '308', '2019', 'Peugeot', 'monovolumen'),
('Peugeot', 'hibrid', '408', '2020', 'Peugeot', 'limuzina'), ('Peugeot', 'hibrid', '508', '2024', 'Peugeot', 'limuzina'),
('Peugeot', 'hibrid', '2008', '2019', 'Peugeot', 'suv'), ('Peugeot', 'hibrid', '3008', '2018', 'Peugeot', 'suv'),
('Peugeot', 'hibrid', '4008', '2019', 'Peugeot', 'suv'), ('Peugeot', 'hibrid', '5008', '2020', 'Peugeot', 'suv');
