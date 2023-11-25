use edunovawp2;
go

drop database if exists BaranjinVrh;
go

create database BaranjinVrh;
go

alter database BaranjinVrh collate Croatian_CI_AS;

use BaranjinVrh;

create table DobrovoljnaVatrogasnaDrustvaBaranja(
ID int primary key identity (1,1) not null,
Naziv varchar (200) not null
);

create table Događanja(
Događanja_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null,
Organizator int references DobrovoljnaVatrogasnaDrustvaBaranja(ID) not null,
Datum date not null,
Uzrast varchar (100) not null,
--fotografije spremamo kao putanju 
Fotografije varchar (100),
Ostalo varchar (200)
);
create table Kontakti (
Kontakt_ID int primary key identity (1,1) not null,
Adresa varchar (100) not null,
Emai varchar (100) not null,
Telefon varchar (100) not null
);


create table Upisi (
Upis_ID int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null,
DatumRodenja date,
Iskutvo bit,
Adresa varchar (50) not null,
Email varchar (50) not null,
Mobitel varchar(50) 
);

create table Info (
Info_ID int primary key identity (1,1) not null,
Odrustvu varchar (200),
Osnutak date
);


create table DvDBaranjinVrh(
Drustvo int references Info(Info_ID) not null,
Događanja int references Događanja (Događanja_ID) not null,
Kontakt int references Kontakti (Kontakt_ID) not null,
Upis int references Upisi (Upis_ID) not null
);