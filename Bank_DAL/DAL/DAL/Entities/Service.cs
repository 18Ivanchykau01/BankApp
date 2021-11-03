using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
    }
}
