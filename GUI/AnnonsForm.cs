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
        private Annons valdAnnons;
        private bool visarEgnaAnnonser = false;
        public AnnonsForm(BookSwapRegister register, Student student)
        {
            InitializeComponent();
            this.register = register;
            inloggadStudent = student;
            annonsController = new AnnonsController(register, student);
        }

        private void btnNyAnnons_Click(object sender, EventArgs e)
        {
            HanteraAnnonsForm hanteraAnnonsFormulär = new HanteraAnnonsForm(register, inloggadStudent);
            hanteraAnnonsFormulär.ShowDialog();
            hanteraAnnonsFormulär.Dispose();

        }
    }
}
