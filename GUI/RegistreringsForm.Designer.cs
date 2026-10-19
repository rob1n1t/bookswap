
using System;
using System.Windows.Forms;
using ServiceLager;
using Models;
namespace GUI;

partial class RegistreringsForm
{

    private System.ComponentModel.IContainer components = null;

 
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
        lblFörnamn = new Label();
        txtFörnamn = new TextBox();
        lblEfternamn = new Label();
        txtEfternamn = new TextBox();
        lblEpost = new Label();
        txtEpost = new TextBox();
        lblTelefonnummer = new Label();
        txtTelefonnummer = new TextBox();
        lblLösenord = new Label();
        txtLösenord = new TextBox();
        btnRegistrera = new Button();
        btnAvbryt = new Button();
        SuspendLayout();
        // 
        // lblFörnamn
        // 
        lblFörnamn.AutoSize = true;
        lblFörnamn.Location = new Point(30, 30);
        lblFörnamn.Margin = new Padding(2, 0, 2, 0);
        lblFörnamn.Name = "lblFörnamn";
        lblFörnamn.Size = new Size(83, 25);
        lblFörnamn.TabIndex = 0;
        lblFörnamn.Text = "Förnamn";
        // 
        // txtFörnamn
        // 
        txtFörnamn.Location = new Point(179, 28);
        txtFörnamn.Margin = new Padding(2);
        txtFörnamn.Name = "txtFörnamn";
        txtFörnamn.Size = new Size(285, 31);
        txtFörnamn.TabIndex = 1;
        // 
        // lblEfternamn
        // 
        lblEfternamn.AutoSize = true;
        lblEfternamn.Location = new Point(30, 70);
        lblEfternamn.Margin = new Padding(2, 0, 2, 0);
        lblEfternamn.Name = "lblEfternamn";
        lblEfternamn.Size = new Size(93, 25);
        lblEfternamn.TabIndex = 2;
        lblEfternamn.Text = "Efternamn";
        // 
        // txtEfternamn
        // 
        txtEfternamn.Location = new Point(179, 68);
        txtEfternamn.Margin = new Padding(2);
        txtEfternamn.Name = "txtEfternamn";
        txtEfternamn.Size = new Size(285, 31);
        txtEfternamn.TabIndex = 3;
        // 
        // lblEpost
        // 
        lblEpost.AutoSize = true;
        lblEpost.Location = new Point(30, 110);
        lblEpost.Margin = new Padding(2, 0, 2, 0);
        lblEpost.Name = "lblEpost";
        lblEpost.Size = new Size(115, 25);
        lblEpost.TabIndex = 4;
        lblEpost.Text = "E-postadress";
        // 
        // txtEpost
        // 
        txtEpost.Location = new Point(179, 108);
        txtEpost.Margin = new Padding(2);
        txtEpost.Name = "txtEpost";
        txtEpost.Size = new Size(285, 31);
        txtEpost.TabIndex = 5;
        // 
        // lblTelefonnummer
        // 
        lblTelefonnummer.AutoSize = true;
        lblTelefonnummer.Location = new Point(30, 150);
        lblTelefonnummer.Margin = new Padding(2, 0, 2, 0);
        lblTelefonnummer.Name = "lblTelefonnummer";
        lblTelefonnummer.Size = new Size(135, 25);
        lblTelefonnummer.TabIndex = 6;
        lblTelefonnummer.Text = "Telefonnummer";
        // 
        // txtTelefonnummer
        // 
        txtTelefonnummer.Location = new Point(179, 148);
        txtTelefonnummer.Margin = new Padding(2);
        txtTelefonnummer.Name = "txtTelefonnummer";
        txtTelefonnummer.Size = new Size(285, 31);
        txtTelefonnummer.TabIndex = 7;
        // 
        // lblLösenord
        // 
        lblLösenord.AutoSize = true;
        lblLösenord.Location = new Point(30, 190);
        lblLösenord.Margin = new Padding(2, 0, 2, 0);
        lblLösenord.Name = "lblLösenord";
        lblLösenord.Size = new Size(86, 25);
        lblLösenord.TabIndex = 8;
        lblLösenord.Text = "Lösenord";
        // 
        // txtLösenord
        // 
        txtLösenord.Location = new Point(179, 188);
        txtLösenord.Margin = new Padding(2);
        txtLösenord.Name = "txtLösenord";
        txtLösenord.Size = new Size(285, 31);
        txtLösenord.TabIndex = 9;
        txtLösenord.UseSystemPasswordChar = true;
        // 
        // btnRegistrera
        // 
        btnRegistrera.Location = new Point(112, 240);
        btnRegistrera.Margin = new Padding(2);
        btnRegistrera.Name = "btnRegistrera";
        btnRegistrera.Size = new Size(115, 35);
        btnRegistrera.TabIndex = 10;
        btnRegistrera.Text = "Registrera";
        btnRegistrera.UseVisualStyleBackColor = true;
        btnRegistrera.Click += btnRegistrera_Click;
        // 
        // btnAvbryt
        // 
        btnAvbryt.Location = new Point(240, 240);
        btnAvbryt.Margin = new Padding(2);
        btnAvbryt.Name = "btnAvbryt";
        btnAvbryt.Size = new Size(100, 35);
        btnAvbryt.TabIndex = 11;
        btnAvbryt.Text = "Avbryt";
        btnAvbryt.UseVisualStyleBackColor = true;
        btnAvbryt.Click += btnAvbryt_Click;
        // 
        // RegistreringsForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(520, 401);
        Controls.Add(lblFörnamn);
        Controls.Add(txtFörnamn);
        Controls.Add(lblEfternamn);
        Controls.Add(txtEfternamn);
        Controls.Add(lblEpost);
        Controls.Add(txtEpost);
        Controls.Add(lblTelefonnummer);
        Controls.Add(txtTelefonnummer);
        Controls.Add(lblLösenord);
        Controls.Add(txtLösenord);
        Controls.Add(btnRegistrera);
        Controls.Add(btnAvbryt);
        Margin = new Padding(2);
        Name = "RegistreringsForm";
        Text = "Registrering";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblFörnamn;
    private TextBox txtFörnamn;
    private Label lblEfternamn;
    private TextBox txtEfternamn;
    private Label lblEpost;
    private TextBox txtEpost;
    private Label lblTelefonnummer;
    private TextBox txtTelefonnummer;
    private Label lblLösenord;
    private TextBox txtLösenord;
    private Button btnRegistrera;
    private Button btnAvbryt;
}
