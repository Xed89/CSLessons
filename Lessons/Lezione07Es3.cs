class Lezione07Es3
{
  public static void Run()
  {
    Console.WriteLine("Lezione 7, Esercizio 3");

    // Esercizio: Sfida del Tesoro
    Console.WriteLine("Benvenuto alla 'Sfida del Tesoro'!");
    Console.WriteLine("Sei un avventuriero che deve scegliere una porta per trovare il tesoro.");
    Console.WriteLine("Ci sono 3 porte: 1, 2 e 3. Solo una contiene il tesoro, le altre hanno trappole!");

    Random random = new Random();
    int portaTesoro = random.Next(1, 4); // Genera casualmente la porta con il tesoro

    /* 
      Scrivi il codice qui sotto che implementa il resto del gioco in modo che:
      1. Chiede all'utente di scegliere una porta tra 1, 2 e 3
      2. Se l'utente sceglie la porta giusta, stampa "Hai trovato il tesoro!"
      3. Se l'utente sceglie una porta sbagliata, stampa "Hai trovato una trappola!" e dica quale era la porta con il tesoro
      4. Se l'utente non sceglie una porta valida, stampa "Scelta non valida! Scegli una porta tra 1, 2 e 3."
    */
  }
}