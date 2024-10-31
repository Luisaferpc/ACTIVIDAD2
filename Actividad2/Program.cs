using Actividad2;

public class Program
{
    public static void Main(string[] args)
    {
        string respuesta;
        bool confirmar = true;

    Matricula factura = new Matricula();

        do {
            factura.Inscripcion();
            factura.Liquidacion();
            Console.WriteLine("Desea matricular otro estudiante? (s/n): ");
            respuesta = Console.ReadLine();
            if (respuesta == "n")
            {
                confirmar = false;
                Console.WriteLine("Su matricula ha terminado!");
            }


        }while( confirmar );



    }
}