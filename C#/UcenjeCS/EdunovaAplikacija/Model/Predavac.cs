﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.EdunovaAplikacija.Model
{
    internal class Predavac : Osoba
    {
        public string Iban { get; set; }

        public override string ToString()
        {
            return "\n Ime: " + Ime + "\n Prezime: " + Prezime + "\n OiB: " + Oib + "\n Email: " + Email + "\n Iban: " + Iban;
        }

    }
}
