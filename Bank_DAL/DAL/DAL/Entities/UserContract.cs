using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class UserContract
    {
        public int Id { get; set; }
        public int? UserInterviewerId { get; set; }
        public int? UserEmployeeId { get; set; }
        public double Salary { get; set; }
        public string ContractFilePath { get; set; }
        public virtual User User { get; set; }
        public virtual Deposit Deposit { get; set; }
    }
}
