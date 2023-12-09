insert into becar (sifra,prviputa,treciputa) values
(1,'12:22','23:00'),(2,'21:12','1:33'),(3,'15:21','09:21');

insert into neprijatelj (sifra,kratkamajica,introvertno,indiferentno) values
(1,'da',0,1),(2,'ja',0,1),(3,'aj',1,1);


insert into muskarac_decko (sifra) values
(1),(2),(3);

update cura set indiferentno = 0;

delete from brat where novcica != 12.74;

select prviputa
from becar where treciputa is null;

--Prikažite bojakose iz tablice decko, neprijatelj iz tablice brat te--introvertno iz tablice neprijatelj uz uvjet da su vrijednosti kolone--treciputa iz tablice becar poznate te da su vrijednosti kolone--drugiputa iz tablice muskarac poznate. Podatke posložite po--introvertno iz tablice neprijatelj silazno

select a.bojakose,f.neprijatelj,e.introvertno
from decko a inner join muskarac_decko b  on a.sifra=b.decko
inner join muskarac c on c.sifra=b.muskarac
inner join becar d on c.sifra=d.muskarac
inner join neprijatelj e on d.sifra=e.becar
inner join brat f on e.sifra=f.neprijatelj
where d.treciputa is not null and c.drugiputa is not null
order by 3 desc;

--Prikažite kolone drugiputa i treciputa iz tablice muskarac čiji se--primarni ključ ne nalaze u tablici muskarac_decko. 

select a.drugiputa, a.treciputa
from muskarac a inner join muskarac_decko b on a.sifra=b.muskarac
where b.sifra is null;