use master;
go

drop database if exists Vjezba12;
go

create database Vjezba12;
go

alter database Vjezba12 collate Croatian_CI_AS;

use Vjezba12;

create table zena (
	sifra int primary key,
	eura decimal (16,6),
	indiferentno bit not null,
	novcica decimal (15,5)
);

create table decko (
	sifra int primary key,
	hlace varchar (46) not null,
	asocijalno bit not null,
	stilfrizura varchar (43),
	indiferentno bit,
	ogrlica int not null,
	zena int references zena (sifra)
);

create table sestra (
	sifra int primary key,
	lipa decimal (15,9) not null,
	ogrilica int not null, 
	kratkamajica varchar (43)
);

create table zarucnica (
	sifra int primary key,
	hlace varchar (48),
	kratkamajica varchar (46),
	jmag char (11),
	nausnica int not null,
);

create table zarucnica_sestra (
	sifra int primary key,
	zerucnica int references zarucnica (sifra),
	sestra int references sestra (sifra)
);

create table svekrva (
	sifra int primary key,
	maraka decimal (14,7) not null,
	kuna decimal (15,8) not null,
	vesta varchar (44) not null,
	asocijalno bit,
	ekstrovertno bit,
	zarucnica int references zarucnica (sifra)
);

create table djevojka (
	sifra int primary key,
	modelnaocala varchar (34),
	vesta varchar (40),
	kratkamajica varchar (39),
	suknja varchar (36),
	bojaociju varchar (32),
	prstena int,
	svekrva int references svekrva (sifra)
);

create table prijate(
	sifra int primary key,
	lipa decimal (16,10) not null,
	asocijalno bit not null,
	stilfrizura varchar (37) not null,
	kuna decimal (14,6) not null,
	modelnaocala varchar (38) not null,
	djevojka int references djevojka (sifra)
);
