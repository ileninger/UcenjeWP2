use master;
go

drop database if exists taxisluzba;
go

create  database taxisluzba;
go

use taxisluzba;

create table vozilo(
id int not null primary key identity (1,1),
registracija char (8) not null,
marka varchar (50) not null,
model varchar (50) not null,
serijskibroj char (20) not null,
godinaProizvodnja int not null
);

create table vozaci (
id int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
iban varchar (50),
brojugovora varchar (50),
brojmobitela int,
datumPocetkaRada date,
);

create table putnici (
id int not null primary key identity (1,1),
ime varchar (50) not null,
brojmobitela int,
klubVrijednosti bit,
);

create table voznja(
id int not null primary key identity (1,1),
vozilo int not null,
vozac int not null,
putnik int not null,
vrijeme date not null,
);

create table putnikvoznja(
id int not null primary key identity (1,1),
putnik int not null,
brojvoznji int,
);


alter table voznja add foreign key (vozilo) references vozilo(id);
alter table voznja add foreign key (vozac) references vozaci(id);
alter table voznja add foreign key (putnik) references putnici(id);

alter table putnikvoznja add foreign key (putnik) references putnici (id);
--alter table voznja add foreign key (smjer) references  smjerovi (sifra);