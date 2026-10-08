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

        public Affär(Student kopare, Annons annons, DateTime datum)
        {
            Köpare = kopare;
            Annons = annons;
            Reservationsdatum = datum;
            Status = AffärsStatus.Reserverad;
        }
    }
}
