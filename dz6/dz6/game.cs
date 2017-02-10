using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    class game
    {
        player player1 { get; set; }
        player player2 { get; set; }
        karta[] massKart { get; set; }
        public game()
        {
            for (int i = 0; i < 36; i++)
            {
                massKart [i] = new karta();
            }
            player1 = new player("player1");
            player2 = new player("player2");
        }
        public void playerKardIN()
        {

        }
        public void sortRand()
        {

        }
        public void gamesOn()
        {

        }





    }
}