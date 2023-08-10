using System.ComponentModel.DataAnnotations;

namespace OnlineExpress.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
