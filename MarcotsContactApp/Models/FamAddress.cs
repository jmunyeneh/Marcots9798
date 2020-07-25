using System;
using System.Collections.Generic;

namespace MarcotsContactApp.Models
{
    public partial class FamAddress
    {
        public int Id { get; set; }
        public int AddrId { get; set; }
        public int PersonId { get; set; }

        public virtual Adddress Addr { get; set; }
        public virtual Person Person { get; set; }
    }
}
