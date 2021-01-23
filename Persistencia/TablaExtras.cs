using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class TablaExtras : KeyedCollection<string, ExtraDato>
    {
        // PRE: item != null.
        // POS: devuelve una cadena que representa al objeto ExtraDato item.
        protected override string GetKeyForItem(ExtraDato item)
        {
            return (item.Nombre);
        }
    }
}
