using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class BD
    {
        private static TablaPresupuestos presupuestos;
        
        private BD() { }
        
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

        public static PresupuestoDato SELECTPresupuesto(string clave)
        {
            return BD.Presupuestos[clave];
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
    }
}
