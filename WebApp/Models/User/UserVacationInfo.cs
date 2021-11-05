using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.User
{
    public class UserVacationInfo
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")] public DateTime VacationStart { get; set; }
        [DisplayFormat(DataFormatString = "{MM-dd-yyyy}")] public DateTime VacationEnd { get; set; }
        public string ContactMail { get; set; }
        public string Phone { get; set; }
    }
}
