using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public abstract class Address
    {

       [RegularExpression(@"^[a-zA-Z0-9._%+-]+@contoso\.edu$", ErrorMessage = "This is an invalid email address.")]
        public string Email { get; set; }
    }


}