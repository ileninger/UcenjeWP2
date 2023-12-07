--insert into zena (sifra, haljina, hlace) values 
--(1,'plave','smeđe'),
--(2,'roza','nosi'),
--(3,'vjencania','rifrle');

--insert into prijatelj (sifra,haljina,introvertno) values
--(1,'ima',1),(2,'oa',0),(3,'ćaba',1);
--insert into brat (sifra,hlace,prijatelj) values  
----(1,'ima',1),(2,'oa',2),(3,'ćaba',3);
--insert into prijatelj_ostavljena(sifra) values 
--(1),(2),(3);
--update svekrva set suknja='Osijek';

--delete from decko where modelnaocla is not 'AB';

select narukvica
from brat
where treciputa is null;

select f.drugiputa,a.zena,b.narukvica
from decko a inner join zena b 
on a.zena = b.sifra
inner join brat c on b.brat=c.sifra
inner join prijatelj d on c.prijatelj=d.sifra
inner join prijatelj_ostavljena e on e.ostavljena=d.sifra
inner join ostavljena f on e.ostavljena=f.sifra
where b.narukvica is not null and d.prstena=219
order by 3 desc;

select a.prstena, a.introvertno
from prijatelj a left join prijatelj_ostavljena b 
on a.sifra=b.prijatelj
where b.prijatelj is null;