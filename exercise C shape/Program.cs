using System;
namespace ex_fibonancci
{
class display_fibonacci
    {
        static void Main(string[] args)
        {
            int fi;
            Console.WriteLine(" The first ten numbers of fibonacci: ");
            for (fi = 0; fi < 10; fi++)
            {
                Console.WriteLine(fibonancci(fi));
            }
            

        }
        static int fibonancci(int f)
        
        {

         /// nếu f < 0 thì return về -1;
         if(f < 0)
            {
                return 0;
        /// hoặc nếu f == 0  và f==1 thì return về f;
            }
            else if( f == 0 || f == 1)
            {
                return f;
            }
            else
            {
                return fibonancci(f - 1) + fibonancci(f - 2) ;
            }
        }
    }


}