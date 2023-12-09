--insert into cura (sifra,ekstrovertno,carape,suknja) values
--(1,1,'da','lpo'),(2,0,'da','lpo'),(3,0,'jaja','oao');

--insert into punac_prijateljic(sifra) values
--(1),(2),(3);

insert into brat (sifra,ektrovertno,cura) values
(1,1,1),(2,0,2),(3,1,3);

update snasa set drugiputa = '2020-04-24';

delete zarucnik where haljina ='AB';

select carape
from cura where ekstrovertno is not null;

--Prikažite kuna iz tablice prijateljica, nausnica iz tablice zarucnik te--ekstroventno iz tablice brat uz uvjet da su vrijednosti kolone--ekstroventno iz tablice cura poznate te da su vrijednosti kolone--modelnaocala iz tablice punac sadrže niz znakova ba. Podatke--posložite po ekstroventno iz tablice brat silazno. 

select a.kuna,f.nausnice,e.ektrovertno
from prijateljica a inner join punac_prijateljic b on a.sifra=b.prijateljica
inner join punac c on c.sifra=b.punac
inner join cura d on c.sifra=d.punac
inner join brat e on d.sifra = e.cura
inner join zarucnik f on e.sifra=f.brat
where d.ekstrovertno is not null and c.modelnaocala like '%ba%'
order by 3 desc;

--Prikažite kolone modelnaocala i kuna iz tablice punac čiji se--primarni ključ ne nalaze u tablici punac_prijateljica. select a.modelnaocala, a.kunafrom punac a inner join punac_prijateljic b on a.sifra=b.punacwhere b.punac is not null;