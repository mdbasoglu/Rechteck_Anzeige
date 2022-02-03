using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck
    {
        // Attribute.
        private double _breite;
        private double _höhe;
        // Konstruktor.
        public Rechteck(double breite, double höhe)
        {
            _breite = breite;
            _höhe = höhe;
        }
        // get-Properties.
        public double Breite
        {
            get
            {
                return _breite;
            }
        }
        public double Höhe
        {
            get
            {
                return _höhe;
            }
        }
        // Rechenmethoden.
        public double GetFläche()
        {
            return _breite * _höhe;
        }
        public double GetUmfang()
        {
            return 2.0 * (_breite + _höhe);
        }
    }
}
