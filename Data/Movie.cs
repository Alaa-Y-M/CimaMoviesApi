using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CimaMoviesApi.Data;
public class Movie
{
    public long Id { get; set; }

    [Required]
    public string MovieName { get; set; } = null!;

    [Required]
    public string MovieStory { get; set; } = null!;

    [Required]
    public string MovieTrailer { get; set; } = null!;

    [Required]
    public string MoviePost { get; set; } = null!;

    [Required]
    public int SubCategoryId { get; set; }
    [ForeignKey("SubCategoryId")]
    public SubCategory SubCategory { get; set; } = null!;
}
