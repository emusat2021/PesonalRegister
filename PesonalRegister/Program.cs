namespace PesonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Eugenias Restaurang Personal Register");

            Console.WriteLine("Var snäll och lägg till anställdas förnamn: ");
            string förNamn = Console.ReadLine();

            Console.WriteLine($"Var snäll och lägg till {förNamn} efternamn: ");
            string efterNamn = Console.ReadLine();

            Console.WriteLine($"Var snäll och lägg till {efterNamn} lön: ");
            string lön = Console.ReadLine();


        }
    }
}
