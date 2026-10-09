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
        }
    }
}
