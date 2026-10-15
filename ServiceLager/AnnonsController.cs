using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace ServiceLager
{
    public class AnnonsController
    {
        private BookSwapRegister Register;
        private Användare InloggadAnvändare;

        public AnnonsController(BookSwapRegister register, Användare inloggadAnvändare)
        {
            Register = register;
            InloggadAnvändare = inloggadAnvändare;
        }

        public List<Annons> HämtaTillgängligaAnnonser()
        {
            return Register.HämtaTillgängligaAnnonser();
        }
        #region Metoder för att publicera annons
        public Kursbok PubliceraKursbok(Student säljare, Kurs kurs, string titel, decimal pris, AnnonsSkick skick, string isbn, string författare, int upplaga)
        {
            Kursbok bok = new Kursbok(säljare, kurs, titel, pris, skick, DateTime.Now, isbn, författare, upplaga);
            Register.LäggTillAnnons(bok);
            return bok;
        }

        public Kompendium PubliceraKompendium(Student säljare, Kurs kurs, string titel, decimal pris, AnnonsSkick skick, int antalSidor, int utgivningsÅr)
        {
            Kompendium kompendium = new Kompendium(säljare, kurs, titel, pris, skick, DateTime.Now, antalSidor, utgivningsÅr);
            Register.LäggTillAnnons(kompendium);
            return kompendium;
        }

        public DigitalResurs PubliceraDigitalresurs(Student säljare, Kurs kurs, string titel, decimal pris, AnnonsSkick skick, string filformat, string leveranssätt)
        {
            DigitalResurs digitalresurs = new DigitalResurs(säljare, kurs, titel, pris, skick, DateTime.Now, filformat, leveranssätt);
            Register.LäggTillAnnons(digitalresurs);
            return digitalresurs;
        }

        #endregion

        #region Metoder för att redigera annons
        // Lägg alla metoder för att redigera i den här region, använd pilarna för att collapsa
        // när alla metoder är implementerade

        #endregion

        #region Metoder för att reservera annons

        public Affär ReserveraAnnons(Annons annons)
        {
            if (InloggadAnvändare is not Student köpare)
                throw new InvalidOperationException("Endast studenter kan reservera annonser.");

            if (!annons.KanReserverasAv(köpare))
                throw new InvalidOperationException("Annonsen kan inte reserveras.");

            Affär affär = new Affär(köpare, annons, DateTime.Now);
            annons.MarkeraSomReserverad();
            Register.LäggTillAffär(affär);

            return affär;
        }

        #endregion

        public List<Affär> HämtaMinaAffärer()
        {
            return Register.HämtaAffärer((Student)InloggadAnvändare);
        }
    }
}
