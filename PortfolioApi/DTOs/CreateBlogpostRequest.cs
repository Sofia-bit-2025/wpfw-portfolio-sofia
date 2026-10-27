
using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.DTOs;

public sealed class CreateBlogpostRequest
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Titel { get; set; } = string.Empty;

    [Required]
    [StringLength(20000, MinimumLength = 10)]
    public string Inhoud { get; set; } = string.Empty;

    [Required]
    public DateOnly? Publicatiedatum { get; set; }
}
