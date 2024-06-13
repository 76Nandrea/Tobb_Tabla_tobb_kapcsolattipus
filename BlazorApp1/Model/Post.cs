using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string? Content { get; set; }

        //több az egyhez viszony (külső kulcs)
        public int Userid { get; set; }

        public virtual User?  User { get; set; }
    }
}
