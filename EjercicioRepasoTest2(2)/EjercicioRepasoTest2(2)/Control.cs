using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadio
{
    internal class Control : Visualizador
    {
        private int tamahio;
        private List<bool> equipoJugador;
        private List<bool> equipoRival;

        public Control()
        {
            this.tamahio = 0;

        }

        public int Tamahio
        {
            get => tamahio; 
            set => tamahio = value;
        }

        public List<bool> EquipoJugador
        {
            get => equipoJugador;
            set => equipoJugador = value;
        }

        public List<bool> EquipoRival
        {
            get => equipoRival;
            set => equipoRival = value;
        }

        public void ImprimirPantalla()
        {

        }
        public void Acciones()
        {

        }
        public void Resultado()
        {

        }
    }
}
