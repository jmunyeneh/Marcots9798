using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class Months
    {
        public Months()
        {
            Person = new HashSet<Person>();
        }
        [Key]
        public int MonthId { get; set; }
        [Display(Name="Birth Month")]
        public string MonthName { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
