﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Persistencia
{
    class TablaVehiculos : KeyedCollection<string, VehiculoDato>
    {
        protected override string GetKeyForItem(VehiculoDato item)
        {
            return item.NumeroDeBastidor;
        }
    }
}

