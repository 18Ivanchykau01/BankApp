using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Attributes.Models;

namespace WebApp.Models.User
{
    public class UserShortInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Default] public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }

    }
}
