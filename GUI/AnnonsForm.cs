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
            UppdateraAffärslista();
        }

        private void btnNyAnnons_Click(object sender, EventArgs e)
        {
            HanteraAnnonsForm hanteraAnnonsFormulär = new HanteraAnnonsForm(register, inloggadStudent);
            hanteraAnnonsFormulär.ShowDialog();
            hanteraAnnonsFormulär.Dispose();

        }

        private void UppdateraAnnonslista()
        {
            List<Annons> annonser;

            if (visarEgnaAnnonser)
            {
                annonser = annonsController.HämtaEgnaAnnonser();
                btnReservera.Enabled = false;
            }
            else
            {
                annonser = annonsController.HämtaTillgängligaAnnonser();
                btnReservera.Enabled = false;
            }

            lstAnnonser.DataSource = null;
            lstAnnonser.DataSource = annonser;
            lstAnnonser.DisplayMember = "Titel";
            lstAnnonser.ClearSelected();

            valdAnnons = null;
            txtAnnonsdetaljer.Clear();

            if (annonser.Count == 0)
            {
                if (visarEgnaAnnonser)
                {
                    lblAntalAnnonser.Text = "Du har inga annonser";
                }
                else
                {
                    lblAntalAnnonser.Text = "Det finns inga tillgängliga annonser";
                }
            }
            else
            {
                lblAntalAnnonser.Text = "Antal annonser: " + annonser.Count;
            }
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

            if (!visarEgnaAnnonser && valdAnnons.KanReserverasAv(inloggadStudent))
            {
                btnReservera.Enabled = true;
            }
            else
            {
                btnReservera.Enabled = false;
            }
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
                UppdateraAffärslista();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Kunde inte reservera",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnVisaEgna_Click(object sender, EventArgs e)
        {
            visarEgnaAnnonser = true;
            UppdateraAnnonslista();
        }

        private void btnRedigera_Click(object sender, EventArgs e)
        {
            if (valdAnnons == null)
            {
                MessageBox.Show("Välj först en annons som ska redigeras.");
                return;
            }

            HanteraAnnonsForm hanteraAnnonsForm = new HanteraAnnonsForm(
                register,
                inloggadStudent,
                valdAnnons);

            DialogResult resultat = hanteraAnnonsForm.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                visarEgnaAnnonser = true;
                UppdateraAnnonslista();
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (valdAnnons == null)
            {
                MessageBox.Show("Välj först en annons som ska tas bort.");
                return;
            }

            DialogResult svar = MessageBox.Show(
                "Är du säker på att du vill ta bort annonsen?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo);

            if (svar == DialogResult.No)
            {
                return;
            }

            try
            {
                annonsController.TaBortAnnons(valdAnnons);
                UppdateraAnnonslista();
                MessageBox.Show("Annonsen har tagits bort.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UppdateraAffärslista()
        {
            List<Affär> affärer = annonsController.HämtaMinaAffärer();

            lstAffärer.DataSource = null;
            lstAffärer.DataSource = affärer;
            lstAffärer.ClearSelected();

            if (affärer.Count == 0)
                lblAntalAffärer.Text = "Du har inga reservationer";
            else
                lblAntalAffärer.Text = "Antal: " + affärer.Count;
        }
    }
}
