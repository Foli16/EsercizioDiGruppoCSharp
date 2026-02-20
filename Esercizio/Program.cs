class Program
{
    static void Main(string[] args)
    {
        StampaMenu();

        double totaleAccumulato = 0;
        string riepilogoScontrino = "";
        bool continua = true;

        while (continua)
        {
            // Faccio scegliere il gusto (+ controllo errore)
            Console.Write("Scegli il numero del gusto: ");
            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta >= gusti.Length)
            {
                Console.Write("Indice non valido! Riprova: ");
            }

            // Faccio scegliere la quantità (+ controllo errore)
            Console.Write($"Quante palline di {gusti[scelta]} vuoi? ");
            int qta;
            while (!int.TryParse(Console.ReadLine(), out qta) || qta <= 0)
            {
                Console.Write("Inserisci una quantità valida (maggiore di 0): ");
            }

            // Calcolo parziale e aggiunta al riepilogo
            double parziale = CalcolaTotale(scelta, qta);
            totaleAccumulato += parziale;
            riepilogoScontrino += $"- {gusti[scelta]} (x{qta}): {parziale:F2}€\n";

            // Chiedo se desidera continuare
            Console.Write("Vuoi aggiungere altro? (s/n): ");
            string risposta = Console.ReadLine().ToLower();
            if (risposta != "s") continua = false;
        }

        // Gestione Finale e Sconto
        double sconto = ApplicaSconto(totaleAccumulato);
        double totaleFinale = totaleAccumulato - sconto;

        Console.WriteLine("\n=== RIEPILOGO FINALE ===");
        Console.Write(riepilogoScontrino);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Subtotale:      {totaleAccumulato:F2}€");
        if (sconto > 0) Console.WriteLine($"Sconto (10%):  -{sconto:F2}€");
        Console.WriteLine($"TOTALE NETTO:   {totaleFinale:F2}€");
        Console.WriteLine("\nGrazie e arrivederci!\n");
        Console.WriteLine("======================================");
    }
}
