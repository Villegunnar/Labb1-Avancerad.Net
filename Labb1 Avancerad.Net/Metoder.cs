using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1_Avancerad.Net
{
    public class Metoder
    {
        public static void StartProgram()
        {
            //1. Skapa ett objekt av LådaCollection och lägga till 5 objekt i Collection
            ColourWriteLine("------------Skapa ett objekt av LådaCollection och lägga till 5 objekt i Collection------------");
            LådaCollection boxCollection = CreateBoxes();
          
         

            //2. Lägga till ett objekt med samma höjd, längd, bredd (exempel : 10,10,10) för att testa om vi kan lägga till två lådar med samma dimension.
            ColourWriteLine("\n------------Lägga till ett objekt med samma höjd, längd, bredd------------");
            boxCollection.Add(new Låda(10, 10, 10));



            //3. Testa Remove metod och sen visa listan efter du tagit bort ett objekt
            ColourWriteLine("\n------------Testa Remove metod och sen visa listan efter du tagit bort ett objekt------------");
            Display(boxCollection);
            Console.WriteLine();
            boxCollection.Remove(new Låda(10, 10, 10));

            Display(boxCollection);



            //4. Kolla om vår Collection contains en specifikt objekt
            ColourWriteLine("\n------------Kolla om vår Collection contains en specifikt objekt------------");

            Låda lådaCheck = new Låda(20, 20, 20);
            Console.WriteLine($"Finns en låda med dimensionerna höjd:{lådaCheck.höjd} Längd: {lådaCheck.längd} Bredd: {lådaCheck.bredd}       = {boxCollection.Contains(lådaCheck)}");


            //5. Dispaly metod ska loopa genom alla objekt som finns i Collection och skriva ut dem
            ColourWriteLine("\n------------Dispaly metod ska loopa genom alla objekt som finns i Collection och skriva ut dem------------");
            Display(boxCollection);


            Console.ReadLine();
        }
        public static LådaCollection CreateBoxes()
        {
            LådaCollection Boxes = new LådaCollection()
            {
              new Låda(10, 10, 10),
              new Låda(20, 20, 20),
              new Låda(30, 30, 30),
              new Låda(40, 40, 40),
              new Låda(50, 50, 50)
            };
            return Boxes;
        }
        public static void Display(LådaCollection lådaLista)
        {

            Console.WriteLine("\nHöjd\tLängd\tBredd\tHash Code");
            foreach (var item in lådaLista)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
               item.höjd.ToString(), item.längd.ToString(),
               item.bredd.ToString(), item.GetHashCode().ToString());
            }
        }
        public static void ColourWriteLine(string text = "")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
