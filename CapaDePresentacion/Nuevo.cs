using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Nuevo : UserControl
    {
        // PRE: 
        // POS: crea un control de usuario de tipo "Nuevo".
        public Nuevo()
        {
            InitializeComponent();
            lbExtras.Enabled = true;
        }

        // PRE: extras tiene que ser != null
        // POS: crea un control de usuario de tipo "Nuevo".
        public Nuevo(List<MD.Extra> extras)
        {
            InitializeComponent();
            for (int i = 0; i < lbExtras.Items.Count; i++)
            {
                foreach (MD.Extra extra in extras)
                {
                    if (lbExtras.Items[i].ToString() == extra.Nombre)
                    {
                        lbExtras.SetSelected(i, true);
                    }
                }
                
            }
            lbExtras.Enabled = false;
        }

        // PRE: 
        // POS: return true si todos los controles del control son validos (estan rellenados)
        public bool isValido()
        {
            ListBox.SelectedObjectCollection selectedItems = lbExtras.SelectedItems;
            return selectedItems != null;
        }

        // PRE:
        // POS: devuelve en una lista los extras seleccionados.
        public List<MD.Extra> getExtras()
        {
            ListBox.SelectedObjectCollection selectedItems = lbExtras.SelectedItems;
            List<MD.Extra> extras = new List<MD.Extra>();
            float valor = 10;
  
            for(int i = 0; i < selectedItems.Count; i++) { 

                for(int j = 0; j < lbExtras.Items.Count; j++)
                {
                    if (lbExtras.Items[j].ToString().Equals(selectedItems[i].ToString()))
                    {
                        MD.Extra extra = new MD.Extra(lbExtras.Items[j].ToString(), j * 2);
                        extras.Add(extra);
                    }
                }
                valor++;
            }
            return extras;
        }

    }
}
