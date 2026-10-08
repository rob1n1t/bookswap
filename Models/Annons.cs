using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Annons
    {
        public Student Säljare { get; private set; }
        public Kurs Kurs { get; private set; }
        public string Titel { get; private set; }
        public decimal Pris { get; private set; }
        public AnnonsSkick Skick { get; private set; }
        public DateTime Publiceringsdatum { get; private set; }
        public AnnonsStatus Status { get; private set; }

        protected Annons(
            Student säljare,
            Kurs kurs,
            string titel,
            decimal pris,
            AnnonsSkick skick,
            DateTime publiceringsdatum)
        {
            Säljare = säljare;
            Kurs = kurs;
            Titel = titel;
            Pris = pris;
            Skick = skick;
            Publiceringsdatum = publiceringsdatum;
            Status = AnnonsStatus.TillSalu;
        }

        public bool KanReserverasAv(Student köpare)
        {
            return Status == AnnonsStatus.TillSalu && köpare != Säljare;
        }

        public void MarkeraSomReserverad()
        {
            Status = AnnonsStatus.Reserverad;
        }
    }
}
