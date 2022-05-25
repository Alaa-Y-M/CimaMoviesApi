using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Data;
public class Category
{
    public int Id { get; set; }

    [Required, StringLength(150)]
    public string CategoryName { get; set; } = null!;
}
