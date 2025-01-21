using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadio
{
    internal interface Visualizador
    {
        public int Tamahio {  get; set; }
        public List<bool> EquipoJugador { get; set; }
        public List<bool> EquipoRival {  get; set; }

        public void ImprimirPantalla();
        public void Acciones();
        public void Resultado();

    }
}
