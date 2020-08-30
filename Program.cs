using System;

namespace Act_3_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rc, ri, rb, tot;
            Console.WriteLine("Ingrese respuestas correctas, incorrectas y en blanco.");
            rc = int.Parse(Console.ReadLine());
            ri = int.Parse(Console.ReadLine());
            rb = int.Parse(Console.ReadLine());
            tot = rc * 4 - ri;
            Console.WriteLine("El puntaje total es de {0}", tot);
        }
    }
}
