using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia
{

    namespace Transportes
    {
        internal class VehiculosEspaciales
        {
            private double velocidadMaximaCurvatura;
            private int cantidadPasajerosMaxima;
            private int cantidadEspaciosComunes;
            private int cantidadCamarotes;

            public VehiculosEspaciales(double velocidadMaximaCurvatura, int cantidadPasajerosMaxima, int cantidadEspaciosComunes, int cantidadCamarotes)
            {
                this.velocidadMaximaCurvatura = velocidadMaximaCurvatura;
                this.cantidadPasajerosMaxima = cantidadPasajerosMaxima;
                this.cantidadEspaciosComunes = cantidadEspaciosComunes;
                this.cantidadCamarotes = cantidadCamarotes;
            }
        }
    }
}
