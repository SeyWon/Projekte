using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT15
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // 97 a - 122 z


            string choose;

            Console.WriteLine("ROT 15");
            Console.WriteLine("Möchten sie lesen oder schreiben");

            choose = Console.ReadLine();


            if (choose == "schreiben")
            {
                write();
                Console.ReadKey();
               
            }
            else if (choose == "lesen")
            {
                read();
                Console.ReadKey();

            }

        }
        static void write()
        {

            string a;
            Console.Write("was möchten sie schreiben: ");
            a = Console.ReadLine();


            foreach (char b in a)
            {
                int c = b + 15;

                if (c >= 97 & c <= 122)
                {
                    Console.Write(Convert.ToChar(c));


                }
                else if (c > 122)
                {

                    Console.Write(Convert.ToChar(c - 122 + 96));


                }


            }
        }
        static void read()
        {

            string a;

            Console.Write("was möchten sie lesen: ");
            a = Console.ReadLine();


            foreach (char b in a)
            {
                int c = b - 15;

                if (c >= 97 & c <= 122)
                {
                    Console.Write(Convert.ToChar(c));

                }
                else if (c < 97)
                {

                    Console.Write(Convert.ToChar(c + 122 - 96));


                }




            }
        }
    }
}
