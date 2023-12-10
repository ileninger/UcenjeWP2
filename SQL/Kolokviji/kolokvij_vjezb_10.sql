use master;
go

drop database if exists Vjezba10;
go

create database Vjezba10;
go

alter database Vjezba10 collate Croatian_CI_AS;
go

use Vjezba10;

create  table neprijatelj (
	sifra int primary key,
	gustoca decimal (15,10),
	dukserica varchar (32),
	maraka decimal (15,7) not null,
	stilfrizura varchar (49)
);

create table punac (
	sifra int primary key,
	lipa decimal (15,9) not null,
	eura decimal (15,10),
	stilfrizura varchar (37) not null
);

create table punac_neprijatelj (
	sifra int primary key,
	punac int references punac (sifra),
	neprijatelj int references neprijatelj (sifra)
);

create table svekrva (
	sifra int primary key,
	eura decimal (17,9) not null,
	carape varchar (43) not null,
	kuna decimal (13,9) not null,
	majica varchar (30) not null,
	introvertno bit,
	punac int references punac (sifra)
);

create table mladic (
	sifra int primary key,
	hlace varchar (38),
	lipa decimal (18,6) not null,
	stilfrizura varchar (35),
	prstena int not null,
	maraka decimal (12,6),
	svekrva int references svekrva (sifra) not null
);

create table zena (
	sifra int primary key,
	bojaociju varchar (49),
	maraka decimal (13,9),
	majica varchar (45) not null,
	indiferentno bit not null,
	prviputa datetime not null,
	mladic int references mladic (sifra)
);

create table zarucnica (
	sifra int primary key,
	treciputa datetime not null,
	prviputa datetime not null,
	suknja varchar (32),
	eura decimal (16,10) not null,
);

create table sestra (
	sifra int primary key,
	suknja varchar (46),
	bojaociju varchar (49)  not null,
	idiferentno bit not null,
	dukserica varchar (32),
	drugiputa datetime not null,
	prviputa datetime,
	zarucnica int references zarucnica (sifra) not null
);