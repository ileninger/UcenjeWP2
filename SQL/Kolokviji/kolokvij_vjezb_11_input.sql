insert into svekrva(sifra,haljina) values 
(1,'aja'),(2,'unfe'),(3,'uač');

insert into djevojka (sifra,prstena,svekrva) values
(1,442,2),(2,8818,1),(3,9399,3);

insert into punac_mladic (sifra) values
(1),(2),(3);

update muskarac set novcica=15.70;

delete from punica where drugiputa = '2019-04-08';

select haljina
from svekrva where carape like '%ana%';



--Prikažite drugiputa iz tablice mladic, haljina iz tablice punica te--prstena iz tablice djevojka uz uvjet da su vrijednosti kolone carape iz--tablice svekrva počinju slovom a te da su vrijednosti kolone kuna iz--tablice punac različite od 21. Podatke posložite po prstena iz tablice--djevojka silaznoselect  a.drugiputa, f.haljina, e.prstenafrom mladic a inner join punac_mladic b on a.sifra=b.mladicinner join punac c on c.sifra=b.punainner join svekrva d on c.sifra=d.punacinner join djevojka e on d.sifra = e.svekrvainner join punica f on e.sifra=f.djevojkawhere d.carape like '%a%' and c.kuna != 21order by 3 desc;select a.kuna, a.vestafrom punac a inner join punac_mladic b on a.sifra=b.punawhere a.sifra != b.puna