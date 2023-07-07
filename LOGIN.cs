using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using CRUD_ACIA.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRUD_ACIA
{
    public partial class LOGIN : Form
    {

        private string connectionString = "Server=tcp:aciaserver.database.windows.net,1433;Initial Catalog=ACIA;Persist Security Info=False;User ID=aciaserver;Password=z8DNXKisri_Pba.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public LOGIN()
        {
            InitializeComponent();

            

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool isFirstEdit = true;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (isFirstEdit)
            {
                USERTXT.Text = string.Empty;
                isFirstEdit = false;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada
            string Usuario = USERTXT.Text;
            string Clave = CLAVETXT.Text;

            // Llamada al método para validar las credenciales
            bool isValid = ValidateCredentials(Usuario, Clave);

            if (isValid)
            {
                MessageBox.Show("Credenciales válidas. Inicio de sesión exitoso.");
                // Realizar las acciones correspondientes al inicio de sesión exitoso

                CRUD crudd = new CRUD();
                crudd.Show();
                this.Hide();
                Clases.Usuario CurrentUser = new Clases.Usuario();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SPObtenerInfoUsuarioPorUserName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@User", Usuario);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            try
                            {

                                if (reader.Read())
                                {
                                    CurrentUser.ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]);
                                    CurrentUser.Cedula_Usuario = reader["Cedula_Usuario"].ToString();
                                    CurrentUser.Nombre_Usuario = reader["Nombre_Usuario"].ToString();
                                    CurrentUser.Apellido_Paterno_Usuario = reader["Apellido_Paterno_Usuario"].ToString();
                                    CurrentUser.Apellido_Materno_Usuario = reader["Apellido_Materno_Usuario"].ToString();
                                    CurrentUser.FechaNacimiento_Usuario = Convert.ToDateTime(reader["FechaNacimiento_Usuario"]);
                                    CurrentUser.ID_Credencial = Convert.ToInt32(reader["ID_Credencial"]);
                                    CurrentUser.ID_Seccion = Convert.ToInt32(reader["ID_Seccion"]);
                                    CurrentUser.isenabled = Convert.ToBoolean(reader["isenabled"]);
                                }
                                else
                                {
                                }
                            }
                            catch(Exception ex) { }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Inicio de sesión fallido.");
                // Realizar las acciones correspondientes al inicio de sesión fallido
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isFirstEditPass = true;
        private void CLAVETXT_TextChanged(object sender, EventArgs e)
        {

            if (isFirstEditPass)
            {
                CLAVETXT.Text = string.Empty;
                isFirstEditPass = false;
            }

        }

        private bool ValidateCredentials(string Usuario, string Clave)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Credencial_Usuario WHERE Usuario = @Usuario AND Clave = @Clave AND Rol_ID = 2";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Usuario", SqlDbType.Int).Value = Usuario;
                    command.Parameters.AddWithValue("@Clave", SqlDbType.VarChar).Value = Clave;

                    int count = (int)command.ExecuteScalar();

                    isValid = (count > 0);
                    if (isValid) { InsertarLoginLog("CRUD_ValidateCredentials Line 76", "0000", 1, "Inicio de Sesion Exitoso para " + Usuario); }
                    else { InsertarLoginLog("CRUD_ValidateCredentials Line 76", "UNF", 1, "No se encuentra un usuario con las caracteristicas"); }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                    InsertarLoginLog("CRUD_ValidateCredentials Line 76", "SYS_ERROR", 1, "Error del sistema, comuniquese con el departamento de BackEnd");

                }
            }

            return isValid;
        }

        public void InsertarLoginLog(string modulo,string ErrorCode, int sesionID,string ErrorDescription)
        {
            try

            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand("INSERT INTO Login_LOGS (Date_Log, Modulo, Codigo_Error, ID_Sesion, ErrorDescription) VALUES (GETDATE(), @Modulo, @ErrorCode, @SesionID, @ErrorDescription)", connection);
                    command.Parameters.AddWithValue("@Modulo", modulo);
                    command.Parameters.AddWithValue("@ErrorCode", ErrorCode);
                    command.Parameters.AddWithValue("@SesionID", sesionID);
                    command.Parameters.AddWithValue("@ErrorDescription", ErrorDescription);

                    command.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            { 
            
            }

        }

    }
}
