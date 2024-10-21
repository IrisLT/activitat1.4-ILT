namespace exercici10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio varaible
            int any;

            //valors inicials
            Console.Write("Escriu un any: ");
            any = Convert.ToInt32(Console.ReadLine());


            //calculs
            //Resultats
            if (any < 1700 || any > 2100)
                Console.WriteLine("Any invalid");
            else if (any >= 1701 && any <= 1800)
                Console.WriteLine("Segle XVIII");
            else if (any >= 1801 && any <= 1900)
                Console.WriteLine("Segle XIX");
            else if (any >= 1901 && any <= 2000)
                Console.WriteLine("Segle XX");
            else
                Console.WriteLine("Segle XXI");
        }
    }
}
