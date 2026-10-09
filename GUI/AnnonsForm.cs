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
        private Användare inloggadAnvändare;
        private AnnonsController annonsController;
        private Annons valdAnnons;
        private bool visarEgnaAnnonser = false;
        public AnnonsForm(BookSwapRegister register, Användare användare)
        {
            InitializeComponent();
            Register = register;
            inloggadAnvändare = användare;
            annonsController = new AnnonsController(register, användare);
        }
    }
}
