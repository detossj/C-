using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaA
{
    internal class Triangulo
    {
        //Atributos
        private double _base;
        private double _altura;

        //Constructores
        public Triangulo()
        {
            _base = 0;
            _altura = 0;
        }

        public Triangulo(double altura,double basee)
        {
            _base = basee;
            _altura = altura;
        }

        // Set y Get

        public double Base
        {
            get => _base;
            set => _base = value;
        }

        public double Altura
        {
            get => _altura;
            set => _altura = value;
        }

        //Metodos

        public double CalcularArea()
        {
            return (_altura * _base)/2;
        }


    }
}
