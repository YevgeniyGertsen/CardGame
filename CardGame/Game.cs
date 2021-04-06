using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        public List<Player> players { get; set; }
        public Stack<Card> cards { get; set; }
        Random rnd = new Random();
        public void createPlayer()
        {
            for (int i = 0; i < rnd.Next(2, 4); i++)
            {
                Player player = new Player();
                player.Name = "Player " + i;
                players.Add(player);
            }
        }
        public void createCards()
        {
            foreach (TypeCard item in (TypeCard[])Enum.GetValues(typeof(TypeCard)))
            {
                for (int i = 6; i <= 14; i++)
                {
                    Card card = new Card();
                    card.mast = item;
                    card.cardNumber = i;
                    cards.Push(card);
                }
            }
        }
        public void distribution()
        {
            while (cards.Count>0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].cards.Add(cards.Pop());
                }
            }
        }
    }
}
