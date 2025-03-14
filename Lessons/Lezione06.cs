// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione06
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 6: Chiedere un dato all'utente");

    // Finora abbiamo visto come generare un dato da scrivere nella console, così l'utente lo può leggere
    // Ma un programma serve di solito per elaborare dati, e da dove li prendiamo?
    // Una possibilità è quella di leggerli dalla console, dove li può scrivere l'utente

    // La funzione Console.WriteLine("...") ha bisogno di un argomento e non genera nessun risultato
    // perché scrive nella console
    // Mentre la funzione per leggere, Console.ReadLine() fa l'opposto, non ha bisogno di argomenti ma restituisce un risultato
    Console.WriteLine("Scrivi qualcosa e premi invio:");
    string? valore_letto = Console.ReadLine();
    //console.readLine è il calore della variabile "valore_letto
    // COSA E' QUEL PUNTO DI DOMANDA?!? 
    // CALMO. Se metti il mouse sopra ReadLine vedi che la funzione restituisce un dato di tipo string?
    // il punto di domanda significa che potrebbe anche non restituire alcun dato, piu avanti vedremo come gestire questo caso.

    // Esercizio 1: Scrivi qui di seguito una riga di codice che riscrive nella console il dato appena letto

    // Facciamo finta che vogliamo scrivere un programma che chiede all'utente due numeri e stampa la loro somma
    // Esercizio 2: Scrivi qui di seguito le righe di codice necessarie per leggere i due dati dall'utente
    Console.WriteLine("scrivi qualcosa e premi invio");
    string? valore1 = Console.ReadLine();
    Console.WriteLine("scrivi qualcosa e premi invio");
    string? valore2 = Console.ReadLine();
    
    // Esercizio 3: I dati che leggi tramite Console.ReadLine() sono stringhe, se le sommiamo col + cosa succede?
    // Prova qui di seguito e stampa il risultato:
    Console.WriteLine("la somma degli ultimi 2 valori dati è:");
    Console.WriteLine(valore1 + valore2);
  
    // Come si fa a trasformare una stringa in numero? Piu avanti magari proveremo a scrivere il codice che lo fa
    // per ora usiamo una funzione già disponibile nel linguaggio c#: Int32.Parse()
    // Prova a mettere il mouse sopra Parse, guarda che argomenti richiede e che valore restituisce
    var numero_interpretato_da_stringa = Int32.Parse("157");
    Console.WriteLine("Il numero interpretato deve essere 157, ed è: " + numero_interpretato_da_stringa);

    // Esercizio 4: Tutte le stringhe possono essere convertite in numeri? Proviamo a vedere, decommenta la
    //              seguente riga, mettiti al riparo ed esegui il codice, cosa succede?
    //var numero_invalido = Int32.Parse("3 porcellini");

    // Esercizio 5: Ora che abbiamo capito come interpretare il numero contenuto in una stringa, scrivi
    //              qui sotto il codice che somma i due numeri inseriti nell'esercizio 2 e mostra all'utente la somma
        

  }
}