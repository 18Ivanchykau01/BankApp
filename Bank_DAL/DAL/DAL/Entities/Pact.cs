using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;


namespace DAL.Entities
{
    public class Pact
    {
        [Key]
        public int Id { get; set; }
        public int Client_Id { get; set; }
        [ForeignKey("ClientID")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public string FilePath { get; set; }
        [DataType(DataType.Date)][DisplayFormat(DataFormatString = "{dd-MM-yyyy HH:mm}")]
        public DateTime OpenDate { get; set; }
        public string Status { get; set; }
        public virtual Deposit Deposits { get; set; }
        public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();
         
    }
}
