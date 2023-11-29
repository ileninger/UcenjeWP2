--use Zadatak1;
--go

--insert into Zupani (Ime,Prezime) values 
--('Ivan','Anušić'),
--('Zlatko', 'Komadina'),
--('Boris','Miletić');

--insert into Zupanije (Zupan,Naziv) values 
--(1,'Osječko-baranjska'),
--(2,'Primorsko-goranska'),
--(3,'Istarska');

--insert into Opcine (Zupanija,Naziv) values 
--(1,'Čepin'),(1,'Vuka'),(1,'Draž'),
--(3,'Bale'),(3,'Ližnjan'),(3,'Medulin'),
--(2,'Fužine'), (2,'Punat'),(2,'Omišalj');

--select * from Opcine;
--insert into Mjesta (Opcina,Naziv) values 
--(9,'Njivice'), (9,'Omišalj'),
--(7,'Fužine'),(7,'Vrata'),(7,'Lič'),
--(8,'Punat'),(6,'Stara Baška'),
--(6,'Medulin'),(6,'Vinkuran'),(6,'Pomer'),
--(4,'Bale'),(4,'Goleš'),(4,'Grmed'),
--(5,'Ližnjan'),(5,'Jadreški'),(5,'Muntić'),
--(3,'Draž'),(3,'Kneževi Vinogradi'), (3,'Batina'),
--(2,'Vuka'),(2,'Hrastovac'),(2,'Lipovac Hrastinski'),
--(1,'Čepin'), (1,'Bekentinci'),(1,'Čokadinci');

--select * from Mjesta;

select a.Naziv,b.Ime,b.Prezime, c.Naziv
from Zupanije a inner join Zupani b
on a.Zupanija_ID = b.Zupan_ID
inner join Opcine c on a.Naziv = c.Opcina_ID;
--inner join Opcine c on a.Zupanija_ID=c.Naziv;

