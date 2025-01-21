using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario user1 = new Usuario();
            user1.nombre = "Carlos";
        }
    }

    public class Usuario
    {
        public string nombre;
        public string contrasena;
        public string email;

        public void IniciarSesion()
        {
            Console.WriteLine($"El usuario {nombre} acaba de iniciar sesion");
        }
        public void CerrarSesion()
        {
            Console.WriteLine($"El usuario {nombre} acaba de cerrar sesion");
        }
        public void CambiarConstrasena()
        {
            Console.WriteLine($"El usuario {nombre} acaba de cambiar su contraseña");
        }
    }
}
