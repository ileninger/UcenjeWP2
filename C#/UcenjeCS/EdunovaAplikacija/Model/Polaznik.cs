using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.EdunovaAplikacija.Model
{
    internal class Polaznik:Osoba
    {
        public string BrojUgovora { get; set; }
        public override string ToString()
        {
            return "Ime: " + Ime + " Prezime: " + Prezime + " OiB: " + Oib + " Email: " + Email + " BrojUgovora: " + BrojUgovora;
        }
    }
}
