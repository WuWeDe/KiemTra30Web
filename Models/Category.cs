using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Category
    {
        #pragma warning disable CS8618
        public int ID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        //public List<News> News{get; set;}
    }
}