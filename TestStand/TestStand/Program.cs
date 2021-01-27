using System.Collections.Generic;

namespace TestStand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> M = new List<double>() { 20, 75, 100, 105, 75, 0 };
            List<double> V = new List<double>() { 0, 75, 150, 200, 250, 300 };

            PetrolEngine engine = new PetrolEngine(10, M, V, 110, 0.01, 0.0001, 0.1);
            PetrolTestStand petrolTestStand = new PetrolTestStand(); // TEST

            double Ts = ConsoleCommunication.GetTemp();
            ConsoleCommunication.ShowTime(petrolTestStand.BeginTest(engine, Ts));
        }
    }
}
