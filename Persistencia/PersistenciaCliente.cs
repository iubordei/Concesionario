using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PersistenciaCliente
    {
        public static void Añadir(Cliente c)
        {
            ClienteDato c = new ClienteDato();
            BD.INSERTCliente();
        }

        public static Cliente Buscar(Cliente c)
        {

        }

        public static void Eliminar(Cliente c)
        {

        }

        public static void Modificar(Cliente c)
        {

        }
    }
}
