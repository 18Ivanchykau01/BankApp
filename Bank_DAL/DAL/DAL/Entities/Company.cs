using DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public Client Contact_Person { get; set; }
        public string Company_name { get; set; }  
        public int PactId { get; set; }
        [ForeignKey("PactId")]
        public virtual Pact Pact { get; set; }
    }
}
