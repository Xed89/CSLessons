// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
class Lezione03
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 3: Variabili parte 2");

    // Ora vediamo come fare un passo in più con le variabili, usarle in una espressione
    // Dichiariamo una variabile a cui assegnamo già un valore iniziale
    int valore1 = 8;
    // E un'altra a cui assegnamo il valore 9
    int valore2 = 9;

    // Una variabile può essere definita con la parola var al posto del tipo per lasciare al compilatore capire quale è
    // il tipo giusto in base al valore che gli dai
    var valore1_piu_valore2 = valore1 + valore2;

    // Esercizio 1: Cosa stamperà la riga seguente? prova a capirlo senza eseguire il programma, quindi eseguilo per verificare
    Console.WriteLine(valore1_piu_valore2);

    // Esercizio 2: Dichiara una variabile che si chiama sottrazione e assegnagli il valore di valore1 meno valore2 meno 7
  
    // Esercizio 3: Scrivi una riga di codice che scrive nella console il valore della variabile dell'esecizio 2
  }
}