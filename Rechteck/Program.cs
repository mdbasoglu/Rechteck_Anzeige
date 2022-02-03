using System;

namespace Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenngrößen eines Rechtecks.");
            //
            // Ein Rechteck-Objekt erstellen und mit Hilfe einer Referenz verwalten.
            //
            Rechteck rechteck = new Rechteck(2.5, 4.5);
            //
            // Kenngrößen abrufen und ausgeben.
            //
            // Aufruf von Properties.
            //
            Console.WriteLine("Breite: " + rechteck.Breite);
            Console.WriteLine("Höhe : " + rechteck.Höhe);
            //
            // Aufruf von Methoden.
            //
            Console.WriteLine("Fläche: " + rechteck.GetFläche());
            Console.WriteLine("Umfang: " + rechteck.GetUmfang());
        }
    }
}
