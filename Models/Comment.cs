using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Comment
    {
        public int ID { get; set; }

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

         [DataType(DataType.Date)]
        public DateTime CreatAt { get; set; }

        


       
     
        
    }
}