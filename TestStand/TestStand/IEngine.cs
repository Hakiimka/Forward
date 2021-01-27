using System;
using System.Collections.Generic;
using System.Text;

namespace TestStand
{
    interface IEngine 
    {
        double CountVh(double M, double Hm, double V, double Hv);
        double CountVc(double C, double Ts, double Td);
    }
}
