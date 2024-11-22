select * from smjerovi;

--minimalna select naredba

select 1;

--filtriranje kolona (između select i from)
-- * sve kolone
-- kolona
-- konstanta
-- izraz
select naziv as n1, cijena as c1, 
naziv, 'Osijek' as grad,
cijena*1.25 as PDV,
getdate() as kada,*
from smjerovi;


-- izlistajte imena i prezimena polaznika

select ime, prezime from polaznici;

-- filtriranje redova
select * from polaznici;

update polaznici set oib = '53441375824' where sifra=10;
--operatori
--uspoređivanja =, !=, <, >, <=, >=
-- logički operatori: and, or, not
-- ostali operatori: like (% je zamjena za bilo koji znak)
select * from polaznici
where ime like '%an%';

-- s najmanom mogućnošću greške izlistati sve muškarce
select * from polaznici
where ime not like '%a';

--ostali operatori: in

select * from polaznici
where sifra in (1, 7, 9);

-- ostali operatori: between

select * from smjerovi
where izvodiseod between '2024-01-01' and '2024-12-31';

-- slaganje rezultata
select prezime, ime from polaznici
order by prezime, 2;

--ograničavanje rezultata
select top 10 percent * from polaznici;

select top 10 ime, prezime into nova from polaznici;

select * from nova;

drop table nova;

use knjiznica;

-- ukupno redova
select count(*) from autor;

select top 10 * from autor;

-- unesite seba kao autora

insert into autor (sifra, ime, prezime, datumrodenja)
values (4, 'Robert', 'Mateašić', '1976-03-03');

select top 10 * from katalog;

select top 10 a.ime, a.prezime, b.naslov, 
c.naziv
from autor a inner join katalog b
on a.sifra = b.autor
inner join mjesto c
on c.sifra = b.mjesto;

select*
from autor a right join katalog b
on a.sifra=b.autor;

use svastara;

select count(*) from artikli;  -- 52601
select distinct artikl from ArtikliNaPrimci; -- 52599

select * from artikli where
sifra not in (select distinct artikl from ArtikliNaPrimci);

delete from artikli where
sifra=79102;




