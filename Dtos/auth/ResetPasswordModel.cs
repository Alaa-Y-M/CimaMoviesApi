using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.auth;
public class ResetPasswordModel
{
    [Required]
    public string Id { get; set; } = null!;

    [Required]
    public string Token { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}
