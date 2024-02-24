using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("CiklicneMatrice")]
    public class CiklicneMatrice : ControllerBase
    {
        //Ciklicna matrica u smjeru sata
        [HttpGet]
        [Route("Ciklo1")]

        public string Ciklo1(int Redovi, int Stupci)
        {
            int Brojac = 1; //Rezultat koji spremamo u matricu
                            // RedPocetak, RedKrajm StupacPocetak i StupacKraj definiraju rubne uvjete

            int RedPoc = 0, RedKraj = Redovi - 1;
            int KolPoc = 0, KolKraj = Stupci - 1;

            int[,] CiklickaMatica = new int[Redovi, Stupci]; // Ciklicku matticu spremamo u niz
            StringBuilder PrikazCiklickeMatrice = new StringBuilder(); //Ciklicka matrica za prikaz

            //if dok se ne popune sva mjesta u matrici

            while (RedPoc <= RedKraj && KolPoc <= KolKraj)
            {
                //Popunjavamo najdonji redak
                for (int j = KolKraj;  j >= KolPoc; j--) 
                {
                    CiklickaMatica[RedKraj, j] = Brojac++;
                }
                RedKraj--;

                // Popinjavamo Lijevi stupac

                for (int i = RedKraj; i >= RedPoc; i--)
                {
                    CiklickaMatica[i, KolPoc] = Brojac++;
                }
                KolPoc++;

                // Popunjavamo gornji redak - moramo se osigurat da se gleda najgornji redak preko if-a
                if (RedPoc <= RedKraj)
                {
                    for (int j = KolPoc; j <=KolKraj; j++)
                    {
                        CiklickaMatica[RedPoc,j] = Brojac++;
                    }
                    RedPoc++;
                }

                // Popunjavamo desni stupac, osiguramo se preko if-a da dode na najzadnje slobodno mjesto

                if (KolPoc <= KolKraj)
                {
                    for (int i = RedPoc; i <=RedKraj; i++)
                    {
                        CiklickaMatica[i, KolKraj] = Brojac++;
                    }
                    KolKraj--;
                }
            }
          

            //Ispis matrice
            for (int i = 0; i<Redovi; i++)
            {
                for(int j = 0; j < Stupci; j++)
                {
                    PrikazCiklickeMatrice.Append(CiklickaMatica[i, j]+ "\t"); // prikaz stupaca
                }
                PrikazCiklickeMatrice.AppendLine();//Prikaz stupaca
            }
            return PrikazCiklickeMatrice.ToString(); 

        }

        [HttpGet]
        [Route("Ciklo2")]

        public string Ciklo2(int Redovi, int Stupci)
        {
            int Brojac = 1; //Rezultat koji spremamo u matricu
                            // RedPocetak, RedKrajm StupacPocetak i StupacKraj definiraju rubne uvjete

            int RedPoc = 0, RedKraj = Redovi - 1;
            int KolPoc = 0, KolKraj = Stupci - 1;

            int[,] CiklickaMatica = new int[Redovi, Stupci]; // Ciklicku matticu spremamo u niz
            StringBuilder PrikazCiklickeMatrice = new StringBuilder(); //Ciklicka matrica za prikaz

            //if dok se ne popune sva mjesta u matrici

            while (RedPoc <= RedKraj && KolPoc <= KolKraj)
            {
                //Popunjavamo najdonji redak
                for (int j = KolKraj; j >= KolPoc; j--)
                {
                    CiklickaMatica[j, RedKraj] = Brojac++;
                }
                RedKraj--;

                // Popinjavamo Lijevi stupac

                for (int i = RedKraj; i >= RedPoc; i--)
                {
                    CiklickaMatica[KolPoc, i] = Brojac++;
                }
                KolPoc++;

                // Popunjavamo gornji redak - moramo se osigurat da se gleda najgornji redak preko if-a
                if (RedPoc <= RedKraj)
                {
                    for (int j = KolPoc; j <= KolKraj; j++)
                    {
                        CiklickaMatica[j, RedPoc] = Brojac++;
                    }
                    RedPoc++;
                }

                // Popunjavamo desni stupac, osiguramo se preko if-a da dode na najzadnje slobodno mjesto

                if (KolPoc <= KolKraj)
                {
                    for (int i = RedPoc; i <= RedKraj; i++)
                    {
                        CiklickaMatica[KolKraj, i] = Brojac++;
                    }
                    KolKraj--;
                }
            }


            //Ispis matrice
            for (int i = 0; i < Redovi; i++)
            {
                for (int j = 0; j < Stupci; j++)
                {
                    PrikazCiklickeMatrice.Append(CiklickaMatica[i, j] + "\t"); // prikaz stupaca
                }
                PrikazCiklickeMatrice.AppendLine();//Prikaz stupaca
            }
            return PrikazCiklickeMatrice.ToString();

        }

    }
}