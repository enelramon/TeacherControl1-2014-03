using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.BLL;

namespace DAL
{
    public partial class rEstudiantes : Form
    {
        Conexion ConexionDb = new Conexion();

        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Estudiantes estudiante = new Estudiantes(MatriculamaskedTextBox.Text, NombretextBox.Text, EmailtextBox.Text);

            //if (ConexionDb.EjecutarDB("Insert Into Estudiantes(Matricula,Nombres,Email) Values('" + MatriculamaskedTextBox.Text + "','" + NombretextBox.Text + "','" + EmailtextBox.Text + "')"))
           if ( estudiante.Insertar())
            {
                MessageBox.Show("Transaccion exitosa!!!!!!");
            }


        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            DataTable dt;

            int.TryParse(IdEstudiantetextBox.Text, out id);

           dt=  ConexionDb.BuscarDb("select * from Estudiantes where IdEstudiante =" + id.ToString());

            if (dt.Rows.Count > 0)
            {
                MatriculamaskedTextBox.Text = dt.Rows[0]["Matricula"].ToString();
                NombretextBox.Text = dt.Rows[0]["Nombres"].ToString();
            }

        }

 





    }
}
