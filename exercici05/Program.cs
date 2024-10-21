namespace exercici05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio varaible
            int numero;

            //valors inicials
            Console.Write("Digues un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());


            //calculs
            //Resultats
            if (numero%2==0)
                Console.WriteLine($"El numero {numero} es parell");
            else
                Console.WriteLine($"El numero {numero} es senar");
        }
    }
}
