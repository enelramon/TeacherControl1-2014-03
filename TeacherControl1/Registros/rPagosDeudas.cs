using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;


namespace TeacherControl1
{
    public partial class rPagosDeudas : Form
    {
        public rPagosDeudas()
        {
            InitializeComponent();
        }
        public PagosDeudas p;
        public Deudas d;
        /// <summary>
        /// Variables idEst = IdEstudiante, idDeu=IdDeuda
        /// </summary>
        public int idEst;
        public int idDeu;
        /// <summary>
        /// Metodo Que Carga los datos en IdEstudianteCombobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void rPagos_Load(object sender, EventArgs e)
        {
          

                  


                  IdEstudiantecomboBox.DataSource = Estudiantes.Lista("Nombre,IdEstudiante", "1=1");
               IdEstudiantecomboBox.ValueMember = "IdEstudiante";
               IdEstudiantecomboBox.DisplayMember = "Nombre";


         
        }
        /// <summary>
        /// Metodo Que Carga Datos en IdDeuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdEstudiantecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            string id = IdEstudiantecomboBox.SelectedValue.ToString();
            int.TryParse(id,out idEst);

             d = new Deudas();

             IdDeudacomboBox.DataSource = Deudas.Lista("Cantidad,IdDeuda", "IdEstudiante=" + idEst.ToString());
            IdDeudacomboBox.ValueMember = "IdDeuda";
            IdDeudacomboBox.DisplayMember = "Cantidad";

          
        }
        /// <summary>
        /// Metodo Carga idD Desde IdDeuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdDeudacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idD = IdDeudacomboBox.SelectedValue.ToString();
            int.TryParse(idD, out idDeu);

        }
        /// <summary>
        /// Boton Buscar en Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            p = new PagosDeudas();
            if (p.Buscar(Convert.ToInt32(IdPagotextBox.Text)))
            {
                FechadateTimePicker.Text = p.Fecha.ToString();
                IdEstudiantecomboBox.SelectedValue = p.IdEstudiante;
                CantidadtextBox.Text = p.Cantidad.ToString();

            }
        }
        /// <summary>
        /// Boton Guardar Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            p = new PagosDeudas(FechadateTimePicker.Value, idEst, idDeu, Convert.ToInt32(CantidadtextBox.Text));
            if (p.Insertar())
               {
                 p.PagoDeuda(idDeu);
                 MessageBox.Show("Se Guardo El Pago");
                }
        }
        /// <summary>
        /// Boton Eliminar Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            p = new PagosDeudas();
            if (p.Eliminar(Convert.ToInt32(IdPagotextBox.Text)))
            {
                MessageBox.Show("Se Elimino Corectamente");
            }
        }
        /// <summary>
        /// Boton Actualizar Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {

            p = new PagosDeudas(FechadateTimePicker.Value, idEst, idDeu, Convert.ToInt32(CantidadtextBox.Text));
            if (p.Modificar(Convert.ToInt32(IdPagotextBox.Text)))
            {
                MessageBox.Show("Se Actualizaron los Datos");

            }
        }
        /// <summary>
        /// Boton Limpiar Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdPagotextBox.Clear();
            CantidadtextBox.Clear();
        }

        
       

      

       

       

       
    }

}