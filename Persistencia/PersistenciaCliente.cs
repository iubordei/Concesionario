using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaCliente
    {
        // PRE: c != null.
        // POS: inserta en la BD un objeto de tipo Cliente.
        public static void Añadir(Cliente c)
        {
            if (BD.Clientes != null)
                BD.INSERTCliente(CambioAClienteDato(c));
        }

        // PRE: dni != null.
        // POS: devuelve un objeto Cliente cuyo dni sea igual al parámetro dni pasado.
        public static Cliente Buscar(String dni)
        {
            if (BD.Clientes == null)
                return null;
            return CambioACliente(BD.SELECTCliente(dni));
        }

        // PRE: c != null.
        // POS: elimina de la BD al cliente c si éste existe en ella.
        public static void Eliminar(Cliente c)
        {
            if (BD.Clientes != null)
                BD.DELETECliente(CambioAClienteDato(c));
        }

        // PRE: c != null.
        // POS: actualiza la información contenida en la BD del Cliente c.
        public static void Modificar(Cliente c)
        {
            if (BD.Clientes != null)
                BD.UPDATECliente(CambioAClienteDato(c));
        }

        // PRE: dni != null.
        // POS: devuelve TRUE si dentro de la BD hay un objeto Cliente cuyo DNI = "dni", FALSE en caso contrario.
        public static bool Existe(String dni)
        {
            return BD.contieneDNI(dni);
        }

        // PRE:
        // POS: devuelve una lista con todos los clientes almacenados en la BD.
        public static List<Cliente> ListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            List<ClienteDato> clientesDato = BD.ALLClientes();

            foreach (ClienteDato cd in clientesDato)
            {
                clientes.Add(CambioACliente(cd));
            }

            return clientes;

        }

        // PRE: c != null.
        // POS: devuelve un objeto de tipo ClienteDato a partir del objeto Cliente c.
        public static ClienteDato CambioAClienteDato(Cliente c)
        {
            if (c == null)
            {
                return (null);
            }
            else
            {
                return (new ClienteDato(c.DNI, c.Nombre, c.Telefono, (CategoriaDato)c.Categoria));
            }
        }

        // PRE: c != null.
        // POS: devuelve un objeto de tipo Cliente a partir del objeto ClienteDato c.
        public static Cliente CambioACliente(ClienteDato c)
        {
            if (c == null)
            {
                return (null);
            }
            else
            {
                return (new Cliente(c.DNI, c.Nombre, c.Telefono, (Categoria)c.Categoria));
            }
        }


    }
}