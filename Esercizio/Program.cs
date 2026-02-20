using System;

class Program
{
    static string[] gusti = { "Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone" };
    static double[] prezzi = { 1,50, 1,20, 1,30, 2,00, 1,20 };

    static void StampaMenu()
    {
        Console.WriteLine("===== BENVENUTI IN GELATERIA =====");
        for (int i = 0; i < gusti.Length; i++)
        {
            Console.WriteLine($"{i} - {gusti[i]} : {prezzi[i]:0.00} € a pallina");
        }
        Console.WriteLine("====================================");
    }

        static void Main()
    {
        
    }



}
