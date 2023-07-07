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
    public partial class CRUD_ASIGNATURAS : Form
    {
        private const string connectionString = "Server=tcp:aciaserver.database.windows.net,1433;Initial Catalog=ACIA;Persist Security Info=False;User ID=aciaserver;Password=z8DNXKisri_Pba.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
        public CRUD_ASIGNATURAS()
        {
            InitializeComponent();
        }

        private void CrearAsignatura()
        {

            string nombreMateria = NombreMateriatbx.Text;
            string codigoMateria = CodigoMateriatbx.Text;
            int cuposMateria = (int)cuposmateriaUD.Value;
            string horarioMateria = HorarioMateriatbx.Text;
            int maestroMateria = (int)Maestrocbx.SelectedValue;
            int creditosMateria = (int)CreditoUD.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SPInsertarMateria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        command.Parameters.AddWithValue("@NombreMateria", nombreMateria);
                        command.Parameters.AddWithValue("@CodigoMateria", codigoMateria);
                        command.Parameters.AddWithValue("@CuposMateria", cuposMateria);
                        command.Parameters.AddWithValue("@HorarioMateria", horarioMateria);
                        command.Parameters.AddWithValue("@MaestroMateria", maestroMateria);
                        command.Parameters.AddWithValue("@CreditosMateria", creditosMateria);

                        // Parámetro opcional
                        command.Parameters.AddWithValue("@ResponsableInsert", 23);

                        // Ejecutar el stored procedure
                        int newId = Convert.ToInt32(command.ExecuteScalar());

                        MessageBox.Show("Materia insertada correctamente. ID generado: " + newId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la materia: " + ex.Message);
            }



        }
        private void Guardarbtn_Click(object sender, EventArgs e)
        {



            CrearAsignatura();  

        }

        private void CRUD_ASIGNATURAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aCIADataSetMaestro_Credencial.Maestro_Credencial' Puede moverla o quitarla según sea necesario.
            this.maestro_CredencialTableAdapter.Fill(this.aCIADataSetMaestro_Credencial.Maestro_Credencial);
            // TODO: esta línea de código carga datos en la tabla 'materiasDataset.Materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.materiasDataset.Materias);

        }
    }











}
