using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvidsson_Mattias_Labration3
{
    // En klass som representerar en person med olika attribut som kön, hår, födelsedatum och ögonfärg.
    public class Person
    {
        // Attribut för personens kön med en privat set-metod för att säkerställa inkapsling.
        public Gender Gender { get; private set; }
        // Attribut för personens hårdetaljer med en öppen set-metod för att kunna ändras.
        public Hair HairDetails { get; set; }
        // Attribut för personens födelsedatum med en privat set-metod för att säkerställa inkapsling.
        public DateTime Birthday { get; private set; }
        // Attribut för personens ögonfärg med en öppen set-metod för att kunna ändras.
        public string? EyeColor { get; set; }

        // Konstruktor som används för att skapa en instans av Person med specificerade attribut.
        public Person(Gender gender, Hair hair, DateTime birthdate, string eyeColor)
        {
            Gender = gender;
            HairDetails = hair;
            Birthday = birthdate;
            EyeColor = eyeColor;
        }
        // Överskriden ToString-metod för att skapa en strängrepresentation av objektet.
        public override string ToString()
        {
            return  $"Gender: {Gender}\n" +
                    $"Hair: Length - {HairDetails.HairLength}cm, Color - {HairDetails.HairColor}\n" +
                    $"Birthday: {Birthday.ToShortDateString()}\n" +
                    $"Eyecolor: {EyeColor}";
        }
    }
}
