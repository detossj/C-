using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadio
{
    public enum Tterreno
    {
        desierto,
        pradera,
        nieve,
        bosque,
        ciudad,
        volcan
    }
    internal class CampoBatalla
    {
        private Tterreno terreno;
        private List<string> peleadores;
        private double tiempoMax;

        public CampoBatalla(Tterreno terreno, List<string> peleadores, double tiempoMax)
        {
            this.terreno = terreno;
            this.peleadores = peleadores;
            this.tiempoMax = tiempoMax;
        }

        public void fijarTerreno(Tterreno terreno)
        {
            this.terreno = terreno;

        }

        public void addPeleadores(string peleador)
        {
            if(!peleadores.Contains(peleador))
            {
                this.peleadores.Add(peleador);
            }
        }

        public void setTiempo(double tiempoMax)
        {
            if(tiempoMax > 0)
            {
                this.tiempoMax = tiempoMax;
            }
        }

        public Tterreno getTerreno()
        {
            return this.terreno;
        }

        public int cantPeleadores()
        {
            return peleadores.Count();
        }

        public string getPeleador(int i)
        {
            return (string)peleadores[i];
        }

        public double getTiempo()
        {
            return this.tiempoMax;
        }

      
    }
}
