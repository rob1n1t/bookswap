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
    public partial class AdministrationsForm : Form
    {
        private AnnonsController annonsController;
        private KursController kursController;
        private Annons? valdAnnons;
        private Kurs? valdKurs;

        public AdministrationsForm(BookSwapRegister register, Administratör admin)
        {
            InitializeComponent();
            annonsController = new AnnonsController(register, admin);
            kursController = new KursController(register, admin);

            UppdateraKurslista();
        }

        private void UppdateraKurslista()
        {
            List<Kurs> kurser = kursController.HämtaKurser();

            lstKurser.DataSource = null;
            lstKurser.DataSource = kurser;
            lstKurser.DisplayMember = "Namn";

            lstKurser.ClearSelected();

            valdKurs = null;

            txtKurskod.Clear();
            txtKursnamn.Clear();
        }

        private void lstKurser_SelectedIndexChanged(object sender, EventArgs e)
        {
            valdKurs = lstKurser.SelectedItem as Kurs;

            if (valdKurs != null)
            {
                txtKurskod.Text = valdKurs.Kurskod;
                txtKursnamn.Text = valdKurs.Namn;
            }

            else
            {
                txtKurskod.Clear();
                txtKursnamn.Clear();
            }
        }

        private void btnLäggTillKurs_Click(object sender, EventArgs e)
        {
            string kurskod = txtKurskod.Text.Trim();
            string namn = txtKursnamn.Text.Trim();

            try
            {
                kursController.LäggTillKurs(kurskod, namn);

                UppdateraKurslista();

                MessageBox.Show("Kursen har lagts till.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kunde inte lägga till kurs.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {
            if (valdKurs == null)
            {
                MessageBox.Show("Välj först en kurs som ska redigeras.",
                    "Ingen kurs vald",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string kurskod = txtKurskod.Text.Trim();
            string namn = txtKursnamn.Text.Trim();

            try
            {
                kursController.RedigeraKurs(valdKurs, kurskod, namn);

                UppdateraKurslista();

                MessageBox.Show("Kursen har uppdaterats.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kunde inte redigera jurs",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaBortKurs_Click(object sender, EventArgs e)
        {
            if (valdKurs == null)
            {
                MessageBox.Show("Välj först en kurs som ska tas bort.",
                    "Ingen kurs vald",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);

                return;
            }

            DialogResult svar = MessageBox.Show(
                $"Vill du verkligen ta bort kursen '{valdKurs.Namn}'?",
                "Bekräfta borttagning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (svar != DialogResult.Yes)
            {
                return;
            }

            try
            {
                kursController.TaBortKurs(valdKurs);

                UppdateraKurslista();

                MessageBox.Show("Kursen har tagits bort.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kunde inte ta bort kurs",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
