using System;
using System.IO;

namespace Facturacion
{
    public class Factura
    {
        #region Atributos
        private string nameP, nameC, description;
        private int quantity, price, nProduct, nFactura, value, total, totalValue, menu;
        private string x;
        private string y;
        #endregion

        public Factura()
        { }
        public void getFactura()
        {

            nFactura++;
            // TextWriter archivo;
            //archivo = new StreamWriter("archivo.txt");
            Console.WriteLine("'x' para cerrar la factura");
            StreamWriter getF = File.AppendText("facturaFile.txt");
            getF.WriteLine("*************** Factura: #{0} **************", nFactura);
            getF.WriteLine("Colmado Joel");
            getF.WriteLine("Tel: 809-456-4564 | Cel: 829-456-7841 ");

            do
            {
                nProduct++;

                //obtener datos
                Console.WriteLine("Nonbre del producto");
                nameP = Console.ReadLine();
                Console.WriteLine("descripcion del producto");
                description = Console.ReadLine();
                Console.WriteLine("precio del producto");
                price = Console.Read();
                Console.WriteLine("Cantidad");
                quantity = Console.Read();

                //calculo
                //value = quantity * price;
                //totalValue += value;

                //imprecion
                getF.WriteLine("------------------------------------------");
                getF.WriteLine("Producto: #{0}", nProduct);
                getF.WriteLine("Nombre: {0}", nameP);
                getF.WriteLine("Descripcion: {0}", description);
                getF.WriteLine("Valor: {0}", value);
                getF.WriteLine("Cantidad: {0}", quantity);
                getF.WriteLine("Total: {0}", total);


                Console.WriteLine("'y' para continuar");
                y = Console.ReadLine();
                if (y == "y") { };
            }
            while (y == "y");
            {
                nProduct = 0;
                DateTime thisDay = DateTime.Today;
                Console.WriteLine("Nonbre del cliente");
                nameC = Console.ReadLine();

                getF.WriteLine("");
                getF.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
                getF.WriteLine("Nonbre del cliente: {0}", nameC);
                getF.WriteLine("Emicion de factura: ", thisDay.ToString());
                getF.WriteLine("Valor total: ", totalValue);
                getF.WriteLine("");
                getF.WriteLine("******************************************");
                getF.WriteLine("");
                getF.Close();
                Console.Clear();

                postFactura();

                /*Console.WriteLine("Desea facturar nuevamente?  'y' o 'n'");   
                x = Console.ReadLine();
                if (x == "y"){getFactura();}
                else{Console.WriteLine("bye");}*/
            }
        }

        public void postFactura()
        {
            TextReader readFactura;
            readFactura = new StreamReader("facturaFile.txt");
            Console.WriteLine(readFactura.ReadToEnd());
            readFactura.Close();
        }
    }
}








/*
using System.IO.StreamReader;

StreamWriter fichero;
fichero = File.CreateText("prueba.txt"); 

fichero.WriteLine("esto es una línea");
fichero.Write("fin de la cita.");
fichero.Close();

string linea;

fichero = File.OpenText("prueba.txt");
linea = fichero.ReadLine();
fichero.Close();*/





