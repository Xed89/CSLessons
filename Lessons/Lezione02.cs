// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione02
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 2: Variabili parte 1");

    // Nella lezione 1 abbiamo visto come si fa a chiamare un metodo (funzione) predefinita per scrivere nella console
    // In questa lezione vedremo che cosa sono e a cosa servono le variabili

    // Una variabile è una posizione nella memoria a cui diamo un nome, e che possiamo usare come contenitore per un dato

    // Per definire una variabile bisogna decidere che tipo contiene e che nome deve avere, in questo modo:
    int una_variabile;
    // int è il tipo, un numero intero
    // una_variabile è il nome, puoi deciderlo tu, deve cominciare con una lettera e può contenere lettere, numeri e _
    // Come puoi vedere la variabile viene sottolineata, perché il compilatore dice 
    // 'aoh una variabile ok, ma se non ci fai niente che la dichiari a fare?'

    // Esercizio 1:
    // Metti il mouse sopra la variabile una_variabile qui sopra, e leggi la spiegazione del perché è sottolieata

    // In effetti una variabile ha senso solo se ci mettiamo dentro qualcosa, e si fa con l'operatore di assegnazione
    // che per mancanza di originalità è l'uguale

    // Esercizio 2: Prova a decommentare la seguente riga e vedi cosa succede alla sottolineatura sopra
    //una_variabile = 7;
    // E' sparita? che cosa dice ora se ci vai sopra?

    // In effetti neanche salvare un numero in memoria per poi non leggerlo mai più non ha molto senso.
    // Esercizio 3: Pensa fortissimo alla lezione 1 e scrivi una riga di codice che scrive nella console il valore
    //              della variabile una_variabile

    // ATTENZIONE! la soluzione non è Console.WriteLine("una_variabile");
    //             ma ti consiglio di provarla e vedere cosa succede se la esegui con F5
 }
}