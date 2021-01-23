using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Persistencia
{
    class TablaPresupuestos : KeyedCollection<string, PresupuestoDato>
    {
        // PRE: item != null.
        // POS: devuelve una cadena que representa al objeto PresupuestoDato item.
        protected override string GetKeyForItem(PresupuestoDato item)
        {
            return (item.FechaRealizacion + " " + item.Cliente + " " + item.Vehiculo);
        }
    }
}
