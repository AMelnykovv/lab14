using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab14
{
    public class Knight : Figure
    {
        public Knight(string name, string position) : base(name, position)
        {
        }

        public override void PossibleMoves()
        {
            Console.WriteLine($"Possible moves for {Name} at {Position}:");
            // Add code to calculate possible moves for a knight
        }
    }
}
