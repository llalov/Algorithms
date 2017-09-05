using System;

namespace _1_3_Recursive_Drawing
{
    class Program
    {
        public static void Draw(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', n));
            Draw(n - 1);
            Console.WriteLine(new string('#', n));
        }

        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            Draw(n);
        }

        //  EXPECTED OUTPUT FOR INPUT 5:

        //  *****
        //  ****
        //  ***
        //  **
        //  *
        //  #
        //  ##
        //  ###
        //  ####
        //  #####
       
    }
}
