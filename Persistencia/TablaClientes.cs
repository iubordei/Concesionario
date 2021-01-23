using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class TablaClientes : KeyedCollection<string, ClienteDato>
    {
        // PRE: item != null.
        // POS: devuelve una cadena que representa al objeto ClienteDato item.
        protected override string GetKeyForItem(ClienteDato item)
        {
            return item.DNI;
        }
    }
}
