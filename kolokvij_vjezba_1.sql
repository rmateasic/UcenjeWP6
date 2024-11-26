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
