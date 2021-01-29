using System;

namespace Metoder_opg_1._10_H1
{
    class Program
    {
        static void Main(string[] args)
        {
                    /*10.	Gæt tallet
                            -	Lav et hemmeligt tilfældigt tal. 
                            -	Lad brugeren gætte tallet. 
                            -	Hvis brugeren gætter forkert skal I fortælle om tallet er højere eller lavere. 
                            -	Hold styr på hvor mange gæt brugeren har brugt, og brug passende ris/ros når tallet 
                                bliver gættet afhængig af antallet af forsøg.*/

               
            
            Random random = new Random();
            int terningskast = random.Next(1, 7);

            
            int antalGæt = GiveAnswer(terningskast);//Erklærer en variabel som vhja metodekald får værdien af hvor mange gæt der er brugt

            Console.WriteLine("Du brugte {0} gæt", antalGæt);
            
            Console.ReadKey();//"Fastholder programmet"
        }
        //opretter metode til at få brugerens gæt
        public static int GetTal(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());

        }
        //Opretter metode til at udskrive svar
        public static int GiveAnswer(int terningskast)
        {
            int antalGæt = 0;     //Erklærer variabel med værdien nul til at holde styr på hvor mange gæt der er brugt(tælles op i løkken)
            int svar;             //erklærer en variabel til svar da den også skal bruges uden for do løkken

            
            do                   //løkke så man kan blive ved med at gætte indtil man gætter rigtigt
            {
                svar = GetTal("Gæt et tal mellem 1 og 6!");//metodekald
                #region svar til bruger
                if (terningskast > svar)
                {
                    Console.WriteLine("Du gættede for lavt");
                    antalGæt++; //tæller antal gæt man har brugt op med 1 for hver gang
                }
                else if (terningskast < svar)
                {
                    Console.WriteLine("Desværre du gættede for højt");
                    antalGæt++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tillyke, du gættede rigtigt");
                    antalGæt++;
                }

                #endregion

            } while (svar != terningskast); //afbrydelse af løkken når man gætter rigtigt
            return antalGæt;

        }
    }
}