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

        // PRE:
        // POS: get: acceso mediante el patrón Singleton a la "tabla" vehiculos.
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

        // PRE: vehiculo != null.
        // POS: inserta vehiculo en la "tabla" vehiculos.
        public static void INSERTVehiculo(VehiculoDato vehiculo)
        {
            BD.Vehiculos.Add(vehiculo);
        }

        // PRE: vehiculo != null.
        // POS: devuelve un objeto de tipo VehiculoDato obtenido de la "tabla" vehiculos a partir del parámetro vehiculo.
        public static VehiculoDato SELECTVehiculo(VehiculoDato vehiculo)
        {
            if (BD.Vehiculos.Count == 0)
                return null;
            if (!contieneNum(vehiculo.NumeroDeBastidor))
                return null;
            else
                return BD.vehiculos[vehiculo.NumeroDeBastidor];
        }

        // PRE: vehiculo != null.
        // POS: elimina de la "tabla" vehiculos vehiculo, si vehiculo se encuentra en ella.
        public static void DELETEVehiculo(VehiculoDato vehiculo)
        {
            BD.Vehiculos.Remove(vehiculo);
        }

        // PRE: p != null;
        // POS: actualiza el objeto vehiculo en la "tabla" vehiculos.
        public static void UPDATEVehiculo(VehiculoDato vehiculo)
        {
            BD.DELETEVehiculo(vehiculo);
            BD.INSERTVehiculo(vehiculo);
        }

        // PRE: num != null.
        // POS: devuelve TRUE si la "tabla" vehiculos contiene un vehículo cuyo número de bastidor es num.
        public static bool contieneNum(String num)
        {
            foreach (VehiculoDato vehiculo in vehiculos)
            {
                if (vehiculo.NumeroDeBastidor.Equals(num))
                    return true;
            }
            return false;
        }

        // PRE: num != null.
        // POS: devuelve un objeto de tipo VehiculoDato obtenido de la "tabla" vehiculos, cuyo número de bastidor sea num.
        public static VehiculoDato SELECTVehiculoNum(String num)
        {
            if (BD.Vehiculos.Count == 0)
                return null;
            if (!contieneNum(num))
                return null;
            else
                return BD.vehiculos[num];
        }

        // PRE:
        // POS: devuelve una colección que contiene todos los objetos VehiculoDato almacenados en la "tabla" vehiculos.
        public static KeyedCollection<string, VehiculoDato> GetAll()
        {
            return BD.vehiculos;
        }

        // PRE:
        // POS: devuelve una colección que contiene todos los objetos VehiculoDato almacenados en la "tabla" vehiculos que sean de segunda mano.
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

        // PRE:
        // POS: devuelve una colección que contiene todos los objetos VehiculoDato almacenados en la "tabla" vehiculos que sean nuevos.
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

        // PRE:
        // POS: get: acceso mediante el patrón Singleton a la "tabla" clientes.
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

        // PRE: c != null.
        // POS: inserta c en la "tabla" clientes.
        public static void INSERTCliente(ClienteDato c)
        {
            BD.Clientes.Add(c);
        }

        // PRE: dni != null.
        // POS: devuelve un objeto de tipo ClienteDato obtenido de la "tabla" clientes cuyo DNI sea dni.
        public static ClienteDato SELECTCliente(String dni)
        {
            if (BD.Clientes.Count == 0)
                return null;
            if (!contieneDNI(dni))
                return null;
            else
                return BD.Clientes[dni];
        }

        public static ClienteDato SELECTCliente(ClienteDato cliente)
        {
            if (BD.Clientes.Count == 0)
                return null;
            if (!contieneDNI(cliente.DNI))
                return null;
            else
                return BD.Clientes[cliente.DNI];
        }

        // PRE: c != null.
        // POS: elimina de la "tabla" clientes c, si c se encuentra en ella.
        public static void DELETECliente(ClienteDato c)
        {
            if (BD.Clientes.Count != 0)
                BD.Clientes.Remove(c.DNI);
        }

        // PRE: dni != null.
        // POS: devuelve TRUE si el cliente cuyo DNI es dni se encuentra en la "tabla" clientes, FALSE en caso contrario.
        public static bool contieneDNI(String dni)
        {
            foreach (ClienteDato cliente in BD.Clientes)
            {
                if (cliente.DNI.Equals(dni))
                    return true;
            }
            return false;
        }

        // PRE: c != null;
        // POS: actualiza el objeto c en la "tabla" clientes.
        public static void UPDATECliente(ClienteDato c)
        {
            if (BD.Clientes.Count != 0)
            {
                BD.DELETECliente(c);
                BD.INSERTCliente(c);
            }

        }

        // PRE:
        // POS: devuelve una lista formada por objetos ClienteDato, que contiene a todos los clientes almacenados
        // POS: en la "tabla" clientes.
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

        // PRE:
        // POS: get: acceso mediante el patrón Singleton a la "tabla" extras.
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

        // PRE: e != null.
        // POS: inserta e en la "tabla" extras.
        public static void INSERTExtra(ExtraDato e)
        {
            BD.Extras.Add(e);
        }

        // PRE: e != null.
        // POS: devuelve un objeto de tipo ExtraDato obtenido de la "tabla" extras a partir del parámetro e.
        public static ExtraDato SELECTExtra(ExtraDato e)
        {
            return BD.Extras[e.Nombre];
        }

        // PRE: e != null.
        // POS: elimina de la "tabla" extras e, si e se encuentra en ella.
        public static void DELETEExtra(ExtraDato e)
        {
            BD.Extras.Remove(e);
        }

        // PRE: e != null;
        // POS: actualiza el objeto e en la "tabla" extras.
        public static void UPDATEExtra(ExtraDato e)
        {
            BD.DELETEExtra(e);
            BD.INSERTExtra(e);

        }

        #endregion
    }
}
