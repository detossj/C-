using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medabot
{
    internal class Pierna
    {
        private int evasion;
        private int velocidad;
        private string tipoPierna;

        public int Evasion
        {
            get => evasion;
            set => evasion = value;
        }
        public int Velocidad
        {
            get => velocidad;
            set => velocidad = value;
        }

        public string TipoPierna
        {
            get => tipoPierna; 
            set => tipoPierna = value;
        }
    }
}
