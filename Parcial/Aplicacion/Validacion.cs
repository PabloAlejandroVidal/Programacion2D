using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    internal static  class Validacion
    {

        internal static bool ValidarClase(string clase)
        {
            if (clase == Pasajero.eClase.Turista.ToString())
                return true;
            if (clase == Pasajero.eClase.Premium.ToString())
                return true;
            return false;
        }

        internal static bool ValidarDni(TextBox txtDni, out int dni)
        {
            if (int.TryParse(txtDni.Text, out dni))
            {
                if (dni > 10000000)
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool ValidarNombre(string nombre)
        {
            return nombre != null;
        }
    }
}
