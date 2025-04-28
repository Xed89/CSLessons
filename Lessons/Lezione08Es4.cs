class Lezione08Es4
{
  public static void Run()
  {
    Console.WriteLine("Lezione 8, Esercizio 4");

    /*
      AAaaAaAAhhh un DRAGOOOO!!!

      Questo esercizio è un gioco di ruolo in cui l'utente deve affrontare un drago.
      Gran parte del codice è già stato scritto, il tuo compito è capire come funziona e
      apportare le seguenti modifiche:
      1. Fare in modo che il drago attacchi ad ogni turno e infligga un danno casuale
         tra 10 e 30 HP all'avventuriero.
      2. Contare quanti attacchi hanno fatto rispettivamente il drago e l'avventuriero e 
         stampare il numero totale di attacchi alla fine del gioco.
      3. Fare in modo che la spada sia utilizzabile solo quando il drago ha meno di 150 HP.
         In caso contrario, avvicinarsi è troppo pericoloso e l'avventuriero deve usare l'arco.
      4. Se l'avventuriero ha meno di 50 HP, aggiungere una possibilità di bere una pozione curativa
         che ripristina 100 HP. La pozione può essere usata solo una volta e non è possibile
         usarla se il drago ha meno di 50 HP.
    */

    Console.WriteLine("Drago) Ciao avventuriero, come ti chiami?");
    string nome = Console.ReadLine()!;
    Console.WriteLine("Avventuriero) Il mio nome è " + nome + ", e tu che bestia sei?");
    Thread.Sleep(1000);
    Console.WriteLine("Drago) Sono Sfresnatpfirtsart e sono arrabbiatissimo perché nessuno legge mai davvero il mio nome!");
    Console.WriteLine("       Preparati allo scontro!");
    Thread.Sleep(1000); 

    Console.WriteLine("Avventuriero) Ma io non voglio combattere!");
    Thread.Sleep(1000);
    Console.WriteLine("Drago) Tardi, bastava leggere davvero il mio nome!");
    Thread.Sleep(1000);

    Random random = new Random();
    int vitaDrago = random.Next(100, 400); // Genera casualmente la vita del drago tra 100 e 400
    int vitaAvventuriero = random.Next(100, 400); // Genera casualmente la vita dell'avventuriero tra 100 e 400
    int round = 1;

    while (vitaDrago > 0 && vitaAvventuriero > 0)
    {
      Console.WriteLine("=== Round " + round + " ===");
      Console.WriteLine("Avventuriero  " + vitaAvventuriero + " HP");
      Console.WriteLine("Drago         " + vitaDrago + " HP");

      Console.WriteLine("> Vuoi usare la spada o l'arco? (Scrivi 's' o 'a' e premi invio)");
      string scelta = Console.ReadLine()!;
      if (scelta == "s")
      {
        Console.WriteLine("Avventuriero) Attacco con la spada!");
        int danno = random.Next(20, 40); // Genera casualmente il danno tra 20 e 40
        vitaDrago -= danno;
        Console.WriteLine("Hai inflitto " + danno + " danni al drago!");
      }
      else if (scelta == "a")
      {
        Console.WriteLine("Avventuriero) Attacco con l'arco!");
        int danno = random.Next(15, 35); // Genera casualmente il danno tra 15 e 35
        vitaDrago -= danno;
        Console.WriteLine("Hai inflitto " + danno + " danni al drago!");
      }
      else
      {
        Console.WriteLine("Scelta non valida! Devi scegliere 's' o 'a'.");
        continue; // Salta il resto del ciclo e inizia un nuovo round
      }


      // Attendi 1 secondo e stampa tre righe vuote prima di continuare
      Thread.Sleep(500);
      Console.Write(".");
      Thread.Sleep(500);
      Console.Write(".");
      Thread.Sleep(500);
      Console.WriteLine(".");
      Console.WriteLine();
    }
  } 
}