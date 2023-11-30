namespace Arvidsson_Mattias_Labration1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Skapar tre arrayer för att lagra namnen och åldrarna på personerna.
            string[] nameofRelativs = new string[5]; // Array för namn
            int[] ageofRelativs = new int[5];        // Array för åldrar
            int ageSum = 0;                          // Variabel för att hålla totala ålderssumman

            // Loop för att mata in namn och åldrar från användaren för varje person.
            for (int i = 1; i < nameofRelativs.Length; i++)
            {
                Console.WriteLine($"Vad heter person nummer {i}? ");
                nameofRelativs[i] = Console.ReadLine();

                Console.WriteLine($"Hur gammal är person nummer {i}? ");
                ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Loop för att skriva ut namnen och åldrarna för varje person samt räkna ålderssumman.
            for (int i = 1; i < ageofRelativs.Length; i++)
            {
                Console.WriteLine("{0} är {1} år gammal.", nameofRelativs[i], ageofRelativs[i]);
                ageSum += ageofRelativs[i];

            }

            // Skriver ut den totala ålderssumman för alla personer.
            Console.WriteLine("Gemensamt är alla " + ageSum + " år gamla.");

            // Beräknar genomsnittsåldern och skriver ut den med två decimaler.
            double averageAge = (double)ageSum / ageofRelativs.Length;
            Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);

        }
    }
}