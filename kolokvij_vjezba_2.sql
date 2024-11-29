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
