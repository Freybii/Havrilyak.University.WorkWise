﻿ using System.ComponentModel.DataAnnotations;
using WorkWise.Controllers;

namespace WorkWise.Databases.Models
{
    public class User
    {
        public int Id { get; set; }

        
        public string? FirstName { get; set; }

        
        public string? LastName { get; set; }

        
        public string? Email { get; set; }

        
        public string? Phone { get; set; }

        
        public string? Password { get; set; }
    }

}
