using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sinisterra Luciano 2A - TP INTERFACES";


            //Aviones
            ///
            Privado aPrivado = new Privado(50000, 900, 8);
            Comercial aComercial = new Comercial(80000, 700, 20);

            Console.WriteLine("AVIONES");

            Console.WriteLine("Avion Privado:");
            aPrivado.MostrarPrecio();
            Console.WriteLine("Impuesto Nacional:" + (Gestion.MostrarImpuestoNacional(aPrivado)));
            Console.WriteLine("Impuesto Provincial:" + (Gestion.MostrarImpuestoProvincial(aPrivado))); 
            Console.WriteLine(" ");


            Console.WriteLine("Avion Comercial:");
            aComercial.MostrarPrecio();
            Console.WriteLine("Impuesto Nacional:" + (Gestion.MostrarImpuestoNacional(aComercial)));
            Console.WriteLine("Impuesto Provincial:" + (Gestion.MostrarImpuestoProvincial(aComercial)));
            Console.WriteLine("");
            Console.WriteLine(" ");

            ///Autos
            ///
            Deportivo aDeportivo = new Deportivo(5000, "ABC 123", 2);
            Familiar aFamiliar = new Familiar(1000, "QWE 456", 4);

            Console.WriteLine("AUTOS");

            Console.WriteLine("Auto deportivo:");
            aDeportivo.MostrarPatente();
            aDeportivo.MostrarPrecio();
            Console.WriteLine("Impuesto Nacional:" + (Gestion.MostrarImpuestoNacional(aDeportivo)));
            Console.WriteLine("Impuesto Provincial: " + (Gestion.MostrarImpuestoProvincial(aDeportivo)));
            Console.WriteLine(" ");

            Console.WriteLine("Auto Familiar:");
            aFamiliar.MostrarPatente();
            aFamiliar.MostrarPrecio();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            /// Carreta
            /// 
            Carreta carreta = new Carreta(100);

            Console.WriteLine("CARRETAS");

            Console.WriteLine("Una carreta:");
            carreta.MostrarPrecio();
            Console.WriteLine("Impuesto Provincial : " + (Gestion.MostrarImpuestoProvincial(carreta)));





            Console.ReadLine();

        }
    }
}
