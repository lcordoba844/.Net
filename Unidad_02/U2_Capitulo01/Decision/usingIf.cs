using System;

namespace Decision
{
    class UsingIf
    {
        static void practicandoIf()
        {
            Console.WriteLine("Ingrese un texto.");
            String inputTexto = Console.ReadLine();

            if (inputTexto == null)
            {
                Console.WriteLine("No se ha ingresado un texto válido");
            }
            else
            {
                Console.WriteLine("Ingrese una opción:");
                Console.WriteLine("1: Mostrar texto en mayúscula.");
                Console.WriteLine("2: Mostrar texto en minúscula.");
                Console.WriteLine("3: Mostrar cantidad de caracteres del texto ingresado.");
                Console.WriteLine("");

                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("_ La palabra en mayúscula es: " + inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("_ La palabra en minúscula es: " + inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("_ La longitud del texto es:" + inputTexto.Length);
                }
                else
                {
                    Console.WriteLine("_ No seleccionó ninguna de las opciones.");
                }
            }
        }
    }
}