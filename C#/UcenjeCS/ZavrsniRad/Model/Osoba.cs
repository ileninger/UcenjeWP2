using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.ZavrsniRad.Model
{
    internal class Osoba
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateOnly DatumZaposlenja { get; set; }

        public string IBAN { get; set; }
        public string OiB { get; set; }

        public string Email { get; set; }
    }
}
