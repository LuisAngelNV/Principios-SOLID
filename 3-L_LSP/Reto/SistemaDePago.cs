using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._3_L_LSP.Reto
{
    public interface IMetodoDePago
    {
        /// <summary>
        /// Agregregar atributo de verificacion de fondos
        /// </summary>
        /// 
        bool ProcesarPago(decimal monto);
    }

    public interface IVerficarFondos
    {
        double VerificarFondos();
    }

    // Clases de formas de pago
    public class SPTarjetaCredito : IMetodoDePago, IVerficarFondos
    {
        public double FondosDisponibles { get; set; } = 1000;

        public bool ProcesarPago(decimal monto)
        {
            if (VerificarFondos() >= (double)monto)
            {
                Console.WriteLine($"Pago de {monto} procesado con tarjeta.");
                return true;
            }
            Console.WriteLine("Fondos insuficientes en la tarjeta.");
            return false;
        }

        public double VerificarFondos()
        {
            return FondosDisponibles;
        }
    }


    public class TrasferenciaBancaria : IMetodoDePago, IVerficarFondos
    {
        public double FondosDisponibles { get; set; } = 1000;

        public bool ProcesarPago(decimal monto)
        {
            if (VerificarFondos() >= (double)monto)
            {
                Console.WriteLine($"Pago de {monto} procesado por transferencia bancaria.");
                return true;
            }
            Console.WriteLine("Fondos insuficientes para la transferencia bancaria.");
            return false; 
        }

        public double VerificarFondos()
        {
            return FondosDisponibles;
        }
    }


    public class PagoEfectivo : IMetodoDePago
    {
        public bool ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Pago en efectivo recibido: {monto}");
            return true;
        }
    }

}
