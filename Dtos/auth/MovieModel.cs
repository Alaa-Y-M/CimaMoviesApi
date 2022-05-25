

using CimaMoviesApi.Data;

namespace CimaMoviesApi.Dtos.auth;
public class MovieModel
{
    public Movie Movie { get; set; }=null!;
    public IEnumerable<MovieActor> Actors { get; set; }=null!;
    public IEnumerable<MovieLink> Links { get; set; }=null!;
}
