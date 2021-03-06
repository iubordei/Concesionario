﻿using System;
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
    public partial class VehiculoUnoAUno : Form
    {
        private List<MD.Vehiculo> vehiculos = LNVehiculo.Vehiculo.GetAllVehiculos();
        private Nuevo nuevo = new Nuevo();
        private SegundaMano segundaMano = new SegundaMano();

        // PRE:
        // POS: crea un formulario de tipo "VehiculoUnoAUno".
        public VehiculoUnoAUno()
        {
            InitializeComponent();
            List<MD.Vehiculo> vehiculos = LNVehiculo.Vehiculo.GetAllVehiculos();
            foreach (MD.Vehiculo vehiculo in vehiculos)
            {
                bindingSource1.Add(vehiculo);
            }
            rellenarDatos(int.Parse(bindingNavigatorPositionItem.Text) - 1, vehiculos);
            
        }

        // PRE: una lista de vehiculos inicializada y != null y una posicion de la lista
        // POS: se rellenan todos los controles del formulario con los datos de vehiculo que ocupa dicha posicion de la lista
        public void rellenarDatos(int posicion, List<MD.Vehiculo> vehiculos)
        {
            tbNumeroBastidor.Text = vehiculos[posicion].NumeroDeBastidor;
            tbAño.Text = vehiculos[posicion].Año.ToString();
            tbMarca.Text = vehiculos[posicion].Marca;
            tbModelo.Text = vehiculos[posicion].Modelo;
            tbPotencia.Text = vehiculos[posicion].Potencia.ToString();
            tbPrecioRecomendado.Text = vehiculos[posicion].PrecioRecomendado.ToString();
            if (vehiculos[posicion].GetType() == typeof(MD.SegundaMano))
            {
                rbSegundaMano.Checked = true;
                rbSegundaMano.Enabled = false;
                segundaMano = new SegundaMano(((MD.SegundaMano)vehiculos[posicion]).Matricula, ((MD.SegundaMano)vehiculos[posicion]).FechaMatriculacion);
                segundaMano.Location = new Point(352, 173);
                segundaMano.Show();
                Controls.Add(segundaMano);
            }
            if (vehiculos[posicion].GetType() == typeof(MD.Nuevo))
            {
                rbNuevo.Checked = true;
                rbNuevo.Enabled = false;
                nuevo = new Nuevo(((MD.Nuevo)vehiculos[posicion]).Extras);
                nuevo.Location = new Point(352, 173);
                nuevo.Show();
                Controls.Add(nuevo);
            }
            tbNumeroBastidor.Enabled = false;
            tbModelo.Enabled = false;
            tbMarca.Enabled = false;
            tbAño.Enabled = false;
            tbPotencia.Enabled = false;
            tbPrecioRecomendado.Enabled = false;
        }

        // PRE:
        // POS: se añade un nuevo vehiculo
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave("Alta");
            VehiculoAgregarClave.ShowDialog();
        }

        // PRE:
        // POS: se elimina el vehiculo
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave("Baja");
            VehiculoAgregarClave.ShowDialog();
        }

        // PRE:
        // POS: se rellenan los controles con los datos del vehiculo que ocupe la siguiente posicion
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            segundaMano.Hide();
            nuevo.Hide();
            rellenarDatos(int.Parse(bindingNavigatorPositionItem.Text) - 1, vehiculos);
        }

        // PRE:
        // POS: se rellenan los controles con los datos del vehiculo que ocupe la anterior posicion
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            nuevo.Hide();
            segundaMano.Hide();
            rellenarDatos(int.Parse(bindingNavigatorPositionItem.Text) - 1, vehiculos);
        }

        // PRE:
        // POS: se rellenan los controles con los datos del vehiculo que ocupe la ultima posicion
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            segundaMano.Hide();
            nuevo.Hide();
            rellenarDatos(int.Parse(bindingNavigatorPositionItem.Text) - 1, vehiculos);

        }

        // PRE:
        // POS: se rellenan los controles con los datos del vehiculo que ocupe la primera posicion
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            segundaMano.Hide();
            nuevo.Hide();
            rellenarDatos(int.Parse(bindingNavigatorPositionItem.Text) - 1, vehiculos);

        }
    }
}
