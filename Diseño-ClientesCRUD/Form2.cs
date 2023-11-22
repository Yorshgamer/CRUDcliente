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
    public partial class Cliente_direcciones : System.Windows.Forms.Form
    {
        private Principal FormPrincipal;
        private Cliente_Contacto FormContacto;

        public Cliente_direcciones(Principal FormPrincipal)
        {
            InitializeComponent();
            this.FormPrincipal = FormPrincipal;
            FormContacto = new Cliente_Contacto(this);
            this.BackColor = Color.LightBlue;
        }

        public void btnRetrocedes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.Show();
        }

        private void Cliente_direcciones_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            
            FormContacto.Show();
            this.Hide();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            FormContacto.Show();
            this.Hide();
        }

        private void btnSaliir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormPrincipal.Show();
            this.Hide();
        }
        public Principal GetFormPrincipal()
        {
            return FormPrincipal;
        }

        public string GetDatos()
        {
            string direccion = txtboxDireccion.Text;
            return $"'{direccion}',";
        }
    }
}
