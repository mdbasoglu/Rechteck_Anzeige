using System;

namespace H03_Rechteck_Logik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenngrößen eines Rechtecks.");

            Rechteck rechteck = new Rechteck(2.5, 4.5);

            Console.WriteLine($"Breite: {rechteck._Breite}");
            Console.WriteLine($"Höhe: {rechteck._Hoehe}");

            Console.WriteLine($"Fläche: {rechteck.GetFlaeche():f2}");
            Console.WriteLine($"Umfang: {rechteck.GetUmfang():f0}");
        }
    }
}
