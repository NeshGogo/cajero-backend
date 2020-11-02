using System.ComponentModel.DataAnnotations;

namespace BackEndCajero.Models
{
    public class Account
    {
        [Key]
        public string AccountNo { get; set; }
        public double Balance { get; set; }
        public int ClientId { get; set; }
        public string Alias { get; set; }
        public Client Client { get; set; }
        public bool Deleted { get; set; }
    }
}