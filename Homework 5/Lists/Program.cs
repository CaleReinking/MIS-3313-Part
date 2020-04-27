using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] volleyBallNames = { "Ashlynn Dunbar", "Paige Anderson", "Paige Johnson", "Hali'a Swartman-Hogan", "Abby Butler", "Olivia Curtis", "Sanaa Dotson", "Rylie Gregston", "Aysia Harty", "Brianna Kadiku", "Keyton Kinley", "Sarah Maras", "Kylie McLaughlin", "Sarah Sanders" };

            Console.WriteLine($"The names of the ou womens volleyball players are");
            foreach (string vb in volleyBallNames)
            {
                Console.WriteLine(vb);
            }
            Console.ReadKey();
        }
    }
}
