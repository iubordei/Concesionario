using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PersistenciaPresupuesto
    {
        public static void Añadir(Presupuesto p)
        {
            BD.INSERTPresupuesto(presupuestoAPresupuestoDato(p));
        }

        public static Presupuesto Buscar(Presupuesto p)
        {
            return (BD.SELECTPresupuesto(presupuestoAPresupuestoDato(p)));
        } 

        public static void Eliminar(Presupuesto p)
        {
            BD.DELETEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        public static void Modificar(Presupuesto p)
        {
            BD.UPDATEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        private PresupuestoDato presupuestoAPresupuestoDato(Presupuesto p)
        {
            return (new PresupuestoDato(p.fecha, p.Cliente.DNI, p.Vehiculo.NumBastidor, p.estado, p.valoracion));
        }
    }
}
