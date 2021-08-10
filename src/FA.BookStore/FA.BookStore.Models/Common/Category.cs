using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.BookStore.Models
{
    [Table("Categories", Schema = "common")]
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Please enter {0}.")]
        [StringLength(255, ErrorMessage = "The {0} must be between 2 and 1 characters.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter {0}.")]
        [StringLength(255, ErrorMessage = "The {0} must be between 2 and 1 characters.", MinimumLength = 3)]
        public string UrlSlug { get; set; }

        [MaxLength(500, ErrorMessage = "The {0} less than {1} characters.")]
        public string Description { get; set; }
    }
}
