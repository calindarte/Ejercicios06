using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios07
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta)
     si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)*/

            Console.SetCursorPosition(20, 4); Console.Write("Escribe el precio del producto: $");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.SetCursorPosition(20, 5); Console.Write("Elige la forma de pago (tarjeta o efectivo): ");
            string forma = (Console.ReadLine()).ToLower();

            if (forma.Equals("tarjeta"))
            {
                Console.SetCursorPosition(20, 6); Console.Write("Introduce el numero de tarjeta: ");
                int numero_cuenta = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(20, 7); Console.Write("El producto con precio $" + precio + " se ha pagado " +"con el numero de tarjeta " + numero_cuenta);

            }
            else if (forma.Equals("efectivo"))
            {
                Console.SetCursorPosition(20, 8); Console.Write("El producto con precio $" + precio + " se ha pagado");
            } else
                 {
                Console.SetCursorPosition(20, 9); Console.Write("La forma de pago no es correcta");
                    }
            Console.ReadLine();
        }
    }
}


