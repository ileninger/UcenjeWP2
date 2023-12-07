use master;
go

drop database if exists Vjezba6;
go

create database Vjezba6;
go

alter database Vjezba6 collate Croatian_CI_AS;
go

use Vjezba6;

create table ostavljena (
	sifra int primary key,
	prviputa datetime,
	kratkamajica varchar (39),
	drugiputa datetime not null,
	marka decimal (14,10)
);

create table prijatelj(
	sifra int primary key,
	haljina varchar (35) not null,
	prstena int, 
	introvertno bit,
	stilfrizura varchar (36)
);

create table prijatelj_ostavljena (
	sifra int primary key,
	prijatelj int references prijatelj (sifra),
	ostavljena int references ostavljena (sifra)
);

create table brat (
	sifra int primary key,
	nausnica int,
	treciputa datetime,
	narukvica int,
	hlace varchar (31) not null,
	prijatelj int references prijatelj (sifra) not null
);

create table zena (
	sifra int primary key,
	novcica decimal (14,8),
	narukvica int,
	dukserica varchar (40),
	haljina varchar (30) not null,
	hlace varchar (32) not null,
	brat int references brat (sifra)
);

create table decko (
	sifra int primary key,
	prviputa datetime not null,
	modelnaocla varchar (41) not null,
	nausnica int,
	zena int references zena (sifra)
);

create table punac (
	sifra int primary key,
	ektrovertno bit,
	suknja varchar (30), 
	majica varchar (44),
	prviputa datetime
);

create table svekrva (
	sifra int primary key,
	hlace varchar (48),
	suknja varchar (42), 
	ogrlica int,
	treciputa datetime,
	dukserica varchar (32),
	narukvica int,
	punac int references punac (sifra)
);

