using System;
using System.Threading;

namespace FSMCat
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var cat = new Cat(6, 10, 100);

            while (true)
            {
                Console.WriteLine(cat.GetState());
                cat.Update();
                Thread.Sleep(500);
            }
        }
    }
}