use master;
go

drop database if exists Vjezba11;
go

create database Vjezba11;
go

alter database Vjezba11 collate Croatian_CI_AS;
go

use Vjezba11;

create table mladic(
	sifra int primary key,
	ogrlica int,
	stilfrizura varchar (35) not null,
	drugiputa datetime,
	hlace varchar (41)
);

create table punac (
	sifra int primary key,
	jmbag char (11) not null,
	kuna decimal (16,5),
	vesta varchar (45)
);

create table punac_mladic (
	sifra int primary key,
	puna int references punac (sifra),
	mladic int references mladic (sifra)
);

create table svekrva(
	sifra int primary key,
	narukvica int,
	carape varchar (39),
	haljina varchar (31) not null,
	punac int references punac (sifra)
);	

create table djevojka (
	sifra int primary key,
	kratkamajica varchar (45),
	prstena int not null,
	ekstrovertno bit,
	majica varchar (42),
	introvertno bit,
	svekrva int references svekrva (sifra)
);

create table punica (
	sifra int primary key,
	carape varchar (33),
	drugiputa datetime not null,
	majica varchar (40),
	haljina varchar (30),
	bojakose varchar (37),
	djevojka int references djevojka (sifra)
);

create table neprijatelj (
	sifra int primary key,
	narukvica  int,
	novcica decimal (12,8),
	bojakose varchar (39),
	gustoca decimal (14,10),
	introvertno bit,
	asocijalno bit not null
);

create table muskarac (
	sifra int primary key,
	maraka decimal (16,5) not null,
	novcica decimal (13,10) not null,
	nausnica int not null,
	narukvica int,
	gustoca decimal (12,6) not null,
	neprijatelj int references neprijatelj (sifra)
);