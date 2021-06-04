using ConsoleApp1.Classi;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utente utente = new Utente("Mario88", "password", "Mario Rossi");
            

            var utentiRegistrati = new Dictionary<string, Utente>();
            utentiRegistrati.Add(utente.Username + utente.Password, utente); //in questo modo l'utente è identificato univocamente
                                                                             //dalla somma del nome utente e password
            
            Console.WriteLine("Inserire Username:");
            string nomeUtente = Console.ReadLine();
            Console.WriteLine("Inserire Password:");
            string password = Console.ReadLine();
            while(!utentiRegistrati.ContainsKey(nomeUtente + password))
            {
                Console.WriteLine("Nome Utente e/o Password errati. Inserire di nuovo i dati.");
                Console.WriteLine("Inserire Username:");
                nomeUtente = Console.ReadLine();
                Console.WriteLine("Inserire Password:");
                password = Console.ReadLine();
            }

            int scelta = SchermoMenu();
            AnalizzaScelta(scelta, utente);



        }

        public static void AnalizzaScelta(int scelta, Utente utente)
        {
            //questo andrebbe implementato con un metodo, al momento inserisco brutalmente qui
            var prodottiInVendita = new Dictionary<int, ProdottiInVendita>();
            prodottiInVendita.Add(100, new Alimentare()
            {
                Codice = 100,
                Descrizione = "pasta",
                Prezzo = 0.5,
                PercentualeSconto = 20,
                Scadenza = DateTime.Today
            });
            prodottiInVendita.Add(200, new Abbigliamento()
            {
                Codice = 200,
                Descrizione = "maglietta",
                Prezzo = 12,
                PercentualeSconto = 30,
                Brand = "Vans",
                Taglia = "XS"
            });
            prodottiInVendita.Add(300, new Elettronica()
            {
                Codice = 300,
                Descrizione = "smartphone",
                Prezzo = 249.99,
                PercentualeSconto = 50,
                Produttore = "Samsung"
            });

            var prodottiNelCarrello = new Dictionary<Utente, List<ProdottiInVendita>>();
            switch (scelta)
            {
                case 1:
                    //aggiungi al carrello
                    prodottiNelCarrello.Add(utente, new List<ProdottiInVendita>());
                    ProdottiInVendita.AggiungiAlCarrello(prodottiInVendita, prodottiNelCarrello, utente);
                    break;
                case 2:
                    //elimina prodotto
                    break;
                case 3:
                    //modifica quantità
                    break;
                case 4:
                    //riepilogo
                    break;
                case 5:
                    Console.WriteLine("Arrivederci");
                    break;
            }
        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Aggiungi prodotto al carrello\n2. Elimina prodotto\n" +
                "3. Modifica la quantità di un prodotto già inserito\n4. Riepilogo\n5. Esci");
            bool success = Int32.TryParse(Console.ReadLine(), out int scelta);
            while(!success || scelta == 0 || scelta > 5)
            {
                Console.WriteLine("Inserisci una tra le opzioni indicate");
                Console.WriteLine("1. Aggiungi prodotto al carrello\n2. Elimina prodotto\n" +
                "3. Modifica la quantità di un prodotto già inserito\n4. Riepilogo\n5. Esci");
                success = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            return scelta;
        }
    }
}
