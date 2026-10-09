using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kontouppgifter
    {
        public string Epostadress { get; }
        private string Losenord { get; }

        public Kontouppgifter(string epostadress, string losenord)
        {
            Epostadress = epostadress;
            Losenord = losenord;
        }

        public Kontouppgifter(string epostadress, string losenord)
        {
            if (string.IsNullOrWhiteSpace(epostadress))
            {
                throw new ArgumentException("E-postadress får inte vara tom eller null.", nameof(epostadress));
            }
            if (string.IsNullOrWhiteSpace(losenord))
            {
                throw new ArgumentException("Lösenord får inte vara tom eller null.", nameof(losenord));
            }

            Epostadress = epostadress.Trim();   // trim ignorerar blanksteg
            Losenord = losenord;
        }
        public bool VerifieraLosenord(string losenord)
        {
            return Losenord == losenord;
        }

    }
}
