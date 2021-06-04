using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    public class ProdottiInVendita : IECommerce
    {
        public int Codice { get; set; }
        public String Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int PercentualeSconto { get; set; }

        public static void AggiungiAlCarrello(Dictionary<int, ProdottiInVendita> prodottiInVendita, 
            Dictionary<Utente, List<ProdottiInVendita>> prodottiNelCarrello, Utente utente)
        {
            bool continua = false;
            while (!continua)
            {
                Console.WriteLine("Che prodotto vuoi aggiungere al carrello?");
                foreach (var item in prodottiInVendita)
                {
                    Console.WriteLine(item.Value);
                }
                Console.WriteLine("Inserisci il codice corrispondente");
                bool success = Int32.TryParse(Console.ReadLine(), out int codice);
                while (!success || !prodottiInVendita.ContainsKey(codice))
                {
                    Console.WriteLine("Non hai inserito un codice valido");
                    success = Int32.TryParse(Console.ReadLine(), out codice);
                }
                prodottiNelCarrello[utente].Add(prodottiInVendita[codice]);
                //andrebbe fatto un controllo in modo più elegante
                Console.WriteLine("Vuoi aggiungere altri prodotti?\n1 per continuare\n2 per terminare");
                int scelta = Convert.ToInt32(Console.ReadLine());
                if(scelta==1)
                {
                    continua = false;
                }else if (scelta == 2)
                {
                    continua = true;
                }

            }

        }


        //qui vanno implementati altri due metodi dell'interfaccia
        public static void EliminaDaCarrello()
        {
            throw new NotImplementedException();
        }

        public static void ModificaQuantità()
        {
            throw new NotImplementedException();
        }


        public double CalcoloSconto()
        {
            double prezzoScontato = Prezzo - ((Prezzo * PercentualeSconto) / 100);
            return prezzoScontato;
        }

       
        public override string ToString()
        {
            return $"Codice: {Codice} -- Descrizione: {Descrizione} -- Prezzo: {Prezzo} -- Sconto: {PercentualeSconto} -- ";
        }
    }
}
