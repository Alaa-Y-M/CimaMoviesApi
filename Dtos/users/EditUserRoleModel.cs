using System.ComponentModel.DataAnnotations;

namespace CimaMoviesApi.Dtos.users;
public class EditUserRoleModel
{
    [Required]
    public string UserId { get; set; } = null!;

    [Required]
    public string RoleId { get; set; } = null!;
}