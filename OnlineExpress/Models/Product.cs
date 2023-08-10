using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExpress.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        [Required,MinLength(4,ErrorMessage ="Min length is 4")]
        //[Column(TypeName ="decimal(8,2")]
        public decimal Price { get; set;}
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
    }
}
