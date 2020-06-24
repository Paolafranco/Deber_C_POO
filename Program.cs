
using System;

namespace ConsolaTerceroA
{
    class Program
    {
        static void Main(string[] args)
        {
           
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }

            Console.Write("Bienvenidos,");
            Console.WriteLine(" ingrese sus nombres y apellidos");
            string nombresIngresados = Console.ReadLine();
            Console.Write("Porfavor,");
            Console.WriteLine(" ingrese su numero de cedula");
             string nombresIngresados1 = Console.ReadLine();
            Console.WriteLine("Muchas gracias ya te encuetras registrado: " + nombresIngresados);


            Console.Read();
            Console.ReadLine();
        }
    }
}
