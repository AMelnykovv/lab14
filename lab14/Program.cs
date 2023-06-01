using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Program
    {
        public static void Main()
        {
            Figure knight = new Knight("Knight", "B1");
            knight.PrintPosition();
            knight.PossibleMoves();
            knight.Move("A3");
            knight.PrintPosition();
        }
    }
}
