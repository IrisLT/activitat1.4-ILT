namespace exercici11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angle;
            string quadrant;
        }

        static string Quadrant (int valor)
         //les variables que hi ha a un metode son independents del principal
        { //la variable calcula un int i torna un string
            valor = valor % 360; //angles superiors a 360
            if (valor < 0)
                valor += 360; //suma al negatiu 360 unitats, ho transforma en un angle en positiu

        }
    }
}
