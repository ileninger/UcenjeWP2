using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.EdunovaAplikacija.Model
{
    internal class Grupe:Entitet
    {
        public string Naziv { get; set; }
        public DateTime DatumPocetka { get; set; }

        public Smjer Smjer { get; set; }

        public List <Polaznik> Polaznici { get; set; }
    }
}
