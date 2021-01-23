using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Persistencia
{
    class TablaVehiculos : KeyedCollection<string, VehiculoDato>
    {
        // PRE: item != null.
        // POS: devuelve una cadena que representa al objeto VehiculoDato item.
        protected override string GetKeyForItem(VehiculoDato item)
        {
            return item.NumeroDeBastidor;
        }
    }
}

