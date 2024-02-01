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
            return "\n Ime: " + Ime + "\n Prezime: " + Prezime + "\n OiB: " + Oib + "\n Email: " + Email + "\n BrojUgovora: " + BrojUgovora;
        }
    }
}
