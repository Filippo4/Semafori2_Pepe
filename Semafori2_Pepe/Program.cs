using Libreria_Semafori2_Pepe;
using System;
using System.Threading;

namespace Semafori2_Pepe
{
    class Program
    {
        public static int s;
        static SemaphoreSlim s1 = new SemaphoreSlim(0);
        static void Main(string[] args)
        {
            while (true)
            {
                s = 0;
                Thread t1 = new Thread(() => procedura1());
                Thread t2 = new Thread(() => procedura2());
                t1.Start();
                t2.Start();
                while (t1.IsAlive) { }
                while (t2.IsAlive) { }
                Console.WriteLine(s);
                Console.ReadLine();
            }
        }
        static void procedura1()
        {
            Console.WriteLine("inserisci il primo numero!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero!");
            int b = int.Parse(Console.ReadLine());
            s = a + b;
            Console.WriteLine($" {s} {a} {b}");
            Console.ReadLine();
            s1.Release();
        }

        static void procedura2()
        {
            Random random = new Random();
            int c = random.Next(10, 99);
            s1.Wait();

            Console.WriteLine($" {s} , {c}");
        }
    }
}
