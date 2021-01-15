using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaPresupuesto
    {
        public static void Añadir(MD.Presupuesto p)
        {
            BD.INSERTPresupuesto(presupuestoAPresupuestoDato(p));
        }

        public static MD.Presupuesto Buscar(MD.Presupuesto p)
        {
            PresupuestoDato pd = presupuestoAPresupuestoDato(p);
            PresupuestoDato res = BD.SELECTPresupuesto(pd);
            if (res != null)
            {
                return (new MD.Presupuesto(res.FechaRealizacion, Persistencia.PersistenciaCliente.Buscar(res.Cliente), Persistencia.PersistenciaVehiculo.Buscar(res.Vehiculo)));
            } else
            {
                return (null);
            }
        } 

        public static List<MD.Presupuesto> GetTodos()
        {
            List<MD.Presupuesto> presupuestos = new List<MD.Presupuesto>();
            KeyedCollection<string, PresupuestoDato> tabla = BD.GetPresupuestos();
            foreach (PresupuestoDato pDato in tabla)
            {
                presupuestos.Add(presupuestoDatoAPresupuesto(pDato));
            }

            return (presupuestos);
        }

        public static void Eliminar(MD.Presupuesto p)
        {
            BD.DELETEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        public static void Modificar(MD.Presupuesto p)
        {
            BD.UPDATEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        private static PresupuestoDato presupuestoAPresupuestoDato(MD.Presupuesto p)
        {
            return (new PresupuestoDato(p.FechaRealizacion, p.Cliente.DNI, p.Vehiculo.NumeroDeBastidor, p.Estado.ToString(), p.Valoracion));
        }

        private static MD.Presupuesto presupuestoDatoAPresupuesto(PresupuestoDato pDato)
        {
            return (new MD.Presupuesto(pDato.FechaRealizacion, Persistencia.PersistenciaCliente.Buscar(pDato.Cliente), Persistencia.PersistenciaVehiculo.Buscar(pDato.Vehiculo)));
        }
    }
}
