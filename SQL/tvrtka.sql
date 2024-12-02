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
putanja varchar(100) not null
);

insert into zaposlenici(ime, prezime, datum_rodenja, placa, invalid)
values
--1
('Marko', 'Marulić', '1950-08-18', '2250', 1),
--2
('Dobriša', 'Cesarić', '1902-01-10', '1252.25', 0),
--3
('Tin', 'Ujević', '1991-07-05', '325.28', 1);

insert into slike(zaposlenik, redni_broj, putanja)
values
(1, 1, '"C:\Users\rober\Downloads\Marko Marulić.jpg"'),
(1, 1, '"C:\Users\rober\Downloads\Marko Marulić1.jpg"'),
(2, 2, '"C:\Users\rober\Downloads\Dobriša Cesarić.jpg"'),
(2, 2, '"C:\Users\rober\Downloads\Dobriša Cesarić1.jpg"'),
(3, 3, '"C:\Users\rober\Downloads\Tin Ujević.jpg"'),
(3, 3, '"C:\Users\rober\Downloads\Tin Ujević1.jpg"');
