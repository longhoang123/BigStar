

using System.ComponentModel.DataAnnotations;

namespace BigStar.Models.Data
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int LikeCount { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
