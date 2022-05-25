using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.auth;
public class LoginModel
{
    [StringLength(256), Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    public bool RememberMe { get; set; }
}
