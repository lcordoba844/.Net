using System;

namespace Decision;
class UsingCase { 
    static void Main() {

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

            if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.D3) {
                int option = opcion.KeyChar - '0';
                switch (option) {
                    case 1: {
                            Console.WriteLine("_ La palabra en mayúscula es: " + inputTexto.ToUpper());
                            break;
                        }
                    case 2: {
                            Console.WriteLine("_ La palabra en minúscula es: " + inputTexto.ToLower());
                            break;
                        }
                    case 3: {
                            Console.WriteLine("_ La longitud del texto es: " + inputTexto.Length);
                            break;
                        }
                }
            }
        }
    }
}