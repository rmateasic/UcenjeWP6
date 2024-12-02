-- ovo je SQL skripta kolokvij_vjezba_2

use master;
go

drop database if exists kolokvij_vjezba_2;
go

create database kolokvij_vjezba_2;
go


use kolokvij_vjezba_2;
go

create table svekar(
sifra int primary key identity(1,1),
stilfrizura varchar(48) not null,
ogrlica int,
asocijalno bit
);

create table prijatelj(
sifra int primary key identity(1,1),
modelnaocala varchar(37) not null,
treciputa datetime,
ekstrovertno bit,
prviputa datetime not null,
svekar int references svekar(sifra)
);

create table decko(
sifra int primary key identity(1,1),
indiferentno bit not null,
vesta varchar(34) not null,
asocijalno bit
);

create table cura(
sifra int primary key identity(1,1),
haljina varchar(30),
drugiputa datetime,
suknja varchar(38) not null,
narukvica int not null,
introvertno bit not null,
majica varchar(40),
decko int not null references decko(sifra)
);

create table zarucnica(
sifra int primary key identity(1,1),
narukvica int not null,
bojakose varchar(37),
novcica decimal(15,9) not null,
lipa decimal (15,8),
indifertentno bit
);

create table decko_zarucnica(
sifra int primary key identity(1,1),
decko int references decko(sifra),
zarucnica int references zarucnica(sifra)
);

create table neprijatelj(
sifra int primary key identity(1,1),
majica varchar(32) not null,
haljina varchar(43),
lipa decimal(16,8) not null,
modelnaocala varchar(49),
kuna decimal(12,6),
jmbag char(11) not null,
cura int not null references cura(sifra)
);

create table brat(
sifra int primary key identity(1,1),
suknja varchar(40) not null,
ogrlica int,
asocijalno bit,
neprijatelj int references neprijatelj(sifra)
);

