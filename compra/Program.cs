using System;

namespace compra
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCompra, valorFinal;
            string cupom;
            Console.WriteLine("Digita o valor da compra:");
            totalCompra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cupom desconto:");
            cupom = Console.ReadLine();

            if(totalCompra>1000 || cupom == "DESCONTO20")
            {
                valorFinal = totalCompra - (totalCompra * 0.2);

            }

            else
            {
                valorFinal = totalCompra;
            }
            Console.WriteLine("Total da compra:{0}", valorFinal.ToString("0.00"));
        }
    }
}
