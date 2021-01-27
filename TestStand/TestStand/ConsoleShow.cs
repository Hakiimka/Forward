using System;

namespace TestStand
{
    static class ConsoleCommunication
    {
        public static double GetTemp()
        {
            try
            {
                Console.Write("Введите температуру среды: ");
                double Ts = Convert.ToDouble(Console.ReadLine());
                if (Ts <= -50 || Ts >= 200)
                    return 9999;
                else
                return Ts;
            }
            catch { return 9999; }
        }
        public static void ShowTime(int time)
        {
            if (time != 0)
            {
                Console.WriteLine($"Перегрев двигателя произойдет через {time} секунд");
            }
            else 
            {
                Console.WriteLine("При данной температуре перегрев не произойдет");
            }
        }
    }
}
