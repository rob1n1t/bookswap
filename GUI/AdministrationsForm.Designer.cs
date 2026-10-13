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
            lstKurser = new ListBox();
            lblKurskod = new Label();
            lblKursnamn = new Label();
            txtKurskod = new TextBox();
            txtKursnamn = new TextBox();
            btnLäggTillKurs = new Button();
            btnRedigeraKurs = new Button();
            btnTaBortKurs = new Button();
            lblKurser = new Label();
            SuspendLayout();
            // 
            // lstKurser
            // 
            lstKurser.FormattingEnabled = true;
            lstKurser.Location = new Point(32, 63);
            lstKurser.Name = "lstKurser";
            lstKurser.Size = new Size(180, 179);
            lstKurser.TabIndex = 0;
            lstKurser.SelectedIndexChanged += lstKurser_SelectedIndexChanged;
            // 
            // lblKurskod
            // 
            lblKurskod.AutoSize = true;
            lblKurskod.Location = new Point(307, 63);
            lblKurskod.Name = "lblKurskod";
            lblKurskod.Size = new Size(77, 25);
            lblKurskod.TabIndex = 1;
            lblKurskod.Text = "Kurskod";
            // 
            // lblKursnamn
            // 
            lblKursnamn.AutoSize = true;
            lblKursnamn.Location = new Point(307, 180);
            lblKursnamn.Name = "lblKursnamn";
            lblKursnamn.Size = new Size(91, 25);
            lblKursnamn.TabIndex = 2;
            lblKursnamn.Text = "Kursnamn";
            // 
            // txtKurskod
            // 
            txtKurskod.Location = new Point(307, 91);
            txtKurskod.Name = "txtKurskod";
            txtKurskod.Size = new Size(150, 31);
            txtKurskod.TabIndex = 3;
            // 
            // txtKursnamn
            // 
            txtKursnamn.Location = new Point(307, 211);
            txtKursnamn.Name = "txtKursnamn";
            txtKursnamn.Size = new Size(150, 31);
            txtKursnamn.TabIndex = 4;
            // 
            // btnLäggTillKurs
            // 
            btnLäggTillKurs.Location = new Point(32, 315);
            btnLäggTillKurs.Name = "btnLäggTillKurs";
            btnLäggTillKurs.Size = new Size(136, 34);
            btnLäggTillKurs.TabIndex = 5;
            btnLäggTillKurs.Text = "Lägg till kurs";
            btnLäggTillKurs.UseVisualStyleBackColor = true;
            btnLäggTillKurs.Click += btnLäggTillKurs_Click;
            // 
            // btnRedigeraKurs
            // 
            btnRedigeraKurs.Location = new Point(191, 315);
            btnRedigeraKurs.Name = "btnRedigeraKurs";
            btnRedigeraKurs.Size = new Size(136, 34);
            btnRedigeraKurs.TabIndex = 6;
            btnRedigeraKurs.Text = "Redigera kurs";
            btnRedigeraKurs.UseVisualStyleBackColor = true;
            btnRedigeraKurs.Click += btnRedigeraKurs_Click;
            // 
            // btnTaBortKurs
            // 
            btnTaBortKurs.Location = new Point(345, 315);
            btnTaBortKurs.Name = "btnTaBortKurs";
            btnTaBortKurs.Size = new Size(136, 34);
            btnTaBortKurs.TabIndex = 7;
            btnTaBortKurs.Text = "Ta bort kurs";
            btnTaBortKurs.UseVisualStyleBackColor = true;
            btnTaBortKurs.Click += btnTaBortKurs_Click;
            // 
            // lblKurser
            // 
            lblKurser.AutoSize = true;
            lblKurser.Location = new Point(32, 26);
            lblKurser.Name = "lblKurser";
            lblKurser.Size = new Size(61, 25);
            lblKurser.TabIndex = 8;
            lblKurser.Text = "Kurser";
            // 
            // AdministrationsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKurser);
            Controls.Add(btnTaBortKurs);
            Controls.Add(btnRedigeraKurs);
            Controls.Add(btnLäggTillKurs);
            Controls.Add(txtKursnamn);
            Controls.Add(txtKurskod);
            Controls.Add(lblKursnamn);
            Controls.Add(lblKurskod);
            Controls.Add(lstKurser);
            Name = "AdministrationsForm";
            Text = "Administration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKurser;
        private Label lblKurskod;
        private Label lblKursnamn;
        private TextBox txtKurskod;
        private TextBox txtKursnamn;
        private Button btnLäggTillKurs;
        private Button btnRedigeraKurs;
        private Button btnTaBortKurs;
        private Label lblKurser;
    }
}