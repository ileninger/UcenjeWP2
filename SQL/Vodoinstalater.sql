use edunovawp2;
go

drop database if exists Vodoinstalateri;
go

create database Vodoinstalateri;
go

use Vodoinstalateri;

create table Strucna(
Sifra int primary key identity (1,1) not null,
Naziv varchar (50)
);

create table Vodoinstalateri (
Sifra int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null,
OiB char (11) not null,
StrucnaSprema int references Strucna(Sifra) not null,
Kontakt varchar (100)
);

create table Segrti (
Sifra int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null,
OiB char (11) not null,
StrucnaSprema int references Strucna(Sifra) not null,
Kontakt varchar (100)
);

create table Popravci (
Popravak_ID int primary key identity (1,1) not null,
Vodoinstalater int references Vodoinstalateri (Sifra) not null,
Segrt int references Segrti (Sifra) not null,
Datum date not null,
Cijena decimal (18,2) not null
);

create table Kvarovi (
Kvar_ID int primary key identity (1,1) not null,
Naziv varchar (50),
Opis varchar (200),
);

create table Kvarovi_Popraci (
Kvar_ID int references Kvarovi (Kvar_ID) not null,
Popravci int references Popravci (Popravak_ID) not null
);