// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione08
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 8: Il costrutto while");

    // Riprendiamo un esercizio che abbiamo visto nella lezione 6, la somma di due numeri
    // Se volessimo scrivere una calcolatrice che fa somme, e ne può fare tante?
    // Ci serve un modo per 'ripetere' del codice! Qualcuno ha detto while? no

    // Il costrutto while si scrive come l'if:
    while (1 > 3) {
      // Codice da eseguire finché la condizione è vera
      Console.WriteLine("Ciao Mamao 1!");
      Console.WriteLine("Ciao Mamao 2!");
      Console.WriteLine("Ciao Mamao 3!");
    }
    // Il codice viene valutato in questo modo:
    // Valuta la condizione: è vera
    // Esegue il codice tra le graffe, in modo sequenziale come al solito
    // Valuta la condizione di nuovo: è vera
    // Esegue il codice tra le graffe
    // ... avanti così finché la condizione rimane vera, ad un certo punto:
    // Valuta la condizione di nuovo: è falsa, continua dopo le graffe come succede per l'if quando la condizione è falsa
    // Nota: non esiste un else per il while

    // Esercizio 1: Che cosa fa il seguente codice? Prova a capirlo, poi decommentalo ed esegui per verificare.
    // ... Ricordati di ricommentarlo dopo :P
    /*
    Console.WriteLine("Pomodoro: 'Ciao roberto!'");
    Console.Write("Roberto: ");
    while (1 < 3) {
      Console.Write("A");
    }
    */
    //scrive "Pomodoro: 'ciao roberto!'" poi, in un altra riga scrive Roberto: " e se il 3 è maggiore dell'1 scrive "A"
    //all' infinito 
    // Ora proviamo a scrivere il programma della calcolatrice che fa le somme.
    // Come avrai capito, siccome il while continua a eseguire il codice finché la condizione è vera, ci dovrà
    // essere qualcosa nella condizione che cambia, che varia, come una... variabile?
    // Usiamo una variabile di nome 'finito' per determinare se abbiamo finito
    // Esercizio 2: Quali valori può avere la variabile 'finito'? Che tipo di dato possiamo usare? Dichiarala qui di seguito
    //              ps: sono scritti tutti nella lezione 5 :P
    //2
    bool chiedere = true; //(condizione falsa)
    // Esercizio 3: Decommenta il seguente codice e completalo
    
    // Scrivi qui la condizione, dobbiamo continuare a chiedere numeri e sommarli fintanto che...
    
    //while (chiedere)
    {
      // Qui riscrivi il codice che chiede e somma i numeri come alla lezione 6

      Console.Write("scrivi un numero e premi invio: ");
      string? Valore1_1 = Console.ReadLine();
      Console.Write("scrivi un numero e premi invio: ");
      string? Valore1_2 = Console.ReadLine();

      Console.Write("LA RISPOSTA è:");
      Console.WriteLine(Int32.Parse(Valore1_1)+Int32.Parse(Valore1_2));
       
      // Ora non ci resta che capire se continuare a chiedere numeri, come possiamo fare?
      // Suggerimento: Chiediamolo all'utente :P 
      //               Se l'utente non vuole continuare, questo codice deve cambiare una variabile 
      //               per uscire poi al prossimo ciclo del while
      Console.WriteLine("vuoi altri calcoli? scrivi 1 se la risposta è si scrivi 2 se la risposta è no");
      string? risposta = Console.ReadLine();
      if(risposta == "2")
      {
        chiedere = false;
      }
    }
    
  }
}