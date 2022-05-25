using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.users;
public class UserRolesModel
{
    [Required]
    public string UserId { get; set; } = null!;

    [Required]
    public string UserName { get; set; } = null!;

    [Required]
    public string RoleId { get; set; } = null!;

    [Required]
    public string RoleName { get; set; } = null!;
}
