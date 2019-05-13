using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var listSpace = new Spaces().GetSpaces();
            var listBoxes = new Boxes().GetBoxes();
        }
    }
}
