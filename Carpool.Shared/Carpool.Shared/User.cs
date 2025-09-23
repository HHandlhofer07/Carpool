using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Shared
{
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Klasse { get; set; }
            public int Jahrgang { get; set; }
            public string Email { get; set; }
            public string PasswordHash { get; set; } 
            public string Adresse { get; set; }
            public string Telefonnummer { get; set; }
        }
}
