-- ovo je SQL skripta kolokvij_vjezba_1

use master;
go

drop database if exists kolokvij_vjezba_1;
go

create database kolokvij_vjezba_1;
go


use kolokvij_vjezba_1;
go

create table sestra(
sifra int not null primary key identity(1,1),
introvertno bit not null,
haljina varchar(31),
marama decimal(16,6) not null,
hlace varchar(46),
narukvica int 
);

create table punac(
sifra int not null primary key identity(1,1),
ogrlica int not null,
gustoca decimal(14,9) not null,
hlace varchar(41) 
);

create table svekar(
sifra int not null primary key identity(1,1),
bojaociju varchar(40),
prstena int not null,
dukserica varchar(41) not null,
lipa decimal(13,8) not null,
eura decimal(12,7) not null,
majica varchar(35) not null
);

create table zena(
sifra int not null primary key identity(1,1),
treciputa datetime not null,
hlace varchar(46) not null,
kratkamajica varchar(31),
jmbag char(11),
bojaociju varchar(39),
haljina varchar(44) not null,
sestra int
);