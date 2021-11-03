using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Login is required")] [MaxLength(50)] public string Login { get; set; }
        [Required(ErrorMessage = "Password is required")] [MaxLength(50)] public string Password { get; set; }
        public bool IsDeleted { get; set; }
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy HH:mm}")] public DateTime HireDate { get; set; }
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")] public DateTime? VacationStart { get; set; }
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")] public DateTime? VacationEnd { get; set; }
        public string UserPosition { get; set; }        //enum
        public int? UserAccess { get; set; }             //enum number
        public int? UserContractID { get; set; }
        [ForeignKey("UserContractID")]
        public virtual UserContract UserContract { get; set; }
        public virtual ICollection<PersonalInfo> Personal_Info { get; set; } = new HashSet<PersonalInfo>();
        public virtual ICollection<Pact> Pacts { get; set; } = new HashSet<Pact>();
        
        
    }
}
