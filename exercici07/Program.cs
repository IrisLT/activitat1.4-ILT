namespace exercici07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocitat;
            Console.WriteLine("Diga'm la velocitat a la que anaves: ");
            velocitat = Convert.ToInt32(Console.ReadLine());

            //Resultats
            if (velocitat < 80 && velocitat > 0)
                Console.WriteLine("Sense sanció");
            else if (velocitat >= 80 && velocitat <= 99)
                Console.WriteLine("100 euros de multa");
            else if (velocitat >= 100 && velocitat <= 129)
                Console.WriteLine("300 euros de multa");
            else (velocitat >= 130)
                Console.WriteLine("600 euros de multa i retirada del carnet");
        }
    }
}
