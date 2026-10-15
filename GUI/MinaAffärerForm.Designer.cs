namespace GUI
{
    partial class MinaAffärerForm
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
            lblAffärer = new Label();
            lstAffärer = new ListBox();
            lblAntalAffärer = new Label();
            btnStäng = new Button();
            SuspendLayout();
            //
            // lblAffärer
            //
            lblAffärer.AutoSize = true;
            lblAffärer.Location = new Point(74, 58);
            lblAffärer.Name = "lblAffärer";
            lblAffärer.Size = new Size(136, 20);
            lblAffärer.TabIndex = 0;
            lblAffärer.Text = "Mina Reservationer";
            //
            // lstAffärer
            //
            lstAffärer.FormattingEnabled = true;
            lstAffärer.Location = new Point(246, 58);
            lstAffärer.Name = "lstAffärer";
            lstAffärer.Size = new Size(320, 124);
            lstAffärer.TabIndex = 1;
            //
            // lblAntalAffärer
            //
            lblAntalAffärer.AutoSize = true;
            lblAntalAffärer.Location = new Point(246, 214);
            lblAntalAffärer.Name = "lblAntalAffärer";
            lblAntalAffärer.Size = new Size(50, 20);
            lblAntalAffärer.TabIndex = 2;
            //
            // btnStäng
            //
            btnStäng.Location = new Point(472, 205);
            btnStäng.Name = "btnStäng";
            btnStäng.Size = new Size(94, 29);
            btnStäng.TabIndex = 3;
            btnStäng.Text = "Stäng";
            btnStäng.UseVisualStyleBackColor = true;
            btnStäng.Click += btnStäng_Click;
            //
            // MinaAffärerForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStäng);
            Controls.Add(lblAntalAffärer);
            Controls.Add(lstAffärer);
            Controls.Add(lblAffärer);
            Name = "MinaAffärerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mina Reservationer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAffärer;
        private ListBox lstAffärer;
        private Label lblAntalAffärer;
        private Button btnStäng;
    }
}