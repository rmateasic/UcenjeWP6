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