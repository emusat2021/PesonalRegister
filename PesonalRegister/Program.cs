namespace PesonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Eugenias Restaurang Personal Register");
            Console.WriteLine("=====================================================");

            var listAnställda =  new List<Register>();
            bool registrera = true;

            while(registrera)
            {
                var registerAnställd = new Register();

                Console.WriteLine("Var snäll och lägg till anställdas FÖRNAMN: ");
                Console.WriteLine("---------------------------------------------");

                registerAnställd.FörNamn = Console.ReadLine().ToLower();

                Console.WriteLine($"Var snäll och lägg till {registerAnställd.FörNamn} EFTERNAMN: ");
                Console.WriteLine("---------------------------------------------");

                registerAnställd.EfterNamn = Console.ReadLine().ToLower();

                Console.WriteLine($"Var snäll och lägg till {registerAnställd.EfterNamn} LÖN: ");
                Console.WriteLine("---------------------------------------------");

                registerAnställd.Lön = Convert.ToInt32(Console.ReadLine());

                listAnställda.Add(registerAnställd);
                Console.WriteLine("===============================================");

                Console.WriteLine($"Anställd : {registerAnställd.FörNamn.ToUpper()}  {registerAnställd.EfterNamn.ToUpper()} LÖN: {registerAnställd.Lön}");

                Console.WriteLine("Vill du tillägga en ny anställd tryck ENTER annars tryck 'N' ");
                string fortsätt = Console.ReadLine().ToLower();

                if (fortsätt == "n")
                {
                    registrera = false;
                }

            }


            foreach( var anställd in listAnställda )
            {
                Console.WriteLine($"Förnamn: {anställd.FörNamn.ToUpper()} Efernamn: {anställd.EfterNamn.ToUpper()} Lön: {anställd.Lön}");
            }

        }
    }
}
