
using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.DTOs;

public sealed class CreateBlogpostRequest : IValidatableObject
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Titel { get; set; } = string.Empty;

    [Required]
    [StringLength(20000, MinimumLength = 10)]
    public string Inhoud { get; set; } = string.Empty;

    [Required]
    public DateOnly? Publicatiedatum { get; set; }

    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        if (!string.IsNullOrWhiteSpace(Titel) &&
            Titel.Trim().Length < 2)
        {
            yield return new ValidationResult(
                "Titel moet minimaal 2 tekens bevatten na het verwijderen van spaties.",
                [nameof(Titel)]);
        }

        if (!string.IsNullOrWhiteSpace(Inhoud) &&
            Inhoud.Trim().Length < 10)
        {
            yield return new ValidationResult(
                "Inhoud moet minimaal 10 tekens bevatten na het verwijderen van spaties.",
                [nameof(Inhoud)]);
        }

        if (Publicatiedatum == DateOnly.MinValue)
        {
            yield return new ValidationResult(
                "Publicatiedatum is ongeldig.",
                [nameof(Publicatiedatum)]);
        }
    }
}
