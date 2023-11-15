namespace Arvidsson_Mattias_Labration1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            
            string[] nameofRelativs = new string[5];
            int[] ageofRelativs = new int[5];
            int ageSum = 0;

            for (int i = 1; i < nameofRelativs.Length; i++)
            {
                Console.WriteLine($"Vad heter person nummer {i}? ");
                nameofRelativs[i] = Console.ReadLine();

                Console.WriteLine($"Hur gammal är person nummer {i}? ");
                ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 1; i < ageofRelativs.Length; i++)
            {
                Console.WriteLine("{0} är {1} år gammal.", nameofRelativs[i], ageofRelativs[i]);
                ageSum += ageofRelativs[i];

            }

            Console.WriteLine("Gemensamt är alla " + ageSum + " gamla.");

            double averageAge = (double)ageSum / ageofRelativs.Length;
            Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);



        }
    }
}