using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Display Order must be 1-100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }



    }
}
