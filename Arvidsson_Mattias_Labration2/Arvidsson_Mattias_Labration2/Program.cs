namespace Arvidsson_Mattias_Labration2
{

    using System;
    internal class Program
    {
        static void Main(string[] args)
        {

            // Skapar arrayer för att lagra information.
            int menuSelect = 0;
            int numberofPeople = 0;
            string[] nameofRelativs = null;                       // Array för namn
            int[] ageofRelativs = null;                           // Array för åldrar
            int ageSum = 0;                                       // Variabel för att se totala ålderssumman

            while (menuSelect != 5)
            {

                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "\nVälj ett av alternativen: " +
                    "\n1.) Skriv in antal personer samt namn och ålder. " +
                    "\n2.) Skriv ut namn samt ålder. " +
                    "\n3.) Skriv ut den totala summan av de tillagda personers ålder. " +
                    "\n4.) Skriv ut genomsnitt åldern för de tillagda personerna. " +
                    "\n5.) Avsluta programmet. " +
                    "\n------------------------------------------------"
                    );

                menuSelect = Int32.Parse(Console.ReadLine());

                switch (menuSelect)
                {

                    case 1:

                        Console.WriteLine("Hur många personer vill du lägga till?");
                        numberofPeople = Convert.ToInt32(Console.ReadLine());

                        nameofRelativs = new string[numberofPeople];
                        ageofRelativs = new int[numberofPeople];

                        // Loop för att mata in namn och åldrar från användaren för varje person.
                        for (int i = 0; i < numberofPeople; i++)
                        {
                            Console.WriteLine($"Vad heter person nummer {i + 1}? ");
                            nameofRelativs[i] = Console.ReadLine();

                            Console.WriteLine($"Hur gammal är person nummer {i + 1}? ");
                            ageofRelativs[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        break;

                    case 2:

                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            // Loop för att skriva ut namnen och åldrarna för varje person samt räkna ålderssumman.
                            for (int i = 0; i < numberofPeople; i++)
                            {
                                Console.WriteLine("{0} är {1} år gammal.", nameofRelativs[i], ageofRelativs[i]);
                                ageSum += ageofRelativs[i];
                            }
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 3:

                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            // Loop för att skriva ut den totala ålderssumman för alla personer.
                            Console.WriteLine("Gemensamt är alla " + ageSum + " år gamla.");
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 4:

                        if (nameofRelativs != null && ageofRelativs != null)
                        {
                            // Beräknar genomsnittsåldern och skriver ut den med två decimaler.
                            double averageAge = (double)ageSum / ageofRelativs.Length;
                            Console.WriteLine("Genomsnitt ålder är: {0:0.00}.", averageAge);
                        }

                        else
                        {
                            Console.WriteLine("Inga personer har lagts till ännu. ");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Då avslutar vi programmet. ");

                        break;

                    default:

                        Console.WriteLine("Det är ett svar jag inte förstår... Du behöver ange en siffra mellan 1-5.\n");

                        break;
                }
 
            }

        }
    
    }

}