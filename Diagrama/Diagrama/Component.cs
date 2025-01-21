using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    internal class Component
    {
        private string name;
    }

    internal class Ram:Component
    {
        private int capacity;
        private string type;
    }

    internal class Procesor:Component
    {
        private int cores;
        private int threads;
    }
    internal class GraphicsCard
    {
        private float clock;
    }
}
