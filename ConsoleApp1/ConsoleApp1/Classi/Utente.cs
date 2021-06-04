using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classi
{
    public class Utente
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String NomeCognome { get; set; }

        public Utente(string username, string password, string nomeCognome)
        {
            Username = username;
            Password = password;
            NomeCognome = nomeCognome;
        }

    }
}
