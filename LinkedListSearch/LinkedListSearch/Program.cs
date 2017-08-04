using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cameron Woodhull-Martin
  CSC340
  Linked List Search
  This program is desined to go through an unorganized list using a reference list that of its own order. */
namespace LinkedListSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            do{     //used for repeatability


                //unorganized array
                int[] array = { 1, 4, 6, 8, 9, 2, 3, 7, 5 };

                //array with algorith L(next(i)) applied
                int[] next = { 5, 8, 7, 4, 10, 6, 1, 3, 2};
              
                Console.WriteLine("\nSearch for a number 1-9:");
                int x = Convert.ToInt32(Console.ReadLine());

                //save the position of number looking for
                int y = LinkedListSearch(array, 9, 0,next, 10, x);

                Console.WriteLine("your number is in position {0} of the original array.", y);
                                
            }while(Continue());
        }




        static int LinkedListSearch(int[] list, int n, int head, int[] next, int guesses, int x)
        {
            False:          //used for garunteed outcome. in case guesses doesnt find sufficient guess
            int largest = head;
            
            for (int i = 1; i < guesses; i++)
            {
                int j = uniform(1, n);
                if ((x > list[j]) && (list[j] > list[largest]))
                    largest = j;
            }

            int index = largest;
            if((next[index] != 10) && (x > list[index]))
            {
     
                index = next[index];
                       
            }
            if (list[index] == x)
                    return index;
                else
                    goto False;
           
        }

        //Find random number
        static int uniform(int begin, int end)
        {
         
            Random random = new Random();
            return (random.Next(begin, end));

        }

        //Used only for continuing after single use
        static bool Continue()
        {
            Continue:
            Console.Write("Do you wish to continue: (y)es or (n)o: ");
            char cont = Convert.ToChar(Console.ReadLine());

            switch (cont)
            {
                case ('y'):
                    return true;
                case ('n'):
                    return false;
                default:
                    Console.WriteLine("Please input correct letter.");
                    goto Continue;

            }

        }
    }
}
