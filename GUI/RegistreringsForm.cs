using ServiceLager;

namespace GUI;

public partial class RegistreringsForm : Form
{
    private AnvändarController användarController { get; }

    public RegistreringsForm(BookSwapRegister register)
    {
        InitializeComponent();
        användarController = new AnvändarController(register);
    }

    private void btnRegistrera_Click(object sender, EventArgs e)
    {
        try
        {
            användarController.RegistreraStudent(
                txtFörnamn.Text,
                txtEfternamn.Text,
                txtEpost.Text,
                txtTelefonnummer.Text,
                txtLösenord.Text);

            MessageBox.Show("Kontot har skapats. Du kan nu logga in.",
                "Registrering klar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnAvbryt_Click(object sender, EventArgs e)
    {
        Close();
    }
}
