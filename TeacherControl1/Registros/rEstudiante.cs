using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Forms;
using BLL;




 namespace TeacherControl1
{
    public partial class rEstudiante: Form
    {

        public Estudiantes es;
       
          
        public rEstudiante()
        { 
            InitializeComponent();
        }

 
        
        /// <summary>
        ///Metodo Boton Buscar En La base De Dato Estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
            
            if (IdEstudiantemaskedTextBox.Text == "")
            {
                //CUANDO NO HAY NADA LANZAR LA BUSQUEDA
                Registros.BusquedaEstudiantes Busqueda = new Registros.BusquedaEstudiantes();
                Busqueda.ShowDialog();
                if (Busqueda.IdEncontrado !=0)
                {
                    IdEstudiantemaskedTextBox.Text = Busqueda.IdEncontrado.ToString();
                    //TODO: Sacar el buscar a un metodo para no repetir el codigo
                    Buscarbutton.PerformClick();
                }
               // MessageBox.Show("Debe Digitar Un ID Para Buscar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else {
                     es = new Estudiantes();
                     if (es.Buscar(Convert.ToInt32(IdEstudiantemaskedTextBox.Text)))
                         {
                         
                               NombretextBox.Text = es.Nombre;
                               ApellidotextBox.Text = es.Apellido;
                               TelefonfomaskedTextBox.Text = es.Telefono;
                               MatriculamaskedTextBox1.Text = es.Matricula;
                               CedulamaskedTextBox.Text = es.Cedula;
                               DirecciontextBox.Text = es.Direccion;
                               EmailtextBox.Text = es.Email;
                               FechaNacdateTimePicker.Text = es.FechaNac.ToString();
                               GenerocomboBox.Text = GeneroIntAString (es.Genero);

                         }
                     else//NO ES NECESARIO BUSCAR DOS VECES..... if (es.Buscar(Convert.ToInt32(IdEstudiantemaskedTextBox.Text)) == false)
                     {
                         MessageBox.Show("No Existe ID","Iformacion",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                     }

                }
          

 
        }
        /// <summary>
        /// Metodo Boton Guardar En La Base De Dato Estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if ((NombretextBox.TextLength == 0 ) && (ApellidotextBox.TextLength == 0) && (MatriculamaskedTextBox1.Visible == true))
            {
                MessageBox.Show("Error Los Campos (Nombre ,Apellido y Matricula) No pueden Estar Vacios","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);

            }
            else
            {

                es = new Estudiantes(NombretextBox.Text, ApellidotextBox.Text, MatriculamaskedTextBox1.Text, TelefonfomaskedTextBox.Text, CedulamaskedTextBox.Text, DirecciontextBox.Text, EmailtextBox.Text,
                   FechaNacdateTimePicker.Value,GeneroTextAInt(GenerocomboBox.Text));

                if (es.Insertar())
                {
                    MessageBox.Show("Transaccion exitosa!!!!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);

                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);

                }
            }     

            
        }
        /// <summary>
        ///  Metodo Boton Nuevo En La Base De Dato Estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Metodo Boton Eliminar En Base De Dato Estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdEstudiantemaskedTextBox.Text == "")
            {
                MessageBox.Show("Debe Digitar Un ID Para Eliminar","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            else
            {
                es = new Estudiantes();
                if (es.Eliminar(Convert.ToInt32(IdEstudiantemaskedTextBox.Text)))
                {
                    MessageBox.Show("Eliminado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Error al Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);


            }
            
        }
        /// <summary>
        /// Metodo Boton Actualizar En Base De Datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
                
            if (IdEstudiantemaskedTextBox.Text == "")
            {
                MessageBox.Show("Debe Digitar Un ID Para Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            else
            {
                es = new Estudiantes( NombretextBox.Text, ApellidotextBox.Text, MatriculamaskedTextBox1.Text, TelefonfomaskedTextBox.Text, CedulamaskedTextBox.Text, DirecciontextBox.Text, EmailtextBox.Text,
                    FechaNacdateTimePicker.Value,GeneroTextAInt(GenerocomboBox.Text));
                if (es.Modificar(Convert.ToInt32(IdEstudiantemaskedTextBox.Text)))
                {
                    MessageBox.Show("Actualizacion Completa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Erro Al Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        /// <summary>
        /// Metodo Limpiar Limpia Campos De Registro.cs
        /// </summary>
        public  void Limpiar()
        {

            IdEstudiantemaskedTextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            MatriculamaskedTextBox1.Clear();
            TelefonfomaskedTextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();

        }
        /// <summary>
        /// Metodo Bucar en En la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerEstbutton_Click(object sender, EventArgs e)
        {
           
           
        }
        /// <summary>
        /// Validador de Text En Nombre Solo Letras ,Backspase y Space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                      e.Handled = true;
                      return;
            }
        }
        /// <summary>
        /// Validador de Text En Apellido Solo Letras ,Backspase y Space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// Coversor de Genero a Int
        /// </summary>
        /// <param name="genero"></param>
        /// <returns></returns>
        private int GeneroTextAInt(string genero)
        {
          

            int Valor = 0;
            if (GenerocomboBox.Text == "Femenino")
            {
                Valor = 1;
            }
            if (GenerocomboBox.Text == "Masculino")
            {
                Valor = 2;
            }
            if (GenerocomboBox.Text == "[Todo]")
            {
                Valor = 3;
            }
            return Valor;
        }
        /// <summary>
        /// Convierte De genero int A string 
        /// </summary>
        /// <param name="genero"></param>
        /// <returns></returns>
        private string GeneroIntAString(int genero)
        {
            String Genero = "";
            if (genero == 2) 
            {
                Genero = "Masculino";
            }
            if (genero == 1)
            {
                Genero = "Femenino";
            }
            if (genero == 3)
            {
                Genero = "[Todo]";
            }
            return Genero;
        }

       
    }


 }
   

