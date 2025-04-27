using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._1_S_SRP
{
    /* Mala practica en SRP
     * public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public decimal CalcularImpuesto()
    {
        return Precio * 0.16m;
    }

    public void ImprimirEtiqueta()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: {Precio}");
    }

    public void GuardarEnArchivo()
    {
        Console.WriteLine("Guardando información del producto en archivo...");
    }
}*/

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }

    public class  CalculoDeImpuestos
    {
        public decimal CalcularImpuesto(Producto producto)
        {
            Console.WriteLine("Calculando impuestos...");
            return producto.Precio* 0.16m;
        }
    }

    public class  ImpresionDeFacturas
    {
        public void ImprimirFactura(Producto producto)
        {
            Console.WriteLine("Imprimiendo factura...");
            Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio}");
        }
    }

    public class GuardarFacturas
    {
        public void GuardarFactura(Producto producto)
        {
            Console.WriteLine($"Guardando factura de {producto.Nombre} en la base de datos...");
        }
    }

}
