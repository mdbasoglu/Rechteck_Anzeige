using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03_Rechteck_Logik
{
    public class Rechteck
    {
        private double _breite;

        public double _Breite
        {
            get { return _breite; }
        }

        private double _hoehe;

        public double _Hoehe
        {
            get { return _hoehe; }
        }

        public Rechteck(double breite, double hoehe)
        {
            _breite = breite;
            _hoehe = hoehe;
        }

        public double GetFlaeche()
        {
            double flache = _breite * _hoehe;

            return flache;
        }

        public double GetUmfang()
        {
            double umfang = 2 * (_breite + _hoehe);

            return umfang;
        }
    }
}
