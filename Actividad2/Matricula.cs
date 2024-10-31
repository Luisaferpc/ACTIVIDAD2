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
        public int valorMatricula { get; set; }

        public void Inscripcion()
        {
            Console.WriteLine("Ingrese el nombre del estudiante");
        }

    }
}
