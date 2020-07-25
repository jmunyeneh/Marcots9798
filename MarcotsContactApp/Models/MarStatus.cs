using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class MarStatus
    {
        public MarStatus()
        {
            Person = new HashSet<Person>();
        }
        
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
