using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /* mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
             * mõlemad mängijad viskavad täringuid;
             * programm kontrollib, kumb mängija viskas rohkem
             * mängija, kes viskab rohkem, ongi mängu võitja
             * täringuid visatakse kolm korda
             * programm kuulutab võitja
             */
            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
              
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    
                    userScore = userScore + 1;
                    Console.WriteLine($"Arvuti skoor on: {cpuScore}. Kasutaja skoor on: {userScore}.");
                }
                else if (cpuRandom > userRandom)
                {
                    
                    cpuScore = cpuScore + 1;
                    Console.WriteLine($"Arvuti skoor on: {cpuScore}. Kasutaja skoor on: {userScore}.");
                }
                else
                {
                    Console.WriteLine($"Arvuti skoor on: {cpuScore}. Kasutaja skoor on: {userScore}.");
                }
            }
            if(cpuScore > 2 || cpuScore == 2 || userScore == 0)
            {                
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else if(cpuScore == userScore)
            {
                Console.WriteLine("Viik");
                
            }
            else
            {
                Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
            }
           

        }
    }
}
