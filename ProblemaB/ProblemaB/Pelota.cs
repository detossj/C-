using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaB
{
    internal class Pelota
    {
        //Atributos
        private double radio;
        private string color;
        private string textura;
        private bool transparencia;

        //Constructores

        public Pelota()
        {
            radio = 0;
        }

        public Pelota(double radio, string color, string textura, bool transparencia)
        {
            this.radio = radio;
            this.color = color;
            this.textura = textura;
            Transparencia = transparencia;
        }

        //Set y Get

        public double Radio
        {
            get => radio;
            set => radio = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }
        public string Textura
        {
            get => textura; 
            set => textura = value;
        }

        public bool Transparencia
        {
            get => transparencia; 
            set => transparencia = value;
        }


    }
}
