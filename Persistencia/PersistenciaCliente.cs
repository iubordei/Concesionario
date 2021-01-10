using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaCliente
    {
        public static void Añadir(Cliente c)
        {
            BD.INSERTCliente(cambioAClienteDato(c));
        }

        public static Cliente Buscar(Cliente c)
        {
            return (BD.SELECTCliente(cambioAClienteDato(c)));
        }

        public static void Eliminar(Cliente c)
        {
            BD.DELETECliente(cambioAClienteDato(c));
        }

        public static void Modificar(Cliente c)
        {
            BD.UPDATECliente(cambioAClienteDato(c));
        }

        private ClienteDato cambioAClienteDato(Cliente c)
        {
            return (new ClienteDato(c.DNI, c.Nombre, c.Telefono, c.Categoria));
        }
    }
}
