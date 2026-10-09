using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Användare
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Telefonnummer { get; set; }
        public Kontouppgifter Kontouppgifter { get; set; }

        protected Användare(string förnamn,string efternamn,string telefonnummer,Kontouppgifter kontouppgifter)
        { 
            Förnamn = förnamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
            Kontouppgifter = kontouppgifter;
        }
    }
}
