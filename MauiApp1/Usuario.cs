using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class Usuario
    {
        private string rut = string.Empty;
        private string nombre = string.Empty;
        private string apellidoPaterno = string.Empty;
        private string apellidoMaterno = string.Empty;
        private DateTime fecha;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
