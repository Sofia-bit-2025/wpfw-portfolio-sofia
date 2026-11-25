using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.DTOs;

public sealed class RegisterRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
