namespace exercici01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio varaible
            int nota;

            //valors inicials
            Console.Write("Escriu una nota: ");
            nota = Convert.ToInt32(Console.ReadLine());


            //calculs
            //Resultats
            if (nota < 0 || nota > 10)
                Console.WriteLine("Nota erronea");
            else if (nota < 5)
                Console.WriteLine("Suspès");
            else if (nota < 7)
                Console.WriteLine("Aprovat");
            //si nota fos double seria else if (nota<9)
            else if (nota == 7 || nota == 8)
                Console.WriteLine("Notable");
            else
                Console.WriteLine("Excel·lent");
        }
    }
}
