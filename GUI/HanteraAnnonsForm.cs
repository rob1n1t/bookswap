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
    public partial class HanteraAnnonsForm : Form
    {
        private AnnonsController annonsController;
        private KursController kursController;
        private Annons? annons;
        private Student säljare;
        public HanteraAnnonsForm(BookSwapRegister register, Student student, Annons? annons = null)
        {
            InitializeComponent();
            säljare = student;
            annonsController = new AnnonsController(register, student);
            kursController = new KursController(register, student);

            // Lägger till valen för dropdownlistan Annonstyp
            cmbAnnonsTyp.Items.AddRange(new object[] { "Kursbok", "Kompendium", "Digitalresurs" });

            cmbSkick.DataSource = Enum.GetValues(typeof(AnnonsSkick));
            VisaKurser();

            // Bestämmer att startvalet är "ett steg innan listan börjar", så studenten själv får välja alternativ
            cmbAnnonsTyp.SelectedIndex = -1;
            cmbKurs.SelectedIndex = -1;
            cmbSkick.SelectedIndex = -1;
        }

        private void VisaKurser()
        {
            cmbKurs.DisplayMember = nameof(Kurs.Namn);
            cmbKurs.DataSource = kursController.HämtaKurser();
        }

        private void cmbAnnonsTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? typ = cmbAnnonsTyp.SelectedItem?.ToString();

            pnlKursbok.Visible = typ == "Kursbok";
            pnlKompendium.Visible = typ == "Kompendium";
            pnlDigitalresurs.Visible = typ == "Digitalresurs";
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            // Kontrollering att studenten har gjort ett val från dropdownlistorna
            if (cmbAnnonsTyp.SelectedItem is not string typ)
            {
                MessageBox.Show("Välj en typ av annons.");
                return;
            }
            if (cmbKurs.SelectedItem is not Kurs kurs)
            {
                MessageBox.Show("Välj en kurs.");
                return;
            }
            if (cmbSkick.SelectedItem is not AnnonsSkick skick)
            {
                MessageBox.Show("Välj skick för din annons.");
                return;
            }

            string titel = txtTitel.Text.Trim();
            decimal pris = numPris.Value;

            switch (typ)
            {
                case "Kursbok":
                    annonsController.PubliceraKursbok(
                    säljare, kurs, titel, pris, skick, txtISBN.Text.Trim(), txtFörfattare.Text.Trim(), (int)numUpplaga.Value);
                    break;

                case "Kompendium":
                    annonsController.PubliceraKompendium(
                    säljare, kurs, titel, pris, skick, (int)numAntalSidor.Value, (int)numUtgivningsår.Value);
                    break;

                case "Digitalresurs":
                    annonsController.PubliceraDigitalresurs(
                    säljare, kurs, titel, pris, skick, txtFilformat.Text.Trim(), txtLeveranssätt.Text.Trim());
                    break;

                default:
                    MessageBox.Show("Välj en giltig typ av annons.");
                    break;
            }
            Close();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
