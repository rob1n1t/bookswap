using Models;
using ServiceLager;

namespace GUI
{
    public partial class InloggningsForm : Form
    {
        private BookSwapRegister register;
        private AnvändarController controller;

        public InloggningsForm(BookSwapRegister register)
        {
            InitializeComponent();

            this.register = register;
            controller = new AnvändarController(register);
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string epost = txtEpostadress.Text.Trim();
            string lösenord = txtLösenord.Text;

            Användare? användare = controller.LoggaIn(epost, lösenord);

            if (användare == null)
            {
                MessageBox.Show("Felaktig e-postadress eller lösenord",
                    "Inloggningen misslyckades",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (användare is Student)
            {
                AnnonsForm annonsForm = new AnnonsForm(register, användare);

                Hide();
                annonsForm.ShowDialog();
                Show();
            }

            else if (användare is Administratör administratör)
            {
                AdministrationsForm administrationsForm =
                    new AdministrationsForm(register, administratör);

                Hide();
                administrationsForm.ShowDialog();
                Show();
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            RegistreringsForm registreringsForm =
                new RegistreringsForm(register); 

            registreringsForm.ShowDialog();
        }
    }
}
