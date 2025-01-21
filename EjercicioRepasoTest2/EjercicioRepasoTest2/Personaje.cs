using Galaxia.Razas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia
{
    internal class Personaje:Raza
    {
        private string nombre;

        public Personaje(string nombre, Traza razas, string colorOjos, string tipoPelo, string colorCuerpo, bool tatuaje, string habilidades, string resistencias)
            :base(razas, colorOjos, tipoPelo, colorCuerpo, tatuaje, habilidades, resistencias)
        {
            this.nombre = nombre;
        }
    }
}
