using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.auth;
public class RegisterModel
{
    [StringLength(256), Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [StringLength(256), Required]
    public string UserName { get; set; } = null!;

    [Required, DataType(DataType.Password)]
    public string Password { get; set; } = null!;
}
