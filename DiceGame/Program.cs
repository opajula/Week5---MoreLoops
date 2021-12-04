using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringut;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem, on võitja
            //* täringuid visatakse 3 korda
            //programm kuulutab võitja


            Random rnd = new Random();

            int cpuScoreSUM = 0;
            int userScoreSUM = 0;

            int i = 0;

            for(i = 0; i < 3; i++)
            {
                Console.WriteLine("Vajutage klahvi, et täringut veeretada:");
                Console.ReadLine();

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                cpuScoreSUM = cpuScoreSUM + cpuRandom;
                userScoreSUM = userScoreSUM + userRandom;
            }
           
            Console.WriteLine($"Arvuti skoor on: {cpuScoreSUM}");
            Console.WriteLine($"Kasutaja skoor on: {userScoreSUM}");
            
            if(cpuScoreSUM < userScoreSUM)
            {
                Console.WriteLine("Kasutaja on võitnud. Palju õnne!");
            }
            else if(cpuScoreSUM > userScoreSUM)
            {
                Console.WriteLine("Arvuti võitis mängu.");
            }
            else
            {
                Console.WriteLine("Mäng on mängitud viiki!");
            }
            


        }
    }
}
