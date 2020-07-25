using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarcotsContactApp.Models
{
    public class ContactsDTO
    {
        public int PersonId { get; set; }
        [Display(Name ="Submited Status")]
        public ContactStatus ContactStatus { get; set; }
        [Display(Name = "Birth Month")]
        public string MonthName { get; set; }
        public string OwnerId { get; set; }       
        public string FirstName { get; set; }       
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Telephone { get; set; }
        public int? Kids { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Description { get; set; }
        public int?  BirthDay { get; set; }
        public string BirthMonth { get; set; }
        [Display(Name = "Marital Status")]
        public string MaritalDesc { get; set; }

    }
}
