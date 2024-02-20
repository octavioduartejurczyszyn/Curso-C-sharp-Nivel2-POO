using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Último
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro();
            p1.Nombre = "ringo";
            p1.Origen = "pichcichu";
            p1.Color = "blanco y marrón";

            Console.WriteLine("El nombre del perro es " + p1.Nombre + ", su origen " + p1.Origen + " y su color es " + p1.Color);
            Console.ReadKey();

        }
    }
}
