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



--Prikažite drugiputa iz tablice mladic, haljina iz tablice punica te