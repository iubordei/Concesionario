using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNPresupuesto
{
    public class Presupuesto
    {

        // PRE: fecha != null, cliente != null, valoraciones != null.
        // POS: persiste un nuevo presupuesto en el sistema con los valores facilitados como parámetros.
        public static void CrearPresupuesto(DateTime fecha, MD.Cliente cliente, Dictionary<MD.Vehiculo, double> valoraciones)
        {
            Persistencia.PersistenciaPresupuesto.Añadir(new MD.Presupuesto(fecha, cliente, valoraciones));
        }

        // PRE:
        // POS: marca el estado de un presupuesto como Desestimado.
        public static void DesestimarPresupuesto(MD.Presupuesto presupuesto)
        {
            if (presupuesto != null)
            {
                presupuesto.Estado = MD.Estado.Desestimado;
                Persistencia.PersistenciaPresupuesto.Modificar(presupuesto);
            }
        }

        // PRE: presupuesto != null.
        // POS: devuelve el Estado en el que se encuentra un objeto de tipo Presupuesto.
        public static MD.Estado GetEstado(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Estado);
        }

        // PRE: presupuseto != null.
        // POS: devuevlve verdadero si el presupuesto ha sido aceptado, falso en caso contrario.
        public static bool EsAceptado(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Estado.Equals(MD.Estado.Aceptado));
        }

        // PRE: presupuesto != null.
        // POS: estado = "estado" y vehiculo = "vehiculo", obtenidos del objeto de tipo Presupuesto pasado como parámetro.
        public static void GetVehiculoComprado(MD.Presupuesto presupuesto, out MD.Estado estado, out MD.Vehiculo vehiculo)
        {
            estado = presupuesto.Estado;
            vehiculo = presupuesto.Vehiculo;
        }

        // PRE: presupuesto != null.
        // POS: devuelve la fecha de la creación del presupuesto pasado como parámetro.
        public static DateTime GetFecha(MD.Presupuesto presupuesto)
        {
            return (presupuesto.FechaRealizacion);
        }

        // PRE: presupuesto != null.
        // POS: devuelve el objeto de tipo Cliente asociado al presupuesto pasado como parámetro.
        public static MD.Cliente GetCliente(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Cliente);
        }

        // PRE: presupuesto != null.
        // POS: devuelve el objeto de tipo Vehiculo asociado al presupuesto pasado como parámetro.
        public static MD.Vehiculo GetVehiculo(MD.Presupuesto presupuesto)
        {
            return (presupuesto.Vehiculo);
        }

        // PRE: cliente != null.
        // POS: devuelve una lista compuesta por objetos de tipo Presupuesto, cuyo cliente asociado sea el cliente pasado como parámetro.
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

        // PRE: vehiculo != null.
        // POS: devuelve una lista compuesta por objetos de tipo Presupuesto, cuyo vehículo asociado sea el vehículo pasado como parámetro.
        public static List<MD.Presupuesto> GetPresupuestosPorVehiculo(MD.Vehiculo vehiculo)
        {
            List<MD.Presupuesto> presupuestos = Persistencia.PersistenciaPresupuesto.GetTodos();
            List<MD.Presupuesto> solucion = new List<MD.Presupuesto>();

            foreach (MD.Presupuesto presupuesto in presupuestos)
            {
                foreach (KeyValuePair<MD.Vehiculo, double> kvp in presupuesto.Valoracion)
                {
                    if (vehiculo.Equals(kvp.Key))
                    {
                        solucion.Add(presupuesto);
                    }
                }
            }

            return (solucion);
        }

        // PRE: estado != null.
        // POS: devuelve una lista compuesta por objetos de tipo Presupuesto, cuyo estado asociado sea el estado pasado como parámetro.
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

        // PRE:
        // POS: devuelve una lista compuesta por todos los objetos de tipo Presupuesto persistidos en el sistema.
        public static List<MD.Presupuesto> GetTodosPresupuestos()
        {
            return (Persistencia.PersistenciaPresupuesto.GetTodos() != null ? Persistencia.PersistenciaPresupuesto.GetTodos() : new List<MD.Presupuesto>());
        }

        // PRE:
        // POS: actualiza el estado de los presupuestos en el caso de que hayan pasado más de 15 días si actualmente
        // POS: se encuentran en Estado "Pendiente".
        public static void ActualizarEstadoPresupuestos(List<MD.Presupuesto> presupuestos)
        {
            if (presupuestos != null)
            {
                foreach (MD.Presupuesto presupuesto in presupuestos)
                {
                    if (DateTime.Now > presupuesto.FechaRealizacion.AddDays(15) && presupuesto.Estado == MD.Estado.Pendiente)
                    {
                        presupuesto.Estado = MD.Estado.Desestimado;
                        Persistencia.PersistenciaPresupuesto.Modificar(presupuesto);
                    }
                }
            }
        }

        // PRE:
        // POS: devuelve verdad si presupuesto está en Estado "Pendiente" y se le asigna el vehículo pasado como
        // POS: parámetro como vehículo comprado, además de actualizar el Estado a "Aceptado", falso en caso contrario.
        public static bool ComprarVehiculo(MD.Presupuesto presupuesto, MD.Vehiculo vehiculo)
        {
            if (presupuesto != null && vehiculo != null)
            {
                if (presupuesto.Estado == MD.Estado.Pendiente)
                {
                    presupuesto.Vehiculo = vehiculo;
                    presupuesto.Estado = MD.Estado.Aceptado;
                    Persistencia.PersistenciaPresupuesto.Modificar(presupuesto);
                    return (true);
                }
            }
            return (false);
        }
    }
}
