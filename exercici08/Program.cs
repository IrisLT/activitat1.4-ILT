namespace exercici08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaració de variables
            int hores, minuts, segons, hhmmss;

            //Demanem valors d'entrada
            Console.WriteLine("Escriu una hora en format hhmmss:");
            hhmmss = Convert.ToInt32(Console.ReadLine());

            //Calculs
            hores = hhmmss / 10000;
            minuts = hhmmss / 100 % 100;
            segons = hhmmss % 100;

        }
        public static bool HoraValida(int h, int m, int s)
        {
            //vol un unic return
            bool HoraValida;
            if h >= 24 || h < 0 || m > 59 || m < 0 || s > 59 || s < 0
                HoraValida = false;
            else
                HoraValida = true;
            return HoraValida;



        }
    }
}
