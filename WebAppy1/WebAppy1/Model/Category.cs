using System.ComponentModel.DataAnnotations;

namespace WebAppy1.Model
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int displayorder { get; set; }
    }
}
