using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    public class Matricula
    {
        public string Nombre {  get; set; }
        public int Estrato { get; set; }
        public double valorMatricula { get; set; }
        public double Descuento {  get; set; }
        public int Bono {  get; set; }  

        public void Inscripcion()
        {
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la matricula: ");
            valorMatricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el estrato del estudiante: ");
            Estrato = Convert.ToInt32(Console.ReadLine());
        }
        public void Liquidacion()
        {
            switch (Estrato) {
                case 1:
                    Descuento = valorMatricula * 0.80;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}");
                    break;
                case 2:
                    Descuento = valorMatricula * 0.50;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}");
                    break;
                case 3:
                    Descuento = valorMatricula * 0.50;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}");
                    break;

            }


        }

    }  
}
