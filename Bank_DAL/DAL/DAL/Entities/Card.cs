using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Issuer { get; set; }
        public int Number { get; set; }
        [DisplayFormat(DataFormatString = "{MM/yy}")]
        public DateTime ExpiratuionDate { get; set; }
        public string HolderName { get; set; }
        public string Network { get; set; }
        public int CVV { get; set; }  
        public double Cash { get; set; }
    }
}
