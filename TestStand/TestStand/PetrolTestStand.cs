using System;

namespace TestStand
{
    class PetrolTestStand : ITestStand
    {
        public PetrolTestStand() { }

        public int BeginTest(PetrolEngine engine, double Ts)
        {

            double tempD = Ts;
            int sec = 0;

            for (int i = 0; tempD <= engine.Tp; i++)
            {
                sec++;
                double a = engine.M[i] / engine.I;
                double tempVh = engine.CountVh(engine.M[i], engine.Hm, engine.V[i], engine.Hv); // нагрев
                double tempVc = engine.CountVc(engine.C, Ts, tempD); // охлаждение
                tempD += tempVh - tempVc;
                tempD *= 0.9; // dt
                if (i == engine.M.Count - 1)
                    i = 0;
                engine.V[i] *= a * 0.1;
            }
            return sec;
        }

        public int BeginTest(IEngine engine, double Ts)
        {
            throw new NotImplementedException();
        }
    }
}
