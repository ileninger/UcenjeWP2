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
--insert into Mjesta (Opcina, Naziv) values 
--(10,'Njivice'), (10,'Omišalj'),
--(8,'Fužine'),(8,'Vrata'),(8,'Lič'),
--(9,'Punat'),(9,'Stara Baška'),
--(7,'Medulin'),(7,'Vinkuran'),(7,'Pomer'),
--(5,'Bale'),(5,'Goleš'),(5,'Grmed'),
--(6,'Ližnjan'),(6,'Jadreški'),(6,'Muntić'),
--(4,'Draž'),(4,'Kneževi Vinogradi'), (4,'Batina'),
--(3,'Vuka'),(3,'Hrastovac'),(3,'Lipovac Hrastinski'),
--(2,'Čepin'), (2,'Bekentinci'),(2,'Čokadinci');

--select * from Mjesta;

--select a.Naziv,b.Ime,b.Prezime, c.Naziv 
--from Zupanije a inner join Zupani b
--on a.Zupanija_ID = b.Zupan_ID
--inner join Opcine c on a.Zupanija_ID=c.Naziv;

