﻿using System;
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
        public double Bono {  get; set; }  

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
                    Bono = 200000;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}\n El bono de alimentación al que tiene derecho es de {Bono}");
                    
                    break;
                case 2:
                    Bono = 100000;
                    Descuento = valorMatricula * 0.50;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}\n El bono de alimentación al que tiene derecho es de {Bono}");
                    break;
                case 3:
                    Descuento = valorMatricula * 0.30;
                    Console.WriteLine($"Tiene un descuento por valor de {Descuento}");
                    break;
                }
            Console.WriteLine($"Señor(a) {Nombre} el total a pagar de su matricula es de {valorMatricula-Descuento}");


        }

    }  
}
