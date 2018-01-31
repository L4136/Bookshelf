using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Contents of Heli's bookshelf:");
                List<Paper> papers = new List<Paper>();
                papers.Add(new Paper("Koiramme 1/18", 2018, false, "Magazine", false, 130));
                papers.Add(new Paper("Math", 2017, true, "Notebook", false, 50));
                papers.Add(new Paper("Pro Silverlight 5 in C#", 2012, true, "Book", true, 944));
                
                
                foreach (Paper paper in papers)
                {
                    Console.WriteLine(paper.ToString());
                }

                List<Digital> digitals = new List<Digital>();
                digitals.Add(new Digital("Final Fantasy X", 2002, true, "Game", "PlayStation2", false));
                digitals.Add(new Digital("Super Mario", 1985, true, "Epic Game", "Nintendo", true));

                foreach (Digital digital in digitals)
                {
                    Console.WriteLine(digital.ToString());
                }
            }
        }
    }
}
