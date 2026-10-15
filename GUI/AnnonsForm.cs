using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using ServiceLager;

namespace GUI
{
    public partial class AnnonsForm : Form
    {
        private BookSwapRegister register;
        private Student inloggadStudent;
        private AnnonsController annonsController;
        private Annons? valdAnnons;
        private bool visarEgnaAnnonser = false;


        public AnnonsForm(BookSwapRegister register, Student student)
        {
            InitializeComponent();
            this.register = register;
            inloggadStudent = student;
            annonsController = new AnnonsController(register, student);
            UppdateraAnnonslista();
        }

        private void btnNyAnnons_Click(object sender, EventArgs e)
        {
            HanteraAnnonsForm hanteraAnnonsFormulär = new HanteraAnnonsForm(register, inloggadStudent);
            hanteraAnnonsFormulär.ShowDialog();
            hanteraAnnonsFormulär.Dispose();

        }


        private void UppdateraAnnonslista()
        {
            List<Annons> annonser = annonsController.HämtaTillgängligaAnnonser();

            lstAnnonser.DataSource = null;
            lstAnnonser.DataSource = annonser;
            lstAnnonser.DisplayMember = "Titel";
            lstAnnonser.ClearSelected();

            valdAnnons = null;
            txtAnnonsdetaljer.Clear();

            if (annonser.Count == 0)
                lblAntalAnnonser.Text = "Det finns inga tillgängliga annonser";
            else
                lblAntalAnnonser.Text = "Antal annonser: " + annonser.Count;
        }

        private void btnVisaTillgängliga_Click(object sender, EventArgs e)
        {
            visarEgnaAnnonser = false;
            UppdateraAnnonslista();
        }

        private void lstAnnonser_SelectedIndexChanged(object sender, EventArgs e)
        {
            valdAnnons = lstAnnonser.SelectedItem as Annons;

            if (valdAnnons == null)
            {
                txtAnnonsdetaljer.Clear();
                return;
            }

            string detaljer =
                "Titel: " + valdAnnons.Titel + Environment.NewLine +
                "Kurs: " + valdAnnons.Kurs.Kurskod + " " + valdAnnons.Kurs.Namn + Environment.NewLine +
                "Pris: " + valdAnnons.Pris + " kr" + Environment.NewLine +
                "Skick: " + valdAnnons.Skick + Environment.NewLine +
                "Säljare: " + valdAnnons.Säljare.Förnamn + " " + valdAnnons.Säljare.Efternamn + Environment.NewLine +
                "Publicerad: " + valdAnnons.Publiceringsdatum.ToShortDateString() + Environment.NewLine +
                "Status: " + valdAnnons.Status;

            if (valdAnnons is Kursbok bok)
            {
                detaljer += Environment.NewLine + "ISBN: " + bok.ISBN +
                    Environment.NewLine + "Författare: " + bok.Författare +
                    Environment.NewLine + "Upplaga: " + bok.Upplaga;
            }
            else if (valdAnnons is Kompendium kompendium)
            {
                detaljer += Environment.NewLine + "Antal sidor: " + kompendium.AntalSidor +
                    Environment.NewLine + "Utgivningsår: " + kompendium.UtgivningsÅr;
            }
            else if (valdAnnons is DigitalResurs digital)
            {
                detaljer += Environment.NewLine + "Filformat: " + digital.Filformat +
                    Environment.NewLine + "Leveranssätt: " + digital.Leveranssätt;
            }

            txtAnnonsdetaljer.Text = detaljer;
        }

        private void btnReservera_Click(object sender, EventArgs e)
        {
            if (valdAnnons == null)
            {
                MessageBox.Show("Välj en annons i listan först.",
                    "Ingen annons vald", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                annonsController.ReserveraAnnons(valdAnnons);

                MessageBox.Show("Annonsen är reserverad.",
                    "Reservation klar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UppdateraAnnonslista();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Kunde inte reservera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMinaAffärer_Click(object sender, EventArgs e)
        {
            MinaAffärerForm minaAffärerFormulär = new MinaAffärerForm(register, inloggadStudent);
            minaAffärerFormulär.ShowDialog();
            minaAffärerFormulär.Dispose();
        }
    }
}
