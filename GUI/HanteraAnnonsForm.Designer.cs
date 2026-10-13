namespace GUI
{
    partial class HanteraAnnonsForm
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
            cmbAnnonsTyp = new ComboBox();
            cmbKurs = new ComboBox();
            txtTitel = new TextBox();
            lblTitel = new Label();
            numPris = new NumericUpDown();
            cmbSkick = new ComboBox();
            pnlKursbok = new Panel();
            numUpplaga = new NumericUpDown();
            lblUpplaga = new Label();
            txtFörfattare = new TextBox();
            lblFörfattare = new Label();
            txtISBN = new TextBox();
            lblISBN = new Label();
            pnlKompendium = new Panel();
            numUtgivningsår = new NumericUpDown();
            lblUtgivningsÅr = new Label();
            numAntalSidor = new NumericUpDown();
            lblAntalSidor = new Label();
            pnlDigitalresurs = new Panel();
            txtLeveranssätt = new TextBox();
            txtFilformat = new TextBox();
            lblLeversanssätt = new Label();
            lblFilformat = new Label();
            lblAnnonsTyp = new Label();
            lblKurs = new Label();
            lblSkick = new Label();
            lblPris = new Label();
            btnSpara = new Button();
            btnAvbryt = new Button();
            ((System.ComponentModel.ISupportInitialize)numPris).BeginInit();
            pnlKursbok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpplaga).BeginInit();
            pnlKompendium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUtgivningsår).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAntalSidor).BeginInit();
            pnlDigitalresurs.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAnnonsTyp
            // 
            cmbAnnonsTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnnonsTyp.FormattingEnabled = true;
            cmbAnnonsTyp.Location = new Point(146, 27);
            cmbAnnonsTyp.Name = "cmbAnnonsTyp";
            cmbAnnonsTyp.Size = new Size(182, 33);
            cmbAnnonsTyp.TabIndex = 0;
            cmbAnnonsTyp.SelectedIndexChanged += cmbAnnonsTyp_SelectedIndexChanged;
            // 
            // cmbKurs
            // 
            cmbKurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKurs.FormattingEnabled = true;
            cmbKurs.Location = new Point(144, 81);
            cmbKurs.Name = "cmbKurs";
            cmbKurs.Size = new Size(182, 33);
            cmbKurs.TabIndex = 1;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(144, 131);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(329, 31);
            txtTitel.TabIndex = 2;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(16, 137);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(44, 25);
            lblTitel.TabIndex = 3;
            lblTitel.Text = "Titel";
            // 
            // numPris
            // 
            numPris.Location = new Point(144, 374);
            numPris.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numPris.Name = "numPris";
            numPris.Size = new Size(180, 31);
            numPris.TabIndex = 4;
            numPris.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbSkick
            // 
            cmbSkick.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkick.FormattingEnabled = true;
            cmbSkick.Location = new Point(144, 320);
            cmbSkick.Name = "cmbSkick";
            cmbSkick.Size = new Size(182, 33);
            cmbSkick.TabIndex = 5;
            // 
            // pnlKursbok
            // 
            pnlKursbok.Controls.Add(numUpplaga);
            pnlKursbok.Controls.Add(lblUpplaga);
            pnlKursbok.Controls.Add(txtFörfattare);
            pnlKursbok.Controls.Add(lblFörfattare);
            pnlKursbok.Controls.Add(txtISBN);
            pnlKursbok.Controls.Add(lblISBN);
            pnlKursbok.Location = new Point(1, 171);
            pnlKursbok.Name = "pnlKursbok";
            pnlKursbok.Size = new Size(472, 143);
            pnlKursbok.TabIndex = 6;
            pnlKursbok.Visible = false;
            // 
            // numUpplaga
            // 
            numUpplaga.Location = new Point(143, 103);
            numUpplaga.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpplaga.Name = "numUpplaga";
            numUpplaga.Size = new Size(180, 31);
            numUpplaga.TabIndex = 13;
            numUpplaga.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUpplaga
            // 
            lblUpplaga.AutoSize = true;
            lblUpplaga.Location = new Point(15, 103);
            lblUpplaga.Name = "lblUpplaga";
            lblUpplaga.Size = new Size(79, 25);
            lblUpplaga.TabIndex = 13;
            lblUpplaga.Text = "Upplaga";
            // 
            // txtFörfattare
            // 
            txtFörfattare.Location = new Point(143, 55);
            txtFörfattare.Name = "txtFörfattare";
            txtFörfattare.Size = new Size(180, 31);
            txtFörfattare.TabIndex = 13;
            // 
            // lblFörfattare
            // 
            lblFörfattare.AutoSize = true;
            lblFörfattare.Location = new Point(15, 55);
            lblFörfattare.Name = "lblFörfattare";
            lblFörfattare.Size = new Size(89, 25);
            lblFörfattare.TabIndex = 13;
            lblFörfattare.Text = "Författare";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(143, 12);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 31);
            txtISBN.TabIndex = 13;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(15, 12);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(50, 25);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // pnlKompendium
            // 
            pnlKompendium.Controls.Add(numUtgivningsår);
            pnlKompendium.Controls.Add(lblUtgivningsÅr);
            pnlKompendium.Controls.Add(numAntalSidor);
            pnlKompendium.Controls.Add(lblAntalSidor);
            pnlKompendium.Location = new Point(1, 171);
            pnlKompendium.Name = "pnlKompendium";
            pnlKompendium.Size = new Size(472, 143);
            pnlKompendium.TabIndex = 7;
            pnlKompendium.Visible = false;
            // 
            // numUtgivningsår
            // 
            numUtgivningsår.Location = new Point(139, 58);
            numUtgivningsår.Name = "numUtgivningsår";
            numUtgivningsår.Size = new Size(188, 31);
            numUtgivningsår.TabIndex = 3;
            // 
            // lblUtgivningsÅr
            // 
            lblUtgivningsÅr.AutoSize = true;
            lblUtgivningsÅr.Location = new Point(15, 60);
            lblUtgivningsÅr.Name = "lblUtgivningsÅr";
            lblUtgivningsÅr.Size = new Size(112, 25);
            lblUtgivningsÅr.TabIndex = 2;
            lblUtgivningsÅr.Text = "Utgivningsår";
            // 
            // numAntalSidor
            // 
            numAntalSidor.Location = new Point(139, 9);
            numAntalSidor.Name = "numAntalSidor";
            numAntalSidor.Size = new Size(186, 31);
            numAntalSidor.TabIndex = 1;
            // 
            // lblAntalSidor
            // 
            lblAntalSidor.AutoSize = true;
            lblAntalSidor.Location = new Point(15, 11);
            lblAntalSidor.Name = "lblAntalSidor";
            lblAntalSidor.Size = new Size(98, 25);
            lblAntalSidor.TabIndex = 0;
            lblAntalSidor.Text = "Antal sidor";
            // 
            // pnlDigitalresurs
            // 
            pnlDigitalresurs.Controls.Add(txtLeveranssätt);
            pnlDigitalresurs.Controls.Add(txtFilformat);
            pnlDigitalresurs.Controls.Add(lblLeversanssätt);
            pnlDigitalresurs.Controls.Add(lblFilformat);
            pnlDigitalresurs.Location = new Point(1, 171);
            pnlDigitalresurs.Name = "pnlDigitalresurs";
            pnlDigitalresurs.Size = new Size(472, 143);
            pnlDigitalresurs.TabIndex = 8;
            pnlDigitalresurs.Visible = false;
            // 
            // txtLeveranssätt
            // 
            txtLeveranssätt.Location = new Point(143, 60);
            txtLeveranssätt.Name = "txtLeveranssätt";
            txtLeveranssätt.Size = new Size(180, 31);
            txtLeveranssätt.TabIndex = 3;
            // 
            // txtFilformat
            // 
            txtFilformat.Location = new Point(143, 15);
            txtFilformat.Name = "txtFilformat";
            txtFilformat.Size = new Size(180, 31);
            txtFilformat.TabIndex = 2;
            // 
            // lblLeversanssätt
            // 
            lblLeversanssätt.AutoSize = true;
            lblLeversanssätt.Location = new Point(15, 64);
            lblLeversanssätt.Name = "lblLeversanssätt";
            lblLeversanssätt.Size = new Size(109, 25);
            lblLeversanssätt.TabIndex = 1;
            lblLeversanssätt.Text = "Leveranssätt";
            // 
            // lblFilformat
            // 
            lblFilformat.AutoSize = true;
            lblFilformat.Location = new Point(15, 15);
            lblFilformat.Name = "lblFilformat";
            lblFilformat.Size = new Size(83, 25);
            lblFilformat.TabIndex = 0;
            lblFilformat.Text = "Filformat";
            // 
            // lblAnnonsTyp
            // 
            lblAnnonsTyp.AutoSize = true;
            lblAnnonsTyp.Location = new Point(16, 30);
            lblAnnonsTyp.Name = "lblAnnonsTyp";
            lblAnnonsTyp.Size = new Size(126, 25);
            lblAnnonsTyp.TabIndex = 9;
            lblAnnonsTyp.Text = "Typ av annons";
            // 
            // lblKurs
            // 
            lblKurs.AutoSize = true;
            lblKurs.Location = new Point(16, 84);
            lblKurs.Name = "lblKurs";
            lblKurs.Size = new Size(46, 25);
            lblKurs.TabIndex = 10;
            lblKurs.Text = "Kurs";
            // 
            // lblSkick
            // 
            lblSkick.AutoSize = true;
            lblSkick.Location = new Point(16, 323);
            lblSkick.Name = "lblSkick";
            lblSkick.Size = new Size(52, 25);
            lblSkick.TabIndex = 11;
            lblSkick.Text = "Skick";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(16, 376);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(40, 25);
            lblPris.TabIndex = 12;
            lblPris.Text = "Pris";
            // 
            // btnSpara
            // 
            btnSpara.Location = new Point(70, 468);
            btnSpara.Name = "btnSpara";
            btnSpara.Size = new Size(112, 34);
            btnSpara.TabIndex = 13;
            btnSpara.Text = "Spara";
            btnSpara.UseVisualStyleBackColor = true;
            btnSpara.Click += btnSpara_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(327, 468);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(112, 34);
            btnAvbryt.TabIndex = 14;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // HanteraAnnonsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 533);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSpara);
            Controls.Add(lblPris);
            Controls.Add(lblSkick);
            Controls.Add(pnlDigitalresurs);
            Controls.Add(lblKurs);
            Controls.Add(pnlKompendium);
            Controls.Add(lblAnnonsTyp);
            Controls.Add(pnlKursbok);
            Controls.Add(cmbSkick);
            Controls.Add(numPris);
            Controls.Add(lblTitel);
            Controls.Add(txtTitel);
            Controls.Add(cmbKurs);
            Controls.Add(cmbAnnonsTyp);
            Name = "HanteraAnnonsForm";
            Text = "Hantera annonser";
            ((System.ComponentModel.ISupportInitialize)numPris).EndInit();
            pnlKursbok.ResumeLayout(false);
            pnlKursbok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpplaga).EndInit();
            pnlKompendium.ResumeLayout(false);
            pnlKompendium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUtgivningsår).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAntalSidor).EndInit();
            pnlDigitalresurs.ResumeLayout(false);
            pnlDigitalresurs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAnnonsTyp;
        private ComboBox cmbKurs;
        private TextBox txtTitel;
        private Label lblTitel;
        private NumericUpDown numPris;
        private ComboBox cmbSkick;
        private Panel pnlKursbok;
        private Panel pnlKompendium;
        private Panel pnlDigitalresurs;
        private Label lblAnnonsTyp;
        private Label lblKurs;
        private Label lblSkick;
        private Label lblPris;
        private Label lblFörfattare;
        private TextBox txtISBN;
        private Label lblISBN;
        private NumericUpDown numUpplaga;
        private Label lblUpplaga;
        private TextBox txtFörfattare;
        private NumericUpDown numUtgivningsår;
        private Label lblUtgivningsÅr;
        private NumericUpDown numAntalSidor;
        private Label lblAntalSidor;
        private TextBox txtLeveranssätt;
        private TextBox txtFilformat;
        private Label lblLeversanssätt;
        private Label lblFilformat;
        private Button btnSpara;
        private Button btnAvbryt;
    }
}