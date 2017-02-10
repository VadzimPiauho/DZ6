using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    class player
    {
        public string name;
        public Queue<karta> koloda { get; set; }
        public player ( string name)
        {
            koloda = new Queue<karta>();
            this.name = name;
        }

        public void print()
        {
            foreach(karta i in koloda)
                Console.WriteLine(i);
        }
    }
}