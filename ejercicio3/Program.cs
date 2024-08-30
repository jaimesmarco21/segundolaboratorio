using System;
class program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Menú de Operaciones Matemáticas:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero.");
                    }
                    break;
                    case 5:
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
            }
            Console.WriteLine();
        }
    }
}