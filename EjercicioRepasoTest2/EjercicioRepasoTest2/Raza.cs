using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia
{
    namespace Razas
    {
        public enum Traza
        {
            humanos,
            orcosEspaciales,
            elfosEspaciales,
            enanosEspaciales,
            medianosEspeciales
        }
        internal class Raza
        {
            private Traza razas;
            private string colorOjos;
            private string tipoPelo;
            private string colorCuerpo;
            private bool tatuaje;
            private string habilidades;
            private string resistencias;

            public Raza(Traza razas, string colorOjos, string tipoPelo, string colorCuerpo, bool tatuaje, string habilidades, string resistencias)
            {
                this.razas = razas;
                this.colorOjos = colorOjos;
                this.tipoPelo = tipoPelo;
                this.colorCuerpo = colorCuerpo;
                this.tatuaje = tatuaje;
                this.habilidades = habilidades;
                this.resistencias = resistencias;
            }

            public Traza Razas
            {
                get => razas;
                set => razas = value;
            }

            public string ColorOjos
            {
                get => colorOjos;
                set => colorOjos = value;
            }

            public string TipoPelo
            {
                get => tipoPelo; 
                set => tipoPelo = value;
            }
            public string ColorCuerpo
            {
                get => colorCuerpo; 
                set => colorCuerpo = value;
            }

            public bool Tatuaje
            {
                get => tatuaje; 
                set => tatuaje = value;
            }
            public string Habilidades
            {
                get => habilidades;
                set => habilidades = value;
            }

            public string Resistencias
            {
                get => resistencias;
                set => resistencias = value;
            }

            public void AgregarCaracteristicaUnica(string habilidad,string resistencia)
            {
                this.habilidades = habilidad;
                this.resistencias = resistencia;

            }
        }

    }

}