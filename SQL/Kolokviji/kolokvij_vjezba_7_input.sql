--insert into zarucnik_mladic (sifra) values 
--(1),(2),(3);

insert into zarucnik (sifra,vesta,modelnaocala) values
(1,'plava','rayball'),(2,'zelena','tiberland'),(3,'bjela','pollaroid');

insert into ostavljen (sifra,lipa,zarucnik) values
(1,12.55,2),(2,0.31,1),(3,111.124,3);

insert into prijateljica (sifra,haljina,ogrlica,novcica,ostavljen) values 
(1,'aa',2,12.121,1),(2,'fe',32,343.12,3),(5,'ptrl',99,885.12,2);

update punica set eura=15.77;

delete from sestra where hlace < 'AB';


select kratkamajica
from ostavljen
where introvertno is null;
--Prikažite narukvica iz tablice mladic, stilfrizura iz tablice sestra te--gustoca iz tablice prijateljica uz uvjet da su vrijednosti kolone--introvertno iz tablice ostavljen poznate te da su vrijednosti kolone--asocijalno iz tablice zarucnik poznate. Podatke posložite po gustoca iz--tablice prijateljica silazno.
select a.narukvica,f.stilfrizuar, e.gustoca
from mladic a inner join zarucnik_mladic b on  a.sifra=b.mladic
inner join zarucnik c on c.sifra=b.zarucnik
inner join ostavljen d  on c.sifra = d.zarucnik
inner join prijateljica e on d.sifra=e.ostavljen
inner join sestra f on e.sifra=f.prijateljica
where d.introvertno is not null and c.asocijalno is not null
order by 3 desc;


select a.asocijalno,a.modelnaocala
from zarucnik a inner join zarucnik_mladic b on a.sifra=b.mladic
where b.mladic is not null;
