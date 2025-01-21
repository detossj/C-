using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia
{

    namespace Transportes
    {
        internal class VehiculoTerrestre
        {
            private List<Rueda> ruedas;
            private List<Volante> volantes;
            private double velocidad;
            private double velocidadMaxima;
            private double aceleracion;
        
            public VehiculoTerrestre(List<Rueda> ruedas, List<Volante> volantes, double velocidad, double velocidadMaxima, double aceleracion)
            {
                this.ruedas = ruedas;
                this.volantes = volantes;
                this.velocidad = velocidad;
                this.velocidadMaxima = velocidadMaxima;
                this.aceleracion = aceleracion;
            }
        }
    }

}