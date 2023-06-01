using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab14
{
    public class King : Figure
    {
        public King(string name, string position) : base(name, position)
        {
        }

        public override void PossibleMoves()
        {
            Console.WriteLine($"Possible moves for {Name} at {Position}:");
            // Add code to calculate possible moves for a king
        }
    }
}
