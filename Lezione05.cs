// Ignora queste prime 4 righe e le ultime 2 parentesi graffe chiuse, in una lezione successiva capirai cosa sono
using System.Data.SqlTypes;

class Lezione05
{
  public static void Run()
  {
    // >>>    Inizia a leggere da qui    <<<<

    Console.WriteLine("Lezione 5: Variabili parte 4");

    // Finora abbiamo visto come dichiarare variabili di tipo intero
    // Ma esiste solo il tipo intero? Ovvio che no, sennò mica ci facevo una lezione.

    // I numeri sono infiniti, la memoria del computer no, quindi ad un certo punto bisogna decidere
    // di fermarsi e capire che numeri vogliamo usare nei nostri programmi, quanti ce ne servono?
    // Le variabili sono come delle scatole per i dati, se abbiamo dati piccoli bastano scatole piccole
    // per dati più cicciotti ci serviranno scatole più cicciotte che occupano quindi più memoria.

    // Il linguaggio C# mette a disposizione diversi tipi, chiamati 'tipi primitivi'(uga uga banga banga), che puoi
    // usare per contenere diversi tipi di dati, li vediamo in ordine di dimensione:

    // Il più piccolo è il byte
    // Contiene numeri da 0 a 255, solo positivi
    byte variabile_byte = 120;

    // C'è anche la versione per i negativi, che occupa sempre un byte
    // quindi può rappresentare sempre 256 valori distinti
    // Di conseguenza non va da 0 a 255
    // ma da -128 a 127 (Se fai i conti sono sempre 256 valori)
    sbyte variabile_byte_con_segno = -120;

    // Lo step successivo sono due byte, gli interi corti, o in inglese short
    // Da qui in poi le variabili numeriche hanno di default il segno ed esiste la variante senza segno
    // al contrario di quanto succede con byte/sbyte dove la variante con segno è l'eccezione, perché non si usa quasi mai.
    // Può contenere valori da -32768 a 32767
    short variabile_short = 3458;
    // Variante senza segno (la u all'inizio sta per unsigned) occupa sempre 2 byte
    // Però puà rappresentare il doppio dei numeri positivi, da 0 a 65535
    ushort variabile_ushort = 3458;

    // Lo step successivo è... PLOT TWIST 4 byte, non si somma uno ma si raddoppia!
    // Può contenere valori da -2147483648 a 2147483647
    // Cioè circa da meno due miliardi a più due miliardi... e qualcosa :P 
    // Come mai questi numeri strani e così precisi? Lo capiremo più avanti per ora fidati!
    int variabile_intera = 123456789;
    // Esercizio 1: La variante senza segno del tipo int quale è secondo te?
    // Risposta:   
    
    // Per tanto tempo la variabile intera sufficiente per fare molte cose è stato l'intero
    // ed è ancora il tipo di variabile più usato per le operazioni normali.
    // In alcuni casi serve un intero più grande ancora, pensa alle dimensioni dei file ad esempio:
    // Se usassimo un int per contenere la dimensione di un file, arriviamo fino a 2 miliardi, cioè 2 Gigabyte
    // e non potremmo avere file più grandi di così.
    // Entra in gioco qui la stessa mente super originale che ha pensato all'uguale per fare l'assegnazione:
    // Se quello più piccolo di int si chiama short, quello più grande si chiamerà, rullo di tamburi...
    long variabile_long = 9223372036854775807;
    // Eh si, chi l'avrebbe mai detto. 
    // La variabile long occupa il doppio di int, cioè 8 byte.
    // I valori di un long sono abbastanza grandi, vanno da -9223372036854775808 a 9223372036854775807
    // Cioè circa 9 miliardi di miliardi in negativo e in positivo
    // Oppure con la variante ulong, perdiamo il segno ma raddoppiamo la capacità dei valori positivi
    ulong variabile_ulong = 18446744073709551615;

    // Esercizio 2: Prova a aumentare di 1 il valore assegnato a questa variabile ulong, cosa ti dice il compilatore?
    ulong variabile_ulong_2_il_ritorno = 18446744073709551615;
    
    // Passiamo ora ai numeri con la virgola.
    // Per rappresentare i numeri con la virgola 
    float variabile_a_virgola_mobile_con_precisione_singola = 6.123456f; // Notare la f alla fine che significa appunto float
    double variabile_a_virgola_mobile_con_precisione_doppia = 6.123456789012345; // Qui non c'è perché vogliamo un valore double


    // Perché si chiama a virgola mobile e perché abbiamo bisogno di un tipo a precisione doppia?
    // Questo è un discorso abbastanza lungo e complicato, pensa solo al fatto che ci sono infiniti numeri con la virgola
    // ma il computer ha memoria infinita?

    // Un tipo particolare è il tipo boolean, che rappresenta solo due valori: vero e falso
    // Questo tipo di variabile serve per tenere il risultato di una condizione, che può essere appunto o vera o falsa.
    bool valore_bool_true = true;
    bool valore_bool_false = false;

    // E oraaaa i testi!
    // Per i testi ci sono due tipi di variabili: char e string

    // La variabile char può contenere un solo carattere, i caratteri si rappresentano con gli apici singoli
    char variabile_char = 'w';

    // La variabile string invece può contenere un testo qualsiasi
    string variabile_string = "Ciao sono Giansasso Elicotteraio";

    // Compreso il valore stringa vuota
    string variabile_string_vuota = "";

    // Esercizio 3: Quale è la differenza tra questi due valori?
    // Valore 1: "75"
    // Valore 2: 75

  }
}