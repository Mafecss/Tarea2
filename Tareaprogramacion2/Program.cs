using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaprogra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el costo de las camisas por unidad");
            float precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas que va a comprar");
            float camisas = float.Parse(Console.ReadLine());
            if (camisas <= 1)
            {
                float costo = camisas * precio;
                Console.WriteLine($"El precio de la camisa es de {costo} colones");
                Console.WriteLine();
            }
            else if (camisas > 1 && camisas <= 5)
            {
                float desc = (precio * camisas) * 0.15f;
                float costo = (precio * camisas) - desc;
                Console.WriteLine($"El precio de las camisas es de {costo} colones con un 15% de descuento");
                Console.WriteLine();
            }
            else if (camisas > 5)

            {
                float desc = (precio * camisas) * 0.20f;
                float costo = (precio * camisas) - desc;
                Console.WriteLine($"El precio de las camisas es de {costo} colones con un 20% de descuento");
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
