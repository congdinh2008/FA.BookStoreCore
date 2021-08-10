using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.BookStore.Models
{
    [Table("Books", Schema = "common")]
    public class Book : BaseEntity
    {
        [Required(ErrorMessage = "Please enter {0}.")]
        [StringLength(255, ErrorMessage = "The {0} must be between 2 and 1 characters.", MinimumLength = 3)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter {0}.")]
        [StringLength(255, ErrorMessage = "The {0} must be between 2 and 1 characters.", MinimumLength = 3)]
        public string UrlSlug { get; set; }

        [MaxLength(500, ErrorMessage = "The {0} less than {1} characters.")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Please enter book image path.")]
        [Display(Name = "Image Thumbnail")]
        public string ImgUrl { get; set; }

        [Required(ErrorMessage = "Please enter book price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Quantity")]
        [DefaultValue(0)]
        public int Quantity { get; set; }

        [Display(Name = "Is Active?")]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
