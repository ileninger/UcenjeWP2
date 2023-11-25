use edunovawp2;
go

drop database if exists Muzej;
go

create database Muzej;
go

use Muzej;

create table Kustosi (
Kustos_ID int primary key identity (1,1) not null,
Ime varchar (50),
Prezime varchar (50),
OiB char (11),
UzePodrucje varchar (50)
);

create table Sponzori(
Sponzor_ID int primary key identity (1,1) not null,
Naziv varchar (50),
OiB char (11),
VrijednostUgovora decimal (18,2)
);

create table Izlozbe (
Izlozba_ID int primary key identity (1,1) not null,
Naziv varchar (50),
Kustos int references Kustosi (Kustos_ID),
Sponzor int references Sponzori (Sponzor_ID)
);

create table Djela (
Djela_ID int primary key identity (1,1) not null,
Autor varchar (50),
DatumNastanka date,
ZemljaPodrijekla varchar (50),
ProcjenjanaVrijednost decimal (18,2),
Izlozba int  references Izlozbe (Izlozba_ID)
);