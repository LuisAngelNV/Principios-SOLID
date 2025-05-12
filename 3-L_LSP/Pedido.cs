using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._3_L_LSP
{
    public class Pedido
    {
        private readonly IDescuento _descuento;
        private readonly IMetodoPago _metodoPago;
        private readonly IEnvio _envio;

        public decimal Total { get; set; }

        // Inyección de dependencias (DIP)
        public Pedido(IDescuento descuentos, IMetodoPago metodoPago, IEnvio envio)
        {
            _descuento = descuentos;
            _metodoPago = metodoPago;
            _envio = envio;
        }

        public void Procesar()
        {
            decimal totalConDescuento = _descuento.Aplicar(Total);
            _metodoPago.ProcesarPago(totalConDescuento);
            _envio.EnviarPedido();
        }
    }
}
