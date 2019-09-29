using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість чисел");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть з якого числа починається послідовність 0:(0,1),1:(1,1)");
            int a = int.Parse(Console.ReadLine());
            int[] arrayNumber = new int[count];
            arrayNumber[0] = a;
            arrayNumber[1] = 1;
            for(var index=2;index<count;index++)
            {
                arrayNumber[index] = arrayNumber[index - 1] + arrayNumber[index - 2];
            }
            foreach(var i in arrayNumber)
            {
                Console.Write(i + "  ");
            }
            Console.ReadKey();
        }
    }
}
