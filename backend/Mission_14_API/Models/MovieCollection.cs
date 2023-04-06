using System.ComponentModel.DataAnnotations;

namespace Mission_14_API.Models
{
    public class MovieCollection
    {
        [Key]
        public int MovieId { get; set; }
        public string Category { get; set; }
        public string title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string? Rating { get; set; }
        public string? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }

    }
}
