﻿using System;
using System.Windows.Forms;

namespace proyectoo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Método para generar el RFC
        private string GenerarRFC(string nombre, string apellido1, string apellido2, DateTime fechaNacimiento)
        {
            // Crear el RFC con partes simples
            string rfc = apellido1.Substring(0, 2) + apellido2.Substring(0, 1) + nombre.Substring(0, 1) + fechaNacimiento.ToString("yyMMdd");
            return rfc; // Devolver el RFC completo
        }

        // Evento para calcular el RFC al hacer clic en el botón
        void BtnCalcularClick(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtnombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;

            // Generar el RFC y mostrarlo en el Label
            lblResultado.Text = GenerarRFC(nombre, apellido1, apellido2, fechaNacimiento);
        }
    }
}
