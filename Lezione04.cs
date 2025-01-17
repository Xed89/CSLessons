// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione04
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 4: Variabili parte 3");

    // Le variabili possono cambiare valore, infatti se scrivo:
    int valore1 = 8;
    // e poi
    valore1 = 9;
    // Inizialmente la variabile valore1 avrà valore 8 ma poi cambia in 9

    // Esercizio 1: Osserva qui sopra la riga della dichiarazione della variabile int valore1 = 8;
    //              Che cosa noti? 
    //              Se metti il mouse sopra la variabile valore1 in quella riga, che cosa ti dice il compilatore?
    //              Perché secondo te da quel messaggio?

    // Esercizio 2: Che cosa scriveranno nella console le seguenti righe?
    int valore2 = 12 + 3;
    Console.WriteLine(valore2);
    valore2 = valore2 + valore1 - 1;
    Console.WriteLine(valore2);

    // Esercizio 3: Hai le due variabili seguenti:
   var valoreA = 7;
   var valoreB = 9;
    // Scrivi qui di seguito il codice necessario per scambiare i valori delle due variabili:

    // Suggerimento: Pensa a come faresti se le due variabili fossero secchielli, uno con pittura rossa, l'altro blu
    // Quando eseguirai il codice, se hai scritto giusto, vedrai stampati i valori scambiati:
    Console.WriteLine("Il valore della variabile 'valoreA' deve essere 9, ed è: " + valoreA);
    Console.WriteLine("Il valore della variabile 'valoreB' deve essere 7, ed è: " + valoreB);
  }
}