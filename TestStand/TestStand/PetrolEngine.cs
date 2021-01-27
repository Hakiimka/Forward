using System;
using System.Collections.Generic;
using System.Text;

namespace TestStand
{
    class PetrolEngine : IEngine 
    {

        public double I { get; set; }
        public List<double> M { get; set; }
        public List<double> V { get; set; }
        public int Tp { get; set; }
        public double Hm { get; set; }
        public double Hv { get; set; }
        public double C { get; set; }

        public PetrolEngine() { }
        public PetrolEngine(double _I,List<double> _M,List<double> _V,int _Tp,double _Hm,double _Hv,double _C)
        {
            I = _I;
            M = _M;
            V = _V;
            Tp = _Tp;
            Hm = _Hm;
            Hv = _Hv;
            C = _C;
        }

        public double CountVc(double C, double Ts, double Td)
        {
            return C * (Ts - Td);
        }
       
        public double CountVh(double M, double Hm, double V, double Hv)
        {
            return M * Hm + (V * V * Hv);
        }
    }
}
