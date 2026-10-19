namespace GUI
{
    partial class AnnonsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnnonser = new Label();
            lstAnnonser = new ListBox();
            lblAntalAnnonser = new Label();
            lblDetaljer = new Label();
            txtAnnonsdetaljer = new TextBox();
            btnNyAnnons = new Button();
            btnReservera = new Button();
            btnVisaTillgängliga = new Button();
            btnVisaEgna = new Button();
            btnRedigera = new Button();
            btnTaBort = new Button();
            tabAnnonsVy = new TabControl();
            tabAnnonsHem = new TabPage();
            tabMinaReservationer = new TabPage();
            lblAntalAffärer = new Label();
            lblMinaReservationer = new Label();
            lstAffärer = new ListBox();
            tabAnnonsVy.SuspendLayout();
            tabAnnonsHem.SuspendLayout();
            tabMinaReservationer.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnnonser
            // 
            lblAnnonser.AutoSize = true;
            lblAnnonser.Location = new Point(12, 27);
            lblAnnonser.Margin = new Padding(2, 0, 2, 0);
            lblAnnonser.Name = "lblAnnonser";
            lblAnnonser.Size = new Size(88, 25);
            lblAnnonser.TabIndex = 0;
            lblAnnonser.Text = "Annonser";
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(12, 54);
            lstAnnonser.Margin = new Padding(2);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(481, 354);
            lstAnnonser.TabIndex = 1;
            lstAnnonser.SelectedIndexChanged += lstAnnonser_SelectedIndexChanged;
            // 
            // lblAntalAnnonser
            // 
            lblAntalAnnonser.AutoSize = true;
            lblAntalAnnonser.Location = new Point(12, 410);
            lblAntalAnnonser.Margin = new Padding(2, 0, 2, 0);
            lblAntalAnnonser.Name = "lblAntalAnnonser";
            lblAntalAnnonser.Size = new Size(0, 25);
            lblAntalAnnonser.TabIndex = 2;
            // 
            // lblDetaljer
            // 
            lblDetaljer.AutoSize = true;
            lblDetaljer.Location = new Point(532, 27);
            lblDetaljer.Margin = new Padding(2, 0, 2, 0);
            lblDetaljer.Name = "lblDetaljer";
            lblDetaljer.Size = new Size(131, 25);
            lblDetaljer.TabIndex = 3;
            lblDetaljer.Text = "Annonsdetaljer";
            // 
            // txtAnnonsdetaljer
            // 
            txtAnnonsdetaljer.Location = new Point(532, 54);
            txtAnnonsdetaljer.Margin = new Padding(2);
            txtAnnonsdetaljer.Multiline = true;
            txtAnnonsdetaljer.Name = "txtAnnonsdetaljer";
            txtAnnonsdetaljer.ReadOnly = true;
            txtAnnonsdetaljer.Size = new Size(460, 354);
            txtAnnonsdetaljer.TabIndex = 4;
            // 
            // btnNyAnnons
            // 
            btnNyAnnons.Location = new Point(8, 452);
            btnNyAnnons.Margin = new Padding(2);
            btnNyAnnons.Name = "btnNyAnnons";
            btnNyAnnons.Size = new Size(112, 34);
            btnNyAnnons.TabIndex = 5;
            btnNyAnnons.Text = "Ny annons";
            btnNyAnnons.UseVisualStyleBackColor = true;
            btnNyAnnons.Click += btnNyAnnons_Click;
            // 
            // btnReservera
            // 
            btnReservera.Location = new Point(145, 452);
            btnReservera.Margin = new Padding(2);
            btnReservera.Name = "btnReservera";
            btnReservera.Size = new Size(112, 34);
            btnReservera.TabIndex = 6;
            btnReservera.Text = "Reservera";
            btnReservera.UseVisualStyleBackColor = true;
            btnReservera.Click += btnReservera_Click;
            // 
            // btnVisaTillgängliga
            // 
            btnVisaTillgängliga.Location = new Point(273, 452);
            btnVisaTillgängliga.Margin = new Padding(2);
            btnVisaTillgängliga.Name = "btnVisaTillgängliga";
            btnVisaTillgängliga.Size = new Size(200, 34);
            btnVisaTillgängliga.TabIndex = 7;
            btnVisaTillgängliga.Text = "Visa tillgängliga annonser";
            btnVisaTillgängliga.UseVisualStyleBackColor = true;
            btnVisaTillgängliga.Click += btnVisaTillgängliga_Click;
            // 
            // btnVisaEgna
            // 
            btnVisaEgna.Location = new Point(762, 452);
            btnVisaEgna.Margin = new Padding(2);
            btnVisaEgna.Name = "btnVisaEgna";
            btnVisaEgna.Size = new Size(230, 34);
            btnVisaEgna.TabIndex = 9;
            btnVisaEgna.Text = "Visa egna annonser";
            btnVisaEgna.UseVisualStyleBackColor = true;
            btnVisaEgna.Click += btnVisaEgna_Click;
            // 
            // btnRedigera
            // 
            btnRedigera.Location = new Point(492, 452);
            btnRedigera.Margin = new Padding(2);
            btnRedigera.Name = "btnRedigera";
            btnRedigera.Size = new Size(112, 34);
            btnRedigera.TabIndex = 10;
            btnRedigera.Text = "Redigera";
            btnRedigera.UseVisualStyleBackColor = true;
            btnRedigera.Click += btnRedigera_Click;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(629, 452);
            btnTaBort.Margin = new Padding(2);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(112, 34);
            btnTaBort.TabIndex = 11;
            btnTaBort.Text = "Ta Bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // tabAnnonsVy
            // 
            tabAnnonsVy.Controls.Add(tabAnnonsHem);
            tabAnnonsVy.Controls.Add(tabMinaReservationer);
            tabAnnonsVy.Location = new Point(2, 1);
            tabAnnonsVy.Name = "tabAnnonsVy";
            tabAnnonsVy.SelectedIndex = 0;
            tabAnnonsVy.Size = new Size(1018, 562);
            tabAnnonsVy.TabIndex = 12;
            // 
            // tabAnnonsHem
            // 
            tabAnnonsHem.Controls.Add(lstAnnonser);
            tabAnnonsHem.Controls.Add(lblAntalAnnonser);
            tabAnnonsHem.Controls.Add(btnTaBort);
            tabAnnonsHem.Controls.Add(lblAnnonser);
            tabAnnonsHem.Controls.Add(btnRedigera);
            tabAnnonsHem.Controls.Add(txtAnnonsdetaljer);
            tabAnnonsHem.Controls.Add(btnVisaEgna);
            tabAnnonsHem.Controls.Add(lblDetaljer);
            tabAnnonsHem.Controls.Add(btnNyAnnons);
            tabAnnonsHem.Controls.Add(btnVisaTillgängliga);
            tabAnnonsHem.Controls.Add(btnReservera);
            tabAnnonsHem.Location = new Point(4, 34);
            tabAnnonsHem.Name = "tabAnnonsHem";
            tabAnnonsHem.Padding = new Padding(3);
            tabAnnonsHem.Size = new Size(1010, 524);
            tabAnnonsHem.TabIndex = 0;
            tabAnnonsHem.Text = "Hem";
            tabAnnonsHem.UseVisualStyleBackColor = true;
            // 
            // tabMinaReservationer
            // 
            tabMinaReservationer.Controls.Add(lblAntalAffärer);
            tabMinaReservationer.Controls.Add(lblMinaReservationer);
            tabMinaReservationer.Controls.Add(lstAffärer);
            tabMinaReservationer.Location = new Point(4, 34);
            tabMinaReservationer.Name = "tabMinaReservationer";
            tabMinaReservationer.Padding = new Padding(3);
            tabMinaReservationer.Size = new Size(1010, 524);
            tabMinaReservationer.TabIndex = 1;
            tabMinaReservationer.Text = "Mina reservationer";
            tabMinaReservationer.UseVisualStyleBackColor = true;
            // 
            // lblAntalAffärer
            // 
            lblAntalAffärer.AutoSize = true;
            lblAntalAffärer.Location = new Point(145, 448);
            lblAntalAffärer.Margin = new Padding(4, 0, 4, 0);
            lblAntalAffärer.Name = "lblAntalAffärer";
            lblAntalAffärer.Size = new Size(0, 25);
            lblAntalAffärer.TabIndex = 4;
            // 
            // lblMinaReservationer
            // 
            lblMinaReservationer.AutoSize = true;
            lblMinaReservationer.Location = new Point(380, 36);
            lblMinaReservationer.Margin = new Padding(4, 0, 4, 0);
            lblMinaReservationer.Name = "lblMinaReservationer";
            lblMinaReservationer.Size = new Size(225, 25);
            lblMinaReservationer.TabIndex = 3;
            lblMinaReservationer.Text = "Mina reserverade annonser";
            // 
            // lstAffärer
            // 
            lstAffärer.FormattingEnabled = true;
            lstAffärer.Location = new Point(145, 65);
            lstAffärer.Margin = new Padding(4);
            lstAffärer.Name = "lstAffärer";
            lstAffärer.Size = new Size(706, 379);
            lstAffärer.TabIndex = 2;
            // 
            // AnnonsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 564);
            Controls.Add(tabAnnonsVy);
            Margin = new Padding(2);
            Name = "AnnonsForm";
            Text = "Annonser";
            tabAnnonsVy.ResumeLayout(false);
            tabAnnonsHem.ResumeLayout(false);
            tabAnnonsHem.PerformLayout();
            tabMinaReservationer.ResumeLayout(false);
            tabMinaReservationer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAnnonser;
        private ListBox lstAnnonser;
        private Label lblAntalAnnonser;
        private Label lblDetaljer;
        private TextBox txtAnnonsdetaljer;
        private Button btnNyAnnons;
        private Button btnReservera;
        private Button btnVisaTillgängliga;
        private Button btnVisaEgna;
        private Button btnRedigera;
        private Button btnTaBort;
        private TabControl tabAnnonsVy;
        private TabPage tabAnnonsHem;
        private TabPage tabMinaReservationer;
        private ListBox lstAffärer;
        private Label lblMinaReservationer;
        private Label lblAntalAffärer;
    }
}