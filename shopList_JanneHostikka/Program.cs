using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace shopList_JanneHostikka
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\Users\Janne\source\repos\shopList_JanneHostikka\shopList.txt";



          //  Console.WriteLine("Kuinka monta tuotetta tarvitset:");
           // var tuoteLaskuri = int.Parse(Console.ReadLine());

           // for (var i = 0; i < tuoteLaskuri; i++)         // Aloitin loopin tekoa jotta saisi tuotteita rajattomasti
                                                               // mutta jäi kesken 

            {


                Console.WriteLine("Syötä tuotteen nimi: ");


               // Console.WriteLine("Syötä seuraava tuote: ");

    


                using (StreamWriter Lista = File.AppendText(file))

                {
                    Lista.WriteLine(Console.ReadLine());


                }

            }
        }

    }
}