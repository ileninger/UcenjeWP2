use master;
go

drop database if exists Vjezba3;
go

create database Vjezba3;
go

alter database Vjezba3 collate Croatian_CI_AS;
go

use Vjezba3;

create table cura(
sifra int primary key,
dukserica varchar (49) not null,
maraka decimal (13,7) not null,
drugiputa datetime not null,
majica varchar (49) not null,
novcica decimal (15,8) not null,
ogrlica int
);

create table svekar(
sifra int primary key,
novcica decimal (16,8),
suknja varchar (44),
bojakose varchar (36) not null, 
prstena int not null,
narukvica int,
cura int references cura (sifra)
);

create table punica(
sifra int primary key,
asocijalno bit not null,
kratkamajica varchar (44) not null,
kuna decimal (13,8),
vesta varchar (32),
snasa int not null
);

create table snasa (
sifra int primary key,
introvertno bit not null,
kuna decimal (15,6),
eura decimal (12,9),
treciputa datetime not null,
ostavljena int
);

create table ostavljena (
sifra int primary key,
kuna decimal (17,5) not null,
lipa decimal (15,6) not null,
majica varchar (36) not null,
modelnaocala varchar (31),
prijatelj int not null
);

create table prijatelj(
sifra int primary key,
kuna decimal (16,10) not null,
haljina varchar (37) not null,
lipa decimal (13,10) not null,
dukserica varchar (31) not null,
indiferentno bit
);

create table brat(
sifra int primary key,
jmbag char (11) not null,
ogrilica int,
ektrovertno bit,
);

create table prijatelj_brat(
sifra int primary key,
prijatelj int references prijatelj (sifra),
brat int references brat (sifra)
);

alter table ostavljena add foreign key (prijatelj) references prijatelj (sifra);
alter table snasa add foreign key (ostavljena) references ostavljena (sifra);
alter table punica add foreign key (snasa) references snasa (sifra);