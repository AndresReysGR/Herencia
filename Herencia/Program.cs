using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //triangulo
            Triangulo triangulo = new Triangulo();
            triangulo.Color = "Amarilla";
            Console.WriteLine(triangulo.toString());
            triangulo.Altura = 2.5;
            triangulo.Base = 4;
            double areaTriangulo = triangulo.calcularArea();
            Console.WriteLine("Area Del Triangulo: " + areaTriangulo);

            //circulo
            Circulo circulo = new Circulo(5.4);
            Console.WriteLine("Area del circulo: " + circulo.calcularArea().ToString());

            //Variables de otra forma, al momento de tener clases predeterminadas
            Figura triangulo2 = new Triangulo();

            ((Triangulo)triangulo2).Base = 2;
            ((Triangulo)triangulo2).Altura = 3;

            Console.WriteLine("Area del triangulo 2: " + triangulo2.calcularArea().ToString());

            //Forma de enlistar
            List<Figura> figuras = new List<Figura>();

            figuras.Add(triangulo);
            figuras.Add(circulo);
            figuras.Add(triangulo2);

            foreach(var figura in figuras)
            {
                Console.WriteLine("Area de figura: " + figura.calcularArea().ToString());
            }

            Console.Read();
        }
        
    }
}
