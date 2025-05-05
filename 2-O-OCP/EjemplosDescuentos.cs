using System;

namespace PrinipiosSOLID._2_O_OCP
{
    // Ejemplo 1: Diferentes tipos de descuentos
    public class DescuentoNuevoCliente : IDescuento
    {
        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuento = precioOriginal * 0.15m; // 15% de descuento
            Console.WriteLine($"Descuento de nuevo cliente aplicado: {descuento}");
            return precioOriginal - descuento;
        }
    }

    public class DescuentoCumpleanos : IDescuento
    {
        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuento = precioOriginal * 0.25m; // 25% de descuento
            Console.WriteLine($"Descuento de cumpleaños aplicado: {descuento}");
            return precioOriginal - descuento;
        }
    }

    // Ejemplo 2: Descuento compuesto (combina dos descuentos)
    public class DescuentoCompuesto : IDescuento
    {
        private readonly IDescuento _primerDescuento;
        private readonly IDescuento _segundoDescuento;

        public DescuentoCompuesto(IDescuento primerDescuento, IDescuento segundoDescuento)
        {
            _primerDescuento = primerDescuento;
            _segundoDescuento = segundoDescuento;
        }

        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal precioConPrimerDescuento = _primerDescuento.CalcularDescuento(precioOriginal);
            return _segundoDescuento.CalcularDescuento(precioConPrimerDescuento);
        }
    }

    // Ejemplo 3: Descuento con límite máximo
    public class DescuentoConLimite : IDescuento
    {
        private readonly decimal _porcentajeDescuento;
        private readonly decimal _limiteMaximo;

        public DescuentoConLimite(decimal porcentajeDescuento, decimal limiteMaximo)
        {
            _porcentajeDescuento = porcentajeDescuento;
            _limiteMaximo = limiteMaximo;
        }

        public decimal CalcularDescuento(decimal precioOriginal)
        {
            decimal descuentoCalculado = precioOriginal * _porcentajeDescuento;
            decimal descuentoFinal = Math.Min(descuentoCalculado, _limiteMaximo);
            Console.WriteLine($"Descuento con límite aplicado: {descuentoFinal} (límite: {_limiteMaximo})");
            return precioOriginal - descuentoFinal;
        }
    }

    // Clase para demostrar el uso de los diferentes descuentos
    public class EjemplosDeUso
    {
        public static void MostrarEjemplos()
        {
            Console.WriteLine("\nEjemplos de diferentes tipos de descuentos:");
            Console.WriteLine("----------------------------------------");

            // Ejemplo 1: Uso básico de diferentes descuentos
            decimal precioOriginal = 1000m;
            CalculadoraDePrecios calculadora = new CalculadoraDePrecios();

            Console.WriteLine("\n1. Descuento de nuevo cliente:");
            IDescuento descuentoNuevoCliente = new DescuentoNuevoCliente();
            calculadora.AplicarDescuento(precioOriginal, descuentoNuevoCliente);

            Console.WriteLine("\n2. Descuento de cumpleaños:");
            IDescuento descuentoCumpleanos = new DescuentoCumpleanos();
            calculadora.AplicarDescuento(precioOriginal, descuentoCumpleanos);

            // Ejemplo 2: Descuento compuesto
            Console.WriteLine("\n3. Descuento compuesto (nuevo cliente + cumpleaños):");
            IDescuento descuentoCompuesto = new DescuentoCompuesto(
                new DescuentoNuevoCliente(),
                new DescuentoCumpleanos()
            );
            calculadora.AplicarDescuento(precioOriginal, descuentoCompuesto);

            // Ejemplo 3: Descuento con límite
            Console.WriteLine("\n4. Descuento con límite máximo de 200:");
            IDescuento descuentoConLimite = new DescuentoConLimite(0.30m, 200m);
            calculadora.AplicarDescuento(precioOriginal, descuentoConLimite);
        }
    }
} 