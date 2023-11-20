namespace Arvidsson_Mattias_Labration2
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            Console.WriteLine("Hur många personer vill du lägga till?");
            int numberofPeople = Convert.ToInt32(Console.ReadLine());

            // Skapar två arrayer för att lagra namnen och åldrarna på personerna.
            string[] nameofRelativs = new string[numberofPeople]; // Array för namn
            int[] ageofRelativs = new int[numberofPeople];        // Array för åldrar
            int ageSum = 0;                                       // Variabel för att hålla totala ålderssumman

            while (numberofPeople > 0)
            {
                // Loop för att mata in namn och åldrar från användaren för varje person.
                for (int i = 0; i < nameofRelativs.Length; i++)
                {
                    Console.WriteLine($"Vad heter person nummer {i}? ");
                    nameofRelativs[i] = Console.ReadLine();

                    Console.WriteLine($"Hur gammal är person nummer {i}? ");
                    ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());

                }

                // Loop för att skriva ut namnen och åldrarna för varje person samt räkna ålderssumman.
                for (int i = 0; i < ageofRelativs.Length; i++)
                {
                    Console.WriteLine("{0} är {1} år gammal.", nameofRelativs[i], ageofRelativs[i]);
                    ageSum += ageofRelativs[i];

                }

                // Skriver ut den totala ålderssumman för alla släktingar.
                Console.WriteLine("Gemensamt är alla " + ageSum + " gamla.");

                // Beräknar genomsnittsåldern och skriver ut den med två decimaler.
                double averageAge = (double)ageSum / ageofRelativs.Length;
                Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);

                Console.WriteLine("Vill du fortsätta eller avsluta? ");
                char answer = (char)Console.Read();
                switch (answer)
                { 
                    
                }

                break;

            }

        }
    }
}