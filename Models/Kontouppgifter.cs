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

            string trimmadEpostadress = epostadress.Trim();
            if (trimmadEpostadress.Any(char.IsWhiteSpace))
            {
                throw new ArgumentException("E-postadress får inte innehålla mellanslag.", nameof(epostadress));
            }

            Epostadress = trimmadEpostadress;
            Lösenord = lösenord;
        }
        public bool VerifieraLösenord(string lösenord)
        {
            return Lösenord == lösenord;
        }

    }
}
