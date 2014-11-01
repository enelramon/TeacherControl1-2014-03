using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    public class Deudas
    {
       
        public int IdDeuda { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public int IdEstudiante { get; set; }
        public int Cantidad { get; set; }
        public int Balance { get; set; }
        

        Conexion ConexionDB = new Conexion();
   
        /// <summary>
        /// Constructores
        /// </summary>
        public Deudas()
        {
            this.IdDeuda = 0;
            this.IdEstudiante = 0;
            this.Cantidad = 0;
            this.Balance = 0;


        }
        public Deudas(int IdEstudiante, int Cantidad, DateTime Fecha, DateTime Vence)
        {
            this.IdDeuda = IdDeuda;
            this.IdEstudiante = IdEstudiante;
            this.Cantidad = Cantidad;
            this.Balance = Balance;
            this.Fecha = Fecha;
            this.Vence = Vence;

        }

       /// <summary>
        /// Metodo Insertar Datos En Base de Datos
       /// </summary>
       /// <returns></returns>
        public bool Insertar()
        {

            return ConexionDB.EjecutarDB("Insert Into DeudasChocolate(Fecha,Vence,IdEstudiante,Cantidad,Balance) Values ('" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "','" + Vence.ToString("MM/dd/yyyy HH:mm:ss") + "','" + IdEstudiante + "','" + Cantidad + "','" + Cantidad + "')");

        }
        /// <summary>
        /// Metodo Modificar Datos En Base de Datos
        /// </summary>
        /// <param name="IdDeuda"></param>
        /// <returns></returns>
        public bool Modificar(int IdDeuda)
        {
            return ConexionDB.EjecutarDB("update DeudasChocolate set Fecha ='" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "' ,Vence ='" + Vence.ToString("MM/dd/yyyy HH:mm:ss") + "' ,IdEstudiante ='" + IdEstudiante + "',Cantidad ='" + Cantidad + "',Balance ='" + Cantidad + "' where IdDeuda ='" + IdDeuda + "'");
        }   
        /// <summary>
        /// Medoto Eliminar Datos En Base de Datos
        /// </summary>
        /// <param name="IdDeuda"></param>
        /// <returns></returns>
        public bool Eliminar(int IdDeuda)
        {
            return ConexionDB.EjecutarDB("delete from DeudasChocolate where IdDeuda="+IdDeuda);
        }
        /// <summary>
        /// Metodo Buscar Datos En Base de Datos
        /// </summary>
        /// <param name="IdDeuda"></param>
        /// <returns></returns>
        public bool Buscar(int IdDeuda)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt= ConexionDB.BuscarDb("select *from DeudasChocolate where IdDeuda=" + IdDeuda);

            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                IdDeuda = (int)dt.Rows[0]["IdDeuda"];
                Fecha = (DateTime)dt.Rows[0]["Fecha"];
                Vence = (DateTime)dt.Rows[0]["Vence"];
                IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
                Cantidad = (int)dt.Rows[0]["Cantidad"];
                Balance = (int)dt.Rows[0]["Balance"];

            }
            return mensaje;
        }
        /// <summary>
        /// Metodo Lista Datos En Base de Datos
        /// </summary>
        /// <param name="Campo"></param>
        /// <param name="FiltroWere"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public  static   DataTable Lista(String Campo, String FiltroWere )
        {
            Conexion ConexionDB = new Conexion();
            return ConexionDB.BuscarDb("Select " + Campo + " from DeudasEstudiantes Where " + FiltroWere  );
        }
         
      
    }
}