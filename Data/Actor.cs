using System.ComponentModel.DataAnnotations;
namespace CimaMoviesApi.Data;
public class Actor
{
    public int Id { get; set; }

    [Required]
    public string ActorName { get; set; } = null!;

    public string ActorPicture { get; set; } = null!;
}
