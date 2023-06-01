using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Figure
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Figure (string name, string position)
        {
            Name = name;
            Position = position;
        }

        public virtual void Move(string newPosition)
        {
            Console.WriteLine($"Moving {Name} from {Position} to {newPosition}");
            Position = newPosition;
        }

        public virtual void PossibleMoves()
        {
            Console.WriteLine($"Possible moves for {Name} at {Position}");
        }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"{Name} is at {Position}");
        }
    }

}

