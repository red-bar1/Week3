using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    public class Abbigliamento : ProdottiInVendita
    {        
        public String Taglia { get; set; }
        public String Brand { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $"Taglia: {Taglia} -- Brand: {Brand}";
        }

    }
}
