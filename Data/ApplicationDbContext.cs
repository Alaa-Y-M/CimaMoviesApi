using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CimaMoviesApi.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Category> Categories { get; set; }=null!;
    public DbSet<SubCategory> SubCategories { get; set; }=null!;
    public DbSet<Movie> Movies { get; set; }=null!;
    public DbSet<MovieActor> MovieActors { get; set; }=null!;
    public DbSet<Actor> Actors { get; set; }=null!;
    public DbSet<MovieLink> MovieLinks { get; set; }=null!;
}