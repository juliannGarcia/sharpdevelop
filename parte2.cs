using System.Windows.Forms;

namespace proyectoo
{
    public partial class parte2 : Form
    {
        public parte2()
        {
            InitializeComponent();
        }

        // Método para establecer el RFC y el nombre completo
        public void SetRFC(string rfc, string nombreCompleto)
        {
            lblRFC.Text = "RFC: " + rfc; // Asegúrate de tener un Label llamado lblRFC
            lblNombreCompleto.Text = "Nombre Completo: " + nombreCompleto; // Asegúrate de tener un Label llamado lblNombreCompleto
        }
    }
}
