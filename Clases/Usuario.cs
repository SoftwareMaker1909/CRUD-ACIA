using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ACIA.Clases
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Cedula_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Paterno_Usuario { get; set; }
        public string Apellido_Materno_Usuario { get; set; }
        public DateTime FechaNacimiento_Usuario { get; set; }
        public int ID_Credencial { get; set; }
        public int ID_Seccion { get; set; }
        public string ResponsableInsert { get; set; }
        public DateTime DateTimeInsert { get; set; }
        public bool isenabled { get; set; }
    }
}
