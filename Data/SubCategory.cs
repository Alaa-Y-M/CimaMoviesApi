using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CimaMoviesApi.Data;
public class SubCategory
{
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string SubCategoryName { get; set; } = null!;

    [Required]
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category Category { get; set; } = null!;
}
