use master;
go

drop database if exists Vjezba4;
go

create database Vjezba4;

alter database Vjezba4 collate Croatian_CI_AS;
go

use Vjezba4;

create table ostavljen (
sifra int primary key,
modelnaocala  varchar (43) not null,
introvertno bit not null,
kuna decimal (14,10) not null
);

create table punac (
sifra int primary key,
treciputa datetime not null,
majica varchar (46) not null,
jmbag char (11),
novcica decimal (18,7),
maraka decimal (12,6),
ostavljen int references ostavljen (sifra)
);

create table zena (
sifra int primary key,
suknja varchar (39),
lipa decimal (18,7) not null,
prstena int
);

create table mladic(
sifra int primary key,
kuna decimal (15,9) not null,
lipa decimal (18,5) not null,
nausnica int not null,
stilfrizura varchar (49) not null,
vesta varchar (34)
);

create table zena_mladic (
sifra int primary key,
zena int references zena (sifra),
mladic int references mladic (sifra)
);
create table snasa (
sifra int primary key,
introvertno bit not null,
treciputa datetime not null,
haljina varchar (44),
zena int references zena (sifra)
);
create table becar (
sifra int primary key,
novcica decimal (14,8) not null,
kratkamajica varchar (48),
bojaociju varchar (36),
snasa int references snasa (sifra)
);

create table prijatelj (
sifra int primary key,
eura decimal (16,9) not null,
prstena int,
gustoca decimal (16,5) not null,
jbag char (11),
suknja varchar (47),
becar int references becar (sifra)
);