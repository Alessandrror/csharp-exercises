using System;
using FundamentosCSHARP_2.Models;

//namespace FundamentosCSHARP_2
//{
//    class Program
//    {
//        static void Main(String[] args)
//        {
//            Bebida bebida = new Bebida("Coca Cola", 1000);
//            bebida.Beberse(500);
//            Console.WriteLine(bebida.Cantidad);
//        }
//    }
//}

namespace FundamentosCSHARP_2
{
    class Program
    {
        static void Main(String[] args)
        {
            Cerveza cerveza = new Cerveza();
            cerveza.Beberse(10);
        }
    }
}