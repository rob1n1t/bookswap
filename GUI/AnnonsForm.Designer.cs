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
            btnMinaAffärer = new Button();
            SuspendLayout();
            // 
            // lblAnnonser
            // 
            lblAnnonser.AutoSize = true;
            lblAnnonser.Location = new Point(10, 7);
            lblAnnonser.Margin = new Padding(2, 0, 2, 0);
            lblAnnonser.Name = "lblAnnonser";
            lblAnnonser.Size = new Size(71, 20);
            lblAnnonser.TabIndex = 0;
            lblAnnonser.Text = "Annonser";
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(10, 30);
            lstAnnonser.Margin = new Padding(2);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(241, 244);
            lstAnnonser.TabIndex = 1;
            lstAnnonser.SelectedIndexChanged += lstAnnonser_SelectedIndexChanged;
            // 
            // lblAntalAnnonser
            // 
            lblAntalAnnonser.AutoSize = true;
            lblAntalAnnonser.Location = new Point(10, 275);
            lblAntalAnnonser.Margin = new Padding(2, 0, 2, 0);
            lblAntalAnnonser.Name = "lblAntalAnnonser";
            lblAntalAnnonser.Size = new Size(0, 20);
            lblAntalAnnonser.TabIndex = 2;
            // 
            // lblDetaljer
            // 
            lblDetaljer.AutoSize = true;
            lblDetaljer.Location = new Point(264, 7);
            lblDetaljer.Margin = new Padding(2, 0, 2, 0);
            lblDetaljer.Name = "lblDetaljer";
            lblDetaljer.Size = new Size(109, 20);
            lblDetaljer.TabIndex = 3;
            lblDetaljer.Text = "Annonsdetaljer";
            // 
            // txtAnnonsdetaljer
            // 
            txtAnnonsdetaljer.Location = new Point(264, 30);
            txtAnnonsdetaljer.Margin = new Padding(2);
            txtAnnonsdetaljer.Multiline = true;
            txtAnnonsdetaljer.Name = "txtAnnonsdetaljer";
            txtAnnonsdetaljer.ReadOnly = true;
            txtAnnonsdetaljer.ScrollBars = ScrollBars.Vertical;
            txtAnnonsdetaljer.Size = new Size(367, 244);
            txtAnnonsdetaljer.TabIndex = 4;
            // 
            // btnNyAnnons
            // 
            btnNyAnnons.Location = new Point(10, 296);
            btnNyAnnons.Margin = new Padding(2);
            btnNyAnnons.Name = "btnNyAnnons";
            btnNyAnnons.Size = new Size(90, 27);
            btnNyAnnons.TabIndex = 5;
            btnNyAnnons.Text = "Ny annons";
            btnNyAnnons.UseVisualStyleBackColor = true;
            btnNyAnnons.Click += btnNyAnnons_Click;
            // 
            // btnReservera
            // 
            btnReservera.Location = new Point(112, 296);
            btnReservera.Margin = new Padding(2);
            btnReservera.Name = "btnReservera";
            btnReservera.Size = new Size(90, 27);
            btnReservera.TabIndex = 6;
            btnReservera.Text = "Reservera";
            btnReservera.UseVisualStyleBackColor = true;
            btnReservera.Click += btnReservera_Click;
            // 
            // btnVisaTillgängliga
            // 
            btnVisaTillgängliga.Location = new Point(214, 296);
            btnVisaTillgängliga.Margin = new Padding(2);
            btnVisaTillgängliga.Name = "btnVisaTillgängliga";
            btnVisaTillgängliga.Size = new Size(160, 27);
            btnVisaTillgängliga.TabIndex = 7;
            btnVisaTillgängliga.Text = "Visa tillgängliga annonser";
            btnVisaTillgängliga.UseVisualStyleBackColor = true;
            btnVisaTillgängliga.Click += btnVisaTillgängliga_Click;
            // 
            // btnMinaAffärer
            // 
            btnMinaAffärer.Location = new Point(444, 294);
            btnMinaAffärer.Name = "btnMinaAffärer";
            btnMinaAffärer.Size = new Size(184, 29);
            btnMinaAffärer.TabIndex = 8;
            btnMinaAffärer.Text = "Mina reservationer";
            btnMinaAffärer.UseVisualStyleBackColor = true;
            btnMinaAffärer.Click += btnMinaAffärer_Click;
            // 
            // AnnonsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnMinaAffärer);
            Controls.Add(btnVisaTillgängliga);
            Controls.Add(btnReservera);
            Controls.Add(btnNyAnnons);
            Controls.Add(txtAnnonsdetaljer);
            Controls.Add(lblDetaljer);
            Controls.Add(lblAntalAnnonser);
            Controls.Add(lstAnnonser);
            Controls.Add(lblAnnonser);
            Margin = new Padding(2);
            Name = "AnnonsForm";
            Text = "Annonser";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnMinaAffärer;
    }
}