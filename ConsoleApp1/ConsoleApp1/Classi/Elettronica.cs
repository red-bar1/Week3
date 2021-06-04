using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    public class Elettronica : ProdottiInVendita
    {
        public String Produttore { get; set; }

        public override string ToString()
        {
            return base.ToString()+$"Produttore: {Produttore}";
        }
    }
}
