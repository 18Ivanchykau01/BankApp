using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Audit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Report_theme { get; set; }
        public string ReportFilePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        
    }
}
