using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class Photo
    {
        public Photo()
        {
            FamilyPhoto = new HashSet<FamilyPhoto>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public bool? MyPicture { get; set; }

        public virtual ICollection<FamilyPhoto> FamilyPhoto { get; set; }
    }
}
