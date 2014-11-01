using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace TeacherControl1
{
    public partial class rDeudas : Form
    {
        public rDeudas()
        {
            InitializeComponent();
        }
        public Deudas d;
        public string id;
       
       
        
        /// <summary>
        /// Metodo de Carga de Datos En el Combobox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rDeudas_Load(object sender, EventArgs e)
        { 
            IdEstudiantecomboBox.DataSource = Estudiantes.Lista("Nombre,IdEstudiante", "1=1");
            IdEstudiantecomboBox.ValueMember = "IdEstudiante";
            IdEstudiantecomboBox.DisplayMember = "Nombre";
        }
        /// <summary>
        /// Metodo De Carga dato en id Desde Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdEstudiantecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            id =IdEstudiantecomboBox.SelectedValue.ToString();
        }
        /// <summary>
        /// Boton Guardar En Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
            d = new Deudas(Convert.ToInt32(id), Convert.ToInt32(CantidadtextBox.Text), FechadateTimePicker.Value, VencedateTimePicker.Value);
            if (d.Insertar())
            {
                MessageBox.Show("Deuda Guardada");
            }

        }
        /// <summary>
        /// Boton Limpiar TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Metodo Limpiar TextBox
        /// </summary>
        public void Limpiar()
        {

            IdDeudatextBox.Clear();
            CantidadtextBox.Clear();
            BalancetextBox.Clear();
        }
        /// <summary>
        /// Boton Buscar en Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            d = new Deudas();
           if( d.Buscar(Convert.ToInt32(IdDeudatextBox.Text)))
            {
                FechadateTimePicker.Text = d.Fecha.ToString();
                IdEstudiantecomboBox.SelectedValue = d.IdEstudiante;
                VencedateTimePicker.Text = d.Vence.ToString();
                CantidadtextBox.Text = d.Cantidad.ToString();
                BalancetextBox.Text = d.Balance.ToString();
            }
        }
        /// <summary>
        /// Boton Eliminar En Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            d = new Deudas();
            if (d.Eliminar(Convert.ToInt32(IdDeudatextBox.Text))){
                MessageBox.Show("Se elimino Correctamente");
            }
        }
        /// <summary>
        /// Boton Actualizar Datos En Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            d = new Deudas(Convert.ToInt32(id), Convert.ToInt32(CantidadtextBox.Text), FechadateTimePicker.Value, VencedateTimePicker.Value);
            if (d.Modificar(Convert.ToInt32(IdDeudatextBox.Text)))
            {
                MessageBox.Show("Deuda Actulizaron sus Datos");
            }
        }    

       
    }
}
