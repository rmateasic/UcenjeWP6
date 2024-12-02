-- ovo je SQL skripta kolokvij_vjezba_3

use master;
go

drop database if exists kolokvij_vjezba_3;
go

create database kolokvij_vjezba_3;
go


use kolokvij_vjezba_3;
go

create table cura(
sifra int primary key identity(1,1),
dukserica varchar(49) not null,
maraka decimal(13,7) not null,
drugiputa datetime not null,
majica varchar(49) not null,
novcica decimal(15,8) not null,
ogrlica int
);

create table svekar(
sifra int primary key identity(1,1),
novcica decimal(16,8),
suknja varchar(44),
bojakose varchar(36) not null,
prsten int not null,
narukvica int,
cura int references cura(sifra)
);

create table prijatelj(
sifra int primary key identity(1,1),
kuna decimal(16,10) not null,
haljina varchar(37) not null,
lipa decimal(13,10) not null,
dukserica varchar(31) not null,
indiferentno bit
);

create table ostavljena(
sifra int primary key identity(1,1),
kuna decimal(17,5) not null,
lipa decimal(15,6) not null,
majica varchar(36) not null,
modelnaocala varchar(31),
prijatelj int references prijatelj(sifra) not null
);

create table snasa(
sifra int primary key identity(1,1),
introvertno bit not null,
kuna decimal(15,6),
eura decimal(12,9),
trecipura datetime not null,
ostavljena int references ostavljena(sifra)
);