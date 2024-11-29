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
maraka decimal(16,6) not null,
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

create table cura(
sifra int not null primary key identity(1,1),
novcica decimal(16,5),
gustoca decimal(18,6),
lipa decimal(13,10) not null,
ogrlica int,
bojakose varchar(38) not null,
suknja varchar(36) not null,
punac int not null
);

create table sestra_svekar(
sifra int not null primary key identity(1,1),
sestra int,
svekar int
);

create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50),
hlace varchar(30) not null,
modelnaocala varchar(43) not null,
maraka decimal(14,5),
zena int
);

create table mladic(
sifra int not null primary key identity(1,1),
suknja varchar(50),
kuna decimal(16,8),
drugiputa datetime not null,
asocijalno bit not null,
ekstrovertno bit,
dukserica varchar(48),
muskarac int not null
);