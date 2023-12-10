insert into punac (sifra,lipa,stilfrizura) values
(1,22.11,'jaa'),(2,181.1120,'ja'),(3,112.019,'awq');

insert into svekrva (sifra,eura,carape,kuna,majica,punac) values
(1,222.11,'ahah',11,'aajja',3),
(2,222.11,'ahah',11,'aajja',2),(3,222.11,'ahah',11,'aajja',1);

insert into punac_neprijatelj(sifra) values (1),(2),(3);

insert into mladic(sifra,lipa,prstena,svekrva) values
(1,22.44,22,2),(2,11.919,344,2),(3,195.121,445,1);

update sestra set bojaociju='Osijek';

delete from zena where maraka != 14.81;

-- Prikažite maraka iz tablice neprijatelj, indiferentno iz tablice zena--te lipa iz tablice mladic uz uvjet da su vrijednosti kolone carape iz--tablice svekrva počinju slovom a te da su vrijednosti kolone eura iz--tablice punac različite od 22. Podatke posložite po lipa iz tablice--mladic silazno.

select  a.maraka,f.indiferentno,e.lipa
from neprijatelj a inner join punac_neprijatelj b on a.sifra=b.neprijatelj
inner join punac c on b.punac=c.sifra
inner join svekrva d on d.punac=c.sifra
inner join mladic e on d.sifra=e.svekrva
inner join zena f on e.sifra=f.mladic
where d.carape like 'a%' and c.eura != 22
order by 3 desc;

select a.eura, a.stilfrizura
from punac a inner join punac_neprijatelj b on a.sifra=b.punac
where b.punac is null;
