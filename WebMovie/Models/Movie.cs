using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString ="{0:N0}")]
        public decimal Price { get; set; }
    }
}
