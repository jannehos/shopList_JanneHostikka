using System;

namespace shopList_JanneHostikka
{
    class Program
    {
        static void Main(string[] args)
        {


            

            Console.WriteLine("Kuinka monta tuotetta tarvitset:" );
            var tuoteLaskuri = int.Parse(Console.ReadLine());

            for (var i = 0; i < tuoteLaskuri; i++)

            {


                Console.WriteLine("Syötä tuotteen nimi:");
                string title = (Console.ReadLine());
                Console.WriteLine("Tuotteen nimi on:  " + title);

                Console.ReadLine();
            }

        }
    }
}
