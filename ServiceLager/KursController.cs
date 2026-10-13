using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLager
{
    public class KursController
    {
        private BookSwapRegister register;
        private Användare inloggadAnvändare;

        public KursController(BookSwapRegister register, Användare användare)
        {
            this.register = register;
            inloggadAnvändare = användare;
        }

        public List<Kurs> HämtaKurser()
        {
            return register.HämtaKurser();
        }

        public Kurs LäggTillKurs(string kurskod, string namn)
        {
            if (inloggadAnvändare is not Administratör)
            {
                throw new UnauthorizedAccessException(
                    "Endast administratörer får lägga till kurser.");
            }

            bool kurskodFinns = register.HämtaKurser().Any(kurs =>
                kurs.Kurskod.Equals(kurskod.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (kurskodFinns)
            {
                throw new InvalidOperationException(
                    "Det finns redan en kurs med den kurskoden.");
            }

            Kurs nyKurs = new Kurs(kurskod, namn);

            register.LäggTillKurs(nyKurs);

            return nyKurs;
        }

        public void RedigeraKurs(Kurs kurs,string kurskod,string namn)
        {
            if (inloggadAnvändare is not Administratör)
            {
                throw new UnauthorizedAccessException(
                    "Endast administratörer får redigera kurser.");
            }

            if (kurs == null)
            {
                throw new ArgumentException("Ingen kurs har valts.");
            }

            List<Kurs> kurser = register.HämtaKurser();

            if (!kurser.Contains(kurs))
            {
                throw new InvalidOperationException(
                    "Kursen finns inte i registret.");
            }

            string nyKurskod = kurskod.Trim();

            //Kontrollerar om den nya kurskoden redan används av någon annan kurs
            bool kurskodUpptagen = kurser.Any(annanKurs =>
                annanKurs != kurs &&
                annanKurs.Kurskod.Equals(nyKurskod,
                StringComparison.OrdinalIgnoreCase));

            if (kurskodUpptagen)
            {
                throw new InvalidOperationException(
                    "Det finns redan en annan kurs med den kurskoden.");
            }

            kurs.UppdateraKursuppgifter(kurskod, namn);
        }

        public void TaBortKurs(Kurs kurs)
        {
            if (inloggadAnvändare is not Administratör)
            {
                throw new UnauthorizedAccessException(
                    "Endast administratörer får ta bort kurser.");
            }

            if (kurs == null)
            {
                throw new ArgumentException("Ingen kurs har valts.");
            }

            if (!register.HämtaKurser().Contains(kurs))
            {
                throw new InvalidOperationException(
                    "Kursen finns inte i registret.");
            }

            //Finns det någon annons där annonsens kurs är samma som kursen vi försöker ta bort?
            bool kursAnvänds = register.HämtaAnnonser()
                .Any(annons => annons.Kurs == kurs);

            if (kursAnvänds)
            {
                throw new InvalidOperationException(
                    "Kursen kan inte tas bort eftersom den används av en eller flera annonser.");
            }

            register.TaBortKurs(kurs);
        }
    }
}
