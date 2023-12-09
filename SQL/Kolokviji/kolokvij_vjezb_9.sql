use master;
go

drop database if exists Vjezba9;
go

create database Vjezba9;
go

alter database Vjezba9 collate Croatian_CI_AS;
go

use Vjezba9;

create table prijateljica (
	sifra int primary key,
	treciput datetime not null,
	novcica decimal (16,7) not null,
	kuna decimal (14,10),
	drugiputa datetime not null,
	haljina varchar (45) not null,
	kratkamajica varchar (49) not null
);

create table punac (
	sifra int primary key,
	narukvica int,
	modelnaocala varchar (30) not null,
	kuna decimal (12,8) not null,
	bojaociju varchar (33) not null,
	suknnja varchar (45) not null
);

create table punac_prijateljic(
	sifra int primary key,
	punac int references punac (sifra),
	prijateljica int references prijateljica (sifra)
);

create table cura(
	sifra int primary key,
	vesta varchar (49),
	ekstrovertno bit not null,
	carape varchar (37) not null,
	suknja varchar (37),
	punac int references punac (sifra)
);

create table brat (
	sifra int primary key,
	novcica decimal (18,9),
	ektrovertno bit not null,
	vesta varchar (32),
	cura int references cura (sifra) not null
);

create table zarucnik (
	sifra int primary key,
	gustoca decimal (17,6) not null,
	haljina varchar (40) not null,
	kratkamajica varchar (48),
	nausnice int,
	brat int references brat (sifra)
);

create table ostavljena (
	sifra int primary key,
	modelnaocala varchar (34),
	suknja varchar (32) not null,
	eura decimal (18,7),
	lipa decimal (15,7),
	treciputa datetime,
	drugiputa datetime,
);

create table snasa (
	sifra int primary key,
	prsten int not null,
	drugiputa datetime,
	haljina varchar (38),
	ostavljena int references ostavljena (sifra)
);