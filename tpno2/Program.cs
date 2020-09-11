using System;

namespace tpno2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar una aplicación de consola que cargue de un número entero por teclado e imprimir su cuadrado

            int numero;
            String aux;
            try
            {
                Console.WriteLine("Escriba el numero del cual quiere saber su cuadrado");
                aux = Console.ReadLine();
                numero=Int32.Parse(aux);
                Console.Write(numero * numero);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error");
                Console.WriteLine(ex.ToString());
               // throw;
            }
            Console.ReadKey();
        }
    }
}
