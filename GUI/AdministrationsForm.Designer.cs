namespace GUI
{
    partial class AdministrationsForm
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
            tabAdministration = new TabControl();
            tabKurser = new TabPage();
            lblKurser = new Label();
            btnTaBortKurs = new Button();
            btnRedigeraKurs = new Button();
            btnLäggTillKurs = new Button();
            lstKurser = new ListBox();
            txtKurskod = new TextBox();
            lblKurskod = new Label();
            lblKursnamn = new Label();
            txtKursnamn = new TextBox();
            tabAnnonser = new TabPage();
            lblAntalAnnonser = new Label();
            btnTaBortAnnons = new Button();
            txtAnnonsdetaljer = new TextBox();
            label2 = new Label();
            lstAnnonser = new CheckedListBox();
            label1 = new Label();
            tabAdministration.SuspendLayout();
            tabKurser.SuspendLayout();
            tabAnnonser.SuspendLayout();
            SuspendLayout();
            // 
            // tabAdministration
            // 
            tabAdministration.Controls.Add(tabKurser);
            tabAdministration.Controls.Add(tabAnnonser);
            tabAdministration.Location = new Point(-7, 6);
            tabAdministration.Name = "tabAdministration";
            tabAdministration.SelectedIndex = 0;
            tabAdministration.Size = new Size(977, 540);
            tabAdministration.TabIndex = 9;
            // 
            // tabKurser
            // 
            tabKurser.Controls.Add(lblKurser);
            tabKurser.Controls.Add(btnTaBortKurs);
            tabKurser.Controls.Add(btnRedigeraKurs);
            tabKurser.Controls.Add(btnLäggTillKurs);
            tabKurser.Controls.Add(lstKurser);
            tabKurser.Controls.Add(txtKurskod);
            tabKurser.Controls.Add(lblKurskod);
            tabKurser.Controls.Add(lblKursnamn);
            tabKurser.Controls.Add(txtKursnamn);
            tabKurser.Location = new Point(4, 29);
            tabKurser.Name = "tabKurser";
            tabKurser.Padding = new Padding(3);
            tabKurser.Size = new Size(969, 507);
            tabKurser.TabIndex = 0;
            tabKurser.Text = "Kurser";
            tabKurser.UseVisualStyleBackColor = true;
            // 
            // lblKurser
            // 
            lblKurser.AutoSize = true;
            lblKurser.Location = new Point(57, 60);
            lblKurser.Margin = new Padding(2, 0, 2, 0);
            lblKurser.Name = "lblKurser";
            lblKurser.Size = new Size(50, 20);
            lblKurser.TabIndex = 17;
            lblKurser.Text = "Kurser";
            // 
            // btnTaBortKurs
            // 
            btnTaBortKurs.Location = new Point(429, 300);
            btnTaBortKurs.Margin = new Padding(2);
            btnTaBortKurs.Name = "btnTaBortKurs";
            btnTaBortKurs.Size = new Size(109, 27);
            btnTaBortKurs.TabIndex = 16;
            btnTaBortKurs.Text = "Ta bort kurs";
            btnTaBortKurs.UseVisualStyleBackColor = true;
            btnTaBortKurs.Click += btnTaBortKurs_Click;
            // 
            // btnRedigeraKurs
            // 
            btnRedigeraKurs.Location = new Point(222, 300);
            btnRedigeraKurs.Margin = new Padding(2);
            btnRedigeraKurs.Name = "btnRedigeraKurs";
            btnRedigeraKurs.Size = new Size(109, 27);
            btnRedigeraKurs.TabIndex = 15;
            btnRedigeraKurs.Text = "Redigera kurs";
            btnRedigeraKurs.UseVisualStyleBackColor = true;
            btnRedigeraKurs.Click += btnLäggTillKurs_Click;
            // 
            // btnLäggTillKurs
            // 
            btnLäggTillKurs.Location = new Point(57, 300);
            btnLäggTillKurs.Margin = new Padding(2);
            btnLäggTillKurs.Name = "btnLäggTillKurs";
            btnLäggTillKurs.Size = new Size(109, 27);
            btnLäggTillKurs.TabIndex = 14;
            btnLäggTillKurs.Text = "Lägg till kurs";
            btnLäggTillKurs.UseVisualStyleBackColor = true;
            btnLäggTillKurs.Click += btnLäggTillKurs_Click;
            // 
            // lstKurser
            // 
            lstKurser.FormattingEnabled = true;
            lstKurser.Location = new Point(57, 89);
            lstKurser.Margin = new Padding(2);
            lstKurser.Name = "lstKurser";
            lstKurser.Size = new Size(481, 184);
            lstKurser.TabIndex = 9;
            lstKurser.SelectedIndexChanged += lstKurser_SelectedIndexChanged;
            // 
            // txtKurskod
            // 
            txtKurskod.Location = new Point(577, 107);
            txtKurskod.Margin = new Padding(2);
            txtKurskod.Name = "txtKurskod";
            txtKurskod.Size = new Size(121, 27);
            txtKurskod.TabIndex = 12;
            // 
            // lblKurskod
            // 
            lblKurskod.AutoSize = true;
            lblKurskod.Location = new Point(577, 84);
            lblKurskod.Margin = new Padding(2, 0, 2, 0);
            lblKurskod.Name = "lblKurskod";
            lblKurskod.Size = new Size(62, 20);
            lblKurskod.TabIndex = 10;
            lblKurskod.Text = "Kurskod";
            // 
            // lblKursnamn
            // 
            lblKursnamn.AutoSize = true;
            lblKursnamn.Location = new Point(577, 179);
            lblKursnamn.Margin = new Padding(2, 0, 2, 0);
            lblKursnamn.Name = "lblKursnamn";
            lblKursnamn.Size = new Size(74, 20);
            lblKursnamn.TabIndex = 11;
            lblKursnamn.Text = "Kursnamn";
            // 
            // txtKursnamn
            // 
            txtKursnamn.Location = new Point(577, 201);
            txtKursnamn.Margin = new Padding(2);
            txtKursnamn.Name = "txtKursnamn";
            txtKursnamn.Size = new Size(121, 27);
            txtKursnamn.TabIndex = 13;
            // 
            // tabAnnonser
            // 
            tabAnnonser.Controls.Add(lblAntalAnnonser);
            tabAnnonser.Controls.Add(btnTaBortAnnons);
            tabAnnonser.Controls.Add(txtAnnonsdetaljer);
            tabAnnonser.Controls.Add(label2);
            tabAnnonser.Controls.Add(lstAnnonser);
            tabAnnonser.Controls.Add(label1);
            tabAnnonser.Location = new Point(4, 29);
            tabAnnonser.Name = "tabAnnonser";
            tabAnnonser.Padding = new Padding(3);
            tabAnnonser.Size = new Size(969, 507);
            tabAnnonser.TabIndex = 1;
            tabAnnonser.Text = "Annonser";
            tabAnnonser.UseVisualStyleBackColor = true;
            // 
            // lblAntalAnnonser
            // 
            lblAntalAnnonser.AutoSize = true;
            lblAntalAnnonser.Location = new Point(755, 400);
            lblAntalAnnonser.Name = "lblAntalAnnonser";
            lblAntalAnnonser.Size = new Size(0, 20);
            lblAntalAnnonser.TabIndex = 5;
            // 
            // btnTaBortAnnons
            // 
            btnTaBortAnnons.Location = new Point(408, 400);
            btnTaBortAnnons.Name = "btnTaBortAnnons";
            btnTaBortAnnons.Size = new Size(94, 29);
            btnTaBortAnnons.TabIndex = 4;
            btnTaBortAnnons.Text = "Ta bort annons";
            btnTaBortAnnons.UseVisualStyleBackColor = true;
            btnTaBortAnnons.Click += btnTaBortAnnons_Click;
            // 
            // txtAnnonsdetaljer
            // 
            txtAnnonsdetaljer.Location = new Point(548, 76);
            txtAnnonsdetaljer.Multiline = true;
            txtAnnonsdetaljer.Name = "txtAnnonsdetaljer";
            txtAnnonsdetaljer.ReadOnly = true;
            txtAnnonsdetaljer.ScrollBars = ScrollBars.Vertical;
            txtAnnonsdetaljer.Size = new Size(382, 312);
            txtAnnonsdetaljer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 53);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Annonsdetaljer";
            // 
            // lstAnnonser
            // 
            lstAnnonser.FormattingEnabled = true;
            lstAnnonser.Location = new Point(59, 53);
            lstAnnonser.Name = "lstAnnonser";
            lstAnnonser.Size = new Size(443, 334);
            lstAnnonser.TabIndex = 1;
            lstAnnonser.SelectedIndexChanged += lstAnnonser_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Annonser";
            // 
            // AdministrationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 540);
            Controls.Add(tabAdministration);
            Margin = new Padding(2);
            Name = "AdministrationsForm";
            Text = "Administration";
            tabAdministration.ResumeLayout(false);
            tabKurser.ResumeLayout(false);
            tabKurser.PerformLayout();
            tabAnnonser.ResumeLayout(false);
            tabAnnonser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabAdministration;
        private TabPage tabAnnonser;
        private TabPage tabKurser;
        private Label lblKurser;
        private Button btnTaBortKurs;
        private Button btnRedigeraKurs;
        private Button btnLäggTillKurs;
        private ListBox lstKurser;
        private TextBox txtKurskod;
        private Label lblKurskod;
        private Label lblKursnamn;
        private TextBox txtKursnamn;
        private CheckedListBox lstAnnonser;
        private Label label1;
        private Button btnTaBortAnnons;
        private TextBox txtAnnonsdetaljer;
        private Label label2;
        private Label lblAntalAnnonser;
    }
}