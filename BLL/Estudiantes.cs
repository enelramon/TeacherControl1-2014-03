using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{

    public class Estudiantes
    {
        public int IdEstudiante { get; set; }
        public String Matricula { get; set; }
        public String Nombre { get; set; }
        public string Apellido { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public string Telefono { get; set; }
        public String Cedula { get; set; }
        public DateTime FechaNac { get; set; }
        public int Genero { get; set; }


        public Estudiantes()
        {

            this.IdEstudiante = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Matricula = "";
            this.Direccion = "";
            this.Email = "";
            this.Telefono = "";
            this.Cedula = "";
        }


        public Estudiantes(String Nombre, String Apellido, String Matricula, String Telefono, String Cedula, String Direccion, String Email, DateTime FechaNac, int Genero)
        {

            this.Nombre = Nombre;
            this.Matricula = Matricula;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
            this.FechaNac = FechaNac;
            this.Genero = Genero;

        }

        private Conexion ConexionDB = new Conexion();

        /// <summary>
        /// Metodo De insertar En La Base De Dato Estudiante
        /// </summary>
        /// <returns></returns>
        public bool Insertar()
        {

            return ConexionDB.EjecutarDB("Insert Into Estudiantes(Nombre,Apellido,Matricula,Telefono,Cedula,Direccion,Email,FechaNac , Genero) Values ('"
                        + Nombre + "','" + Apellido + "','" + Matricula + "','" + Telefono + "','" + Cedula + "','" + Direccion + "','" + Email + "','" + FechaNac.Day + "/" + FechaNac.Month + "/" +
                        FechaNac.Year + "','" + Genero + "')");

        }
        /// <summary>
        /// Medoto De Modificar En La Base De Dato Estudiante
        /// </summary>
        /// <returns></returns>
        public bool Modificar(int IdEstudiante)
        {

            return ConexionDB.EjecutarDB(" update Estudiantes set Nombre = '" + Nombre + "' ,Apellido ='" + Apellido + "',Matricula ='" + Matricula + "',Telefono ='" + Telefono + "',Cedula = '" + Cedula + "',Direccion = '" + Direccion + "',Email = '" + Email + "',FechaNac = '" + FechaNac.ToString("MM/dd/yyyy") + "',Genero ='" + Genero + "' where IdEstudiante = '" + IdEstudiante + "' ");
        }
        /// <summary>
        /// Metodo De Eliminar En La Base De Dato Estduiante
        /// </summary>
        /// <returns></returns>
        public bool Eliminar(int IdEstudiante)
        {

            return ConexionDB.EjecutarDB("delete from Estudiantes where IdEstudiante =" + IdEstudiante);
        }
        /// <summary>
        /// Metodo De Buscar En La Base De Dato Estduiante 
        /// </summary>
        /// <returns></returns>
        public bool Buscar(int IdEstudiante)
        {
            bool mensaje = false;


            DataTable dt;

            dt = ConexionDB.BuscarDb("select * from Estudiantes where IdEstudiante = " + IdEstudiante);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;

                IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                Nombre = dt.Rows[0]["Nombre"].ToString();
                Matricula = dt.Rows[0]["Matricula"].ToString();
                Apellido = dt.Rows[0]["Apellido"].ToString();
                Telefono = dt.Rows[0]["Telefono"].ToString();
                Cedula = dt.Rows[0]["Cedula"].ToString();
                Direccion = dt.Rows[0]["Direccion"].ToString();
                Email = dt.Rows[0]["Email"].ToString();
                FechaNac = (DateTime)dt.Rows[0]["FechaNac"];
                Genero = (int)dt.Rows[0]["Genero"];


            }

            return mensaje;
        }
        /// <summary>
        /// Metodo De Listar en  Datos En Base de Datos
        /// </summary>
        /// <param name="Campos"></param>
        /// <param name="FiltroWhere"></param>
        /// <returns></returns>
        public static  DataTable Lista(String Campos, String FiltroWhere)
        {
             Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campos + " from Estudiantes Where " + FiltroWhere);
        }
    }

}
