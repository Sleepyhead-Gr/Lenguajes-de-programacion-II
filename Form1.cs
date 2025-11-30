using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coppel
{
    public partial class Form1 : Form
    {
        private COPPELDataSet datos;

        private COPPELDataSetTableAdapters.EmpleadoTableAdapter empleadoTA;
        private COPPELDataSetTableAdapters.centroTrabajoTableAdapter centroTrabajoTA;
        private COPPELDataSetTableAdapters.puestosTableAdapter puestosTA;
        private COPPELDataSetTableAdapters.DirectivosTableAdapter directivosTA;
        public Form1()
        {
            InitializeComponent();
            datos = new COPPELDataSet();
            empleadoTA = new COPPELDataSetTableAdapters.EmpleadoTableAdapter();
            centroTrabajoTA = new COPPELDataSetTableAdapters.centroTrabajoTableAdapter();
            puestosTA = new COPPELDataSetTableAdapters.puestosTableAdapter();
            directivosTA = new COPPELDataSetTableAdapters.DirectivosTableAdapter();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // vacío porque no necesitas nada aquí
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Llenar las tablas desde la base de datos
                empleadoTA.Fill(datos.Empleado);
                centroTrabajoTA.Fill(datos.centroTrabajo);
                puestosTA.Fill(datos.puestos);
                directivosTA.Fill(datos.Directivos);

                // Enlazar los DataGridView con los DataTable
                dgvEmpleado.DataSource = datos.Empleado;
                dgvCentroTrabajo.DataSource = datos.centroTrabajo;
                dgvPuestos.DataSource = datos.puestos;
                dgvDirectivos.DataSource = datos.Directivos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los datos desde la base de datos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
