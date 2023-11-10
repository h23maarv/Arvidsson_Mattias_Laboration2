namespace Arvidsson_Mattias_Labration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofRelativs;
            string[] nameofRelativs = new string[numberofRelativs];
            int[] ageofRelativs = new int[numberofRelativs];
            int averageAge = 0;

            Console.WriteLine("Ange antalet familjemedlemmar ");
            numberofRelativs = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < nameofRelativs.Length; i++)
            {
                Console.WriteLine($"Vad heter person nummer {i}? ");
                nameofRelativs[i] = Console.ReadLine();

                Console.WriteLine($"Hur gammal är person nummer {i}? ");
                ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 1; i < ageofRelativs.Length; i++)
            {
                averageAge += ageofRelativs[i];

            }

            Console.WriteLine("Gemensamt är alla " + averageAge + " gamla");
            double ageSum = averageAge;
            Console.WriteLine("Genomsnitt ålder är: " + ageSum);



        }
    }
}