use master;
go

drop database if exists Zadatak1;
go

create database Zadatak1;
go

alter database Zadatak1 collate Croatian_CI_AS;
go

use zadatak1;

create table Zupani (
Zupan_ID int primary key identity (1,1) not null,
Ime varchar (50) not null,
Prezime varchar (50) not null
);

create table Opcine (
Opcina_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null,
Zupanija int not null
);

create table Mjesta (
Mjesto_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null,
Opcina int references Opcine (Opcina_ID)
);

create table Zupanije (
Zupanija_ID int primary key identity (1,1) not null,
Naziv varchar (100) not null,
Zupan int references Zupani(Zupan_ID)
);

alter table Opcine add foreign key (Zupanija) references Zupanije (Zupanija_ID)

--foreign key (predavac) references predavaci(sifra);