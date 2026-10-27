
using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.DTOs;

public sealed class CreateProjectRequest
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Titel { get; set; } = string.Empty;
}

[Required]
    [StringLength(4000, MinimumLength = 5)]
    public string Beschrijving { get; set; } = string.Empty;

    [Required]
    [Url]
    [StringLength(2048)]
    public string GitHubUrl { get; set; } = string.Empty;