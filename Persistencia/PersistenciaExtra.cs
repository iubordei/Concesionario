using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaExtra
    {
        public static void Añadir(MD.Extra extra)
        {
            BD.INSERTExtra(extraAExtraDato(extra));
        }

        public static MD.Extra Buscar(MD.Extra extra)
        {
            return ExtraDatoAExtra(BD.SELECTExtra(extraAExtraDato(extra)));
        }

        public static void Eliminar(MD.Extra extra)
        {
            BD.DELETEExtra(extraAExtraDato(extra));
        }

        public static void Modificar(MD.Extra extra)
        {
            BD.UPDATEExtra(extraAExtraDato(extra));
        }

        public static MD.Extra ExtraDatoAExtra(ExtraDato extraDato)
        {
            return (new MD.Extra(extraDato.Nombre, extraDato.Precio));
        }

        public static List<MD.Extra> ListaExtraDatoAListaExtra(List<ExtraDato> lista)
        {
            List<MD.Extra> extras = new List<MD.Extra>();
            foreach (ExtraDato extraDato in lista)
            {
                extras.Add(ExtraDatoAExtra(extraDato));
            }

            return (extras);
        }

        private static ExtraDato extraAExtraDato(MD.Extra extra)
        {
            return (new ExtraDato(extra.Nombre, extra.Precio));
        }

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
