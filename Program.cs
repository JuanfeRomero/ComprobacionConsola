using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoInt = Int32.MaxValue;
            string tipoString = "Otro tipo de dato diferente";
            DateTime tipoFecha = DateTime.Now;
            long tipoLong = Int64.MaxValue;
            bool tipoBoolean = tipoLong > tipoInt;
            float tipoFloat = Single.MaxValue;

            Console.WriteLine("Mensaje por su cuenta");
            Console.WriteLine("Imprimir el tipo de dato int: " + tipoInt);
            Console.WriteLine(tipoString);
            Console.WriteLine(tipoFecha.ToString("dd/M/yyyy HH:mm"));
            Console.WriteLine("Long es mas grande que int?: " + tipoBoolean);
            Console.WriteLine($"porque el maximo de tipo int es {tipoInt} y el maximo de long es {tipoLong}");
            Console.WriteLine($"mientras que con numeros decimales el maximo permitido es {tipoFloat}");

            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();

        }
    }
}
