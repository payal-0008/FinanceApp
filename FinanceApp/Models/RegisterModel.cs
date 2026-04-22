using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Models
{
    public class RegisterModel
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Password { get; set; }
    }
}
