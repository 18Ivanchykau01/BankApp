using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DAL.Entities
{
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")] [MaxLength(50)] public string FirstName { get; set; }
        [Default] [MaxLength(50)] public string MiddleName { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
        [Required(ErrorMessage = "LastName is required")] [MaxLength(50)] public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Serial_Number { get; set; }
        public string Gender { get; set; }
        [Required()] [MaxLength(50)] public string Mail { get; set; }
        [Required(ErrorMessage = "Phone is required")] public string Phone { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class Default : Attribute
    {
        public string Text { get; private set; }
        public Default(string text)
        {
            Text = text;
        }
        public Default()
        {
            Text = "(not exist)";
        }
    }
}
