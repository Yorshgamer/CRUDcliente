using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace Diseño_ClientesCRUD
{
    internal class Conexion
    {
        SqlConnection SQLCON;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void Open()
        {
            try
            {
                String Nombre_Servidor = Dns.GetHostName();
                SQLCON = new SqlConnection("Data Source=DESKTOP-0GNS5FN;Initial Catalog=Mapli;User ID=sa;Password=yortastic321");
                SQLCON.Open();
                MessageBox.Show("Conexion Abierta");
            }
            catch (Exception)
            {

            }
        }

        public void Close()
        {
            SQLCON.Close();
            MessageBox.Show("Conexion Cerrada");

        }
        public string Cadena()
        {
            return SQLCON.ConnectionString;
        }

        public void InsertarDatosCliente(string datosTotales)
        {
            try
            {
                Open(); // Abre la conexión

                string query = $"INSERT INTO IQV_Cliente (IQV_DNI_Cli, IQV_Nombre_Cli, IQV_ApPaterno_Cli, IQV_ApMaterno_Cli, IQV_Sexo_Cli,IQV_Direccion_Cli,IQV_Numero_Cli,\r\nIQV_Correo_Cli,IQV_FechaNac_Cli,IQV_Usuario_C, IQV_Fecha_C, IQV_Hora_C, IQV_Lugar_C) VALUES ({datosTotales});";

                cmd = new SqlCommand(query, SQLCON);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Datos insertados correctamente en la tabla cliente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar datos en la tabla cliente: {ex.Message}");
            }
            finally
            {
                Close(); // Cierra la conexión
            }
        }
    }
}

