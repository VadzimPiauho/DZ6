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
            if (koloda.Count==0)
            {
                Console.WriteLine("Карт на руках нет");
            }
            //for (int i = 0; i < koloda.Count; i++)
            //{
            //    Console.WriteLine($"{kolo}-{koloda.GetEnumerator()}");
            //}
            foreach (karta i in koloda)
            {
                ICollection<int> keys = i.type.Keys;
                foreach (int j in keys)
                {
                    //Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]);
                    Console.WriteLine($"{i.type[j].PadLeft(20)}\t-{i.mast}");
                }
            }
        }
    }
}