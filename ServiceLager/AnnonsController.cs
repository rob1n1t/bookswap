using Microsoft.Win32;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public List<Annons> HämtaEgnaAnnonser()
        {
            Student student = (Student)InloggadAnvändare;

            return Register.HämtaEgnaAnnonser(student);
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

        public void RedigeraKursbok(
            Kursbok annons,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            string isbn,
            string författare,
            int upplaga)
        {
            Student student = (Student)InloggadAnvändare;

            if (annons.Säljare != student)
            {
                throw new InvalidOperationException(
                    "Du kan bara redigera dina egna annonser.");
            }

            if (annons.Status != AnnonsStatus.TillSalu)
            {
                throw new InvalidOperationException(
                    "Endast annonser som är till salu får redigeras.");
            }

            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("ISBN måste anges.");
            }

            if (string.IsNullOrWhiteSpace(författare))
            {
                throw new ArgumentException("Författare måste anges.");
            }

            if (upplaga <= 0)
            {
                throw new ArgumentException("Upplaga måste anges");
            }

            annons.UppdateraAnnonsUppgifter(
                kurs,
                titel,
                pris,
                skick);

            annons.UppdateraBokUppgifter(
                isbn,
                författare,
                upplaga);
        }

        public void RedigeraKompendium(
            Kompendium annons,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            int antalSidor,
            int utgivningsår)
        {
            Student student = (Student)InloggadAnvändare;

            if (annons.Säljare != student)
            {
                throw new InvalidOperationException(
                    "Du kan bara redigera dina egna annonser.");
            }

            if (annons.Status != AnnonsStatus.TillSalu)
            {
                throw new InvalidOperationException(
                    "Endast annonser som är till salu får redigeras.");
            }

            if (antalSidor <= 0)
            {
                throw new ArgumentException("Antal sidor måste vara större än 0.");
            }

            if (utgivningsår <= 0)
            {
                throw new ArgumentException("Utgivningsår måste vara giltigt.");
            }

            annons.UppdateraAnnonsUppgifter(
                kurs,
                titel,
                pris,
                skick);

            annons.UppdateraKompendieUppgifter(
                antalSidor,
                utgivningsår);
        }

        public void RedigeraDigitalresurs(
            DigitalResurs annons,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            string filformat,
            string leveranssätt)
        {
            Student student = (Student)InloggadAnvändare;

            if (annons.Säljare != student)
            {
                throw new InvalidOperationException(
                    "Du kan bara redigera dina egna annonser.");
            }

            if (annons.Status != AnnonsStatus.TillSalu)
            {
                throw new InvalidOperationException(
                    "Endast annonser som är till salu får redigeras.");
            }

            if (string.IsNullOrWhiteSpace(filformat))
            {
                throw new ArgumentException("Filformat måste anges.");
            }

            if (string.IsNullOrWhiteSpace(leveranssätt))
            {
                throw new ArgumentException("Leveranssätt måste anges.");
            }

            annons.UppdateraAnnonsUppgifter(
                kurs,
                titel,
                pris,
                skick);

            annons.UppdateraDigitalUppgifter(
                filformat,
                leveranssätt);
        }

        public void TaBortAnnons(Annons annons)
        {
            Student student = (Student)InloggadAnvändare;

            if (annons.Säljare != student)
            {
                throw new InvalidOperationException(
                    "Du kan bara ta bort dina egna annonser.");
            }

            if (annons.Status != AnnonsStatus.TillSalu)
            {
                throw new InvalidOperationException(
                    "Endast annonser som är till salu får tas bort.");
            }

            Register.TaBortAnnons(annons);
        }

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
