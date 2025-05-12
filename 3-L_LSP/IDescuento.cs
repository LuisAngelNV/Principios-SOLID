using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._3_L_LSP
{
    // ----------------------------
    // 1. Descuentos (OCP + LSP)
    // ----------------------------
    public interface IDescuento
    {
        decimal Aplicar(decimal monto);
    }

    // Implementaciones concretas (SRP: una clase por tipo de descuento)
    public class DescuentoBlackFriday : IDescuento
    {
        public decimal Aplicar(decimal monto) => monto * 0.70m; // 30% off
    }

    public class DescuentoClienteVIPL : IDescuento
    {
        public decimal Aplicar(decimal monto) => monto * 0.85m; // 15% off
    }
    public class DescuentoPrimeraCompra : IDescuento
    {
        public decimal Aplicar(decimal monto) => monto * 0.90m; // 10% off
    }

    // ----------------------------
    // 2. Métodos de Pago (LSP)
    // ----------------------------
    public interface IMetodoPago
    {
        void ProcesarPago(decimal monto);
    }
    public class TarjetaCredito : IMetodoPago
    {
        public void ProcesarPago(decimal monto) => Console.WriteLine($"Pagado ${monto} con Tarjeta de Crédito");
    }

    public class PayPal : IMetodoPago
    {
        public void ProcesarPago(decimal monto) => Console.WriteLine($"Pagado ${monto} con PayPal");
    }
    // ----------------------------
    // 3. Envíos (LSP + OCP)
    // ----------------------------
    public interface IEnvio
    {
        void EnviarPedido();
    }

    public class EnvioEstandar : IEnvio
    {
        public void EnviarPedido() => Console.WriteLine("Envío estándar (3-5 días)");
    }

    public class EnvioExpress : IEnvio
    {
        public void EnviarPedido() => Console.WriteLine("Envío express (24 horas)");
    }


}
