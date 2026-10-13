using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Kurs
    {
        public string Kurskod { get; private set; }
        public string Namn { get; private set; }

        public Kurs(string kurskod, string namn)
        {
            if (string.IsNullOrWhiteSpace(kurskod))
            {
                throw new ArgumentException("Kurskod måste anges.");
            }

            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new ArgumentException("Kursnamn måste anges.");
            }
            
            Kurskod = kurskod.Trim();
            Namn = namn.Trim();
        }

        public void UppdateraKursuppgifter(string kurskod, string namn)
        {
            if (string.IsNullOrWhiteSpace(kurskod))
            {
                throw new ArgumentException("Kurskod måste anges.");
            }

            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new ArgumentException("Kursnamn måste anges.");
            }

            Kurskod = kurskod.Trim();
            Namn = namn.Trim();
        }
    }
}
