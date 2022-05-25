using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CimaMoviesApi.Data;
public class MovieActor
{
    public long Id { get; set; }

    [Required]
    public int ActorId { get; set; }
    [ForeignKey("ActorId")]
    public Actor Actor { get; set; } = null!;

    [Required]
    public long MovieId { get; set; }
    [ForeignKey("MovieId")]
    public Movie Movie { get; set; } = null!;
}
