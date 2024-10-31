using Actividad2;

public class Program
{
    public static void Main(string[] args)
    {
        int totalPagar;
        bool confirmar = true;

    Matricula factura = new Matricula();

        do {
            factura.Inscripcion();
            factura.Liquidacion();


        }while( confirmar );



    }
}