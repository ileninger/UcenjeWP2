use master;
go

drop database if exists Vjezba2;
go

create database Vjezba2;
go

alter database Vjezba2 collate Croatian_CI_AS;
go

use Vjezba2;

create table cura (
sifra int primary key,
haljina varchar (33),
drugiput datetime,
suknja varchar (38) not null,
narukvica int not null,
introvertno bit not null,
majica varchar (40),
decko int
);
create table neprijatelj (
sifra int primary key,
majica varchar (32) not null,
haljina varchar(43),
lipa decimal (16,8) not null,
modelnaocla varchar (49),
kuna decimal (12,6),
jmbag char (11) not null,
cura int,
);

create table brat (
sifra int primary key,
suknja varchar (47) not null,
ogrlica int,
asocijalno bit,
neprijatelj int,
);

create table decko (
sifra int primary key,
indiferentno bit not null,
vesta varchar (34) not null,
asocijalno bit
);

create table zarucnica(
sifra int primary key,
narukcica int not null,
bojakosa varchar (37),
novcica decimal (15,9) not null,
lipa decimal (15,8),
indiferetno bit
);

create table decko_zarucnica(
decko int references decko (sifra),
zarucnica int references zarucnica (sifra)
);

create table svekar (
sifra int primary key,
stilfrizura varchar (48) not null,
ogrlica int,
asocijanlno bit
);
create table prijatelj (
sifra int primary key,
modelnaocala varchar (37) not null, 
treciputa datetime,
ekstrovertno bit,
prviputa datetime not null,
svekar int references svekar (sifra),
);

alter table cura add foreign key (decko) references decko (sifra);
alter table neprijatelj add foreign key (cura) references cura (sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj (sifra);