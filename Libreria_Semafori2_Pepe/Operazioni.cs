using System;

namespace Libreria_Semafori2_Pepe
{
  
    public static class Operazioni
    {
        public static int s;
        public static int Somma(int a, int b)
        {
            s = a + b;
            return s;
        }
        public static int GeneraNumero()
        {
            Random random = new Random();
            int c = random.Next(10, 99);
            return c;
        }

    }
}
