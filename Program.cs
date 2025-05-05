using PrinipiosSOLID._1_S_SRP;
using PrinipiosSOLID._2_O_OCP;


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

Usuario usuario = new Usuario { Email= "Antonio perez", Password= "ebkkenr"};
ServicioDeBaseDeDatos baseDeDatos = new ServicioDeBaseDeDatos();
baseDeDatos.GuardarUsuario(usuario);
ValidadorDePassword validador = new ValidadorDePassword();
validador.Validar(usuario.Password);
ServicioDeEmail servicioDeEmail = new ServicioDeEmail();
servicioDeEmail.EnviarBienvenida(usuario.Email);

Console.WriteLine("_______________________________________");
Console.WriteLine("O - OCP");
Console.WriteLine("Open/Closed Principle (OCP)");
CalculadoraDePrecios CDP = new CalculadoraDePrecios();
IDescuento descuento = new DescuentoFinDeSemana();
CDP.AplicarDescuento(1000m, descuento);

// Mostrar ejemplos adicionales
Console.WriteLine("\nEjemplos adicionales de descuentos:");
EjemplosDeUso.MostrarEjemplos();

// Mostrar ejemplo detallado del descuento compuesto
Console.WriteLine("\nEjemplo detallado del descuento compuesto:");
EjemploDescuentoCompuesto.MostrarEjemploDetallado();

public class Usuario
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class ServicioDeBaseDeDatos
{
    public void GuardarUsuario(Usuario usuario)
    {
        Console.WriteLine("Guardando usuario en la base de datos...");
    }
}

public class ValidadorDePassword
{
    public bool Validar(string password)
    {
        Console.WriteLine("Validando contraseña...");
        return true;
    }
}

public class ServicioDeEmail
{
    public void EnviarBienvenida(string email)
    {
        Console.WriteLine("Enviando correo de bienvenida a " + email);
    }
}

