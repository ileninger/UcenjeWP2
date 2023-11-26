use master;
go 

drop database if exists BabyBlue;
go

create database BabyBlue;
go

alter database BabyBlue collate Croatian_CI_AS;
go

use BabyBlue;
create table Galerije (
Galerija_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null
);
create table Fotografije (
Fotografija_ID int primary key identity (1,1) not null,
Datum date not null,
Naziv varchar (100)
);
create table GalerijaFotografija (
GalerijaFotografija_ID int primary key identity (1,1) not null,
Galerija int references Galerije (Galerija_ID) not null,
Fotografija int references Fotografije (Fotografija_ID) not null
);

create table Korisnici (
Korisnik_ID int primary key identity (1,1) not null,
KorisničkoIme varchar(100) not null,
);

create table Komentari (
Komentar_ID int primary key identity (1,1) not null,
Korisnik int references Korisnici (Korisnik_ID),
Datum date,
TekstKomentara varchar (2000)
);

create table Objave (
Objava_ID int primary key identity (1,1) not null,
Naslov varchar (50) not null,
DatumObjve date not null,
Opis varchar (2000),
GalerijaFotografija int references GalerijaFotografija (GalerijaFotografija_ID),
Komentari int references Komentari (Komentar_ID)
);