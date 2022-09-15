using System;

namespace Syntax_and_Syntax_Sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9)? ($"{answer} is less than 9 ") : ($" {answer} is greater than 9");
            Console.WriteLine(response);
        }
    }
}
