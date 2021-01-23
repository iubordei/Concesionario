﻿using System;
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
        // PRE: vehiculo != null.
        // POS: añade a la BD un objeto de tipo Vehiculo.
        public static void Añadir(Vehiculo vehiculo)
        {
            BD.INSERTVehiculo(VehiculoAVehiculoDato(vehiculo));
        }

        // PRE: vehiculo != null.
        // POS: devuelve un objeto de tipo Vehiculo igual al pasado como parámetro si lo encuentra en la BD.
        public static Vehiculo Buscar(Vehiculo vehiculo)
        {
            VehiculoDato vd = VehiculoAVehiculoDato(vehiculo);
            VehiculoDato res = BD.SELECTVehiculo(vd);
            if (res != null)
            {
                return (VehiculoDatoAVehiculo(res));
            }
            else
            {
                return (null);
            }
        }

        // PRE: vehiculo != null.
        // POS: elimina el objeto vehiculo de la BD si éste existe en ella.
        public static void Eliminar(Vehiculo vehiculo)
        {
            BD.DELETEVehiculo(VehiculoAVehiculoDato(vehiculo));
        }

        // PRE: vehiculo != null.
        // POS: actualiza los atributos de vehiculo en la BD según el valor de sus atributos.
        public static void Modificar(Vehiculo vehiculo)
        {
            BD.UPDATEVehiculo(VehiculoAVehiculoDato(vehiculo));
        }

        // PRE: vehiculo != null.
        // POS: devuelve un objeto VehiculoDato cuyo contenido es equivalente al del objeto vehiculo.
        public static VehiculoDato VehiculoAVehiculoDato(Vehiculo vehiculo)
        {
            return (new VehiculoDato(vehiculo.NumeroDeBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecomendado, null, null, null));
        }

        // PRE: vDato != null.
        // POS: devuelve un objeto Vehiculo cuyo contenido es equivalente al del objeto vDato.
        public static Vehiculo VehiculoDatoAVehiculo(VehiculoDato vDato)
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
        
        // PRE: num != null.
        // POS: devuelve un objeto Vehiculo cuyo número de bastidor sea num, null si no se encuentra.
        public static Vehiculo BuscarNum(String num)
        {
            return VehiculoDatoAVehiculo(BD.SELECTVehiculoNum(num));
        }

        // PRE:
        // POS: devuelve una lista que contiene todos los vehículos almacenados en la BD.
        public static List<Vehiculo> GetAll()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            KeyedCollection<string, VehiculoDato> tabla = BD.GetAll();
            foreach (VehiculoDato vehiculoDato in tabla)
            {
                vehiculos.Add(VehiculoDatoAVehiculo(vehiculoDato));
            }
            return vehiculos;
        }

        // PRE:
        // POS: devuelve una lista de vehiculos, formada por aquellos que son de segunda mano.
        public static List<Vehiculo> GetSegundaMano()
        {
            List<Vehiculo> segundaMano = new List<Vehiculo>();
            Dictionary<string, VehiculoDato> tabla = BD.GetSegundaMano();
            foreach (KeyValuePair<string, VehiculoDato> kvp in tabla)
            {
                segundaMano.Add(VehiculoDatoAVehiculo(kvp.Value));
            }
            return segundaMano;
        }

        // PRE:
        // POS: devuelve una lista de vehiculos, formada por aquellos que son nuevos.
        public static List<Vehiculo> GetNuevos()
        {
            List<Vehiculo> nuevos = new List<Vehiculo>();
            Dictionary<string, VehiculoDato> tabla = BD.GetSegundaMano();
            foreach (KeyValuePair<string, VehiculoDato> kvp in tabla)
            {
                nuevos.Add(VehiculoDatoAVehiculo(kvp.Value));
            }
            return nuevos;
        }
    }
}