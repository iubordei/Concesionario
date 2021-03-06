﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaPresupuesto
    {
        // PRE: p != null.
        // POS: inserta en la BD un objeto de tipo MD.Presupuesto.
        public static void Añadir(MD.Presupuesto p)
        {
            if (BD.Presupuestos != null)
                BD.INSERTPresupuesto(presupuestoAPresupuestoDato(p));
        }

        // PRE: p != null.
        // POS: devuelve un objeto de tipo MD.Presupuesto si p es encontrado en la BD, null en caso contrario.
        public static MD.Presupuesto Buscar(MD.Presupuesto p)
        {
            if (BD.Presupuestos != null)
            {
                PresupuestoDato pd = presupuestoAPresupuestoDato(p);
                PresupuestoDato res = BD.SELECTPresupuesto(pd);
                if (res != null)
                {
                    Dictionary<MD.Vehiculo, double> valoraciones = new Dictionary<MD.Vehiculo, double>();
                    foreach (KeyValuePair<VehiculoDato, double> kvp in res.Valoraciones)
                    {
                        valoraciones.Add(PersistenciaVehiculo.VehiculoDatoAVehiculo(kvp.Key), kvp.Value);
                    }
                    return (new MD.Presupuesto(res.FechaRealizacion, Persistencia.PersistenciaCliente.CambioACliente(res.Cliente), valoraciones));
                }
                else
                {
                    return (null);
                }
            }
            else
            {
                return (null);
            }
        }

        // PRE:
        // POS: devuelve una lista de MD.Presupuesto con todos los presupuestos almacenados en la BD.
        public static List<MD.Presupuesto> GetTodos()
        {
            if (BD.Presupuestos == null)
                return null;

            List<MD.Presupuesto> presupuestos = new List<MD.Presupuesto>();
            KeyedCollection<string, PresupuestoDato> tabla = BD.GetPresupuestos();
            foreach (PresupuestoDato presupuestoDato in tabla)
            {
                presupuestos.Add(presupuestoDatoAPresupuesto(presupuestoDato));
            }
            return presupuestos;
        }

        // PRE: p != null.
        // POS: elimina de la BD el objeto p si éste existe en ella.
        public static void Eliminar(MD.Presupuesto p)
        {
            if (BD.Presupuestos != null)
                BD.DELETEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        // PRE: p != null.
        // POS: actualiza en la BD el objeto p.
        public static void Modificar(MD.Presupuesto p)
        {
            if (BD.Presupuestos != null)
                BD.UPDATEPresupuesto(presupuestoAPresupuestoDato(p));
        }

        // PRE: p != null.
        // POS: devuelve un objeto de tipo PresupuestoDato, creado a partir de un objeto de tipo MD.Presupuesto.
        private static PresupuestoDato presupuestoAPresupuestoDato(MD.Presupuesto p)
        {
            Dictionary<VehiculoDato, double> valoraciones = new Dictionary<VehiculoDato, double>();
            foreach (KeyValuePair<MD.Vehiculo, double> kvp in p.Valoracion)
            {
                valoraciones.Add(PersistenciaVehiculo.VehiculoAVehiculoDato(kvp.Key), kvp.Value);
            }

            EstadoDato estado = EstadoDato.Pendiente;
            switch (p.Estado)
            {
                case MD.Estado.Aceptado:
                    estado = EstadoDato.Aceptado;
                    break;
                case MD.Estado.Desestimado:
                    estado = EstadoDato.Desestimado;
                    break;
            }

            return (new PresupuestoDato(p.FechaRealizacion, Persistencia.PersistenciaCliente.CambioAClienteDato(p.Cliente), Persistencia.PersistenciaVehiculo.VehiculoAVehiculoDato(p.Vehiculo), estado, valoraciones));
        }

        // PRE: p != null.
        // POS: devuelve un objeto de tipo MD.Presupuesto, creado a partir de un objeto de tipo PresupuestoDato.
        private static MD.Presupuesto presupuestoDatoAPresupuesto(PresupuestoDato pDato)
        {
            Dictionary<MD.Vehiculo, double> valoraciones = new Dictionary<MD.Vehiculo, double>();
            foreach (KeyValuePair<VehiculoDato, double> kvp in pDato.Valoraciones)
            {
                valoraciones.Add(PersistenciaVehiculo.VehiculoDatoAVehiculo(kvp.Key), kvp.Value);
            }

            MD.Estado estado = MD.Estado.Pendiente;

            switch (pDato.Estado)
            {
                case EstadoDato.Aceptado:
                    estado = MD.Estado.Aceptado;
                    break;
                case EstadoDato.Desestimado:
                    estado = MD.Estado.Desestimado;
                    break;
            }

            MD.Presupuesto presupuesto = new MD.Presupuesto(pDato.FechaRealizacion, Persistencia.PersistenciaCliente.CambioACliente(pDato.Cliente), valoraciones);
            presupuesto.Vehiculo = Persistencia.PersistenciaVehiculo.VehiculoDatoAVehiculo(pDato.Vehiculo);
            presupuesto.Estado = estado;
            return (presupuesto);
        }
    }
}
