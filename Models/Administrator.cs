using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Administrator : Anvandare
    {
        public Administrator(
            string fornamn,
            string efternamn,
            string telefonnummer,
            Kontouppgifter kontouppgifter)
            : base(fornamn, efternamn, telefonnummer, kontouppgifter)
        { 
        }
    
    }
}
