using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kontouppgifter
    {
        public string Epostadress { get; }
        private string Lösenord { get; }

        public Kontouppgifter(string epostadress, string lösenord)
        {
            if (string.IsNullOrWhiteSpace(epostadress))
            {
                throw new ArgumentException("E-postadress får inte vara tom eller null.", nameof(epostadress));
            }
            if (string.IsNullOrWhiteSpace(lösenord))
            {
                throw new ArgumentException("Lösenord får inte vara tom eller null.", nameof(lösenord));
            }

            Epostadress = epostadress.Trim();   // trim ignorerar blanksteg
            Lösenord = lösenord;
        }
        public bool VerifieraLösenord(string lösenord)
        {
            return Lösenord == lösenord;
        }

    }
}
