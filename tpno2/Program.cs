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
            

            float numero1, numero2, resultado;
            string aux1, aux2;
            try
            {
                Console.WriteLine("Escriba el numerador: ");
                aux1 = Console.ReadLine();
                numero1 = float.Parse(aux1);
                Console.WriteLine("Escriba el denominador");
                aux2 = Console.ReadLine();
                numero2 = float.Parse(aux2);
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado de la división es = " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
