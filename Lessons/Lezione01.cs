// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione01
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    // Questo è un commento su una riga
    /*
    Questo è un commento
    su più righe
    */

    // Ciò che scrivi in un commento viene ignorato

    // Come scrivere un testo nella console:
    Console.WriteLine("Hello, World!");
    //                    ^ Questo testo tra virgolette doppie è una stringa, cioè un testo

    // Tra virgolette singole invece è un singolo carattere
    Console.WriteLine('T');

    // Prova a premere il tasto F5 per eseguire il codice e guarda cosa scrive nella console.

    // Esercizio 1: Scrivi qui sotto una riga di codice che scrive nella console il testo "Ciao, mondo!"
    //              poi premi F5 nuovamente e guarda cosa scrive.


    /*
    Un programma è composto da una sequenza di istruzioni che vengono eseguite, appunto, in sequenza
    cioè una dopo l'altra.
    Come puoi notare, sopra la riga che scrive "Hello, World!" è prima di quella che scrive 'T'
    e quando esegui il programma infatti questo ordine viene rispettato.

    Analizziamo la riga di codice scritta sopra:
    Console.WriteLine("Hello, World!");      <- il ; alla fine di una riga indica il termine dell'istruzione
      ^        ^          ^
      |        |       Tra parentesi si indicano gli argomenti, cioè i dati che un metodo richiede
      |        |       In questo caso WriteLine richiede un unico argomento di tipo stringa, che è il 
      |        |       testo da scrivere nella console
      |        |
      |     WriteLine è un metodo, cioè un pezzo di codice che può essere eseguito 
      |     e che fa qualcosa di specifico: in questo caso scrivere una riga nella console
      |
     Console è una classe, simile a quello che in Gamemaker sono gli oggetti
     il nome richiama ciò che fa questa classe: gestire la console, cioè il testo
     che un programma genera come output e il testo che può ricevere in input

    */

    // Esercizio 2: 
    // Prova qui sotto a scrivere Console. (si anche il punto) e guarda che metodi la classe Console mette a disposizione
    // Prova a vedere se ne vedi uno che genera un suono, quindi testalo.


  }
}