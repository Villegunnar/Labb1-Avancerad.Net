using System;
using System.Collections.Generic;
namespace Labb1_Avancerad.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Skapa ett objekt av LådaCollection och lägga till 5 objekt i Colliction
            LådaCollection Boxes = new LådaCollection() 
            { 
              new Låda(10, 10, 10),
              new Låda(20, 20, 20),
              new Låda(30, 30, 30),
              new Låda(40, 40, 40),
              new Låda(50, 50, 50)
            };


            //2. Lägga till ett objekt med samma höjd, längd, bredd (exempel : 10,10,10) för att testa om vi kan lägga till två lådar med samma dimension.
            Boxes.Add(new Låda(10, 10, 10));



            //3. Testa Remove metod och sen visa listan efter du tagit bort ett objekt
            Boxes.Remove(new Låda(10, 10, 10));

            foreach (var item in Boxes)
            {
                Console.WriteLine(item);
            }



            //4. Testa Remove metod och sen visa listan efter du tagit bort ett objekt
            if (Boxes.Contains(new Låda(20, 20, 20)))
            {
                Console.WriteLine("Boxes with dimensions 20x20x20 exists in the list");
            }
            else
            {
                Console.WriteLine("Box dosnt exist in then list");
            }



            //5. Dispaly metod ska loopa genom alla objekt som finns i Collection och skriva ut dem
            Display(Boxes);


            Console.ReadLine();
        }
        public static void Display(LådaCollection tempList)
        {
            foreach (var item in tempList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
