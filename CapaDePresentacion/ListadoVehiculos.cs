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
    public partial class ListadoVehiculos : Form
    {
        // PRE:
        // POS: crea un formulario de tipo "ListadoVehiculos".
        public ListadoVehiculos()
        {
            InitializeComponent();
            List<MD.Vehiculo> vehiculos = LNVehiculo.Vehiculo.GetAllVehiculos();
            DataGridViewRow rowInicial = (DataGridViewRow)dataGridView1.Rows[0];
            rellenarCelda(rowInicial, vehiculos[0]);
            for(int i = 1; i < vehiculos.Count(); i++)
            {
                if (vehiculos[i].GetType() == typeof(MD.SegundaMano))
                    this.dataGridView1.Rows.Add(vehiculos[i].NumeroDeBastidor, vehiculos[i].Marca, vehiculos[i].Modelo, vehiculos[i].Potencia, vehiculos[i].PrecioRecomendado, vehiculos[i].Año, ((MD.SegundaMano)vehiculos[i]).Matricula, ((DateTime)((MD.SegundaMano)vehiculos[i]).FechaMatriculacion).ToString("dd-MM-yyyy"), "null");
                else
                    this.dataGridView1.Rows.Add(vehiculos[i].NumeroDeBastidor, vehiculos[i].Marca, vehiculos[i].Modelo, vehiculos[i].Potencia, vehiculos[i].PrecioRecomendado, vehiculos[i].Año, "null", "null", ((MD.Nuevo)vehiculos[i]).Extras.Count);
            }

        }

        // PRE: la fila debe de estar inicializada y != null y el vehiculo debe de estar inicializado y != null
        // POS: rellena los datos de la fila con los datos del vehiculo
        public void rellenarCelda(DataGridViewRow row, MD.Vehiculo vehiculo)
        {
            row.Cells[0].Value = vehiculo.NumeroDeBastidor;
            row.Cells[1].Value = vehiculo.Marca;
            row.Cells[2].Value = vehiculo.Modelo;
            row.Cells[3].Value = vehiculo.Potencia;
            row.Cells[4].Value = vehiculo.PrecioRecomendado;
            row.Cells[5].Value = vehiculo.Año;
            if (vehiculo.GetType() == typeof(MD.SegundaMano))
            {
                row.Cells[6].Value = ((MD.SegundaMano)vehiculo).Matricula;
                row.Cells[7].Value = ((DateTime)((MD.SegundaMano)vehiculo).FechaMatriculacion).ToString("dd-MM-yyyy");
                row.Cells[8].Value = "null";
            }
            if(vehiculo.GetType() == typeof(MD.Nuevo))
            {
                row.Cells[6].Value = "null";
                row.Cells[7].Value = "null";
                row.Cells[8].Value = ((MD.Nuevo)vehiculo).Extras.Count;
            }
        }
    }
}
