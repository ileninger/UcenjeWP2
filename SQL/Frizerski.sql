use edunovawp2;
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
Kontakt varchar (50),
Spol bit not null
);

create table Usluge(
Usluga_ID int primary key identity (1,1) not null,
Naziv varchar(50) not null,
Cijena decimal (18,2) not null,
Trajanje decimal (18,2)
);

create table Posjeta (
Posjeta_ID int primary key identity (1,1) not null,
Djelatnik int references Djelatnici (Djelatinik_ID)  not null,
Korsnik int references Korisnici (Korisnik_ID) not null,
Usluga int references Usluge (Usluga_ID) not null,
Datum date
);


--Unošenje baze

insert into Djelatnici(Ime,Prezime,OiB,IBAN) values
('Chad','Elliott','89116494507','HR2723400091384832368'),
('Eleanor','Friedman','90333142589','HR2723400091384832368'),
('Uzair','Blackwell','95165917419','HR2723400091384832368'),
('Caspar','Cook','78480095107','HR2723400091384832368');

insert into Korisnici (Ime,Prezime,Spol) values
	('Ivo','Marić',1),
	('Magdalena','Katušić',2),
	('Terezija','Omijec',2);

select * from Posjeta;

insert into Usluge(Naziv,Cijena,Trajanje) values
	('Šišanje',5.00,1.00),
	('Feniranje',2.00,0.15);

select * from Posjeta
INNER JOIN Djelatnici on Posjeta.Djelatnik=Djelatnici.Djelatinik_ID