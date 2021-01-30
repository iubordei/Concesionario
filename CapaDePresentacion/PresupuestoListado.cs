using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class PresupuestoListado : Form
    {
        // PRE:
        // POS: inicializa un formulario PresupuestoListado.
        public PresupuestoListado()
        {
            InitializeComponent();
        }

        // PRE:
        // POS: inicializa un formulario PresupuestoListado y le asigna al DataSource del BindingSource (que será el origen de datos para el DataGridView) la lista presupuestos.
        public PresupuestoListado(List<MD.Presupuesto> presupuestos)
        {
            InitializeComponent();
            presupuestoBindingSource.DataSource = presupuestos;
        }

        // PRE:
        // POS: recoge los datos del DataGridView principal y los escribe en otro DataGridView de manera formateada (para facilitar la lectura de los datos) durante la carga del formulario.
        private void PresupuestoListado_Load(object sender, EventArgs e)
        {
            dataGridPresupuesto.Visible = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 4;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            dataGrid.ColumnHeadersDefaultCellStyle = style;

            dataGrid.Columns[0].Name = "Cliente";
            dataGrid.Columns[0].Name = "Vehículo";
            dataGrid.Columns[0].Name = "Fecha";
            dataGrid.Columns[0].Name = "Estado";

            foreach (DataGridViewRow row in dataGridPresupuesto.Rows)
            {
                MD.Presupuesto presupuesto = (MD.Presupuesto)row.DataBoundItem;

                string nombre = presupuesto.Cliente.Nombre;
                string vehiculo = (presupuesto.Vehiculo != null ? (presupuesto.Vehiculo.Marca + " " + presupuesto.Vehiculo.Modelo + " " + presupuesto.Vehiculo.Año) : "");
                string fecha = presupuesto.FechaRealizacion.ToString();
                string estado = presupuesto.Estado.ToString();
                string[] cosas = { nombre, vehiculo, fecha, estado };
                dataGrid.Rows.Add(cosas);
            }
        }
    }
}
