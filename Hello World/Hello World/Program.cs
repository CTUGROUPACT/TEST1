using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            String strOne = "world";
            String strTwo = "Hello";
            Console.WriteLine(SwapWords(strOne, strTwo));
            
                
            Console.WriteLine(strOne +" " + strTwo );

            Console.ReadKey(); 
        }
        static String SwapWords( string String1, string String2)
        {
            String strThree = String1;
            String1 = String2;
            String2 = strThree;
            return (String1 + " " + String2);

                
        }
        
    }
}
