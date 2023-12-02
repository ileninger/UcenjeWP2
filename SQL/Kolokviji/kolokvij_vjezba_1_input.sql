use Vjezba1;
insert into zene (treciputa, hlace,haljina) values 
('15:00','maja','sanja'),
('07:00','rifle','kaaja'),
('03:45','kratke','milaa');


insert into muskarci (bojaociju,hlace,modelnacaonala,marka) values
('plava','rifle','rayban',14.25),
('zelena','rifle','timberland',14.00),
('siva','štof','timberland',1.00);

insert into sestre_svekari (sifra) values 
(1),
(2),
(3);
insert into punci (sifra,ogrlica,gustoca) values
(1,114,44.36),
(2,2047,33.54),
(3,1147,25.36);

insert into cura (bojakose,lipa,suknja,punac) values
('plava',14.42,'mimi',1),
('plava',11.30,'mimi',2),
('plava',36.5,'mimi',1);
update cura set gustoca=15.77;
 select * from mladici;

 delete from mladici where kuna >15.78

select kratkamajica from zene
where hlace like '%ana%';