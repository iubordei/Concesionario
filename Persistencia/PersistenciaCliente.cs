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
        public static void Añadir(Cliente c)
        {
            BD.INSERTCliente(cambioAClienteDato(c));
        }

        public static Cliente Buscar(String dni)
        {
            return cambioACliente(BD.SELECTCliente(dni));
        }

        public static void Eliminar(Cliente c)
        {
            BD.DELETECliente(cambioAClienteDato(c));
        }

        public static void Modificar(Cliente c)
        {
            BD.UPDATECliente(cambioAClienteDato(c));
        }

        public static bool Existe(String dni)
        {
            return BD.ISCliente(dni);
        }

        public static List<Cliente> ListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            List<ClienteDato> clientesDato = BD.ALLClientes();

            foreach (ClienteDato cd in clientesDato)
            {
                clientes.Add(cambioACliente(cd));
            }

            return clientes;

        }

        private static ClienteDato cambioAClienteDato(Cliente c)
        {
            return (new ClienteDato(c.DNI, c.Nombre, c.Telefono, (CategoriaDato)c.Categoria));
        }

        private static Cliente cambioACliente(ClienteDato c)
        {
            return (new Cliente(c.DNI, c.Nombre, c.Telefono, (Categoria)c.Categoria));
        }


    }
}