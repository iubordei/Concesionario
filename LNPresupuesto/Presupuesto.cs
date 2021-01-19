using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNPresupuesto
{
    public class Presupuesto
    {

        // PRE:
        // POS:
        public static MD.Presupuesto CrearPresupuesto(DateTime fecha, MD.Cliente cliente, MD.Vehiculo vehiculo)
        {
            return (new MD.Presupuesto(fecha, cliente, vehiculo));
        }

        // PRE:
        // POS:
        public static MD.Estado GetEstado(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Estado);
        }

        // PRE:
        // POS:
        public static void GetVehiculoComprado(MD.Presupuesto presupuesto, out MD.Estado estado, out MD.Vehiculo vehiculo)
        {
            estado = presupuesto.Estado;
            vehiculo = presupuesto.Vehiculo;
        }

        // PRE:
        // POS:
        public static DateTime GetFecha(MD.Presupuesto presupuesto)
        {
            return (presupuesto.FechaRealizacion);
        }

        // PRE:
        // POS:
        public static MD.Cliente GetCliente(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Cliente);
        }

        // PRE:
        // POS:
        public static MD.Vehiculo GetVehiculo(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Vehiculo);
        }

        // PRE:
        // POS:
        public static List<MD.Presupuesto> GetPresupuestosPorCliente(MD.Cliente cliente)
        {
            List<MD.Presupuesto> presupuestos = Persistencia.PersistenciaPresupuesto.GetTodos();
            List<MD.Presupuesto> solucion = new List<MD.Presupuesto>();

            foreach (MD.Presupuesto presupuesto in presupuestos)
            {
                if (presupuesto.Cliente.Equals(cliente))
                {
                    solucion.Add(presupuesto);
                }
            }

            return (solucion);
        }

        // PRE:
        // POS:
        public static List<MD.Presupuesto> GetPresupuestosPorVehiculo(MD.Vehiculo vehiculo)
        {
            List<MD.Presupuesto> presupuestos = Persistencia.PersistenciaPresupuesto.GetTodos();
            List<MD.Presupuesto> solucion = new List<MD.Presupuesto>();

            foreach (MD.Presupuesto presupuesto in presupuestos)
            {
                if (presupuesto.Vehiculo.Equals(vehiculo))
                {
                    solucion.Add(presupuesto);
                }
            }

            return (solucion);
        }

        // PRE:
        // POS:
        public static List<MD.Presupuesto> GetPresupuestosPorEstado(MD.Estado estado)
        {
            List<MD.Presupuesto> presupuestos = Persistencia.PersistenciaPresupuesto.GetTodos();
            List<MD.Presupuesto> solucion = new List<MD.Presupuesto>();

            foreach (MD.Presupuesto presupuesto in presupuestos)
            {
                if (presupuesto.Estado.Equals(estado))
                {
                    solucion.Add(presupuesto);
                }
            }

            return (solucion);
        }
    }
}
