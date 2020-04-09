using System;

namespace Facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario us = new Usuario();
            bool vl = us.login();

            if(vl == true)
            {
                menu();
            }
        }

        public static void menu()
        {
            Factura ft = new Factura(); 
            Console.WriteLine("");
            Console.WriteLine("****************** Menu ****************");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*         1. Para facturar             *");
            Console.WriteLine("*         2. Mostrar Fichero           *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("****************************************");
                 
            string option = Console.ReadLine();
            switch(option)
            {
              case "1":
                ft.getFactura();
              break;
              case "2":
                ft.postFactura();
              break;


            }
        }
    }
}
