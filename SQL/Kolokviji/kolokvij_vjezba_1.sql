use master;
go

drop database if exists Vjezba1;
go

create database Vjezba1;
go

alter database Vjezba1 collate Croatian_CI_AS;
go

use Vjezba1;
create table svekri(
sifra int primary key identity (1,1) not null,
bojaociju varchar (40),
prstena int not null,
deukserica varchar (41) not null,
lipa decimal (13,8) not null,
eura decimal (12,7) not null,
majice varchar (35)  not null
);


create table sestre(
sifra int primary key identity (1,1) not null,
introvertno bit not null,
haljina varchar(31),
maraka decimal (16,6) not null,
hlace varchar (46),
narukvica int
);
create table sestre_svekari(
sifra int,
sestra int references sestre (sifra),
svekar int references svekri (sifra)
);

create table zene(
sifra int primary key identity (1,1),
treciputa datetime not null,
hlace varchar (46) not null,
kratkamajica varchar (31),
jmbah char (11),
bojaociju varchar (39),
haljina varchar (44) not null,
sestra int references sestre (sifra)
);

create table muskarci (
sifra int primary key identity (1,1),
bojaociju varchar (50),
hlace varchar (30) not null,
modelnacaonala varchar (43) not null,
marka decimal (14,5),
zena int references zene (sifra)
);

create table mladici (
sifra int primary key identity (1,1), 
suknja varchar (50),
kuna decimal (16,8),
drugiputa datetime not null,
asocijalno bit not null,
ekstrovertno bit,
dukserica varchar (48),
muskarac int references muskarci (sifra)
);

create table punci (
sifra int primary key,
ogrlica int not null,
gustoca decimal (14,9) not null,
hlace varchar (41)
);

create table cura(
sifra int primary key identity (1,1),
novcica decimal (16,5),
gustoca decimal (18,6),
lipa decimal (13,10) not null,
ogrilca int,
bojakose varchar (38) not null,
suknja varchar (36) not null,
punac int references punci (sifra)
);