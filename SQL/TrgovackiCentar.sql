use edunovawp2;
go

drop database if exists TrgovackiCentar;
go

create database TrgovackiCentar;
go

use TrgovackiCentar;

create table Osobe(
Osoba_ID int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null,
OiB char (11),
Kontakt varchar (50)
);

Create table Trgovine (
Trgovina_ID int primary key identity (1,1) not null,
Naziv varchar (50),
RadnoVrijeme varchar(100),
);

create table Trgovine_Osobe (
Osoba_ID int references Osobe(Osoba_ID) not null,
Trgovine_ID int references Trgovine(Trgovina_ID) not null
);

create table Sefovi (
Sef_ID int primary key identity (1,1) not null,
Osoba_ID int references Osobe(Osoba_ID) not null,
Trgovine_ID int references Trgovine(Trgovina_ID) not null
);
