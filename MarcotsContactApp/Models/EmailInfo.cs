using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarcotsContactApp.Models
{
    public class EmailInfo
    {
        public string Name { get; set; }
        [Required]       
        [DataType(DataType.EmailAddress,ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
