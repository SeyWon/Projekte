using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortier_algyromius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[11];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = rnd.Next(1, 100);
            }
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i];

                        array[i] = array[i+1];
                        array[i+1] = temp;  

                        

                    }
                   
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.ReadKey();
        }
    }
}
