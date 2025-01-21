using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Plato : Mesero
    {
        //Atributos
        private int id;
        private string platoPrincipal;
        private string postre;
        private string bebida;
        private DateTime fechaOrden;
        private int precio;
        private int numeroMesa;

        public string PlatoPrincipal
        {
            get => platoPrincipal;
            set => platoPrincipal = value;
        }

        public int NumeroMesa
        {
            get => numeroMesa;
            set => numeroMesa = value;
        }

        public int Precio
        {
            get => precio;
            set => precio = value;
        }

        //Constructores

        public Plato()
        {
            fechaOrden = DateTime.Now;
            numeroMesa = 1;
        }


    }
}
