using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2repaso
{
    internal class Mueble
    {

        //Atributos

        private int patas;
        private string color;
        private string forma;

        //Constructores

        public Mueble()
        {

        }
        public Mueble(int patas, string color, string forma)
        {
            this.patas = patas;
            this.color = color;
            this.forma = forma;
        }

        //set y get

        public int Patas
        {
            get => patas;
            set => patas = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        // Metodos

        public string ObtenerColor()
        {
            return Color;
        }
    }

    internal class Mesa : Mueble
    {
        public string basee;
    }
}
