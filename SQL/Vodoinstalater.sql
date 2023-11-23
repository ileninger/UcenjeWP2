use edunovawp2;
go

drop database if exists Vodoinstaler;
go

create database Vodoinstalater;
go

Create table StrucneSpreme(
StrucnaSprema_ID int primary key identity (1,1) not null,
StrucnaSprema varchar (50)
);

create table Vodoinstalateri (
Vodoinstalater_ID int primary key identity (1,1) not null,
Ime varchar (50),
Prezime varchar (50),
OiB char (11),
StrucnaSprema int references StrucneSpreme(StrucnaSprema_ID),
);