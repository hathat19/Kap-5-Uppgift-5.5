using System;
namespace Uppgift5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            string[] answers = { "Ja, eller?", "NEJ", "Ingen chans!", "Du borde skaffa dig en hobby.", "Jag förstår inte.", "Vilken dum fråga!", "42 är lösningen.", "Fråga inte mig!", "Jag vet inte...", "Du slösar min tid!"};
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Skriv en fråga till den magiska biljardbollen! Om du skriver \"a\" så stängs programmet av.");
               
                //Stänga av?
                if (Console.ReadLine().ToLower() == "a")
                {
                    break; 
                }

                //Skriver ut ett slumpmässigt svar
                Console.WriteLine(answers[random.Next(0, (answers.Length))]);
            }
        }
    }
}
/*Skapa ett program som fungerar som leksaken ”Magic 8-ball”. Användaren ska få
ställa hur många frågor hen vill till programmet som ska svara med slumpmässigt valt
svar av 10 möjliga. Spara de 10 möjliga svaren i en array med strängar. Om
användaren skriver in ”a” när hen ska ställa en fråga ska programmet avslutas.*/