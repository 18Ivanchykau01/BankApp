using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class Deposit
    {
        [Key]
        public int Id { get; set; }
        public int? PactId { get; set; }
        [ForeignKey("PactId")]
        public virtual Pact Pact { get; set; }
        public int? UserContractId { get; set; }
        [ForeignKey("UserContractId")]
        public virtual UserContract UserContract { get; set; }
        public string Description { get; set; }
        public double AccountMoney { get; set; }
        public double? Procent { get; set; }
        public virtual ICollection<Card> Cards { get; set; } = new HashSet<Card>();
        
    }
}
