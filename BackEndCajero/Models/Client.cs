using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndCajero.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }
        public List<Account> Acounts { get; set; }
        public bool Deleted { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
