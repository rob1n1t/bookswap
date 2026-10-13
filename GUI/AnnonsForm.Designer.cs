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
            btnNyAnnons = new Button();
            SuspendLayout();
            // 
            // btnNyAnnons
            // 
            btnNyAnnons.Location = new Point(12, 370);
            btnNyAnnons.Name = "btnNyAnnons";
            btnNyAnnons.Size = new Size(112, 34);
            btnNyAnnons.TabIndex = 0;
            btnNyAnnons.Text = "Ny annons";
            btnNyAnnons.UseVisualStyleBackColor = true;
            btnNyAnnons.Click += btnNyAnnons_Click;
            // 
            // AnnonsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNyAnnons);
            Name = "AnnonsForm";
            Text = "Annonser";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNyAnnons;
    }
}