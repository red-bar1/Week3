using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    //ho deciso di implementare ECommerce come interfaccia perché
    //immagino possa essere implementata da diverse app di e-commerce
    public interface IECommerce
    {
        static void AggiungiAlCarrello(Dictionary<int, ProdottiInVendita> prodottiInVendita,
            Dictionary<Utente, List<ProdottiInVendita>> prodottiNelCarrello, Utente utente) { }
        static void EliminaDaCarrello() { }
        static void ModificaQuantità() { }
    }
}
