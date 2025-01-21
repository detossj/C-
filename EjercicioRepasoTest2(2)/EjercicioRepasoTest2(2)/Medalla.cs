using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medabot
{
    internal class Medalla
    {
        private string nombre;
        private string especialidad;
        private int nivel;
        private int experiencia;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Especialidad
        {
            get => especialidad; 
            set => especialidad = value;
        }   
        public int Nivel
        {
            get => nivel; 
            set => nivel = value;
        }
        public int Experiencia
        {
            get => experiencia;
            set => experiencia = value;
        }
    }
}
