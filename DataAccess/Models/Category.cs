using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Name")]
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Display Order")]
        public string CategoryName { get; set; }

        [Range(1, 100, ErrorMessage = "Display Order Must Be Between 1 and 100 only")]
        public int DisplayOrder { get; set; }

    }
}
