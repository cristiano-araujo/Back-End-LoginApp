using System;
using System.Data;

namespace Register.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Telefone { get; set; }
        public string Genero { get; set; }
        public string Pwd { get; set; }
        public DateTime MenberSince { get; set; } 
    }
}
