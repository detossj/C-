using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Triangulo
    {
        private double basee;
        private double altura;

        public Triangulo()
        {
            basee = 0;
            altura = 0;
        }
        public Triangulo(double basee, double altura)
        {
            this.basee = basee;
            this.altura = altura;
        }

        public double Basee
        {
            get => basee;
            set => basee = value;
        }

        public double Altura
        {
            get => Altura;
            set => Altura = value;
        }

        public double CalcularArea()
        {
            return (basee * altura) / 2;
        }



    }
}