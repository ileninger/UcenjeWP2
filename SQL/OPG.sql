use edunovawp2;
go

drop database if exists OPG;
go

create database OPG;
go

use OPG;
Create table Djelatnici(
	Djelatnik_iD int primary key identity (1,1) not null,
	Ime varchar (50) not null,
	Prezime varchar (50) not null,
	OiB char (11) not null

);
create table Proizvodi (
	Proizvod_ID int primary key identity (1,1) not null,
	Naziv varchar(100),
	Cijena decimal (18,2),
	Djelatnik int references Djelatnici (Djelatnik_ID)
);

create table Sirovine (
	Sirovina_ID int primary key identity (1,1) not null,
	Naziv varchar (100) not null,
	Opis varchar (200)
);

create table Sirovina_Proizvod(
	Proizvod int references Proizvodi (Proizvod_ID),
	Sirovina int references Sirovine (Sirovina_ID)
);