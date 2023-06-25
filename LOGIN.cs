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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de entrada
            int ID_Credencial = Convert.ToInt32(USERTXT.Text);
            string Clave = CLAVETXT.Text;

            // Llamada al método para validar las credenciales
            bool isValid = ValidateCredentials(ID_Credencial, Clave);

            if (isValid)
            {
                MessageBox.Show("Credenciales válidas. Inicio de sesión exitoso.");
                // Realizar las acciones correspondientes al inicio de sesión exitoso

                CRUD crudd = new CRUD();
                crudd.Show();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Inicio de sesión fallido.");
                // Realizar las acciones correspondientes al inicio de sesión fallido
            }


        }

        private bool ValidateCredentials(int ID_Credencial, string Clave)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Credencial_Usuario WHERE ID_Credencial = @ID_Credencial AND Clave = @Clave AND Rol_ID = 2";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID_Credencial", SqlDbType.Int).Value = ID_Credencial;
                    command.Parameters.AddWithValue("@Clave", SqlDbType.VarChar).Value = Clave;

                    int count = (int)command.ExecuteScalar();

                    isValid = (count > 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return isValid;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
