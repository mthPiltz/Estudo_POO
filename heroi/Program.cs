namespace heroi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IronMan ironMan1 = new("Iron Main 1", "Iron Main 1", "21-09-2022", "Brasil", 12, 5, 11);
            IronMan ironMan2 = new("Iron Main 2", "Iron Main 2", "22-09-2022", "Brasil", 71, 7, 2); 
            IronMan ironMan3 = new("Iron Main 2", "Iron Main 2", "22-09-2022", "Brasil", 69, 1, 1);

            ironMan1.hurt(ironMan2);
            ironMan1.heal(ironMan3);

            Wolverine wolverine1 = new("Wolverine 1", "Wolverine 1", "21-09-2022", "Brasil", 12, 6000.00, 12);
            Wolverine wolverine2 = new("Wolverine 2", "Wolverine 2", "22-09-2022", "Brasil", 71, 7000.00, 9);
            Wolverine wolverine3 = new("Wolverine 3", "Wolverine 3", "22-09-2022", "Brasil", 69, 400.00, 65);

            wolverine1.hurt(wolverine2);
            wolverine1.heal(wolverine3);

            Ciclope ciclope1 = new("Ciclope 1", "Ciclope 1", "21-09-2022", "Brasil", 12, "Oakley");
            Ciclope ciclope2 = new("Ciclope 2", "Ciclope 2", "22-09-2022", "Brasil", 71, "HB");
            Ciclope ciclope3 = new("Ciclope 3", "Ciclope 3", "22-09-2022", "Brasil", 69, "Rayban");

            ciclope1.hurt(ciclope2);
            ciclope1.heal(ciclope3);

            Coringa coringa1 = new("Coringa 1", "Coringa 1", "21-09-2022", "Brasil", 12, "Indonesia");
            Coringa coringa2 = new("Coringa 2", "Coringa 2", "22-09-2022", "Brasil", 71, "Paquistão");
            Coringa coringa3 = new("Coringa 3", "Coringa 3", "22-09-2022", "Brasil", 69, "Pais de Gales");

            coringa1.hurt(coringa2);
            coringa1.heal(coringa3);

            Console.WriteLine("-----test Iron Man-----\n");

            Console.WriteLine("Iron Man 2 " + ironMan2.ResistenceLevel);
            Console.WriteLine(ironMan2.HealthCondition);
            Console.WriteLine("Iron Man 3 " + ironMan3.ResistenceLevel);
            Console.WriteLine(ironMan3.HealthCondition);
            Console.WriteLine("Armor: " + ironMan1.ArmorVersion);

            Console.WriteLine("\n-----test Wolverine-----\n");

            Console.WriteLine("Wolverine 2 " + wolverine2.ResistenceLevel);
            Console.WriteLine(wolverine2.HealthCondition);
            Console.WriteLine("Wolverine 3 " + wolverine3.ResistenceLevel);
            Console.WriteLine(wolverine3.HealthCondition);

            Console.WriteLine("\n-----test Ciclope-----\n");

            Console.WriteLine("Ciclope 2 " + ciclope2.ResistenceLevel);
            Console.WriteLine(ciclope2.HealthCondition);
            Console.WriteLine("Ciclope 3 " + ciclope3.ResistenceLevel);
            Console.WriteLine(ciclope3.HealthCondition);
            Console.WriteLine(ciclope2.EyewearBrand);

            Console.WriteLine("\n-----test Coring-----\n");

            Console.WriteLine("Coringa 2 " + coringa2.ResistenceLevel);
            Console.WriteLine(coringa2.HealthCondition);
            Console.WriteLine("Coringa 3 " + coringa3.ResistenceLevel);
            Console.WriteLine(coringa3.HealthCondition);

            Console.WriteLine("\n---test removed girlfirend");
            Console.WriteLine(ironMan1.Girlfriends);
            wolverine1.hurt(ironMan1);
            Console.WriteLine(ironMan1.Girlfriends);

            Console.WriteLine("\n--teste attack ciclope in wolverine--\n");
            Console.WriteLine(wolverine1.MinutesForHealing);
            ciclope1.hurt(wolverine1);
            Console.WriteLine(wolverine1.MinutesForHealing);
        }
    }
}