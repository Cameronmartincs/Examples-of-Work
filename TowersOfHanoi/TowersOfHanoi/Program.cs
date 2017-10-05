using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{

    class TowerOfHanoi
    {

        static void Main(string[] args)
        {

            int m = 0;
            Console.Write("Enter the number of discs: ");
            int numdiscs = Convert.ToInt32(Console.ReadLine());
            movedisc(numdiscs, 1, 3, 2, ref m);
            Console.WriteLine("Number of moves = {0}", m);

        }
        static void movedisc(int n, int begin, int end, int temp, ref int m)
        {
            
            if (n > 0)
            {
                movedisc(n - 1, begin, temp, end,ref m);
                Console.WriteLine("Moved disk {0} from tower {1} to tower {2}", n, begin, end);
                m++;
                movedisc(n - 1, temp, end, begin,ref m);

            }
        }
    }
}
