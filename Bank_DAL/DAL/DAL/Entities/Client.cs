using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy HH:mm}")]
        public DataType RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<PersonalInfo> Personal_Info { get; set; } = new HashSet<PersonalInfo>();
        public virtual ICollection<Pact> Pacts { get; set; } = new HashSet<Pact>();
        public virtual ICollection<Card> Cards { get; set; } = new HashSet<Card>();
    }
}
