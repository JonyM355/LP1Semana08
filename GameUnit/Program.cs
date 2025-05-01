using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit mu = new MilitaryUnit(3, 10, 2);
            SettlerUnit su = new SettlerUnit();

            mu.Move();
            su.Move();

            Console.WriteLine(mu);
            Console.WriteLine(su);

        }
    }
}
