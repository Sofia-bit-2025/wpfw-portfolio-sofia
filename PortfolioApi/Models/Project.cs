
namespace PortfolioApi.Models;

public sealed class Project
{
    public int Id { get; set; }

    public string Titel { get; set; } = string.Empty;

    public string Beschrijving { get; set; } = string.Empty;

    public string Categorie { get; set; } = string.Empty;

    public string GitHubUrl { get; set; } = string.Empty;

    public DateOnly Datum { get; set; }

    public string Status { get; set; } = "In ontwikkeling";

    public List<string> Technologieen { get; set; } = [];

    public List<string> TechnischeDetails { get; set; } = [];
}
