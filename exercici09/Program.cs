namespace exercici09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio varaible
            double nota, notaPractiques, notaExamen;

            //valors inicials
            Console.Write("Escriu la nota del examen: ");
            notaExamen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriu la nota de les practiques: ");
            notaPractiques = Convert.ToDouble(Console.ReadLine());

            //calculs
            nota = (0.8 * notaExamen) + (0.2 * notaPractiques);

            //Resultats
            if (nota < 0 || nota > 10)
                Console.WriteLine("Nota erronea");
            else if (nota < 5)
                Console.WriteLine("Suspès");
            else if (nota < 7)
                Console.WriteLine("Aprovat");
            //si nota fos double seria else if (nota<9)
            else if (nota >= 7 || nota <= 8)
                Console.WriteLine("Notable");
            else
                Console.WriteLine("Excel·lent");
        }
    }
}
