using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum TypeCard
    {
        Chervi, Bubi, Piki, Krestya
    }
    
    class Card
    {
        public TypeCard mast { get; set; }
        public int cardNumber { get; set; }
    }
}
