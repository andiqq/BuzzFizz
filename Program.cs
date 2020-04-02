using System;
using static System.Console;

namespace BuzzFizz {
    class Program {
        static void Main(string[] args) 
        {
            for (int i = 1; i <= 50; i++) 
            {
                
                bool writeNumber = true;

                if (i % 3 == 0) 
                {
                    Write("Buzz");
                    writeNumber = false;
                }
                if (i % 5 == 0) 
                {
                    Write("Fizz");
                    writeNumber = false;
                }
                if (writeNumber) 
                {
                    Write(i);
                }
                Write(" ");
            }
            WriteLine();
        }
    }
}
