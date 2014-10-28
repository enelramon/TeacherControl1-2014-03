using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    class Estudiantes
    {
        public int IdEstudiante { get; set; }

        public string Matricula { get; set; }

        public string Nombres { get; set; }

        public string Email { get; set; }

        private Conexion ConexionDb = new Conexion();

        public Estudiantes()
        {
            this.Matricula = "";
        }

        public Estudiantes(string matricula, string nombres, string email)
        {
            this.Matricula = matricula;
            this.Nombres = nombres;
            this.Email = email;
        }

        public bool Insertar()
        {
            return ConexionDb.EjecutarDB("Insert Into Estudiantes(Matricula,Nombres,Email) Values('" + this.Matricula +
                "','" + this.Nombres + "','" + this.Email + "')");
        }

        public bool Modificar()
        {
            return ConexionDb.EjecutarDB("Update Estudiantes set Matricula='" + this.Matricula + "',Nombres='" + this.Nombres + "',Email='" + this.Email + "' Where IdEstudiante=" + IdEstudiante .ToString());
        }

        public bool Eliminar()
        {
            return ConexionDb.EjecutarDB("Delete Estudiantes Where IdEstudiante=" + IdEstudiante.ToString());

        }

        public bool Buscar(int id)
        {
            bool retorno = false;
            DataTable dt;

            dt = ConexionDb.BuscarDb("Select * from Estudiantes Where IdEstudiante=" + id );
            if (dt.Rows.Count >0)
            {
                this.IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                this.Matricula = (string )dt.Rows[0]["Matricula"];
                this.Nombres = (string)dt.Rows[0]["Nombres"];
                this.Email = (string)dt.Rows[0]["Email"];
            }

            return retorno;

        }

        public DataTable Lista(string Campos,string FiltroWhere)
        {
            
            return ConexionDb.BuscarDb("Select " + Campos + " from Estudiantes Where " + FiltroWhere );
        }

    }
}
