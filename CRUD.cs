using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_ACIA
{
    public partial class CRUD : Form
    {

        public CRUD()
        {
            InitializeComponent();
            CedulaTXT.Enabled = false;
            NombreTXT.Enabled = false;
            ApellidoPTXT.Enabled = false;
            ApellidoMTXT.Enabled = false;
            dtpDATE.Enabled = false;
            BTNagregar2.Enabled = false;




        }

        private void InsertarCredencial()
        {

            
            string connectionString = "Server=tcp:aciaserver.database.windows.net,1433;Initial Catalog=ACIA;Persist Security Info=False;User ID=aciaserver;Password=z8DNXKisri_Pba.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Reemplaza por tu cadena de conexión
            string consulta = "INSERT INTO Credencial_Usuario (Usuario, Clave, Rol_ID) VALUES (@Usuario, @Clave, @Rol_ID)";

            // Obtener los valores de los controles TextBox y ComboBox
            string usuario = NombreUsuarioTXT.Text;
            string clave = ClaveTXT.Text;
            int rolID = Convert.ToInt32(RolCBX.SelectedValue);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Clave", clave);
                comando.Parameters.AddWithValue("@Rol_ID", rolID);

                try
                {
                    connection.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro insertado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

               
            }

           


        }

        private void InsertarUsuario()
        {
            string connectionString = "Server=tcp:aciaserver.database.windows.net,1433;Initial Catalog=ACIA;Persist Security Info=False;User ID=aciaserver;Password=z8DNXKisri_Pba.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Reemplaza por tu cadena de conexión

            // Obtener los valores de los controles
            string cedulaUsuario = CedulaTXT.Text;
            string nombreUsuario = NombreTXT.Text;
            string apellidoPaternoUsuario = ApellidoPTXT.Text;
            string apellidoMaternoUsuario = ApellidoMTXT.Text;
            DateTime fechaNacimientoUsuario = dtpDATE.Value;

            

            string consulta = "INSERT INTO Usuario (Cedula_Usuario, Nombre_Usuario, Apellido_Paterno_Usuario, Apellido_Materno_Usuario, FechaNacimiento_Usuario, ID_Credencial) VALUES (@Cedula, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento_Usuario, @IDCredencial)" + "SELECT MAX(Rol_ID) FROM Credencial_Usuario";
            int idCredencial = ObtenerUltimoIDCredencial(connectionString);
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                // Obtener el último Rol_ID de la tabla Credencial_Usuario
                string queryUltimoRolID = "SELECT MAX(Rol_ID) FROM Credencial_Usuario";

                // Crear un objeto SqlCommand para obtener el último Rol_ID
                SqlCommand commandUltimoRolID = new SqlCommand(queryUltimoRolID, connection);

                // Ejecutar la consulta para obtener el último Rol_ID
                int ultimoRolID = (int)commandUltimoRolID.ExecuteScalar();


            }
            */
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.AddWithValue("@Cedula", cedulaUsuario);
                comando.Parameters.AddWithValue("@Nombre", nombreUsuario);
                comando.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaternoUsuario);
                comando.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaternoUsuario);
                comando.Parameters.AddWithValue("@FechaNacimiento_Usuario", fechaNacimientoUsuario);
                comando.Parameters.AddWithValue("@IDCredencial", idCredencial);

                try
                {
                    connection.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro insertado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el registro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int ObtenerUltimoIDCredencial(string connectionString)
        {
            string consulta = "SELECT TOP 1 ID_Credencial FROM Credencial_Usuario ORDER BY ID_Credencial DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comando = new SqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        return Convert.ToInt32(resultado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el último ID_Credencial: " + ex.Message);
                }
            }

            return 0; // Valor predeterminado si no se puede obtener el último ID_Credencial
        }
        private void CRUD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCIADataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.aCIADataSet.Rol);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito y si la longitud actual del texto es menor que 11
            if (!char.IsDigit(e.KeyChar) || CedulaTXT.Text.Length >= 11)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AgregarCredenBTN_Click(object sender, EventArgs e)
        {
            InsertarCredencial();
            
            CedulaTXT.Enabled = true;
            NombreTXT.Enabled = true;
            ApellidoPTXT.Enabled = true;
            ApellidoMTXT.Enabled = true;
            dtpDATE.Enabled = true;
            BTNagregar2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNagregar2_Click(object sender, EventArgs e)
        {
            InsertarUsuario();
        }

        private void WelcomeToUser_Click(object sender, EventArgs e)
        {

        }
    }
}
