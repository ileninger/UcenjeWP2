use master;
go

drop database if exists Crvenkapica;
go

create database Crvenkapica;
go

alter database Crvenkapica collate Croatian_CI_AS;
go

use Crvenkapica;
Create table Djeca (
Djete_ID int primary key identity(1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null,
Spol bit not null
);
Create table Roditelji( 
Roditelj_ID int primary key identity (1,1) not null,
ImeOca varchar (50) not null,
PrezimeOca varchar (50) not null,
OiBOca char (11),
ImeMajke varchar (50) not null,
PrezimeMajke varchar (50) not null,
OiBMajkte char(11)
);
--Create table Roditelj_Djeca(
--Roditelj int references Roditelji (Roditelj_ID),
--Djeca int references Djeca (Djete_ID),
--);

--Ako roditelj upisuje više djece svako djete je nova prijava
Create table Prijave (
Prijava_ID int primary key identity (1,1) not null,
Roditelj int references Roditelji (Roditelj_ID) not null,
Djete int references Djeca (Djete_ID) not null,
DatumPrijave datetime not null
);

create table Odgajatelji(
Odgajatelj_ID int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null, 
OiB char (11) not null,
);


create table OdgojnaSkupina(
OdgojnaSkupina_ID int primary key identity (1,1) not null,
Naziv varchar (50) not null,
Odgajatelj int references Odgajatelji(Odgajatelj_ID) not null,
MaxBrojDjece int
);

create table Galerije (
Galerija_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null
);

create table Fotografije(
Fotografija_ID int primary key identity (1,1) not null,
lokacija varchar (200) not null
);

create table GalerijaFotografija(
GalerijaFotografija_ID int primary key identity not null,
Galerija int references Galerije (Galerija_ID) not null,
Fotografije int references Fotografije (Fotografija_ID) not null
);
create table Događaji (
Događaji_ID int primary key identity (1,1) not null,
Naslov varchar (50) not null,
Datum datetime not null,
GalerijaFotografija  int references GalerijaFotografija (GalerijaFotografija_ID),
);

create table Kontakt (
NazivVrtica varchar (50) not null,
Adresa varchar (100) not null,
KontaktTelefon varchar (100) not null
);