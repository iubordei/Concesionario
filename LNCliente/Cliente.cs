using Persistencia;
using MD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LNCliente
{
    public class LNCliente
    {

        public bool AltaCliente(MD.Cliente cliente)
        // PRE: 
        // POS: devuelve TRUE si cliente se ha añadido a la base de datos, 
        //FALSE si ya estaba en la base de datos o era nulo.
        {
            if (cliente != null && !PersistenciaCliente.Existe(cliente.DNI))
            {
                PersistenciaCliente.Añadir(cliente);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaCliente(Cliente cliente)
        // PRE: 
        // POS: devuelve TRUE si cliente se ha eliminado de la base de datos, 
        //FALSE si no estaba en la base de datos o era nulo.
        {
            if (cliente != null && PersistenciaCliente.Existe(cliente.DNI))
            {
                PersistenciaCliente.Eliminar(cliente);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfoCliente(string dni)
        // PRE:
        // POS: devuelve una cadena que contiene la información relativa al dni del cliente introducido. 
        //Devuelve cadena vacía si no hay ningún cliente agregado con ese dni.
        {
            if (dni != null && PersistenciaCliente.Existe(dni))
            {
                Cliente c = PersistenciaCliente.Buscar(dni);
                return c.ToString();
            }
            else
            {
                return "";
            }
        }

        public List<Presupuesto> VerPresupuestos(Cliente cliente)
        // PRE: 
        // POS: devuelve una lista que contiene todos los elementos de tipo Presupuesto relacionados con cliente. 
        //Devuelve una lista vacía si el cliente no existe o es nulo o no tiene presupuestos válidos (dentro del plazo de 15 días) a su nombre.
        {

        }
        public List<Presupuesto> VerCompras(Cliente cliente)
        // PRE:
        // POS: devuelve una lista que contiene los presupuestos que han sido aceptados y el vehículo asociado al presupuesto ha sido comprado. 
        //Devuelve una lista vacía si cliente no existe o es nulo.
        {

        }

        public List<Cliente> verClientes()
        // PRE:
        // POS: devuelve una lista que contiene todos los elementos cliente del concesionario.
        {
            return PersistenciaCliente.ListaClientes();
        }

        public List<Cliente> verClientesPorCategoria(Categoria categoria)
        // PRE:
        // POS: devuelve una lista que contiene todos los elementos cliente del concesionario cuya Categoria sea categoria. 
        //Devuelve una lista vacía si categoria es nula o no existe.
        {
            List<Cliente> clientes = PersistenciaCliente.ListaClientes();
            List<Cliente> clientesCategoria = new List<Cliente>();

            foreach (Cliente c in clientes)
            {
                if (c.Categoria == categoria)
                {
                    clientesCategoria.Add(c);
                }
            }

            return clientesCategoria;
        }

        public bool ModificarTipoCliente(Cliente cliente, Categoria categoria)
        // PRE: 
        // POS: devuelve TRUE si se ha modificado la categoria de cliente, 
        //FALSE si la categoria que se intenta poner es la misma que la que tiene o si cliente o categoria son nulos o no existen.
        {
            if (cliente != null && PersistenciaCliente.Existe(cliente.DNI))
            {
                Cliente c = new Cliente(cliente.Nombre, cliente.DNI, cliente.Telefono, categoria);
                PersistenciaCliente.Modificar(cliente);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}