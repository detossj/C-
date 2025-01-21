using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3part2
{
    internal class Computer
    {
        public string name;
        public Mouse mouse = new Mouse();
        public Keyboard keyboard = new Keyboard();
        public Motherboard motherboard = new Motherboard();
    }    

    internal class Mouse
    {
        public string name;
    }
    internal class Keyboard
    {
        public string name;
    }
    internal class Motherboard
    {
        public string name;
        public Component component = new Component();
    }
    internal class Component
    {
        public string name;
    }

    internal class Ram:Component
    {
        public int capacity;
        public string type;
    }
    internal class Processor:Component
    {
        public int cores;
        public int threads;
    }
    internal class GraphicsCard
    {
        public float clock;
    }

}
