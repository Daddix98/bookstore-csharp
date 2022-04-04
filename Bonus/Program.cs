// See https://aka.ms/new-console-template for more information

         

//--BONUS--

Console.WriteLine("--ESERCIZIO BONUS--");

//CHIEDO ALL'UTENTE DI INSERIRE LE INFORMAZIONI SU UN LIBRO DI SUA SCELTA 

Console.WriteLine("Inserisci Titolo:");
string titoloUtente = Console.ReadLine();

Console.WriteLine("Inserire Nome autore:");
string nomeAutore = Console.ReadLine();

Console.WriteLine("Inserire ISBN:");
long ISBN = long.Parse(Console.ReadLine());

Console.WriteLine("Inserire Numero Pagine:");
int numeroPagine = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire Peso Libro (gm):");
int pesoLibro = int.Parse(Console.ReadLine());

Console.WriteLine("Inserire Larghezza Libro:");
double larghezzaLibro = double.Parse(Console.ReadLine());

Console.WriteLine("Inserire Altezza Libro:");
double altezzaLibro = double.Parse(Console.ReadLine());

Console.WriteLine("Inserire Spessore Libro:");
double spessoreLibro = double.Parse(Console.ReadLine());

Console.WriteLine("Valutazione Media:");
float valutazioneMedia = float.Parse(Console.ReadLine());

Console.WriteLine("Desidera Versione Kidle ?(SI/NO):");
string versionKidle = Console.ReadLine();

Console.WriteLine("Desidera Copertina Flessibile ?(SI/NO):");
string tipoCopertina = Console.ReadLine();



