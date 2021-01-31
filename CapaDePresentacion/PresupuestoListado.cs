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
        private List<MD.Presupuesto> presupuestos;

        // PRE:
        // POS: inicializa un formulario PresupuestoListado.
        public PresupuestoListado()
        {
            InitializeComponent();
        }

        // PRE:
        // POS: inicializa un formulario PresupuestoListado y le asigna la lista presupuestos al formulario, que se utilizará como origen de datos para el control DataGridView.
        public PresupuestoListado(List<MD.Presupuesto> presupuestos)
        {
            InitializeComponent();
            this.presupuestos = presupuestos;
        }

        // PRE:
        // POS: escribe en el control DataGridView de manera formateada (para facilitar la lectura de los datos) los contenidos de "presupuestos" durante la carga del formulario.
        private void PresupuestoListado_Load(object sender, EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 4;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            dataGrid.ColumnHeadersDefaultCellStyle = style;

            dataGrid.Columns[0].Name = "Cliente";
            dataGrid.Columns[1].Name = "Vehículo";
            dataGrid.Columns[2].Name = "Fecha";
            dataGrid.Columns[3].Name = "Estado";

            foreach (MD.Presupuesto presupuesto in presupuestos)
            {
                string nombre = presupuesto.Cliente.Nombre;
                string vehiculo = (presupuesto.Vehiculo != null ? (presupuesto.Vehiculo.Marca + " " + presupuesto.Vehiculo.Modelo + " " + presupuesto.Vehiculo.Año) : "");
                string fecha = presupuesto.FechaRealizacion.ToString("D");
                string estado = presupuesto.Estado.ToString();
                string[] cosas = { nombre, vehiculo, fecha, estado };

                dataGrid.Rows.Add(cosas);
            }
        }
    }
}
