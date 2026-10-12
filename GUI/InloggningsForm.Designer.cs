namespace GUI
{
    partial class InloggningsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoggaIn = new Button();
            btnRegistrera = new Button();
            lblEpostadress = new Label();
            txtEpostadress = new TextBox();
            lblLösenord = new Label();
            txtLösenord = new TextBox();
            SuspendLayout();
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(45, 404);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(112, 34);
            btnLoggaIn.TabIndex = 0;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(272, 404);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(112, 34);
            btnRegistrera.TabIndex = 1;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // lblEpostadress
            // 
            lblEpostadress.AutoSize = true;
            lblEpostadress.Location = new Point(45, 93);
            lblEpostadress.Name = "lblEpostadress";
            lblEpostadress.Size = new Size(115, 25);
            lblEpostadress.TabIndex = 2;
            lblEpostadress.Text = "E-postadress";
            // 
            // txtEpostadress
            // 
            txtEpostadress.Location = new Point(45, 134);
            txtEpostadress.Name = "txtEpostadress";
            txtEpostadress.Size = new Size(339, 31);
            txtEpostadress.TabIndex = 3;
            // 
            // lblLösenord
            // 
            lblLösenord.AutoSize = true;
            lblLösenord.Location = new Point(45, 222);
            lblLösenord.Name = "lblLösenord";
            lblLösenord.Size = new Size(86, 25);
            lblLösenord.TabIndex = 4;
            lblLösenord.Text = "Lösenord";
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(45, 266);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(339, 31);
            txtLösenord.TabIndex = 5;
            txtLösenord.UseSystemPasswordChar = true;
            // 
            // InloggningsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(txtLösenord);
            Controls.Add(lblLösenord);
            Controls.Add(txtEpostadress);
            Controls.Add(lblEpostadress);
            Controls.Add(btnRegistrera);
            Controls.Add(btnLoggaIn);
            Name = "InloggningsForm";
            Text = "Inloggning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoggaIn;
        private Button btnRegistrera;
        private Label lblEpostadress;
        private TextBox txtEpostadress;
        private Label lblLösenord;
        private TextBox txtLösenord;
    }
}
