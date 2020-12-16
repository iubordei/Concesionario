using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class BD
    {
        private BD() { }

        #region presupuestos
        private static TablaPresupuestos presupuestos;
        public static TablaPresupuestos Presupuestos
        {
            get
            {
                if (presupuestos == null)
                {
                    presupuestos = new TablaPresupuestos();
                }

                return (presupuestos);
            }
        }

        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            BD.Presupuestos.Add(p);
        }

        public static PresupuestoDato SELECTPresupuesto(PresupuestoDato p)
        {
            return BD.Presupuestos[p.FechaRealizacion + " " + p.Cliente + " " + p.Vehiculo];
        }

        public static void DELETEPresupuesto(PresupuestoDato p)
        {
            BD.Presupuestos.Remove(p);
        }

        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            BD.DELETEPresupuesto(p);
            BD.INSERTPresupuesto(p);

        }

        #endregion

        #region vehiculos
        private static TablaVehiculos vehiculos;

        public static TablaVehiculos Vehiculos
        {
            get
            {
                if (presupuestos == null)
                {
                    vehiculos = new TablaVehiculos();
                }

                return (vehiculos);
            }
        }

        public static void INSERTVehiculo(VehiculoDato vehiculo)
        {
            BD.Vehiculos.Add(vehiculo);
        }

        public static VehiculoDato SELECTVehiculo(VehiculoDato vehiculo)
        {
            return BD.vehiculos[vehiculo.NumeroDeBastidor];
        }

        public static void DELETEVehiculo(VehiculoDato vehiculo)
        {
            BD.Vehiculos.Remove(vehiculo);
        }

        public static void UPDATEVehiculo(VehiculoDato vehiculo)
        {
            BD.DELETEVehiculo(vehiculo);
            BD.INSERTVehiculo(vehiculo);
        }
        #endregion

        #region clientes
        private static TablaClientes clientes;

        public static TablaClientes Clientes
        {
            get
            {
                if (presupuestos == null)
                {
                    clientes = new TablaClientes();
                }

                return (clientes);
            }
        }
        #endregion
    }
}
