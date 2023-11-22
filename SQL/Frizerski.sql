use master;
go

drop database if exists FrizerskiSalon;
go

create database FrizerskiSalon;
go

use FrizerskiSalon;

create table Djelatnici(
Djelatinik_ID int primary key identity (1,1) not null,
Ime varchar(50) not null,
Prezime varchar (50) not null,
OiB char(11) not null,
IBAN varchar (50),
Kontakt varchar (50)
);


create table Korisnici(
Korisnik_ID int primary key identity (1,1) not null,
Ime varchar(50) not null,
Prezime varchar (50) not null,
Kontakt varchar (50) not null,
Spol bit not null
);

create table Usluge(
Usluga_ID int primary key identity (1,1) not null,
Naziv varchar(50) not null,
Cijena decimal (18,2) not null,
Trajanje int not null
);

create table Posjeta (
Posjeta_ID int primary key identity (1,1) not null,
Djelatnik int references Djelatnici (Djelatinik_ID)  not null,
Korsnik int references Korisnici (Korisnik_ID) not null,
Usluga int references Usluge (Usluga_ID) not null,
Datum date
);