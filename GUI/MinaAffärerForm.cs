using Models;
using ServiceLager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MinaAffärerForm : Form
    {
        private AnnonsController controller;

        public MinaAffärerForm(BookSwapRegister register, Användare användare)
        {
            InitializeComponent();
            controller = new AnnonsController(register, användare);
            UppdateraAffärslista();
        }

        private void UppdateraAffärslista()
        {
            List<Affär> affärer = controller.HämtaMinaAffärer();

            lstAffärer.DataSource = null;
            lstAffärer.DataSource = affärer;
            lstAffärer.ClearSelected();

            if (affärer.Count == 0)
                lblAntalAffärer.Text = "Du har inga reservationer";
            else
                lblAntalAffärer.Text = "Antal: " + affärer.Count;
        }

        private void btnStäng_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
