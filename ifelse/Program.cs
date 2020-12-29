using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter three Numbers : ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            //string c = Console.ReadLine();
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            int z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x>z)
            {
                Console.WriteLine("Max is " + x);
            }
            else if(y>z)
            {
                Console.WriteLine("max is " + y);
            }
            else
            {
                Console.WriteLine("max is " + z);
            }
        }
    }
}
