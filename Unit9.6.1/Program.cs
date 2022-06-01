using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Unit9._6._1
{
     class Program
    {
        static void Main(string[]args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEvent += ShowNumber;
            try 
            {
            numberReader.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверно");

            }
        }
        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Введена цифра 1 "); break;
                case 2: Console.WriteLine("Введена цифра 2"); break;

            }

        }
    }
}

