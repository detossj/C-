using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medabot
{
    internal class Pieza
    {
        private string nombre;
        private string especialidad;
        private int hpMax;
        private int hpActual;
        private int armadura;

        public Pieza()
        {
            this.nombre = string.Empty;
            this.especialidad = string.Empty;
            this.hpMax = 0;
            this.hpActual = 0;
            this.armadura = 0;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getEspecialidad()
        {
            return this.especialidad;
        }
        public int getHpMax()
        {
            return this.hpMax;
        }
        public int getHpActual()
        {
            return this.hpActual;
        }
        public int getArmadura()
        {
            return this.armadura;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEspecialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
        public void setHpMax(int hpMax)
        {
            this.hpMax = hpMax;
        }
        public void setHpActual(int hpActual)
        {
            this.hpActual = hpActual;
        }
        public void setArmadura(int armadura)
        {
            this.armadura = armadura;
        }
    }
}
