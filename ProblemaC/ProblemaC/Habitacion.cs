using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaC
{
    internal class Habitacion
    {
        //Atributos
        private int idHabitacion;
        private int nPiso;
        private bool estadoHabitacion;

        //Constructores
        public Habitacion()
        {
            idHabitacion = 0;
            nPiso = 0;
            estadoHabitacion = true;
        }
        public Habitacion(int idHabitacion, int nPiso, bool estadoHabitacion)
        {
            this.idHabitacion = idHabitacion;
            this.nPiso = nPiso;
            this.estadoHabitacion = estadoHabitacion;
        }

        //Set y Get

        public int IdHabitacion
        {
            get => idHabitacion;
            set => idHabitacion = value;
        }
        public int NPiso
        {
            get => nPiso;
            set => nPiso = value;
        }
        public bool EstadoHabitacion
        {
            get => estadoHabitacion;
            set => estadoHabitacion = value;
        }

        //Metodos

        public void consultarEstado()
        {
            if (estadoHabitacion == true)
            {
                Console.WriteLine("Habitacion ocupada");
            }
            else if (estadoHabitacion == false)
            {
                Console.WriteLine("Habitacion desocupada");
            }
        }
    }
}
