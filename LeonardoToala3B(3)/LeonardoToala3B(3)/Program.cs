using System;
using LeonardoToala3B_3_.Clases;
namespace LeonardoToala3B_3_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Tercer Nivel Cía. Ltda.");
            Console.WriteLine("\nIngrese Apellidos del cliente:");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese Nombres del cliente:");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese Número de Cédula del cliente:");
            cliente.Cédula = Console.ReadLine();
            Console.WriteLine("Ingrese Dirección del cliente:");
            cliente.Dirección = Console.ReadLine();

            Gasolina gasolina = new Gasolina();
            Console.WriteLine("\nIngrese el Tipo de Gasolina:");
            gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese Cantidad de Galones:");
            gasolina.Galones = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Precio de Venta:");
            gasolina.Precio = float.Parse(Console.ReadLine());

            Console.WriteLine("\nTercer Nivel Cía. Ltda.");
            Console.WriteLine("\nDetalle de Venta");
            Console.WriteLine("Cliente: {0} {1}",cliente.Apellidos,cliente.Nombres);
            Console.WriteLine("Número de Cédula del cliente: {0}",cliente.Cédula);
            Console.WriteLine("Dirección del cliente: {0}\n",cliente.Dirección);
            Console.WriteLine("Tipo de Gasolina: {0}",gasolina.Tipo);
            Console.WriteLine("Cantidad de Galones: {0}",gasolina.Galones);
            Console.WriteLine("Precio de Venta: {0}\n",gasolina.Precio);
            calculo();
            void calculo()
            {
                float subtotal, iva, total;
                subtotal = (gasolina.Galones * gasolina.Precio);
                Console.WriteLine("El Subtotal es: " + subtotal);
                iva = ((subtotal*12)/100);
                Console.WriteLine("El I.V.A es: " + iva);
                total = (subtotal + iva);
                Console.WriteLine("El Total a Cancelar es: " + total);
            }
            Console.ReadKey();
        }
    }
}
