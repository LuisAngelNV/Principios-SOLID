using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._3_L_LSP.Reto
{
    //public class Vehiculo
    //{
    //    public string Marca { get; set; }

    //    public virtual void ImprimirReporte()
    //    {
    //        Console.WriteLine($"Reporte de vehículo de marca: {Marca}");
    //    }
    //}

    //public class Camion : Vehiculo
    //{
    //    public int CapacidadCarga { get; set; }

    //    public override void ImprimirReporte()
    //    {
    //        Console.WriteLine($"Camión marca: {Marca}, Capacidad de carga: {CapacidadCarga} kg");
    //    }
    //}

    //public class BicicletaElectrica : Vehiculo
    //{
    //    public override void ImprimirReporte()
    //    {
    //        throw new NotImplementedException("Las bicicletas eléctricas no necesitan un reporte de este tipo.");
    //    }
    //}

    /*
     * Mejor opcíon en cuanto a código limpio y SOLID
     * public interface IVehiculo
{
    void ImprimirReporte();
}

public class Camion : IVehiculo
{
    public string Marca { get; set; }
    public int CapacidadCarga { get; set; }

    public void ImprimirReporte()
    {
        Console.WriteLine($"Camión marca: {Marca}, Capacidad: {CapacidadCarga} kg");
    }
}

public class BicicletaElectrica : IVehiculo
{
    public string Marca { get; set; }

    public void ImprimirReporte()
    {
        Console.WriteLine($"Bicicleta eléctrica marca: {Marca}");
    }
}

     */

    public interface IMarca
    {
        void ImprimirMarca();
    }
    public interface ICapacidadCarga : IMarca
    {
        void ImprimirCapacidadCarga();
    }


    public class Camion : ICapacidadCarga
    {
        public string Marca { get; set; }
        public int CapacidadCarga { get; set; }
        public void ImprimirMarca()
        {
            Console.WriteLine($"Camión marca: {Marca}");
        }
        public void ImprimirCapacidadCarga()
        {
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} kg");
        }
    }

    public class BicicletaElectrica : IMarca
    {
        public string Marca { get; set; }
        public void ImprimirMarca()
        {
            Console.WriteLine($"Bicicleta eléctrica marca: {Marca}");
        }
    }
}
