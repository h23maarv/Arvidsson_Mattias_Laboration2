namespace Arvidsson_Mattias_Labration2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {

                Console.WriteLine("Hur många personer vill du lägga till?");
                int numberofPeople = Convert.ToInt32(Console.ReadLine());

                // Skapar tre arrayer för att lagra namnen och åldrarna på personerna.
                string[] nameofRelativs = new string[numberofPeople]; // Array för namn
                int[] ageofRelativs = new int[numberofPeople];        // Array för åldrar
                int ageSum = 0;                                       // Variabel för att hålla totala ålderssumman

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

                // Skriver ut den totala ålderssumman för alla personer.
                Console.WriteLine("Gemensamt är alla " + ageSum + " år gamla.");

                // Beräknar genomsnittsåldern och skriver ut den med två decimaler.
                double averageAge = (double)ageSum / ageofRelativs.Length;
                Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);
                //ändra till string
                char answer;
                Console.WriteLine("Vill du fortsätta eller avsluta? J eller N? ");

                do
                    {
                        // Console.WriteLine("Vill du fortsätta eller avsluta? J eller N? ");
                        //Ändra till Readline. Ändra till Ja och Nej istället för J och N.
                        answer = Char.ToLower((char)Console.Read());

                        switch (answer)
                        {

                            case 'j':
                                Console.WriteLine("Då börjar vi om ");
                                break;

                            case 'n':
                                Console.WriteLine("Då avslutar vi programmet ");
                                running = false;
                                break;

                            default:
                                Console.WriteLine("Det är ett svar jag inte förstår... ");
                                Console.WriteLine("Vill du fortsätta eller avsluta? J eller N? ");
                                //answer = Char.ToLower((char)Console.Read());
                                break;

                        }

                    }
                    while (answer != 'j' && answer != 'n');
            }

        }
    
    }

}