using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        // PRE:
        // POS: get: acceso mediante el patrón Singleton a la "tabla" presupuestos.
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

        // PRE: p != null.
        // POS: inserta p en la "tabla" presupuestos.
        public static void INSERTPresupuesto(PresupuestoDato p)
        {
            BD.Presupuestos.Add(p);
        }

        // PRE: p != null.
        // POS: devuelve un objeto de tipo PresupuestoDato obtenido de la "tabla" presupuestos a partir del parámetro p.
        public static PresupuestoDato SELECTPresupuesto(PresupuestoDato p)
        {
            return BD.Presupuestos[p.FechaRealizacion + " " + p.Cliente + " " + p.Vehiculo];
        }

        // PRE: p != null.
        // POS: elimina de la "tabla" presupuestos p, si p se encuentra en ella.
        public static void DELETEPresupuesto(PresupuestoDato p)
        {
            BD.Presupuestos.Remove(p);
        }

        // PRE: p != null;
        // POS: actualiza el objeto p en la "tabla" presupuestos.
        public static void UPDATEPresupuesto(PresupuestoDato p)
        {
            BD.DELETEPresupuesto(p);
            BD.INSERTPresupuesto(p);

        }

        // PRE:
        // POS: devuelve una colección compuesta por todos los objetos de tipo PresupuestoDato contenidos en la "tabla" presupuestos.
        public static KeyedCollection<string, PresupuestoDato> GetPresupuestos()
        {
            return (BD.presupuestos);
        }

        #endregion

        #region vehiculos
        private static TablaVehiculos vehiculos;

        public static TablaVehiculos Vehiculos
        {
            get
            {
                if (vehiculos == null)
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

        public static VehiculoDato SELECTVehiculoNum(String num)
        {
            return BD.vehiculos[num];
        }

        public static KeyedCollection<string, VehiculoDato> GetAll()
        {
            return BD.vehiculos;
        }

        public static Dictionary<string, VehiculoDato> GetSegundaMano()
        {
            KeyedCollection<string, VehiculoDato> vehiculos = BD.vehiculos;
            Dictionary<string, VehiculoDato> segundaMano = new Dictionary<string, VehiculoDato>();
            foreach (VehiculoDato vehiculoDato in vehiculos)
            {
                if ((vehiculoDato.FechaMatriculacion != null) && (vehiculoDato.Matricula != null))
                    segundaMano.Add(vehiculoDato.NumeroDeBastidor, vehiculoDato);
            }
            return segundaMano;
        }

        public static Dictionary<string, VehiculoDato> GetNuevos()
        {
            KeyedCollection<string, VehiculoDato> vehiculos = BD.vehiculos;
            Dictionary<string, VehiculoDato> nuevos = new Dictionary<string, VehiculoDato>();
            foreach (VehiculoDato vehiculoDato in vehiculos)
            {
                if ((vehiculoDato.FechaMatriculacion == null) && (vehiculoDato.Matricula == null))
                    nuevos.Add(vehiculoDato.NumeroDeBastidor, vehiculoDato);
            }
            return nuevos;
        }

        #endregion

        #region clientes
        private static TablaClientes clientes;

        public static TablaClientes Clientes
        {
            get
            {
                if (clientes == null)
                {
                    clientes = new TablaClientes();
                }

                return (clientes);
            }
        }

        public static void INSERTCliente(ClienteDato c)
        {
            BD.Clientes.Add(c);
        }

        public static ClienteDato SELECTCliente(String dni)
        {
            return BD.Clientes[dni];
        }

        public static void DELETECliente(ClienteDato c)
        {
            BD.Clientes.Remove(c);
        }

        public static bool ISCliente(String dni)
        {
            return BD.Clientes.Contains(dni);
        }

        public static void UPDATECliente(ClienteDato c)
        {
            BD.DELETECliente(c);
            BD.INSERTCliente(c);

        }

        public static List<ClienteDato> ALLClientes()
        {
            List<ClienteDato> clientes = new List<ClienteDato>();
            foreach (ClienteDato c in BD.Clientes)
            {
                clientes.Add(c);
            }
            return clientes;
        }
        #endregion

        #region extras
        private static TablaExtras extras;

        public static TablaExtras Extras
        {
            get
            {
                if (extras == null)
                {
                    extras = new TablaExtras();
                }

                return (extras);
            }
        }

        public static void INSERTExtra(ExtraDato e)
        {
            BD.Extras.Add(e);
        }

        public static ExtraDato SELECTExtra(ExtraDato e)
        {
            return BD.Extras[e.Nombre];
        }

        public static void DELETEExtra(ExtraDato e)
        {
            BD.Extras.Remove(e);
        }

        public static void UPDATEExtra(ExtraDato e)
        {
            BD.DELETEExtra(e);
            BD.INSERTExtra(e);

        }

        #endregion
    }
}
