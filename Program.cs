
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //receiving special character
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaring variables
            string []letter = new string[] {" A", " K", " Q", " J", "10", " 9", " 8", " 7", " 6", " 5", " 4", " 3", " 2"}; 
            string []typeLetter = new string[] {"Diamond", "Sword", "Heart", "Trevol"};

            //Showing letters
            for (int i = 0; i < 13; i++)
            {
                           
                Console.Write("---------------|--------------|---------------|-------------| \n");
                Console.Write("{0}             | {0}           |{0}             |{0}           | \n", letter[i]);
                Console.Write("               |              |               |             | \n");
                Console.Write("               |              |               |             | \n");
                Console.Write("   {0}     |    {1}     |    {2}      |    {3}   | \n", typeLetter[0], typeLetter[1], typeLetter[2], typeLetter[3]);
                Console.Write("               |              |               |             | \n");
                Console.Write("               |              |               |             | \n");
                Console.Write("            {0} |            {0}|             {0}|           {0}| \n", letter[i]);
                Console.Write("---------------|--------------|---------------|-------------| \n");
                 
            }
            
            Console.ReadKey();
        }
    }
}
