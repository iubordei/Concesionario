using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaExtra
    {
        // PRE: extra != null.
        // POS: añade extra a la BD.
        public static void Añadir(MD.Extra extra)
        {
            BD.INSERTExtra(extraAExtraDato(extra));
        }

        // PRE: extra != null.
        // POS: devuelve un objeto Extra si lo encuentra en la BD.
        public static MD.Extra Buscar(MD.Extra extra)
        {
            return ExtraDatoAExtra(BD.SELECTExtra(extraAExtraDato(extra)));
        }

        // PRE: extra != null.
        // POS: elimina de la BD extra si éste se encuentra en ella.
        public static void Eliminar(MD.Extra extra)
        {
            BD.DELETEExtra(extraAExtraDato(extra));
        }

        // PRE: extra != null.
        // POS: actualiza los datos de extra dentro de la BD.
        public static void Modificar(MD.Extra extra)
        {
            BD.UPDATEExtra(extraAExtraDato(extra));
        }

        // PRE: extra != null.
        // POS: devuelve un objeto Extra equivalente a partir de un objeto ExtraDato.
        public static MD.Extra ExtraDatoAExtra(ExtraDato extraDato)
        {
            return (new MD.Extra(extraDato.Nombre, extraDato.Precio));
        }

        // PRE: lista != null.
        // POS: devuelve una lista de objetos Extra, formados a partir de una lista de objetos ExtraDato,
        // POS: es decir, convierte uno a uno todos los objetos de lista a sus respectivos equivalentes de tipo Extra.
        public static List<MD.Extra> ListaExtraDatoAListaExtra(List<ExtraDato> lista)
        {
            List<MD.Extra> extras = new List<MD.Extra>();
            foreach (ExtraDato extraDato in lista)
            {
                extras.Add(ExtraDatoAExtra(extraDato));
            }

            return (extras);
        }

        // PRE: extra != null.
        // POS: devuelve un objeto ExtraDato equivalente al objeto de tipo Extra extra.
        private static ExtraDato extraAExtraDato(MD.Extra extra)
        {
            return (new ExtraDato(extra.Nombre, extra.Precio));
        }

        // PRE: lista != null.
        // POS: devuelve una lista de objetos ExtraDato, formados a partir de una lista de objetos Extra,
        // POS: es decir, convierte uno a uno todos los objetos de lista a sus respectivos equivalentes de tipo ExtraDato.
        private static List<ExtraDato> listaExtraAListaExtraDato(List<MD.Extra> lista)
        {
            List<ExtraDato> extras = new List<ExtraDato>();
            foreach (MD.Extra extra in lista)
            {
                extras.Add(extraAExtraDato(extra));
            }

            return (extras);
        }
    }
}
