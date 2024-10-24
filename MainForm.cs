using System;
using System.Windows.Forms;

namespace proyectoo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GenerarRFC(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
           
            string rfc = apellido1.Substring(0, 2) + apellido2.Substring(0, 1) + nombre.Substring(0, 1) + fechaNacimiento.ToString("yyMMdd");
            return rfc; 
        }

        private void BtnCalcularClick(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;
            string rfc = GenerarRFC(nombre, apellido1, apellido2, fechaNacimiento);
            string NombreCompleto = nombre + " " + apellido1 + " " + apellido2;

            
         
            parte2 mostrarRFC = new parte2();
            mostrarRFC.SetRFC(rfc, NombreCompleto);
            mostrarRFC.ShowDialog();
        }
    }
}
