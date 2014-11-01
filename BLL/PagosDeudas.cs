using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
   public  class PagosDeudas
    {

       public int IdPagos { set; get; }
       public DateTime Fecha { set; get; }
       public int IdEstudiante { set; get; }
       public int IdDeuda { set; get; }
       public int Cantidad { set; get; }

       Conexion ConexionDB = new Conexion();
       /// <summary>
       /// Constructores
       /// </summary>
       public PagosDeudas()
       {
           this.IdPagos = 0;
           this.IdDeuda = 0;
           this.IdEstudiante = 0;
           this.Cantidad = 0;
       }
       public PagosDeudas( DateTime Fecha, int IdEstudiante , int IdDeuda, int Cantidad)
       {
           this.IdDeuda = IdDeuda;
           this.Fecha = Fecha;
           this.IdEstudiante = IdEstudiante;
           this.Cantidad = Cantidad;

       }
       /// <summary>
       /// Metodo de Insertar Datos En Base de Datos
       /// </summary>
       /// <returns></returns>
       public bool Insertar()
       {

           return ConexionDB.EjecutarDB("Insert Into PagosDeudas(Fecha,IdEstudiante,IdDeuda,CantidadPagada) Values('" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") +  "','" + IdEstudiante + "','" + IdDeuda + "','" + Cantidad + "')");

       }
       /// <summary>
       /// Metodo de Modificar Datos En Base de Datos
       /// </summary>
       /// <param name="IdPago"></param>
       /// <returns></returns>
       public bool Modificar(int IdPago)
       {
           return ConexionDB.EjecutarDB("update PagosDeudas set Fecha ='" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "' ,IdEstudiante ='" + IdEstudiante + "',IdDeuda ='" + IdDeuda + "' ,CantidadPagada ='" + Cantidad + "' where IdPago='" + IdPago+"'");
       }
       /// <summary>
       /// Metodo de Eliminar Datos En Base de Datos
       /// </summary>
       /// <param name="IdPago"></param>
       /// <returns></returns>
       public bool Eliminar(int IdPago)
       {
           return ConexionDB.EjecutarDB("delete from PagosDeudas where IdPago=" + IdPago);
       }
       /// <summary>
       /// Metodo de Buscar Datos En Base de Datos
       /// </summary>
       /// <param name="IdPago"></param>
       /// <returns></returns>
       public bool Buscar(int IdPago)
       {
           bool mensaje = false;
           DataTable dt = new DataTable();
           dt = ConexionDB.BuscarDb("select * from PagosDeudas where IdPago=" + IdPago);

           if (dt.Rows.Count > 0)
           {
               mensaje = true;
                
               Fecha = (DateTime)dt.Rows[0]["Fecha"];
               IdEstudiante = (int)dt.Rows[0]["IdEstudiante"];
               IdDeuda = (int)dt.Rows[0]["IdDeuda"];
               Cantidad = (int)dt.Rows[0]["CantidadPagada"];

           }
           return mensaje;
       }
        /// <summary>
       /// Metodo De Listar Datos En Base de Datos
        /// </summary>
        /// <param name="Campo"></param>
        /// <param name="FiltroWere"></param>
        /// <returns></returns>
       public DataTable Lista(String Campo, String FiltroWere)
       {

           return ConexionDB.BuscarDb("Select " + Campo + " from PagosDeudas where  " + FiltroWere);
       }
       /// <summary>
       /// Metodo De Actualizacion de Pagos Datos En Base de Datos
       /// </summary>
       /// <param name="IdDeuda"></param>
       /// <returns></returns>
       public bool PagoDeuda(int IdDeuda)
       {
           return ConexionDB.EjecutarDB("Update DeudasChocolate  set Balance= Cantidad -'" + Cantidad+"' where IdDeuda='"+IdDeuda+ "'");
       }
       
   
    }
}
