using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Telefono
    {
        private int memoria;
        private int ram;
        private double peso;
        private int megapixeles;
        private bool tieneflash;

        public Telefono()
        {
            memoria = 128 ;
            ram = 6;
            peso = 150;
            megapixeles = 150;
            tieneflash = false;
        }

        public Telefono(int memoria, int ram, double peso, int megapixeles, bool tieneflash)
        {
            this.memoria = memoria;
            this.ram = ram;
            this.peso = peso;
            this.megapixeles = megapixeles;
            this.tieneflash = tieneflash;
        }

        public int getMemoria()
        {
            return memoria;
        }
    }
}
