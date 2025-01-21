using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaE
{
    internal class Trabajador
    {
        //Atributos
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaNacimiento;
        private string departamento;
        private string cargo;

        //Constructores
        public Trabajador()
        {
            nombre = string.Empty;
            apellidoPaterno = string.Empty;
            apellidoMaterno = string.Empty;
            fechaNacimiento = DateTime.MinValue;
            departamento = string.Empty;
            cargo = string.Empty;

        }
        public Trabajador(string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string departamento, string cargo)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.fechaNacimiento = fechaNacimiento;
            this.departamento = departamento;
            this.cargo = cargo;
        }

        // Set y Get

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string ApellidoPaterno
        {
            get => apellidoPaterno;
            set => apellidoPaterno = value;
        }

        public string ApellidoMaterno
        {
            get => apellidoMaterno; 
            set => apellidoMaterno = value;
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento; 
            set => fechaNacimiento = value;
        }

        public string Departamento
        {
            get => departamento;
            set => departamento = value;
        }

        public string Cargo
        {
            get => cargo; 
            set => cargo = value;
        }

        // Metodos

        public void CalcularEdad()
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            Console.WriteLine($"Edad : {edad}");
        }
    }
}
