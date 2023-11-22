use edunovawp2;
go

drop database if exists Samostan;
go

create database Samostan;
go

use Samostan;

create table Svecenici (
Svecenik_ID int primary key identity (1,1) not null,
Ime varchar (50),
Prezime varchar (50),
Nadredeni_svecenik int references Svecenici (Svecenik_ID) not null
);

create table Poslovi (
Posao_ID int primary key identity (1,1) not null,
Naziv varchar(50),
Opis varchar (200)
);

create table Svecenik_posao(
Svecenik_ID int references Svecenici (Svecenik_ID),
Posao_ID int references Poslovi (Posao_ID)
);
