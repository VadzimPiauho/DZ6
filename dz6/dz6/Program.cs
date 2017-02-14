using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] arrMast =new []{ "чирва", "буба", "пика", "кресте" };
            var arrType = new[] { "6", "7", "8", "9", "10", "валет", "дама", "король", "туз" };
            Dictionary<int, string> finalResult = new Dictionary<int, string>();
            for (int i = 0; i < arrType.Length; i++)
            {
                finalResult.Add(i,arrType[i]);
            }    
            game Games = new game(arrMast, finalResult);
            Games.sortRand();
            Games.playerKardIN();
            Console.WriteLine("Карты первого игрока");
            Games.player1.print();
            Console.WriteLine("Карты второго игрока");
            Games.player2.print();
            Games.gamesOn();
            Console.WriteLine("Карты первого игрока");
            Games.player1.print();
            Console.WriteLine("Карты второго игрока");
            Games.player2.print();
            Console.WriteLine("Конец игры");
        }
    }
}
