use Vjezba12;
go

--insert into djevojka (sifra) values
--(1), (2),(3);

insert into zarucnica (sifra,jmag,nausnica) values
(1,11111111111,81811),
(2,11111111111,81811),
(3,11111111111,81811);


insert into svekrva (sifra,maraka,kuna,vesta,ekstrovertno,zarucnica) values 
(1,11.66,33.99,'ima',0,1),
(2,998.121,11.21,'plava',0,2),
(3,818.210,209.121,'zelena',1,3);

update decko set asocijalno=0;


delete from prijate where asocijalno=0;

select vesta from svekrva 
where (kuna != 8) or (kuna !=3) or (kuna !=20) or (kuna != 28) or (kuna != 35);

--Prikažite kratkamajica iz tablice sestra, kuna iz tablice prijatelj te--vesta iz tablice djevojka uz uvjet da su vrijednosti kolone kuna iz--tablice svekrva veće od 87 te da su vrijednosti kolone kratkamajica iz--tablice zarucnica sadrže niz znakova ba. Podatke posložite po vesta iz--tablice djevojka silazno. 

select f.kratkamajica, a.kuna,b.vesta
from prijate a inner join djevojka b
on a.djevojka=b.sifra
inner join svekrva c on b.svekrva=c.sifra
inner join zarucnica d on c.zarucnica = d.sifra
inner join zarucnica_sestra e on e.zerucnica = e.sifra
inner join sestra f on e.sestra = f.sifra
where c.kuna >87 and d.kratkamajica like '%ba'
order by 3 desc;

select a.kratkamajica, a.jmag
from zarucnica a inner join zarucnica_sestra b
where a.sifra is not null;
