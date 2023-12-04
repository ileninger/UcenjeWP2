insert into zena_mladic (sifra) values
(1),(2),(3);

insert into becar (sifra,novcica) values 
(1,33.44),(2,22.112), (3,69.87);

insert into snasa (sifra,introvertno,treciputa) values 
(1,0,'14:22'),(2,1,'11:21'),(3,1,'11:01');

update punac set majica ='Osijek';

delete from prijatelj where prstena >17;

select haljina
from snasa where treciputa is null;

select a.nausnica,f.jbag, e.kratkamajica
from  mladic a inner join zena_mladic b on a.stilfrizura=b.mladic
inner join zena c on c.sifra=b.zena
inner join snasa d on c.sifra=d.zena
inner join becar e on d.sifra=e.snasa
inner join prijatelj f on e.sifra=f.sifra
where d.treciputa is not null and c.lipa !=29
order by kratkamajica desc;

select a.lipa,a.prstena
from zena a left join zena_mladic b on a.sifra=b.zena
where b.zena is not null;

