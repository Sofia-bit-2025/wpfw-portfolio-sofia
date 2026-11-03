namespace PortfolioApi.DTOs;

public sealed record ProjectResponse(
    int Id,
    string Titel,
    string Beschrijving,
    string Categorie,
    string GitHubUrl,
    DateOnly Datum,
    string Status,
    IReadOnlyList<string> Technologieen,
    IReadOnlyList<string> TechnischeDetails);


