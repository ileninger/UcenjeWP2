use master;
go

drop database if exists Vjezba8;
go

create database Vjezba8;
go

alter database Vjezba8 collate Croatian_CI_AS;
go

use Vjezba8;

create table decko (
	sifra int primary key,
	kuna decimal (12,10) not null,
	lipa decimal (12,10) not null,
	bojakose varchar (44) not null,
	treciputa datetime,
	ogrlica int,
	ektrovertno bit
);

create table muskarac (
	sifra int primary key,
	haljina varchar (47) not null,
	drugiputa datetime,
	treciputa datetime not null
);

create table muskarac_decko(
	sifra int primary key,
	muskarac int references muskarac (sifra),
	decko int references decko (sifra)
);

create table becar (
	sifra int primary key,
	eura decimal (15,10),
	treciputa datetime not null,
	prviputa datetime not null,
	muskarac int references muskarac (sifra)
);

create table neprijatelj (
	sifra int primary key,
	kratkamajica varchar (44) not null,
	introvertno bit not null,
	indiferentno bit not null,
	ogrlica int,
	becar int references becar (sifra)
);

create table brat (
	sifra int primary key,
	introvertno bit not null,
	novcica decimal (14,7),
	treciputa datetime not null,
	neprijatelj int references neprijatelj (sifra) not null
);

create table prijateljica (
	sifra int primary key,
	vesta varchar (50) not null,
	nausnica int,
	introvertno bit
);

create table cura (
	sifra int primary key,
	nausnica int,
	indiferentno bit not null,
	ogrlica int,
	gustoca decimal (12,6) not null,
	drugiputa datetime not null,
	vesta varchar (33) not null,
	prijateljica int references prijateljica (sifra)
);