using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesInfoApp.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string Poster_Link { get; set; }

        public string Title { get; set; }
        public string Year { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Runtime { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Genre { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Rating { get; set; }
        public string Description { get; set; }
        public string? Meta_score { get; set; } = string.Empty;
        public string Director { get; set; }
        public string Star1 { get; set; }
        public string Star2 { get; set; }
        public string Star3 { get; set; }
        public string Star4 { get; set; }
        public string? Gross { get; set; }


    }
}
