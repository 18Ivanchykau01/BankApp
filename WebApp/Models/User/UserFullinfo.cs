using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Attributes.Models;

namespace WebApp.Models.User
{
    public class UserFullinfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")] 
        [MaxLength(30)] 
        [RegularExpression("[A-Z]+[a-z]", ErrorMessage = "First name can only contain letters")]
        public string FirstName { get; set; }

        [MaxLength(50)][Default] 
        public string MiddleName { get; set; }

        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Serial_Number { get; set; }
        public string Gender { get; set; }
        [Required()] [MaxLength(50)] public string Mail { get; set; }
        [Required(ErrorMessage = "Phone is required")] public string Phone { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }

    }
}
