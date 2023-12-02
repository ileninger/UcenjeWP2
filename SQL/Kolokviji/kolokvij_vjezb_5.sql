use master;
go

drop database if exists Vjezba5;
go

create database Vjezba5;
go

alter database Vjezba5 collate Croatian_CI_AS;
go

use Vjezba5;

create table zarucnik (
sifra int primary key ,
jmbag char (11) not null,
lipa decimal (12,8) not null,
indiferentno bit
);

create table mladic (
sifra int primary key,
kratkamajica varchar (48),
haljina varchar (30),
asocijalno bit not null,
zarucnik int references zarucnik (sifra)
);

create table punac (
sifra int primary key,
dukserica varchar (33) not null,
prviputa datetime,
majica varchar (36) not null,
svekar int
);
create table punica (
sifra int primary key,
hlace varchar (43),
nausnica int,
ogrlica int not null,
vesta varchar (49),
modelnaocala varchar (31),
treciputa datetime,
punac int
);

create table ostavljena (
sifra int primary key,
majica varchar (33) not null,
ogrlica int,
carape varchar (44) not null,
stilfrizura varchar (42) not null,
punica int
);

create table svekar (
sifra int primary key,
bojakose varchar (33) not null,
majice varchar (31) not null,
carape varchar (31),
haljina varchar (43) not null,
narukvica int not null,
eura decimal (14,5)
);

create table cura (
sifra int primary key,
carape varchar (41),
maraka decimal (17,10),
asocijalno bit not null,
vesta varchar (47)
);

create table svekar_cura(
sifra int primary key,
svekar int references svekar (sifra),
cura int references cura (sifra),
);

alter table punac add foreign key (svekar) references svekar (sifra);
alter table punica add foreign key (punac) references punac (sifra);
alter table ostavljena add foreign key (punica) references punica (sifra);