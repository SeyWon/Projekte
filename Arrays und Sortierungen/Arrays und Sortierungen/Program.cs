using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_und_Sortierungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welche Variante 1-4");

            int eingabe;
            eingabe = Convert.ToInt32(Console.ReadLine());
            switch (eingabe)
            {

                case 1:
                    Var1();
                    break;

                case 2:
                    Var2();
                    break;

                case 3:
                    Var3();
                    break;

                case 4:
                    Var4();
                    break;

                case 5:
                    Var5();
                    break;

                case 6:
                    Var6();
                    break;

                case 7:
                    Var7();
                    break;

                case 8:
                    Var8();
                    break;

                case 9:
                    Var9();
                    break;


            }



        }

        static void Var1()
        {
            int[] a = new int[10];

            for (int i = 0; i <= 9; i++)
            {

                a[i] = i;
            }
            for (int i = 0; i <= 9; i++)
            {

                Console.WriteLine(a[i]);
            }
            Console.ReadKey();


        }






        static void Var2()
        {

            int[] a = new int[10];

            Random rnd = new Random();
            for (int i = 0; i <= 9; i++)
            {

                a[i] = rnd.Next(1, 10);


            }
            for (int i = 0; i <= 9; i++)
            {

                Console.WriteLine(a[i]);

            }
            Console.ReadKey();
        }
        static void Var3()
        {
            int eingabe = 10;


            int[] a = Erstellen(eingabe);
            Schreiben(a);
            Console.ReadKey();

        }
        static void Var4()
        {
            int eingabe;

            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            int[] a = Erstellen(eingabe);
            Schreiben(a);
            Console.ReadKey();

        }

        static void Var5()
        {
            int eingabe;
            int von;
            int bis;

            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[] a = Erstellen(eingabe);

            Console.WriteLine("Von wo bis wo wollen sie ihr Array anzeigen");
            Console.Write("Von");
            von = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("bis");
            bis = Convert.ToInt32(Console.ReadLine());




            Rückgabe(a, von, bis);
            Console.ReadKey();


        }
        static void Var6()
        {

            int eingabe;
            bool ende = false;
            char jn;


            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            int[] a = Erstellen(eingabe);
            Schreiben(a);
            Console.ReadKey();
            Console.Clear();

            while (ende == false)
            {

                a = vertauschen(a);
                Console.WriteLine("Neues array");
                Schreiben(a);
                Console.Write("Noch mehr vertauschen?");
                jn = Convert.ToChar(Console.ReadLine());

                switch (jn)
                {

                    case 'n':
                        ende = true;
                        break;

                    case 'j':
                        ende = false;

                        break;

                }

            }
        }


        static void Var7()
        {
            int eingabe;

            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            int[] a = Erstellen(eingabe);
            Console.WriteLine("Unsortiert");
            Schreiben(a);

            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(a);
            Console.WriteLine("Sortiert");
            Schreiben(a);
            Console.ReadKey();
        }

        static void Var8()
        {
            int eingabe;

            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            int[] a = Erstellen(eingabe);
            Console.WriteLine("Unsortiert");
            Schreiben(a);

            Console.WriteLine();
            Console.WriteLine();

            BubbleSort(a);
            
            Schreiben(a);


        }

        static void Var9()
        {


            int eingabe;
            bool ende = false;
            char jn;
            Console.WriteLine("Wie viele Stellen soll ihr Array haben?");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            



            int[] a = Erstellen(eingabe);
            Console.WriteLine("Unsortiert");
            Schreiben(a);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Wie soll Sortiert werden?");
            Console.WriteLine("1 = BubbleSort | 2 = SelectionSort | 3 = Eigenhändig");
            eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {

                case 1:
                    BubbleSort(a);
                    Schreiben(a);
                    Console.ReadLine();
                    break;

                case 2:
                    SelectionSort(a);
                    Schreiben(a);
                    Console.ReadLine();
                    break;

                case 3:

                    do
                    {

                        a = vertauschen(a);
                        Console.WriteLine("Neues array");
                        Schreiben(a);
                        Console.Write("Noch mehr vertauschen?");
                        jn = Convert.ToChar(Console.ReadLine());

                        switch (jn)
                        {

                            case 'n':
                                ende = true;
                                break;

                            case 'j':
                                ende = false;

                                break;

                        }

                    } while (ende == false);
                        
                                break;
                        
            }



        }








        public static int[] Erstellen(int stellen)
        {
            int[] ar = new int[stellen];

            Random rnd = new Random();
            for (int i = 0; i < stellen; i++)
            {
                ar[i] = rnd.Next(1, 10);

            }
            return ar;

        }
        public static void Schreiben(int[] ar)
        {

            Console.Write("|");
            for (int i = 0; i < ar.Length; i++)
            {

                Console.Write("z" + i + " |");
            }
            Console.WriteLine();
            Console.Write("|");
            for (int i = 0; i < ar.Length; i++)
            {

                Console.Write(ar[i] + "  |");
            }

        }
        public static void Rückgabe(int[] ar, int von, int bis)
        {
            for (int i = von; i <= bis; i++)
            {
                Console.WriteLine(ar[i]);
            }

        }
        public static int[] vertauschen(int[] ar)
        {
            int a;
            int b;
            int temp = 0;
            
            Console.WriteLine("Ihr aktuelles Array:");
            Schreiben(ar);

            Console.Write("Tausche Zelle:");
            a =Convert.ToInt32(Console.ReadLine());
            

           
            
             
            Console.Clear();
            Schreiben(ar);
            Console.Write("Mit:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;

            return ar;

        }
        public static int[] BubbleSort(int[] ar)
        {
            int counter = 0;
            for (int j = 0; j < ar.Length; j++)
            {
                for (int i = 0; i < ar.Length - 1; i++)
                {
                    if (ar[i] > ar[i + 1])
                    {
                        int temp = ar[i];

                        ar[i] = ar[i + 1];
                        ar[i + 1] = temp;
                        counter++;
                    }
                }
            }
            Console.WriteLine("Sortiert");
            Console.WriteLine("Anzahl der Änderungen: " + counter);

            return ar;
        }
        public static int[] SelectionSort(int[] ar)
        {
            int counter= 0;

            for (int i = 0; i < ar.Length; i++)
            {
                int min = ar[i];
                
                for (int j = 0; j < ar.Length; j++)
                {
                    int temp;


                    if (min < ar[j])
                    {
                        min = ar[j];
                       
                        temp = ar[j];
                       
                        ar[j] = ar[i];
                       
                        ar[i] = temp;

                        counter++;
                       
                    }
                }
            }
            Console.WriteLine("Sortiert");
            Console.WriteLine("Anzahl der Änderungen: " +counter );

            return ar;
        }
    }
}
    
    

