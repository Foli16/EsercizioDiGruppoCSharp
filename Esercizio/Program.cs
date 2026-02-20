using System;

class Program
{
    static void Main()
    {
        
    }

    private static double CalcolaTotale(int gusto, int quantita)
    {
        return arrayPrezzi[gusto] * quantita;
    }

    private static double ApplicaSconto(double totale)
    {
        double scontoApplicato = 0;
        if(totale > 10)
            scontoApplicato = totale*0.1;
        return scontoApplicato;
    }
}
