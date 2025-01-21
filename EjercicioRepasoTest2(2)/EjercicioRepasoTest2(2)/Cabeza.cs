using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medabot
{
    internal class Cabeza:Pieza
    {
        private string habilidad;
        private int numeroUsos;

        public Cabeza()
        {
            this.habilidad = string.Empty;
            this.numeroUsos = 0;
        }

        public string getHabilidad()
        {
            return this.habilidad;
        }
        public int getNumeroUsos()
        {
            return this.numeroUsos;
        }
        public void setHabilidad(string habilidad)
        {
            this.habilidad = habilidad;
        }
        public void setNumeroUsos(int numeroUsos)
        {
            this.numeroUsos = numeroUsos;
        }

        
        
        
    }
}
