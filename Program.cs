using System;

namespace tut2for
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Give me a number");
            var input1 = Console.ReadLine();
            var number1 = 0;
            var isNumber = int.TryParse(input1, out number1);
          
           
           for( var Count = 0; Count < 12; Count++)
           {
                var a = Count + 1;
                Console.WriteLine(number1 + " Times " + a + " = "+ number1*a);
                
           }
        }
    }
}
