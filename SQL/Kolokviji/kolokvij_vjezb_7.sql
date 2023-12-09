use master;
go

drop database if exists Vjezba7;
go

create database Vjezba7;
go

alter database Vjezba7 collate Croatian_CI_AS;
go

use Vjezba7;

create table mladic(
	sifra int primary key,
	prstena int not null,
	lipa decimal (14,5),
	narukvica int,
	drugiputa datetime
);

create table zarucnik (
	sifra int primary key,
	vesta varchar (34) not null,
	asocijalno bit,
	modelnaocala varchar (43) not null,
	narukvica int,
	novcica decimal (15,5)
);

create table zarucnik_mladic(
	sifra int primary key,
	zarucnik int references zarucnik (sifra),
	mladic int references mladic (sifra)
);

create table ostavljen (
	sifra int primary key,
	lipa decimal (14,6) not null,
	introvertno bit,
	kratkamajica varchar (38),
	prstena int,
	zarucnik int references zarucnik (sifra)
);

create table prijateljica (
	sifra int primary key,
	haljina varchar (45) not null,
	gustoca decimal (15,10),
	ogrlica int not null,
	novcica decimal (12,5) not null,
	ostavljen int references ostavljen (sifra)
);

create table sestra (
	sifra int primary key,
	bojakose varchar (34),
	hlace varchar (36),
	lipa decimal (15,6) not null,
	stilfrizuar varchar (40),
	maraka decimal (12,8),
	prijateljica int references prijateljica (sifra)
);

create table cura (
	sifra int primary key,
	lipa decimal (12,9),
	introvertno bit not null,
	modelnaocala varchar (40) not null,
	narukvica int not null,
	treciputa datetime not null,
	kuna decimal (14,9) not null
);

create table punica (
	sifra int primary key,
	majica varchar (40) not null,
	eura decimal (12,6),
	pristena int not null,
	cura int references cura (sifra)
);

