using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Code_Knacker_zusammegführt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            string var;
            bool sw1tch = true;
            // Varianten Hinzufügen
            // Falsche eingaben erkennen/ absturzsicherung
            // Evtl noch so kleine schönheits dinger
            Console.WriteLine("Herzlich Wilkommen zum Codeknacker");
            Console.WriteLine("");
            while (sw1tch == true)      //anfang der While schleife die das ganze programm erst schliest wenn wir möchten
            {
                Console.Clear();
                Console.WriteLine("Wählen sie Ihre Variante");
                Console.WriteLine("|1|2|3|4|5|6|7|8|9|10|11|");

            
                var = Console.ReadLine();


                switch (var.ToLower()) // Alles was wir schreiben wird klein ausgegeben  | damit spart man sich unötig viele case´s
                {

                    case "1":
                    case "variante 1":
                    case "v1":
                        Var1(); //methode in dem sich die Variante befindet wird aufgerufen        
                        Console.Clear();
                        Console.WriteLine("Variante 1 Abgeschlossen");
                        sw1tch = Exit();  //aufrufen der Methode um die While schleife zu schliesen //unten mehr infos 
                        break;


                    case "2":
                    case "v2":
                    case "variante 2":
                        Var2();
                        Console.Clear();
                        Console.WriteLine("Variante 2 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;
                            

                    case "3":
                    case "v3":
                    case "variante 3":
                        Var3();
                        Console.Clear();
                        Console.WriteLine("Variante 3 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;


                    case "4":
                    case "v4":
                    case "variante 4":
                        Var4();
                        Console.Clear();
                        Console.WriteLine("Variante 4 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                 
                    case "5":
                    case "v5":
                    case "variante 5":
                        Var5();
                        Console.Clear();
                        Console.WriteLine("Variante 5 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                  
                    case "6":
                    case "v6":
                    case "variante 6":
                        Var6();
                        Console.Clear();
                        Console.WriteLine("Variante 6 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                  
                    case "7":
                    case "v7":
                    case "variante 7":
                        Var7();
                        Console.Clear();
                        Console.WriteLine("Variante 7 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;


                    case "8":
                    case "v8":
                    case "variante 8":
                        Var8();
                        Console.Clear();
                        Console.WriteLine("Variante 8 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                    case "9":
                    case "v9":
                    case "variante 9":
                        Var9();
                        Console.Clear();
                        Console.WriteLine("Variante 9 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                  
                    case "10":
                    case "v10":
                    case "variante 10":
                        Var10();
                        Console.Clear();
                        Console.WriteLine("Variante 10 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                   
                    case "11":
                    case "v11":
                    case "variante 11":
                        Var11();
                        Console.Clear();
                        Console.WriteLine("Variante 11 Abgeschlossen");
                        sw1tch = Exit();
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(var + " Wurde Nicht gefunden");  
                        Console.WriteLine("");
                        break;


                }
            }
        }
            static void Var1()
            {

            //Variablen given ist die geheimzahl, search werden wir gleich definnieren
            int given = 20;
            int search;
            
            Console.Clear();                                
            Console.WriteLine("Variante 1 | Üben von eingabe und ausgabe | Prüfung ob richtig oder falsch");
            Console.WriteLine("");
            Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen 0-100");



            search = Type();  // Die variable bekommt einen wert, für die angabe rufen wir eine methode auf, Warum sieht man unten 
                

              // Eingegebene Zahl wird mit bereits gesetzter geheimzahl verglichen 
                if (search == given)        
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");        //Haben beide Variabeln den gleichen Wert so gibt uns die Console Gewonnen aus
                    

                }


                else
                {
                    Console.Clear();
                   
                    Console.WriteLine("Die Zahl ist Falsch!");

                }


            Console.ReadKey(); // ReadKey benutzer wir immer wieder um unsere KOnsole beliebig lange auslesen zu können

        }


        static void Var2()
        {
            int given = 50;
            int search;
            
            Console.Clear();
            Console.WriteLine("Variante 2 | Komplexere Bedingte anweisungen | Prüfung ob größer oder kleiner");
            Console.WriteLine("");



            Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen 0-100");
                search = Type();    

                
                    //eingebene Zahl unterscheidet nicht mehr nur unter richtig und falsch sonder gibt auch größer und kleiner aus
                if (search == given)
                {
                   
                    Console.WriteLine("Ihre Zahl ist Richtig!");
                    

                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!       |Eingegebene Zahl: " + search);
                    

                }                                           // wir geben Search noch mal aus damit der User Feedback bekommt was er eingegeben hat
                                                            //Dient der user experience
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!        |Eingegebene Zahl: " + search);

                }
            







        }
        static void Var3()
        {
            int given = 64;
            int search;
            bool win = false; //Bool datentyp für ja oder nein 
            Console.Clear();
            Console.WriteLine("Variante 3 | Einsatz einer wiederholt Anweisung (While-Schleife) | Programm wird erst bei richtiger Zahl geschlossenn");
            Console.WriteLine("");

            while (win == false)  //schleife läuft so lange durch wie bool win false ist 
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen 0-100");
                search = Type();

                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");
                    win = true;                                 //Gewinnen wir setzten wir bool win auf true um die schleife zu beenden
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();

                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);

                }
                else if (search < given)
                {

                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);

                }




            }


        }
        static void Var4()
        {
            int given = 53;
            int search;
            bool win = false;
            int counter = 1;            //counter zum Zählen unserer Versuche. Startet bei eins damit der letzte versuch mit gezähl wird
                                        //alternativ ein counter ++ in der Bedingung gewonnen hinzufügen dann kann man bei 0 starten 
            Console.Clear();
            Console.WriteLine("Variante 4 | Einsatz eines Zählers | Anzahl der Versuche werden Gezählt");
            Console.WriteLine("");

            while (win == false)
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen 0-100");
                search = Type();

                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");

                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");  //counter wird nach dem sieg abgefragt 
                    Console.ReadKey();
                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();
                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;     
                }
              
                // Counter++ rechnet mit jedem mal wo wir falsch raten +1 auf den Counter 
                
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);
                    counter++;
                }

            }

        }
        static void Var5()
        {
            int given;
            int search;
            bool win = false;
            int counter = 1;
            Console.Clear();
            Console.WriteLine("Variante 5 | Einsatz eines Zufallsgenerator | Zahl wird nun vom Computer zufällig generiert");
            Console.WriteLine("");

            Random rnd = new Random();
            given = rnd.Next();         //Hier wird eine Zufalls zahl erstellt und dem int given zugewiesen 

                                        //Variante funktioniert sonst wie Variante 4 nur ist die Gesuchte Zahl mit jeder "Runde" anders

            while (win == false)
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen 0-2147483647");
                search = Type();

                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");

                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");
                    Console.ReadKey();
                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();
                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;
                }
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);
                    counter++;
                }


            }
        }
        static void Var6()
        {
            int given;
            int search;

            bool win = false;
            int counter = 1;
            Console.Clear();
            Console.WriteLine("Variante 6 | Modulo Operator | Zahlenbereich wird von 0-2147483647 auf 100-200 beschränkt");
            Console.WriteLine("");
            Random rnd = new Random();


            given = rnd.Next();
                                        // mit Modulo können wir nun die Grenzen setztn 
                                        //bei einer modulo rechnung kommt der rest einer division als Lösung raus 
            given = given % 101 + 100;  // modulu nimmt den den Rest hinter 101 also o bis 100, um dann auf den bereich 100-200 zu kommen rechnen wir unseren ersten bereich + 100

            
            while (win == false)
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein    Tipp: Die gesuchte Zahl befindet sich zwischen 100 und 200");
                search = Type();
                
                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");

                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");
                    Console.ReadKey();
                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();
                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;
                }
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);
                    counter++;
                }


            }
        }
        static void Var7()
        {
            int given;
            int search;
            int min;
            int max;
            bool win = false;
            int counter = 1;
            Console.Clear();
            Console.WriteLine("Variante 7 | Funktionen mit Parameter und Variabeln Speichern | Der Nutzer setzt die grenzen selbst");
            Console.WriteLine("");
            Random rnd = new Random();
            Console.WriteLine("Sie dürfen nun den Zahlenbereich selber festlegen");

            Console.WriteLine("Geben sie die Niedrigste Zahl des Zahlenbereichs an");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            // Abfragen der Grenzen für unsere Zufallszahl 
            Console.WriteLine("Geben sie die höchste Zahl des Zahlenbereichs an");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            given = rnd.Next(min, max);         // Setzen der Grenzen der Zufallszahl //modulo wird dafür nicht zwingend benötigt 



            


            while (win == false)
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen " + min + " und " + max);
                search = Type();
                
                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");

                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");
                    Console.ReadKey();
                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();
                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;
                }
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);
                    counter++;
                }


            }
        }

        static void Var8()
        {
            int given;
            int search;
            int min = 1000;
            int max = 10000;
            int ave = 14;         // wir haben 9000 eratbare Zahlen. Wir müssen 9000 14 mal durch 2 Teilen um eine Zahl kleiner als 1 rauszubekommen
                                  // das ist dann unser Durschnittswert der Versuche die man benötigt
            bool win = false;
            int counter = 1;
            Random rnd = new Random();
            given = rnd.Next(min, max);



            Console.Clear();
            Console.WriteLine("Variante 8 | bedingte anweisungen + alg. | Nutzer bekommt eine Rückmeldung ob er gut oder schlecht war");
            Console.WriteLine("");


            while (win == false)
            {
                Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen " + min + " und " + max);

                search = Type();





                if (search == given)
                {
                    Console.WriteLine("Ihre Zahl ist Richtig!");
                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");

                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();

                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;
                }
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!       |Eingegebene Zahl: " + search);
                    counter++;
                }

            }
                if (counter == ave)         //Vergleich unseres Counters mit dem Vordefinierten Durschnittswert NACH der While schleife
                {
                    Console.WriteLine("Ihre Leistung war Durschnittlich");
                }
                else if (counter > ave)
                {

                    Console.WriteLine("Ihre Leistung war schlechter als der Durschnitt");
                    Console.WriteLine("Die Durschnitlichte Anzahl an Versuchen für den bereich " + min + " bis " + max + " lautet " + ave);
                                                                                                                    


                }
                else if (counter < ave)
                {
                    Console.WriteLine("Ihre Leistung war besser als der Durschnitt");
                    Console.WriteLine("Die Durschnitlichte Anzahl an Versuchen für den bereich " + min + " bis " + max + " lautet " + ave);


            }
                Console.ReadKey();
            




        }


        static void Var9()
        {
            
            int given;
            int search;
            int min;
            int max;
            bool win = false;
            int counter = 1;
            
          
            Console.Clear();
            Console.WriteLine("Variante 9 | Lösungsalgorithmus | Algorithmus entscheidet über gut und schlecht");
            Console.WriteLine("");
            Random rnd = new Random();
            Console.WriteLine("Sie dürfen nun den Zahlenbereich selber festlegen");

            Console.WriteLine("Geben sie die Niedrigste Zahl des Zahlenbereichs an");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Geben sie die höchste Zahl des Zahlenbereichs an");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            given = rnd.Next(min, max);



            
            

            while (win == false)
            {

                     Console.WriteLine("Geben sie die gesuchte Zahl ein  Tipp: sie befindet sich zwischen " + min + " und " + max);
                     search = Type();
                
                



                if (search == given)
                {
                    Console.Clear();
                    Console.WriteLine("Ihre Zahl ist Richtig!");
                    Console.WriteLine("Sie haben " + counter + " versuche gebraucht");
                    
                    //Methode mit ein und Rückgabewert ein geben tun wir dei Variabeln die wir für die Berechnung des Durschnitts brauchen//Dazu unten mehr
                    Console.WriteLine(Valuation(min, max, counter));        //Valuation ist ein Algorythmus der Uns für jeden beliebigen Zahlenbereich
                                                                            //den Durschnitt berechnet und Ihn mit unserer Anzahl an versuchen vergleicht 
                    Console.ReadLine();

                    win = true;
                    Console.WriteLine("");
                    Console.WriteLine("Drücken sie eine beliebige Taste");
                    Console.ReadKey();

                }
                else if (search > given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist kleiner!      |Eingegebene Zahl: " + search);
                    counter++;
                }
                else if (search < given)
                {
                    Console.Clear();
                    Console.WriteLine("Die Gesuchte Zahl ist größer!      |Eingegebene Zahl: " + search);
                    counter++;
                }  
            }
        }

        static void Var10()
        {
            int suchzahl;
            int min;
            int max;
            bool gewonnen = false;
            bool maxwert = true;
            bool minwert = false;
            int counter = 1;
            String op;
            



                Console.Clear();
                Console.WriteLine("Variante 10");
                Console.WriteLine("In dieser Variante Spielt der Computer gegen sie");
                Console.WriteLine("");
                Console.WriteLine("Geben sie die Zahl ein die der Computer erraten soll");


                suchzahl = Type();  
                Console.Clear();
    
                Console.WriteLine("Festlegen des Suchbereiches");
                Console.WriteLine("Geben sie die Untergrenze ein");
            do
            {

                min = Type();
                Console.Clear();
                if (min > suchzahl)
                {
                    Console.WriteLine("Fehler die Zahl kann nicht größer als " + suchzahl +" sein");
                }
                else
                {
                    minwert = true;
                }



            } while (minwert == false);

              Console.WriteLine("Festlegen des Suchbereiches");

            do
            {
                Console.WriteLine("Geben sie die Obergrenze ein");
                max = Type();
                if (max < min)
                {
                    Console.WriteLine("Fehler die Zahl kann nicht kleiner als " + min + " sein"); // absturzsicherheit für den fall das max kleiner als min ist

                }
                else
                {
                    maxwert = false;
                }
            } while (maxwert == true);
             


       
                int m1n = min;          //min und max werden sich gleich immer wieder verändern 
                int m4x = max;          // für Valuation brauchen wir jedoch die ursprungswerte die wir definiert haben
                                        // deswegen weisen wir 2 weiteren Variabeln vor dem anfang der while schleife die werte zu
                                        //diese sind dann fest und verändern sich nicht mehr 


                while (gewonnen == false)
                {
                // Fenster mit Infos der eingaben die der benutzer vorher gemacht hat
                Console.Clear();
                Console.WriteLine("Zur Erinnerung");
                Console.WriteLine("Eingegebene Zahl: " + suchzahl);
                Console.WriteLine("Niedrigste Zahl des Such Bereichs: " + m1n); //erster fall bei dem wir die Ursprungswerte brauchen 
                Console.WriteLine("Höchste Zahl des Such Bereichs: " + m4x);
                Console.WriteLine("");
                Console.WriteLine("");
                
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(min, max);
                  //Gennieren einer Zufallszahl ober und untergrenze sind gegeben
                
                    Console.WriteLine("Ist es " + randomNumber + "?");
                    Console.WriteLine("Folgende Antorten sind Möglich");
                    Console.WriteLine("J = JA | G = Die Gesuchte Zahl ist Größer | K = die gesuchte zahl ist kleiner");
                    op = Console.ReadLine();
                        //computer fragt jetzt ob seine Zahl richtig ist 
                    switch (op)
                    {
                        case "j": // wir sagen dem Computer das er richitg liegt
                       
                                  if (suchzahl == randomNumber)  //abfrage ob er wirklich richtig liegt 
                                  {
                                           Console.Clear();
                                           Console.WriteLine("War garnicht so schwer ;)");
                                           Console.WriteLine("Ich habe " + counter + " Versuche gebraucht");
                                           Console.WriteLine(Valuation(m1n, m4x, counter)); //Zweiter fall bei dem wir die Ursprungswerte brauchen 
                                           gewonnen = true;
                                           Console.WriteLine("");
                                           Console.WriteLine("Drücken sie eine beliebige Taste");
                                           Console.ReadKey();

                                  }
                                
                                  else //sagen wir dem Computer erliegt richtig obwohl er es nicht tut merkt er es 
                                  {
                                            Console.WriteLine("Lügen ist nicht cool");
                                            Console.ReadLine();
                                            
                                  }

                        break;

                        case "g": //Die gesuchte Zahl ist größer
                               
                                 if (suchzahl > randomNumber)
                                 {

                                         min = randomNumber + 1; //ist die Gesuchte Zahl wirklich Größer wird unsere Aktuelle Zahl
                                                                 // als Min wert für die Nächste berechnung benutzt
                                         counter++;
                                  }
                        
                                 else if (suchzahl == randomNumber)
                                 {
                                            Console.WriteLine("Lügen ist nicht cool");
                                            Console.ReadLine();                         //es ist nicht möglich den Pc anzulügen, 
                                                                                        // ist nur fair weil der Pc würde dich auch nicht anlügen ;)
                                 }
                                 else if (suchzahl < randomNumber)
                                 {
                                             Console.WriteLine("Lügen ist nicht cool");
                                             Console.ReadLine();

                                 }
                        break;

                        case "k":
                       
                                if (suchzahl < randomNumber)
                                {

                                        max = randomNumber - 1;     //ist die Gesuchte Zahl wirklich Kleiner wird unsere Aktuelle Zahl
                                                                    // als Max wert für die Nächste berechnung benutzt
                                        counter++;
                                }
                       
                                else if (suchzahl == randomNumber)
                                {
                                        Console.WriteLine("Lügen ist nicht cool");
                                        Console.ReadLine();
                                }
                                else if (suchzahl > randomNumber)
                                {
                           
                                         Console.WriteLine("Lügen ist nicht cool");
                                         Console.ReadLine();

                                }

                        break;




                    }
                }
        }


        public static void Var11()
        {
            Console.WriteLine("Zusatzaufgabe 2 | Generieren einer Zufalls Zahl die Größer als der Max rnd wert ist");

            int stellen;
            int[] a = new int[20];               // generiert ein Array. Es muss so Groß sein wie die Höchste Zahl die rnd Stellen gennerieren kann, in diesem Fall 20
            Random rnd = new Random();
            stellen = rnd.Next(1, 20);                 // zufalls Zahl bestimmt die anzahl an Stellen


            Random rnd2 = new Random();

            // for schleife läuft so oft durch Wie Stellen herausgeben wurden

            for (int i = 0; i < stellen; i++)
            {

                //Jede Variable im Array bekommt einen wert von 0-9
                a[i] = rnd2.Next(9);


            }
            //Hier schreiben wir alle Generierten Zahlen nebeneinander damit es wie eine ganze aussieht
            for (int i = 0; i < stellen; i++)
            {



                Console.Write(a[i]);


            }


            Console.WriteLine("");
            Console.WriteLine("Drücken sie eine beliebige Taste");
            Console.ReadKey();

        }
      





        static int Type() //methode für die absturz sichere eingagbe von Integern 
        {
            bool finish = false; 
            // schleife läuft solange durch bis wir uns
            while (finish == false)
            {
                try      //versuche 
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    finish = true;
                    return guess; //wird die angabe akzeptiert sinden wir guess als rückgabewert zurück 
                }
                catch  // sollte es nicht gehen mach das 
                {
                    Console.Clear();
                    Console.WriteLine("Ungültige eingabe");
                }
            }
            return 0; 
        }
        static bool Exit()
        {
            bool ende = false;
           
            Console.WriteLine("Wollen sie weiter machen?");
            Console.WriteLine("J | N");
            while (ende == false)           //schleife läuft solange durch wie wir wollen, damit verhindern wir fehlerhafte eingaben
            {
                string exselect = Console.ReadLine(); 

                switch (exselect.ToLower()) //to lower wieder um groß und klein schreibung zu ignorieren
                {

                    case "j":

                        return true; // sagen wir ja wird der Rückgabewert zu True // an der 1. while schleife ändert sich nix




                    case "n":

                        return false; //sagen wir nein wird der Rückgabewert zu false //
                                      //die 1. While schleife kann aufgrund des negativen bool Sw1tch nicht betreten werden und das programm geht aus 


                    default:
                        Console.WriteLine("Fehler bei der eingabe"); //jede andere eingabe wird nicht akzeptiert 
                        break;

                }
            }
            

            return false;



        }
        static string Valuation(int vmin, int vmax, int vcounter) //die Mitgegebenen Werte bekommen neue Variablen 
        {
            int acount = 0;
            int durschnitt = vmax - vmin; //berechnen wie viele mögliche Zahlen eraten werden können 
            while (durschnitt > 1)
            {
                durschnitt = durschnitt / 2; //Diese Zahl wird so oft durch 2 geteilt bis wir eine Zahl kleiner als 1 Raus bekommen
                acount++;  // ein counter Zählt jeden Durchlauf mit // dies ist dann unser Durschnittswert
            }

            //vergleich vom berechneten Durschnittswert mit Counter der Versuche (haben wir der Methode mitgeben) die wir gebraucht haben
            if (acount == vcounter) 
            {
                return "Die erbrachte Leistung lag im Durschnitt"; //Rückgabewert 
            }

            else if (acount > vcounter)
            {

                return //rückgabewert 
                Environment.NewLine + // damit kann man einen Zeilen umbruch machen
                "Die erbrachte leistung war besser als der Durschnitt " + 
                Environment.NewLine +
                "die Durschnitlichte Anzahl an Versuchen für den bereich " + Convert.ToString(vmin) + " bis " + Convert.ToString(vmax) + " lautet " + Convert.ToString(acount);
                                                                                                            //Infos damit der User seine leistung vergleichen kann
                                                                                                            //und rückmeldung bekommt
               

            }
            else if (acount < vcounter)
            {                               
                return
               Environment.NewLine +
               "Die erbrachte leistung war schlechter als der Durschnitt " + 
               Environment.NewLine +
               "die Durschnitlichte Anzahl an Versuchen für den bereich " + Convert.ToString(vmin) + " bis " + Convert.ToString(vmax) + " lautet " + Convert.ToString(acount);



            }
            return "";
        }

    }

    


}
