
using CimaMoviesApi.Data;
using CimaMoviesApi.Dtos.auth;
using Microsoft.AspNetCore.Mvc;

namespace CimaMoviesApi.Services.Home;
public interface IHomeRepository
{
    Task<IEnumerable<SubCategory>> GetSubCategoriesAsync();
    Task<IEnumerable<Movie>> GetMoviesAsync(string search);
    Task<ActionResult<MovieModel>> GetMovieAsync(long id);
    Task<IEnumerable<MovieActor>> GetMoviesByActorAsync(int id);
}
