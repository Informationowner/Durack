using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durack.Classes
{
    class Card
    {
        public Suit Suit { get;protected set; }
        public Rank Rank { get;protected set; }
        public bool IsTrump { get;protected set;}

        public override bool Equals(object obj)
        {
            if (((Card)obj).IsTrump && IsTrump && ((Card)obj).Suit == Suit && ((Card)obj).Rank == Rank)
                return true;
            else return false;
        }

        public bool Comparable(Card enemy)
        {
            if (this.IsTrump || enemy.IsTrump)
                return true;
            if (this.Suit == enemy.Suit)
                return true;

            return false;
        }

        public int Compare(Card enemy)
        {
            
//ghg
        }

    }
}
