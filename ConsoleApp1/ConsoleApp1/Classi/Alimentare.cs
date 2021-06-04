using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    public class Alimentare : ProdottiInVendita
    {
        public DateTime Scadenza { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $"Scadenza: {Scadenza}";
        }
    }
}
