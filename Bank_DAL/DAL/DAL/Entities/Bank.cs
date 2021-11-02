using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        public string Filial_Agency_Name { get; set; }
        public string Filial_Agency_Location { get; set; }
        public virtual ICollection<UserContract> UsersContracts { get; set; } = new HashSet<UserContract>();
        public virtual ICollection<Pact> Pacts { get; set; } = new HashSet<Pact>();
    }
}
