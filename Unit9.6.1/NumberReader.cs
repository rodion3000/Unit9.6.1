using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit9._6._1
{
    internal class NumberReader
    {
        public delegate void NumberDelegate(int number);
        public event NumberDelegate NumberEvent;
      
        public void Read()
        {
            
            string[] lastnameMassive = new string[] {"Конников","Пукичев","Владимирович","Рамзанов","Сурэнович"};
            while (true)
            {
                Console.WriteLine("Введите цифру 1 либо 2");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number != 1 && number != 2)
                {
                    throw new FormatException();
                }
                NumberEntered(number);
                if (number == 1)
                {
                    Array.Sort(lastnameMassive);
                    foreach (string s in lastnameMassive)
                    {
                        Console.WriteLine(s);
                    }


                }
                if (number == 2)
                {
                    Array.Reverse(lastnameMassive);
                    foreach (string s in lastnameMassive)
                    {
                        Console.WriteLine(s);
                    }

                }
            }

            
            
        }
        protected virtual void NumberEntered(int number)
        {
            NumberEvent?.Invoke(number);
        }
        
    }
}
