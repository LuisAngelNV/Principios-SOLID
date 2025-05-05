using System;

namespace PrinipiosSOLID._2_O_OCP
{
    public class EjemploDescuentoCompuesto
    {
        public static void MostrarEjemploDetallado()
        {
            Console.WriteLine("\nEjemplo detallado de DescuentoCompuesto:");
            Console.WriteLine("----------------------------------------");

            // Crear los descuentos individuales
            var descuentoNuevoCliente = new DescuentoNuevoCliente();
            var descuentoCumpleanos = new DescuentoCumpleanos();

            // Crear el descuento compuesto
            var descuentoCompuesto = new DescuentoCompuesto(
                descuentoNuevoCliente,
                descuentoCumpleanos
            );

            // Precio original
            decimal precioOriginal = 1000m;
            Console.WriteLine($"Precio original: {precioOriginal:C}");

            // Aplicar primer descuento
            decimal precioDespuesPrimerDescuento = descuentoNuevoCliente.CalcularDescuento(precioOriginal);
            Console.WriteLine($"Precio después del descuento de nuevo cliente (15%): {precioDespuesPrimerDescuento:C}");

            // Aplicar segundo descuento
            decimal precioFinal = descuentoCumpleanos.CalcularDescuento(precioDespuesPrimerDescuento);
            Console.WriteLine($"Precio después del descuento de cumpleaños (25%): {precioFinal:C}");

            // Aplicar descuento compuesto (debe dar el mismo resultado)
            Console.WriteLine("\nAplicando el descuento compuesto directamente:");
            decimal precioConDescuentoCompuesto = descuentoCompuesto.CalcularDescuento(precioOriginal);
            Console.WriteLine($"Precio final con descuento compuesto: {precioConDescuentoCompuesto:C}");

            // Demostrar que podemos usar cualquier combinación de descuentos
            Console.WriteLine("\nProbando diferentes combinaciones de descuentos:");
            
            // Combinación 1: Descuento de fin de semana + Descuento con límite
            var descuentoFinDeSemana = new DescuentoFinDeSemana();
            var descuentoConLimite = new DescuentoConLimite(0.30m, 200m);
            
            var descuentoCompuesto2 = new DescuentoCompuesto(
                descuentoFinDeSemana,
                descuentoConLimite
            );
            
            Console.WriteLine("\nCombinación: Descuento fin de semana (20%) + Descuento con límite (30% máximo 200):");
            decimal precioConCombinacion2 = descuentoCompuesto2.CalcularDescuento(precioOriginal);
            Console.WriteLine($"Precio final con esta combinación: {precioConCombinacion2:C}");
        }
    }
} 