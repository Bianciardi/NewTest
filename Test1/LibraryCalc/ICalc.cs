using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public interface ICalc
    {
        double Ris { get; }
        double Num1 { get; set; }
        double Num2 { get; set; }
        void Somma();
    }
}
