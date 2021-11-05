using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBankApp.Models.Login
{
    public class LoginView
    {
        [Required]
        public string Login { get; set; }

        [Required][DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
