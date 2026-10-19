using System;
using System.Collections.Generic;
using Models;

namespace ServiceLager
{
    public class BookSwapRegister
    {
        private List<Annons> Annonser { get; }
        private List<Affär> Affärer { get; }
        private List<Användare> Användare { get; }
        private List<Kurs> Kurser { get; }

        public BookSwapRegister()
        {
            Annonser = new List<Annons>();
            Affärer = new List<Affär>();
            Användare = new List<Användare>();
            Kurser = new List<Kurs>();
        }

        public void LäggTillAnvändare(Användare nyAnvändare)
        {
            Användare.Add(nyAnvändare);
        }

        public Användare? HittaAnvändareViaEpost(string epost)
        {
            foreach (Användare aktuellAnvändare in Användare)
            {
                if (string.Equals(aktuellAnvändare.Kontouppgifter.Epostadress, epost,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return aktuellAnvändare;
                }
            }

            return null;
        }

        public void LäggTillKurs(Kurs nyKurs)
        {
            Kurser.Add(nyKurs);
        }

        public void LäggTillAnnons(Annons nyAnnons)
        {
            Annonser.Add(nyAnnons);
        }

        public List<Annons> HämtaTillgängligaAnnonser()
        {
            List<Annons> tillgängliga = new List<Annons>();

            foreach (Annons aktuellAnnons in Annonser)
            {
                if (aktuellAnnons.Status == AnnonsStatus.TillSalu)
                {
                    tillgängliga.Add(aktuellAnnons);
                }
            }

            return tillgängliga;
        }

        public void LäggTillAffär(Affär affär)
        {
            Affärer.Add(affär);
        }

        public List<Affär> HämtaAffärer(Student student)
        {
            List<Affär> studentensAffärer = new List<Affär>();

            foreach (Affär aktuellAffär in Affärer)
            {
                if (aktuellAffär.Köpare == student || aktuellAffär.Annons.Säljare == student)
                {
                    studentensAffärer.Add(aktuellAffär);
                }
            }

            return studentensAffärer;
        }
        public List<Kurs> HämtaKurser()
        {
            return new List<Kurs>(Kurser);
        }

        public void TaBortKurs(Kurs kurs)
        {
            Kurser.Remove(kurs);
        }

        public List<Annons> HämtaAnnonser()
        {
            return new List<Annons>(Annonser);
        }

        public List<Annons> HämtaEgnaAnnonser(Student säljare)
        {
            List<Annons> egnaAnnonser = new List<Annons>();

            foreach (Annons annons in Annonser)
            {
                if (annons.Säljare == säljare)
                {
                    egnaAnnonser.Add(annons);
                }
            }

            return egnaAnnonser; 
        }

        public void TaBortAnnons(Annons annons)
        {
            Annonser.Remove(annons);
        }

        #region Exempeldata
        public void FyllMedExempelData()
        {
            // Skapar 4 studenter
            Kontouppgifter bertilKonto = new Kontouppgifter("bertil@gmail.com", "berra1234");
            Student bertil = new Student("Bertil", "Bertilsson", "0731234567", bertilKonto);
            LäggTillAnvändare(bertil);

            Kontouppgifter stinaKonto = new Kontouppgifter("stina@gmail.com", "stina1337");
            Student stina = new Student("Stina", "Stinasson", "0731337854", stinaKonto);
            LäggTillAnvändare(stina);

            Kontouppgifter klasKonto = new Kontouppgifter("klas@gmail.com", "klas99!");
            Student klas = new Student("Klas", "Klasson", "0739876543", klasKonto);
            LäggTillAnvändare(klas);

            Kontouppgifter oliviaKonto = new Kontouppgifter("olivia@gmail.com", "0l1v14");
            Student olivia = new Student("Olivia", "Olsson", "0731246810", oliviaKonto);
            LäggTillAnvändare(olivia);

            // Skapar 1 administratör
            Kontouppgifter adminKonto = new Kontouppgifter("admin@gmail.com", "password");
            Administratör admin = new Administratör("Adam", "Adamsson", "0739753197", adminKonto);
            LäggTillAnvändare(admin);

            // Skapa hårdkodade kurser
            Kurs gProgCSharp = new Kurs("NGC011", "Grundläggande programmering med C#");
            Kurs objekt1 = new Kurs("C10B1B", "Objektorienterad systemutveckling 1");
            Kurs samdig = new Kurs("SAMDIG", "Samhällets digitalisering");
            LäggTillKurs(gProgCSharp);
            LäggTillKurs(objekt1);
            LäggTillKurs(samdig);

            // Skapar 4 annonser
            Kursbok kursbok1 = new Kursbok(
             bertil,
             objekt1,
             "Object oriented AAD",
             545m,
             AnnonsSkick.BraSkick,
             DateTime.Today,
             "9780201895513",
             "Grady Booch",
             3);

            Kursbok kursbok2 = new Kursbok(
                stina,
                objekt1,
                "Pro C# 10 with .NET 6",
                586m,
                AnnonsSkick.Nyskick,
                DateTime.Today,
                "9781484278680",
                "Andrew Troelsen",
                11);

            Kompendium kompendium = new Kompendium(
                klas,
                gProgCSharp,
                "Kurskompendium C#",
                100m,
                AnnonsSkick.Slitet,
                DateTime.Today,
                80,
                2026);

            DigitalResurs digitalResurs = new DigitalResurs(
                olivia,
                gProgCSharp,
                "Programmeringsövningar",
                50m,
                AnnonsSkick.BraSkick,
                DateTime.Today,
                "PDF",
                "Nedladdningslänk");

            LäggTillAnnons(kursbok1);
            LäggTillAnnons(kursbok2);
            LäggTillAnnons(kompendium);
            LäggTillAnnons(digitalResurs);

            // Skapar 1 affär
            Affär affär1 = new Affär(bertil, digitalResurs, DateTime.Now);
            digitalResurs.MarkeraSomReserverad();
            LäggTillAffär(affär1);
        }

        #endregion
    }
}