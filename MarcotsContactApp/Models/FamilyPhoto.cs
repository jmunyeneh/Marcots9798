using System;
using System.Collections.Generic;

namespace MarcotsContactApp.Models
{
    public partial class FamilyPhoto
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? PhotoId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
