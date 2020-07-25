using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class Days
    {
        public Days()
        {
            Person = new HashSet<Person>();
        }
        [Key]
        public int DayId { get; set; }
        public int? DayNum { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
