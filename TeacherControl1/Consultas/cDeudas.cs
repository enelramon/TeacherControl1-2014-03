using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace TeacherControl1.Consultas
{
    public partial class cDeudas : Form
    {
        public cDeudas()
        {
            InitializeComponent();
        }

        private void FiltrarFechascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Fechaspanel.Visible = FiltrarFechascheckBox.Checked;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string Filtro = "1=1";

            if (FiltrarFechascheckBox.Checked)
                Filtro = "Fecha between '" + DesdedateTimePicker.Value.ToString("MM/dd/yyyy") + "' and '" + HastadateTimePicker.Value.ToString("MM/dd/yyyy") + "'";

            if (FiltrarFechascheckBox.Text.Length > 0 && CampocomboBox.SelectedIndex >0)//si hay algun dato entonces se puede filtrar
            {
                Filtro += " and " + CampocomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

                DatosdataGridView.DataSource = Deudas.Lista("*", Filtro);
        }
    }
}
