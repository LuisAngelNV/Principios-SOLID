using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinipiosSOLID._4_I_ISP.Prueb
{
    public interface IImprimible
    {
        void ImpresionBasica();
    }

    public interface IEscaneable
    {
        void ImpresionProfesional();
    }

    public interface IFaxeable
    {
        void Multifuncional();
    }

    public class ImpresoraBasica : IImprimible
    {
        public void ImpresionBasica()
        {
            Console.WriteLine("Imprimiendo desde la impresora básica.");
        }
    }

    public class Escaner : IEscaneable
    {
        public void ImpresionProfesional()
        {
            Console.WriteLine("Escaneando desde el escáner.");
        }
    }

    public class ImpresoraMultifuncional : IImprimible, IEscaneable, IFaxeable
    {
        public void ImpresionBasica()
        {
            Console.WriteLine("Imprimiendo desde la impresora multifuncional.");
        }
        public void ImpresionProfesional()
        {
            Console.WriteLine("Escaneando desde la impresora multifuncional.");
        }
        public void Multifuncional()
        {
            Console.WriteLine("Enviando fax desde la impresora multifuncional.");
        }
    }
}
