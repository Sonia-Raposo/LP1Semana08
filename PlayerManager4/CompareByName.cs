using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace PlayerManager4
{
    public class CompareByName: IComparer <Player>
    {

        private bool order { get; }

        public int Compare(Player p1, Player p2)
        {
            int compare;

            if (order) 
            {
                compare = p1.Name.CompareTo(p2.Name);
            }

            else
            {
                compare = p2.Name.CompareTo(p1.Name);
            }

            return compare;
        }

        public CompareByName(bool playerOrder)
        {
            order = playerOrder;
        }
    }
}

    