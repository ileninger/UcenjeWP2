use Vjezba2;
go

--insert into decko (sifra,indiferentno, vesta,asocijalno) values
--(1,0,'gad',1),
--(3,0,'tom',0),
--(5,1,'gad',0);


--insert into cura(sifra,suknja,narukvica,introvertno,decko) values 
--(1,'plava',12231,1,5),
--(2,'bjela',12,0,3),
--(3,'pinki',131,1,1);
--select * from cura;

insert into neprijatelj (sifra,majica,jmbag,cura,lipa) values 
(2,'plava',11111111111,1,25.36),
(5,'anaas',11551111111,2,36.78),
(10,'avokado',55111111111,2,47.336);

update prijatelj set treciputa = '2020-04-30';

delete from brat where ogrlica != 14;

select suknja from cura where drugiput =null;

select a.novcica, f.neprijatelj, e.haljina
from zarucnica a inner join decko_zarucnica b on a.sifra=b.zarucnica
inner join decko c on c.sifra=b.decko
inner join cura d on c.sifra=d.decko
inner join neprijatelj e on d.sifra=e.cura
inner join brat f on e.sifra = f.neprijatelj
where d.drugiput is not null and c.vesta like '%ba'
order by e.haljina desc;


select a.vesta, a.asocijalno
from decko a left join decko_zarucnica b on a.sifra = b.decko
where b.decko is null;

--select a.novica, f.neprijatelj, e.haljina
--from zarucnica a inner join decko_zarucnica b on a.sifra=b.zarucnica 
--inner join decko c on c.sifra = b.decko 
--inner join cura d on c sifra = d.decko 
--inner join neprijatlj e on d.sifra = e.cura
--inner join brat f on e.sifra = f. neprijatelj 
--where d.drugiputa is not null and c.vesta like '%ba'
--order by e.haljica desc;

