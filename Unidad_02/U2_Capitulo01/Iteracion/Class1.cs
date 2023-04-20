using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteracion
{
    internal class Class1
    {
        static void Main() {

            int cantIteraciones = 5;
            string[] listita = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++) {
                Console.WriteLine("Ingrese palabra para la posición "+ i +": ");
                listita[i] = Console.ReadLine();            
            }

            Console.WriteLine();

            for (int i = (listita.Length - 1); i >= 0 ; i--)
            {
                Console.WriteLine(listita[i]);
            }

            /* CON FOREACH INVIRTIENDO EL ARRAY 
            Array.Reverse(listita);

            foreach (string s in listita)
            {   
                Console.WriteLine(s);
                Console.WriteLine();
            }

            */
        }
    }
}
