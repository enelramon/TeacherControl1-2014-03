using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace TeacherControl1.Registros
{
    public partial class BusquedaEstudiantes : Form
    {
        public int IdEncontrado = 0;

        public BusquedaEstudiantes()
        {
            InitializeComponent();
        }

        private void BusquedaEstudiantes_Load(object sender, EventArgs e)
        {
            DatosdataGridView.DataSource = Estudiantes.Lista("*", "1=1");
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            
                int.TryParse(DatosdataGridView.CurrentRow.Cells[0].Value.ToString(), out IdEncontrado);
                this.Close();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            IdEncontrado = 0;
            this.Close();
        }
    }
}
