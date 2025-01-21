using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum Sexo
    {
        Masculino,
        Femenino,
        Otro
    }


    public class Mesero
    {
        private int rut;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private Sexo sexo;
        private double propina;

        public double Propina
        {
            get => propina;
            set => propina = value;
        }

        public Mesero()
        {
            propina = 0;
        }

        public void AgregarPropina(int precioOrden, double porcentajePropina)
        {
            Propina = precioOrden * porcentajePropina;
        }
        public double ObtenerPropina()
        {
            return propina;
        }

    }
}
