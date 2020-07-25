using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarcotsContactApp.Models
{
    public partial class Person
    {
        public Person()
        {
            FamAddress = new HashSet<FamAddress>();
            FamilyPhoto = new HashSet<FamilyPhoto>();
        }        
        public int PersonId { get; set; }
        public string OwnerId { get; set; }
        public string FullName => FirstName + " " + LastName;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MidName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        public string NickName { get; set; }
        [Display(Name= "Life Philosophy")]
        public string Description { get; set; }
        public string Telephone { get; set; }
        [Required]
        public int? Kids { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Occupation { get; set; }
        [Required]
        [Display(Name="Marital Status")]
        public int? StatusId { get; set; }
        [Display(Name= "Birth Day")]
        public int? BirthDay { get; set; }
        [Display(Name = "Birth Month")]
        public int? BirthMonth { get; set; }
        public DateTime? InsertedDate { get; set; } 
        public DateTime? ModifiedDate { get; set; }      
        [Display(Name = "Approval Status")]
        public ContactStatus ContactStatus { get; set; }
        public virtual Days BirthDayNavigation { get; set; }
        public virtual Months BirthMonthNavigation { get; set; }
       
        public virtual MarStatus Status { get; set; }
        public virtual ICollection<FamAddress> FamAddress { get; set; }
        public virtual ICollection<FamilyPhoto> FamilyPhoto { get; set; }

        #region image 
        //<img class="img img-thumbnail" src="@recipe.GetInlineImageSrc()"/>
        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }

        public string GetInlineImageSrc()
        {
            if (Image == null || ImageContentType == null)
                return null;

            var base64Image = System.Convert.ToBase64String(Image);
            return $"data:{ImageContentType};base64,{base64Image}";
        }

        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {
            if (file == null)
                return;

            ImageContentType = file.ContentType;

            using (var stream = new System.IO.MemoryStream())
            {
                file.CopyTo(stream);
                Image = stream.ToArray();
            }
        }

        #endregion
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
