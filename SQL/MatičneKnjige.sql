use edunovawp2;
go

drop database if exists DAOS;
go

create database DAOS;
go

alter database DAOS collate Croatian_CI_AS;

use DAOS;

create table Vjerosipovjesti(
Vjera_ID int primary key identity (1,1) not null,
Vjera varchar (100)
);

create table Područja (
Područja_ID int primary key identity (1,1) not null,
Naziv varchar (100),
);

create table MaticaRođenih(
MaticaRođenih_ID int primary key identity (1,1) not null
DatumUpisa date not null,
Ime varchar (100) not null,
Prezime varchar (100) not null,
ImeOca varchar (100),
PrezimeOca varchar (100),
ImeMajke varchar(100) not null,
DjevojackoPrezimeMajke varchar (100),
DatumRođenja date not null,
MjestoRođenja varchar (100) not null
Područje int references Područja (Područja_ID) not null,
Vjeroipovjest int references Vjerosipovjesti (Vjera_ID),
);

create table MaticaUmrlih(
MaticaUmrlih_ID int primary key identity (1,1) not null
DatumUpisa date not null,
Ime varchar (100) not null,
Prezime varchar (100) not null,
OiB char (11) not null,
ImeOca varchar (100) not null,
PrezimeOca varchar (100) not null,
ImeMajke varchar(100) not null,
DjevojackoPrezimeMajke varchar (100),
DatumSmrti date not null,
MjestoSmrti varchar (100) not null,
MjestoUkopa varchar (100) not null
Područje int references Područja (Područja_ID) not null,
Vjeroipovjest int references Vjerosipovjesti (Vjera_ID),
);

create table Ženici (
Ženik_ID int primary key identity (1,1) not null
Ime varchar (50) not null,
Prezime varchar (50) not null,
OiB char (11) not null,
DatumRođenja date not null,
MjestoRođenja varchar (100) not null,
Narodnost varchar (100),
Državljnstvo varchar (100),
PrezimeNakonSklapanjaBraka varchar (100)
);

create table Nevjeste (
Nevjesta_ID int primary key identity (1,1) not null
Ime varchar (50) not null,
Prezime varchar (50) not null,
OiB char (11) not null,
DatumRođenja date not null,
MjestoRođenja varchar (100) not null,
Narodnost varchar (100),
Državljnstvo varchar (100),
PrezimeNakonSklapanjaBraka varchar (100)
);

create table MaticaVjenčanih (
MaticaVjenčanih_ID int primary key identity (1,1) not null
DatumUpisa date not null,
MjestoUpisa varchar (100) not null,
Područje int references Područja (Područja_ID) not null,
Ženik int references Ženici (Ženik_ID) not null,
Nevjesta int references Nevjeste (Nevjesta_ID) not null
);

create table MatičneKnjige(
Matica_ID int primary key identity (1,1) not null
MaticaRođenih int references MaticaRođenih (MaticaRođenih_ID), 
MaticaUmrlih int references MaticaUmrlih (MaticaUmrlih_ID),
MaticaVjenčanih int references MaticaVjenčanih (MaticaVjenčanih_ID)
);