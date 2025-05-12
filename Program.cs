using PrinipiosSOLID._1_S_SRP;
using PrinipiosSOLID._2_O_OCP;
using PrinipiosSOLID._3_L_LSP;
using PrinipiosSOLID._3_L_LSP.Reto;
using PrinipiosSOLID._4_I_ISP.Prueb;


Console.WriteLine("Principios de SOLID");
Console.WriteLine("_______________________________________");
Console.WriteLine("S - SRP");
Console.WriteLine("Single Responsibility Principle (SRP)");
Producto producto = new Producto { Nombre = "Laptop", Precio = 15000m };

CalculoDeImpuestos calculadora = new CalculoDeImpuestos();
decimal impuesto = calculadora.CalcularImpuesto(producto);
Console.WriteLine($"Impuesto: {impuesto}");

ImpresionDeFacturas impresora = new ImpresionDeFacturas();
impresora.ImprimirFactura(producto);

GuardarFacturas guardador = new GuardarFacturas();
guardador.GuardarFactura(producto);
Console.WriteLine("_______________________________________");
Console.WriteLine("O - OCP");
Console.WriteLine("Open/Closed Principle (OCP)");
//CalculadoraDePrecios CDP = new CalculadoraDePrecios();
//IDescuento descuento = new DescuentoFinDeSemana();
//CDP.AplicarDescuento(1000m, descuento);

// Mostrar ejemplos adicionales
Console.WriteLine("\nEjemplos adicionales de descuentos:");
EjemplosDeUso.MostrarEjemplos();

// Mostrar ejemplo detallado del descuento compuesto
Console.WriteLine("\nEjemplo detallado del descuento compuesto:");
EjemploDescuentoCompuesto.MostrarEjemploDetallado();
Console.WriteLine("_______________________________________");
Console.WriteLine("L - LSP");
Console.WriteLine("Liskov Substitution Principle (LSP)");
// Crear un pedido para un cliente VIP que paga con PayPal y quiere envío express
// Uso:
var pedidoNuevoCliente = new Pedido(
    descuentos: new DescuentoPrimeraCompra(),
    metodoPago: new TarjetaCredito(),
    envio: new EnvioEstandar()
);
pedidoNuevoCliente.Total = 500m;
pedidoNuevoCliente.Procesar();
Console.WriteLine("_______________________________________");
Console.WriteLine("L - LSP");
Console.WriteLine("Liskov Substitution Principle (LSP)");
Console.WriteLine("Reto de programacion");
List<IMetodoDePago> pagos = new List<IMetodoDePago>
{
    new SPTarjetaCredito(),
    new TrasferenciaBancaria(),
    new PagoEfectivo()
};

foreach (var metodo in pagos)
{
    metodo.ProcesarPago(150);
}
Console.WriteLine("_______________________________________");
Console.WriteLine("I - ISP");
Console.WriteLine("Interface Segregation Principle (ISP");
Console.WriteLine("Reto de programacion");
List<IImprimible> impresorasOficina = new List<IImprimible>
{
    new ImpresoraBasica(),
    new ImpresoraMultifuncional()
};

foreach (var impresoras in impresorasOficina)
{
    impresoras.ImpresionBasica();
}

List<IEscaneable> escaners = new List<IEscaneable>
{
    new Escaner(),
    new ImpresoraMultifuncional()
};

foreach (var escaneres in escaners)
{
    escaneres.ImpresionProfesional();
}
