using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Affär
    {
        public Student Köpare { get; private set; }
        public Annons Annons { get; private set; }
        public DateTime Reservationsdatum { get; private set; }
        public AffärsStatus Status { get; private set; }

        public Affär(Student köpare, Annons annons, DateTime datum)
        {
            Köpare = köpare;
            Annons = annons;
            Reservationsdatum = datum;
            Status = AffärsStatus.Reserverad;
        }
        public override string ToString()
        {
            return Annons.GetType().Name + " | " + Annons.Titel + " | " + Reservationsdatum.ToShortDateString() + " | " + Status + " | " + Annons.Säljare.Förnamn + " " +  Annons.Säljare.Efternamn + " | " + Annons.Pris + "kr";
        }
    }
}
