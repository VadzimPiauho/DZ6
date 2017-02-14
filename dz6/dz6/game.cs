using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    class game
    {
        public player player1 { get; set; }
        public player player2 { get; set; }
        public karta[] massKart { get; set; } = new karta[36];
        public game(string [] arrMast, Dictionary<int,string> finalResult)
        {
            ICollection<int> keys = finalResult.Keys;
            int i = 0;
                for (int j = 0; j < 4; j++)
                {    
                    for (int k = 0; k < 9; k++)
                    {
                        massKart[i] = new karta();
                        massKart[i].mast = arrMast[j];  
                        massKart[i].type.Add(k, finalResult[k]);
                    
                        //Console.WriteLine("ID -> {0}  Name -> {1}", j, dic[j]); 
                        i++;
                    }   
                }   
            player1 = new player("player1");
            player2 = new player("player2");
        }    
        public void sortRand()
        {  
            Random rand = new Random();
            for (int i = massKart.Length - 1; i >= 0; i--)
            {
                int j = rand.Next(i);
                karta tmp = massKart[i];
                massKart[i] = massKart[j];
                massKart[j] = tmp;
            }
        }
        public void playerKardIN()
        {
            for (int i = 0; i < massKart.Length; i++)
            {
                player1.koloda.Enqueue(massKart[i]);
                player2.koloda.Enqueue(massKart[i+1]);
                i++;
            }
        }
        public void gamesOn()
        {
            while (true)
            {
                if (player1.koloda.Count ==0 || (player2.koloda.Count==0))
                {
                    if (player1.koloda.Count == 0)
                    {
                        Console.WriteLine("Победил второй игрок");
                    }
                    if (player2.koloda.Count == 0)
                    {
                        Console.WriteLine("Победил первый игрок");
                    }
                        break;
                }
                int [] arr1= new int[1];
                int[] arr2 = new int[1];
                ICollection<int> keys1 = player1.koloda.Peek().type.Keys;
                ICollection<int> keys2 = player2.koloda.Peek().type.Keys;
                keys1.CopyTo(arr1,0);
                keys2.CopyTo(arr2,0);

                //Console.WriteLine(player1.koloda.Peek().type);
                if ((arr1[0]> arr2[0])|| arr1[0] == arr2[0])
                {
                    player1.koloda.Enqueue(player2.koloda.Peek());
                    player2.koloda.Dequeue();
                }
                if (arr1[0] < arr2[0])
                {
                    player2.koloda.Enqueue(player1.koloda.Peek());
                    player1.koloda.Dequeue();
                }
               
            }
        }
    }
}