using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._2_O_OCP
{
    
    public interface IDescuento
    {
        decimal CalcularDescuento(decimal precioOriginal);
    }

    public class DescuentoVerano : IDescuento
    {
        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuento = precioOriginal * 0.10m;
            Console.WriteLine($"Descuento de verano aplicado: {descuento}");
            return precioOriginal - descuento;
        }
    }

    public class DescuentoFinDeSemana :IDescuento
    {
        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuento = precioOriginal * 0.20m;
            Console.WriteLine($"Descuento de fin de semana aplicado: {descuento}");
            return precioOriginal - descuento;
        }
    }
    public class DescuentoClienteVIP : IDescuento
    {
        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuento = precioOriginal * 0.30m;
            Console.WriteLine($"Descuento de cliente VIP aplicado: {descuento}");
            return precioOriginal - descuento;
        }
    }

    public class CalculadoraDePrecios
    {
        public void AplicarDescuento(decimal precioOriginal, IDescuento descuento)
        {
            decimal precioConDescuento = descuento.CalcularDescuento(precioOriginal);
            Console.WriteLine($"Precio original: {precioOriginal}, Precio con descuento: {precioConDescuento}");
        }
    }
}
