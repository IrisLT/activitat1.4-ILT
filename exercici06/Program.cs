namespace exercici06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomEquipLoc, nomEquipVis;
            int golsVisitant, golsLocal;

            Console.WriteLine("Nom equip local: ");
            nomEquipLoc=Console.ReadLine();
            Console.WriteLine("Nom equip visitant: ");
            nomEquipVis=Console.ReadLine();

            Console.WriteLine("Gols equip local: ");
            golsLocal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gols equip visitant: ");
            golsVisitant = Convert.ToInt32(Console.ReadLine());

            if (golsLocal > golsVisitant)
                Console.WriteLine($"{nomEquipLoc} ha guanyat al {nomEquipVis} amb un resultat de {golsLocal} a {golsVisitant}");
            else
                Console.WriteLine($"{nomEquipLoc} ha perdut contra {nomEquipVis} amb un resultat de {golsLocal} a {golsVisitant}");
        }
    }
}
