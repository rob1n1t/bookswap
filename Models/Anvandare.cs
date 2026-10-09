using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Anvandare
    {
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Telefonnummer { get; set; }
        public Kontouppgifter Kontouppgifter { get; set; }

        protected Anvandare(
            string fornamn,
            string efternamn,
            string telefonnummer,
            Kontouppgifter kontouppgifter)

        { 
            Fornamn = fornamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
            Kontouppgifter = kontouppgifter;
        }
    }
}
