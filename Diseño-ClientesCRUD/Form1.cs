using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Diseño_ClientesCRUD
{
    public partial class Principal : System.Windows.Forms.Form
    {
        private Cliente_direcciones Formdirecciones;
        private Cliente_Contacto FormContacto;
        Conexion con = new Conexion();
  
        public Principal()
        {
            InitializeComponent();
            Formdirecciones = new Cliente_direcciones(this);
            FormContacto = new Cliente_Contacto(Formdirecciones);
        }
        private void btnDirec_Click(object sender, EventArgs e)
        {
            if (ValidarDNI())
            {
                Formdirecciones.Show();
                this.Hide();
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (ValidarDNI())
            {
                Formdirecciones.Show();
                this.Hide(); 
            }
                      
            
        }   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaliir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (ValidarDNI())
    {
        Formdirecciones.Show();
        this.Hide();
    }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open(); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Close();
        }
        public string GetDatos()
        {
            string Nombre = txtboxNombre.Text;
            string ApPaterno = textboxPaterno.Text;
            string ApMaterno = textboxMaterno.Text;
            string DNI = txtboxDNI.Text;
            string Genero = cboxGenero.Text;

            return $"'{DNI}',"+$"'{Nombre}',"+$"'{ApPaterno}'," + $"'{ApMaterno}'," + $"'{Genero}',";
        }
        public string GetDatosFec()
        {
            DateTime Fecha = FechaActual.Value;
            string FechaFormatAct = Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            return FechaFormatAct;
        }
        public string GetDatosFecNac()
        {
            DateTime FechaNaci = FechaNac.Value;
            string FechaFormatNac = FechaNaci.ToString("yyyy-MM-dd HH:mm:ss");
            return FechaFormatNac;
        }

        private bool ValidarDNI()
        {
            string DNI = txtboxDNI.Text;

            // Verificar que DNI tenga exactamente 8 caracteres
            if (DNI.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes tomar acciones adicionales si es necesario, como limpiar el cuadro de texto
                return false;
            }

            string Genero = cboxGenero.Text;
            if (Genero != "Masculino" && Genero != "Femenino")
            {
                MessageBox.Show("Por favor, selecciona un género válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
