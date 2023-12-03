use Vjezba3;
go

insert into prijatelj_brat (sifra) values
(1),(2),(3);

select * from prijatelj_brat;

insert into snasa (sifra,introvertno,treciputa) values 
(1,1,'14:30'),
(2,0,'00:25'),
(5,0,'11:01');

select * from snasa;

insert into prijatelj (sifra,kuna,haljina,lipa,dukserica) values 
(1,24.44,'zelena',996.12,'plava'),
(2,24.44,'zelena',996.12,'plava'),
(3,24.44,'zelena',996.12,'plava');

insert into ostavljena (sifra,kuna,lipa,prijatelj,majica) values 
(1,23.44,99.11,1,'plava'),
(2,44.11,33.12,3,'plava'),
(3,148.121,760.12,2,'plava');

select * from ostavljena;

update svekar set suknja='Osijek';
delete from punica where kratkamajica ='AB';

select * from ostavljena where lipa not in ('9','10','20' ,'30' ,'35'); 

select a.ektrovertno, f.vesta, e.kuna 
from brat a inner join  prijatelj_brat b 
on a.sifra = b.brat
inner join prijatelj c on b.brat=c.sifra
inner join ostavljena d on c.sifra=d.prijatelj
inner join snasa e on d.sifra = e.ostavljena
inner join punica f on e.sifra = f.snasa
where d.lipa not like 91 and c.haljina like '%ba%'
order by 3 desc;

select haljina, lipa
from prijatelj where not exists (select * from prijatelj_brat where prijatelj.sifra = prijatelj_brat.sifra);

--where d.lipa not like 91 and c.haljina like '%ba%'
--order by 3 desc; 