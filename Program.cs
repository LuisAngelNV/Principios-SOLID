using PrinipiosSOLID._1_S_SRP;

Producto producto = new Producto { Nombre = "Laptop", Precio = 15000m };

CalculoDeImpuestos calculadora = new CalculoDeImpuestos();
decimal impuesto = calculadora.CalcularImpuesto(producto);
Console.WriteLine($"Impuesto: {impuesto}");

ImpresionDeFacturas impresora = new ImpresionDeFacturas();
impresora.ImprimirFactura(producto);

GuardarFacturas guardador = new GuardarFacturas();
guardador.GuardarFactura(producto);
