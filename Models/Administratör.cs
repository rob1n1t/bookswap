using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Administratör : Användare
    {
        public Administratör(string förnamn,string efternamn,string telefonnummer,Kontouppgifter kontouppgifter)
            : base(förnamn, efternamn, telefonnummer, kontouppgifter)
        { 
        }
    
    }
}
