using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public enum UserAccess
    {
        Teller = 1, 
        Credit_Expert,
        Bookkeeper, 
        Financial_Analyst,
        Auditor,
        DepartmentHead,
        BankManager
    }
}
