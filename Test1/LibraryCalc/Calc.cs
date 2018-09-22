using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Calc:ICalc
    {
        private double _num1;
        public double Num1
        {
            get { return _num1; }
            set { _num1 = value; }
        }

        private double _num2;
        public double Num2
        {
            get { return _num2; }
            set { _num2 = value; }
        }

        private double _ris;
        public double Ris
        {
            get { return _ris; }
        }

        public Calc()
        {

        }
        public void Somma()
        {
            _ris = _num1+_num2;
        }
    }
}
