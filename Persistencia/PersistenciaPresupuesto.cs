using System;
using System.Collections.Generic;
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
                return (new MD.Presupuesto(res.FechaRealizacion, res.Cliente, res.Vehiculo));
            } else
            {
                return (null);
            }
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
            return (new PresupuestoDato(p.FechaRealizacion, p.Cliente.DNI, p.Vehiculo.NumBastidor, p.Estado.ToString(), p.Valoracion));
        }
    }
}
