using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD;

namespace Persistencia
{
    public class PersistenciaVehiculo
    {
        //Pre: … 
        //Post: …
        public static void Añadir(Vehiculo vehiculo)
        {
            BD.INSERTVehiculo(vehiculoAvehiculoDato(vehiculo));
        }
        //Pre: … 
        //Post: …
        public static Vehiculo Buscar(Vehiculo vehiculo)
        {
            VehiculoDato vd = vehiculoAvehiculoDato(vehiculo);
            VehiculoDato res = BD.SELECTVehiculo(vd);
            if (res != null)
            {
                return (vehiculoDatoAVehiculo(res));
            }
            else
            {
                return (null);
            }
        }

        public static void Eliminar(Vehiculo vehiculo)
        {
            BD.DELETEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        public static void Modificar(Vehiculo vehiculo)
        {
            BD.UPDATEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        private static VehiculoDato vehiculoAvehiculoDato(Vehiculo vehiculo)
        {
            return (new VehiculoDato(vehiculo.NumeroDeBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecomendado, null, null, null));
        }

        private static Vehiculo vehiculoDatoAVehiculo(VehiculoDato vDato)
        {
            if (vDato.Matricula == null)
            {
                return (new MD.Nuevo(vDato.NumeroDeBastidor, vDato.Marca, vDato.Modelo, vDato.Potencia, vDato.Año, vDato.PrecioRecomendado, PersistenciaExtra.ListaExtraDatoAListaExtra(vDato.Extras), vDato.Iva));
            }
            else
            {
                return (new MD.SegundaMano(vDato.NumeroDeBastidor, vDato.Marca, vDato.Modelo, vDato.Potencia, vDato.Año, vDato.PrecioRecomendado, vDato.Matricula, vDato.FechaMatriculacion, vDato.Iva));
            }
        }

        public static Vehiculo BuscarNum(String num)
        {
            return vehiculoDatoAVehiculo(BD.SELECTVehiculoNum(num));
        }

        public static List<Vehiculo> GetAll()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            KeyedCollection<string, VehiculoDato> tabla = BD.GetAll();
            foreach (VehiculoDato vehiculoDato in tabla)
            {
                vehiculos.Add(vehiculoDatoAVehiculo(vehiculoDato));
            }
            return vehiculos;
        }

        public static List<Vehiculo> GetSegundaMano()
        {
            List<Vehiculo> segundaMano = new List<Vehiculo>();
            Dictionary<string, VehiculoDato> tabla = BD.GetSegundaMano();
            foreach (KeyValuePair<string, VehiculoDato> kvp in tabla)
            {
                segundaMano.Add(vehiculoDatoAVehiculo(kvp.Value));
            }
            return segundaMano;
        }

        public static List<Vehiculo> GetNuevos()
        {
            List<Vehiculo> nuevos = new List<Vehiculo>();
            Dictionary<string, VehiculoDato> tabla = BD.GetSegundaMano();
            foreach (KeyValuePair<string, VehiculoDato> kvp in tabla)
            {
                nuevos.Add(vehiculoDatoAVehiculo(kvp.Value));
            }
            return nuevos;
        }
    }
}