// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione07
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 7: Il costrutto if");

    // Finora abbiamo visto come scrivere delle righe di codice che vengono eseguite sempre, in sequenza e senza eccezioni
    // Ma se volessimo, ad esempio, scrivere un programma che fa delle cose solo a determinate condizioni?
    // In nostro aiuto arriva il costrutto if, che si scrive così:
    if (1 < 3) // Tra parentesi, dopo l'if, va scritta una espressione il cui risultato è un bool, cioè un dato vero o falso
    {
      // Qui ci va il codice da eseguire quando la condizione è vera
      // Nota che puoi scrivere più righe, le parentesi graffe fanno da contenitore
      Console.WriteLine("Ramo 'vero': 1 è minore di 3");
    }
    else
    {
      // Qui ci va il codice da eseguire quando la condizione è falsa
      // Come puoi notare il compilatore ha sottolineato Console, prova a vedere cosa dice mettendo sopra il mouse
      Console.WriteLine("Ramo 'falso': 1 NON è minore di 3");
      // In pratica ti sta dando del pirla perché 1 è sempre minore di 3, che domande fai?
    }

    // E' possibile scrivere anche un if con solo il codice per il ramo 'vero':
    if (1 < 3)
    {
      // ... codice ...
    }

    // E tecnicamente si può anche scrivere senza le graffe se la riga di codice è una, ma è sconsigliato perché
    // si rischia di sbagliare
    // Esercizio 1: Nell'esempio qui di seguito mancano le parentesi graffe: secondo te che cosa stamperà a video?
    if (4 < 3)
      Console.WriteLine("1 è minore di 3: prima riga");
    Console.WriteLine("1 è minore di 3: seconda riga");


    // Esercizio 2: Scrivi un programma che legge un numero dalla console e scrive se questo numero è minore di 3

    // Esercizio 3: Cosa fa il seguente codice?
    Console.WriteLine("Scrivi il tuo nome:");
    var nome = Console.ReadLine();
    if (nome == "Antonio")
    {
      Console.WriteLine("Ciao Antonio lo gnomo!");
    }
    else
    {
      Console.WriteLine("Ciao " + nome + "!");
    }
  }
}