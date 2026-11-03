
using System.ComponentModel.DataAnnotations;

namespace PortfolioApi.DTOs;

public sealed class CreateProjectRequest : IValidatableObject
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Titel { get; set; } = string.Empty;

    [Required]
    [StringLength(4000, MinimumLength = 5)]
    public string Beschrijving { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Categorie { get; set; } = string.Empty;

    [Required]
    [Url]
    [StringLength(2048)]
    public string GitHubUrl { get; set; } = string.Empty;

    [Required]
    public DateOnly? Datum { get; set; }

    [Required]
    [StringLength(60)]
    public string Status { get; set; } = "In ontwikkeling";

    public List<string>? Technologieen { get; set; } = [];

    public List<string>? TechnischeDetails { get; set; } = [];

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

        if (!string.IsNullOrWhiteSpace(Beschrijving) &&
            Beschrijving.Trim().Length < 5)
        {
            yield return new ValidationResult(
                "Beschrijving moet minimaal 5 tekens bevatten na het verwijderen van spaties.",
                [nameof(Beschrijving)]);
        }

        if (!string.IsNullOrWhiteSpace(Categorie) &&
            Categorie.Trim().Length < 2)
        {
            yield return new ValidationResult(
                "Categorie moet minimaal 2 tekens bevatten na het verwijderen van spaties.",
                [nameof(Categorie)]);
        }

        if (Datum == DateOnly.MinValue)
        {
            yield return new ValidationResult(
                "Datum is ongeldig.",
                [nameof(Datum)]);
        }
    }
}
