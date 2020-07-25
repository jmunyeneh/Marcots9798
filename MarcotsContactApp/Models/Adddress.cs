using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class Adddress
    {
        public Adddress()
        {
            FamAddress = new HashSet<FamAddress>();
        }
        [Key]
        public int AddrId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<FamAddress> FamAddress { get; set; }
    }
}
