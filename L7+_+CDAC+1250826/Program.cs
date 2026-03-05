using System;
class Program
{
    static void Main()
    {
        // Problema #1 - Mostrar números del 1 al 20
        string nombre = ("Carlos Daniel Angulo Campos");
        int carnet = 1250826;
        int indice = 1;

        Console.WriteLine("Nombre: ", nombre, " Carnet: ", carnet.ToString());

        while(indice <= 20)
        {
            if(indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(indice);
            indice++;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}