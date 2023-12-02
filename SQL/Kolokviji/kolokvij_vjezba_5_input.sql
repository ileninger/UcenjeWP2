use Vjezba5;
go

--insert into punac(sifra, dukserica,majica) values
--(1,'Plava','polo'),
--(2,'Duga','trenerka'),
--(3,'Bela','V izrez');

--insert into punica (sifra, ogrlica) values
--(2,3435),
--(4,9530),
--(3,3333);
--insert into svekar_cura (sifra) values
--(1),(2),(3);

--update mladic set haljina = 'Osijek';

--delete from ostavljena where ogrlica=17;

--select majica
--from punac where prviputa is null;


--select   a.carape, a.majice
--from svekar a left join svekar_cura b 
--on a.sifra=b.cura
--where b.sifra is  null 
select a.asocijalno, e.nausnica, f.stilfrizura
from cura a inner join svekar_cura b 
on a.sifra = b. cura
inner join svekar c on b.sifra = c.sifra
inner join punac d on c.sifra = d.sifra
inner join punica e on d.sifra = e.sifra
inner join ostavljena f on e.sifra = f.punica
where d.prviputa is not null and c.majice like '%ba%'
order by e.nausnica asc;