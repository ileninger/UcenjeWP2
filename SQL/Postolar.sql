use edunovawp2;
go

drop database if exists Postolar;
go

create database Postolar;
go

use Postolar;

create table Djelatnici(
Djelatnik_ID int primary key identity (1,1) not null,
Ime varchar(50) not null,
Prezime varchar (50) not null,
OiB char (11)
);

create table Segrti(
Segrt_ID int primary key identity (1,1) not null,
Ime varchar(50) not null,
Prezime varchar (50) not null,
OiB char (11)
);

create table Vlasnici(
Vlasnik_ID int primary key identity (1,1) not null,
Ime varchar(50) not null,
Prezime varchar (50) not null,
OiB char (11)
);

create table Obuca(
Obuca_ID int primary key identity (1,1) not null,
Vlasnik int references Vlasnici (Vlasnik_ID),
Naziv varchar (50),
Opis varchar (200)
);

Create table Popravci (
Popravak_ID int primary key identity (1,1) not null,
Djelatnik int references Djelatnici (Djelatnik_ID),
Segrt int references Segrti (Segrt_ID),
Datum date,
OpisPopravka varchar (200)
);

create table Popravci_Obuca(
Popravak int references Popravci (Popravak_ID),
Obuca int references Obuca (Obuca_ID)
);