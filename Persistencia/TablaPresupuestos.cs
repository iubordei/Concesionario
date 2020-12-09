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
        protected override string GetKeyForItem(PresupuestoDato item)
        {
            return (item.FechaRealizacion + " " + item.Cliente + " " + item.Vehiculo);
        }
    }
}
