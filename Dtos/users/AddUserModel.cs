using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.users;
public class AddUserModel
{
    [StringLength(256), Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [StringLength(256), Required]
    public string UserName { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    public bool EmailConfirmed { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; } = null!;
}
