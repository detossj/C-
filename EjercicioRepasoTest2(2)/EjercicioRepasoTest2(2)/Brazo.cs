using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medabot
{
    internal class Brazo:Pieza
    {
        private bool horientacion;
        private int exito;
        private int potencia;

        public bool getHorientacion()
        {
            return this.horientacion;
        }
        public int getExito()
        {
            return this.exito;
        }

        public int getPotencia()
        { 
            return this.potencia; 
        }

        public void setHorientacion(bool horientacion)
        {
            this.horientacion = horientacion;
        }
        public void setExito(int exito)
        {
            this.exito = exito;
        }

        public void setPotencia(int potencia)
        {
            this.potencia = potencia;
        }


    }
}
