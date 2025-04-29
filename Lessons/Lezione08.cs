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
    while (1 > 3)
    {
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

      // Questa riga fa fermare il programma per 300 millisecondi, per evitare di intasare la console di A
      System.Threading.Thread.Sleep(300);
    }
    */

    // Ma a cosa può servire un costrutto del genere?
    // Possiamo come abbiamo visto prima usarlo per eseguire all'infinito del codice, ma anche per
    // eseguire del codice finché una condizione è vera, come ad esempio chiedere dei dati all'utente 
    // in continuazione, finché l'utente non decide di smettere
    // Vediamo un esempio pratico, scriviamo un programma che chiede un numero all'utente
    // e lo moltiplica per 7 usando però soltanto somme:
    Console.WriteLine("Scrivi un numero che vuoi moltiplicare per 7 e premi invio:");
    int numero = Int32.Parse(Console.ReadLine()!);
    // La variabile 'risultato' contiene il risultato della moltiplicazione
    // inizialmente è 0, perché non abbiamo ancora fatto nessuna somma
    int risultato = 0;
    // La variabile 'numero_di_somme' contiene il numero di somme che ci restano da fare
    // per ottenere il risultato della moltiplicazione
    // Inizialmente sono 7, perché vogliamo moltiplicare per 7
    int numero_di_somme = 7;
    while (numero_di_somme > 0)
    {
      // Somma al risultato il numero inserito dall'utente
      risultato = risultato + numero;

      // Per ogni somma che facciamo, dobbiamo diminuire il numero di somme da fare
      // Questa istruzione altera il valore di numero_di_somme, decrementandolo di 1
      // La condizione del while verifica che numero_di_somme sia maggiore di 0
      // e quindi il ciclo continua a ripetersi finché non abbiamo fatto 7 somme, 
      // perché il valore iniziale di numero_di_somme è 7
      numero_di_somme = numero_di_somme - 1;
    }
    Console.WriteLine("Il risultato di " + numero + "x7 è: " + risultato);

    // Fun fact: Può sembrare strano usare un while per fare una moltiplicazione, ma in realtà 
    //           i microcontrollori più scarsi impiegati in circuiti a basso costo a volte non hanno
    //           i circuiti per fare moltiplicazioni, e quindi fanno proprio così!

    // Esercizio 2: Metti un punto di interruzione (breakpoint) sulla riga iniziale qui sopra, 
    //              cioè quella che stampa "Scrivi un numero che vuoi moltiplicare ..."
    //              e poi esegui il programma in debug, cosa succede? 
    //              Prova a vedere come variano i valori delle variabili numero, numero_di_somme e risultato
    //              durante le varie ripetizioni del ciclo while.

    


    // Ora proviamo a scrivere il programma di una calcolatrice che fa le somme.
    // Come avrai capito, siccome il while continua a eseguire il codice finché la condizione è vera, ci dovrà
    // essere qualcosa nella condizione che cambia, che varia, come una... variabile?
    // Usiamo una variabile di nome 'finito' per determinare se abbiamo finito
    // Esercizio 3: Quali valori può avere la variabile 'finito'? Che tipo di dato possiamo usare? Dichiarala qui di seguito
    //              ps: sono scritti tutti nella lezione 5 :P

    // Esercizio 4: Decommenta il seguente codice e completalo

    /*
    // Scrivi qui la condizione, dobbiamo continuare a chiedere numeri e sommarli fintanto che...
    while ( )
    {
      // Qui riscrivi il codice che chiede e somma i numeri come alla lezione 6


       
      // Ora non ci resta che capire se continuare a chiedere numeri, come possiamo fare?
      // Suggerimento: Chiediamolo all'utente :P 
      //               Se l'utente non vuole continuare, questo codice deve cambiare una variabile 
      //               per uscire poi al prossimo ciclo del while
    }
    */
  }
}